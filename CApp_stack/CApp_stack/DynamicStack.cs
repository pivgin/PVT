using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApp_stack
{
    class DynamicStack
    {
        private StackElement _head;

        public void Push(object value)
        {
            StackElement element = new StackElement();
            element.Data = value;

            element.NextElement = _head;
            _head = element;

        }
        public object Pop()
        {
            StackElement element = _head;
            _head = _head.NextElement;
            element.NextElement = null;
            return element.Data;

        }

    }
}
