using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS3309_DealOrNoDeal
{
    class Player
    {
        private int id;
        private String firstName;
        private String lastName;
        private String dateOfBirth;
        private String address;
        private int wins;
        private int losses;
        private double highestWinnings;
        private double lowestWinnings;
        private Case playerCase;

        public Player()
        {

        }

        public Case PlayerCase
        {
            get { return this.playerCase; }
            set { this.playerCase = value; }
        }

        private void SelectCaseToKeep()
        {

        }

        private void ReadStatisticsFromDatabase()
        {

        }

        private void WriteStatisticsToDatabase()
        {

        }


    }
}
