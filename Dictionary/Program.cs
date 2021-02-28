using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> personInfo = new MyDictionary<int, string>();
            personInfo.Add(1, "Barış");
        }
    }

    class MyDictionary<K,V>
    {
        K[] key;
        V[] value;
        K[] tempkey;
        V[] tempvalue;

        public MyDictionary()
        {
            key = new K[0];
            value = new V[0];
        }

        public void Add(K indexs, V values)
        {
            tempkey = key;
            tempvalue = value;

            key = new K[key.Length + 1];
            value = new V[value.Length + 1];

            for (int i = 0; i < tempvalue.Length; i++)
            {
                key[i] = tempkey[i];
                value[i] = tempvalue[i];
            }

            key[key.Length - 1] = indexs;
            value[value.Length - 1] = values;

            Console.WriteLine(values + " ismini ekleme işlemini gerçekleştirdiniz.");
        }
    }
}
