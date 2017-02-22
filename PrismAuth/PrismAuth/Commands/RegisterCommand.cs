﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiNET;
using MiNET.Plugins;
using MiNET.Plugins.Attributes;
using PrismAuth;
using PrismAuth.Account;

namespace PrismAuth.Commands
{
    public class RegisterCommand : PrismAuth
    {
        [Command(Name = "reg")]
        public void Register(Player commander)
        {
            commander.SendMessage("/reg (password)");
        }

        [Command(Name = "reg")]
        public async void RegisterAsync(Player commander, string password)
        {
            commander.SendMessage("this is register command.");
            if (await this.AccountManager.IsRegisteredAsync(commander))
            {
                commander.SendMessage("you are already registered.");
                return;
            }
            else
            {
                if (await this.AccountManager.RegisterPlayerAsync(commander, password))
                {
                    commander.SendMessage("successfully registered.");
                }
                else
                {
                    commander.SendMessage("failed to register.");
                }
            }
        }
    }
}
