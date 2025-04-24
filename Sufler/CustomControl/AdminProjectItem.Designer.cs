namespace Sufler.CustomControl
{
    partial class AdminProjectItem
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
            this.labelNameProj = new System.Windows.Forms.Label();
            this.labelTagProj = new System.Windows.Forms.Label();
            this.labelDateEnd = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.buttonPush = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNameProj
            // 
            this.labelNameProj.AutoSize = true;
            this.labelNameProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameProj.Location = new System.Drawing.Point(3, 13);
            this.labelNameProj.Margin = new System.Windows.Forms.Padding(3);
            this.labelNameProj.Name = "labelNameProj";
            this.labelNameProj.Size = new System.Drawing.Size(51, 20);
            this.labelNameProj.TabIndex = 0;
            this.labelNameProj.Text = "label1";
            this.labelNameProj.Click += new System.EventHandler(this.AdminProjectItem_Click);
            // 
            // labelTagProj
            // 
            this.labelTagProj.AutoSize = true;
            this.labelTagProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTagProj.Location = new System.Drawing.Point(3, 36);
            this.labelTagProj.Name = "labelTagProj";
            this.labelTagProj.Size = new System.Drawing.Size(44, 16);
            this.labelTagProj.TabIndex = 1;
            this.labelTagProj.Text = "label2";
            this.labelTagProj.Click += new System.EventHandler(this.AdminProjectItem_Click);
            // 
            // labelDateEnd
            // 
            this.labelDateEnd.AutoSize = true;
            this.labelDateEnd.Location = new System.Drawing.Point(3, 57);
            this.labelDateEnd.Name = "labelDateEnd";
            this.labelDateEnd.Size = new System.Drawing.Size(35, 13);
            this.labelDateEnd.TabIndex = 2;
            this.labelDateEnd.Text = "label3";
            this.labelDateEnd.Click += new System.EventHandler(this.AdminProjectItem_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(418, 13);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(35, 13);
            this.labelPrice.TabIndex = 3;
            this.labelPrice.Text = "label4";
            this.labelPrice.Click += new System.EventHandler(this.AdminProjectItem_Click);
            // 
            // buttonPush
            // 
            this.buttonPush.Location = new System.Drawing.Point(381, 47);
            this.buttonPush.Name = "buttonPush";
            this.buttonPush.Size = new System.Drawing.Size(92, 23);
            this.buttonPush.TabIndex = 4;
            this.buttonPush.Text = "Опубликовать";
            this.buttonPush.UseVisualStyleBackColor = true;
            this.buttonPush.Click += new System.EventHandler(this.buttonPush_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(300, 47);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 5;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // AdminProjectItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonPush);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelDateEnd);
            this.Controls.Add(this.labelTagProj);
            this.Controls.Add(this.labelNameProj);
            this.Name = "AdminProjectItem";
            this.Size = new System.Drawing.Size(484, 75);
            this.Load += new System.EventHandler(this.AdminProjectItem_Load);
            this.Click += new System.EventHandler(this.AdminProjectItem_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameProj;
        private System.Windows.Forms.Label labelTagProj;
        private System.Windows.Forms.Label labelDateEnd;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button buttonPush;
        private System.Windows.Forms.Button buttonDel;
    }
}