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
            //productController = new ProductController(listBox1,pictureBox1);
            //productController.show_picture(0);


        }
        private void button1_Click(object sender, EventArgs e)
        {

            productController.add_img("lada",5000);
        }
        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            productController.show_picture(listBox1.SelectedIndex);

        }

        private void button3_Click(object sender, EventArgs e)
        {
           telegramController = new TelegramController();
        }
    }
}
