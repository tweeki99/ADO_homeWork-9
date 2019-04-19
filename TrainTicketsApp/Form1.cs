using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainTicketsApp.Models;

namespace TrainTicketsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            using (var context = new TrainTicketsContext())
            {
                var cities = context.Routes.GroupBy(p=>p.FromTheCity)
                                 .Select(g => new { Name = g.Key});
                foreach (var city in cities)
                {
                    ComboBoxFromTheCity.Items.Add(city.Name);
                }

                cities = context.Routes.GroupBy(p => p.InTheCity)
                                 .Select(g => new { Name = g.Key });
                foreach (var city in cities)
                {
                    ComboBoxInTheCity.Items.Add(city.Name);
                }
            }
        }

        private void ButtonSearchClick(object sender, EventArgs e)
        {
            if (ComboBoxFromTheCity.SelectedItem == null || ComboBoxInTheCity.SelectedItem == null)
            {
                MessageBox.Show("Выберите все точки маршрута");
                return;
            }
            LoadDataGridViewTimetable();
            if (DataGridViewTimetable.Rows.Count > 0)
            {
                TimetableVisable(true);
            }
            else MessageBox.Show("Не найдено подходящих вариантов");
        }

        private void ButtonToOrderClick(object sender, EventArgs e)
        {
            using (var context = new TrainTicketsContext())
            {
                var train = context.Trains.ToList().Where(t => t.Name == DataGridViewTimetable.SelectedRows[0].Cells["Train"].Value.ToString()).FirstOrDefault();

                MessageBox.Show($"Вы забронировали билет на поезд \"{train.Name}\"\nКод поезда<{train.Id}>");
            }
        }
        
        private void LoadDataGridViewTimetable()
        {
            DataGridViewTimetable.Rows.Clear();
            DataGridViewTimetable.Columns.Clear();

            DataGridViewTimetable.Columns.Add("FromTheCity", "Откуда");
            DataGridViewTimetable.Columns.Add("InTheCity", "Куда");
            DataGridViewTimetable.Columns.Add("Train", "Поезд");
            DataGridViewTimetable.Columns.Add("Date", "Дата выезда");

            using (var context = new TrainTicketsContext())
            {
                DateTime date = Convert.ToDateTime(DateTimePicker.Text);
                var timetable = context.Timetable.Where(t => t.Date == date
                                                          && t.Route.FromTheCity == ComboBoxFromTheCity.SelectedItem.ToString()
                                                          && t.Route.InTheCity == ComboBoxInTheCity.SelectedItem.ToString()).ToList();

                for (int i = 0; i < timetable.Count(); i++)
                {
                    List<string> data = new List<string>();

                    data.Add(timetable[i].Route.FromTheCity);
                    data.Add(timetable[i].Route.InTheCity);
                    data.Add(timetable[i].Train.Name);
                    data.Add(timetable[i].Date.ToLongDateString());

                    DataGridViewTimetable.Rows.Add(data.ToArray());
                }
            }
        }

        private void TimetableVisable(bool showOrHide)
        {
            DataGridViewTimetable.Visible = showOrHide;
            ButtonToOrder.Visible = showOrHide;
        }

        private void ComboBoxFromTheCitySelectedIndexChanged(object sender, EventArgs e)
        {
            TimetableVisable(false);
        }

        private void ComboBoxInTheCitySelectedIndexChanged(object sender, EventArgs e)
        {
            TimetableVisable(false);
        }

        private void DateTimePickerTextChanged(object sender, EventArgs e)
        {
            TimetableVisable(false);
        }
    }
}
