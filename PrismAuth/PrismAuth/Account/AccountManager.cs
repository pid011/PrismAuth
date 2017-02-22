﻿using MiNET;
using Newtonsoft.Json;
using PrismAuth.Util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace PrismAuth.Account
{
    public class AccountManager
    {
        private List<string> loginedPlayer;

        public AccountManager()
        {
            this.loginedPlayer = new List<string>();
        }

        public async Task<bool> RegisterPlayerAsync(Player player, string password)
        {
            var task = Task.Run(() => AddPlayer(player.Username, password));
            var completed = await task;

            if (completed)
            {
                this.loginedPlayer.Add(player.Username);
            }
            return completed;
        }

        public async Task<bool> LoginPlayerAsync(Player player, string password)
        {
            var task = Task.Run(() => VerifyPassword(player.Username, password));
            var completed = await task;

            if (completed)
            {
                this.loginedPlayer.Add(player.Username);
            }
            return completed;
        }

        public bool IsLogined(Player player)
        {
            return this.loginedPlayer.Exists(x => x == player.Username);
        }

        public void DisconnectPlayer(Player player)
        {
            this.loginedPlayer.Remove(player.Username);
        }

        public async Task<bool> IsRegisteredAsync(Player player)
        {
            return await Task.Run(() =>
            {
                var path = IO.GetFilePath(player.Username + ".json");
                if (File.Exists(path))
                {
                    PlayerAccount account = null;
                    using (StreamReader file = new StreamReader(path, Encoding.Unicode))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        account = (PlayerAccount)serializer.Deserialize(file, typeof(PlayerAccount));
                    }

                    if (account != null)
                    {
                        return true;
                    }
                }

                return false;
            });
        }

        public List<string> GetLoginedPlayers()
        {
            return this.loginedPlayer;
        }

        private bool AddPlayer(string userName, string password)
        {
            var completed = false;
            try
            {
                
                var path = IO.GetFilePath(userName + ".json");
                if (!File.Exists(path))
                {
                    File.Create(path);
                }
                if (TryEncryptPassword(password, out string digest))
                {
                    var account = new PlayerAccount() { Password = digest };
                    var json = JsonConvert.SerializeObject(account, Formatting.Indented);
                    File.WriteAllText(path, json, Encoding.Unicode);
                    completed = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                completed = false;
            }

            return completed;
        }

        private void RemovePlayer(string userName)
        {
            var path = IO.GetFilePath(userName + ".json");
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        private async Task RemoveAsync(string userName)
        {
            var task = Task.Run(() => RemovePlayer(userName));

            await task;
            return;
        }

        private bool VerifyPassword(string targetName, string password)
        {
            var verify = false;

            var path = IO.GetFilePath(targetName + ".json");
            if (File.Exists(path))
            {
                PlayerAccount account = null;
                using (StreamReader file = new StreamReader(path, Encoding.Unicode))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    account = (PlayerAccount)serializer.Deserialize(file, typeof(PlayerAccount));
                }

                if (account != null)
                {
                    verify = VerifyDigest(password, account.Password);
                }
            }

            return verify;
        }

        private bool TryEncryptPassword(string passwd, out string digest)
        {
            digest = null;
            try
            {
                digest = BCrypt.Net.BCrypt.HashPassword(passwd, 11);
            }
            catch (BCrypt.Net.SaltParseException)
            {
                return false;
            }

            return true;
        }

        private bool VerifyDigest(string passwd, string digest)
        {
            var verify = false;
            try
            {
                verify = BCrypt.Net.BCrypt.Verify(passwd, digest);
            }
            catch (BCrypt.Net.SaltParseException)
            {
                return false;
            }
            return verify;
        }
    }
}
