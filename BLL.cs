namespace IOC.Console
{
    public class BLL
    {
        private IDAL _dal { get; set; }
        public BLL(IDAL dal)
        {
            _dal = dal;
        }
        public List<Product> GetProducts()
        {
            return _dal.GetProducts();
        }
    }
}
 