using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<TKey,TVal>
    {
        TKey[] keys;
        TVal[] values;
        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TVal[0];


        }

        public void Add(TKey t, TVal v)
        {
                TKey[] tempArrayKey = keys;
                TVal[] tempArrayValue = values;
                keys = new TKey[keys.Length + 1];
                values = new TVal[values.Length + 1];

            for (int i = 0; i < tempArrayKey.Length; i++)
            {
                keys[i] = tempArrayKey[i];
            }

            for (int i = 0; i < tempArrayValue.Length; i++)
            {
                values[i] = tempArrayValue[i];
            }

            keys[keys.Length - 1] = t;
            values[values.Length - 1] = v;

            Console.WriteLine("Sehir adi " + t + " : " + "Nufus: " + v);
        }

        public TKey[] itemkey
        {
            get { return keys; }
        }

        public TVal[] itemvalue
        {
            get { return values; }
        }

        public int Lenght
        {
            get { return keys.Length; }
        }
    }
}
