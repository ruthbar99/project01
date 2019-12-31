using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    interface Idal
    {
        void addGuestRequest();
        void ChangeStatus(int GuestRequestKey);
        void addHostingUnit(Host owner, string Name);


    }
}
