namespace Sufler.Forms
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonChangeInfo = new System.Windows.Forms.Button();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.labelDateCreate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.panelOtzev = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonOtzev = new System.Windows.Forms.Button();
            this.labelBall = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonZakaz = new System.Windows.Forms.RadioButton();
            this.radioButtonIsp = new System.Windows.Forms.RadioButton();
            this.roundedButtonOtzev = new Sufler.UserControl.RoundedButton();
            this.roundedButtonInfo = new Sufler.UserControl.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            this.panelInfo.SuspendLayout();
            this.panelOtzev.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelInfo);
            this.splitContainer1.Panel2.Controls.Add(this.panelOtzev);
            this.splitContainer1.Panel2.Controls.Add(this.roundedButtonOtzev);
            this.splitContainer1.Panel2.Controls.Add(this.roundedButtonInfo);
            this.splitContainer1.Size = new System.Drawing.Size(734, 711);
            this.splitContainer1.SplitterDistance = 151;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.04598F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.95403F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxAvatar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelName, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.39436F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.60563F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(734, 151);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxAvatar.BackColor = System.Drawing.Color.Gray;
            this.pictureBoxAvatar.Location = new System.Drawing.Point(298, 12);
            this.pictureBoxAvatar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(117, 100);
            this.pictureBoxAvatar.TabIndex = 0;
            this.pictureBoxAvatar.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(337, 131);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(39, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "label1";
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.buttonDel);
            this.panelInfo.Controls.Add(this.buttonChangeInfo);
            this.panelInfo.Controls.Add(this.textBoxInfo);
            this.panelInfo.Controls.Add(this.labelDateCreate);
            this.panelInfo.Controls.Add(this.label3);
            this.panelInfo.Controls.Add(this.labelDate);
            this.panelInfo.Controls.Add(this.labelPhone);
            this.panelInfo.Location = new System.Drawing.Point(14, 79);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(708, 465);
            this.panelInfo.TabIndex = 3;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(13, 234);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 6;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonChangeInfo
            // 
            this.buttonChangeInfo.Location = new System.Drawing.Point(13, 204);
            this.buttonChangeInfo.Name = "buttonChangeInfo";
            this.buttonChangeInfo.Size = new System.Drawing.Size(114, 23);
            this.buttonChangeInfo.TabIndex = 5;
            this.buttonChangeInfo.Text = "Редактировать";
            this.buttonChangeInfo.UseVisualStyleBackColor = true;
            this.buttonChangeInfo.Click += new System.EventHandler(this.buttonChangeInfo_Click);
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(60, 81);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.ReadOnly = true;
            this.textBoxInfo.Size = new System.Drawing.Size(364, 78);
            this.textBoxInfo.TabIndex = 4;
            // 
            // labelDateCreate
            // 
            this.labelDateCreate.AutoSize = true;
            this.labelDateCreate.Location = new System.Drawing.Point(10, 175);
            this.labelDateCreate.Name = "labelDateCreate";
            this.labelDateCreate.Size = new System.Drawing.Size(39, 13);
            this.labelDateCreate.TabIndex = 3;
            this.labelDateCreate.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "О себе:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(10, 51);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(39, 13);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "label2";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(10, 24);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(39, 13);
            this.labelPhone.TabIndex = 0;
            this.labelPhone.Text = "label1";
            // 
            // panelOtzev
            // 
            this.panelOtzev.Controls.Add(this.flowLayoutPanel1);
            this.panelOtzev.Controls.Add(this.buttonOtzev);
            this.panelOtzev.Controls.Add(this.labelBall);
            this.panelOtzev.Controls.Add(this.groupBox1);
            this.panelOtzev.Location = new System.Drawing.Point(14, 79);
            this.panelOtzev.Name = "panelOtzev";
            this.panelOtzev.Size = new System.Drawing.Size(708, 465);
            this.panelOtzev.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 127);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(637, 320);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // buttonOtzev
            // 
            this.buttonOtzev.Location = new System.Drawing.Point(13, 97);
            this.buttonOtzev.Name = "buttonOtzev";
            this.buttonOtzev.Size = new System.Drawing.Size(114, 23);
            this.buttonOtzev.TabIndex = 2;
            this.buttonOtzev.Text = "Оставить отзыв";
            this.buttonOtzev.UseVisualStyleBackColor = true;
            this.buttonOtzev.Click += new System.EventHandler(this.buttonOtzev_Click);
            // 
            // labelBall
            // 
            this.labelBall.AutoSize = true;
            this.labelBall.Location = new System.Drawing.Point(10, 81);
            this.labelBall.Name = "labelBall";
            this.labelBall.Size = new System.Drawing.Size(54, 13);
            this.labelBall.TabIndex = 1;
            this.labelBall.Text = "Оценка: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonZakaz);
            this.groupBox1.Controls.Add(this.radioButtonIsp);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonZakaz
            // 
            this.radioButtonZakaz.AutoSize = true;
            this.radioButtonZakaz.Location = new System.Drawing.Point(7, 44);
            this.radioButtonZakaz.Name = "radioButtonZakaz";
            this.radioButtonZakaz.Size = new System.Drawing.Size(75, 17);
            this.radioButtonZakaz.TabIndex = 1;
            this.radioButtonZakaz.Text = "Заказчик";
            this.radioButtonZakaz.UseVisualStyleBackColor = true;
            this.radioButtonZakaz.CheckedChanged += new System.EventHandler(this.radioButtonZakaz_CheckedChanged);
            // 
            // radioButtonIsp
            // 
            this.radioButtonIsp.AutoSize = true;
            this.radioButtonIsp.Location = new System.Drawing.Point(7, 21);
            this.radioButtonIsp.Name = "radioButtonIsp";
            this.radioButtonIsp.Size = new System.Drawing.Size(102, 17);
            this.radioButtonIsp.TabIndex = 0;
            this.radioButtonIsp.Text = "Исполнитель";
            this.radioButtonIsp.UseVisualStyleBackColor = true;
            this.radioButtonIsp.CheckedChanged += new System.EventHandler(this.radioButtonIsp_CheckedChanged);
            // 
            // roundedButtonOtzev
            // 
            this.roundedButtonOtzev.BackColor = System.Drawing.Color.Transparent;
            this.roundedButtonOtzev.BackgroundColor = System.Drawing.Color.Transparent;
            this.roundedButtonOtzev.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundedButtonOtzev.BorderRadius = 0;
            this.roundedButtonOtzev.BorderSize = 0;
            this.roundedButtonOtzev.FlatAppearance.BorderSize = 0;
            this.roundedButtonOtzev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonOtzev.ForeColor = System.Drawing.Color.Black;
            this.roundedButtonOtzev.Location = new System.Drawing.Point(81, 49);
            this.roundedButtonOtzev.Name = "roundedButtonOtzev";
            this.roundedButtonOtzev.Size = new System.Drawing.Size(133, 24);
            this.roundedButtonOtzev.TabIndex = 1;
            this.roundedButtonOtzev.Text = "Рейтинг и отзывы";
            this.roundedButtonOtzev.TextColor = System.Drawing.Color.Black;
            this.roundedButtonOtzev.UseVisualStyleBackColor = false;
            this.roundedButtonOtzev.Click += new System.EventHandler(this.roundedButtonOtzev_Click);
            // 
            // roundedButtonInfo
            // 
            this.roundedButtonInfo.BackColor = System.Drawing.Color.Transparent;
            this.roundedButtonInfo.BackgroundColor = System.Drawing.Color.Transparent;
            this.roundedButtonInfo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundedButtonInfo.BorderRadius = 0;
            this.roundedButtonInfo.BorderSize = 0;
            this.roundedButtonInfo.FlatAppearance.BorderSize = 0;
            this.roundedButtonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonInfo.ForeColor = System.Drawing.Color.Black;
            this.roundedButtonInfo.Location = new System.Drawing.Point(12, 49);
            this.roundedButtonInfo.Name = "roundedButtonInfo";
            this.roundedButtonInfo.Size = new System.Drawing.Size(63, 24);
            this.roundedButtonInfo.TabIndex = 0;
            this.roundedButtonInfo.Text = "Обо мне";
            this.roundedButtonInfo.TextColor = System.Drawing.Color.Black;
            this.roundedButtonInfo.UseVisualStyleBackColor = false;
            this.roundedButtonInfo.Click += new System.EventHandler(this.roundedButtonInfo_Click);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 711);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "ProfileForm";
            this.Text = "Профиль";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelOtzev.ResumeLayout(false);
            this.panelOtzev.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBoxAvatar;
        private System.Windows.Forms.Label labelName;
        private UserControl.RoundedButton roundedButtonOtzev;
        private UserControl.RoundedButton roundedButtonInfo;
        private System.Windows.Forms.Panel panelOtzev;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonZakaz;
        private System.Windows.Forms.RadioButton radioButtonIsp;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonOtzev;
        private System.Windows.Forms.Label labelBall;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.Label labelDateCreate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Button buttonChangeInfo;
        private System.Windows.Forms.Button buttonDel;
    }
}