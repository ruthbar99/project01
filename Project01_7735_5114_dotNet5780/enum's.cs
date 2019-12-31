using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project01_7735_5114_dotNet5780
{
    class enum_s
    {
        enum Area
        {
            All, North, South, Center, Jerusalem
        }

        enum Type
        {
            Zimmer, Hotel, Camping, Apartment
        }

        enum Answer//Pool, Jacuzzi, Garden, ChildrenAttracations
        {
            Necessary, possible, uninterested
        }

        enum Status//Order Status
        {
            NotHandled,
            sentMail,
            closedForCustomerUnresponsiveness,
            closedForCustomerResponse
        }

    }
}
