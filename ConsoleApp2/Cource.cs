﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Cource:Predok
    {
        public string Year;

        public Cource(string Organization, string Level, string Name)
        {
            this.Organization = Organization;
            this.Level = Level;
            this.Name = Name;
        }
    }
}
