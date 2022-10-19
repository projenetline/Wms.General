using System;
using System.Collections.Generic;
using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class ItemTotalsReportView:IBaseEntity
    {
        public int WarehouseId { get; set; }
        public string DepoKodu { get; set; }
        public string DepoAdi { get; set; }
        public int AddressId { get; set; }
        public string Adres { get; set; }
        public int? ContainerId { get; set; }
        public string TasimaKabiNo { get; set; }
        public string TasimaKabiAciklamasi { get; set; }
        public int ItemId { get; set; }
        public string MalzemeKodu { get; set; }
        public string MalzemeAdi { get; set; }
        public int? VariantId { get; set; }
        public string VaryantKodu { get; set; }
        public string VaryantAdı { get; set; }
        public string TakipNumarasi { get; set; }
        public string SonKullanimTarihi { get; set; }
        public decimal? Stok { get; set; }
        public decimal? Rezerve { get; set; }
    }
}
