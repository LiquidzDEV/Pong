﻿using RetroTable.MySql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroTable.UserSystem
{
    internal static class UserManager
    {
        private static List<User> Users = new List<User>();

        public static User Player1 { get; set; }
        public static User Player2 { get; set; }

        internal static User CreateUser(string name)
        {
            //TODO if (Database.User.UserHasName(name) != null) return null;
            if (Users.Find(x => x.Name == name) != null) return null;

            var user = new User(name);

            Users.Add(user);

            //TODO return Database.User.UserCreate(name);
            return user;
        }

        private static void UpdateUsers()
        {
            //TODO Users = Database.User.UserGet();

            if (Player1 != null && !Users.Contains(Player1))
            {
                Player1 = null;
            }

            if (Player2 != null && !Users.Contains(Player2))
            {
                Player2 = null;
            }
        }

        internal static List<User> GetUsers()
        {
            UpdateUsers();
            return Users.ToList();
        }
    }
}
