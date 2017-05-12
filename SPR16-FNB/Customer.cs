using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPR16_FNB
{
    [Serializable]
    /// <summary>
    /// Bank Customer Class
    /// </summary>
    public class Customer
    {
        private int number;
        private string firstName;
        private string lastName;
        private string address1;
        private string address2;
        private string city;
        private string state;
        private string zip;
        private string email;
        private string phone;

        /// <summary>
        /// Constructor Class
        /// </summary>
        public Customer()
        {

        }
        /// <summary>
        /// Second Constructor
        /// </summary>
        /// <param name="fname">Cust fname</param>
        /// <param name="lname">cUST lname</param>
        public Customer(string fname, string lname)
        {

        }
        

        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Address1
        {
            get { return address1; }
            set { address1 = value; }
        }

        public string Address2
        {
            get { return address2; }
            set { address2 = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public string Zip
        {
            get { return zip; }
            set { zip = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
    }
}
