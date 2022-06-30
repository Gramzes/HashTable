using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    class MyHashTable
    {
        public List<List<Abonent>> table = new List<List<Abonent>>();
        List<Abonent> abonents;

        public MyHashTable(List<Abonent> abonents)
        {
            for (int i = 0; i < 255; i++)
            {
                table.Add(new List<Abonent>());
            }
            for (int i=0; i < abonents.Count; i++)
            {
                table[MyHashFunction(abonents[i].phoneNumber)].Add(abonents[i]);
            }
        }

        int MyHashFunction(string value)
        {
            string num4 = value.Substring(value.Length - 5, 5);
            int intValue = Convert.ToInt32(num4.Remove(2,1));
            return intValue*200 % 255;
        }

        public Abonent Search(string value)
        {
            int index = MyHashFunction(value);
            for (int i=0; i < table[index].Count; i++)
            {
                if (table[index][i].phoneNumber == value)
                {
                    return table[index][i];
                }
            }
            return null;
        }
    }
}
