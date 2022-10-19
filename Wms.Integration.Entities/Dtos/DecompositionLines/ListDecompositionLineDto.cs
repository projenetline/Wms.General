using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Dtos.DecompositionLines
{
    public class ListDecompositionLineDto: IBaseDto
    {
        public DateTime CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public int Amount { get; set; }
        public string DocumentNumber { get; set; }
        public string ItemName { get; set; }
        public int TotalAmount { get; set; }
        public string DecompositionShelvesCode { get; set; }
        public string DecompositionShelvesDescription { get; set; }
    }
}