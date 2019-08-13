namespace CustomPresenceTool
{
    partial class MainForm
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox_Log = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dtp_Start = new System.Windows.Forms.DateTimePicker();
            this.dtp_End = new System.Windows.Forms.DateTimePicker();
            this.nud_PartySize = new System.Windows.Forms.NumericUpDown();
            this.nud_PartyMax = new System.Windows.Forms.NumericUpDown();
            this.label_ClientID = new MetroFramework.Controls.MetroLabel();
            this.textBox_ClientID = new MetroFramework.Controls.MetroTextBox();
            this.button_Connect = new MetroFramework.Controls.MetroButton();
            this.Button_Help = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.checkBox_Details = new MetroFramework.Controls.MetroCheckBox();
            this.textBox_Details = new MetroFramework.Controls.MetroTextBox();
            this.checkBox_State = new MetroFramework.Controls.MetroCheckBox();
            this.textBox_State = new MetroFramework.Controls.MetroTextBox();
            this.checkBox_LargeImageKey = new MetroFramework.Controls.MetroCheckBox();
            this.textBox_LargeImageKey = new MetroFramework.Controls.MetroTextBox();
            this.checkBox_LargeImageText = new MetroFramework.Controls.MetroCheckBox();
            this.textBox_LargeImageText = new MetroFramework.Controls.MetroTextBox();
            this.checkBox_SmallImageKey = new MetroFramework.Controls.MetroCheckBox();
            this.textBox_SmallImageKey = new MetroFramework.Controls.MetroTextBox();
            this.checkBox_SmallImageText = new MetroFramework.Controls.MetroCheckBox();
            this.textBox_SmallImageText = new MetroFramework.Controls.MetroTextBox();
            this.checkBox_Start = new MetroFramework.Controls.MetroCheckBox();
            this.checkBox_End = new MetroFramework.Controls.MetroCheckBox();
            this.checkBox_Party = new MetroFramework.Controls.MetroCheckBox();
            this.label_PartySize = new MetroFramework.Controls.MetroLabel();
            this.label_PartyMax = new MetroFramework.Controls.MetroLabel();
            this.label_Status = new MetroFramework.Controls.MetroLabel();
            this.label_StatusDescription = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nud_PartySize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_PartyMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Log
            // 
            this.listBox_Log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.listBox_Log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_Log.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.listBox_Log.FormattingEnabled = true;
            this.listBox_Log.ItemHeight = 12;
            this.listBox_Log.Location = new System.Drawing.Point(25, 580);
            this.listBox_Log.Name = "listBox_Log";
            this.listBox_Log.Size = new System.Drawing.Size(375, 48);
            this.listBox_Log.TabIndex = 27;
            this.listBox_Log.DoubleClick += new System.EventHandler(this.listBox_Log_DoubleClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dtp_Start
            // 
            this.dtp_Start.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.dtp_Start.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.dtp_Start.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtp_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Start.Location = new System.Drawing.Point(150, 420);
            this.dtp_Start.Name = "dtp_Start";
            this.dtp_Start.Size = new System.Drawing.Size(250, 21);
            this.dtp_Start.TabIndex = 19;
            this.dtp_Start.ValueChanged += new System.EventHandler(this.dtp_Start_ValueChanged);
            // 
            // dtp_End
            // 
            this.dtp_End.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.dtp_End.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.dtp_End.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtp_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_End.Location = new System.Drawing.Point(150, 460);
            this.dtp_End.Name = "dtp_End";
            this.dtp_End.Size = new System.Drawing.Size(250, 21);
            this.dtp_End.TabIndex = 21;
            // 
            // nud_PartySize
            // 
            this.nud_PartySize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.nud_PartySize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nud_PartySize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.nud_PartySize.Location = new System.Drawing.Point(220, 500);
            this.nud_PartySize.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nud_PartySize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_PartySize.Name = "nud_PartySize";
            this.nud_PartySize.Size = new System.Drawing.Size(80, 17);
            this.nud_PartySize.TabIndex = 24;
            this.nud_PartySize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_PartyMax
            // 
            this.nud_PartyMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.nud_PartyMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nud_PartyMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.nud_PartyMax.Location = new System.Drawing.Point(220, 540);
            this.nud_PartyMax.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nud_PartyMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_PartyMax.Name = "nud_PartyMax";
            this.nud_PartyMax.Size = new System.Drawing.Size(80, 17);
            this.nud_PartyMax.TabIndex = 26;
            this.nud_PartyMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_PartyMax.ValueChanged += new System.EventHandler(this.nud_PartyMax_ValueChanged);
            // 
            // label_ClientID
            // 
            this.label_ClientID.AutoSize = true;
            this.label_ClientID.Location = new System.Drawing.Point(25, 100);
            this.label_ClientID.Name = "label_ClientID";
            this.label_ClientID.Size = new System.Drawing.Size(58, 19);
            this.label_ClientID.TabIndex = 0;
            this.label_ClientID.Text = "Client ID";
            // 
            // textBox_ClientID
            // 
            this.textBox_ClientID.Location = new System.Drawing.Point(150, 100);
            this.textBox_ClientID.Name = "textBox_ClientID";
            this.textBox_ClientID.Size = new System.Drawing.Size(169, 23);
            this.textBox_ClientID.TabIndex = 1;
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(325, 99);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(75, 25);
            this.button_Connect.TabIndex = 2;
            this.button_Connect.Text = "Connect";
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // Button_Help
            // 
            this.Button_Help.Location = new System.Drawing.Point(325, 139);
            this.Button_Help.Name = "Button_Help";
            this.Button_Help.Size = new System.Drawing.Size(75, 25);
            this.Button_Help.TabIndex = 3;
            this.Button_Help.Text = "Help";
            this.Button_Help.Click += new System.EventHandler(this.Button_Help_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // checkBox_Details
            // 
            this.checkBox_Details.AutoSize = true;
            this.checkBox_Details.Location = new System.Drawing.Point(25, 184);
            this.checkBox_Details.Name = "checkBox_Details";
            this.checkBox_Details.Size = new System.Drawing.Size(58, 15);
            this.checkBox_Details.TabIndex = 6;
            this.checkBox_Details.Text = "Details";
            this.checkBox_Details.UseVisualStyleBackColor = true;
            // 
            // textBox_Details
            // 
            this.textBox_Details.Location = new System.Drawing.Point(150, 180);
            this.textBox_Details.Name = "textBox_Details";
            this.textBox_Details.Size = new System.Drawing.Size(250, 23);
            this.textBox_Details.TabIndex = 7;
            // 
            // checkBox_State
            // 
            this.checkBox_State.AutoSize = true;
            this.checkBox_State.Location = new System.Drawing.Point(25, 224);
            this.checkBox_State.Name = "checkBox_State";
            this.checkBox_State.Size = new System.Drawing.Size(49, 15);
            this.checkBox_State.TabIndex = 8;
            this.checkBox_State.Text = "State";
            this.checkBox_State.UseVisualStyleBackColor = true;
            // 
            // textBox_State
            // 
            this.textBox_State.Location = new System.Drawing.Point(150, 220);
            this.textBox_State.Name = "textBox_State";
            this.textBox_State.Size = new System.Drawing.Size(250, 23);
            this.textBox_State.TabIndex = 9;
            // 
            // checkBox_LargeImageKey
            // 
            this.checkBox_LargeImageKey.AutoSize = true;
            this.checkBox_LargeImageKey.Location = new System.Drawing.Point(25, 264);
            this.checkBox_LargeImageKey.Name = "checkBox_LargeImageKey";
            this.checkBox_LargeImageKey.Size = new System.Drawing.Size(104, 15);
            this.checkBox_LargeImageKey.TabIndex = 10;
            this.checkBox_LargeImageKey.Text = "LargeImageKey";
            this.checkBox_LargeImageKey.UseVisualStyleBackColor = true;
            // 
            // textBox_LargeImageKey
            // 
            this.textBox_LargeImageKey.Location = new System.Drawing.Point(150, 260);
            this.textBox_LargeImageKey.Name = "textBox_LargeImageKey";
            this.textBox_LargeImageKey.Size = new System.Drawing.Size(250, 23);
            this.textBox_LargeImageKey.TabIndex = 11;
            // 
            // checkBox_LargeImageText
            // 
            this.checkBox_LargeImageText.AutoSize = true;
            this.checkBox_LargeImageText.Location = new System.Drawing.Point(25, 304);
            this.checkBox_LargeImageText.Name = "checkBox_LargeImageText";
            this.checkBox_LargeImageText.Size = new System.Drawing.Size(106, 15);
            this.checkBox_LargeImageText.TabIndex = 12;
            this.checkBox_LargeImageText.Text = "LargeImageText";
            this.checkBox_LargeImageText.UseVisualStyleBackColor = true;
            // 
            // textBox_LargeImageText
            // 
            this.textBox_LargeImageText.Location = new System.Drawing.Point(150, 300);
            this.textBox_LargeImageText.Name = "textBox_LargeImageText";
            this.textBox_LargeImageText.Size = new System.Drawing.Size(250, 23);
            this.textBox_LargeImageText.TabIndex = 13;
            // 
            // checkBox_SmallImageKey
            // 
            this.checkBox_SmallImageKey.AutoSize = true;
            this.checkBox_SmallImageKey.Location = new System.Drawing.Point(25, 344);
            this.checkBox_SmallImageKey.Name = "checkBox_SmallImageKey";
            this.checkBox_SmallImageKey.Size = new System.Drawing.Size(104, 15);
            this.checkBox_SmallImageKey.TabIndex = 14;
            this.checkBox_SmallImageKey.Text = "SmallImageKey";
            this.checkBox_SmallImageKey.UseVisualStyleBackColor = true;
            // 
            // textBox_SmallImageKey
            // 
            this.textBox_SmallImageKey.Location = new System.Drawing.Point(150, 340);
            this.textBox_SmallImageKey.Name = "textBox_SmallImageKey";
            this.textBox_SmallImageKey.Size = new System.Drawing.Size(250, 23);
            this.textBox_SmallImageKey.TabIndex = 15;
            // 
            // checkBox_SmallImageText
            // 
            this.checkBox_SmallImageText.AutoSize = true;
            this.checkBox_SmallImageText.Location = new System.Drawing.Point(25, 384);
            this.checkBox_SmallImageText.Name = "checkBox_SmallImageText";
            this.checkBox_SmallImageText.Size = new System.Drawing.Size(106, 15);
            this.checkBox_SmallImageText.TabIndex = 16;
            this.checkBox_SmallImageText.Text = "SmallImageText";
            this.checkBox_SmallImageText.UseVisualStyleBackColor = true;
            // 
            // textBox_SmallImageText
            // 
            this.textBox_SmallImageText.Location = new System.Drawing.Point(150, 380);
            this.textBox_SmallImageText.Name = "textBox_SmallImageText";
            this.textBox_SmallImageText.Size = new System.Drawing.Size(250, 23);
            this.textBox_SmallImageText.TabIndex = 17;
            // 
            // checkBox_Start
            // 
            this.checkBox_Start.AutoSize = true;
            this.checkBox_Start.Location = new System.Drawing.Point(25, 424);
            this.checkBox_Start.Name = "checkBox_Start";
            this.checkBox_Start.Size = new System.Drawing.Size(47, 15);
            this.checkBox_Start.TabIndex = 18;
            this.checkBox_Start.Text = "Start";
            this.checkBox_Start.UseVisualStyleBackColor = true;
            // 
            // checkBox_End
            // 
            this.checkBox_End.AutoSize = true;
            this.checkBox_End.Location = new System.Drawing.Point(25, 464);
            this.checkBox_End.Name = "checkBox_End";
            this.checkBox_End.Size = new System.Drawing.Size(43, 15);
            this.checkBox_End.TabIndex = 20;
            this.checkBox_End.Text = "End";
            this.checkBox_End.UseVisualStyleBackColor = true;
            // 
            // checkBox_Party
            // 
            this.checkBox_Party.AutoSize = true;
            this.checkBox_Party.Location = new System.Drawing.Point(25, 504);
            this.checkBox_Party.Name = "checkBox_Party";
            this.checkBox_Party.Size = new System.Drawing.Size(50, 15);
            this.checkBox_Party.TabIndex = 22;
            this.checkBox_Party.Text = "Party";
            this.checkBox_Party.UseVisualStyleBackColor = true;
            // 
            // label_PartySize
            // 
            this.label_PartySize.AutoSize = true;
            this.label_PartySize.Location = new System.Drawing.Point(150, 500);
            this.label_PartySize.Name = "label_PartySize";
            this.label_PartySize.Size = new System.Drawing.Size(32, 19);
            this.label_PartySize.TabIndex = 23;
            this.label_PartySize.Text = "Size";
            // 
            // label_PartyMax
            // 
            this.label_PartyMax.AutoSize = true;
            this.label_PartyMax.Location = new System.Drawing.Point(150, 540);
            this.label_PartyMax.Name = "label_PartyMax";
            this.label_PartyMax.Size = new System.Drawing.Size(34, 19);
            this.label_PartyMax.TabIndex = 25;
            this.label_PartyMax.Text = "Max";
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Location = new System.Drawing.Point(25, 140);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(43, 19);
            this.label_Status.TabIndex = 4;
            this.label_Status.Text = "Status";
            // 
            // label_StatusDescription
            // 
            this.label_StatusDescription.AutoSize = true;
            this.label_StatusDescription.Location = new System.Drawing.Point(150, 140);
            this.label_StatusDescription.Name = "label_StatusDescription";
            this.label_StatusDescription.Size = new System.Drawing.Size(98, 19);
            this.label_StatusDescription.TabIndex = 5;
            this.label_StatusDescription.Text = "Not Connected";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 660);
            this.Controls.Add(this.textBox_SmallImageText);
            this.Controls.Add(this.checkBox_Party);
            this.Controls.Add(this.checkBox_End);
            this.Controls.Add(this.checkBox_Start);
            this.Controls.Add(this.checkBox_SmallImageText);
            this.Controls.Add(this.textBox_SmallImageKey);
            this.Controls.Add(this.checkBox_SmallImageKey);
            this.Controls.Add(this.textBox_LargeImageText);
            this.Controls.Add(this.checkBox_LargeImageText);
            this.Controls.Add(this.textBox_LargeImageKey);
            this.Controls.Add(this.checkBox_LargeImageKey);
            this.Controls.Add(this.textBox_State);
            this.Controls.Add(this.checkBox_State);
            this.Controls.Add(this.textBox_Details);
            this.Controls.Add(this.checkBox_Details);
            this.Controls.Add(this.label_StatusDescription);
            this.Controls.Add(this.label_PartyMax);
            this.Controls.Add(this.label_PartySize);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.Button_Help);
            this.Controls.Add(this.button_Connect);
            this.Controls.Add(this.textBox_ClientID);
            this.Controls.Add(this.label_ClientID);
            this.Controls.Add(this.nud_PartyMax);
            this.Controls.Add(this.nud_PartySize);
            this.Controls.Add(this.dtp_End);
            this.Controls.Add(this.dtp_Start);
            this.Controls.Add(this.listBox_Log);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(20, 100, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
            this.Text = "Discord Custom Presence Tool";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_PartySize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_PartyMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox_Log;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dtp_Start;
        private System.Windows.Forms.DateTimePicker dtp_End;
        private System.Windows.Forms.NumericUpDown nud_PartySize;
        private System.Windows.Forms.NumericUpDown nud_PartyMax;
        private MetroFramework.Controls.MetroLabel label_ClientID;
        private MetroFramework.Controls.MetroTextBox textBox_ClientID;
        private MetroFramework.Controls.MetroButton button_Connect;
        private MetroFramework.Controls.MetroButton Button_Help;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTextBox textBox_State;
        private MetroFramework.Controls.MetroCheckBox checkBox_State;
        private MetroFramework.Controls.MetroTextBox textBox_Details;
        private MetroFramework.Controls.MetroCheckBox checkBox_Details;
        private MetroFramework.Controls.MetroTextBox textBox_SmallImageText;
        private MetroFramework.Controls.MetroCheckBox checkBox_SmallImageText;
        private MetroFramework.Controls.MetroTextBox textBox_SmallImageKey;
        private MetroFramework.Controls.MetroCheckBox checkBox_SmallImageKey;
        private MetroFramework.Controls.MetroTextBox textBox_LargeImageText;
        private MetroFramework.Controls.MetroCheckBox checkBox_LargeImageText;
        private MetroFramework.Controls.MetroTextBox textBox_LargeImageKey;
        private MetroFramework.Controls.MetroCheckBox checkBox_LargeImageKey;
        private MetroFramework.Controls.MetroCheckBox checkBox_End;
        private MetroFramework.Controls.MetroCheckBox checkBox_Start;
        private MetroFramework.Controls.MetroCheckBox checkBox_Party;
        private MetroFramework.Controls.MetroLabel label_PartySize;
        private MetroFramework.Controls.MetroLabel label_PartyMax;
        private MetroFramework.Controls.MetroLabel label_StatusDescription;
        private MetroFramework.Controls.MetroLabel label_Status;
    }
}

