using System.Text.Json.Nodes;

namespace SzkolenieTechniczne3.Common.CrossCutting.Interfaces
{
    public interface IApiHttpException
    {
        public uint HttpErrorCode { get; }
        public JsonObject Error { get; }
    }
}
