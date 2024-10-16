using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Encap2
{
    public class Person
    {
        public string FullName { get; private set; }
        public int Age { get; private set; }
        public string PhoneNumber { get; private set; }

        public Person(string fullName, int age, string phoneNumber)
        {
            int spaceCount = 0;
            for (int i = 0; i < fullName.Length; i++)
            {
                if (fullName[i] == ' ')
                {
                    spaceCount++;
                }
            }

            if (spaceCount >= 1)
            {
                string[] words = fullName.Split(' ');
                bool boyukHerf = true;

                foreach (var word in words)
                {
                    if (word.Length == 0 || word[0] < 65 || word[0] > 90)
                    {
                        boyukHerf = false;
                        break;
                    }
                }

                if (boyukHerf)
                {
                    FullName = fullName;
                    Console.WriteLine("Istifadeci yaradildi");
                }
                else
                {
                    Console.WriteLine("Her iki soz boyuk herfle baslamalidi");
                }
            }
            else
            {
                Console.WriteLine("En az iki soz olmalidor");
            }
            Age = age;
            PhoneNumber = phoneNumber;
        }
    }
}
