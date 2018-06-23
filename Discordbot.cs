using System;
using Discord;
using Discord.WebSocket;
using System.Threading.Tasks;
using Discord.Commands;
using Discord.Audio;
using System.IO;
public class Discordbot
{

    static void Main(string[] args)
    => new Discordbot().StartAsync().GetAwaiter().GetResult();

    private DiscordSocketClient _client;

    private CommandHandler _handler;
     
    public async Task StartAsync()
    {
        _client = new DiscordSocketClient();

        await _client.LoginAsync(TokenType.Bot, "NDIzMjkxOTk3MjI3NDUwMzc1.DgNdeA.hXZDX1xErd0AVczIhyFa-VVwW7M"); // put your token here

        await _client.StartAsync();

        _handler = new CommandHandler(_client);

        await Task.Delay(-1);
    }


}

public class Commands : ModuleBase<SocketCommandContext>
{
    // this is where you make your commands
    [Command("help")]
    public async Task help()
    {
        var a = new Discord.EmbedBuilder();
        a.WithTitle("Commands");
        a.WithDescription("General Commands\n!help // Gives list of commands to use");
        a.WithColor(new Discord.Color(0, 170, 255));
        Discord.IDMChannel gencom = await Context.Message.Author.GetOrCreateDMChannelAsync();
        await gencom.SendMessageAsync("", false, a);
        await gencom.CloseAsync();
    }
    [Command("이찬우")]
    public async Task chanwoo()
    {
        var b = new Discord.EmbedBuilder();
        b.WithTitle("븅신쉑");
        b.WithColor(new Discord.Color(0, 170, 255));
        await Context.Channel.SendMessageAsync("", false, b);
    }
    [Command("kick")]
    [RequireBotPermission(Discord.GuildPermission.KickMembers)]
    [RequireUserPermission(Discord.GuildPermission.KickMembers)]
    public async Task KickAsync(Discord.IGuildUser user, [Remainder] string reason)
    {
        if (user.GuildPermissions.KickMembers)
        {
            var b = new Discord.EmbedBuilder();
            b.WithTitle("User Kicked");
            b.WithDescription(user.Username + "was kicked.");
            b.WithColor(new Discord.Color(0, 170, 255));
            await Context.Channel.SendMessageAsync("", false, b);
            await user.KickAsync();
        }
    }

    [Command("postwelcome")]
    public async Task welcome()
    {
        var b = new Discord.EmbedBuilder();
        b.WithTitle("Welcome");
        b.WithDescription("Enjoy your time here! :smile:");
        b.WithColor(new Discord.Color(0, 170, 255));
        await Context.Channel.SendMessageAsync("", false, b);
    }

    [Command("postrules")]
    public async Task rules()
    {
        var b = new Discord.EmbedBuilder();
        b.WithTitle("Rules");
        b.WithDescription("-WOAH");

        b.WithColor(new Discord.Color(0, 170, 255));
        await Context.Channel.SendMessageAsync("", false, b);
    }
    [Command("LMG MOUNTED")]
    public async Task Lord()
    {
        var b = new Discord.EmbedBuilder();
        b.WithTitle("AND LOADED!");
        b.WithColor(new Discord.Color(0, 170, 255));
        await Context.Channel.SendMessageAsync("", false, b);
        await Context.Channel.SendMessageAsync("https://ubistatic19-a.akamaihd.net/resource/en-us/game/rainbow6/siege/r6-operator-tachanka_229936.png", false);
    }
    /*
    [Command("join", RunMode = RunMode.Async)]
    public async Task voicejoin()
    {
        var b = new Discord.EmbedBuilder();
        b.WithTitle("test2");
        b.WithColor(new Discord.Color(0, 170, 255));
        await Context.Channel.SendMessageAsync("", false, b);
        await _service.JoinAudio(Context.Guild, (Context.User as IVoiceState).VoiceChannel);
    }
    [Command("leave", RunMode = RunMode.Async)]
    public async Task LeaveCmd()
    {
        await _service.LeaveAudio(Context.Guild);
    }

    [Command("play", RunMode = RunMode.Async)]
    public async Task PlayCmd([Remainder] string song)
    {
        await _service.SendAudioAsync(Context.Guild, Context.Channel, song);
    }*/
}
