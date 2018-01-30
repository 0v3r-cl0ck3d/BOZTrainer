namespace BOZTrainerGUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SetPointsButton = new System.Windows.Forms.Button();
            this.PointsNUD = new System.Windows.Forms.NumericUpDown();
            this.SeWeaponOneClipButton = new System.Windows.Forms.Button();
            this.WeaponOneCLipNUD = new System.Windows.Forms.NumericUpDown();
            this.SetWeaponTwoClipButton = new System.Windows.Forms.Button();
            this.WeaponTwoCLipNUD = new System.Windows.Forms.NumericUpDown();
            this.WeaponThreeCLipNUD = new System.Windows.Forms.NumericUpDown();
            this.SetWeaponThreeClipButton = new System.Windows.Forms.Button();
            this.SetKillCountBUtton = new System.Windows.Forms.Button();
            this.KillCountNUD = new System.Windows.Forms.NumericUpDown();
            this.ToggleNoclipButton = new System.Windows.Forms.Button();
            this.HotKeyTimer = new System.Windows.Forms.Timer(this.components);
            this.ToggleGodmodeButton = new System.Windows.Forms.Button();
            this.ToggleDeathStateButton = new System.Windows.Forms.Button();
            this.ShowAboutFormButton = new System.Windows.Forms.Button();
            this.SetWaeponTwoIdButton = new System.Windows.Forms.Button();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.ManualDataOverWriteButton = new System.Windows.Forms.Button();
            this.ManualOverWriteData = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.ManualPointerOffsetNUD = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ManualPointerNUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HotKeyListButton = new System.Windows.Forms.Button();
            this.AutoFire = new System.Windows.Forms.Timer(this.components);
            this.SetWeaponTwoIDNUD = new System.Windows.Forms.NumericUpDown();
            this.SetWeaponOneIDButton = new System.Windows.Forms.Button();
            this.SetWeaponOneIDNUD = new System.Windows.Forms.NumericUpDown();
            this.SetWaeponThreeIdButton = new System.Windows.Forms.Button();
            this.SetWeaponThreeIDNUD = new System.Windows.Forms.NumericUpDown();
            this.HeadShotCountNUD = new System.Windows.Forms.NumericUpDown();
            this.SetHeadShotCountBUtton = new System.Windows.Forms.Button();
            this.ToggleUFOModeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PointsNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeaponOneCLipNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeaponTwoCLipNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeaponThreeCLipNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KillCountNUD)).BeginInit();
            this.InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManualOverWriteData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManualPointerOffsetNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManualPointerNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetWeaponTwoIDNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetWeaponOneIDNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetWeaponThreeIDNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadShotCountNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // SetPointsButton
            // 
            this.SetPointsButton.Location = new System.Drawing.Point(12, 12);
            this.SetPointsButton.Name = "SetPointsButton";
            this.SetPointsButton.Size = new System.Drawing.Size(131, 23);
            this.SetPointsButton.TabIndex = 0;
            this.SetPointsButton.Text = "Set Points";
            this.SetPointsButton.UseVisualStyleBackColor = true;
            this.SetPointsButton.Click += new System.EventHandler(this.SetPointsButton_Click);
            // 
            // PointsNUD
            // 
            this.PointsNUD.Location = new System.Drawing.Point(161, 15);
            this.PointsNUD.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.PointsNUD.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.PointsNUD.Name = "PointsNUD";
            this.PointsNUD.Size = new System.Drawing.Size(130, 20);
            this.PointsNUD.TabIndex = 1;
            // 
            // SeWeaponOneClipButton
            // 
            this.SeWeaponOneClipButton.Location = new System.Drawing.Point(12, 41);
            this.SeWeaponOneClipButton.Name = "SeWeaponOneClipButton";
            this.SeWeaponOneClipButton.Size = new System.Drawing.Size(131, 23);
            this.SeWeaponOneClipButton.TabIndex = 2;
            this.SeWeaponOneClipButton.Text = "Set Weapon One Clip";
            this.SeWeaponOneClipButton.UseVisualStyleBackColor = true;
            this.SeWeaponOneClipButton.Click += new System.EventHandler(this.SeWeaponOneClipButton_Click);
            // 
            // WeaponOneCLipNUD
            // 
            this.WeaponOneCLipNUD.Location = new System.Drawing.Point(161, 43);
            this.WeaponOneCLipNUD.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.WeaponOneCLipNUD.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.WeaponOneCLipNUD.Name = "WeaponOneCLipNUD";
            this.WeaponOneCLipNUD.Size = new System.Drawing.Size(130, 20);
            this.WeaponOneCLipNUD.TabIndex = 3;
            // 
            // SetWeaponTwoClipButton
            // 
            this.SetWeaponTwoClipButton.Location = new System.Drawing.Point(12, 70);
            this.SetWeaponTwoClipButton.Name = "SetWeaponTwoClipButton";
            this.SetWeaponTwoClipButton.Size = new System.Drawing.Size(131, 23);
            this.SetWeaponTwoClipButton.TabIndex = 4;
            this.SetWeaponTwoClipButton.Text = "Set Weapon Two Clip";
            this.SetWeaponTwoClipButton.UseVisualStyleBackColor = true;
            this.SetWeaponTwoClipButton.Click += new System.EventHandler(this.SetWeaponTwoClipButton_Click);
            // 
            // WeaponTwoCLipNUD
            // 
            this.WeaponTwoCLipNUD.Location = new System.Drawing.Point(161, 73);
            this.WeaponTwoCLipNUD.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.WeaponTwoCLipNUD.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.WeaponTwoCLipNUD.Name = "WeaponTwoCLipNUD";
            this.WeaponTwoCLipNUD.Size = new System.Drawing.Size(130, 20);
            this.WeaponTwoCLipNUD.TabIndex = 5;
            // 
            // WeaponThreeCLipNUD
            // 
            this.WeaponThreeCLipNUD.Location = new System.Drawing.Point(161, 102);
            this.WeaponThreeCLipNUD.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.WeaponThreeCLipNUD.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.WeaponThreeCLipNUD.Name = "WeaponThreeCLipNUD";
            this.WeaponThreeCLipNUD.Size = new System.Drawing.Size(130, 20);
            this.WeaponThreeCLipNUD.TabIndex = 6;
            // 
            // SetWeaponThreeClipButton
            // 
            this.SetWeaponThreeClipButton.Location = new System.Drawing.Point(12, 99);
            this.SetWeaponThreeClipButton.Name = "SetWeaponThreeClipButton";
            this.SetWeaponThreeClipButton.Size = new System.Drawing.Size(131, 23);
            this.SetWeaponThreeClipButton.TabIndex = 7;
            this.SetWeaponThreeClipButton.Text = "Set Weapon Three Clip";
            this.SetWeaponThreeClipButton.UseVisualStyleBackColor = true;
            this.SetWeaponThreeClipButton.Click += new System.EventHandler(this.SetWeaponThreeClipButton_Click);
            // 
            // SetKillCountBUtton
            // 
            this.SetKillCountBUtton.Location = new System.Drawing.Point(12, 128);
            this.SetKillCountBUtton.Name = "SetKillCountBUtton";
            this.SetKillCountBUtton.Size = new System.Drawing.Size(131, 23);
            this.SetKillCountBUtton.TabIndex = 8;
            this.SetKillCountBUtton.Text = "Set Kill Count";
            this.SetKillCountBUtton.UseVisualStyleBackColor = true;
            this.SetKillCountBUtton.Click += new System.EventHandler(this.SetKillCountBUtton_Click);
            // 
            // KillCountNUD
            // 
            this.KillCountNUD.Location = new System.Drawing.Point(161, 128);
            this.KillCountNUD.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.KillCountNUD.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.KillCountNUD.Name = "KillCountNUD";
            this.KillCountNUD.Size = new System.Drawing.Size(131, 20);
            this.KillCountNUD.TabIndex = 9;
            // 
            // ToggleNoclipButton
            // 
            this.ToggleNoclipButton.Location = new System.Drawing.Point(13, 276);
            this.ToggleNoclipButton.Name = "ToggleNoclipButton";
            this.ToggleNoclipButton.Size = new System.Drawing.Size(130, 23);
            this.ToggleNoclipButton.TabIndex = 10;
            this.ToggleNoclipButton.Text = "Toggle Noclip";
            this.ToggleNoclipButton.UseVisualStyleBackColor = true;
            this.ToggleNoclipButton.Click += new System.EventHandler(this.ToggleNoclipButton_Click);
            // 
            // HotKeyTimer
            // 
            this.HotKeyTimer.Interval = 200;
            this.HotKeyTimer.Tick += new System.EventHandler(this.HotKeyTimer_Tick);
            // 
            // ToggleGodmodeButton
            // 
            this.ToggleGodmodeButton.Location = new System.Drawing.Point(13, 305);
            this.ToggleGodmodeButton.Name = "ToggleGodmodeButton";
            this.ToggleGodmodeButton.Size = new System.Drawing.Size(130, 23);
            this.ToggleGodmodeButton.TabIndex = 11;
            this.ToggleGodmodeButton.Text = "Toggle God mode";
            this.ToggleGodmodeButton.UseVisualStyleBackColor = true;
            this.ToggleGodmodeButton.Click += new System.EventHandler(this.ToggleGodmodeButton_Click);
            // 
            // ToggleDeathStateButton
            // 
            this.ToggleDeathStateButton.Location = new System.Drawing.Point(162, 305);
            this.ToggleDeathStateButton.Name = "ToggleDeathStateButton";
            this.ToggleDeathStateButton.Size = new System.Drawing.Size(130, 23);
            this.ToggleDeathStateButton.TabIndex = 12;
            this.ToggleDeathStateButton.Text = "Toggle Death State";
            this.ToggleDeathStateButton.UseVisualStyleBackColor = true;
            this.ToggleDeathStateButton.Click += new System.EventHandler(this.ToggleDeathStateButton_Click);
            // 
            // ShowAboutFormButton
            // 
            this.ShowAboutFormButton.Location = new System.Drawing.Point(161, 334);
            this.ShowAboutFormButton.Name = "ShowAboutFormButton";
            this.ShowAboutFormButton.Size = new System.Drawing.Size(131, 23);
            this.ShowAboutFormButton.TabIndex = 13;
            this.ShowAboutFormButton.Text = "About";
            this.ShowAboutFormButton.UseVisualStyleBackColor = true;
            this.ShowAboutFormButton.Click += new System.EventHandler(this.ShowAboutFormButton_Click);
            // 
            // SetWaeponTwoIdButton
            // 
            this.SetWaeponTwoIdButton.Location = new System.Drawing.Point(13, 218);
            this.SetWaeponTwoIdButton.Name = "SetWaeponTwoIdButton";
            this.SetWaeponTwoIdButton.Size = new System.Drawing.Size(130, 23);
            this.SetWaeponTwoIdButton.TabIndex = 14;
            this.SetWaeponTwoIdButton.Text = "Set Weapon Two ID";
            this.SetWaeponTwoIdButton.UseVisualStyleBackColor = true;
            this.SetWaeponTwoIdButton.Click += new System.EventHandler(this.SetWaeponTwoIdButton_Click);
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.Color.Turquoise;
            this.InfoPanel.Controls.Add(this.ManualDataOverWriteButton);
            this.InfoPanel.Controls.Add(this.ManualOverWriteData);
            this.InfoPanel.Controls.Add(this.label4);
            this.InfoPanel.Controls.Add(this.ManualPointerOffsetNUD);
            this.InfoPanel.Controls.Add(this.label3);
            this.InfoPanel.Controls.Add(this.ManualPointerNUD);
            this.InfoPanel.Controls.Add(this.label2);
            this.InfoPanel.Controls.Add(this.label1);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.InfoPanel.Location = new System.Drawing.Point(304, 0);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(126, 371);
            this.InfoPanel.TabIndex = 15;
            // 
            // ManualDataOverWriteButton
            // 
            this.ManualDataOverWriteButton.Location = new System.Drawing.Point(7, 157);
            this.ManualDataOverWriteButton.Name = "ManualDataOverWriteButton";
            this.ManualDataOverWriteButton.Size = new System.Drawing.Size(113, 23);
            this.ManualDataOverWriteButton.TabIndex = 24;
            this.ManualDataOverWriteButton.Text = "Over Write";
            this.ManualDataOverWriteButton.UseVisualStyleBackColor = true;
            this.ManualDataOverWriteButton.Click += new System.EventHandler(this.ManualDataOverWriteButton_Click);
            // 
            // ManualOverWriteData
            // 
            this.ManualOverWriteData.Location = new System.Drawing.Point(3, 131);
            this.ManualOverWriteData.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.ManualOverWriteData.Minimum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            -2147483648});
            this.ManualOverWriteData.Name = "ManualOverWriteData";
            this.ManualOverWriteData.Size = new System.Drawing.Size(120, 20);
            this.ManualOverWriteData.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Data to over write with:";
            // 
            // ManualPointerOffsetNUD
            // 
            this.ManualPointerOffsetNUD.Enabled = false;
            this.ManualPointerOffsetNUD.Hexadecimal = true;
            this.ManualPointerOffsetNUD.Location = new System.Drawing.Point(3, 86);
            this.ManualPointerOffsetNUD.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.ManualPointerOffsetNUD.Minimum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            -2147483648});
            this.ManualPointerOffsetNUD.Name = "ManualPointerOffsetNUD";
            this.ManualPointerOffsetNUD.Size = new System.Drawing.Size(120, 20);
            this.ManualPointerOffsetNUD.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Offset: (Broke)";
            // 
            // ManualPointerNUD
            // 
            this.ManualPointerNUD.Hexadecimal = true;
            this.ManualPointerNUD.Location = new System.Drawing.Point(3, 43);
            this.ManualPointerNUD.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.ManualPointerNUD.Minimum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            -2147483648});
            this.ManualPointerNUD.Name = "ManualPointerNUD";
            this.ManualPointerNUD.Size = new System.Drawing.Size(120, 20);
            this.ManualPointerNUD.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Pointer:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Manual Data Over Write";
            // 
            // HotKeyListButton
            // 
            this.HotKeyListButton.Location = new System.Drawing.Point(13, 334);
            this.HotKeyListButton.Name = "HotKeyListButton";
            this.HotKeyListButton.Size = new System.Drawing.Size(130, 23);
            this.HotKeyListButton.TabIndex = 25;
            this.HotKeyListButton.Text = "Hot Key List";
            this.HotKeyListButton.UseVisualStyleBackColor = true;
            this.HotKeyListButton.Click += new System.EventHandler(this.HotKeyListButton_Click);
            // 
            // AutoFire
            // 
            this.AutoFire.Interval = 1;
            this.AutoFire.Tick += new System.EventHandler(this.AutoFire_Tick);
            // 
            // SetWeaponTwoIDNUD
            // 
            this.SetWeaponTwoIDNUD.Location = new System.Drawing.Point(162, 218);
            this.SetWeaponTwoIDNUD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.SetWeaponTwoIDNUD.Name = "SetWeaponTwoIDNUD";
            this.SetWeaponTwoIDNUD.Size = new System.Drawing.Size(130, 20);
            this.SetWeaponTwoIDNUD.TabIndex = 26;
            // 
            // SetWeaponOneIDButton
            // 
            this.SetWeaponOneIDButton.Location = new System.Drawing.Point(13, 189);
            this.SetWeaponOneIDButton.Name = "SetWeaponOneIDButton";
            this.SetWeaponOneIDButton.Size = new System.Drawing.Size(130, 23);
            this.SetWeaponOneIDButton.TabIndex = 27;
            this.SetWeaponOneIDButton.Text = "Set Weapon One ID";
            this.SetWeaponOneIDButton.UseVisualStyleBackColor = true;
            this.SetWeaponOneIDButton.Click += new System.EventHandler(this.SetWeaponOneIDButton_Click);
            // 
            // SetWeaponOneIDNUD
            // 
            this.SetWeaponOneIDNUD.Location = new System.Drawing.Point(161, 189);
            this.SetWeaponOneIDNUD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.SetWeaponOneIDNUD.Name = "SetWeaponOneIDNUD";
            this.SetWeaponOneIDNUD.Size = new System.Drawing.Size(130, 20);
            this.SetWeaponOneIDNUD.TabIndex = 28;
            // 
            // SetWaeponThreeIdButton
            // 
            this.SetWaeponThreeIdButton.Location = new System.Drawing.Point(13, 247);
            this.SetWaeponThreeIdButton.Name = "SetWaeponThreeIdButton";
            this.SetWaeponThreeIdButton.Size = new System.Drawing.Size(130, 23);
            this.SetWaeponThreeIdButton.TabIndex = 29;
            this.SetWaeponThreeIdButton.Text = "Set Weapon Three ID";
            this.SetWaeponThreeIdButton.UseVisualStyleBackColor = true;
            this.SetWaeponThreeIdButton.Click += new System.EventHandler(this.SetWaeponThreeIdButton_Click);
            // 
            // SetWeaponThreeIDNUD
            // 
            this.SetWeaponThreeIDNUD.Location = new System.Drawing.Point(161, 247);
            this.SetWeaponThreeIDNUD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.SetWeaponThreeIDNUD.Name = "SetWeaponThreeIDNUD";
            this.SetWeaponThreeIDNUD.Size = new System.Drawing.Size(130, 20);
            this.SetWeaponThreeIDNUD.TabIndex = 30;
            // 
            // HeadShotCountNUD
            // 
            this.HeadShotCountNUD.Location = new System.Drawing.Point(160, 157);
            this.HeadShotCountNUD.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.HeadShotCountNUD.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.HeadShotCountNUD.Name = "HeadShotCountNUD";
            this.HeadShotCountNUD.Size = new System.Drawing.Size(131, 20);
            this.HeadShotCountNUD.TabIndex = 31;
            // 
            // SetHeadShotCountBUtton
            // 
            this.SetHeadShotCountBUtton.Location = new System.Drawing.Point(12, 157);
            this.SetHeadShotCountBUtton.Name = "SetHeadShotCountBUtton";
            this.SetHeadShotCountBUtton.Size = new System.Drawing.Size(131, 23);
            this.SetHeadShotCountBUtton.TabIndex = 32;
            this.SetHeadShotCountBUtton.Text = "Set Headshot Count";
            this.SetHeadShotCountBUtton.UseVisualStyleBackColor = true;
            this.SetHeadShotCountBUtton.Click += new System.EventHandler(this.SetHeadShotCountBUtton_Click);
            // 
            // ToggleUFOModeButton
            // 
            this.ToggleUFOModeButton.Location = new System.Drawing.Point(162, 276);
            this.ToggleUFOModeButton.Name = "ToggleUFOModeButton";
            this.ToggleUFOModeButton.Size = new System.Drawing.Size(130, 23);
            this.ToggleUFOModeButton.TabIndex = 33;
            this.ToggleUFOModeButton.Text = "Toggle UFO mode";
            this.ToggleUFOModeButton.UseVisualStyleBackColor = true;
            this.ToggleUFOModeButton.Click += new System.EventHandler(this.ToggleUFOModeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 371);
            this.Controls.Add(this.ToggleUFOModeButton);
            this.Controls.Add(this.SetHeadShotCountBUtton);
            this.Controls.Add(this.HeadShotCountNUD);
            this.Controls.Add(this.SetWeaponThreeIDNUD);
            this.Controls.Add(this.SetWaeponThreeIdButton);
            this.Controls.Add(this.SetWeaponOneIDNUD);
            this.Controls.Add(this.SetWeaponOneIDButton);
            this.Controls.Add(this.SetWeaponTwoIDNUD);
            this.Controls.Add(this.HotKeyListButton);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.SetWaeponTwoIdButton);
            this.Controls.Add(this.ShowAboutFormButton);
            this.Controls.Add(this.ToggleDeathStateButton);
            this.Controls.Add(this.ToggleGodmodeButton);
            this.Controls.Add(this.ToggleNoclipButton);
            this.Controls.Add(this.KillCountNUD);
            this.Controls.Add(this.SetKillCountBUtton);
            this.Controls.Add(this.SetWeaponThreeClipButton);
            this.Controls.Add(this.WeaponThreeCLipNUD);
            this.Controls.Add(this.WeaponTwoCLipNUD);
            this.Controls.Add(this.SetWeaponTwoClipButton);
            this.Controls.Add(this.WeaponOneCLipNUD);
            this.Controls.Add(this.SeWeaponOneClipButton);
            this.Controls.Add(this.PointsNUD);
            this.Controls.Add(this.SetPointsButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PointsNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeaponOneCLipNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeaponTwoCLipNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeaponThreeCLipNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KillCountNUD)).EndInit();
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManualOverWriteData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManualPointerOffsetNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManualPointerNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetWeaponTwoIDNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetWeaponOneIDNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetWeaponThreeIDNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadShotCountNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SetPointsButton;
        private System.Windows.Forms.NumericUpDown PointsNUD;
        private System.Windows.Forms.Button SeWeaponOneClipButton;
        private System.Windows.Forms.NumericUpDown WeaponOneCLipNUD;
        private System.Windows.Forms.Button SetWeaponTwoClipButton;
        private System.Windows.Forms.NumericUpDown WeaponTwoCLipNUD;
        private System.Windows.Forms.NumericUpDown WeaponThreeCLipNUD;
        private System.Windows.Forms.Button SetWeaponThreeClipButton;
        private System.Windows.Forms.Button SetKillCountBUtton;
        private System.Windows.Forms.NumericUpDown KillCountNUD;
        private System.Windows.Forms.Button ToggleNoclipButton;
        private System.Windows.Forms.Timer HotKeyTimer;
        private System.Windows.Forms.Button ToggleGodmodeButton;
        private System.Windows.Forms.Button ToggleDeathStateButton;
        private System.Windows.Forms.Button ShowAboutFormButton;
        private System.Windows.Forms.Button SetWaeponTwoIdButton;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Button ManualDataOverWriteButton;
        private System.Windows.Forms.NumericUpDown ManualOverWriteData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ManualPointerOffsetNUD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ManualPointerNUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HotKeyListButton;
        private System.Windows.Forms.Timer AutoFire;
        private System.Windows.Forms.NumericUpDown SetWeaponTwoIDNUD;
        private System.Windows.Forms.Button SetWeaponOneIDButton;
        private System.Windows.Forms.NumericUpDown SetWeaponOneIDNUD;
        private System.Windows.Forms.Button SetWaeponThreeIdButton;
        private System.Windows.Forms.NumericUpDown SetWeaponThreeIDNUD;
        private System.Windows.Forms.NumericUpDown HeadShotCountNUD;
        private System.Windows.Forms.Button SetHeadShotCountBUtton;
        private System.Windows.Forms.Button ToggleUFOModeButton;
    }
}

