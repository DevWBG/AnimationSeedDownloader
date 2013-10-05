namespace AnimationDownloader
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.INFOMATIONBOX = new System.Windows.Forms.GroupBox();
            this.PRINT_OPTION = new System.Windows.Forms.TextBox();
            this.INPUT_PATH = new System.Windows.Forms.Button();
            this.INPUT_OPTION = new System.Windows.Forms.Button();
            this.CH_OTHER = new System.Windows.Forms.CheckBox();
            this.CH_HMANGA = new System.Windows.Forms.CheckBox();
            this.CH_HANIME = new System.Windows.Forms.CheckBox();
            this.CH_JAV = new System.Windows.Forms.CheckBox();
            this.CH_HGAMES = new System.Windows.Forms.CheckBox();
            this.CH_BATCH = new System.Windows.Forms.CheckBox();
            this.CH_HENTAI = new System.Windows.Forms.CheckBox();
            this.CH_RAWS = new System.Windows.Forms.CheckBox();
            this.CH_MVIDEO = new System.Windows.Forms.CheckBox();
            this.CH_MUSIC = new System.Windows.Forms.CheckBox();
            this.CH_DRAMA = new System.Windows.Forms.CheckBox();
            this.CH_MANGA = new System.Windows.Forms.CheckBox();
            this.CH_NONENG = new System.Windows.Forms.CheckBox();
            this.CH_ANIME = new System.Windows.Forms.CheckBox();
            this.INFO_DEV = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SELECTBOX = new System.Windows.Forms.GroupBox();
            this.DOWN_PROGRESS = new System.Windows.Forms.ProgressBar();
            this.START_DOWNLOAD = new System.Windows.Forms.Button();
            this.PRINT_SEED = new System.Windows.Forms.CheckedListBox();
            this.INPUTDOWNLOADPATH = new System.Windows.Forms.FolderBrowserDialog();
            this.INFOMATIONBOX.SuspendLayout();
            this.INFO_DEV.SuspendLayout();
            this.SELECTBOX.SuspendLayout();
            this.SuspendLayout();
            // 
            // INFOMATIONBOX
            // 
            this.INFOMATIONBOX.Controls.Add(this.PRINT_OPTION);
            this.INFOMATIONBOX.Controls.Add(this.INPUT_PATH);
            this.INFOMATIONBOX.Controls.Add(this.INPUT_OPTION);
            this.INFOMATIONBOX.Controls.Add(this.CH_OTHER);
            this.INFOMATIONBOX.Controls.Add(this.CH_HMANGA);
            this.INFOMATIONBOX.Controls.Add(this.CH_HANIME);
            this.INFOMATIONBOX.Controls.Add(this.CH_JAV);
            this.INFOMATIONBOX.Controls.Add(this.CH_HGAMES);
            this.INFOMATIONBOX.Controls.Add(this.CH_BATCH);
            this.INFOMATIONBOX.Controls.Add(this.CH_HENTAI);
            this.INFOMATIONBOX.Controls.Add(this.CH_RAWS);
            this.INFOMATIONBOX.Controls.Add(this.CH_MVIDEO);
            this.INFOMATIONBOX.Controls.Add(this.CH_MUSIC);
            this.INFOMATIONBOX.Controls.Add(this.CH_DRAMA);
            this.INFOMATIONBOX.Controls.Add(this.CH_MANGA);
            this.INFOMATIONBOX.Controls.Add(this.CH_NONENG);
            this.INFOMATIONBOX.Controls.Add(this.CH_ANIME);
            this.INFOMATIONBOX.Location = new System.Drawing.Point(12, 0);
            this.INFOMATIONBOX.Name = "INFOMATIONBOX";
            this.INFOMATIONBOX.Size = new System.Drawing.Size(305, 334);
            this.INFOMATIONBOX.TabIndex = 0;
            this.INFOMATIONBOX.TabStop = false;
            this.INFOMATIONBOX.Text = "Option";
            this.INFOMATIONBOX.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // PRINT_OPTION
            // 
            this.PRINT_OPTION.Location = new System.Drawing.Point(13, 175);
            this.PRINT_OPTION.Multiline = true;
            this.PRINT_OPTION.Name = "PRINT_OPTION";
            this.PRINT_OPTION.ReadOnly = true;
            this.PRINT_OPTION.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PRINT_OPTION.Size = new System.Drawing.Size(283, 153);
            this.PRINT_OPTION.TabIndex = 4;
            this.PRINT_OPTION.TextChanged += new System.EventHandler(this.PRINT_OPTION_TextChanged);
            // 
            // INPUT_PATH
            // 
            this.INPUT_PATH.Location = new System.Drawing.Point(221, 17);
            this.INPUT_PATH.Name = "INPUT_PATH";
            this.INPUT_PATH.Size = new System.Drawing.Size(75, 64);
            this.INPUT_PATH.TabIndex = 3;
            this.INPUT_PATH.Text = "Download Path";
            this.INPUT_PATH.UseVisualStyleBackColor = true;
            this.INPUT_PATH.Click += new System.EventHandler(this.INPUT_PATH_Click);
            // 
            // INPUT_OPTION
            // 
            this.INPUT_OPTION.Location = new System.Drawing.Point(221, 87);
            this.INPUT_OPTION.Name = "INPUT_OPTION";
            this.INPUT_OPTION.Size = new System.Drawing.Size(75, 82);
            this.INPUT_OPTION.TabIndex = 2;
            this.INPUT_OPTION.Text = "Accept";
            this.INPUT_OPTION.UseVisualStyleBackColor = true;
            this.INPUT_OPTION.Click += new System.EventHandler(this.INPUT_OPTION_Click);
            // 
            // CH_OTHER
            // 
            this.CH_OTHER.AutoSize = true;
            this.CH_OTHER.BackColor = System.Drawing.SystemColors.Control;
            this.CH_OTHER.Location = new System.Drawing.Point(13, 109);
            this.CH_OTHER.Name = "CH_OTHER";
            this.CH_OTHER.Size = new System.Drawing.Size(54, 16);
            this.CH_OTHER.TabIndex = 0;
            this.CH_OTHER.Text = "Other";
            this.CH_OTHER.UseVisualStyleBackColor = false;
            this.CH_OTHER.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CH_HMANGA
            // 
            this.CH_HMANGA.AutoSize = true;
            this.CH_HMANGA.BackColor = System.Drawing.SystemColors.Control;
            this.CH_HMANGA.Location = new System.Drawing.Point(110, 109);
            this.CH_HMANGA.Name = "CH_HMANGA";
            this.CH_HMANGA.Size = new System.Drawing.Size(108, 16);
            this.CH_HMANGA.TabIndex = 0;
            this.CH_HMANGA.Text = "Hentai(Manga)";
            this.CH_HMANGA.UseVisualStyleBackColor = false;
            this.CH_HMANGA.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CH_HANIME
            // 
            this.CH_HANIME.AutoSize = true;
            this.CH_HANIME.BackColor = System.Drawing.SystemColors.Control;
            this.CH_HANIME.Location = new System.Drawing.Point(110, 86);
            this.CH_HANIME.Name = "CH_HANIME";
            this.CH_HANIME.Size = new System.Drawing.Size(105, 16);
            this.CH_HANIME.TabIndex = 0;
            this.CH_HANIME.Text = "Hentai(Anime)";
            this.CH_HANIME.UseVisualStyleBackColor = false;
            this.CH_HANIME.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CH_JAV
            // 
            this.CH_JAV.AutoSize = true;
            this.CH_JAV.BackColor = System.Drawing.SystemColors.Control;
            this.CH_JAV.Location = new System.Drawing.Point(110, 153);
            this.CH_JAV.Name = "CH_JAV";
            this.CH_JAV.Size = new System.Drawing.Size(46, 16);
            this.CH_JAV.TabIndex = 0;
            this.CH_JAV.Text = "JAV";
            this.CH_JAV.UseVisualStyleBackColor = false;
            this.CH_JAV.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CH_HGAMES
            // 
            this.CH_HGAMES.AutoSize = true;
            this.CH_HGAMES.BackColor = System.Drawing.SystemColors.Control;
            this.CH_HGAMES.Location = new System.Drawing.Point(110, 131);
            this.CH_HGAMES.Name = "CH_HGAMES";
            this.CH_HGAMES.Size = new System.Drawing.Size(110, 16);
            this.CH_HGAMES.TabIndex = 0;
            this.CH_HGAMES.Text = "Hentai(Games)";
            this.CH_HGAMES.UseVisualStyleBackColor = false;
            this.CH_HGAMES.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CH_BATCH
            // 
            this.CH_BATCH.AutoSize = true;
            this.CH_BATCH.BackColor = System.Drawing.SystemColors.Control;
            this.CH_BATCH.Location = new System.Drawing.Point(110, 65);
            this.CH_BATCH.Name = "CH_BATCH";
            this.CH_BATCH.Size = new System.Drawing.Size(56, 16);
            this.CH_BATCH.TabIndex = 0;
            this.CH_BATCH.Text = "Batch";
            this.CH_BATCH.UseVisualStyleBackColor = false;
            this.CH_BATCH.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CH_HENTAI
            // 
            this.CH_HENTAI.AutoSize = true;
            this.CH_HENTAI.BackColor = System.Drawing.SystemColors.Control;
            this.CH_HENTAI.Location = new System.Drawing.Point(13, 87);
            this.CH_HENTAI.Name = "CH_HENTAI";
            this.CH_HENTAI.Size = new System.Drawing.Size(59, 16);
            this.CH_HENTAI.TabIndex = 0;
            this.CH_HENTAI.Text = "Hentai";
            this.CH_HENTAI.UseVisualStyleBackColor = false;
            this.CH_HENTAI.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CH_RAWS
            // 
            this.CH_RAWS.AutoSize = true;
            this.CH_RAWS.BackColor = System.Drawing.SystemColors.Control;
            this.CH_RAWS.Location = new System.Drawing.Point(13, 131);
            this.CH_RAWS.Name = "CH_RAWS";
            this.CH_RAWS.Size = new System.Drawing.Size(56, 16);
            this.CH_RAWS.TabIndex = 0;
            this.CH_RAWS.Text = "Raws";
            this.CH_RAWS.UseVisualStyleBackColor = false;
            this.CH_RAWS.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CH_MVIDEO
            // 
            this.CH_MVIDEO.AutoSize = true;
            this.CH_MVIDEO.BackColor = System.Drawing.SystemColors.Control;
            this.CH_MVIDEO.Location = new System.Drawing.Point(110, 21);
            this.CH_MVIDEO.Name = "CH_MVIDEO";
            this.CH_MVIDEO.Size = new System.Drawing.Size(95, 16);
            this.CH_MVIDEO.TabIndex = 0;
            this.CH_MVIDEO.Text = "Music Video";
            this.CH_MVIDEO.UseVisualStyleBackColor = false;
            this.CH_MVIDEO.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CH_MUSIC
            // 
            this.CH_MUSIC.AutoSize = true;
            this.CH_MUSIC.BackColor = System.Drawing.SystemColors.Control;
            this.CH_MUSIC.Location = new System.Drawing.Point(13, 42);
            this.CH_MUSIC.Name = "CH_MUSIC";
            this.CH_MUSIC.Size = new System.Drawing.Size(59, 16);
            this.CH_MUSIC.TabIndex = 0;
            this.CH_MUSIC.Text = "Music";
            this.CH_MUSIC.UseVisualStyleBackColor = false;
            this.CH_MUSIC.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CH_DRAMA
            // 
            this.CH_DRAMA.AutoSize = true;
            this.CH_DRAMA.BackColor = System.Drawing.SystemColors.Control;
            this.CH_DRAMA.Location = new System.Drawing.Point(13, 153);
            this.CH_DRAMA.Name = "CH_DRAMA";
            this.CH_DRAMA.Size = new System.Drawing.Size(61, 16);
            this.CH_DRAMA.TabIndex = 0;
            this.CH_DRAMA.Text = "Drama";
            this.CH_DRAMA.UseVisualStyleBackColor = false;
            this.CH_DRAMA.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CH_MANGA
            // 
            this.CH_MANGA.AutoSize = true;
            this.CH_MANGA.BackColor = System.Drawing.SystemColors.Control;
            this.CH_MANGA.Location = new System.Drawing.Point(13, 65);
            this.CH_MANGA.Name = "CH_MANGA";
            this.CH_MANGA.Size = new System.Drawing.Size(63, 16);
            this.CH_MANGA.TabIndex = 0;
            this.CH_MANGA.Text = "Manga";
            this.CH_MANGA.UseVisualStyleBackColor = false;
            this.CH_MANGA.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CH_NONENG
            // 
            this.CH_NONENG.AutoSize = true;
            this.CH_NONENG.BackColor = System.Drawing.SystemColors.Control;
            this.CH_NONENG.Location = new System.Drawing.Point(110, 43);
            this.CH_NONENG.Name = "CH_NONENG";
            this.CH_NONENG.Size = new System.Drawing.Size(95, 16);
            this.CH_NONENG.TabIndex = 0;
            this.CH_NONENG.Text = "Non-English";
            this.CH_NONENG.UseVisualStyleBackColor = false;
            this.CH_NONENG.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CH_ANIME
            // 
            this.CH_ANIME.AutoSize = true;
            this.CH_ANIME.BackColor = System.Drawing.SystemColors.Control;
            this.CH_ANIME.Location = new System.Drawing.Point(13, 21);
            this.CH_ANIME.Name = "CH_ANIME";
            this.CH_ANIME.Size = new System.Drawing.Size(60, 16);
            this.CH_ANIME.TabIndex = 0;
            this.CH_ANIME.Text = "Anime";
            this.CH_ANIME.UseVisualStyleBackColor = false;
            this.CH_ANIME.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // INFO_DEV
            // 
            this.INFO_DEV.Controls.Add(this.button2);
            this.INFO_DEV.Controls.Add(this.label3);
            this.INFO_DEV.Controls.Add(this.label2);
            this.INFO_DEV.Controls.Add(this.label1);
            this.INFO_DEV.Location = new System.Drawing.Point(12, 340);
            this.INFO_DEV.Name = "INFO_DEV";
            this.INFO_DEV.Size = new System.Drawing.Size(305, 140);
            this.INFO_DEV.TabIndex = 1;
            this.INFO_DEV.TabStop = false;
            this.INFO_DEV.Text = "DeveloperInfo";
            this.INFO_DEV.Enter += new System.EventHandler(this.INFO_DEV_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(276, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Visit Blog:";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Blog : http://popnmusic.tistory.com/";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Twitter : @SHL6967";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Developed by DevWBG";
            // 
            // SELECTBOX
            // 
            this.SELECTBOX.Controls.Add(this.DOWN_PROGRESS);
            this.SELECTBOX.Controls.Add(this.START_DOWNLOAD);
            this.SELECTBOX.Controls.Add(this.PRINT_SEED);
            this.SELECTBOX.Location = new System.Drawing.Point(323, 0);
            this.SELECTBOX.Name = "SELECTBOX";
            this.SELECTBOX.Size = new System.Drawing.Size(275, 480);
            this.SELECTBOX.TabIndex = 2;
            this.SELECTBOX.TabStop = false;
            this.SELECTBOX.Text = "Select";
            // 
            // DOWN_PROGRESS
            // 
            this.DOWN_PROGRESS.Location = new System.Drawing.Point(7, 411);
            this.DOWN_PROGRESS.Name = "DOWN_PROGRESS";
            this.DOWN_PROGRESS.Size = new System.Drawing.Size(262, 17);
            this.DOWN_PROGRESS.TabIndex = 2;
            // 
            // START_DOWNLOAD
            // 
            this.START_DOWNLOAD.Location = new System.Drawing.Point(6, 434);
            this.START_DOWNLOAD.Name = "START_DOWNLOAD";
            this.START_DOWNLOAD.Size = new System.Drawing.Size(263, 39);
            this.START_DOWNLOAD.TabIndex = 1;
            this.START_DOWNLOAD.Text = "Start Download";
            this.START_DOWNLOAD.UseVisualStyleBackColor = true;
            this.START_DOWNLOAD.Click += new System.EventHandler(this.START_DOWNLOAD_Click);
            // 
            // PRINT_SEED
            // 
            this.PRINT_SEED.FormattingEnabled = true;
            this.PRINT_SEED.Location = new System.Drawing.Point(6, 17);
            this.PRINT_SEED.Name = "PRINT_SEED";
            this.PRINT_SEED.Size = new System.Drawing.Size(263, 388);
            this.PRINT_SEED.TabIndex = 0;
            // 
            // INPUTDOWNLOADPATH
            // 
            this.INPUTDOWNLOADPATH.HelpRequest += new System.EventHandler(this.INPUTDOWNLOADPATH_HelpRequest);
            // 
            // Form1
            // 
            this.AcceptButton = this.START_DOWNLOAD;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 489);
            this.Controls.Add(this.SELECTBOX);
            this.Controls.Add(this.INFO_DEV);
            this.Controls.Add(this.INFOMATIONBOX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(625, 528);
            this.MinimumSize = new System.Drawing.Size(625, 528);
            this.Name = "Form1";
            this.Text = "Animation Auto Downloader v1.02";
            this.INFOMATIONBOX.ResumeLayout(false);
            this.INFOMATIONBOX.PerformLayout();
            this.INFO_DEV.ResumeLayout(false);
            this.INFO_DEV.PerformLayout();
            this.SELECTBOX.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox INFOMATIONBOX;
        private System.Windows.Forms.CheckBox CH_ANIME;
        private System.Windows.Forms.CheckBox CH_HGAMES;
        private System.Windows.Forms.CheckBox CH_HMANGA;
        private System.Windows.Forms.CheckBox CH_HANIME;
        private System.Windows.Forms.CheckBox CH_HENTAI;
        private System.Windows.Forms.CheckBox CH_RAWS;
        private System.Windows.Forms.CheckBox CH_MVIDEO;
        private System.Windows.Forms.CheckBox CH_MUSIC;
        private System.Windows.Forms.CheckBox CH_DRAMA;
        private System.Windows.Forms.CheckBox CH_MANGA;
        private System.Windows.Forms.CheckBox CH_NONENG;
        private System.Windows.Forms.CheckBox CH_OTHER;
        private System.Windows.Forms.CheckBox CH_JAV;
        private System.Windows.Forms.CheckBox CH_BATCH;
        private System.Windows.Forms.Button INPUT_OPTION;
        private System.Windows.Forms.GroupBox INFO_DEV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button INPUT_PATH;
        private System.Windows.Forms.GroupBox SELECTBOX;
        private System.Windows.Forms.Button START_DOWNLOAD;
        private System.Windows.Forms.CheckedListBox PRINT_SEED;
        private System.Windows.Forms.TextBox PRINT_OPTION;
        private System.Windows.Forms.FolderBrowserDialog INPUTDOWNLOADPATH;
        private System.Windows.Forms.ProgressBar DOWN_PROGRESS;
    }
}

