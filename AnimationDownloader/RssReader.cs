#region Using

using System;
using System.Xml;
using System.Collections.ObjectModel;
using System.Web;
using System.Web.Caching;

#endregion

[Serializable]
public class RssReader : IDisposable
{

  #region Constructors

  public RssReader()
  { }

  public RssReader(string feedUrl)
  {
    _FeedUrl = feedUrl;
  }

  #endregion

  #region Properties

  private string _FeedUrl;

  public string FeedUrl
  {
    get { return _FeedUrl; }
    set { _FeedUrl = value; }
  }

  private Collection<RssItem> _Items = new Collection<RssItem>();

  public Collection<RssItem> Items
  {
    get { return _Items; }
  }

  private string _Title;

  public string Title
  {
    get { return _Title; }
  }

  private string _Description;

  public string Description
  {
    get { return _Description; }
  }

  private DateTime _LastUpdated;

  public DateTime LastUpdated
  {
    get { return _LastUpdated; }
  }

  private TimeSpan _UpdateFrequenzy;

  public TimeSpan UpdateFrequenzy
  {
    get { return _UpdateFrequenzy; }
  }

  #endregion

  #region Methods

  public static RssReader CreateAndCache(string feedUrl, TimeSpan updateFrequenzy)
  {
    if (HttpRuntime.Cache["RssReader_" + feedUrl] == null)
    {
      RssReader reader = new RssReader(feedUrl);
      reader.Execute();
      reader._UpdateFrequenzy = updateFrequenzy;
      HttpRuntime.Cache.Add("RssReader_" + feedUrl, reader, null, DateTime.Now.Add(updateFrequenzy), Cache.NoSlidingExpiration, CacheItemPriority.Normal, RefreshCache);
    }

    return (RssReader)HttpContext.Current.Cache["RssReader_" + feedUrl];
  }

  private static void RefreshCache(string key, object item, CacheItemRemovedReason reason)
  {
    if (reason != CacheItemRemovedReason.Removed)
    {
      string feedUrl = key.Replace("RssReader_", String.Empty);
      RssReader reader = new RssReader(feedUrl);
      reader.Execute();
      reader._UpdateFrequenzy = ((RssReader)item).UpdateFrequenzy;
      HttpRuntime.Cache.Add("RssReader_" + feedUrl, reader, null, DateTime.Now.Add(reader.UpdateFrequenzy), Cache.NoSlidingExpiration, CacheItemPriority.Normal, RefreshCache);
    }
  }

  public Collection<RssItem> Execute()
  {
    if (String.IsNullOrEmpty(FeedUrl))
      throw new ArgumentException("The feed url must be set");

    using (XmlReader reader = XmlReader.Create(FeedUrl))
    {
      XmlDocument doc = new XmlDocument();
      doc.Load(reader);

      ParseElement(doc.SelectSingleNode("//channel"), "title", ref _Title);
      ParseElement(doc.SelectSingleNode("//channel"), "description", ref _Description);
      ParseItems(doc);

      _LastUpdated = DateTime.Now;
      
      return _Items;
    }
  }

  private void ParseItems(XmlDocument doc)
  {
    _Items.Clear();
    XmlNodeList nodes = doc.SelectNodes("rss/channel/item");

    foreach (XmlNode node in nodes)
    {
      RssItem item = new RssItem();
      ParseElement(node, "title", ref item.Title);
      ParseElement(node, "description", ref item.Description);
      ParseElement(node, "link", ref item.Link);

      string date = null;
      ParseElement(node, "pubDate", ref date);
      DateTime.TryParse(date, out item.Date);

      _Items.Add(item);
    }
  }

  private void ParseElement(XmlNode parent, string xPath, ref string property)
  {
    XmlNode node = parent.SelectSingleNode(xPath);
    if (node != null)
      property = node.InnerText;
    else
      property = "Unresolvable";
  }

  #endregion

  #region IDisposable Members

  private bool _IsDisposed;

  private void Dispose(bool disposing)
  {
    if (disposing && !_IsDisposed)
    {
      _Items.Clear();
      _FeedUrl = null;
      _Title = null;
      _Description = null;
    }

    _IsDisposed = true;
  }

  public void Dispose()
  {
    Dispose(true);
    GC.SuppressFinalize(this);
  }

  #endregion

}

#region RssItem struct

[Serializable]
public struct RssItem
{
  public DateTime Date;

  public string Title;

  public string Description;

  public string Link;
}

#endregion