using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

namespace EntityLayer.Concrete;

public class Service
{
    [Key]
    public int ServiceID { get; set; }
    public string Title { get; set; }
    public string ImageUrl { get; set; }
}