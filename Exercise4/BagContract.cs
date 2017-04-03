using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise4
{
    using System.Diagnostics.Contracts;

    [ContractClassFor(typeof(IBag))]
    public abstract class BagContract : IBag
    {
        public virtual int Count()
        {
            //Contract.Ensures(Contract.Result<int>() == data.Count);
            throw new NotImplementedException();
        }

        public int CountElem(int elem)
        {
            throw new NotImplementedException();
        }

        public bool Contains(int elem)
        {
            throw new NotImplementedException();
        }

        public void Add(int elem)
        {
            throw new NotImplementedException();
        }

        public void Remove(int elem)
        {
            throw new NotImplementedException();
        }
    }
}
