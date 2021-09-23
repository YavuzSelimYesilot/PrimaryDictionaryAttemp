using System;
using System.Collections.Generic;
using System.Text;

namespace PrimaryDictionaryAttemp
{
    class MyDictionary<T, K>
    {
        //2 değer tutan bir yapı     (key, value)

        //Example
        //Dictionary<string, string> openWith = new Dictionary<string, string>();
        //openWith.Add("txt", "notepad.exe");

        T[] key;
        K[] value;

        public MyDictionary()
        {
            key = new T[0];
            value = new K[0];
        }

        public void Add(T item1, K item2)
        {
            T[] tempKeyArray = key;
            key = new T[key.Length + 1];

            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                key[i] = tempKeyArray[i];
            }

            key[key.Length - 1] = item1;

            //-----------------------------------

            K[] tempValueArray = value;
            value = new K[value.Length + 1];

            for (int i = 0; i < tempValueArray.Length; i++)
            {
                value[i] = tempValueArray[i];
            }

            value[value.Length - 1] = item2;

        }

        public int Length
        {
            get { return key.Length; }
        }

        public  T[] Keys
        {
            get { return key; }
        }

        public K[] Values
        {
            get { return value; }
        }


    }
}
