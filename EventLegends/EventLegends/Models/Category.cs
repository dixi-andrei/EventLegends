namespace EventLegends.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryType { get; set; }


        //Relatie One-to-Many
        public List<EventCategories > EventCategories { get; set; } 


        public Category() {
            EventCategories = new List<EventCategories>();
        }

        public Category(int CategoryId,string CategoryType) : this() { 
            this.CategoryType = CategoryType;
            this.CategoryId = CategoryId;
        }

        public void AddCategory(EventCategories category)
        {
            this.EventCategories.Add(category);
        }
    }
}
