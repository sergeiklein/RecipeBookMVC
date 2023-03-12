namespace RecipeBookExample.Models
{
    public class RecipeModel
    {
        public int Id { get; set; }  
        public string Name { get; set; }    
        public int CookTime { get; set; }
        public string Description { get; set; }
        public int AuthorId { get; set; }//linking author to this recipe

        public virtual AuthorModel Author { get; set; }
        public virtual List<RecipeIngredient> RecipeIngredients { get; set; }// <<<???>>>Review
    }
}
