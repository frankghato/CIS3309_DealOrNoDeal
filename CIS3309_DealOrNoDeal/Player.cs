using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS3309_DealOrNoDeal
{
    public class Player
    {
        private int id;
        private string firstName;
        private string lastName;
        private string dateOfBirth;
        private string address;
        private decimal highestWinnings;
        private decimal lowestWinnings;
        private int gamesPlayed;
        private int millionsWon;

        public Player()
        {

        }

        public Player(int id, decimal highestWinnings, decimal lowestWinnings, int gamesPlayed, int millionsWon)
        {
            this.id = id;
            this.highestWinnings = highestWinnings;
            this.lowestWinnings = lowestWinnings;
            this.gamesPlayed = gamesPlayed;
            this.millionsWon = millionsWon;
        }

        public Player(string firstName, string lastName, string dateOfBirth, string address)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.address = address;
            gamesPlayed = 0;
            millionsWon = 0;
            highestWinnings = 0;
            lowestWinnings = 0;
        }

        public int ID
        {
            get { return id; }
        }

        public string FirstName
        {
            get { return firstName; }
        }

        public string LastName
        {
            get { return lastName; }
        }

        public string DateOfBirth
        {
            get { return dateOfBirth; }
        }

        public string Address
        {
            get { return address; }
        }

        public decimal HighestWinnings
        {
            get { return highestWinnings; }
            set { highestWinnings = value; }
        }

        public decimal LowestWinnings
        {
            get { return lowestWinnings; }
            set { lowestWinnings = value; }
        }

        public int GamesPlayed
        {
            get { return gamesPlayed; }
            set { gamesPlayed = value; }
        }

        public int MillionsWon
        {
            get { return millionsWon; }
            set { millionsWon = value; }
        }
    }
}

