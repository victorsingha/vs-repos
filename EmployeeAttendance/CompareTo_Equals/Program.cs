using System;

namespace CompareTo_Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "victor";
            string s2 = "sictor";
            string s3 = "vkctor";
            string s4 = "victor";
            int res1 = s1.CompareTo(s2);    // 1 since 's' comes before 'v'
            int res2 = s1.CompareTo(s3);    // -1 since 'k' comes after 'i'
            int res3 = s1.CompareTo(s4);    // 0 since both are equal
            Console.WriteLine(res1);
            Console.WriteLine(res2);
            Console.WriteLine(res3);
            bool r1 = s1.Equals(s2);    //false => 's' not equals to 'v'
            bool r2 = s1.Equals(s3);    //false => 'k' not equals to 'i'
            bool r3 = s1.Equals(s4);    //true  => both string are same
            Console.WriteLine(r1);
            Console.WriteLine(r2);
            Console.WriteLine(r3);
            Console.ReadKey();
        }
    }
}
