using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class ArpManager : IArpService
    {
        private readonly IArpDal arpDal;
        private readonly ILoggerDal loggerDal;
        public ArpManager(IArpDal arpDal, ILoggerDal loggerDal)
        {
            this.arpDal = arpDal;
            this.loggerDal = loggerDal;
        }
        public async Task<IDataResult<Arp>> CreateAsync(Arp entity)
        {
            try
            {
                return new SuccessDataResult<Arp>(await arpDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ArpManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Arp>(null, CustomJObject.Instance.General.NotGet);
            }
        }
        public async Task<IDataResult<Arp>> DeleteAsync(Arp entity)
        {
            try
            {
                return new SuccessDataResult<Arp>(await arpDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ArpManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Arp>(null, CustomJObject.Instance.General.NotDelete);
            }
        }
        public async Task<IDataResult<Arp>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<Arp>(await arpDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ArpManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Arp>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<Arp>> GetCodeAsync(string Code)
        {
            try
            {
                return new SuccessDataResult<Arp>(await arpDal.GetAsync(s => s.Code == Code), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ArpManager.GetCodeAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Arp>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<Arp>> UpdateAsync(Arp entity)
        {
            try
            {
                return new SuccessDataResult<Arp>(await arpDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ArpManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Arp>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
