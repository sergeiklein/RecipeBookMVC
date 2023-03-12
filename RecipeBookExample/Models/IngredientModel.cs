namespace RecipeBookExample.Models
{
    public class IngredientModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<RecipeIngredient> RecipeIngredients { get; set; }
    }
}
