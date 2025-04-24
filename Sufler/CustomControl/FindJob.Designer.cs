namespace Sufler.CustomControl
{
    partial class FindJob
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
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelTag = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelProject = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип заказа";
            // 
            // flowLayoutPanelTag
            // 
            this.flowLayoutPanelTag.AutoScroll = true;
            this.flowLayoutPanelTag.Location = new System.Drawing.Point(19, 64);
            this.flowLayoutPanelTag.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanelTag.Name = "flowLayoutPanelTag";
            this.flowLayoutPanelTag.Size = new System.Drawing.Size(960, 161);
            this.flowLayoutPanelTag.TabIndex = 1;
            // 
            // flowLayoutPanelProject
            // 
            this.flowLayoutPanelProject.AutoScroll = true;
            this.flowLayoutPanelProject.Location = new System.Drawing.Point(238, 233);
            this.flowLayoutPanelProject.Name = "flowLayoutPanelProject";
            this.flowLayoutPanelProject.Size = new System.Drawing.Size(540, 364);
            this.flowLayoutPanelProject.TabIndex = 2;
            // 
            // FindJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanelProject);
            this.Controls.Add(this.flowLayoutPanelTag);
            this.Controls.Add(this.label1);
            this.Name = "FindJob";
            this.Size = new System.Drawing.Size(1000, 600);
            this.Load += new System.EventHandler(this.FindJob_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTag;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProject;
    }
}