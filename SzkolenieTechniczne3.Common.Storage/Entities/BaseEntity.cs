using System;
using System.ComponentModel.DataAnnotations;
using SzkolenieTechniczne3.Common.Storage.Interfaces;

namespace SzkolenieTechniczne3.Common.Storage.Entities
{
    public class BaseEntity : ITrackedEntity, IIdentyfiableEntity
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public Guid CreatedByUserId { get; set; }
        public Guid ModifiedByUserId { get; set; }
    }
}
