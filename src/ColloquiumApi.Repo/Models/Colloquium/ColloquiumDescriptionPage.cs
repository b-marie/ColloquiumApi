using System;
using System.Collections.Generic;
using System.Text;

namespace ColloquiumApi.Repo.Models
{
    public class ColloquiumDescriptionPage
    {
        public Guid Id { get; set;}
        public Guid ColloquiumId { get; set; }
        public string Title { get; set; }
        public string Copy { get; set; }
        public DateTime Created { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public Guid UpdatedBy { get; set; }
    }
}
