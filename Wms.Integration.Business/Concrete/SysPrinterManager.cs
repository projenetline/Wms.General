using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class SysPrinterManager : ISysPrinterService
    {
        private readonly ISysPrinterDal sysPrinterDal;
        public SysPrinterManager(ISysPrinterDal sysPrinterDal)
        {
            this.sysPrinterDal = sysPrinterDal;
        }

        public Task<IDataResult<SysPrinter>> CreateAsync(SysPrinter entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysPrinter>> DeleteAsync(SysPrinter entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysPrinter>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysPrinter>> UpdateAsync(SysPrinter entity)
        {
            throw new NotImplementedException();
        }
    }
}
