using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
namespace StudentInformation.Models
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int marks1 { get; set; }
        public int marks2 { get; set; }
        public int marks3 { get; set; }
        public int marks4 { get; set; }
        public int marks5 { get; set; }
        public int marks6 { get; set; }
    }
}
