using System.ComponentModel.DataAnnotations;

namespace DemoHtmlHelper.Models
{
    public class EmployeeModel
    {
        [Display(Name = "Please enter your Id")]
        public int Id { get; set; }
        [Display(Name="Please enter your name")]
        public string Name { get; set; }
        [Display(Name = "Please enter your email")]
        public string Email { get; set; }
        public bool IsOnline { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateofBirth { get; set; }
        [DataType(DataType.Time)]
        [Display(Name="Please enter your BirthTime")]
        public DateTime BirthTime { get; set; }

    }
}
