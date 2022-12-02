using System;


namespace kosti

{

    public class Class1

    {
        public int p;
        public int pr
        {
            get { return p; }
            set { p = value; }
        }
        public int t;

        public int tr
        {
            get { return t; }
            set { t = value; }
        }
        public int randomNumbers()
        {
            Random r = new Random();
            int sum = r.Next(1, 7);
            return sum;
        }
        public int increasePoints(int l)
        {
            l += randomNumbers();
            return l;
        }
        public int numberThrows()
        {
            t++;
            return t;
        }
    }
}
