using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class WeeklyEntry: IComparable<WeeklyEntry>
{

    public WeeklyEntry(string weekDay, string notes)
    {
        this.WeekDay = (WeekDay) Enum.Parse(typeof(WeekDay), weekDay);
        this.Notes = notes;
    }

    public WeekDay WeekDay { get; set; }
    public string Notes { get; set; }

    public override string ToString()
    {
        return $"{this.WeekDay} - {this.Notes}";
    }

    public int CompareTo(WeeklyEntry other)
    {
        if (ReferenceEquals(this, other))
        {
            return 0;
        }
        if (ReferenceEquals(null, other))
        {
            return 1;
        }
        var weekDayCompare = WeekDay.CompareTo(other.WeekDay);
        if (weekDayCompare!=0)
        {
            return weekDayCompare;
        }
        return string.Compare(Notes, other.Notes, StringComparison.Ordinal);
    }
}

