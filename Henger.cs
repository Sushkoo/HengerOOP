using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Henger
    {
        private int magassag;
        private int sugar;
        private int szuletesSzamlalo=0;

        public Henger(int magassag, int sugar, int szuletesSzamlalo)
        {
            this.magassag = magassag;
            this.sugar = sugar;
        }

        public int Magassag { get => magassag;}
        public int Sugar { get => sugar;}
        public int SzuletesSzamlalo { get => szuletesSzamlalo; }

        public double Terfogat()
        {
            //r2*pi*m
            return Math.Pow(sugar, 2)*3.14*magassag;
        }

        public void ToString()
        {
            throw new System.NotImplementedException();
        }
    }
}
