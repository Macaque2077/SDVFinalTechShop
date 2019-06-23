using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tech4Universal
{
    //handles differeing between new and used products
    interface IProductControl
    {
        void PushData(clsAllProducts prProduct);
        void UpdateControl(clsAllProducts prProduct);

    }
}
