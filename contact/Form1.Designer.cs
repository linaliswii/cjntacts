namespace contact
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddContact = new System.Windows.Forms.Button();
            this.btnDeleteContact = new System.Windows.Forms.Button();
            this.btnEditContact = new System.Windows.Forms.Button();
            this.btnSearchContact = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.txtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.searchcontact = new System.Windows.Forms.Button();
            this.editname = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddContact
            // 
            this.btnAddContact.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnAddContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddContact.Location = new System.Drawing.Point(12, 20);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(298, 41);
            this.btnAddContact.TabIndex = 0;
            this.btnAddContact.Text = "Добавить новый контакт";
            this.btnAddContact.UseVisualStyleBackColor = false;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // btnDeleteContact
            // 
            this.btnDeleteContact.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnDeleteContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteContact.Location = new System.Drawing.Point(12, 67);
            this.btnDeleteContact.Name = "btnDeleteContact";
            this.btnDeleteContact.Size = new System.Drawing.Size(298, 38);
            this.btnDeleteContact.TabIndex = 1;
            this.btnDeleteContact.Text = "Удалить контакт";
            this.btnDeleteContact.UseVisualStyleBackColor = false;
            this.btnDeleteContact.Click += new System.EventHandler(this.btnDeleteContact_Click);
            // 
            // btnEditContact
            // 
            this.btnEditContact.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnEditContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditContact.Location = new System.Drawing.Point(12, 256);
            this.btnEditContact.Name = "btnEditContact";
            this.btnEditContact.Size = new System.Drawing.Size(298, 42);
            this.btnEditContact.TabIndex = 2;
            this.btnEditContact.Text = "Редактировать номер телефона";
            this.btnEditContact.UseVisualStyleBackColor = false;
            // 
            // btnSearchContact
            // 
            this.btnSearchContact.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnSearchContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearchContact.Location = new System.Drawing.Point(12, 111);
            this.btnSearchContact.Name = "btnSearchContact";
            this.btnSearchContact.Size = new System.Drawing.Size(298, 43);
            this.btnSearchContact.TabIndex = 3;
            this.btnSearchContact.Text = "Поиск контакта по имени";
            this.btnSearchContact.UseVisualStyleBackColor = false;
            this.btnSearchContact.Click += new System.EventHandler(this.btnSearchContact_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Info;
            this.txtName.Location = new System.Drawing.Point(399, 34);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(231, 27);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(395, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите номер телефона:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(395, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Введите имя контакта:";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkSalmon;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(449, 226);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(197, 72);
            this.button5.TabIndex = 8;
            this.button5.Text = "Список контактов";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.SystemColors.Info;
            this.txtPhoneNumber.Location = new System.Drawing.Point(399, 112);
            this.txtPhoneNumber.Mask = "+7(999)-000-00-00";
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(231, 22);
            this.txtPhoneNumber.TabIndex = 11;
            // 
            // searchcontact
            // 
            this.searchcontact.BackColor = System.Drawing.Color.DarkSalmon;
            this.searchcontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchcontact.Location = new System.Drawing.Point(12, 161);
            this.searchcontact.Name = "searchcontact";
            this.searchcontact.Size = new System.Drawing.Size(298, 42);
            this.searchcontact.TabIndex = 12;
            this.searchcontact.Text = "Поиск контакта по номеру телефона";
            this.searchcontact.UseVisualStyleBackColor = false;
            this.searchcontact.Click += new System.EventHandler(this.button1_Click);
            // 
            // editname
            // 
            this.editname.BackColor = System.Drawing.Color.DarkSalmon;
            this.editname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editname.Location = new System.Drawing.Point(12, 209);
            this.editname.Name = "editname";
            this.editname.Size = new System.Drawing.Size(298, 41);
            this.editname.TabIndex = 13;
            this.editname.Text = "Поменять имя контакта";
            this.editname.UseVisualStyleBackColor = false;
            this.editname.Click += new System.EventHandler(this.editname_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(658, 314);
            this.Controls.Add(this.editname);
            this.Controls.Add(this.searchcontact);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSearchContact);
            this.Controls.Add(this.btnEditContact);
            this.Controls.Add(this.btnDeleteContact);
            this.Controls.Add(this.btnAddContact);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.Button btnDeleteContact;
        private System.Windows.Forms.Button btnEditContact;
        private System.Windows.Forms.Button btnSearchContact;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.MaskedTextBox txtPhoneNumber;
        private System.Windows.Forms.Button searchcontact;
        private System.Windows.Forms.Button editname;
    }
}

