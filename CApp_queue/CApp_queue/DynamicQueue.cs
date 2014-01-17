using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApp_queue
{
    class DynamicQueue
    {
        private QueueElement _head;

        public void Push(object value)
        {
            QueueElement element = new QueueElement();
            element.Data = value;

            element.NextElement = _head;
            _head = element;

        }
        public object Pop()
        {
            QueueElement element = _head;
            _head = _head.NextElement;
            element.NextElement = null;

            return element.Data;

        }
    }
}
