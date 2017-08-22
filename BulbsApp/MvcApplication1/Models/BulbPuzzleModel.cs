using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;
using BulbPuzzleLibrary;
namespace MvcApplication1.Models
{
    public class BulbPuzzleModel
    {

        private int _countOfBulbsOn;
        private bool[] _bulbs;

        [DisplayName("Number of People")]
        public int NumberOfPeople { get; set; }

        [DisplayName("Number of Bulbs")]
        public int NumberOfBulbs { get; set; }

        [DisplayName("Number of Bulbs On")]
        public int NumberOfBulbsOn { get { return _countOfBulbsOn; } }

        public void Run()
        {
            BulbPuzzle puzzle = new BulbPuzzle(NumberOfPeople, NumberOfBulbs);
            _countOfBulbsOn = puzzle.Run();
            _bulbs = puzzle.Bulbs;
        }
    }
}