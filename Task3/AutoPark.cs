using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Task3
{
    class AutoPark : IEnumerable
    {
        private Car[] _ap;

        public AutoPark(Car[] arr)
        {
            _ap = new Car[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                _ap[i] = arr[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public CarEnum GetEnumerator()
        {
            return new CarEnum(_ap);
        }
    }
}
