using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tech4Universal
{
    interface IProductControl
    {
        void PushData(clsAllProducts prProduct);
        void UpdateControl(clsAllProducts prProduct);

    }
}
