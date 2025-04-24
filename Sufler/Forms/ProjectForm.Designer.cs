namespace Sufler.Forms
{
    partial class ProjectForm
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
            this.labelProjectName = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCountReview = new System.Windows.Forms.Label();
            this.labelZakName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelDateEnd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.labelDateCreate = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.roundedButtonOtcl = new Sufler.UserControl.RoundedButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelProjectName
            // 
            this.labelProjectName.AutoSize = true;
            this.labelProjectName.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProjectName.Location = new System.Drawing.Point(13, 25);
            this.labelProjectName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProjectName.Name = "labelProjectName";
            this.labelProjectName.Size = new System.Drawing.Size(74, 30);
            this.labelProjectName.TabIndex = 0;
            this.labelProjectName.Text = "label1";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(18, 59);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(39, 13);
            this.labelCount.TabIndex = 1;
            this.labelCount.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelCountReview);
            this.panel1.Controls.Add(this.labelZakName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(21, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 83);
            this.panel1.TabIndex = 2;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // labelCountReview
            // 
            this.labelCountReview.AutoSize = true;
            this.labelCountReview.Location = new System.Drawing.Point(87, 45);
            this.labelCountReview.Name = "labelCountReview";
            this.labelCountReview.Size = new System.Drawing.Size(39, 13);
            this.labelCountReview.TabIndex = 2;
            this.labelCountReview.Text = "label1";
            this.labelCountReview.Click += new System.EventHandler(this.panel1_Click);
            // 
            // labelZakName
            // 
            this.labelZakName.AutoSize = true;
            this.labelZakName.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelZakName.Location = new System.Drawing.Point(84, 14);
            this.labelZakName.Name = "labelZakName";
            this.labelZakName.Size = new System.Drawing.Size(46, 17);
            this.labelZakName.TabIndex = 1;
            this.labelZakName.Text = "label1";
            this.labelZakName.Click += new System.EventHandler(this.panel1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Location = new System.Drawing.Point(6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(826, 98);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(46, 17);
            this.labelPrice.TabIndex = 3;
            this.labelPrice.Text = "label1";
            // 
            // labelDateEnd
            // 
            this.labelDateEnd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelDateEnd.AutoSize = true;
            this.labelDateEnd.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateEnd.Location = new System.Drawing.Point(728, 129);
            this.labelDateEnd.Name = "labelDateEnd";
            this.labelDateEnd.Size = new System.Drawing.Size(46, 17);
            this.labelDateEnd.TabIndex = 4;
            this.labelDateEnd.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Описание заказа:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(24, 209);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(365, 134);
            this.textBoxDesc.TabIndex = 6;
            // 
            // labelDateCreate
            // 
            this.labelDateCreate.AutoSize = true;
            this.labelDateCreate.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateCreate.Location = new System.Drawing.Point(21, 356);
            this.labelDateCreate.Name = "labelDateCreate";
            this.labelDateCreate.Size = new System.Drawing.Size(46, 13);
            this.labelDateCreate.TabIndex = 7;
            this.labelDateCreate.Text = "Дата п";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(472, 209);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(400, 134);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(469, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Участники";
            // 
            // roundedButtonOtcl
            // 
            this.roundedButtonOtcl.BackColor = System.Drawing.Color.Transparent;
            this.roundedButtonOtcl.BackgroundColor = System.Drawing.Color.Transparent;
            this.roundedButtonOtcl.BorderColor = System.Drawing.Color.Black;
            this.roundedButtonOtcl.BorderRadius = 19;
            this.roundedButtonOtcl.BorderSize = 2;
            this.roundedButtonOtcl.FlatAppearance.BorderSize = 0;
            this.roundedButtonOtcl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonOtcl.ForeColor = System.Drawing.Color.Black;
            this.roundedButtonOtcl.Location = new System.Drawing.Point(722, 163);
            this.roundedButtonOtcl.Name = "roundedButtonOtcl";
            this.roundedButtonOtcl.Size = new System.Drawing.Size(150, 40);
            this.roundedButtonOtcl.TabIndex = 10;
            this.roundedButtonOtcl.Text = "Откликнуться";
            this.roundedButtonOtcl.TextColor = System.Drawing.Color.Black;
            this.roundedButtonOtcl.UseVisualStyleBackColor = false;
            this.roundedButtonOtcl.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 388);
            this.Controls.Add(this.roundedButtonOtcl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.labelDateCreate);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDateEnd);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelProjectName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "ProjectForm";
            this.Text = "Заказ";
            this.Load += new System.EventHandler(this.ProjectForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProjectName;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelCountReview;
        private System.Windows.Forms.Label labelZakName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelDateEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.Label labelDateCreate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private UserControl.RoundedButton roundedButtonOtcl;
    }
}