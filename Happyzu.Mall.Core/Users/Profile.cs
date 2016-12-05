using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;

namespace Happyzu.Mall.Users
{
    public class Profile : Entity<long>
    {
        [StringLength(255)]
        public string Avatar { get; set; }
    }
}
