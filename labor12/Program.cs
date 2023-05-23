using laba12;

namespace StackExem
{
    class StackEx<T>
    {
        public T[] elems;
        public int count;
        public int n = 10;
        public StackEx(T[] elem, int count)
        {
            elems = elem;
            this.count = count;
        }
        public StackEx()
        {
            elems = new T[n];
        }
        public StackEx(int lenght)
        {
            elems = new T[lenght];
            n = lenght;
        }
        public bool isEmpty
        {
            get { return count == 0; }
        }
        public bool isFull
        {
            get { return count == elems.Length; }
        }
        public void Push(T elem)
        {
            if (isFull)
            {
                throw new StackOverflowException("Стек преполнен!");
            }
            elems[count] = elem;
            count++;
        }
        public int Count()
        {
            return count;
        }
        public virtual T Peek()
        {
            if (isEmpty)
            {
                throw new StackIsEmptyException("Стек пустой");
            }
            return elems[count - 1];
            }
        public virtual T Pop()
        {
            if (isEmpty)
            {
                throw new StackIsEmptyException("Стек пустой");
            }
            T elem = elems[count-1];
            T[] arr = new T[elems.Length - 1];
            Array.Copy(elems, arr, arr.Length);
            elems = new T[arr.Length + 1];
            Array.Copy(arr, elems, arr.Length); count--;
            return elem;
        }
        public void Output()
        {
            for(int i=count-1;i>=0;i--)
            {
                Console.WriteLine(elems[i]);
            }
        }
    }
}