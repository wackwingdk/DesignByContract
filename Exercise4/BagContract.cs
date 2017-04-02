using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise4
{
    using System.Diagnostics.Contracts;

    [ContractClassFor(typeof(IBag))]
    public abstract class BagContract : IBag
    {
        private List<int> data { get; }

        [ContractInvariantMethod]
        private void HasData()
        {
            Contract.Invariant(data!=null);
        }

        public virtual int Count()
        {
            //Contract.Ensures(Contract.Result<int>() == data.Count);
            throw new NotImplementedException();
        }

        public int CountElem(int elem)
        {
            //Contract.Ensures(Contract.Result<int>() == data.Count(x => x == elem));
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
