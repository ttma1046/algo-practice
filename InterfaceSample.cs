using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{

    public class InterfaceSample : IRight
    {
        /*
        int ILeft.P
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        */
        public int P()
        {
            throw new NotImplementedException();
        }

        private class innerClass
        {

        }
    }

    interface ILeft
    {
        int P { get; }
    }

    interface IRight
    {
        int P();
    }

}
