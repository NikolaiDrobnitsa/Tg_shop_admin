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
        public string[] list_admin { get; set; }
        //public List<string> string_admin { get; set; }
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
           telegramController = new TelegramController(productController.prod, list_admin);
            GC.Collect();
        }

        public void UpdateButton_Click(object sender, EventArgs e)
        {
            //productController.Regestration();
            productController.parse_product();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            //using (StreamReader reader = new StreamReader("admins.txt"))
            //{
            //    for (int i = 0; i < list_admin.Length; i++)
            //    {
            //        list_admin[i] = reader.ReadToEnd();

            //    }
            //    //while (!reader.EndOfStream)
            //    //{
            //    //    string_admin.Add(reader.ReadLine());
            //    //}

            //}
            list_admin = File.ReadAllLines("admins.txt");
            //StreamReader reader = new StreamReader("admins.txt");
            //while (!reader.EndOfStream)
            //{
            //    string_admin.Add(reader.ReadLine());
            //}
            //reader.Close();
            //string_admin = File.ReadAllLines("admins.txt").ToList();
            //foreach (var item in string_admin)
            //{
            //    Admin_listBox.Items.Add(item);
            //}
            for (int i = 0; i < list_admin.Length; i++)
            {
                Admin_listBox.Items.Add(list_admin[i]);
            }
            
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) 
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

        private void addAdminbutton_Click(object sender, EventArgs e)
        {
            
            if (admins_textBox.Text != "")
            {
                Admin_listBox.Items.Add(admins_textBox.Text);
                //Array.Clear(list_admin, 0, list_admin.Length);
                //list_admin[i] = Admin_listBox.Items[i].ToString();
                //for (int i = 0; i < Admin_listBox.Items.Count; i++)
                //{
                //list_admin = Admin_listBox.Items[i] + ", ";
                //}
                //string_admin.Add(admins_textBox.Text);
                list_admin = new string[Admin_listBox.Items.Count];
                for (int i = 0; i < Admin_listBox.Items.Count; i++)
                {
                    list_admin[i] = Admin_listBox.Items[i].ToString();
                }
                admins_textBox.Clear();
            }
            else
            {
                MessageBox.Show("Поле должно быть заполнено!");
            }

        }

        private async void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllLines("admins.txt", list_admin);
        }

        private void DelAdmin_button_Click(object sender, EventArgs e)
        {

            if (Admin_listBox.SelectedIndex != -1)
            {
                Admin_listBox.Items.RemoveAt(Admin_listBox.SelectedIndex);
                //Array.Clear(list_admin, 0, list_admin.Length);
                //for (int i = 0; i < Admin_listBox.Items.Count; i++)
                //{
                //list_admin[i] = Admin_listBox.Items[i].ToString();

                //list_admin = Admin_listBox.Items[i] + ", ";
                //}
                //string_admin.Remove(Admin_listBox.SelectedItems.ToString());
                //Admin_listBox.Update();
                list_admin = new string[Admin_listBox.Items.Count];
                for (int i = 0; i < Admin_listBox.Items.Count; i++)
                {
                    list_admin[i] = Admin_listBox.Items[i].ToString();
                }
            }
            else
            {
                MessageBox.Show("Выберите продавца!");
            }
        }

        private void admins_textBox_TextChanged(object sender, EventArgs e)
        {
            if (admins_textBox.Text.Contains("@"))
            {

                addAdminbutton.Enabled = true;
                label1.Visible = false;
            }
            else
            {
                addAdminbutton.Enabled = false;

                label1.Visible = true;
            }
        }
    }
}
