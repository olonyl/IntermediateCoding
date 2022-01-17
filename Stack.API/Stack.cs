using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.API
{
    public class Stack
    {
        private readonly List<Object> _stack;

        public Stack()
        {
            _stack = new List<object>();
        }

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException($"{nameof(Push)}: invalid parameter value for {nameof(obj)}");
            _stack.Add(obj);
        }

        public object Pop()
        {
            if (_stack.Count == 0)
                throw new InvalidOperationException($"{nameof(Pop)}: can't be called with an empty list");
            var lastElement = _stack[_stack.Count - 1];
            _stack.RemoveAt(_stack.Count - 1);
            return lastElement;
        }

        public void Clear()
        {
            _stack.Clear();
        }
    }
}
