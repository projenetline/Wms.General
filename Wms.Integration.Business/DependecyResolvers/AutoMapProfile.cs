using AutoMapper;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.Dtos.DecompositionLines;
using Wms.Integration.Entities.Dtos.Decompositions;
using Wms.Integration.Entities.Dtos.DecompositionShelfs;
using Wms.Integration.Entities.Dtos.DecompositionShelves;
using Wms.Integration.Entities.Dtos.PurchaseOrders;

namespace Wms.Integration.Business.DependecyResolvers
{
    public class AutoMapProfile:Profile
    {
        public AutoMapProfile()
        {
            CreateMap<OrderSlip, CreatePurchaseOrdersDto>();
            CreateMap<OrderSlipLine, CreatePurchaseOrdersLineDto>();
            CreateMap<CreatePurchaseOrdersDto,OrderSlip>();
            CreateMap<CreatePurchaseOrdersLineDto,OrderSlipLine>();

            CreateMap<Decomposition, SelectDecompositionDto>();
            CreateMap<Decomposition, ListDecompositionDto>();
            CreateMap<CreateDecompositionDto, Decomposition>();
            CreateMap<SelectDecompositionDto, Decomposition>();
            CreateMap<SelectDecompositionDto, CreateDecompositionDto>();
            CreateMap<ListDecompositionDto, SelectDecompositionDto>();

            CreateMap<DecompositionLine, SelectDecompositionLineDto>();
            CreateMap<DecompositionLine, ListDecompositionLineDto>();
            CreateMap<CreateDecompositionLineDto, DecompositionLine>();
            CreateMap<SelectDecompositionLineDto, DecompositionLine>();
            CreateMap<SelectDecompositionLineDto, CreateDecompositionLineDto>();
            CreateMap<ListDecompositionLineDto, SelectDecompositionLineDto>();

            CreateMap<DecompositionShelf, SelectDecompositionShelfDto>();
            CreateMap<DecompositionShelf, ListDecompositionShelfDto>();
            CreateMap<CreateDecompositionShelfDto, DecompositionShelf>();
            CreateMap<SelectDecompositionShelfDto, DecompositionShelf>();
            CreateMap<SelectDecompositionShelfDto, CreateDecompositionShelfDto>();
            CreateMap<ListDecompositionShelfDto, SelectDecompositionShelfDto>();

            CreateMap<DecompositionShelves, SelectDecompositionShelvesDto>();
            CreateMap<DecompositionShelves, ListDecompositionShelvesDto>();
            CreateMap<CreateDecompositionShelvesDto, DecompositionShelves>();
            CreateMap<SelectDecompositionShelvesDto, DecompositionShelves>();
            CreateMap<SelectDecompositionShelvesDto, CreateDecompositionShelvesDto>();
            CreateMap<ListDecompositionShelvesDto, SelectDecompositionShelvesDto>();
        }
    }
}
