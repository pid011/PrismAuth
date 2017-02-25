﻿using MiNET;
using MiNET.Net;
using MiNET.Plugins.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismAuth.Handler.PacketHandler
{
    public class CommandStepPacket : BasePacketHandler
    {
        [PacketHandler]
        public Package HandleCommandStep(McpeCommandStep packet, Player target)
        {
            // TODO: reg, login 명령어 제외
            if (!this.AccountManager.IsLogined(target))
            {
                target.SendMessage("please login first.");
                return null;
            }

            return packet;
        }
    }
}
