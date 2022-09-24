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
        private PictureBox pic;
        private PictureBox Editpic;
        TextBox editInfo;
        TextBox editcost;
        Products products;
        SqlCommand sqlCommand;
        SqlConnection sqlConnection;
        public List<Products> prod = new List<Products>();
        public bool check_img { get; set; } = false;
        public string list_admin { get; set; }
        public ProductController(ListBox box, PictureBox pict, PictureBox pic,TextBox infoedit,TextBox cost,PictureBox editPcb)
        {
            lists = box;
            pictures = pict;
            this.pic = pic;
            Editpic = editPcb;
            editInfo = infoedit;
            editcost = cost;
            add_product();


        }

        public void parse_product()
        {
            lists.Items.Clear();
            foreach (Products item in prod)
            {
                //lists.Items.Add("Id: "+item.id+" Name: "+ item.Name + " Cost: " + item.Cost);
       
                
                lists.Items.Add("Id: "+ (prod.IndexOf(item) + 1) + " Name: "+ item.Name + " Cost: " + item.Cost);
                
                //pic.BackgroundImage = ByteArrayToImage(item.img);

            }
            show_pictures(0);
            GC.Collect();

        }

        //public void Regestration()
        //{

        //    //string connectionString = @"Data Source=SQL5080.site4now.net;Initial Catalog=db_a8323e_itstep011;User Id=db_a8323e_itstep011_admin;Password=passitstep011;";
        //    //string connectionString = @"Data Source = SQL5108.site4now.net; Initial Catalog = db_a85cd7_nick; User Id = db_a85cd7_nick_admin; Password = Passvbu011";
        //    //using (SqlConnection connection = new SqlConnection(connectionString))
        //    //{
        //    //    Users regestration = new Users() { email = _email, password = new Text_crypt().Generate(_pass) };
        //    //    //connection.Execute("INSERT INTO Users (email, password) VALUES(@email,@password)", regestration);
        //    //}
        //    foreach (Products item in prod)
        //    {
        //        MemoryStream memory = new MemoryStream(item.img);
        //        pictures.BackgroundImage = Image.FromStream(memory);

        //    }

        //}
        
        public void add_product()
        {
            sqlConnection = new SqlConnection(@"Data Source=SQL8004.site4now.net;Initial Catalog=db_a8bcfd_juzz;User Id=db_a8bcfd_juzz_admin;Password=JuzzikASP1");
            sqlConnection.Open();
            sqlCommand = new SqlCommand("SELECT * FROM Products", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            prod.Clear();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    prod.Add(new Products(Convert.ToInt32(sqlDataReader[0]),(byte[])(sqlDataReader[1]), sqlDataReader[2].ToString(), Convert.ToInt32(sqlDataReader[3])));
                }

            }
            sqlConnection.Close();
            parse_product();
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

        //public void show_picture(int select_indx)
        //{
        //    if (select_indx != -1)
        //    {
        //        select_indx = select_indx + 1;
        //        sqlConnection = new SqlConnection(@"Data Source=SQL8004.site4now.net;Initial Catalog=db_a8bcfd_juzz;User Id=db_a8bcfd_juzz_admin;Password=JuzzikASP1");
        //        sqlConnection.Open();
        //        sqlCommand = new SqlCommand("SELECT img FROM Products WHERE Id=" + select_indx, sqlConnection);
        //        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
        //        sqlDataReader.Read();

        //        if (sqlDataReader.HasRows)
        //        {
        //            byte[] image = (byte[])(sqlDataReader[0]);
        //            if (image == null)
        //            {
        //                pictures.BackgroundImage = null;
        //            }
        //            else
        //            {
        //                MemoryStream memory = new MemoryStream(image);
        //                pictures.BackgroundImage = Image.FromStream(memory);
        //            }
        //        }
        //        sqlConnection.Close();
        //        GC.Collect();
        //        foreach (Products item in prod)
        //        {

        //            if (item.id == select_indx)
        //            {
        //                if (item.img == null)
        //                {
        //                    pictures.Image = null;
        //                }
        //                else
        //                {
        //                    pictures.Image = ByteArrayToImage(item.img);
        //                }

        //            }

        //        }
        //    }


        //}
        string imgLoc = "";
        string imgLoc_edit = "";
        public void add_img(string _name, int _cost)
        {
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
            sqlConnection.Close();
            add_product();
            MessageBox.Show("Продукт добавлен!");
            GC.Collect();
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
                    pic.SizeMode = PictureBoxSizeMode.Zoom;
                    pic.ImageLocation = imgLoc;
                    check_img = true;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("error");
            }
        }
        public Image ByteArrayToImage(byte[] data)
        {
            MemoryStream ms = new MemoryStream(data);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        public void show_pictures(int select_indx)
        {
            if (select_indx != -1)
            {
                select_indx = prod[select_indx].id;
                foreach (Products item in prod)
                {

                    if (item.id == select_indx)
                    {
                        if (item.img == null)
                        {
                            pictures.Image = null;
                        }
                        else
                        {
                            pictures.SizeMode = PictureBoxSizeMode.Zoom;
                            pictures.Image = ByteArrayToImage(item.img);
                        }

                    }

                }
                GC.Collect();
            }
        }
        public void Delete_product(int select_indx)
        {


            if (select_indx != -1)
            {

                select_indx = prod[select_indx].id;
                DialogResult dialog = MessageBox.Show("Вы уверены что хотите удалить товар?", "Удаление товара!", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    sqlConnection = new SqlConnection(@"Data Source=SQL8004.site4now.net;Initial Catalog=db_a8bcfd_juzz;User Id=db_a8bcfd_juzz_admin;Password=JuzzikASP1");
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand("DELETE FROM Products WHERE [id]=@id", sqlConnection);
                    sqlCommand.Parameters.AddWithValue("id", select_indx);
                    sqlCommand.ExecuteNonQuery();
                    add_product();
                    MessageBox.Show("Товар удалён!");
                }

            }
            //if (select_indx != -1)
            //{

            //    MessageBox.Show((prod[select_indx].id).ToString());

            //}
        }
        public void Edit_product(int select_indx)
        {


            if (select_indx != -1)
            {

                select_indx = prod[select_indx].id;
                foreach (Products item in prod)
                {

                    if (select_indx == item.id)
                    {
                        editInfo.Text = item.Name;
                        editcost.Text = item.Cost.ToString();
                        Editpic.SizeMode = PictureBoxSizeMode.Zoom;
                        Editpic.Image = ByteArrayToImage(item.img);
                    }

                }

            }
            //if (select_indx != -1)
            //{

            //    MessageBox.Show((prod[select_indx].id).ToString());

            //}

        }
        public void download_edit_pic()
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files (*.BMP; *JPG; *.GIF; *.PNG)|*.BMP; *JPG; *.GIF; *.PNG)|All files (*.*)|*.*";
                openFileDialog.InitialDirectory = @"C:\Users\Admin\Desktop\Parent_control";
                openFileDialog.Title = "Выберите картинку";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imgLoc_edit = openFileDialog.FileName.ToString();
                    Editpic.SizeMode = PictureBoxSizeMode.Zoom;
                    Editpic.ImageLocation = imgLoc_edit;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("error");
            }
            GC.Collect();
        }
        public void Edit_info(string _name, int _cost ,int select_indx)
        {
            if (imgLoc_edit == "")
            {
                select_indx = prod[select_indx].id;

                sqlConnection = new SqlConnection(@"Data Source=SQL8004.site4now.net;Initial Catalog=db_a8bcfd_juzz;User Id=db_a8bcfd_juzz_admin;Password=JuzzikASP1");
                sqlConnection.Open();
                sqlCommand = new SqlCommand("UPDATE Products SET Name = @Name,Cost = @Cost WHERE id=@id", sqlConnection);

                sqlCommand.Parameters.AddWithValue("id", select_indx);
                sqlCommand.Parameters.AddWithValue("@Name", _name);
                sqlCommand.Parameters.AddWithValue("@Cost", _cost);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            else
            {
                select_indx = prod[select_indx].id;
                sqlConnection = new SqlConnection(@"Data Source=SQL8004.site4now.net;Initial Catalog=db_a8bcfd_juzz;User Id=db_a8bcfd_juzz_admin;Password=JuzzikASP1");
                sqlConnection.Open();
                byte[] image = null;
                FileStream fileStream = new FileStream(imgLoc_edit, FileMode.Open, FileAccess.Read);
                BinaryReader reader = new BinaryReader(fileStream);
                image = reader.ReadBytes((int)fileStream.Length);
                //Image x = (Bitmap)((new ImageConverter()).ConvertFrom(image));


                sqlCommand = new SqlCommand("UPDATE Products SET img = @img,Name = @Name, Cost = @Cost WHERE id = @id", sqlConnection);

                sqlCommand.Parameters.AddWithValue("id", select_indx);
                sqlCommand.Parameters.Add(new SqlParameter("@img", image));
                sqlCommand.Parameters.AddWithValue("@Name", _name);
                sqlCommand.Parameters.AddWithValue("@Cost", _cost);

                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            
            add_product();
            MessageBox.Show("Товар изменён!");
            Editpic.Image = null;
            editInfo.Text = "";
            editcost.Text = "";
            GC.Collect();
        }


    }

}
