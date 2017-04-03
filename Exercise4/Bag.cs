using System;

namespace Exercise4
{
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Linq;

    public class Bag : IBag
    {
        public IEnumerable<int> data { get; set; }

        public void Add(int elem)
        {
            throw new NotImplementedException();
        }

        public bool Contains(int elem)
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        
        public int CountElem(int elem)
        {
            Contract.Ensures(Contract.Result<int>() == data.Count(x => x == elem));
            throw new NotImplementedException();
        }

        public void Remove(int elem)
        {
            throw new NotImplementedException();
        }
    }
}
