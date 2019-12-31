using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//BE GuestRequest
namespace Project01_7735_5114_dotNet5780
{
    class GuestRequest
    {
        static int GeneralGrk = 10000001;//general counter for guest request
        int GuestRequestKey;
        string PrivateName { get; set; }
        string FamilyName { get; set; }
        string MailAddress { get; set; }
        bool Status { get; set; }
        DateTime RegistrationDate { get; set; }
        DateTime EntryDate { get; set; }
        DateTime ReleaseDate { get; set; }
        int Area { get; set; }
        int Type { get; set; }
        int Adults { get; set; }
        int children { get; set; }
        int pool { get; set; }
        int Jacuzzi { get; set; }
        int Garden { get; set; }
        int ChildrensAttractions { get; set; }
        bool SmokingArea { get; set; }
        bool accessible { get; set; }//Accessibility for the disabled
        public void ToString(int GuestRequestKey)
        {

        }



    }
}
