using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        private SortedDictionary<string, string> _data = new SortedDictionary<string, string>();
        private string _name;
        private string _number;

        public string FindByNumber(string number) 
        {
            if (_data.ContainsValue(number))
            {
                foreach (var key in _data.Keys.Where(key => _data[key] == number))
                {
                    return key;
                }
            }

            return string.Empty;
        }

        public string GetNumber(string name)
        {
            return _data.ContainsKey(name) ? _data[name] : string.Empty;
        }

        public void PutNumber(string name, string number) 
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(number)) 
            {
                throw new Exception("Name and/or number cannot be empty");
            }

            _data.Add(name, number);
        }

        public void DisplayPhoneBook()
        {
            Console.WriteLine($"Phone book sorted by alphabet:");

            foreach (var data in _data)
            {
                Console.WriteLine($"{data.Key} - {data.Value}");
            }
        }
    }
}