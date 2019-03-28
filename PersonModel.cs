using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }


        public string Contact
        {
            get
            {
                return $"{ FirstName } { LastName },{ PhoneNumber },{ Address },{ Email }";
            }
        }
    }
}
