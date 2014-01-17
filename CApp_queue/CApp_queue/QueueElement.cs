using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApp_queue
{
    class QueueElement
    {
        public Object Data { get; set; }
        public QueueElement NextElement { get; set; }
    }
}
