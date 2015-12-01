using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Numbertron
    {
        public delegate void NewNumberGenerate(int num);

        public event NewNumberGenerate NewNumber;


        public void Generate()
        {
            Random rand = new Random();
            int i = rand.Next();
            NewNumber(i);
        }

    }
}
