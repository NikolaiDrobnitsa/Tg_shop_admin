namespace Tg_shop_admin
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Tgbutton3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBoxAddProd = new System.Windows.Forms.GroupBox();
            this.DownloadImgButton = new System.Windows.Forms.Button();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.EditgroupBox1 = new System.Windows.Forms.GroupBox();
            this.EditDownLoadButton = new System.Windows.Forms.Button();
            this.EditCostlabel = new System.Windows.Forms.Label();
            this.EditInfoTextBox = new System.Windows.Forms.TextBox();
            this.EditTextlabel = new System.Windows.Forms.Label();
            this.EditsButton = new System.Windows.Forms.Button();
            this.EditpictureBox = new System.Windows.Forms.PictureBox();
            this.EditCostTextBox = new System.Windows.Forms.TextBox();
            this.Admin_listBox = new System.Windows.Forms.ListBox();
            this.admins_textBox = new System.Windows.Forms.TextBox();
            this.addAdminbutton = new System.Windows.Forms.Button();
            this.DelAdmin_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBoxAddProd.SuspendLayout();
            this.EditgroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(148, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(364, 108);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(30, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 104);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(229, 151);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 5;
            this.UpdateButton.Text = "Обновить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 136);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 59);
            this.textBox1.TabIndex = 6;
            // 
            // Tgbutton3
            // 
            this.Tgbutton3.Location = new System.Drawing.Point(428, 151);
            this.Tgbutton3.Name = "Tgbutton3";
            this.Tgbutton3.Size = new System.Drawing.Size(75, 23);
            this.Tgbutton3.TabIndex = 7;
            this.Tgbutton3.Text = "tg";
            this.Tgbutton3.UseVisualStyleBackColor = true;
            this.Tgbutton3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 201);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(127, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 104);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // groupBoxAddProd
            // 
            this.groupBoxAddProd.Controls.Add(this.DownloadImgButton);
            this.groupBoxAddProd.Controls.Add(this.labelCost);
            this.groupBoxAddProd.Controls.Add(this.textBox1);
            this.groupBoxAddProd.Controls.Add(this.labelText);
            this.groupBoxAddProd.Controls.Add(this.button1);
            this.groupBoxAddProd.Controls.Add(this.pictureBox2);
            this.groupBoxAddProd.Controls.Add(this.textBox2);
            this.groupBoxAddProd.Location = new System.Drawing.Point(537, 5);
            this.groupBoxAddProd.Name = "groupBoxAddProd";
            this.groupBoxAddProd.Size = new System.Drawing.Size(251, 277);
            this.groupBoxAddProd.TabIndex = 10;
            this.groupBoxAddProd.TabStop = false;
            this.groupBoxAddProd.Text = "Добавить новый товар";
            // 
            // DownloadImgButton
            // 
            this.DownloadImgButton.Location = new System.Drawing.Point(22, 59);
            this.DownloadImgButton.Name = "DownloadImgButton";
            this.DownloadImgButton.Size = new System.Drawing.Size(77, 38);
            this.DownloadImgButton.TabIndex = 13;
            this.DownloadImgButton.Text = "Загрузить картинку";
            this.DownloadImgButton.UseVisualStyleBackColor = true;
            this.DownloadImgButton.Click += new System.EventHandler(this.DownloadImgButton_Click);
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCost.Location = new System.Drawing.Point(57, 201);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(42, 15);
            this.labelCost.TabIndex = 12;
            this.labelCost.Text = "Цена :";
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText.Location = new System.Drawing.Point(4, 138);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(98, 15);
            this.labelText.TabIndex = 11;
            this.labelText.Text = "Текст под фото :";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(148, 151);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 11;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(319, 151);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(93, 23);
            this.EditButton.TabIndex = 12;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // EditgroupBox1
            // 
            this.EditgroupBox1.Controls.Add(this.EditDownLoadButton);
            this.EditgroupBox1.Controls.Add(this.EditCostlabel);
            this.EditgroupBox1.Controls.Add(this.EditInfoTextBox);
            this.EditgroupBox1.Controls.Add(this.EditTextlabel);
            this.EditgroupBox1.Controls.Add(this.EditsButton);
            this.EditgroupBox1.Controls.Add(this.EditpictureBox);
            this.EditgroupBox1.Controls.Add(this.EditCostTextBox);
            this.EditgroupBox1.Location = new System.Drawing.Point(809, 5);
            this.EditgroupBox1.Name = "EditgroupBox1";
            this.EditgroupBox1.Size = new System.Drawing.Size(251, 277);
            this.EditgroupBox1.TabIndex = 14;
            this.EditgroupBox1.TabStop = false;
            this.EditgroupBox1.Text = "Редактировать товар";
            // 
            // EditDownLoadButton
            // 
            this.EditDownLoadButton.Location = new System.Drawing.Point(22, 59);
            this.EditDownLoadButton.Name = "EditDownLoadButton";
            this.EditDownLoadButton.Size = new System.Drawing.Size(77, 38);
            this.EditDownLoadButton.TabIndex = 13;
            this.EditDownLoadButton.Text = "Загрузить картинку";
            this.EditDownLoadButton.UseVisualStyleBackColor = true;
            this.EditDownLoadButton.Click += new System.EventHandler(this.EditDownLoadButton_Click);
            // 
            // EditCostlabel
            // 
            this.EditCostlabel.AutoSize = true;
            this.EditCostlabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditCostlabel.Location = new System.Drawing.Point(57, 201);
            this.EditCostlabel.Name = "EditCostlabel";
            this.EditCostlabel.Size = new System.Drawing.Size(42, 15);
            this.EditCostlabel.TabIndex = 12;
            this.EditCostlabel.Text = "Цена :";
            // 
            // EditInfoTextBox
            // 
            this.EditInfoTextBox.Location = new System.Drawing.Point(105, 136);
            this.EditInfoTextBox.Multiline = true;
            this.EditInfoTextBox.Name = "EditInfoTextBox";
            this.EditInfoTextBox.Size = new System.Drawing.Size(140, 59);
            this.EditInfoTextBox.TabIndex = 6;
            // 
            // EditTextlabel
            // 
            this.EditTextlabel.AutoSize = true;
            this.EditTextlabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditTextlabel.Location = new System.Drawing.Point(4, 138);
            this.EditTextlabel.Name = "EditTextlabel";
            this.EditTextlabel.Size = new System.Drawing.Size(98, 15);
            this.EditTextlabel.TabIndex = 11;
            this.EditTextlabel.Text = "Текст под фото :";
            // 
            // EditsButton
            // 
            this.EditsButton.Location = new System.Drawing.Point(105, 227);
            this.EditsButton.Name = "EditsButton";
            this.EditsButton.Size = new System.Drawing.Size(140, 38);
            this.EditsButton.TabIndex = 4;
            this.EditsButton.Text = "Изменить";
            this.EditsButton.UseVisualStyleBackColor = true;
            this.EditsButton.Click += new System.EventHandler(this.EditsButton_Click);
            // 
            // EditpictureBox
            // 
            this.EditpictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EditpictureBox.Location = new System.Drawing.Point(127, 26);
            this.EditpictureBox.Name = "EditpictureBox";
            this.EditpictureBox.Size = new System.Drawing.Size(100, 104);
            this.EditpictureBox.TabIndex = 9;
            this.EditpictureBox.TabStop = false;
            // 
            // EditCostTextBox
            // 
            this.EditCostTextBox.Location = new System.Drawing.Point(105, 201);
            this.EditCostTextBox.Name = "EditCostTextBox";
            this.EditCostTextBox.Size = new System.Drawing.Size(140, 20);
            this.EditCostTextBox.TabIndex = 8;
            this.EditCostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditCostTextBox_KeyPress);
            // 
            // Admin_listBox
            // 
            this.Admin_listBox.FormattingEnabled = true;
            this.Admin_listBox.Location = new System.Drawing.Point(537, 288);
            this.Admin_listBox.Name = "Admin_listBox";
            this.Admin_listBox.Size = new System.Drawing.Size(120, 95);
            this.Admin_listBox.TabIndex = 15;
            // 
            // admins_textBox
            // 
            this.admins_textBox.Location = new System.Drawing.Point(663, 300);
            this.admins_textBox.Name = "admins_textBox";
            this.admins_textBox.Size = new System.Drawing.Size(100, 20);
            this.admins_textBox.TabIndex = 16;
            // 
            // addAdminbutton
            // 
            this.addAdminbutton.Location = new System.Drawing.Point(663, 327);
            this.addAdminbutton.Name = "addAdminbutton";
            this.addAdminbutton.Size = new System.Drawing.Size(101, 23);
            this.addAdminbutton.TabIndex = 17;
            this.addAdminbutton.Text = "button2";
            this.addAdminbutton.UseVisualStyleBackColor = true;
            this.addAdminbutton.Click += new System.EventHandler(this.addAdminbutton_Click);
            // 
            // DelAdmin_button
            // 
            this.DelAdmin_button.Location = new System.Drawing.Point(663, 356);
            this.DelAdmin_button.Name = "DelAdmin_button";
            this.DelAdmin_button.Size = new System.Drawing.Size(101, 23);
            this.DelAdmin_button.TabIndex = 18;
            this.DelAdmin_button.Text = "button2";
            this.DelAdmin_button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 450);
            this.Controls.Add(this.DelAdmin_button);
            this.Controls.Add(this.addAdminbutton);
            this.Controls.Add(this.admins_textBox);
            this.Controls.Add(this.Admin_listBox);
            this.Controls.Add(this.EditgroupBox1);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.Tgbutton3);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBoxAddProd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBoxAddProd.ResumeLayout(false);
            this.groupBoxAddProd.PerformLayout();
            this.EditgroupBox1.ResumeLayout(false);
            this.EditgroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Tgbutton3;
        private System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBoxAddProd;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Button DownloadImgButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.GroupBox EditgroupBox1;
        private System.Windows.Forms.Button EditDownLoadButton;
        private System.Windows.Forms.Label EditCostlabel;
        private System.Windows.Forms.TextBox EditInfoTextBox;
        private System.Windows.Forms.Label EditTextlabel;
        private System.Windows.Forms.Button EditsButton;
        public System.Windows.Forms.PictureBox EditpictureBox;
        private System.Windows.Forms.TextBox EditCostTextBox;
        private System.Windows.Forms.ListBox Admin_listBox;
        private System.Windows.Forms.TextBox admins_textBox;
        private System.Windows.Forms.Button addAdminbutton;
        private System.Windows.Forms.Button DelAdmin_button;
    }
}

