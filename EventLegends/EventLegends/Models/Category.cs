using EventLegends.Models.Base;

namespace EventLegends.Models
{
    public class Category :  BaseEntity
    {
        public string CategoryType { get; set; }


        //Relatie Many-to-Many cu Event
        public ICollection<EventCategories > EventCategories { get; set; } 

        /*
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
        */
    }
}
