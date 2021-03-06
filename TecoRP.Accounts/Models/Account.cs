﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecoRP.Accounts.Models
{
    public class Account
    {
        public string ID { get; set; }
        public string MainSocialClubName { get; set; }
        public string UDID { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public int MaxCharacters { get; set; } = 3;
        public DateTime RegisterDate { get; set; }
    }
}
