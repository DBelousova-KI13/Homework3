using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Model
{
    public class Numbertron
    {
        public delegate void NewNumberGenerate(int num);

        public event NewNumberGenerate NewNumber;

        private static int _seed = Environment.TickCount;

        private static readonly ThreadLocal<Random> randomWrapper = new ThreadLocal<Random>(() =>
            new Random(Interlocked.Increment(ref _seed))
        );


        public void Generate()
        {
            Random i = randomWrapper.Value;
            int k = i.Next();
            if (NewNumber != null) NewNumber(k);
        }

    }
}
