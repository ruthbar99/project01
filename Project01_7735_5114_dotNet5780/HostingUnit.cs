using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//BE HostingUnit
namespace Project01_7735_5114_dotNet5780
{
    class HostingUnit
    {
        static int GeneralHUK= 10000001;//general counter for HostingUnit 
        int HostingUnitKey;
        Host Owner;
        string HostingUnitName { get; set; }
        bool[,] Diary = new bool[12, 31];
        public void ToString(int GuestRequestKey)
        {

        }

    }
}
