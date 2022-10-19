using System;
using System.Collections.Generic;
using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class PlanningSlip:IBaseEntity
    {
        public PlanningSlip()
        {
            PlanningSlipLines = new HashSet<PlanningSlipLine>();
            ReservationSlips = new HashSet<ReservationSlip>();
            Slips = new HashSet<Slip>();
            WorkOrders = new HashSet<WorkOrder>();
        }

        public int Id { get; set; }
        public short SlipType { get; set; }
        public string SlipNumber { get; set; }
        public DateTime SlipDate { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public int? WarehouseId { get; set; }
        public int? Warehouse2Id { get; set; }
        public int? CarrierId { get; set; }
        public int? ArpId { get; set; }
        public int? DeliveryArpId { get; set; }
        public int? ShipmentAddressId { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
        public string Description4 { get; set; }
        public string DocumentNumber { get; set; }
        public string CustomCode { get; set; }
        public short Priority { get; set; }
        public int? VehicleId { get; set; }
        public int? DriverId { get; set; }
        public short ShipmentStatus { get; set; }
        public int StateId { get; set; }
        public int? SalesPersonId { get; set; }
        public int? DepartmentId { get; set; }
        public int? DivisionId { get; set; }
        public int? FactoryId { get; set; }
        public int? Department2Id { get; set; }
        public int? Division2Id { get; set; }
        public int? Factory2Id { get; set; }
        public int PrintCount { get; set; }
        public string AuthCode { get; set; }
        public short Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Arp Arp { get; set; }
        public virtual Arp DeliveryArp { get; set; }
        public virtual SysDepartment Department { get; set; }
        public virtual SysDivision Division { get; set; }
        public virtual Driver Driver { get; set; }
        public virtual SysFactory Factory { get; set; }
        public virtual SalesPerson SalesPerson { get; set; }
        public virtual ShipmentAddress ShipmentAddress { get; set; }
        public virtual SysCustomState State { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public virtual SysWarehouse Warehouse { get; set; }
        public virtual SysWarehouse Warehouse2 { get; set; }
        public virtual ICollection<PlanningSlipLine> PlanningSlipLines { get; set; }
        public virtual ICollection<ReservationSlip> ReservationSlips { get; set; }
        public virtual ICollection<Slip> Slips { get; set; }
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
    }
}
