namespace Sufler.Forms
{
    partial class createProject
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
            System.Windows.Forms.Label project_nameLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label date_endLabel;
            System.Windows.Forms.Label tagsLabel;
            this.sufler_MironovDataSet = new Sufler.Sufler_MironovDataSet();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectTableAdapter = new Sufler.Sufler_MironovDataSetTableAdapters.projectTableAdapter();
            this.tableAdapterManager = new Sufler.Sufler_MironovDataSetTableAdapters.TableAdapterManager();
            this.tagBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tagTableAdapter = new Sufler.Sufler_MironovDataSetTableAdapters.tagTableAdapter();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.project_nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.date_endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idtagsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idtagsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tagBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tagsComboBox = new System.Windows.Forms.ComboBox();
            this.idtagsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            project_nameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            date_endLabel = new System.Windows.Forms.Label();
            tagsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sufler_MironovDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idtagsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idtagsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idtagsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // project_nameLabel
            // 
            project_nameLabel.AutoSize = true;
            project_nameLabel.Location = new System.Drawing.Point(19, 20);
            project_nameLabel.Name = "project_nameLabel";
            project_nameLabel.Size = new System.Drawing.Size(86, 13);
            project_nameLabel.TabIndex = 1;
            project_nameLabel.Text = "Имя проекта:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(41, 134);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(64, 13);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Описание:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(66, 51);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(39, 13);
            priceLabel.TabIndex = 5;
            priceLabel.Text = "Цена:";
            // 
            // date_endLabel
            // 
            date_endLabel.AutoSize = true;
            date_endLabel.Location = new System.Drawing.Point(27, 83);
            date_endLabel.Name = "date_endLabel";
            date_endLabel.Size = new System.Drawing.Size(78, 13);
            date_endLabel.TabIndex = 9;
            date_endLabel.Text = "Дата конца:";
            // 
            // tagsLabel
            // 
            tagsLabel.AutoSize = true;
            tagsLabel.Location = new System.Drawing.Point(79, 107);
            tagsLabel.Name = "tagsLabel";
            tagsLabel.Size = new System.Drawing.Size(26, 13);
            tagsLabel.TabIndex = 11;
            tagsLabel.Text = "Тэг:";
            // 
            // sufler_MironovDataSet
            // 
            this.sufler_MironovDataSet.DataSetName = "Sufler_MironovDataSet";
            this.sufler_MironovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataMember = "project";
            this.projectBindingSource.DataSource = this.sufler_MironovDataSet;
            // 
            // projectTableAdapter
            // 
            this.projectTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.participantTableAdapter = null;
            this.tableAdapterManager.projectTableAdapter = this.projectTableAdapter;
            this.tableAdapterManager.responseTableAdapter = null;
            this.tableAdapterManager.reviewTableAdapter = null;
            this.tableAdapterManager.tagTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Sufler.Sufler_MironovDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // tagBindingSource
            // 
            this.tagBindingSource.DataMember = "tag";
            this.tagBindingSource.DataSource = this.sufler_MironovDataSet;
            // 
            // tagTableAdapter
            // 
            this.tagTableAdapter.ClearBeforeFill = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(111, 49);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(288, 22);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(22, 270);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(377, 23);
            this.buttonCreate.TabIndex = 13;
            this.buttonCreate.Text = "Сохранить";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // project_nameTextBox
            // 
            this.project_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectBindingSource, "project_name", true));
            this.project_nameTextBox.Location = new System.Drawing.Point(111, 17);
            this.project_nameTextBox.Name = "project_nameTextBox";
            this.project_nameTextBox.Size = new System.Drawing.Size(288, 22);
            this.project_nameTextBox.TabIndex = 2;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectBindingSource, "description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(111, 131);
            this.descriptionTextBox.MaxLength = 500;
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(288, 133);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // date_endDateTimePicker
            // 
            this.date_endDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.projectBindingSource, "date_end", true));
            this.date_endDateTimePicker.Location = new System.Drawing.Point(111, 76);
            this.date_endDateTimePicker.Name = "date_endDateTimePicker";
            this.date_endDateTimePicker.Size = new System.Drawing.Size(288, 22);
            this.date_endDateTimePicker.TabIndex = 10;
            // 
            // idtagsBindingSource1
            // 
            this.idtagsBindingSource1.DataMember = "id_tags";
            this.idtagsBindingSource1.DataSource = this.tagBindingSource;
            // 
            // idtagsBindingSource
            // 
            this.idtagsBindingSource.DataMember = "id_tags";
            this.idtagsBindingSource.DataSource = this.tagBindingSource;
            // 
            // tagBindingSource1
            // 
            this.tagBindingSource1.DataMember = "tag";
            this.tagBindingSource1.DataSource = this.sufler_MironovDataSet;
            // 
            // tagsComboBox
            // 
            this.tagsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.idtagsBindingSource, "tags", true));
            this.tagsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.projectBindingSource, "tags", true));
            this.tagsComboBox.DataSource = this.tagBindingSource;
            this.tagsComboBox.DisplayMember = "tag_name";
            this.tagsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tagsComboBox.FormattingEnabled = true;
            this.tagsComboBox.Location = new System.Drawing.Point(111, 104);
            this.tagsComboBox.Name = "tagsComboBox";
            this.tagsComboBox.Size = new System.Drawing.Size(288, 21);
            this.tagsComboBox.TabIndex = 15;
            this.tagsComboBox.ValueMember = "tag_id";
            // 
            // idtagsBindingSource2
            // 
            this.idtagsBindingSource2.DataMember = "id_tags";
            this.idtagsBindingSource2.DataSource = this.tagBindingSource;
            // 
            // createProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 313);
            this.Controls.Add(this.tagsComboBox);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(project_nameLabel);
            this.Controls.Add(this.project_nameTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(date_endLabel);
            this.Controls.Add(this.date_endDateTimePicker);
            this.Controls.Add(tagsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "createProject";
            this.Text = "Создание проекта";
            this.Load += new System.EventHandler(this.createProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sufler_MironovDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idtagsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idtagsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idtagsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sufler_MironovDataSet sufler_MironovDataSet;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private Sufler_MironovDataSetTableAdapters.projectTableAdapter projectTableAdapter;
        private Sufler_MironovDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox project_nameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.DateTimePicker date_endDateTimePicker;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.BindingSource tagBindingSource;
        private Sufler_MironovDataSetTableAdapters.tagTableAdapter tagTableAdapter;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.BindingSource idtagsBindingSource;
        private System.Windows.Forms.BindingSource tagBindingSource1;
        private System.Windows.Forms.BindingSource idtagsBindingSource1;
        private System.Windows.Forms.ComboBox tagsComboBox;
        private System.Windows.Forms.BindingSource idtagsBindingSource2;
    }
}