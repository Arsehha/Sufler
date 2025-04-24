namespace Sufler.CustomControl
{
    partial class ProjectItemControl
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTag = new System.Windows.Forms.Label();
            this.buttonClOp = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonRicipient = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(9, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "label1";
            // 
            // labelPrice
            // 
            this.labelPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(441, 9);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(35, 13);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "label2";
            // 
            // labelDate
            // 
            this.labelDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(441, 31);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(35, 13);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "label3";
            // 
            // labelTag
            // 
            this.labelTag.AutoSize = true;
            this.labelTag.Location = new System.Drawing.Point(9, 44);
            this.labelTag.Name = "labelTag";
            this.labelTag.Size = new System.Drawing.Size(35, 13);
            this.labelTag.TabIndex = 3;
            this.labelTag.Text = "label1";
            // 
            // buttonClOp
            // 
            this.buttonClOp.Location = new System.Drawing.Point(12, 69);
            this.buttonClOp.Name = "buttonClOp";
            this.buttonClOp.Size = new System.Drawing.Size(75, 23);
            this.buttonClOp.TabIndex = 4;
            this.buttonClOp.Text = "Закрыть";
            this.buttonClOp.UseVisualStyleBackColor = true;
            this.buttonClOp.Click += new System.EventHandler(this.buttonClOp_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(93, 69);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(93, 23);
            this.buttonChange.TabIndex = 5;
            this.buttonChange.Text = "Редактировать";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(192, 69);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 6;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonRicipient
            // 
            this.buttonRicipient.Location = new System.Drawing.Point(417, 69);
            this.buttonRicipient.Name = "buttonRicipient";
            this.buttonRicipient.Size = new System.Drawing.Size(75, 23);
            this.buttonRicipient.TabIndex = 7;
            this.buttonRicipient.Text = "Участники";
            this.buttonRicipient.UseVisualStyleBackColor = true;
            this.buttonRicipient.Click += new System.EventHandler(this.buttonRicipient_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(417, 69);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 8;
            this.buttonBack.Text = "Покинуть";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // ProjectItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonRicipient);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonClOp);
            this.Controls.Add(this.labelTag);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelName);
            this.Name = "ProjectItemControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(500, 100);
            this.Load += new System.EventHandler(this.ProjectItemControl_Load);
            this.Click += new System.EventHandler(this.ProjectItemControl_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTag;
        private System.Windows.Forms.Button buttonClOp;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonRicipient;
        private System.Windows.Forms.Button buttonBack;
    }
}