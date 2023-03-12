Recipe Book step by step

!!!if you are getting res squiggly lines in the class name or around that area make sure to check and see if it needs a namespace. Righ click on the code in error/quick options and refactoring. click on using if applicable!!!

1. Select ASP.NET  Core WEb App (Model-View-Controller) MVC
2. Set up NuGet Packages. Choose and install:
   a.  Microsoft.EntityFrameworkCore
   b. Microsoft.EntityFrameworkCore.Tools
   c. Microsoft.EntityFrameworkCoree.SQLServer
3. Start Adding Classes in the Model Folder. Create:
   a. RecipeModel.cs
   b. AuthorModel.cs
   c. IngredientModel.cs
   Additional classes will be
   d. RecipeINgredient.cs
4. Start setting up properties in each model. Make sure to assign right linked models.
5. Start setting up controllers. Right click on controller folder/add/controller. 
   If doing MVC choose MVC Controller - Empty
   name these after each model.(Example AuthorController.cs)
6. Now start setting up views for our index
   1. Inside the controller page look at code  - public IActionResult Index()
   2. Right click on Index/Add View/Razor View - Empty
   3. This time we named it Index.cshtml
   So far you shold have added index to Recepe Controller. 
   4. You can add header to your index so we have something to look at  example <h2>Recipe Index</h2>\
7. Now we can start setting up database. Lets create RecipeBookContext
   1. right click on the project name (RecipeBookExample)/add/class
   2. Name it RecipeBookContext.cs
8. In RecipeBookContext.cs do the following:
   1. add semicolon after RecipeBookContext class like this    "RecipeBookContext: DbContext" so basically assign DbContext class as parent class?I think, (Need to chack on this.)
   2. Lets add Db Properties like this:
        public DbSet<RecipeModel> Recipes { get; set; }
        public DbSet<AuthorModel> Authors { get; set; }
        public DbSet<IngredientModel> Ingredients { get; set;}
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }
   We are making lists here so the names should be plural. 
   3. No we can set up connection to the database. 
   4. you should be able to bring this up by typing "override"
      --protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)--
      copy code and link from another project. Link should connect to Local Database and should look alike this.
      --"Server=(localdb)\\mssqllocaldb;Database=MRecipeBook;Trusted_Connection=True;"--
9. Lets reference this context in the Programs.cs
   1. under var builder (Should be 3rd or 4th line) type:
   2. builder.Services.AddDbContext<RecipeBookContext>();  this is the file with connection and seed data
10. Start making a repository
   1. create a folder for repository first by right clicking on project name/add/new folder. name it Repositories
   2. now add new interface by right clicking on Repositories folder/new item/interface/ and name first one "Interface"
   3. Inside the interface.cs page rename Interface to IRepository and give it value T or TEntity. 
   It should look like this. "public interface IRepository<T>
   Rest of the code on this page should just be 
           T GetByID(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
11. Now lets create interface for each of the models
   1. Under repository folder right click/new class/ and name class after each model   Example RecipeRepository.cs
   2. Inside this new class add parent class extension after semicolon(:) It should be Irepository that references RecipeModel. 
   What this means is that we are inheriting original interface and we are assigning it to RecipeModel(I think) It should look like this
   "RecipeRepository : IRepository<RecipeModel>"
   3. Now right click on "IRepository" and select "Quick Actions and Refactoring" then click on "Implement Interface"
   4. Do the same for Author Repository and INgredient Repository. They all should have methods. 
12. Lets now add constructor to Recipe Repository
