﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TShockAPI;
using TerrariaApi.Server;
using Terraria; 
using Terraria.ID; 

namespace Statistics
{
    static class Overlay
    {
        //NetMessage.SendData((int)PacketTypes.CreateCombatText,
//						-1, -1, message.Key, (int)c.PackedValue, Main.npc[id].position.X, Main.npc[id].position.Y);
        public static void SendKillCount(int id)
        {

            Color c = Color.Red;
            string message = "BANG";
            Announcements.ConsoleSendMessage(message + ":" + id);
            NetMessage.SendData((int)PacketTypes.CreateCombatText, -1, -1, message, (int)c.PackedValue, Main.npc[id].position.X, Main.npc[id].position.Y);
        }
    }
}
