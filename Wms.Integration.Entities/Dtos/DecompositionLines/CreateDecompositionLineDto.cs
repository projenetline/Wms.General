using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Dtos.DecompositionLines
{
    public class CreateDecompositionLineDto:IBaseDto
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
        public int Amount { get; set; }
        public int SlipLineId { get; set; }
        public string DocumentNumber { get; set; } 
        public string ItemName { get; set; }
        public int TotalAmount { get; set; }
        public Guid DecompositionShelvesId { get; set; }
        public string DecompositionShelvesCode { get; set; }
        public string DecompositionShelvesDescription { get; set; }
    }
}
