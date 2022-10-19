using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class UnitBarcodeManager : IUnitBarcodeService
    {
        private readonly IUnitBarcodeDal _unitBarcodeDal;
        public UnitBarcodeManager(IUnitBarcodeDal unitBarcodeDal)
        {
            _unitBarcodeDal = unitBarcodeDal;
        }

        public Task<IDataResult<UnitBarcode>> CreateAsync(UnitBarcode entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<UnitBarcode>> DeleteAsync(UnitBarcode entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<UnitBarcode>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<UnitBarcode>> UpdateAsync(UnitBarcode entity)
        {
            throw new NotImplementedException();
        }
    }
}
