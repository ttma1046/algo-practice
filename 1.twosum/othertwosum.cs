namespace Leetcode.Twosum
{
    using System;
    public class Othertwosum
    {
        // private int[] newArray;
        // private int[] oldArray;
	    public static void Test() {

            string test = "a";
            string test2 = test;
            System.Console.WriteLine(test);
            System.Console.WriteLine(test2);
            test = "b";
            System.Console.WriteLine(test);
            System.Console.WriteLine(test2);

            string test3 = "mama";
            ChangeName(test3);
            Console.WriteLine(test3);

            User user1 = new User() { Name = "Chandler" };
            var user2 = new User();
            user2 = user1;
            System.Console.WriteLine(user1.Name);
            System.Console.WriteLine(user2.Name);
            user1.Name = "Test";
            System.Console.WriteLine(user1.Name);
            System.Console.WriteLine(user2.Name);

            User user3 = new User() { Name = "Test3" };

            ChangeName(user3);

            Console.WriteLine(user3.Name);

            User user4 = new User() { Name = "Test4" };

            ChangeNameReset(user4);

            Console.WriteLine(user4.Name);

            /*
            var test = "string".Equals("haha");

            Console.WriteLine(test);

            oldArray = new int[10];
            newArray = new int[20];

            for(int i = 0; i< oldArray.Length; i++)
            {
                newArray[i] = oldArray[i];
            }

            oldArray = newArray;
            */
        }

        public class User
        {
            public string Name { get; set; }
        }

        /*
        public void add(int index, int e)
        {
            if (index > oldArray.Length || index < 0)
            {
                throw new ArgumentOutOfRangeException();   
            }

            //如果数组已经满了 就扩容
            if (size >= oldArray.Length)
            {
                // 扩容函数可参考代码1
            }

            for (int i = size - 1; i >= index; i--)
            {
                oldArray[i + 1] = oldArray[i];
            }

            //将数组elementData从位置index的所有元素往后移一位
            // System.arraycopy(oldArray, index, oldArray, index + 1,size - index);

            oldArray[index] = e;

            size++;
        }
        */
        public static void ChangeName(User user)
        {
            user.Name = "hahah";
        }

        public static void ChangeName(string str)
        {
            str = "baba";
        }

        public static void ChangeNameReset(User user)
        {
            var testUser = new User() { Name = "username" };

            user = testUser;
        }
    }
}