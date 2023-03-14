using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using SzkolenieTechniczne3.Common.CrossCutting.Exceptions;

namespace SzkolenieTechniczne3.Common.Storage
{
    public class PlatformDbContext : DbContext
    {
        private const uint VIOLATION_FOREIGH_KEY_REFERENCE_CONSTRAINTS = 547;

        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (Exception exception) when (exception.InnerException is SqlException sqlException &&
            sqlException.Number == VIOLATION_FOREIGH_KEY_REFERENCE_CONSTRAINTS)
            {
                throw new ApiHttpExceptions(StatusCodes.Status409Conflict);
            }
        }
    }
}
