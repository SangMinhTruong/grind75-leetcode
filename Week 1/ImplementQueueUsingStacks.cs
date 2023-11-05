public class MyQueue {

    private Stack<int> _inStack;
    private Stack<int> _outStack;

    public MyQueue() {
        _inStack = new Stack<int>();
        _outStack = new Stack<int>();
    }
    
    public void Push(int x) {
        _inStack.Push(x);
    }
    
    public int Pop() {
        Peek();
        return _outStack.Pop();
    }
    
    public int Peek() {
        if (_outStack.Count == 0) {
            while (_inStack.Count > 0) {
                _outStack.Push(_inStack.Pop());
            }
        }
        return _outStack.Peek();
    }
    
    public bool Empty() {
        return _inStack.Count == 0 && _outStack.Count == 0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */