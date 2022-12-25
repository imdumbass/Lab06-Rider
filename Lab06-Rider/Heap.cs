using System.Diagnostics;

internal class Heap<T> where T : IComparable<T> {
    private List<T> _data;

    public Heap() {
        _data = new List<T>();
    }

    public Heap(IEnumerable<T> elements) : this() {
        _data.AddRange(elements);

        for (int i = size / 2; i > 0; i--) {
            _heapify(i-1);
        }
    }

    private void _heapify(int i) {
        int target = i;

        if (_left(i) < size && _data[target].CompareTo(_data[_left(i)]) < 0) {
            target = _left(i);
        }

        if (_right(i) < size && _data[target].CompareTo(_data[_right(i)]) < 0) {
            target = _right(i);
        }

        if (target != i) {
            (_data[i], _data[target]) = (_data[target], _data[i]);
            _heapify(target);
        }
    }
    
    public int size {
        get {
            return _data.Count;
        }
    }

    public T max {
        get {
            Trace.Assert(_data.Count > 0);
            return _data[0];
        }
    }

    public T extractMax() {
        Trace.Assert(_data.Count > 0);
        T max = _data[0];

        _data[0] = _data[size - 1];
        _data.RemoveAt(size - 1);
        _heapify(0);

        return max;
    }

    public void insert(T element) {
        _data.Add(element);
        
        int i = size - 1;

        while (i > 0 && _data[_parent(i)].CompareTo(_data[i]) < 0) {
            T temp = _data[i];
            _data[i] = _data[_parent(i)];
            _data[_parent(i)] = temp;

            i = _parent(i);
        }
    }

    private static int _parent(int i) {
        return (i-1) / 2;
    }

    private static int _left(int i) {
        return 2 * i + 1;
    }

    private static int _right(int i) {
        return 2 * i + 2;
    }
} 
