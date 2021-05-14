﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

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
            Console.WriteLine(_stack.Count);
            if (_stack.Count > 0)
            {
                //Console.WriteLine("Test if");
                lastObj = _stack[_stack.Count - 1];
                //lastObj = "test";
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

    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push("Test");
            Console.WriteLine(stack.Pop());
        }

    }
    
}
