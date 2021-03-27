namespace RedditVideoGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.progressBarPanel = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.tabPanel = new System.Windows.Forms.Panel();
            this.generationButtonPanel = new System.Windows.Forms.Panel();
            this.generationButton = new System.Windows.Forms.Button();
            this.videoOptionsButtonPanel = new System.Windows.Forms.Panel();
            this.videoOptionsButton = new System.Windows.Forms.Button();
            this.postOptionsButtonPanel = new System.Windows.Forms.Panel();
            this.postOptionsButton = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.postOptionsPanel = new System.Windows.Forms.Panel();
            this.selectedPostPanel = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.Button();
            this.selectPostButton = new System.Windows.Forms.Button();
            this.commentsText = new System.Windows.Forms.Label();
            this.helpIcon6 = new System.Windows.Forms.PictureBox();
            this.selectedPostText = new System.Windows.Forms.Label();
            this.postUrlPanel = new System.Windows.Forms.Panel();
            this.helpIcon5 = new System.Windows.Forms.PictureBox();
            this.postUrlBox = new System.Windows.Forms.TextBox();
            this.postUrlText = new System.Windows.Forms.Label();
            this.postDepthPanel = new System.Windows.Forms.Panel();
            this.helpIcon4 = new System.Windows.Forms.PictureBox();
            this.postDepthText = new System.Windows.Forms.Label();
            this.commentAmountPanel = new System.Windows.Forms.Panel();
            this.helpIcon3 = new System.Windows.Forms.PictureBox();
            this.commentAmountText = new System.Windows.Forms.Label();
            this.postDatePanel = new System.Windows.Forms.Panel();
            this.helpIcon2 = new System.Windows.Forms.PictureBox();
            this.postDateText = new System.Windows.Forms.Label();
            this.subNamePanel = new System.Windows.Forms.Panel();
            this.helpIcon1 = new System.Windows.Forms.PictureBox();
            this.subNameHelper = new System.Windows.Forms.Label();
            this.subredditBox = new System.Windows.Forms.TextBox();
            this.subNameText = new System.Windows.Forms.Label();
            this.generationPanel = new System.Windows.Forms.Panel();
            this.videoOptionsPanel = new System.Windows.Forms.Panel();
            this.topBarPanel = new System.Windows.Forms.Panel();
            this.xButton = new System.Windows.Forms.Button();
            this.helpTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.postDepthBox = new RedditVideoGenerator.Controls.FlatNumericUpDown();
            this.commentAmountBox = new RedditVideoGenerator.Controls.FlatNumericUpDown();
            this.postDateBox = new RedditVideoGenerator.Controls.FlatComboBox();
            this.progressBar = new RedditVideoGenerator.Controls.FlatProgressBar();
            this.progressBarPanel.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.tabPanel.SuspendLayout();
            this.generationButtonPanel.SuspendLayout();
            this.videoOptionsButtonPanel.SuspendLayout();
            this.postOptionsButtonPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.postOptionsPanel.SuspendLayout();
            this.selectedPostPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helpIcon6)).BeginInit();
            this.postUrlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helpIcon5)).BeginInit();
            this.postDepthPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helpIcon4)).BeginInit();
            this.commentAmountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helpIcon3)).BeginInit();
            this.postDatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helpIcon2)).BeginInit();
            this.subNamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helpIcon1)).BeginInit();
            this.topBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postDepthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentAmountBox)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarPanel
            // 
            this.progressBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.progressBarPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.progressBarPanel.Controls.Add(this.progressBar);
            this.progressBarPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBarPanel.Location = new System.Drawing.Point(0, 414);
            this.progressBarPanel.Name = "progressBarPanel";
            this.progressBarPanel.Size = new System.Drawing.Size(722, 36);
            this.progressBarPanel.TabIndex = 1;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.sidePanel.Controls.Add(this.tabPanel);
            this.sidePanel.Controls.Add(this.logoPanel);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(200, 414);
            this.sidePanel.TabIndex = 0;
            // 
            // tabPanel
            // 
            this.tabPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(114)))));
            this.tabPanel.Controls.Add(this.generationButtonPanel);
            this.tabPanel.Controls.Add(this.videoOptionsButtonPanel);
            this.tabPanel.Controls.Add(this.postOptionsButtonPanel);
            this.tabPanel.Location = new System.Drawing.Point(0, 138);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.Size = new System.Drawing.Size(200, 235);
            this.tabPanel.TabIndex = 1;
            // 
            // generationButtonPanel
            // 
            this.generationButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.generationButtonPanel.Controls.Add(this.generationButton);
            this.generationButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.generationButtonPanel.Location = new System.Drawing.Point(0, 156);
            this.generationButtonPanel.Name = "generationButtonPanel";
            this.generationButtonPanel.Size = new System.Drawing.Size(200, 77);
            this.generationButtonPanel.TabIndex = 2;
            // 
            // generationButton
            // 
            this.generationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(102)))));
            this.generationButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.generationButton.FlatAppearance.BorderSize = 0;
            this.generationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(198)))));
            this.generationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generationButton.Font = new System.Drawing.Font("Harmonia Sans Pro Cyr", 18F);
            this.generationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(187)))), ((int)(((byte)(249)))));
            this.generationButton.Location = new System.Drawing.Point(0, 0);
            this.generationButton.Name = "generationButton";
            this.generationButton.Size = new System.Drawing.Size(194, 77);
            this.generationButton.TabIndex = 0;
            this.generationButton.Text = "Generation";
            this.generationButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generationButton.UseVisualStyleBackColor = false;
            this.generationButton.Click += new System.EventHandler(this.generationButton_Click);
            // 
            // videoOptionsButtonPanel
            // 
            this.videoOptionsButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.videoOptionsButtonPanel.Controls.Add(this.videoOptionsButton);
            this.videoOptionsButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.videoOptionsButtonPanel.Location = new System.Drawing.Point(0, 73);
            this.videoOptionsButtonPanel.Name = "videoOptionsButtonPanel";
            this.videoOptionsButtonPanel.Size = new System.Drawing.Size(200, 83);
            this.videoOptionsButtonPanel.TabIndex = 1;
            // 
            // videoOptionsButton
            // 
            this.videoOptionsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(102)))));
            this.videoOptionsButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.videoOptionsButton.FlatAppearance.BorderSize = 0;
            this.videoOptionsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(198)))));
            this.videoOptionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.videoOptionsButton.Font = new System.Drawing.Font("Harmonia Sans Pro Cyr", 18F);
            this.videoOptionsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(187)))), ((int)(((byte)(249)))));
            this.videoOptionsButton.Location = new System.Drawing.Point(0, 0);
            this.videoOptionsButton.Name = "videoOptionsButton";
            this.videoOptionsButton.Size = new System.Drawing.Size(194, 83);
            this.videoOptionsButton.TabIndex = 0;
            this.videoOptionsButton.Text = "Video Options";
            this.videoOptionsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.videoOptionsButton.UseVisualStyleBackColor = false;
            this.videoOptionsButton.Click += new System.EventHandler(this.videoOptionsButton_Click);
            // 
            // postOptionsButtonPanel
            // 
            this.postOptionsButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(187)))), ((int)(((byte)(249)))));
            this.postOptionsButtonPanel.Controls.Add(this.postOptionsButton);
            this.postOptionsButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.postOptionsButtonPanel.Location = new System.Drawing.Point(0, 0);
            this.postOptionsButtonPanel.Name = "postOptionsButtonPanel";
            this.postOptionsButtonPanel.Size = new System.Drawing.Size(200, 73);
            this.postOptionsButtonPanel.TabIndex = 0;
            // 
            // postOptionsButton
            // 
            this.postOptionsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(90)))), ((int)(((byte)(165)))));
            this.postOptionsButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.postOptionsButton.FlatAppearance.BorderSize = 0;
            this.postOptionsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(198)))));
            this.postOptionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.postOptionsButton.Font = new System.Drawing.Font("Harmonia Sans Pro Cyr", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postOptionsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.postOptionsButton.Location = new System.Drawing.Point(0, 0);
            this.postOptionsButton.Name = "postOptionsButton";
            this.postOptionsButton.Size = new System.Drawing.Size(194, 73);
            this.postOptionsButton.TabIndex = 0;
            this.postOptionsButton.Text = "Post Options";
            this.postOptionsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.postOptionsButton.UseVisualStyleBackColor = false;
            this.postOptionsButton.Click += new System.EventHandler(this.postOptionsButton_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(102)))));
            this.logoPanel.Controls.Add(this.logoBox);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(200, 100);
            this.logoPanel.TabIndex = 0;
            // 
            // logoBox
            // 
            this.logoBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoBox.BackgroundImage")));
            this.logoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoBox.InitialImage = null;
            this.logoBox.Location = new System.Drawing.Point(0, 0);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(200, 100);
            this.logoBox.TabIndex = 0;
            this.logoBox.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.postOptionsPanel);
            this.mainPanel.Controls.Add(this.generationPanel);
            this.mainPanel.Controls.Add(this.videoOptionsPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainPanel.Location = new System.Drawing.Point(200, 32);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(522, 382);
            this.mainPanel.TabIndex = 2;
            // 
            // postOptionsPanel
            // 
            this.postOptionsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.postOptionsPanel.Controls.Add(this.selectedPostPanel);
            this.postOptionsPanel.Controls.Add(this.postUrlPanel);
            this.postOptionsPanel.Controls.Add(this.postDepthPanel);
            this.postOptionsPanel.Controls.Add(this.commentAmountPanel);
            this.postOptionsPanel.Controls.Add(this.postDatePanel);
            this.postOptionsPanel.Controls.Add(this.subNamePanel);
            this.postOptionsPanel.Location = new System.Drawing.Point(6, 6);
            this.postOptionsPanel.Name = "postOptionsPanel";
            this.postOptionsPanel.Size = new System.Drawing.Size(510, 370);
            this.postOptionsPanel.TabIndex = 0;
            // 
            // selectedPostPanel
            // 
            this.selectedPostPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(102)))));
            this.selectedPostPanel.Controls.Add(this.clearButton);
            this.selectedPostPanel.Controls.Add(this.selectPostButton);
            this.selectedPostPanel.Controls.Add(this.commentsText);
            this.selectedPostPanel.Controls.Add(this.helpIcon6);
            this.selectedPostPanel.Controls.Add(this.selectedPostText);
            this.selectedPostPanel.Location = new System.Drawing.Point(6, 238);
            this.selectedPostPanel.Name = "selectedPostPanel";
            this.selectedPostPanel.Size = new System.Drawing.Size(498, 125);
            this.selectedPostPanel.TabIndex = 5;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(90)))), ((int)(((byte)(165)))));
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(187)))), ((int)(((byte)(249)))));
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Harmonia Sans Pro Cyr", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.clearButton.Location = new System.Drawing.Point(402, 83);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(89, 35);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // selectPostButton
            // 
            this.selectPostButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(90)))), ((int)(((byte)(165)))));
            this.selectPostButton.FlatAppearance.BorderSize = 0;
            this.selectPostButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(187)))), ((int)(((byte)(249)))));
            this.selectPostButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectPostButton.Font = new System.Drawing.Font("Harmonia Sans Pro Cyr", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectPostButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.selectPostButton.Location = new System.Drawing.Point(8, 83);
            this.selectPostButton.Name = "selectPostButton";
            this.selectPostButton.Size = new System.Drawing.Size(388, 35);
            this.selectPostButton.TabIndex = 9;
            this.selectPostButton.Text = "Select Post";
            this.selectPostButton.UseVisualStyleBackColor = false;
            this.selectPostButton.Click += new System.EventHandler(this.selectPostButton_Click);
            // 
            // commentsText
            // 
            this.commentsText.AutoSize = true;
            this.commentsText.Font = new System.Drawing.Font("Harmonia Sans Pro Cyr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(90)))), ((int)(((byte)(165)))));
            this.commentsText.Location = new System.Drawing.Point(3, 30);
            this.commentsText.Name = "commentsText";
            this.commentsText.Size = new System.Drawing.Size(134, 19);
            this.commentsText.TabIndex = 8;
            this.commentsText.Text = "Comments: None";
            // 
            // helpIcon6
            // 
            this.helpIcon6.Image = ((System.Drawing.Image)(resources.GetObject("helpIcon6.Image")));
            this.helpIcon6.Location = new System.Drawing.Point(471, 8);
            this.helpIcon6.Name = "helpIcon6";
            this.helpIcon6.Size = new System.Drawing.Size(20, 20);
            this.helpIcon6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.helpIcon6.TabIndex = 7;
            this.helpIcon6.TabStop = false;
            this.helpTooltip.SetToolTip(this.helpIcon6, resources.GetString("helpIcon6.ToolTip"));
            // 
            // selectedPostText
            // 
            this.selectedPostText.AutoSize = true;
            this.selectedPostText.Font = new System.Drawing.Font("Harmonia Sans Pro Cyr", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedPostText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(187)))), ((int)(((byte)(249)))));
            this.selectedPostText.Location = new System.Drawing.Point(3, 5);
            this.selectedPostText.MaximumSize = new System.Drawing.Size(462, 52);
            this.selectedPostText.Name = "selectedPostText";
            this.selectedPostText.Size = new System.Drawing.Size(195, 25);
            this.selectedPostText.TabIndex = 0;
            this.selectedPostText.Text = "Selected Post: None";
            // 
            // postUrlPanel
            // 
            this.postUrlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(102)))));
            this.postUrlPanel.Controls.Add(this.helpIcon5);
            this.postUrlPanel.Controls.Add(this.postUrlBox);
            this.postUrlPanel.Controls.Add(this.postUrlText);
            this.postUrlPanel.Location = new System.Drawing.Point(6, 192);
            this.postUrlPanel.Name = "postUrlPanel";
            this.postUrlPanel.Size = new System.Drawing.Size(498, 40);
            this.postUrlPanel.TabIndex = 3;
            // 
            // helpIcon5
            // 
            this.helpIcon5.Image = ((System.Drawing.Image)(resources.GetObject("helpIcon5.Image")));
            this.helpIcon5.Location = new System.Drawing.Point(198, 9);
            this.helpIcon5.Name = "helpIcon5";
            this.helpIcon5.Size = new System.Drawing.Size(20, 20);
            this.helpIcon5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.helpIcon5.TabIndex = 7;
            this.helpIcon5.TabStop = false;
            this.helpTooltip.SetToolTip(this.helpIcon5, "(Optional) The specific URL to a Reddit post. If the URL is valid, it will use th" +
        "at exact post instead of choosing a random one.");
            // 
            // postUrlBox
            // 
            this.postUrlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.postUrlBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.postUrlBox.Font = new System.Drawing.Font("Harmonia Sans Pro Cyr", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postUrlBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(90)))), ((int)(((byte)(165)))));
            this.postUrlBox.Location = new System.Drawing.Point(250, 7);
            this.postUrlBox.Name = "postUrlBox";
            this.postUrlBox.Size = new System.Drawing.Size(241, 26);
            this.postUrlBox.TabIndex = 1;
            // 
            // postUrlText
            // 
            this.postUrlText.AutoSize = true;
            this.postUrlText.Font = new System.Drawing.Font("Harmonia Sans Pro Cyr", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postUrlText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(187)))), ((int)(((byte)(249)))));
            this.postUrlText.Location = new System.Drawing.Point(3, 8);
            this.postUrlText.Name = "postUrlText";
            this.postUrlText.Size = new System.Drawing.Size(194, 25);
            this.postUrlText.TabIndex = 0;
            this.postUrlText.Text = "Post URL (Optional)";
            // 
            // postDepthPanel
            // 
            this.postDepthPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(102)))));
            this.postDepthPanel.Controls.Add(this.postDepthBox);
            this.postDepthPanel.Controls.Add(this.helpIcon4);
            this.postDepthPanel.Controls.Add(this.postDepthText);
            this.postDepthPanel.Location = new System.Drawing.Point(6, 146);
            this.postDepthPanel.Name = "postDepthPanel";
            this.postDepthPanel.Size = new System.Drawing.Size(498, 40);
            this.postDepthPanel.TabIndex = 4;
            // 
            // helpIcon4
            // 
            this.helpIcon4.Image = ((System.Drawing.Image)(resources.GetObject("helpIcon4.Image")));
            this.helpIcon4.Location = new System.Drawing.Point(117, 10);
            this.helpIcon4.Name = "helpIcon4";
            this.helpIcon4.Size = new System.Drawing.Size(20, 20);
            this.helpIcon4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.helpIcon4.TabIndex = 6;
            this.helpIcon4.TabStop = false;
            this.helpTooltip.SetToolTip(this.helpIcon4, "The amount of posts to be chosen from. A higher number means more variety in post" +
        " choice, but longer generation time.");
            // 
            // postDepthText
            // 
            this.postDepthText.AutoSize = true;
            this.postDepthText.Font = new System.Drawing.Font("Harmonia Sans Pro Cyr", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postDepthText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(187)))), ((int)(((byte)(249)))));
            this.postDepthText.Location = new System.Drawing.Point(3, 8);
            this.postDepthText.Name = "postDepthText";
            this.postDepthText.Size = new System.Drawing.Size(114, 25);
            this.postDepthText.TabIndex = 0;
            this.postDepthText.Text = "Post Depth";
            // 
            // commentAmountPanel
            // 
            this.commentAmountPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(102)))));
            this.commentAmountPanel.Controls.Add(this.commentAmountBox);
            this.commentAmountPanel.Controls.Add(this.helpIcon3);
            this.commentAmountPanel.Controls.Add(this.commentAmountText);
            this.commentAmountPanel.Location = new System.Drawing.Point(6, 100);
            this.commentAmountPanel.Name = "commentAmountPanel";
            this.commentAmountPanel.Size = new System.Drawing.Size(498, 40);
            this.commentAmountPanel.TabIndex = 3;
            // 
            // helpIcon3
            // 
            this.helpIcon3.Image = ((System.Drawing.Image)(resources.GetObject("helpIcon3.Image")));
            this.helpIcon3.Location = new System.Drawing.Point(186, 10);
            this.helpIcon3.Name = "helpIcon3";
            this.helpIcon3.Size = new System.Drawing.Size(20, 20);
            this.helpIcon3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.helpIcon3.TabIndex = 5;
            this.helpIcon3.TabStop = false;
            this.helpTooltip.SetToolTip(this.helpIcon3, "The amount of comments that will be shown in the video.");
            // 
            // commentAmountText
            // 
            this.commentAmountText.AutoSize = true;
            this.commentAmountText.Font = new System.Drawing.Font("Harmonia Sans Pro Cyr", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentAmountText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(187)))), ((int)(((byte)(249)))));
            this.commentAmountText.Location = new System.Drawing.Point(3, 8);
            this.commentAmountText.Name = "commentAmountText";
            this.commentAmountText.Size = new System.Drawing.Size(184, 25);
            this.commentAmountText.TabIndex = 0;
            this.commentAmountText.Text = "Comment Amount";
            // 
            // postDatePanel
            // 
            this.postDatePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(102)))));
            this.postDatePanel.Controls.Add(this.postDateBox);
            this.postDatePanel.Controls.Add(this.helpIcon2);
            this.postDatePanel.Controls.Add(this.postDateText);
            this.postDatePanel.Location = new System.Drawing.Point(6, 53);
            this.postDatePanel.Name = "postDatePanel";
            this.postDatePanel.Size = new System.Drawing.Size(498, 40);
            this.postDatePanel.TabIndex = 1;
            // 
            // helpIcon2
            // 
            this.helpIcon2.Image = ((System.Drawing.Image)(resources.GetObject("helpIcon2.Image")));
            this.helpIcon2.Location = new System.Drawing.Point(104, 10);
            this.helpIcon2.Name = "helpIcon2";
            this.helpIcon2.Size = new System.Drawing.Size(20, 20);
            this.helpIcon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.helpIcon2.TabIndex = 4;
            this.helpIcon2.TabStop = false;
            this.helpTooltip.SetToolTip(this.helpIcon2, "How long ago a post has to be made.\r\nFor example, if you select week, only posts " +
        "created within the past week will get selected.");
            // 
            // postDateText
            // 
            this.postDateText.AutoSize = true;
            this.postDateText.Font = new System.Drawing.Font("Harmonia Sans Pro Cyr", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postDateText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(187)))), ((int)(((byte)(249)))));
            this.postDateText.Location = new System.Drawing.Point(3, 8);
            this.postDateText.Name = "postDateText";
            this.postDateText.Size = new System.Drawing.Size(102, 25);
            this.postDateText.TabIndex = 0;
            this.postDateText.Text = "Post Date";
            // 
            // subNamePanel
            // 
            this.subNamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(102)))));
            this.subNamePanel.Controls.Add(this.helpIcon1);
            this.subNamePanel.Controls.Add(this.subNameHelper);
            this.subNamePanel.Controls.Add(this.subredditBox);
            this.subNamePanel.Controls.Add(this.subNameText);
            this.subNamePanel.Location = new System.Drawing.Point(6, 7);
            this.subNamePanel.Name = "subNamePanel";
            this.subNamePanel.Size = new System.Drawing.Size(498, 40);
            this.subNamePanel.TabIndex = 0;
            // 
            // helpIcon1
            // 
            this.helpIcon1.Image = ((System.Drawing.Image)(resources.GetObject("helpIcon1.Image")));
            this.helpIcon1.Location = new System.Drawing.Point(164, 10);
            this.helpIcon1.Name = "helpIcon1";
            this.helpIcon1.Size = new System.Drawing.Size(20, 20);
            this.helpIcon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.helpIcon1.TabIndex = 3;
            this.helpIcon1.TabStop = false;
            this.helpTooltip.SetToolTip(this.helpIcon1, "The name of the subreddit you want to get a post from. Make sure the subreddit ex" +
        "ists, video generation will fail if it doesn\'t.");
            // 
            // subNameHelper
            // 
            this.subNameHelper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.subNameHelper.Font = new System.Drawing.Font("Harmonia Sans Pro Cyr", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subNameHelper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(90)))), ((int)(((byte)(165)))));
            this.subNameHelper.Location = new System.Drawing.Point(250, 7);
            this.subNameHelper.Name = "subNameHelper";
            this.subNameHelper.Size = new System.Drawing.Size(23, 26);
            this.subNameHelper.TabIndex = 2;
            this.subNameHelper.Text = "r/";
            this.subNameHelper.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // subredditBox
            // 
            this.subredditBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.subredditBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subredditBox.Font = new System.Drawing.Font("Harmonia Sans Pro Cyr", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subredditBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(90)))), ((int)(((byte)(165)))));
            this.subredditBox.Location = new System.Drawing.Point(273, 7);
            this.subredditBox.Name = "subredditBox";
            this.subredditBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.subredditBox.Size = new System.Drawing.Size(218, 26);
            this.subredditBox.TabIndex = 1;
            this.subredditBox.Text = "Art";
            // 
            // subNameText
            // 
            this.subNameText.AutoSize = true;
            this.subNameText.Font = new System.Drawing.Font("Harmonia Sans Pro Cyr", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subNameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(187)))), ((int)(((byte)(249)))));
            this.subNameText.Location = new System.Drawing.Point(3, 8);
            this.subNameText.Name = "subNameText";
            this.subNameText.Size = new System.Drawing.Size(163, 25);
            this.subNameText.TabIndex = 0;
            this.subNameText.Text = "Subreddit Name";
            // 
            // generationPanel
            // 
            this.generationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.generationPanel.Location = new System.Drawing.Point(6, 6);
            this.generationPanel.Name = "generationPanel";
            this.generationPanel.Size = new System.Drawing.Size(510, 370);
            this.generationPanel.TabIndex = 2;
            // 
            // videoOptionsPanel
            // 
            this.videoOptionsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.videoOptionsPanel.Location = new System.Drawing.Point(6, 6);
            this.videoOptionsPanel.Name = "videoOptionsPanel";
            this.videoOptionsPanel.Size = new System.Drawing.Size(510, 370);
            this.videoOptionsPanel.TabIndex = 1;
            // 
            // topBarPanel
            // 
            this.topBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(18)))), ((int)(((byte)(30)))));
            this.topBarPanel.Controls.Add(this.xButton);
            this.topBarPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.topBarPanel.Location = new System.Drawing.Point(200, 0);
            this.topBarPanel.Name = "topBarPanel";
            this.topBarPanel.Size = new System.Drawing.Size(522, 32);
            this.topBarPanel.TabIndex = 3;
            this.topBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel9_MouseDown);
            // 
            // xButton
            // 
            this.xButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.xButton.FlatAppearance.BorderSize = 0;
            this.xButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xButton.Image = ((System.Drawing.Image)(resources.GetObject("xButton.Image")));
            this.xButton.Location = new System.Drawing.Point(494, 4);
            this.xButton.Name = "xButton";
            this.xButton.Size = new System.Drawing.Size(24, 24);
            this.xButton.TabIndex = 1;
            this.xButton.UseVisualStyleBackColor = false;
            this.xButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // helpTooltip
            // 
            this.helpTooltip.AutomaticDelay = 0;
            this.helpTooltip.AutoPopDelay = 32767;
            this.helpTooltip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(18)))), ((int)(((byte)(30)))));
            this.helpTooltip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(187)))), ((int)(((byte)(249)))));
            this.helpTooltip.InitialDelay = 200;
            this.helpTooltip.OwnerDraw = true;
            this.helpTooltip.ReshowDelay = 200;
            this.helpTooltip.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.helpTooltip_Draw);
            // 
            // postDepthBox
            // 
            this.postDepthBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.postDepthBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.postDepthBox.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.postDepthBox.Font = new System.Drawing.Font("Harmonia Sans Pro Cyr", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postDepthBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(90)))), ((int)(((byte)(165)))));
            this.postDepthBox.Location = new System.Drawing.Point(250, 5);
            this.postDepthBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.postDepthBox.Name = "postDepthBox";
            this.postDepthBox.Size = new System.Drawing.Size(241, 29);
            this.postDepthBox.TabIndex = 7;
            this.postDepthBox.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // commentAmountBox
            // 
            this.commentAmountBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.commentAmountBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.commentAmountBox.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.commentAmountBox.Font = new System.Drawing.Font("Harmonia Sans Pro Cyr", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentAmountBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(90)))), ((int)(((byte)(165)))));
            this.commentAmountBox.Location = new System.Drawing.Point(250, 5);
            this.commentAmountBox.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.commentAmountBox.Name = "commentAmountBox";
            this.commentAmountBox.Size = new System.Drawing.Size(241, 29);
            this.commentAmountBox.TabIndex = 6;
            this.commentAmountBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // postDateBox
            // 
            this.postDateBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.postDateBox.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.postDateBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.postDateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.postDateBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.postDateBox.Font = new System.Drawing.Font("Harmonia Sans Pro Cyr", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postDateBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(90)))), ((int)(((byte)(165)))));
            this.postDateBox.FormattingEnabled = true;
            this.postDateBox.ItemHeight = 29;
            this.postDateBox.Items.AddRange(new object[] {
            "All",
            "Year",
            "Month",
            "Week",
            "Day",
            "Hour"});
            this.postDateBox.Location = new System.Drawing.Point(250, 2);
            this.postDateBox.Name = "postDateBox";
            this.postDateBox.Size = new System.Drawing.Size(241, 35);
            this.postDateBox.TabIndex = 5;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(102)))));
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(187)))), ((int)(((byte)(249)))));
            this.progressBar.Location = new System.Drawing.Point(0, 0);
            this.progressBar.Maximum = 100000;
            this.progressBar.Minimum = 1;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(722, 36);
            this.progressBar.StatusFont = new System.Drawing.Font("Harmonia Sans Pro Cyr", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBar.StatusMessage = "";
            this.progressBar.TabIndex = 0;
            this.progressBar.Value = 100000;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(722, 450);
            this.ControlBox = false;
            this.Controls.Add(this.topBarPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.progressBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Reddit Video Generator";
            this.progressBarPanel.ResumeLayout(false);
            this.sidePanel.ResumeLayout(false);
            this.tabPanel.ResumeLayout(false);
            this.generationButtonPanel.ResumeLayout(false);
            this.videoOptionsButtonPanel.ResumeLayout(false);
            this.postOptionsButtonPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.postOptionsPanel.ResumeLayout(false);
            this.selectedPostPanel.ResumeLayout(false);
            this.selectedPostPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helpIcon6)).EndInit();
            this.postUrlPanel.ResumeLayout(false);
            this.postUrlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helpIcon5)).EndInit();
            this.postDepthPanel.ResumeLayout(false);
            this.postDepthPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helpIcon4)).EndInit();
            this.commentAmountPanel.ResumeLayout(false);
            this.commentAmountPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helpIcon3)).EndInit();
            this.postDatePanel.ResumeLayout(false);
            this.postDatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helpIcon2)).EndInit();
            this.subNamePanel.ResumeLayout(false);
            this.subNamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helpIcon1)).EndInit();
            this.topBarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.postDepthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentAmountBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel progressBarPanel;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel tabPanel;
        private System.Windows.Forms.Panel postOptionsButtonPanel;
        private System.Windows.Forms.Button postOptionsButton;
        private System.Windows.Forms.Panel generationButtonPanel;
        private System.Windows.Forms.Button generationButton;
        private System.Windows.Forms.Panel videoOptionsButtonPanel;
        private System.Windows.Forms.Button videoOptionsButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel topBarPanel;
        private System.Windows.Forms.Button xButton;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Panel postOptionsPanel;
        private System.Windows.Forms.Panel generationPanel;
        private System.Windows.Forms.Panel videoOptionsPanel;
        private System.Windows.Forms.Panel subNamePanel;
        private System.Windows.Forms.Label subNameText;
        private System.Windows.Forms.TextBox subredditBox;
        private System.Windows.Forms.Label subNameHelper;
        private System.Windows.Forms.Panel postDatePanel;
        private System.Windows.Forms.Label postDateText;
        private System.Windows.Forms.Panel commentAmountPanel;
        private System.Windows.Forms.Label commentAmountText;
        private System.Windows.Forms.Panel postDepthPanel;
        private System.Windows.Forms.Label postDepthText;
        private System.Windows.Forms.Panel postUrlPanel;
        private System.Windows.Forms.TextBox postUrlBox;
        private System.Windows.Forms.Label postUrlText;
        private System.Windows.Forms.PictureBox helpIcon1;
        private System.Windows.Forms.ToolTip helpTooltip;
        private System.Windows.Forms.PictureBox helpIcon3;
        private System.Windows.Forms.PictureBox helpIcon2;
        private System.Windows.Forms.PictureBox helpIcon4;
        private System.Windows.Forms.PictureBox helpIcon5;
        private System.Windows.Forms.Panel selectedPostPanel;
        private System.Windows.Forms.PictureBox helpIcon6;
        private System.Windows.Forms.Label selectedPostText;
        private System.Windows.Forms.Label commentsText;
        private System.Windows.Forms.Button selectPostButton;
        private System.Windows.Forms.Button clearButton;
        private Controls.FlatComboBox postDateBox;
        private Controls.FlatProgressBar progressBar;
        private Controls.FlatNumericUpDown commentAmountBox;
        private Controls.FlatNumericUpDown postDepthBox;
    }
}