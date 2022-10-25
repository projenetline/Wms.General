using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Dtos.PurchaseOrders
{
    public class CreatePurchaseOrdersDto:IBaseDto
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
        public string SlipNumber { get; set; }
        public DateTime SlipDate { get; set; }
        public string ArpCode { get; set; }//Cari Kodu
        public string WareHouseCode { get; set; } = "";//Depo
        public string DocumentNumber { get; set; }
        public string CustomCode { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
        public string Description4 { get; set; }
        public string TradingGroupCode { get; set; }
        public int Priority { get; set; } = 0;
        public string DocTrackingNumber { get; set; }
        public int PrintCount { get; set; } = 0;
        public int ShipmentStatus { get; set; } = 1;
        public int StateId { get; set; } = 1;/*
                                              *1:Beklemede
                                              *2:Planlanıyor
                                              *3:Planlandı
                                              *4:İşleme Alındı.
                                              *...........vb
                                              */
        public string AuthCode { get; set; }
        public int Active { get; set; } = 1;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int CreatedBy { get; set; } = -1;
        public string DivisionCode { get; set; }
        public string FactoryCode { get; set; }
        public string DepartmentCode { get; set; }
        public IList<CreatePurchaseOrdersLineDto> createPurchaseOrdersLineDtos { get; set; }
    }
}
