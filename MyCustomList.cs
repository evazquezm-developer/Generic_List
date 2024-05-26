public class MyCustomList<T>
{
    private T[] _items;
    private int _count;

    public int Count => _count;

    // Constructor
    public MyCustomList(int capacity = 10)
    {
        _items = new T[capacity];
        _count = 0;
    }

    public void Add (T item)
    {
        if (_count == _items.Length)
        {
            Array.Resize(ref _items, _items.Length * 2);
        }

        _items[_count++] = item;
    }

    public T Get( int index)
    {
        if ( index < 0 || index >= _count )
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        return _items[index];
    }
}