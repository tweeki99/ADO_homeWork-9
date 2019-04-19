using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainTicketsApp.Models;

namespace TrainTicketsApp
{
    public class DataInitializer : CreateDatabaseIfNotExists<TrainTicketsContext>
    {
        protected override void Seed(TrainTicketsContext context)
        {
            List<Route> routes = new List<Route>
            {
                new Route
                {
                    FromTheCity = "Астана",
                    InTheCity = "Караганда"
                },
                new Route
                {
                    FromTheCity = "Караганда",
                    InTheCity = "Астана"
                },
                new Route
                {
                    FromTheCity = "Астана",
                    InTheCity = "Павлодар"
                },
                new Route
                {
                    FromTheCity = "Павлодар",
                    InTheCity = "Астана"
                }
            };

            context.Routes.AddRange(routes);

            List<Train> trains = new List<Train>
            {
                new Train
                {
                    Name = "Скорый поезд №1"
                },
                new Train
                {
                    Name = "Скорый поезд №2"
                },
                new Train
                {
                    Name = "Скорый поезд №3"
                },
                new Train
                {
                    Name = "Скорый поезд №4"
                },
                new Train
                {
                    Name = "Скорый поезд №5"
                },
            };

            context.Trains.AddRange(trains);
            
            List<Timetable> timetable = new List<Timetable>
            {
                new Timetable
                {
                    TrainId = trains[0].Id,
                    RouteId = routes[0].Id,
                    Date = Convert.ToDateTime("2019-04-30")
                },
                new Timetable
                {
                    TrainId = trains[0].Id,
                    RouteId = routes[1].Id,
                    Date = Convert.ToDateTime("2019-05-01")
                },
                new Timetable
                {
                    TrainId = trains[1].Id,
                    RouteId = routes[0].Id,
                    Date = Convert.ToDateTime("2019-05-01")
                },
                new Timetable
                {
                    TrainId = trains[1].Id,
                    RouteId = routes[1].Id,
                    Date = Convert.ToDateTime("2019-05-02")
                },
                new Timetable
                {
                    TrainId = trains[2].Id,
                    RouteId = routes[2].Id,
                    Date = Convert.ToDateTime("2019-05-01")
                },
                new Timetable
                {
                    TrainId = trains[2].Id,
                    RouteId = routes[3].Id,
                    Date = Convert.ToDateTime("2019-05-02")
                },
                new Timetable
                {
                    TrainId = trains[3].Id,
                    RouteId = routes[2].Id,
                    Date = Convert.ToDateTime("2019-04-30")
                },
                new Timetable
                {
                    TrainId = trains[3].Id,
                    RouteId = routes[3].Id,
                    Date = Convert.ToDateTime("2019-05-01")
                },
                 new Timetable
                {
                    TrainId = trains[4].Id,
                    RouteId = routes[0].Id,
                    Date = Convert.ToDateTime("2019-05-01")
                },
                new Timetable
                {
                    TrainId = trains[4].Id,
                    RouteId = routes[2].Id,
                    Date = Convert.ToDateTime("2019-05-02")
                },
            };

            context.Timetable.AddRange(timetable);

            base.Seed(context);
        }
    }
}
