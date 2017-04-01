namespace Exercise4
{
    using System.Diagnostics.Contracts;

    [ContractClass(typeof(BagContract))]
    public interface IBag
    {
        int Count();
        int CountElem(int elem);
        bool Contains(int elem);
        void Add(int elem);
        void Remove(int elem);
    }
}
