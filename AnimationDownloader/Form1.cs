using System;
using System.IO;
using System.Net;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace AnimationDownloader
{

    public partial class Form1 : Form
    {
        string url = "http://tokyotosho.info/rss.php?filter=";
        string strPath = null;
        bool nInputOptionClear = false; // for Clear Print Text Box True false
        int nCheckBox = 0; // for Check box lease one
        RssReader rss;
        bool bCheckOpen = false;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void INPUT_PATH_Click(object sender, EventArgs e)
        {
            INPUTDOWNLOADPATH.ShowDialog();
            strPath = INPUTDOWNLOADPATH.SelectedPath;
        }

        private void INFO_DEV_Enter(object sender, EventArgs e)
        {

        }

        private void PRINT_OPTION_TextChanged(object sender, EventArgs e)
        {

        }

        private void INPUT_OPTION_Click(object sender, EventArgs e)
        { // Ahh... Fucking

            string tokyoURL = "http://tokyotosho.info/rss.php?filter=";

            CheckboxChecked Chbox = new CheckboxChecked(14, tokyoURL);

            int nTempIndex = 0;

            Chbox.InputCheckboxChecked(CH_ANIME, nTempIndex++, "Anime");
            Chbox.InputCheckboxChecked(CH_MUSIC, nTempIndex++, "Music");
            Chbox.InputCheckboxChecked(CH_MANGA, nTempIndex++, "Manga");
            Chbox.InputCheckboxChecked(CH_HENTAI, nTempIndex++, "Hentai");
            Chbox.InputCheckboxChecked(CH_OTHER, nTempIndex++, "Other");
            Chbox.InputCheckboxChecked(CH_RAWS, nTempIndex++, "Raws");
            Chbox.InputCheckboxChecked(CH_DRAMA, nTempIndex++, "Drama");
            Chbox.InputCheckboxChecked(CH_MVIDEO, nTempIndex++, "Music Video");
            Chbox.InputCheckboxChecked(CH_NONENG, nTempIndex++, "Non-English");
            Chbox.InputCheckboxChecked(CH_BATCH, nTempIndex++, "Batch");
            Chbox.InputCheckboxChecked(CH_HANIME, nTempIndex++, "Hentai Anime");
            Chbox.InputCheckboxChecked(CH_HMANGA, nTempIndex++, "Hentai Manga");
            Chbox.InputCheckboxChecked(CH_HGAMES, nTempIndex++, "Hentai Games");
            Chbox.InputCheckboxChecked(CH_JAV, nTempIndex++, "JAV");

            PRINT_OPTION.Clear();

            nTempIndex = 0;

            for (int i = 0; i < 14; i++ )
            {
                if(++nTempIndex == 6)
                {
                    nTempIndex = 7;
                }

                if(Chbox.returnCheckbox(i).Checked == true)
                {
                    PRINT_OPTION.AppendText("Select " + i + ". " + Chbox.returnCheckString(i) + "\n");
                    if(Chbox.returnURL() != tokyoURL)
                    {
                        Chbox.SetupURL("," + nTempIndex);
                    }
                    else
                    {
                        Chbox.SetupURL(nTempIndex.ToString());
                    }
                }
            }

            if (bCheckOpen)
            {
                PRINT_SEED.Items.Clear();
                bCheckOpen = false;
            }

            nInputOptionClear 
                = true;
            nCheckBox = 0;

            try
            {
                rss = new RssReader();
                rss.FeedUrl = url;
                foreach (RssItem item in rss.Execute())
                {
                    PRINT_SEED.Items.Add(item.Title);
                }
                url = "http://tokyotosho.info/rss.php?filter=";
                PRINT_OPTION.AppendText("Successfuly opening tokyotosho.info\n");
                bCheckOpen = true;
            }
            catch (Exception exc)
            {
                PRINT_OPTION.AppendText(exc.ToString());
                PRINT_OPTION.AppendText("\n\n\nCannot Connect tokyotosho.info\n");
            }
        }
        private void INPUTDOWNLOADPATH_HelpRequest(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://popnmusic.tistory.com/");
        }

        private void START_DOWNLOAD_Click(object sender, EventArgs e)
        {
            if (strPath == null){
                MessageBox.Show("Please setting Path first.", "Caution",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
            foreach (int nIndexChecked in PRINT_SEED.CheckedIndices)
            {
                DOWN_PROGRESS.Maximum = PRINT_SEED.CheckedIndices.Count;
                try
                {
                    new WebClient().DownloadFile(rss.Items[nIndexChecked].Link,
                        strPath + "\\" +rss.Items[nIndexChecked].Title + ".torrent");

                    DOWN_PROGRESS.Value = nIndexChecked;
                }
                catch (Exception exc)
                {
                    PRINT_OPTION.AppendText(exc.ToString());
                    DOWN_PROGRESS.Value = nIndexChecked;
                }
                
            }
            MessageBox.Show("Download Completed!");
            DOWN_PROGRESS.Value = 0;
        }
        }
}

class CheckboxChecked
{
    bool[] bCheckSelect;
    CheckBox[] Chboxs;
    string[] ChName;
    string url;

    public CheckboxChecked(int nMax, string tempurl)
    {
        bCheckSelect = new bool[nMax];
        Chboxs = new CheckBox[nMax];
        ChName = new string[nMax];
        url = tempurl;
    }

    public void InputCheckboxChecked(CheckBox Chbox, int nIndex, string name)
    {
        Chboxs[nIndex] = Chbox;
        ChName[nIndex] = name;
    }

    public CheckBox returnCheckbox(int nIndex)
    {
        return Chboxs[nIndex];
    }
    public string returnCheckString(int nIndex)
    {
        return ChName[nIndex];
    }
    public string returnURL()
    {
        return url;
    }
    public void SetupURL(string tempURL)
    {
        url += tempURL;
    }

}