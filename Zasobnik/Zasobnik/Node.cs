using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zasobnik
{
    internal class Node<T>
    {
        public T Hodnota { get; set; }
        public Node<T>? Next { get; set; }

        public Node(T hodnota)
        {
            Hodnota = hodnota;
            Next = null;
        }

        public Node(T hodnota, Node<T> next)
        {
            Hodnota = hodnota;
            Next = next;
        }
    }
}
