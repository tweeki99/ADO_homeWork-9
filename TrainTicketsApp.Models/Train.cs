using System;
using System.Collections.Generic;
using System.Text;
using TrainTicketsApp.Models.Abstract;

namespace TrainTicketsApp.Models
{
    public class Train : Entity
    {
        public string Name { get; set; }
        public virtual ICollection<Timetable> Timetable { get; set; }
    }
}
