using System;
using System.Collections.Generic;
using System.Text;

namespace TheDictionary
{
    class Surname<TKey, TValue>
    {
        TKey[] Keys;
        TValue[] Values;
        public Surname()
        {
            Keys = new TKey[0];
            Values = new TValue[0];
        }

        public void Add(TKey Key, TValue Value)
        {
            TKey[] tArKey = Keys;
            Keys = new TKey[Keys.Length + 1];
            TValue[] tArVal = Values;
            Values = new TValue[Values.Length + 1];

            for (int i = 0; i < tArKey.Length; i++)
            {
                Keys[i] = tArKey[i];
                Values[i] = tArVal[i];
            }

            Keys[Keys.Length - 1] = Key;
            Values[Values.Length - 1] = Value;
        }

        public int Count 
        {
            get { return Keys.Length; }
        }

        public void List() 
        {
            for (int i = 0; i < Keys.Length; i++)
            {
                Console.WriteLine(Keys[i] + "  " + Values[i]);
            }
        }
    }
}
