namespace Lap4
{
    internal class Program
    {
        #region DateTime Value Type (Struct)
        struct SDateTime
        {
            int hour;
            int minute;
            int second;
            public void Gettime()
            {
                Console.WriteLine($" Your Time Is  {Hour}H , {minute}M , {second}S ");

            }
            public SDateTime(int _hour, int _minute, int _second)
            {
                Hour = _hour;
                Minute = _minute;
                Second = _second;
                Gettime();
            }
            public SDateTime(int _hour, int _minute)
            {
                Hour = _hour;
                Minute = _minute;
                Gettime();
            }
            public SDateTime(int _hour)
            {
                Hour = _hour;
                Gettime();
            }
            public SDateTime()
            {

            }


            public int Hour
            {
                set
                {
                    if (value < 0 || value > 24)
                    {
                        hour = 0;
                    }
                    else
                    {
                        hour = value;
                    }
                }
                get { return hour; }
            }
            public int Minute
            {
                set
                {
                    if (value < 0 || value > 60)
                    {
                        minute = 0;
                    }
                    else { minute = value; }
                }
                get
                {
                    return minute;
                }
            }
            public int Second
            {
                set
                {
                    if (value < 0 || value > 60)
                    {
                        value = 0;
                    }
                    else { second = value; }
                }

                get { return second; }
            }
        }
        #endregion
        #region DateTime Ref Typr (Class)
        class CDateTime
        {
            int hour;
            int minute;
            int second;
            public void Gettime()
            {
                Console.WriteLine($" Your Time Is  {Hour}H , {minute}M , {second}S ");

            }
            public CDateTime(int _hour, int _minute, int _second)
            {
                Hour = _hour;
                Minute = _minute;
                Second = _second;
                Gettime();
            }
            public CDateTime(int _hour, int _minute)
            {
                Hour = _hour;
                Minute = _minute;
                Gettime();
            }
            public CDateTime(int _hour)
            {
                Hour = _hour;
                Gettime();
            }
            public CDateTime()
            {

            }


            public int Hour
            {
                set
                {
                    if (value < 0 || value > 24)
                    {
                        hour = 0;
                    }
                    else
                    {
                        hour = value;
                    }
                }
                get { return hour; }
            }
            public int Minute
            {
                set
                {
                    if (value < 0 || value > 60)
                    {
                        minute = 0;
                    }
                    else { minute = value; }
                }
                get
                {
                    return minute;
                }
            }
            public int Second
            {
                set
                {
                    if (value < 0 || value > 60)
                    {
                        value = 0;
                    }
                    else { second = value; }
                }

                get { return second; }
            }
        }
        #endregion
        static void Main(string[] args)
        {
            #region Creation array
            CDateTime[] cd = new CDateTime[3];
            cd[0] = new CDateTime(-10, -15, 30);
            cd[1] = new CDateTime(-12);
            cd[2] = new CDateTime(23, 59, 59);
            Console.WriteLine("----------");
            SDateTime[] sd = new SDateTime[3];
            sd[0] = new SDateTime(10, 300, 40);
            sd[1] = new SDateTime(-90, 30, 10);
            sd[2] = new SDateTime(23, 50, -20);
            #endregion

        }
    }
}