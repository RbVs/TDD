using System;
using System.Collections.Generic;
using System.Text;

namespace TDD.BusinessLogic
{
    public class Names
    {
        public string MakeFullName(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }

        public string NickName { get; set; }
    }
}
