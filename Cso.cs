using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp7
{
    public class Cso : Henger
    {
        private int falVastagsag;

        public Cso(int magassag, int sugar, int szuletesSzamlalo, int falVastagsag) : base(magassag, sugar, szuletesSzamlalo)
        {
            this.falVastagsag = falVastagsag;
        }
        public int FalVastagsag
        {
            get => falVastagsag;
        }
    }
}