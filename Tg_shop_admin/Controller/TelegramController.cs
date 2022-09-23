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
        ProductController contrl;
        //List<Products> prod_tg = new List<Products>(contrl.prod);
        public TelegramController()
        {
            var client = new TelegramBotClient("5338424699:AAG-UAM3s9SAXT1jQSkaYD59s1Pu87qWvqY");
            client.StartReceiving(Update, Error);
        }
        Message message = new Message();
        private async Task Update(ITelegramBotClient botClient, Update update, CancellationToken token)
        {
            //var message = update.Message;
            ////var chatId = message.Chat.Id;
            //Message messages = await botClient.SendPhotoAsync(
            //message.Chat.Id,
            //"https://github.com/TelegramBots/book/raw/master/src/docs/photo-ara.jpg",
            //"<b>Ara bird</b>. <i>Source</i>: <a href=\"https://pixabay.com\">Pixabay</a>",
            //ParseMode.Html);
            var message = update.Message;
            //var chatId = message.Chat.Id;
            //using (var fileStream = new FileStream(mypath, FileMode.Open, FileAccess.Read, FileShare.Read))
            //{
            //    await _botService.Client.SendPhotoAsync(
            //        chatId: message.Chat.Id,
            //        photo: new InputOnlineFile(fileStream),
            //        caption: "My Photo"
            //    );
            //}


            //using (var fileStream = new FileStream(@"C:\Users\Admin\source\repos\Tg_shop_admin\Tg_shop_admin\imgs\5293765.jpg", FileMode.Open, FileAccess.Read, FileShare.Read))
            //{
            //    Message messages = await botClient.SendPhotoAsync(
            //message.Chat.Id,
            //fileStream,
            //"<b>Ara bird</b>. <i>Source</i>: <a href=\"https://pixabay.com\">Pixabay</a>",
            //ParseMode.Html);
            //}


            foreach (Products item in contrl.prod)
            {

                MemoryStream ms = new MemoryStream(item.img);
               using (var fileStream = new FileStream(@"C:\Users\Admin\source\repos\Tg_shop_admin\Tg_shop_admin\imgs\5293765.jpg", FileMode.Open, FileAccess.Read, FileShare.Read))
               {
                Message messages = await botClient.SendPhotoAsync(
                message.Chat.Id,
                fileStream,
                "<b>Ara bird</b>. <i>Source</i>: <a href=\"https://pixabay.com\">Pixabay</a>" + item.Name,
                ParseMode.Html);
               }
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

    }
}
