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
    public class FormLayoutManager : IFormLayoutService
    {
        private readonly IFormLayoutDal formLayoutDal;
        private readonly ILoggerDal loggerDal;
        public FormLayoutManager(IFormLayoutDal formLayoutDal, ILoggerDal loggerDal)
        {
            this.formLayoutDal = formLayoutDal;
            this.loggerDal = loggerDal;
        }
        public async Task<IDataResult<FormLayout>> CreateAsync(FormLayout entity)
        {
            try
            {
                return new SuccessDataResult<FormLayout>(await formLayoutDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "FormLayoutManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<FormLayout>(null, CustomJObject.Instance.General.NotCreate);
            }
        }
        public async Task<IDataResult<FormLayout>> DeleteAsync(FormLayout entity)
        {
            try
            {
                return new SuccessDataResult<FormLayout>(await formLayoutDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "FormLayoutManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<FormLayout>(null, CustomJObject.Instance.General.NotDelete);
            }
        }
        public async Task<IDataResult<FormLayout>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<FormLayout>(await formLayoutDal.GetAsync(s => s.Id == id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "FormLayoutManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<FormLayout>(null, CustomJObject.Instance.General.NotGet);
            }
        }
        public async Task<IDataResult<FormLayout>> UpdateAsync(FormLayout entity)
        {
            try
            {
                return new SuccessDataResult<FormLayout>(await formLayoutDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "FormLayoutManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<FormLayout>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
