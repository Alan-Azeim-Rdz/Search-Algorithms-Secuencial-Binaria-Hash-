using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_Algorithms__Secuencial__Binaria___Hash_
{
    internal class Node
    {
        public int Key;  // Clave del par clave-valor
        public string Value;  // Valor asociado a la clave
        public Node Next;  // Apuntador al siguiente nodo

        public Node(int key, string value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }
}
