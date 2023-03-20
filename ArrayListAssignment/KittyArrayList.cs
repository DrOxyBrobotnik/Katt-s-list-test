namespace ArrayListAssignment
{
    public class KittyArrayList
    {
        private readonly int _resizeValue;
        private int _currentIndex;
        private int[] _array;

        public int Length 
        { 
            get { return _currentIndex; } 
        }

        public KittyArrayList() : this(100)
        {

        }

        public KittyArrayList(int initialSize) : this(initialSize, 50)
        {

        }

        public KittyArrayList(int initialSize, int resizeValue)
        {
            _resizeValue = resizeValue;
            _currentIndex = 0;
            _array = new int[initialSize];
        }

        public int Get(int index)
        {
            if (index > _currentIndex)
                throw new IndexOutOfRangeException();

            return _array[index];
        }

        public void Add(int value)
        {
            if (_currentIndex >= _array.Length)
                ResizeArray();

            _array[_currentIndex++] = value;
        }

        public void Remove(int value)
        {
            for (var i = _currentIndex; i >= 0; i--)
            {
                if (_array[i] == value)
                {
                    RemoveValueAt(i);
                }
            }
        }

        private void ResizeArray()
        {
            var newArray = new int[_array.Length + _resizeValue];

            for (var i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }

            _array = newArray;
        }

        private void RemoveValueAt(int index)
        {
            for (var i = index; i < _array.Length - 1; i++)
            {
                _array[i] = _array[i + 1];
            }

            _array[_array.Length - 1] = 0;
            _currentIndex--;
        }
    }
}