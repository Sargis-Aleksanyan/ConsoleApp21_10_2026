namespace ConsoleApp21_10_2026
{
    internal class List
    {
        private int[] list;

        public int Count { get; private set; }

        public List()
        {
            list = new int[4];
            Count = 0;
        }

        private void Resize()
        {
            int[] NewList = new int[list.Length * 2];

            for (int i = 0; i < list.Length; i++)
            {
                NewList[i] = list[i];
            }
            list = NewList;
        }

        public void Add(int number)
        {
            if (Count == list.Length)
            {
                Resize();
            }

            list[Count] = number;
            Count++;
        }

        public void Insert(int index, int number)
        {
            if (Count == list.Length)
            {
                Resize();
            }

            if (index == Count)
            {
                list[Count] = number;
                Count++;
            }
            else
            {
                for (int i = Count; i > index; i--)
                {
                    list[i] = list[i - 1];
                }

                list[index] = number;
                Count++;
            }

        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < Count - 1; i++)
            {
                list[i] = list[i + 1];
            }

            Count--;
            list[Count] = 0;
        }

        public int Get(int index)
        {
            return list[index];
        }
    }
}
