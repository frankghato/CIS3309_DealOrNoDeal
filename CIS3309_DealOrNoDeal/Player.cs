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
        private String firstName;
        private String lastName;
        private String dateOfBirth;
        private String address;

        public Player()
        {

        }

        public Player(int id, String firstName, String lastName, String dateOfBirth, String address)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.address = address;
        }

        public int ID
        {
            get { return this.id; }
        }

        public String FirstName
        {
            get { return this.firstName; }
        }

        public String LastName
        {
            get { return this.LastName; }
        }

        public String DateOfBirth
        {
            get { return this.dateOfBirth; }
        }

        public String Address
        {
            get { return this.address; }
        }
    }
}
