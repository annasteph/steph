using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ahdh.Models
{
    public class Information
    {
        private static Information _information;
        public List<Account> Accounts;
        public static Information Context
        {
            get
            {
                if (_information == null)
                {
                    _information = new Information();
                }
                return _information;
            }
        }
        private int NextId()
        {
            return Accounts.Selected(x => x.Id).Max; + 1;
        }
    }
}