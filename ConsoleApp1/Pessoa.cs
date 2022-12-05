using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Pessoa
    {
        public Pessoa(string name = null, char sex = default, string spouse = null)
        {
            Name = name;
            IsMarried = !string.IsNullOrEmpty(spouse);
            Sex = sex;
            Spouse = spouse;
        }

        public string Name { get; set; }
        public bool IsMarried { get; set; }
        public char Sex { get; set; }
        public string Spouse { get; set; }
    }
}
