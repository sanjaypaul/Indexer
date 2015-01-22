using System;

namespace IndexerExample1
{
    class DayCollection
    {
        string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

        public int this[string aDay]
        {
            get
            {
                for (int index = 0; index < days.Length; index++)
                {
                    if (days[index] == aDay)
                    {
                        return index;
                    }
                }

                throw new ArgumentOutOfRangeException(aDay, "aDay must be in the form \"Sun\", \"Mon\", etc");
            }
        }

        public string this[int dayIndex]
        {
            get
            {
                for (int index = 0; index < days.Length; index++)
                {
                    if (index == dayIndex)
                    {
                        return days[index];
                    }
                }
                throw new ArgumentOutOfRangeException("Day index must be between 0 to 6");
            }
        }
    }
}
