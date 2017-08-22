using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulbPuzzleLibrary
{
    public class BulbPuzzle
    {
        int _numberOfPeople;
        int _numberOfBulbs;
        bool[] _bulbs;

        public bool[] Bulbs
        {
            get { return _bulbs; }
        }

        public BulbPuzzle(int numberOfPeople, int numberOfBulbs)
        {
            _numberOfPeople = numberOfPeople;
            _numberOfBulbs = numberOfBulbs;
            _bulbs = new bool[numberOfBulbs];
            Init();
        }

        public int Run()
        {
            int numberOfBulbsOn = 0;
            for (int i = 1; i <= _numberOfPeople; i++)
            {
                for (int j = i - 1; j < _numberOfBulbs; j += i)
                {
                    _bulbs[j] = !_bulbs[j]; // Switch the state of the bulb.
                }

            }

            for (int i = 0; i < _numberOfBulbs; i++)
            {
                if (_bulbs[i])
                {
                    numberOfBulbsOn++;
                }
            }
            return numberOfBulbsOn;
        }

        private void Init()
        {
            for (int i = 0; i < _numberOfBulbs; i++)
            {
                _bulbs[i] = false;
            }
        }
    }
}
