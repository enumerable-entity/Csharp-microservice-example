using System;
using System.Text.Json.Nodes;
using SzkolenieTechniczne3.Common.CrossCutting.Interfaces;

namespace SzkolenieTechniczne3.Common.CrossCutting.Exceptions
{
    public class ApiHttpExceptions : Exception, IApiHttpException
    {
        public uint HttpErrorCode { get; private set; }

        public JsonObject Error { get; private set; }
        public ApiHttpExceptions(uint httpErrorCode, JsonObject error = null!)
        {
            HttpErrorCode = httpErrorCode;
            Error = error;
        }
    }
}
