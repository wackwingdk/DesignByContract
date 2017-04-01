using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    using System.Diagnostics.Contracts;

    [ContractClassFor(typeof(IBag))]
    public abstract class BagContract : IBag
    {
        private List<int> data;

        [ContractInvariantMethod]
        public void HasData()
        {
            Contract.Invariant(data!=null);
        }

        public int Count()
        {
            Contract.Ensures(Contract.Result<int>() == data.Count);
            throw new NotImplementedException();
        }

        public int CountElem(int elem)
        {
            Contract.Ensures(Contract.Result<int>() == Contract.su);
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
