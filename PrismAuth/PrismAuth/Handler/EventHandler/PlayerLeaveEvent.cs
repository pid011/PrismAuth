﻿using MiNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrismAuth.Account;

namespace PrismAuth.Handler.EventHandler
{
    public class PlayerLeaveEvent : BaseEventHandler
    {
        public void PlayerLeave(object sender, PlayerEventArgs e)
        {
            this.AccountManager.LogoutPlayer(e.Player.Username);
        }
    }
}