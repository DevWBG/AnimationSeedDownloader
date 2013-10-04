using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Xml;

namespace AnimationDownloader
{
    static class Program
    {
        public static XmlTextReader Reader;
        public static XmlDocument Document;
        public static XmlNode Rss;
        public static XmlNode Channel;
        public static XmlNode Item;
        public static bool error;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
