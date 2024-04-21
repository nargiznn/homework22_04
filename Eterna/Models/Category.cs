using System;
namespace Eterna.Models
{
	public class Category
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Project> projects { get; set; }
    }
}

