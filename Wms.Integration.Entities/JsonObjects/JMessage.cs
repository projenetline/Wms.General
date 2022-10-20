using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.JsonObjects
{
    public class JMessage:IJsonEntity
    {
        public string Get { get; set; } = "";
        public string GetParameter { get; set; } = "";
        public string Create { get; set; } = "";
        public string Delete { get; set; } = "";
        public string Update { get; set; } = "";
        public string List { get; set; } = "";
        public string PagedList { get; set; } = "";
        public string Any { get; set; } = "";

        public string NotGet { get; set; } = "";
        public string NotGetParameter { get; set; } = "";
        public string NotCreate { get; set; } = "";
        public string NotDelete { get; set; } = "";
        public string NotUpdate { get; set; } = "";
        public string NotList { get; set; } = "";
        public string NotPagedList { get; set; } = "";
        public string NotAny { get; set; } = "";
    }
}
