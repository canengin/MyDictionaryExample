using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryExample
{
    public class MyDictionary<T>
    {
        T[] members;
        public MyDictionary()
        {
            members = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = members;
            members = new T[members.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                members[i] = tempArray[i];

            }
            members[members.Length - 1] = item;
        }
        public int Length
        {
            get { return members.Length; }
        }
        public T[] Items
        {
            get { return members; }
        }

    }
}
