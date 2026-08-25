using System.Collections.Generic;

namespace GenericCollectionActivity
{
    public class Stack
    {
        private List<int> items = new List<int>();

        public void Push(int value)
        {
            items.Add(value);
        }

        public int Pop()
        {
            if (items.Count == 0)
                return -1;

            int value = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);

            return value;
        }

        public int Peek()
        {
            if (items.Count == 0)
                return -1;

            return items[items.Count - 1];
        }

        public bool Search(int value)
        {
            return items.Contains(value);
        }

        public void Clear()
        {
            items.Clear();
        }

        public int Count()
        {
            return items.Count;
        }

        public List<int> GetItems()
        {
            return items;
        }
    }
}
