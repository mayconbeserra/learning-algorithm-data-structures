namespace Learning.DataStructures.ArraysAndStrings
{
    public class SinglyLinkedList<T>
    {
        public Node<T> Head { get; protected set; }

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);

            var current = Head;

            if (current == null) 
            {
                Head = node; 
                return;
            }

            while(current.Next != null)
            {
                current = current.Next;
            }

            current.Next = node;
        }

        public void Remove(T data)
        {
            if (Head == null) return;
            if (Head.Data.Equals(data))
            {
                Head = Head.Next; 
                return;
            }

            var current = Head;
            Node<T> previous = null;

            while(current != null)
            {
                if (current.Data.Equals(data))
                    previous.Next = current.Next;
                else previous = current;

                current = current.Next;
            }
        }
    }

    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; protected set; }

        public Node(T data)
        {
            Data = data;
        }
    }
}