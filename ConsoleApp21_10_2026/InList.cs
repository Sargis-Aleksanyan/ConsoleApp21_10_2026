namespace ConsoleApp21_10_2026
{
    internal class List
    {
        private int[] _list;

        public int Count { get; private set; }

        public List()
        {
            _list = new int[4];
            Count = 0;
        }

        private void Resize()
        {
            int[] NewList = new int[_list.Length * 2];

            for (int i = 0; i < _list.Length; i++)
            {
                NewList[i] = _list[i];
            }
            _list = NewList;
        }

        public void Add(int number)
        {
            if (Count == _list.Length)
            {
                Resize();
            }

            _list[Count] = number;
            Count++;
        }

        public void Insert(int index, int number)
        {
            if (index < 0 || index > Count)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            if (Count == _list.Length)
            {
                Resize();
            }

            if (index == Count)
            {
                _list[Count] = number;
                Count++;
            }
            else
            {
                for (int i = Count; i > index; i--)
                {
                    _list[i] = _list[i - 1];
                }

                _list[index] = number;
                Count++;
            }

        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            for (int i = index; i < Count - 1; i++)
            {
                _list[i] = _list[i + 1];
            }

            Count--;
            _list[Count] = 0;
        }

        public int Get(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
            return _list[index];
        }
    }
}
