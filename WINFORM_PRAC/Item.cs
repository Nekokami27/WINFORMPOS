namespace WINFORM_PRAC
{
    public class Item
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        //Not mentioned yet!
        //public int Sale_num { get; set; }
        public bool IsDeleted { get; set; }
        public override string ToString()
        {
            return Name;
        }



    }
}
