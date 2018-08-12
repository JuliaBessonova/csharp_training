using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WebAddressbookTests
{
    public class ContactData : IEquatable<ContactData>, IComparable<ContactData>
    {
        public string allphones;
        public string allemails;

        public ContactData()
        {
           
        }

        public ContactData(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
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

            if (Lastname.CompareTo(other.Lastname) == 0)
            {
                if (Firstname.CompareTo(other.Firstname) == 0)
                {
                    return 0;
                }
                return Firstname.CompareTo(other.Firstname);
            }
            return Lastname.CompareTo(other.Lastname);
        }

        public string Id { get; set; }

        public string Firstname { get; set; }
        
        public string Lastname { get; set; }
       
        public string Address { get; set; }
        
        public string Home { get; set; }
       
        public string Mobile { get; set; }
        
        public string Work { get; set; }

        public string AllPhones
        {
            get
            {
                if (allphones != null)
                {
                    return allphones;
                }
                else
                {
                    return (CleanUp(Home) + CleanUp(Mobile) + CleanUp(Work) + CleanUp(Phone2)).Trim();
                }
            }

            set
            {
                allphones = value;
            }
        }

        private string CleanUp(string value)
        {
            if (value == null || value == "")
            {
                return "";
            }
            return value.Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "") + "\r\n";
        }

        public string Email { get; set; }
        
        public string Email2 { get; set; }
        
        public string Email3 { get; set; }

        public string AllEmails
        {
            get
            {
                if (allemails != null)
                {
                    return allemails;
                }
                else
                {
                    return (CleanUp(Email) + CleanUp(Email2) + CleanUp(Email3)).Trim();

                }
                    
            }
            set
            {
                allemails = value;
            }
        }

        public string Phone2 { get; set; }

        
    }
}
