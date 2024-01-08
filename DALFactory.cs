namespace IOC.Console
{
    public class DALFactory
    {
        public static IDAL GetDal()
        {
            return new DAL();
        }
    }
}
