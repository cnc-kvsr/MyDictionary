using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    public class MyDictionary<T,F>
    {
        T[] id;
        F[] firstName;

        public MyDictionary()
        {
            id = new T[0];
            firstName = new F[0];
        }

        public void Add(T _id,F _firstName)
        {
            T[] tempArray1 = id;
            id = new T[id.Length + 1];

            F[] tempArray2 = firstName;
            firstName = new F[firstName.Length + 1];

            for (int i = 0; i < tempArray1.Length; i++)
            {
                id[i] = tempArray1[i];
                firstName[i] = tempArray2[i];
            }
            id[id.Length - 1] = _id;
            firstName[firstName.Length - 1] = _firstName;

        }
        public T[] Id
        {
            get { return id; }

        }
        public F[] FirstName
        {
            get { return firstName; }
        }



    }
}
