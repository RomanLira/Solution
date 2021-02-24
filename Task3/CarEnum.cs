using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Task3
{
    class CarEnum : IEnumerator
    {
        public Car[] _ap;

        int pos = -1;
        public CarEnum(Car[] list)
        {
            _ap = list;
        }

        public bool MoveNext()
        {
            pos++;
            return (pos < _ap.Length);
        }

        public void Reset()
        {
            pos = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Car Current
        {
            get
            {
                try
                {
                    return _ap[pos];
                }
                catch
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
