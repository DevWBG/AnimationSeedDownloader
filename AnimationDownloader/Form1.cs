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
using System.Runtime.InteropServices;

namespace AnimationDownloader
{
    public partial class Form1 : Form
    {
        
        string strPath = null;
        RssReader rss;
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);

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

            int nTemp = 0;
            PRINT_OPTION.Clear();
            bool CheckSelect = false;
            string TempURL = "http://tokyotosho.info/rss.php?filter=";

            CheckboxSelect Chbox = new CheckboxSelect(TempURL, 14);

            Chbox.InputCheckbox(nTemp++, CH_ANIME, "Anime");
            Chbox.InputCheckbox(nTemp++, CH_MUSIC, "Music");
            Chbox.InputCheckbox(nTemp++, CH_MANGA, "Manga");
            Chbox.InputCheckbox(nTemp++, CH_HENTAI, "Hentai");
            Chbox.InputCheckbox(nTemp++, CH_OTHER, "Other");
            Chbox.InputCheckbox(nTemp++, CH_RAWS, "Raws");
            Chbox.InputCheckbox(nTemp++, CH_DRAMA, "Drama");
            Chbox.InputCheckbox(nTemp++, CH_MVIDEO, "Music Video");
            Chbox.InputCheckbox(nTemp++, CH_NONENG, "Non-English");
            Chbox.InputCheckbox(nTemp++, CH_BATCH, "Batch");
            Chbox.InputCheckbox(nTemp++, CH_HANIME, "Hentai Anime");
            Chbox.InputCheckbox(nTemp++, CH_HMANGA, "Hentai Manga");
            Chbox.InputCheckbox(nTemp++, CH_HGAMES, "Hentai Games");
            Chbox.InputCheckbox(nTemp++, CH_JAV, "JAV");

            nTemp = 0;
            for (int i = 0; i < 14; i++)
            {
                if(++nTemp == 6)
                {
                    nTemp = 7;
                }
                
                if(Chbox.returnChbox(i).Checked == true)
                {
                    CheckSelect = true;
                    if(Chbox.returnURL() != TempURL)
                    {
                        Chbox.AddURL(","+nTemp);
                    }
                    else
                    {
                        Chbox.AddURL(nTemp.ToString());
                    }
                    PRINT_OPTION.AppendText("Select " + (i+1) + ". " + Chbox.returnName(i) + "\n");
                }
            }

            if(!CheckSelect)
            {
                PRINT_OPTION.AppendText("Please select at least one.\n");
                return;
            }

            try
            {
                rss = new RssReader();
                rss.FeedUrl = Chbox.returnURL();
                PRINT_OPTION.AppendText("Successfuly opening tokyotosho.info\n");
                PRINT_SEED.Items.Clear();
                foreach (RssItem item in rss.Execute())
                {
                    PRINT_SEED.Items.Add(item.Title);
                }
            }
            catch (Exception exc)
            {
                exc.ToString();
                PRINT_OPTION.AppendText("Error opening tokyotosho.info\n");
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
    class CheckboxSelect
    {
        string url;
        CheckBox[] Chbox;
        string[] name;

        public CheckboxSelect(string tempURL, int nTemp)
        {
            url = tempURL;
            Chbox = new CheckBox[nTemp];
            name = new string[nTemp];
        }

        public void InputCheckbox(int nTemp, CheckBox Tempbox, string TempName)
        {
            Chbox[nTemp] = Tempbox;
            name[nTemp] = TempName;
        }

        public string returnURL()
        {
            return url;
        }
        public CheckBox returnChbox(int nTemp)
        {
            return Chbox[nTemp];
        }
        public string returnName(int nTemp)
        {
            return name[nTemp];
        }
        public void AddURL(string addurl)
        {
            url += addurl;
        }
    }

}
