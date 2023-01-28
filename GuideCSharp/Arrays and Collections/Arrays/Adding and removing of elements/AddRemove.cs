using System;
using System.Collections.Generic;
using System.Text.Json;

namespace GuideCSharp.ArraysandCollections.Arrays.Addingandremovingofelements
{
    public class AddRemove
    {
        public AddRemove()
        {
            var primeNumbers = new List<int> { 2, 5, 7 };
            primeNumbers.Add(11);
            //primeNumbers is {2, 5, 7, 11}
            ShowList(primeNumbers);

            primeNumbers.Insert(1, 3);
            //primeNumbers is {2, 3, 5, 7, 11}
            ShowList(primeNumbers);

            primeNumbers.RemoveAt(2);
            //primeNumbers is {2, 3, 7, 11}
            ShowList(primeNumbers);

            primeNumbers.AddRange(new[] { 13, 17 });
            //primeNumbers is {2, 3, 7, 11, 13, 17}
            ShowList(primeNumbers);

            primeNumbers.RemoveRange(0, 2);
            primeNumbers.InsertRange(0, new[] { 2, 3, 5 });
            //primeNumbers is {2, 3, 5, 7, 11, 13, 17}
            ShowList(primeNumbers);

            primeNumbers.Clear();
            //primeNumbers is {}
            ShowList(primeNumbers);

            void ShowList(List<int> list)
            {
                Console.WriteLine(JsonSerializer.Serialize(list));
            }
        }
    }
}

