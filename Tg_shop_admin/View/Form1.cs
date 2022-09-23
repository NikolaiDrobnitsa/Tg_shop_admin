using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tg_shop_admin.Controller;
using Tg_shop_admin.Model;
using System.Data.SqlClient;

namespace Tg_shop_admin
{
    public partial class Form1 : Form
    {
        ProductController productController;
        SqlCommand sqlCommand;
        SqlConnection sqlConnection;
        TelegramController telegramController;

        public Form1()
        {
            InitializeComponent();
            productController = new ProductController(listBox1,pictureBox1,pictureBox2,EditInfoTextBox,EditCostTextBox,EditpictureBox);
            //productController.show_picture(0);
            GC.Collect();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (productController.check_img == true)
            {


                if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
                {
                    productController.add_img(textBox1.Text, Convert.ToInt32(textBox2.Text));
                }
                else
                {
                    MessageBox.Show("Все поля должны быть заполнены!");
                }

            }
            else
            {
                MessageBox.Show("Загрузите картинку!");
            }
            
        }
        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            productController.show_pictures(listBox1.SelectedIndex);

        }

        private void button3_Click(object sender, EventArgs e)
        {
           telegramController = new TelegramController();
            GC.Collect();
        }

        public void UpdateButton_Click(object sender, EventArgs e)
        {
            //productController.Regestration();
            productController.parse_product();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void DownloadImgButton_Click(object sender, EventArgs e)
        {
            productController.download();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            productController.Delete_product(listBox1.SelectedIndex);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                productController.Edit_product(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Выберите товар!");
            }

        }

        private void EditCostTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void EditDownLoadButton_Click(object sender, EventArgs e)
        {
            productController.download_edit_pic();
        }

        private void EditsButton_Click(object sender, EventArgs e)
        {
            if (EditCostTextBox.Text != "" && EditInfoTextBox.Text != "")
            {
                productController.Edit_info(EditInfoTextBox.Text, Convert.ToInt32(EditCostTextBox.Text),listBox1.SelectedIndex);
            }
            
        }
    }
}
