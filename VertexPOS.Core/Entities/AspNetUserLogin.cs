using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace VertexPOS.Core
{
    [Index(nameof(UserId), Name = "IX_AspNetUserLogins_UserId")]
    public partial class AspNetUserLogin
    {
        [Key]
        [StringLength(128)]
        public string LoginProvider { get; set; }
        [Key]
        [StringLength(128)]
        public string ProviderKey { get; set; }
        public string ProviderDisplayName { get; set; }
        [Required]
        public string UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(AspNetUser.AspNetUserLogins))]
        public virtual AspNetUser User { get; set; }
    }
}
