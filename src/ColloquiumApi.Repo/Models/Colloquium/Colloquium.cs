using System;
using System.Collections.Generic;
using System.Text;

namespace ColloquiumApi.Repo.Models
{
    public class Colloquium
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime Update { get; set; }
        public Guid UpdatedBy { get; set; }
    }
}
