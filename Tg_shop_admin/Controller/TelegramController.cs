using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Tg_shop_admin.Model;
using Tg_shop_admin.Controller;
using System.Drawing;

namespace Tg_shop_admin.Controller
{
        
    class TelegramController
    {
        //ProductController contrl;
        List<Products> list_products;
        public string admin { get; set; } 
        public string[] admins { get; set; } = { "@jazziks","ssss" };
        public string[] admin_prod { get; set; }
        //List<Products> prod_tg = new List<Products>(contrl.prod);
        public TelegramController(List<Products> products, string[] amins)
        {
            list_products = products;
            admin_prod = amins;
            parseToString();
            var client = new TelegramBotClient("5338424699:AAG-UAM3s9SAXT1jQSkaYD59s1Pu87qWvqY");
            client.StartReceiving(Update, Error);
        }
        Message message = new Message();
        private async Task Update(ITelegramBotClient botClient, Update update, CancellationToken token)
        {

            var message = update.Message;



            foreach (Products item in list_products)
            {

                MemoryStream ms = new MemoryStream(item.img);

                Message messages = await botClient.SendPhotoAsync(
                message.Chat.Id,
                ms,
                "<b>Товар: </b>" + item.Name+ "\n<i> Цена</i>: "+item.Cost + "\n<b> Связь с продавцом: </b>" + admin,
                ParseMode.Html);
            }

        }
        public Image ByteArrayToImage(byte[] data)
        {
            MemoryStream ms = new MemoryStream(data);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        private Task Error(ITelegramBotClient arg1, Exception arg2, CancellationToken arg3)
        {
            System.Windows.Forms.MessageBox.Show("Test");
            throw new NotImplementedException();
        }
        void parseToString()
        {
            for (int i = 0; i < admin_prod.Length; i++)
            {
                admin += admin_prod[i] + " , ";
            }
        }

    }
}
