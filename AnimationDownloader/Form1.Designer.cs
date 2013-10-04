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
            this.INPUT_PATH = new System.Windows.Forms.Button();
            this.INPUT_OPTION = new System.Windows.Forms.Button();
            this.PRINT_INFO = new System.Windows.Forms.ListBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
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
            this.START_DOWNLOAD = new System.Windows.Forms.Button();
            this.PRINT_SEED = new System.Windows.Forms.CheckedListBox();
            this.INFOMATIONBOX.SuspendLayout();
            this.INFO_DEV.SuspendLayout();
            this.SELECTBOX.SuspendLayout();
            this.SuspendLayout();
            // 
            // INFOMATIONBOX
            // 
            this.INFOMATIONBOX.Controls.Add(this.INPUT_PATH);
            this.INFOMATIONBOX.Controls.Add(this.INPUT_OPTION);
            this.INFOMATIONBOX.Controls.Add(this.PRINT_INFO);
            this.INFOMATIONBOX.Controls.Add(this.checkBox13);
            this.INFOMATIONBOX.Controls.Add(this.checkBox12);
            this.INFOMATIONBOX.Controls.Add(this.checkBox11);
            this.INFOMATIONBOX.Controls.Add(this.checkBox10);
            this.INFOMATIONBOX.Controls.Add(this.checkBox9);
            this.INFOMATIONBOX.Controls.Add(this.checkBox8);
            this.INFOMATIONBOX.Controls.Add(this.checkBox7);
            this.INFOMATIONBOX.Controls.Add(this.checkBox6);
            this.INFOMATIONBOX.Controls.Add(this.checkBox5);
            this.INFOMATIONBOX.Controls.Add(this.CH_MUSIC);
            this.INFOMATIONBOX.Controls.Add(this.CH_DRAMA);
            this.INFOMATIONBOX.Controls.Add(this.CH_MANGA);
            this.INFOMATIONBOX.Controls.Add(this.CH_NONENG);
            this.INFOMATIONBOX.Controls.Add(this.CH_ANIME);
            this.INFOMATIONBOX.Location = new System.Drawing.Point(12, 0);
            this.INFOMATIONBOX.Name = "INFOMATIONBOX";
            this.INFOMATIONBOX.Size = new System.Drawing.Size(290, 334);
            this.INFOMATIONBOX.TabIndex = 0;
            this.INFOMATIONBOX.TabStop = false;
            this.INFOMATIONBOX.Text = "Option";
            this.INFOMATIONBOX.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // INPUT_PATH
            // 
            this.INPUT_PATH.Location = new System.Drawing.Point(188, 21);
            this.INPUT_PATH.Name = "INPUT_PATH";
            this.INPUT_PATH.Size = new System.Drawing.Size(96, 60);
            this.INPUT_PATH.TabIndex = 3;
            this.INPUT_PATH.Text = "Download Path";
            this.INPUT_PATH.UseVisualStyleBackColor = true;
            // 
            // INPUT_OPTION
            // 
            this.INPUT_OPTION.Location = new System.Drawing.Point(187, 87);
            this.INPUT_OPTION.Name = "INPUT_OPTION";
            this.INPUT_OPTION.Size = new System.Drawing.Size(97, 82);
            this.INPUT_OPTION.TabIndex = 2;
            this.INPUT_OPTION.Text = "Accept";
            this.INPUT_OPTION.UseVisualStyleBackColor = true;
            // 
            // PRINT_INFO
            // 
            this.PRINT_INFO.FormattingEnabled = true;
            this.PRINT_INFO.ItemHeight = 12;
            this.PRINT_INFO.Location = new System.Drawing.Point(12, 186);
            this.PRINT_INFO.Name = "PRINT_INFO";
            this.PRINT_INFO.Size = new System.Drawing.Size(272, 136);
            this.PRINT_INFO.TabIndex = 1;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox13.Location = new System.Drawing.Point(121, 153);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(60, 16);
            this.checkBox13.TabIndex = 0;
            this.checkBox13.Text = "Anime";
            this.checkBox13.UseVisualStyleBackColor = false;
            this.checkBox13.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox12.Location = new System.Drawing.Point(121, 131);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(60, 16);
            this.checkBox12.TabIndex = 0;
            this.checkBox12.Text = "Anime";
            this.checkBox12.UseVisualStyleBackColor = false;
            this.checkBox12.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox11.Location = new System.Drawing.Point(121, 109);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(60, 16);
            this.checkBox11.TabIndex = 0;
            this.checkBox11.Text = "Anime";
            this.checkBox11.UseVisualStyleBackColor = false;
            this.checkBox11.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox10.Location = new System.Drawing.Point(121, 87);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(60, 16);
            this.checkBox10.TabIndex = 0;
            this.checkBox10.Text = "Anime";
            this.checkBox10.UseVisualStyleBackColor = false;
            this.checkBox10.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox9.Location = new System.Drawing.Point(121, 65);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(60, 16);
            this.checkBox9.TabIndex = 0;
            this.checkBox9.Text = "Anime";
            this.checkBox9.UseVisualStyleBackColor = false;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox8.Location = new System.Drawing.Point(121, 43);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(60, 16);
            this.checkBox8.TabIndex = 0;
            this.checkBox8.Text = "Anime";
            this.checkBox8.UseVisualStyleBackColor = false;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox7.Location = new System.Drawing.Point(121, 21);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(60, 16);
            this.checkBox7.TabIndex = 0;
            this.checkBox7.Text = "Anime";
            this.checkBox7.UseVisualStyleBackColor = false;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox6.Location = new System.Drawing.Point(12, 153);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(60, 16);
            this.checkBox6.TabIndex = 0;
            this.checkBox6.Text = "Anime";
            this.checkBox6.UseVisualStyleBackColor = false;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox5.Location = new System.Drawing.Point(12, 131);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(60, 16);
            this.checkBox5.TabIndex = 0;
            this.checkBox5.Text = "Anime";
            this.checkBox5.UseVisualStyleBackColor = false;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CH_MUSIC
            // 
            this.CH_MUSIC.AutoSize = true;
            this.CH_MUSIC.BackColor = System.Drawing.SystemColors.Control;
            this.CH_MUSIC.Location = new System.Drawing.Point(13, 109);
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
            this.CH_DRAMA.Location = new System.Drawing.Point(13, 87);
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
            this.CH_NONENG.Location = new System.Drawing.Point(13, 43);
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
            this.INFO_DEV.Size = new System.Drawing.Size(290, 140);
            this.INFO_DEV.TabIndex = 1;
            this.INFO_DEV.TabStop = false;
            this.INFO_DEV.Text = "DeveloperInfo";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(276, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Visit Blog:";
            this.button2.UseVisualStyleBackColor = true;
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
            this.SELECTBOX.Controls.Add(this.START_DOWNLOAD);
            this.SELECTBOX.Controls.Add(this.PRINT_SEED);
            this.SELECTBOX.Location = new System.Drawing.Point(309, 0);
            this.SELECTBOX.Name = "SELECTBOX";
            this.SELECTBOX.Size = new System.Drawing.Size(289, 480);
            this.SELECTBOX.TabIndex = 2;
            this.SELECTBOX.TabStop = false;
            this.SELECTBOX.Text = "Select";
            // 
            // START_DOWNLOAD
            // 
            this.START_DOWNLOAD.Location = new System.Drawing.Point(10, 434);
            this.START_DOWNLOAD.Name = "START_DOWNLOAD";
            this.START_DOWNLOAD.Size = new System.Drawing.Size(267, 39);
            this.START_DOWNLOAD.TabIndex = 1;
            this.START_DOWNLOAD.Text = "Start Download";
            this.START_DOWNLOAD.UseVisualStyleBackColor = true;
            // 
            // PRINT_SEED
            // 
            this.PRINT_SEED.FormattingEnabled = true;
            this.PRINT_SEED.Location = new System.Drawing.Point(11, 17);
            this.PRINT_SEED.Name = "PRINT_SEED";
            this.PRINT_SEED.Size = new System.Drawing.Size(267, 404);
            this.PRINT_SEED.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 492);
            this.Controls.Add(this.SELECTBOX);
            this.Controls.Add(this.INFO_DEV);
            this.Controls.Add(this.INFOMATIONBOX);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Animation Auto Downloader v1.00";
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
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox CH_MUSIC;
        private System.Windows.Forms.CheckBox CH_DRAMA;
        private System.Windows.Forms.CheckBox CH_MANGA;
        private System.Windows.Forms.CheckBox CH_NONENG;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.Button INPUT_OPTION;
        private System.Windows.Forms.ListBox PRINT_INFO;
        private System.Windows.Forms.GroupBox INFO_DEV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button INPUT_PATH;
        private System.Windows.Forms.GroupBox SELECTBOX;
        private System.Windows.Forms.Button START_DOWNLOAD;
        private System.Windows.Forms.CheckedListBox PRINT_SEED;
    }
}

