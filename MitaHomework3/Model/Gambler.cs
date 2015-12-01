using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class Gambler
    {
        private readonly string _name;
        private int _score;

        protected Gambler(string name)
        {
            _name = name;
        }


        public string Name
        {
            get { return _name; }
        }

        public int Score
        {
            get { return _score; }
            private set { _score = value; }
        }

        public void AddScore()
        {
            _score++;
        }

        public abstract void FetchNewNumber(int i);

    }
}
