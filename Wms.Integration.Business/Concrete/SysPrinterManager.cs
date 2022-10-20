using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.DataAccess.Concrete;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class SysPrinterManager : ISysPrinterService
    {
        private readonly ISysPrinterDal sysPrinterDal;
        private readonly ILoggerDal loggerDal;
        public SysPrinterManager(ISysPrinterDal sysPrinterDal, ILoggerDal loggerDal)
        {
            this.sysPrinterDal = sysPrinterDal;
            this.loggerDal = loggerDal;
        }

        public async Task<IDataResult<SysPrinter>> CreateAsync(SysPrinter entity)
        {
            try
            {
                return new SuccessDataResult<SysPrinter>(await sysPrinterDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysPrinterManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysPrinter>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<SysPrinter>> DeleteAsync(SysPrinter entity)
        {
            try
            {
                return new SuccessDataResult<SysPrinter>(await sysPrinterDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysPrinterManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysPrinter>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<SysPrinter>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<SysPrinter>(await sysPrinterDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysPrinterManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysPrinter>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<SysPrinter>> UpdateAsync(SysPrinter entity)
        {
            try
            {
                return new SuccessDataResult<SysPrinter>(await sysPrinterDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysPrinterManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysPrinter>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
