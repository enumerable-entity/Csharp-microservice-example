using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SzkolenieTechniczne3.Common.Storage.Entities;

namespace SzkolenieTechniczne3.UserIdentity.Storage.Entities
{
    [Index(nameof(Name), IsUnique = true)]
    [Table("Roles", Schema = "Identity")]
    public class Role : BaseEntity
    {
        [MinLength(2)]
        [MaxLength(64)]
        [Required]
        public string Name { get; set; } = null!;
        [MaxLength(300)]
        public string Descrioption { get; set; } = null!;
        public ICollection<User> Users { get; set; } = new HashSet<User>();
    }
}
