using System;
using System.Collections.Generic;
using System.Text;

namespace ColloquiumApi.Repo.Models
{
    public class UserRoleMap
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid UserRoleId { get; set; }
    }
}
