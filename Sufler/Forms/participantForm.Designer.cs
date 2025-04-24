namespace Sufler.Forms
{
    partial class participantForm
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
            this.roundedButtonPartipants = new Sufler.UserControl.RoundedButton();
            this.roundedButtonResponse = new Sufler.UserControl.RoundedButton();
            this.flowLayoutPanelParsipants = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelResp = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // roundedButtonPartipants
            // 
            this.roundedButtonPartipants.BackColor = System.Drawing.Color.Transparent;
            this.roundedButtonPartipants.BackgroundColor = System.Drawing.Color.Transparent;
            this.roundedButtonPartipants.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundedButtonPartipants.BorderRadius = 0;
            this.roundedButtonPartipants.BorderSize = 0;
            this.roundedButtonPartipants.FlatAppearance.BorderSize = 0;
            this.roundedButtonPartipants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonPartipants.ForeColor = System.Drawing.Color.Black;
            this.roundedButtonPartipants.Location = new System.Drawing.Point(12, 12);
            this.roundedButtonPartipants.Name = "roundedButtonPartipants";
            this.roundedButtonPartipants.Size = new System.Drawing.Size(150, 40);
            this.roundedButtonPartipants.TabIndex = 0;
            this.roundedButtonPartipants.Text = "Участники";
            this.roundedButtonPartipants.TextColor = System.Drawing.Color.Black;
            this.roundedButtonPartipants.UseVisualStyleBackColor = false;
            this.roundedButtonPartipants.Click += new System.EventHandler(this.roundedButtonParticipants_Click);
            // 
            // roundedButtonResponse
            // 
            this.roundedButtonResponse.BackColor = System.Drawing.Color.Transparent;
            this.roundedButtonResponse.BackgroundColor = System.Drawing.Color.Transparent;
            this.roundedButtonResponse.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundedButtonResponse.BorderRadius = 0;
            this.roundedButtonResponse.BorderSize = 0;
            this.roundedButtonResponse.FlatAppearance.BorderSize = 0;
            this.roundedButtonResponse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonResponse.ForeColor = System.Drawing.Color.Black;
            this.roundedButtonResponse.Location = new System.Drawing.Point(168, 12);
            this.roundedButtonResponse.Name = "roundedButtonResponse";
            this.roundedButtonResponse.Size = new System.Drawing.Size(150, 40);
            this.roundedButtonResponse.TabIndex = 1;
            this.roundedButtonResponse.Text = "Запросы";
            this.roundedButtonResponse.TextColor = System.Drawing.Color.Black;
            this.roundedButtonResponse.UseVisualStyleBackColor = false;
            this.roundedButtonResponse.Click += new System.EventHandler(this.roundedButtonResponse_Click);
            // 
            // flowLayoutPanelParsipants
            // 
            this.flowLayoutPanelParsipants.Location = new System.Drawing.Point(13, 59);
            this.flowLayoutPanelParsipants.Name = "flowLayoutPanelParsipants";
            this.flowLayoutPanelParsipants.Size = new System.Drawing.Size(441, 379);
            this.flowLayoutPanelParsipants.TabIndex = 2;
            // 
            // flowLayoutPanelResp
            // 
            this.flowLayoutPanelResp.Location = new System.Drawing.Point(12, 59);
            this.flowLayoutPanelResp.Name = "flowLayoutPanelResp";
            this.flowLayoutPanelResp.Size = new System.Drawing.Size(442, 379);
            this.flowLayoutPanelResp.TabIndex = 3;
            // 
            // participantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 450);
            this.Controls.Add(this.flowLayoutPanelResp);
            this.Controls.Add(this.flowLayoutPanelParsipants);
            this.Controls.Add(this.roundedButtonResponse);
            this.Controls.Add(this.roundedButtonPartipants);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "participantForm";
            this.Text = "Участники";
            this.Load += new System.EventHandler(this.participantForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl.RoundedButton roundedButtonPartipants;
        private UserControl.RoundedButton roundedButtonResponse;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelParsipants;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelResp;
    }
}