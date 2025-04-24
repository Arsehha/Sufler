namespace Sufler.Forms
{
    partial class ResponseForm
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
            System.Windows.Forms.Label messageLabel;
            this.sufler_MironovDataSet = new Sufler.Sufler_MironovDataSet();
            this.responseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.responseTableAdapter = new Sufler.Sufler_MironovDataSetTableAdapters.responseTableAdapter();
            this.tableAdapterManager = new Sufler.Sufler_MironovDataSetTableAdapters.TableAdapterManager();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            messageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sufler_MironovDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Location = new System.Drawing.Point(8, 15);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(68, 13);
            messageLabel.TabIndex = 1;
            messageLabel.Text = "Сообщение:";
            // 
            // sufler_MironovDataSet
            // 
            this.sufler_MironovDataSet.DataSetName = "Sufler_MironovDataSet";
            this.sufler_MironovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // responseBindingSource
            // 
            this.responseBindingSource.DataMember = "response";
            this.responseBindingSource.DataSource = this.sufler_MironovDataSet;
            // 
            // responseTableAdapter
            // 
            this.responseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.participantTableAdapter = null;
            this.tableAdapterManager.projectTableAdapter = null;
            this.tableAdapterManager.responseTableAdapter = this.responseTableAdapter;
            this.tableAdapterManager.reviewTableAdapter = null;
            this.tableAdapterManager.tagTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Sufler.Sufler_MironovDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // messageTextBox
            // 
            this.messageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.responseBindingSource, "message", true));
            this.messageTextBox.Location = new System.Drawing.Point(82, 12);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(184, 152);
            this.messageTextBox.TabIndex = 2;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(11, 170);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(255, 23);
            this.buttonSend.TabIndex = 3;
            this.buttonSend.Text = "Отправить";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // ResponseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 202);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(messageLabel);
            this.Controls.Add(this.messageTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ResponseForm";
            this.Text = "Отклик";
            this.Load += new System.EventHandler(this.ResponseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sufler_MironovDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sufler_MironovDataSet sufler_MironovDataSet;
        private System.Windows.Forms.BindingSource responseBindingSource;
        private Sufler_MironovDataSetTableAdapters.responseTableAdapter responseTableAdapter;
        private Sufler_MironovDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Button buttonSend;
    }
}