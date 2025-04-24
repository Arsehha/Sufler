namespace Sufler.Forms
{
    partial class ChangeAccountInfo
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
            System.Windows.Forms.Label first_nameLabel;
            System.Windows.Forms.Label last_nameLabel;
            System.Windows.Forms.Label date_birthLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label bioLabel;
            this.sufler_MironovDataSet = new Sufler.Sufler_MironovDataSet();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new Sufler.Sufler_MironovDataSetTableAdapters.userTableAdapter();
            this.tableAdapterManager = new Sufler.Sufler_MironovDataSetTableAdapters.TableAdapterManager();
            this.first_nameTextBox = new System.Windows.Forms.TextBox();
            this.last_nameTextBox = new System.Windows.Forms.TextBox();
            this.date_birthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.phoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.bioTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            first_nameLabel = new System.Windows.Forms.Label();
            last_nameLabel = new System.Windows.Forms.Label();
            date_birthLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            bioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sufler_MironovDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sufler_MironovDataSet
            // 
            this.sufler_MironovDataSet.DataSetName = "Sufler_MironovDataSet";
            this.sufler_MironovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.sufler_MironovDataSet;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.participantTableAdapter = null;
            this.tableAdapterManager.projectTableAdapter = null;
            this.tableAdapterManager.responseTableAdapter = null;
            this.tableAdapterManager.reviewTableAdapter = null;
            this.tableAdapterManager.tagTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Sufler.Sufler_MironovDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = this.userTableAdapter;
            // 
            // first_nameLabel
            // 
            first_nameLabel.AutoSize = true;
            first_nameLabel.Location = new System.Drawing.Point(72, 15);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new System.Drawing.Size(32, 13);
            first_nameLabel.TabIndex = 1;
            first_nameLabel.Text = "Имя:";
            // 
            // first_nameTextBox
            // 
            this.first_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "first_name", true));
            this.first_nameTextBox.Location = new System.Drawing.Point(107, 12);
            this.first_nameTextBox.Name = "first_nameTextBox";
            this.first_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.first_nameTextBox.TabIndex = 2;
            // 
            // last_nameLabel
            // 
            last_nameLabel.AutoSize = true;
            last_nameLabel.Location = new System.Drawing.Point(46, 41);
            last_nameLabel.Name = "last_nameLabel";
            last_nameLabel.Size = new System.Drawing.Size(59, 13);
            last_nameLabel.TabIndex = 3;
            last_nameLabel.Text = "Фамилия:";
            // 
            // last_nameTextBox
            // 
            this.last_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "last_name", true));
            this.last_nameTextBox.Location = new System.Drawing.Point(107, 38);
            this.last_nameTextBox.Name = "last_nameTextBox";
            this.last_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.last_nameTextBox.TabIndex = 4;
            // 
            // date_birthLabel
            // 
            date_birthLabel.AutoSize = true;
            date_birthLabel.Location = new System.Drawing.Point(13, 70);
            date_birthLabel.Name = "date_birthLabel";
            date_birthLabel.Size = new System.Drawing.Size(89, 13);
            date_birthLabel.TabIndex = 5;
            date_birthLabel.Text = "Дата рождения:";
            // 
            // date_birthDateTimePicker
            // 
            this.date_birthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.userBindingSource, "date_birth", true));
            this.date_birthDateTimePicker.Location = new System.Drawing.Point(107, 64);
            this.date_birthDateTimePicker.Name = "date_birthDateTimePicker";
            this.date_birthDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_birthDateTimePicker.TabIndex = 6;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(46, 93);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(55, 13);
            phoneLabel.TabIndex = 7;
            phoneLabel.Text = "Телефон:";
            // 
            // phoneMaskedTextBox
            // 
            this.phoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "phone", true));
            this.phoneMaskedTextBox.Location = new System.Drawing.Point(107, 90);
            this.phoneMaskedTextBox.Mask = "+7 (000) 000-00-00";
            this.phoneMaskedTextBox.Name = "phoneMaskedTextBox";
            this.phoneMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.phoneMaskedTextBox.TabIndex = 8;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(53, 119);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(48, 13);
            passwordLabel.TabIndex = 9;
            passwordLabel.Text = "Пароль:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(107, 116);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(200, 20);
            this.passwordTextBox.TabIndex = 10;
            // 
            // bioLabel
            // 
            bioLabel.AutoSize = true;
            bioLabel.Location = new System.Drawing.Point(53, 145);
            bioLabel.Name = "bioLabel";
            bioLabel.Size = new System.Drawing.Size(45, 13);
            bioLabel.TabIndex = 11;
            bioLabel.Text = "О себе:";
            // 
            // bioTextBox
            // 
            this.bioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "bio", true));
            this.bioTextBox.Location = new System.Drawing.Point(107, 142);
            this.bioTextBox.MaxLength = 125;
            this.bioTextBox.Multiline = true;
            this.bioTextBox.Name = "bioTextBox";
            this.bioTextBox.Size = new System.Drawing.Size(200, 148);
            this.bioTextBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(291, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChangeAccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 329);
            this.Controls.Add(this.button1);
            this.Controls.Add(first_nameLabel);
            this.Controls.Add(this.first_nameTextBox);
            this.Controls.Add(last_nameLabel);
            this.Controls.Add(this.last_nameTextBox);
            this.Controls.Add(date_birthLabel);
            this.Controls.Add(this.date_birthDateTimePicker);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneMaskedTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(bioLabel);
            this.Controls.Add(this.bioTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChangeAccountInfo";
            this.Text = "Профиль";
            this.Load += new System.EventHandler(this.ChangeAccountInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sufler_MironovDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sufler_MironovDataSet sufler_MironovDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private Sufler_MironovDataSetTableAdapters.userTableAdapter userTableAdapter;
        private Sufler_MironovDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox first_nameTextBox;
        private System.Windows.Forms.TextBox last_nameTextBox;
        private System.Windows.Forms.DateTimePicker date_birthDateTimePicker;
        private System.Windows.Forms.MaskedTextBox phoneMaskedTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox bioTextBox;
        private System.Windows.Forms.Button button1;
    }
}