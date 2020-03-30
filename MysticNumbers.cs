namespace WTF
{
    public class MysticNumbers
    {
        #region Methods
        public static int ThreeNumbers(int a, int b, int c)
        {
            int result;
            result = DoubleNumbers(a,b);
            return result = DoubleNumbers(result, c);
        } 
        public static int FourNumbers(int a, int b, int c, int d)
        {
            int result;
            result = ThreeNumbers(a,b,c);
            return result = DoubleNumbers(result, d);
        } 
        public static int DoubleNumbers(int a, int b)
        {
                    int result;

            if (b > a)
            {
                result = b;
            }
            else
            {
                result = a;
            }

            return result;

        }
    }
        #endregion
    
}