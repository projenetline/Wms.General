namespace Wms.Integration.Core.DataAccess.Utilities.Results
{
    public class PagedResult<T> where T:class
    {
        private int totalCount;
        private IList<T> items;
        public int TotalCount { get => totalCount; set => totalCount = value; }
        public IList<T> Items
        {
            get => items ?? (items = new List<T>());
            set => items = value;
        }
    }
}
