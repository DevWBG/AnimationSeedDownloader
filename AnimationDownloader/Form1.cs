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
            if (nInputOptionClear)
            {
                PRINT_OPTION.Clear();
                nInputOptionClear = false;
            }
            if (bCheckOpen)
            {
                PRINT_SEED.Items.Clear();
                bCheckOpen = false;
            }
            if (CH_ANIME.Checked == true){
                PRINT_OPTION.AppendText("Select 01. Anime\n");
                nCheckBox++;
                if(url != "http://tokyotosho.info/rss.php?filter="){
                    url += ",1";
                }
                else{
                    url += "1";
                }
            }

            if (CH_MUSIC.Checked == true){
                PRINT_OPTION.AppendText("Select 02. Music\n");
                nCheckBox++;
                if (url != "http://tokyotosho.info/rss.php?filter=")
                {
                    url += ",2";
                }
                else
                {
                    url += "2";
                }
            }

            if (CH_MANGA.Checked == true){
                PRINT_OPTION.AppendText("Select 03. Manga\n");
                nCheckBox++;
                if (url != "http://tokyotosho.info/rss.php?filter=")
                {
                    url += ",3";
                }
                else
                {
                    url += "3";
                }
            }

            if (CH_HENTAI.Checked == true){
                PRINT_OPTION.AppendText("Select 04. Hentai\n");
                nCheckBox++;
                if (url != "http://tokyotosho.info/rss.php?filter=")
                {
                    url += ",4";
                }
                else
                {
                    url += "4";
                }
            }

            if (CH_OTHER.Checked == true){
                PRINT_OPTION.AppendText("Select 05. Other\n");
                nCheckBox++;
                if (url != "http://tokyotosho.info/rss.php?filter=")
                {
                    url += ",5";
                }
                else
                {
                    url += "5";
                }
            }

            if (CH_RAWS.Checked == true){
                PRINT_OPTION.AppendText("Select 06. Raws\n");
                nCheckBox++;
                if (url != "http://tokyotosho.info/rss.php?filter=")
                {
                    url += ",7";
                }
                else
                {
                    url += "7";
                }
            }

            if (CH_DRAMA.Checked == true){
                PRINT_OPTION.AppendText("Select 07. Drama\n");
                nCheckBox++;
                if (url != "http://tokyotosho.info/rss.php?filter=")
                {
                    url += ",8";
                }
                else
                {
                    url += "8";
                }
            }

            
            if (CH_MVIDEO.Checked == true){
                PRINT_OPTION.AppendText("Select 08. Music Video\n");
                nCheckBox++;
                if (url != "http://tokyotosho.info/rss.php?filter=")
                {
                    url += ",9";
                }
                else
                {
                    url += "9";
                }
            }

            if (CH_NONENG.Checked == true)
            {
                PRINT_OPTION.AppendText("Select 09. Non-English\n");
                nCheckBox++;
                if (url != "http://tokyotosho.info/rss.php?filter=")
                {
                    url += ",10";
                }
                else
                {
                    url += "10";
                }
            }

            if (CH_BATCH.Checked == true){
                PRINT_OPTION.AppendText("Select 10. Batch\n");
                nCheckBox++;
                if (url != "http://tokyotosho.info/rss.php?filter="){
                    url += ",11";
                }
                else{
                    url += "11";
                }
            }

            if (CH_HANIME.Checked == true){
                PRINT_OPTION.AppendText("Select 11. Hentai Anime\n");
                nCheckBox++;
                if (url != "http://tokyotosho.info/rss.php?filter=")
                {
                    url += ",12";
                }
                else
                {
                    url += "12";
                }
            }

            if (CH_HMANGA.Checked == true)
            {
                PRINT_OPTION.AppendText("Select 12. Hentai Manga\n");
                nCheckBox++;
                if (url != "http://tokyotosho.info/rss.php?filter=")
                {
                    url += ",13";
                }
                else
                {
                    url += "13";
                }
            }
            
            if (CH_HGAMES.Checked == true)
            {
                PRINT_OPTION.AppendText("Select 13. Hentai Games\n");
                nCheckBox++;
                if (url != "http://tokyotosho.info/rss.php?filter=")
                {
                    url += ",14";
                }
                else
                {
                    url += "14";
                }
            }

            if (CH_JAV.Checked == true)
            {
                PRINT_OPTION.AppendText("Select 14. JAV\n");
                nCheckBox++;
                if (url != "http://tokyotosho.info/rss.php?filter=")
                {
                    url += ",15";
                }
                else
                {
                    url += "15";
                }
            }

            if(nCheckBox == 0){
                PRINT_OPTION.AppendText("Please select at least one.\n");
                nInputOptionClear = true;
                return;
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
                url = "http://tokyotosho.info/rss.php?filter=";
                PRINT_OPTION.AppendText(exc.ToString());
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
                MessageBox.Show("Please setting Path first.", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
            foreach (int nIndexChecked in PRINT_SEED.CheckedIndices)
            {
                DOWN_PROGRESS.Maximum = PRINT_SEED.CheckedIndices.Count;
                try
                {
                    new WebClient().DownloadFile(rss.Items[nIndexChecked].Link, strPath + "\\" +rss.Items[nIndexChecked].Title + ".torrent");
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
