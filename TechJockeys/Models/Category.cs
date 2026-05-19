using Microsoft.IdentityModel.Tokens;

namespace TechJockeys.Models
{
    public class Category
    {
        // using (ModelName)Id as the property tells the server automatically that this is the primary key for the table
        public int CategoryId { get; set; }

        public string Name { get; set; }
    }
}
