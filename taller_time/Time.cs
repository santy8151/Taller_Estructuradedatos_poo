namespace taller_time
{
    public class Time
    {
        private int _hour;
        private int _minute;
        private int _second;
        private int _millisecond;

        public Time() : this(0, 0, 0, 0)
        {
        }

        public Time(int hour) : this(hour, 0, 0, 0)
        {
        }

        public Time(int hour, int minute) : this(hour, minute, 0, 0)
        {
        }

        public Time(int hour, int minute, int second) : this(hour, minute, second, 0)
        {
        }

        public Time(int hour, int minute, int second, int millisecond)
        {
            if (!ValidHour(hour))
            {
                throw new InvalidTimeException($"The hour: {hour}, is not valid.");
            }

            if (!ValidMinute(minute))
            {
                throw new InvalidTimeException($"The minute: {minute}, is not valid.");
            }

            if (!ValidSecond(second))
            {
                throw new InvalidTimeException($"The second: {second}, is not valid.");
            }

            if (!ValidMillisecond(millisecond))
            {
                throw new InvalidTimeException($"The millisecond: {millisecond}, is not valid.");
            }

            _hour = hour;
            _minute = minute;
            _second = second;
            _millisecond = millisecond;
        }

        public bool ValidHour(int hour)
        {
            return hour >= 0 && hour <= 23;
        }

        public bool ValidMinute(int minute)
        {
            return minute >= 0 && minute <= 59;
        }

        public bool ValidSecond(int second)
        {
            return second >= 0 && second <= 59;
        }

        public bool ValidMillisecond(int millisecond)
        {
            return millisecond >= 0 && millisecond <= 999;
        }

        public long ToMilliseconds()
        {
            if (!ValidHour(_hour))
            {
                return 0;
            }

            return (_hour * 3_600_000L)
                + (_minute * 60_000L)
                + (_second * 1_000L)
                + _millisecond;
        }

        public long ToSeconds()
        {
            if (!ValidHour(_hour))
            {
                return 0;
            }

            return (_hour * 3_600L) + (_minute * 60L) + _second;
        }

        public int ToMinutes()
        {
            if (!ValidHour(_hour))
            {
                return 0;
            }

            return (_hour * 60) + _minute;
        }

        public bool IsOtherDay(Time other)
        {
            ArgumentNullException.ThrowIfNull(other);
            return ToMilliseconds() + other.ToMilliseconds() >= 86_400_000L;
        }

        public Time Add(Time other)
        {
            ArgumentNullException.ThrowIfNull(other);

            int milliseconds = _millisecond + other._millisecond;
            int seconds = _second + other._second + (milliseconds / 1_000);
            milliseconds %= 1_000;

            int minutes = _minute + other._minute + (seconds / 60);
            seconds %= 60;

            int hours = _hour + other._hour + (minutes / 60);
            minutes %= 60;
            hours %= 24;

            return new Time(hours, minutes, seconds, milliseconds);
        }

        public override string ToString()
        {
            if (!ValidHour(_hour))
            {
                throw new InvalidTimeException($"The hour: {_hour}, is not valid.");
            }

            string period = _hour < 12 ? "AM" : "PM";
            int displayHour = _hour % 12;

            return $"{displayHour:D2}:{_minute:D2}:{_second:D2}.{_millisecond:D3} {period}";
        }
    }
}
