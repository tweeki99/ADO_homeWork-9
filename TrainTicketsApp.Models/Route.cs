using System;
using System.Collections.Generic;
using System.Text;
using TrainTicketsApp.Models.Abstract;

namespace TrainTicketsApp.Models
{
    public class Route : Entity
    {
        public string FromTheCity { get; set; }
        public string InTheCity { get; set; }
        public virtual ICollection<Timetable> Timetable { get; set; }
    }
}
