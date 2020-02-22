using System;
namespace TestTask.Models
{
    [Flags]
    public enum ActiveDays
    {
        Sunday = 1,
        Mondey = 2,
        Tuesday = 4,
        Wednesday = 8,
        Thursday = 16,
        Friday = 32,
        Saturday=64
    }
}
