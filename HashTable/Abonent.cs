using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    class Abonent
    {
        public string phoneNumber;
        public string name;
        public string dateOfBirthday;

        public Abonent(string phoneNumber, string name, string dateOfBirthday)
        {
            this.phoneNumber = phoneNumber;
            this.name = name;
            this.dateOfBirthday = dateOfBirthday;
        }
    }
}
