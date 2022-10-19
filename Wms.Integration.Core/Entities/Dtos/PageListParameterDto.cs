using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Core.Entities.Dtos
{
    public class PageListParameterDto:IListParameterDto
    {
        private int skipCount = 0;
        private int maxResultCount = 100;
        private int pageNumber = 1;
        private int _pageSize = 10;

        public int SkipCount { get { return skipCount; } set { skipCount = value; } }
        public int MaxResultCount { get { return maxResultCount; } set { maxResultCount = value; } }
        public int PageNumber { get => pageNumber; set => pageNumber = value; }
        public int PageSize { get { return _pageSize; } set { _pageSize = value; } }
    }
}
