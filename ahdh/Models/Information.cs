using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ahdh.Models
{
    public class Information
    {
        public List<Account> Accounts;

        public Information() 
        {
            Accounts = new List<Account>();
            Accounts.Add(new Account { Id = 1, Name = "My name1", Age = 12 });
            Accounts.Add(new Account { Id = 2, Name = "My name2", Age = 12 });
            Accounts.Add(new Account { Id = 3, Name = "My name3", Age = 12 });
        }
    }
}