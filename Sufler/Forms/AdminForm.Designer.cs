namespace Sufler.Forms
{
    partial class AdminForm
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
            this.participantTableAdapter1 = new Sufler.Sufler_MironovDataSetTableAdapters.participantTableAdapter();
            this.roundedButtonProj = new Sufler.UserControl.RoundedButton();
            this.roundedButtonUser = new Sufler.UserControl.RoundedButton();
            this.roundedButtonTag = new Sufler.UserControl.RoundedButton();
            this.panelTag = new System.Windows.Forms.Panel();
            this.buttonDelTag = new System.Windows.Forms.Button();
            this.comboBoxTagDel = new System.Windows.Forms.ComboBox();
            this.buttonSaveTag = new System.Windows.Forms.Button();
            this.textBoxTagNameAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelProject = new System.Windows.Forms.Panel();
            this.flowLayoutPanelProj = new System.Windows.Forms.FlowLayoutPanel();
            this.roundedButtonDontPublished = new Sufler.UserControl.RoundedButton();
            this.roundedButtonPublished = new Sufler.UserControl.RoundedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanelUser = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAll = new System.Windows.Forms.Button();
            this.buttonFound = new System.Windows.Forms.Button();
            this.textBoxFound = new System.Windows.Forms.TextBox();
            this.panelTag.SuspendLayout();
            this.panelProject.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // participantTableAdapter1
            // 
            this.participantTableAdapter1.ClearBeforeFill = true;
            // 
            // roundedButtonProj
            // 
            this.roundedButtonProj.BackColor = System.Drawing.Color.Transparent;
            this.roundedButtonProj.BackgroundColor = System.Drawing.Color.Transparent;
            this.roundedButtonProj.BorderColor = System.Drawing.Color.Black;
            this.roundedButtonProj.BorderRadius = 0;
            this.roundedButtonProj.BorderSize = 2;
            this.roundedButtonProj.FlatAppearance.BorderSize = 0;
            this.roundedButtonProj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonProj.ForeColor = System.Drawing.Color.Black;
            this.roundedButtonProj.Location = new System.Drawing.Point(12, 31);
            this.roundedButtonProj.Name = "roundedButtonProj";
            this.roundedButtonProj.Size = new System.Drawing.Size(84, 40);
            this.roundedButtonProj.TabIndex = 0;
            this.roundedButtonProj.Text = "Проекты";
            this.roundedButtonProj.TextColor = System.Drawing.Color.Black;
            this.roundedButtonProj.UseVisualStyleBackColor = false;
            this.roundedButtonProj.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // roundedButtonUser
            // 
            this.roundedButtonUser.BackColor = System.Drawing.Color.Transparent;
            this.roundedButtonUser.BackgroundColor = System.Drawing.Color.Transparent;
            this.roundedButtonUser.BorderColor = System.Drawing.Color.Black;
            this.roundedButtonUser.BorderRadius = 0;
            this.roundedButtonUser.BorderSize = 2;
            this.roundedButtonUser.FlatAppearance.BorderSize = 0;
            this.roundedButtonUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonUser.ForeColor = System.Drawing.Color.Black;
            this.roundedButtonUser.Location = new System.Drawing.Point(102, 31);
            this.roundedButtonUser.Name = "roundedButtonUser";
            this.roundedButtonUser.Size = new System.Drawing.Size(100, 40);
            this.roundedButtonUser.TabIndex = 1;
            this.roundedButtonUser.Text = "Пользователи";
            this.roundedButtonUser.TextColor = System.Drawing.Color.Black;
            this.roundedButtonUser.UseVisualStyleBackColor = false;
            this.roundedButtonUser.Click += new System.EventHandler(this.roundedButtonUser_Click);
            // 
            // roundedButtonTag
            // 
            this.roundedButtonTag.BackColor = System.Drawing.Color.Transparent;
            this.roundedButtonTag.BackgroundColor = System.Drawing.Color.Transparent;
            this.roundedButtonTag.BorderColor = System.Drawing.Color.Black;
            this.roundedButtonTag.BorderRadius = 0;
            this.roundedButtonTag.BorderSize = 2;
            this.roundedButtonTag.FlatAppearance.BorderSize = 0;
            this.roundedButtonTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonTag.ForeColor = System.Drawing.Color.Black;
            this.roundedButtonTag.Location = new System.Drawing.Point(208, 31);
            this.roundedButtonTag.Name = "roundedButtonTag";
            this.roundedButtonTag.Size = new System.Drawing.Size(52, 40);
            this.roundedButtonTag.TabIndex = 2;
            this.roundedButtonTag.Text = "Теги";
            this.roundedButtonTag.TextColor = System.Drawing.Color.Black;
            this.roundedButtonTag.UseVisualStyleBackColor = false;
            this.roundedButtonTag.Click += new System.EventHandler(this.roundedButtonTag_Click);
            // 
            // panelTag
            // 
            this.panelTag.Controls.Add(this.buttonDelTag);
            this.panelTag.Controls.Add(this.comboBoxTagDel);
            this.panelTag.Controls.Add(this.buttonSaveTag);
            this.panelTag.Controls.Add(this.textBoxTagNameAdd);
            this.panelTag.Controls.Add(this.label2);
            this.panelTag.Controls.Add(this.label1);
            this.panelTag.Location = new System.Drawing.Point(13, 78);
            this.panelTag.Name = "panelTag";
            this.panelTag.Size = new System.Drawing.Size(612, 360);
            this.panelTag.TabIndex = 3;
            // 
            // buttonDelTag
            // 
            this.buttonDelTag.Location = new System.Drawing.Point(6, 156);
            this.buttonDelTag.Name = "buttonDelTag";
            this.buttonDelTag.Size = new System.Drawing.Size(150, 23);
            this.buttonDelTag.TabIndex = 5;
            this.buttonDelTag.Text = "Удалить";
            this.buttonDelTag.UseVisualStyleBackColor = true;
            this.buttonDelTag.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // comboBoxTagDel
            // 
            this.comboBoxTagDel.FormattingEnabled = true;
            this.comboBoxTagDel.Location = new System.Drawing.Point(6, 128);
            this.comboBoxTagDel.Name = "comboBoxTagDel";
            this.comboBoxTagDel.Size = new System.Drawing.Size(150, 21);
            this.comboBoxTagDel.TabIndex = 4;
            // 
            // buttonSaveTag
            // 
            this.buttonSaveTag.Location = new System.Drawing.Point(6, 60);
            this.buttonSaveTag.Name = "buttonSaveTag";
            this.buttonSaveTag.Size = new System.Drawing.Size(150, 23);
            this.buttonSaveTag.TabIndex = 3;
            this.buttonSaveTag.Text = "Сохранить";
            this.buttonSaveTag.UseVisualStyleBackColor = true;
            this.buttonSaveTag.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxTagNameAdd
            // 
            this.textBoxTagNameAdd.Location = new System.Drawing.Point(6, 32);
            this.textBoxTagNameAdd.Name = "textBoxTagNameAdd";
            this.textBoxTagNameAdd.Size = new System.Drawing.Size(150, 22);
            this.textBoxTagNameAdd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Удалить тег";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавить тег";
            // 
            // panelProject
            // 
            this.panelProject.Controls.Add(this.flowLayoutPanelProj);
            this.panelProject.Controls.Add(this.roundedButtonDontPublished);
            this.panelProject.Controls.Add(this.roundedButtonPublished);
            this.panelProject.Location = new System.Drawing.Point(13, 77);
            this.panelProject.Name = "panelProject";
            this.panelProject.Size = new System.Drawing.Size(612, 361);
            this.panelProject.TabIndex = 4;
            // 
            // flowLayoutPanelProj
            // 
            this.flowLayoutPanelProj.AutoScroll = true;
            this.flowLayoutPanelProj.Location = new System.Drawing.Point(0, 51);
            this.flowLayoutPanelProj.Name = "flowLayoutPanelProj";
            this.flowLayoutPanelProj.Size = new System.Drawing.Size(612, 310);
            this.flowLayoutPanelProj.TabIndex = 2;
            // 
            // roundedButtonDontPublished
            // 
            this.roundedButtonDontPublished.BackColor = System.Drawing.Color.Transparent;
            this.roundedButtonDontPublished.BackgroundColor = System.Drawing.Color.Transparent;
            this.roundedButtonDontPublished.BorderColor = System.Drawing.Color.Black;
            this.roundedButtonDontPublished.BorderRadius = 0;
            this.roundedButtonDontPublished.BorderSize = 2;
            this.roundedButtonDontPublished.FlatAppearance.BorderSize = 0;
            this.roundedButtonDontPublished.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonDontPublished.ForeColor = System.Drawing.Color.Black;
            this.roundedButtonDontPublished.Location = new System.Drawing.Point(120, 4);
            this.roundedButtonDontPublished.Name = "roundedButtonDontPublished";
            this.roundedButtonDontPublished.Size = new System.Drawing.Size(127, 40);
            this.roundedButtonDontPublished.TabIndex = 1;
            this.roundedButtonDontPublished.Text = "Не публикованные";
            this.roundedButtonDontPublished.TextColor = System.Drawing.Color.Black;
            this.roundedButtonDontPublished.UseVisualStyleBackColor = false;
            this.roundedButtonDontPublished.Click += new System.EventHandler(this.roundedButtonDontPublished_Click);
            // 
            // roundedButtonPublished
            // 
            this.roundedButtonPublished.BackColor = System.Drawing.Color.Transparent;
            this.roundedButtonPublished.BackgroundColor = System.Drawing.Color.Transparent;
            this.roundedButtonPublished.BorderColor = System.Drawing.Color.Black;
            this.roundedButtonPublished.BorderRadius = 0;
            this.roundedButtonPublished.BorderSize = 2;
            this.roundedButtonPublished.FlatAppearance.BorderSize = 0;
            this.roundedButtonPublished.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonPublished.ForeColor = System.Drawing.Color.Black;
            this.roundedButtonPublished.Location = new System.Drawing.Point(0, 4);
            this.roundedButtonPublished.Name = "roundedButtonPublished";
            this.roundedButtonPublished.Size = new System.Drawing.Size(114, 40);
            this.roundedButtonPublished.TabIndex = 0;
            this.roundedButtonPublished.Text = "Опубликованные";
            this.roundedButtonPublished.TextColor = System.Drawing.Color.Black;
            this.roundedButtonPublished.UseVisualStyleBackColor = false;
            this.roundedButtonPublished.Click += new System.EventHandler(this.roundedButtonPublished_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanelUser);
            this.panel1.Controls.Add(this.buttonAll);
            this.panel1.Controls.Add(this.buttonFound);
            this.panel1.Controls.Add(this.textBoxFound);
            this.panel1.Location = new System.Drawing.Point(12, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 361);
            this.panel1.TabIndex = 5;
            // 
            // flowLayoutPanelUser
            // 
            this.flowLayoutPanelUser.Location = new System.Drawing.Point(0, 34);
            this.flowLayoutPanelUser.Name = "flowLayoutPanelUser";
            this.flowLayoutPanelUser.Size = new System.Drawing.Size(610, 324);
            this.flowLayoutPanelUser.TabIndex = 3;
            // 
            // buttonAll
            // 
            this.buttonAll.Location = new System.Drawing.Point(187, 7);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(75, 23);
            this.buttonAll.TabIndex = 2;
            this.buttonAll.Text = "Все";
            this.buttonAll.UseVisualStyleBackColor = true;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // buttonFound
            // 
            this.buttonFound.Location = new System.Drawing.Point(106, 7);
            this.buttonFound.Name = "buttonFound";
            this.buttonFound.Size = new System.Drawing.Size(75, 23);
            this.buttonFound.TabIndex = 1;
            this.buttonFound.Text = "Найти";
            this.buttonFound.UseVisualStyleBackColor = true;
            this.buttonFound.Click += new System.EventHandler(this.buttonFound_Click);
            // 
            // textBoxFound
            // 
            this.textBoxFound.Location = new System.Drawing.Point(0, 8);
            this.textBoxFound.Name = "textBoxFound";
            this.textBoxFound.Size = new System.Drawing.Size(100, 22);
            this.textBoxFound.TabIndex = 0;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelProject);
            this.Controls.Add(this.panelTag);
            this.Controls.Add(this.roundedButtonTag);
            this.Controls.Add(this.roundedButtonUser);
            this.Controls.Add(this.roundedButtonProj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panelTag.ResumeLayout(false);
            this.panelTag.PerformLayout();
            this.panelProject.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sufler_MironovDataSetTableAdapters.participantTableAdapter participantTableAdapter1;
        private UserControl.RoundedButton roundedButtonProj;
        private UserControl.RoundedButton roundedButtonUser;
        private UserControl.RoundedButton roundedButtonTag;
        private System.Windows.Forms.Panel panelTag;
        private System.Windows.Forms.Button buttonDelTag;
        private System.Windows.Forms.ComboBox comboBoxTagDel;
        private System.Windows.Forms.Button buttonSaveTag;
        private System.Windows.Forms.TextBox textBoxTagNameAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelProject;
        private UserControl.RoundedButton roundedButtonPublished;
        private UserControl.RoundedButton roundedButtonDontPublished;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProj;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxFound;
        private System.Windows.Forms.Button buttonAll;
        private System.Windows.Forms.Button buttonFound;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelUser;
    }
}