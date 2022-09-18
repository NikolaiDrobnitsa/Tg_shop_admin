using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tg_shop_admin.Model;

namespace Tg_shop_admin.Controller
{
    internal class ProductController
    {
        private ListBox lists;
        private PictureBox pictures;
        Products products;
        SqlCommand sqlCommand;
        SqlConnection sqlConnection;
        List<Products> prod = new List<Products>();
        public ProductController(ListBox box, PictureBox pict)
        {
            lists = box;
            pictures = pict;
            add_product();
            parse_product();
        }

        private void parse_product()
        {
            foreach (Products item in prod)
            {
                lists.Items.Add("Id: "+item.id+" Name: "+ item.Name + " Cost: " + item.Cost);

            }
            

        }

        public void Regestration(string _email, string _pass)
        {

            //string connectionString = @"Data Source=SQL5080.site4now.net;Initial Catalog=db_a8323e_itstep011;User Id=db_a8323e_itstep011_admin;Password=passitstep011;";
            //string connectionString = @"Data Source = SQL5108.site4now.net; Initial Catalog = db_a85cd7_nick; User Id = db_a85cd7_nick_admin; Password = Passvbu011";
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    Users regestration = new Users() { email = _email, password = new Text_crypt().Generate(_pass) };
            //    //connection.Execute("INSERT INTO Users (email, password) VALUES(@email,@password)", regestration);
            //}

        }
        
        public void add_product()
        {
            sqlConnection = new SqlConnection(@"Data Source=SQL8004.site4now.net;Initial Catalog=db_a8bcfd_juzz;User Id=db_a8bcfd_juzz_admin;Password=JuzzikASP1");
            sqlConnection.Open();
            sqlCommand = new SqlCommand("SELECT * FROM Products", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    prod.Add(new Products(Convert.ToInt32(sqlDataReader[0]),sqlDataReader[2].ToString(), Convert.ToInt32(sqlDataReader[3])));
                }

            }
            sqlConnection.Close();
        }
        
        //public static byte[] ObjectToByteArray(Object obj)
        //{
        //    BinaryFormatter bf = new BinaryFormatter();
        //    using (var ms = new MemoryStream())
        //    {
        //        bf.Serialize(ms, obj);
        //        return ms.ToArray();
        //    }
        //}

        public void show_picture(int select_indx)
        {
            if (select_indx != -1)
            {
                select_indx = select_indx + 1;
                sqlConnection = new SqlConnection(@"Data Source=SQL8004.site4now.net;Initial Catalog=db_a8bcfd_juzz;User Id=db_a8bcfd_juzz_admin;Password=JuzzikASP1");
                sqlConnection.Open();
                sqlCommand = new SqlCommand("SELECT img FROM Products WHERE Id=" + select_indx, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                sqlDataReader.Read();

                if (sqlDataReader.HasRows)
                {
                    byte[] image = (byte[])(sqlDataReader[0]);
                    if (image == null)
                    {
                        pictures.BackgroundImage = null;
                    }
                    else
                    {
                        MemoryStream memory = new MemoryStream(image);
                        pictures.BackgroundImage = Image.FromStream(memory);
                    }
                }
                sqlConnection.Close();
                GC.Collect();
                //foreach (Products item in prod)
                //{

                //    if (item.id == select_indx)
                //    {
                //        if (item.img == null)
                //        {
                //            pictures.Image = null;
                //        }
                //        else
                //        {
                //            pictures.Image = ByteArrayToImage(item.img);
                //        }

                //    }

                //}
            }
            

        }
        string imgLoc = "";
        public void add_img(string _name, int _cost)
        {

            download();
            //string connectionString = @"Data Source=SQL8004.site4now.net;Initial Catalog=db_a8bcfd_juzz;User Id=db_a8bcfd_juzz_admin;Password=JuzzikASP1";
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    //Products products = new Products() { img = , Name = _name, Cost = _cost};

            //    connection.Execute("INSERT INTO Products (email, password) VALUES(@email,@password)");
            //    connection.

            //}
            sqlConnection = new SqlConnection(@"Data Source=SQL8004.site4now.net;Initial Catalog=db_a8bcfd_juzz;User Id=db_a8bcfd_juzz_admin;Password=JuzzikASP1");
            sqlConnection.Open();
            byte[] image = null;
            FileStream fileStream = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(fileStream);
            image = reader.ReadBytes((int)fileStream.Length);
            //Image x = (Bitmap)((new ImageConverter()).ConvertFrom(image));


            sqlCommand = new SqlCommand("INSERT INTO Products (img, Name, Cost) VALUES (@img, @Name, @Cost)", sqlConnection);

            sqlCommand.Parameters.Add(new SqlParameter("@img", image));
            sqlCommand.Parameters.AddWithValue("@Name", _name);
            sqlCommand.Parameters.AddWithValue("@Cost", _cost);

            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("add photo");


        }
        public void download()
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files (*.BMP; *JPG; *.GIF; *.PNG)|*.BMP; *JPG; *.GIF; *.PNG)|All files (*.*)|*.*";
                openFileDialog.InitialDirectory = @"C:\Users\Admin\Desktop\Parent_control";
                openFileDialog.Title = "Выберите картинку";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = openFileDialog.FileName.ToString();
                    pictures.ImageLocation = imgLoc;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("error");
            }
        }
        //public Image ByteArrayToImage(byte[] data)
        //{
        //    MemoryStream ms = new MemoryStream(data);
        //    Image returnImage = Image.FromStream(ms);
        //    return returnImage;
        //}

    }
}
