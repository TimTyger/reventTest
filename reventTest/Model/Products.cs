using System.ComponentModel.DataAnnotations;

namespace reventTest.Model
{
    public interface IProducts
    {
        string Name { get; set; }
        string Id { get; set; }
    }

    public class Products : IProducts
    {
       [Required] public string Name { get; set; }
        [Required] public string Id { get; set; }
    }
}