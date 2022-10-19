namespace Wms.Integration.Core.DataAccess.Utilities.Results
{
    public interface IDataResult<out T>:IResult
    {
        T Data { get; }
    }
}
