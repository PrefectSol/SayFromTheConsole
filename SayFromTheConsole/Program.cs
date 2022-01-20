namespace SayFromTheConsole
{
    using System.Threading.Tasks;
    using Discord;
    using Discord.Commands;
    using Discord.WebSocket;
    using SayFromTheConsole.Modules;

    public class Program : ModuleBase<SocketCommandContext>
    {
        [Command("RegConsole")]
        [Alias("console")]
        public async Task RegConsoleAsync()
        {
            var messages = await this.Context.Channel.GetMessagesAsync(1).FlattenAsync();
            await (this.Context.Channel as SocketTextChannel).DeleteMessagesAsync(messages);
            await Task.Run(() => this.RegConsole());
        }

        public Discord.WebSocket.ISocketMessageChannel RegConsole()
        {
            var channelCommand = this.Context.Channel;
            ConsoleCommand.InputCommandAsync(channelCommand);
            return null;
        }
    }
}
