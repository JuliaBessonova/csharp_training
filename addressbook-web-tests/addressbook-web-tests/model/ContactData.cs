using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class ContactData : IEquatable<ContactData>, IComparable<ContactData>
    {
        private string firstname;
        private string lastname;
        private string address = "";
        private string home = "";
        private string mobile = "";
        private string work = "";
        private string email = "";
        private string email2 = "";
        private string email3 = "";
        private string phone2 = "";

        public ContactData(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }

        public bool Equals(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return false;
            }
            if (Object.ReferenceEquals(this, other))
            {
                return true;
            }
            return Firstname == other.Firstname && Lastname == other.Lastname;
        }

        public override int GetHashCode()
        {
            return Firstname.GetHashCode() + Lastname.GetHashCode();
        }

        public override string ToString()
        {
            return "firstname=" + Firstname + " " + "lastname=" + Lastname;
        }

        public int CompareTo(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return 1;
            }
            return Lastname.CompareTo(other.Lastname) + Firstname.CompareTo(other.Firstname);
        }

        public string Firstname
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }

        }

        public string Lastname
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }

        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }

        }

        public string Home
        {
            get
            {
                return home;
            }
            set
            {
                home = value;
            }

        }

        public string Mobile
        {
            get
            {
                return mobile;
            }
            set
            {
                mobile = value;
            }

        }

        public string Work
        {
            get
            {
                return work;
            }
            set
            {
                work = value;
            }

        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }

        }

        public string Email2
        {
            get
            {
                return email2;
            }
            set
            {
                email2 = value;
            }

        }

        public string Email3
        {
            get
            {
                return email3;
            }
            set
            {
                email3 = value;
            }

        }

        public string Phone2
        {
            get
            {
                return phone2;
            }
            set
            {
                phone2 = value;
            }

        }
    }
}
