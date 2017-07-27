using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class WeeklyCalendar
{
    public List<WeeklyEntry> WeeklySchedule { get; }

    public WeeklyCalendar()
    {
        this.WeeklySchedule = new List<WeeklyEntry>();
    }
    public void AddEntry(string weekday, string notes)
    {
        this.WeeklySchedule.Add(new WeeklyEntry(weekday, notes));
    }

    
}

