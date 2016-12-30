using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeBot
{
    class MyBot
    {
        DiscordClient discord;


        public MyBot()
            {
            Discord = new DiscordClient(x =>
         {
             x.LogLevel = LogSeverity.Info;
             x.LogHandler = Log;
         });

            discord.UsingCommands(x =>
            {
                x.PrefixChar = '!';
                x.AllowMentionPrefix = true;

            });
var commands = discord.GetService<CommandService>();

            commands.CreateCommand("Hello")
                     .Do(async (e) =>
                     {
                         await e.Channel.SendMessage("I may not do much, but at least I am online....Looking at you Genesis Bot....");

                     });                    

Discord.ExecuteAndWait(async () =>
            {
                await Discord.Connect("MjY0MzE5Mjk2MDgyMDE4MzA1.C0e9vQ.b6d6IutWSPepx - jEQlLA2Erq3mw",TokenType.Bot);
            });

        }

        public DiscordClient Discord
        {
            get
            {
                return discord;
            }

            set
            {
                discord = value;
            }
        }

        private void Log(object sender, LogMessageEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
