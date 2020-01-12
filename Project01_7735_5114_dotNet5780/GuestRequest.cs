using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//BE GuestRequest
namespace Project01_7735_5114_dotNet5780
{
    public class GuestRequest
    {
   
        public int GuestRequestKey { get; set; }
        public string PrivateName { get; set; }
        public string FamilyName { get; set; }
        public string MailAddress { get; set; }
        public bool Status { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Area { get; set; }
        public int Type { get; set; }
        public int Adults { get; set; }
        public int children { get; set; }
        public int pool { get; set; }
        public int Jacuzzi { get; set; }
        public int Garden { get; set; }
        public int ChildrensAttractions { get; set; }
        public bool SmokingArea { get; set; }
        public bool accessible { get; set; }//Accessibility for the disabled
        public void ToString(int GuestRequestKey)
        {

        }
       


    }
}
