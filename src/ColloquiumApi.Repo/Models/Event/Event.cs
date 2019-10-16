using System;
using System.Collections.Generic;
using System.Text;

namespace ColloquiumApi.Repo.Models
{
    public class Event
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid ColloquiumId { get; set; }
        public DateTime EventStart { get; set; }
        public DateTime EventEnd { get; set; }
        public Guid VenueId { get; set; }
        public DateTime SessionDueDate { get; set; }
        public DateTime RegistrationDueDate { get; set; }
        public string RegistrationUrl { get; set; }
        public DateTime Created { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public Guid UpdatedBy { get; set; }
    }
}
