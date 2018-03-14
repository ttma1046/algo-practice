using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    class Human
    {

    }

    abstract class User: Human
    {
        public abstract string TestUser();

        public abstract string TestCompany();

        public virtual string MakeUser()
        {
            return "I made a user";
        }
    }

    class TickUser : User
    {
        public override string TestCompany()
        {
            return "haha";
        }


        public override string TestUser()
        {
            return "TestUser";
        }

        public override string MakeUser()
        {
            return "I made a tick user";
        }
    }

}
