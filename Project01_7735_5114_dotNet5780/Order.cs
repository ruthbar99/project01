using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//BE Order
//Connects the client to a hosting unit
namespace Project01_7735_5114_dotNet5780
{
    public class Order
    {
        int HostingUnitKey;
        public GuestRequest GuestRequestKey { get; set; }
        public int OrderKey { get; set; }
        public string Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime OrderDate { get; set; }
        public void ToString(int GuestRequestKey)
        {

        }

       
    }
}
