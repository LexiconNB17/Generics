﻿namespace Generics
{
    internal class Pair<T1, T2>
    {
        public T1 First { get; set; }
        public T2 Second { get; set; }

        public Pair(T1 first, T2 second)
        {
            First = first;
            Second = second;
        }
    }

    internal class Pair<T> : Pair<T, T>
    {     
        public Pair(T first, T second) 
            : base(first, second)
        {          
        }
    }
}