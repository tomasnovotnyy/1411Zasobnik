using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zasobnik
{
    internal class Zasobnik<T>
    {
        public Node<T>? head { get; set; }
        public int count { get; set; }

        public Zasobnik()
        {
            head = null;
            count = 0;
        }

        public void Push(T value)
        {
            Node<T> node = new Node<T>(value);
            node.Next = head;
            head = node;
        }

        public T? Pop()
        {
            if (head == null)
            {
                throw new Exception("Zasobnik je prazdny.");
            }
            Node<T> node = head;
            head = node.Next;
            return node.Hodnota;
        }

        public bool IsEmpty
        {
            get { return head == null; }
        }
    }
}
