namespace SayFromTheConsole.Modules
{
    using System;
    using System.Threading.Tasks;
    using Discord.Commands;
    using DiscordBot.Common;

    internal class ConsoleCommand : ModuleBase<SocketCommandContext>
    {
        private static async void InputCommand(Discord.WebSocket.ISocketMessageChannel channelCommand)
        {
            while (true)
            {
                string text = Console.ReadLine();
                var embed = new BotEmbedBuilder()
                    .WithDescription(text)
                    .Build();
                await channelCommand.SendMessageAsync(embed: embed);
            }
        }

        public static async void InputCommandAsync(Discord.WebSocket.ISocketMessageChannel channelCommand) => await Task.Run(() => InputCommand(channelCommand));
    }
}