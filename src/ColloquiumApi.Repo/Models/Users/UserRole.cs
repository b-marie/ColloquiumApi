using System;
using System.Collections.Generic;
using System.Text;

namespace ColloquiumApi.Repo.Models
{
    public class UserRole
    {
        public Guid Id { get; set; }
        public string EventId { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
