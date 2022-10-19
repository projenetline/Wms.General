using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class ShipmentAddress:IBaseEntity
    {
        public ShipmentAddress()
        {
            OrderSlips = new HashSet<OrderSlip>();
            PlanningSlips = new HashSet<PlanningSlip>();
            ShipmentDays = new HashSet<ShipmentDay>();
            Slips = new HashSet<Slip>();
            WorkOrders = new HashSet<WorkOrder>();
        }

        public int Id { get; set; }
        public int? ArpId { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string CustomCode { get; set; }
        public string TradingGroupCode { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string CityCode { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string Town { get; set; }
        public string TownCode { get; set; }
        public string District { get; set; }
        public string DistrictCode { get; set; }
        public string PostCode { get; set; }
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
        public string FaxNumber1 { get; set; }
        public string FaxNumber2 { get; set; }
        public string TaxNumber { get; set; }
        public string TaxOffice { get; set; }
        public string TaxCode { get; set; }
        public string Url { get; set; }
        public string Email { get; set; }
        public string AuthCode { get; set; }
        public short Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<OrderSlip> OrderSlips { get; set; }
        public virtual ICollection<PlanningSlip> PlanningSlips { get; set; }
        public virtual ICollection<ShipmentDay> ShipmentDays { get; set; }
        public virtual ICollection<Slip> Slips { get; set; }
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
    }
}
