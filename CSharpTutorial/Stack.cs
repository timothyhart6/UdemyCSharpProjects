using System;
using System.Collections;

namespace CSharpTutorial
{
    class Stack
    {
        private ArrayList _stack = new ArrayList();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException();
            _stack.Add(obj);
        }

        public object Pop()
        {
            object lastObj;
            if (_stack.Count > 0)
            {
                lastObj = _stack[_stack.Count - 1];
                _stack.RemoveAt(_stack.Count - 1);
            }
            else
            {
                throw new InvalidOperationException();
            }


            return lastObj;
        }

        public void Clear()
        {
            _stack.Clear();
        }


    }

}
