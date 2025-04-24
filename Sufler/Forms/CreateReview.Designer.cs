namespace Sufler.Forms
{
    partial class CreateReview
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
            System.Windows.Forms.Label rateLabel;
            System.Windows.Forms.Label textLabel;
            this.sufler_MironovDataSet = new Sufler.Sufler_MironovDataSet();
            this.reviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reviewTableAdapter = new Sufler.Sufler_MironovDataSetTableAdapters.reviewTableAdapter();
            this.tableAdapterManager = new Sufler.Sufler_MironovDataSetTableAdapters.TableAdapterManager();
            this.rateNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.textTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            rateLabel = new System.Windows.Forms.Label();
            textLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sufler_MironovDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // rateLabel
            // 
            rateLabel.AutoSize = true;
            rateLabel.Location = new System.Drawing.Point(12, 12);
            rateLabel.Name = "rateLabel";
            rateLabel.Size = new System.Drawing.Size(48, 13);
            rateLabel.TabIndex = 3;
            rateLabel.Text = "Оценка:";
            // 
            // textLabel
            // 
            textLabel.AutoSize = true;
            textLabel.Location = new System.Drawing.Point(17, 41);
            textLabel.Name = "textLabel";
            textLabel.Size = new System.Drawing.Size(43, 13);
            textLabel.TabIndex = 5;
            textLabel.Text = "Отзыв:";
            // 
            // sufler_MironovDataSet
            // 
            this.sufler_MironovDataSet.DataSetName = "Sufler_MironovDataSet";
            this.sufler_MironovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reviewBindingSource
            // 
            this.reviewBindingSource.DataMember = "review";
            this.reviewBindingSource.DataSource = this.sufler_MironovDataSet;
            // 
            // reviewTableAdapter
            // 
            this.reviewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.participantTableAdapter = null;
            this.tableAdapterManager.projectTableAdapter = null;
            this.tableAdapterManager.responseTableAdapter = null;
            this.tableAdapterManager.reviewTableAdapter = this.reviewTableAdapter;
            this.tableAdapterManager.tagTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Sufler.Sufler_MironovDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // rateNumericUpDown
            // 
            this.rateNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reviewBindingSource, "rate", true));
            this.rateNumericUpDown.Location = new System.Drawing.Point(66, 10);
            this.rateNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.rateNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rateNumericUpDown.Name = "rateNumericUpDown";
            this.rateNumericUpDown.Size = new System.Drawing.Size(158, 20);
            this.rateNumericUpDown.TabIndex = 4;
            this.rateNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textTextBox
            // 
            this.textTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reviewBindingSource, "text", true));
            this.textTextBox.Location = new System.Drawing.Point(66, 36);
            this.textTextBox.MaxLength = 200;
            this.textTextBox.Multiline = true;
            this.textTextBox.Name = "textTextBox";
            this.textTextBox.Size = new System.Drawing.Size(225, 89);
            this.textTextBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Отправить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 165);
            this.Controls.Add(this.button1);
            this.Controls.Add(rateLabel);
            this.Controls.Add(this.rateNumericUpDown);
            this.Controls.Add(textLabel);
            this.Controls.Add(this.textTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateReview";
            this.Text = "Отзыв";
            this.Load += new System.EventHandler(this.CreateReview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sufler_MironovDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sufler_MironovDataSet sufler_MironovDataSet;
        private System.Windows.Forms.BindingSource reviewBindingSource;
        private Sufler_MironovDataSetTableAdapters.reviewTableAdapter reviewTableAdapter;
        private Sufler_MironovDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.NumericUpDown rateNumericUpDown;
        private System.Windows.Forms.TextBox textTextBox;
        private System.Windows.Forms.Button button1;
    }
}