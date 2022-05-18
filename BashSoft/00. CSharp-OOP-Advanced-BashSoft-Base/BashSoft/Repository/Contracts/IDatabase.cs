namespace BashSoft.Repository.Contracts
{
    using System;
    public interface IDatabase : IFilteredTaker, IOrderedTaker, IRequester
    {
        void LoadData(string fileName);
        void UnloadData();
    }
}
