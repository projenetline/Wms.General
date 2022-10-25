using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Dtos.PurchaseOrders
{
    public class CreatePurchaseOrdersLineDto:IBaseDto
    {
        public int Id { get; set; } = 0;
        public int SlipType { get; set; } = 1;/*
                                               * 2:Satın Alma Faturası (Tiger),
                                               * 3:Alınan Proforma Fatura (Tiger),
                                               * 6:Satınalma İade Faturası (Tiger)
                                               * 10:Satın alma İrsaliyesi(Tiger), 
                                               * 11:Konsinye Giriş İrsaliyesi (Tiger),
                                               * 15:Satınalma İade İrsaliyesi (Tiger),
                                               * 20:Üretimden Giriş Fişi (Tiger),
                                               */
        public int SlipId { get; set; } = 0;
        public int LineNumber { get; set; }
        public DateTime LineDate { get; set; }
        public string ItemCode { get; set; }
        public int ItemUnitId { get; set; } = 0;
        public double Quantity { get; set; }
        public string CustomCode { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string DepartmentCode { get; set; }
        public string DivisionCode { get; set; }
        public string FactoryCode { get; set; }
        public string ArpCode { get; set; }
        public string WarehouseCode { get; set; }
        public int DocumentType { get; set; }
        public double ConvFactor1 { get; set; }
        public double ConvFactor2 { get; set; }
        public int Priority { get; set; }
        public int Closed { get; set; }
        public int ShipmentStatus { get; set; }
        public int StateId { get; set; }
        public int Active { get; set; }
        public DateTime  CreatedDate { get; set; }
        public int  CreatedBy { get; set; }

    }
}
