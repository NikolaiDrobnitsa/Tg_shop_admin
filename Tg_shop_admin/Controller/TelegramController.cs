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
        //public string[] admins { get; set; } = { "@jazziks","ssss" };
        public string[] admin_prod { get; set; }
        //List<Products> prod_tg = new List<Products>(contrl.prod);
        private static readonly TelegramBotClient Bot = new TelegramBotClient("5338424699:AAG-UAM3s9SAXT1jQSkaYD59s1Pu87qWvqY");
        public TelegramController(List<Products> products, string[] amins)
        {
            list_products = products;
            admin_prod = amins;
            parseToString();
            //var client = new TelegramBotClient("5338424699:AAG-UAM3s9SAXT1jQSkaYD59s1Pu87qWvqY");
            Bot.StartReceiving(Update, Error);
            //getMember(client);
            //Bot.GetChatMembersCountAsync()
        }
        Message message = new Message();
        private async Task Update(ITelegramBotClient botClient, Update update, CancellationToken token)
        {

            var message = update.Message;
            if (message.Text != null)
            {
                if (message.Text.ToLower().Contains("инфа"))
                {
                   await botClient.SendTextMessageAsync(message.Chat.Id, "вот");
                    //await botClient.GetChatMemberAsync(message.Chat.Id, botClient.GetMeAsync());
                    //bool is_member_of_channel = Is_Member_Of_Channel("@ShopJuzz", message.From.Id);

                    //var chatNM = message.NewChatMember;
                    //var chatLM = msg.LeftChatMember;
                    //var ChatID = msg.Chat.ID;
                    //var userInfo = Bot.GetChatMemberAsync("@ShopJuzz", message.Chat.Id);
                    //await botClient.SendTextMessageAsync(message.Chat.Id, Bot.GetChatMemberAsync("@ShopJuzz", message.Chat.Id).ToString());
                    int col = AccessTheWebAndDoubleAsync(message.Chat.Id).Result;
                    //await botClient.SendTextMessageAsync(message.Chat.Id, Bot.GetChatMembersCountAsync(message.Chat.Id).ToString());
                    await botClient.SendTextMessageAsync(message.Chat.Id, message.Chat.FirstName);
                    await botClient.SendTextMessageAsync(message.Chat.Id, col.ToString());
                    var me = Bot.GetMeAsync().Result;
                    var mes = Bot.GetChatMemberAsync(message.Chat.Id, message.Chat.Id).Result;
                    await botClient.SendTextMessageAsync(message.Chat.Id, me.Username);
                    await botClient.SendTextMessageAsync(message.Chat.Id, me.FirstName);
                    await botClient.SendTextMessageAsync(message.Chat.Id, mes.User.ToString());
                    await botClient.SendTextMessageAsync(message.Chat.Id, mes.User.FirstName);
                    await botClient.SendTextMessageAsync(message.Chat.Id, mes.User.LastName);


                }
                if (message.Text.ToLower().Contains("товар"))
                {
                    foreach (Products item in list_products)
                    {

                        MemoryStream ms = new MemoryStream(item.img);

                        Message messages = await botClient.SendPhotoAsync(
                        message.Chat.Id,
                        ms,
                        "<b>Товар: </b>" + item.Name + "\n<b> Цена</b>: " + item.Cost + "\n<b> Связь с продавцом: </b>" + admin,
                        ParseMode.Html);
                    }
                }

            }

            //message.Chat.
            
            //System.Windows.Forms.MessageBox.Show(botClient.GetChatMembersCountAsync(message.Chat.Id).ToString());
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
        public async Task<int> AccessTheWebAndDoubleAsync(long chatid)
        {
            var task = Bot.GetChatMembersCountAsync(chatid);
            int result = await task;
            return result;
        }
        //public async Task<User> GetMeUser()
        //{
        //    var task = Bot.GetMeAsync();
        //    User result = await task;
        //    return result;
        //}

    }
}
