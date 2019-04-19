using System;
using System.Collections.Generic;
using System.Text;
using TrainTicketsApp.Models.Abstract;

namespace TrainTicketsApp.Models
{
    public class Timetable : Entity
    {

        public Guid TrainId { get; set; }
        public virtual Train Train { get; set; }
        public Guid RouteId { get; set; }
        public virtual Route Route { get; set; }
        public DateTime Date { get; set; }
    }
}
