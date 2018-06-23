using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.IO;
using Discord;
using Discord.Audio;
using Discord.WebSocket;
using Discord.Commands;
    public class SoundService : ModuleBase<ICommandContext>
    {
        private readonly AudioService _service;
        public SoundService(AudioService service)
        {
            _service = service;
        }
        
    }

