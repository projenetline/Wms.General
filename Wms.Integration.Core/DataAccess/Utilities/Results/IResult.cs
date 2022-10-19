namespace Wms.Integration.Core.DataAccess.Utilities.Results
{
    public interface IResult
    {
        string Message { get; }
        bool Success { get; }
    }
}
