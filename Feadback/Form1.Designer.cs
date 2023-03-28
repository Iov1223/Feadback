namespace Feadback
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelChoice = new System.Windows.Forms.Label();
            this.labelNick = new System.Windows.Forms.Label();
            this.textBoxNick = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelFeadBack = new System.Windows.Forms.Label();
            this.richTextBoxFeaddback = new System.Windows.Forms.RichTextBox();
            this.labelNum = new System.Windows.Forms.Label();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonShowNewForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 124);
            this.dataGridView1.TabIndex = 2;
            // 
            // labelChoice
            // 
            this.labelChoice.AutoSize = true;
            this.labelChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChoice.Location = new System.Drawing.Point(9, 9);
            this.labelChoice.Name = "labelChoice";
            this.labelChoice.Size = new System.Drawing.Size(187, 16);
            this.labelChoice.TabIndex = 3;
            this.labelChoice.Text = "Выбор объекта для отзыва:";
            // 
            // labelNick
            // 
            this.labelNick.AutoSize = true;
            this.labelNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNick.Location = new System.Drawing.Point(9, 182);
            this.labelNick.Name = "labelNick";
            this.labelNick.Size = new System.Drawing.Size(307, 16);
            this.labelNick.TabIndex = 4;
            this.labelNick.Text = "Введите имя или ник (не более 100 символов):";
            // 
            // textBoxNick
            // 
            this.textBoxNick.Location = new System.Drawing.Point(12, 201);
            this.textBoxNick.Name = "textBoxNick";
            this.textBoxNick.Size = new System.Drawing.Size(343, 20);
            this.textBoxNick.TabIndex = 5;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmail.Location = new System.Drawing.Point(9, 252);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(199, 16);
            this.labelEmail.TabIndex = 6;
            this.labelEmail.Text = "Введите электронную почту:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(12, 271);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(340, 20);
            this.textBoxEmail.TabIndex = 7;
            // 
            // labelFeadBack
            // 
            this.labelFeadBack.AutoSize = true;
            this.labelFeadBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFeadBack.Location = new System.Drawing.Point(9, 327);
            this.labelFeadBack.Name = "labelFeadBack";
            this.labelFeadBack.Size = new System.Drawing.Size(277, 16);
            this.labelFeadBack.TabIndex = 8;
            this.labelFeadBack.Text = "Введите отзыв (не более 1000 символов):";
            // 
            // richTextBoxFeaddback
            // 
            this.richTextBoxFeaddback.Location = new System.Drawing.Point(12, 346);
            this.richTextBoxFeaddback.Name = "richTextBoxFeaddback";
            this.richTextBoxFeaddback.Size = new System.Drawing.Size(773, 96);
            this.richTextBoxFeaddback.TabIndex = 9;
            this.richTextBoxFeaddback.Text = "";
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNum.Location = new System.Drawing.Point(416, 254);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(133, 16);
            this.labelNum.TabIndex = 10;
            this.labelNum.Text = "Номер объекта (id):";
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(419, 273);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(130, 20);
            this.textBoxNum.TabIndex = 11;
            this.textBoxNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNum_KeyPress);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(12, 465);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(773, 23);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Добавить отзыв";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonShowNewForm
            // 
            this.buttonShowNewForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowNewForm.Location = new System.Drawing.Point(12, 504);
            this.buttonShowNewForm.Name = "buttonShowNewForm";
            this.buttonShowNewForm.Size = new System.Drawing.Size(773, 23);
            this.buttonShowNewForm.TabIndex = 13;
            this.buttonShowNewForm.Text = "Посмотреть отзывы";
            this.buttonShowNewForm.UseVisualStyleBackColor = true;
            this.buttonShowNewForm.Click += new System.EventHandler(this.buttonShowNewForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.buttonShowNewForm);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxNum);
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.richTextBoxFeaddback);
            this.Controls.Add(this.labelFeadBack);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxNick);
            this.Controls.Add(this.labelNick);
            this.Controls.Add(this.labelChoice);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(816, 581);
            this.MinimumSize = new System.Drawing.Size(816, 581);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelChoice;
        private System.Windows.Forms.Label labelNick;
        private System.Windows.Forms.TextBox textBoxNick;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelFeadBack;
        private System.Windows.Forms.RichTextBox richTextBoxFeaddback;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonShowNewForm;
    }
}

