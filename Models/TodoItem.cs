using System.ComponentModel.DataAnnotations;
namespace TodoList.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }
        public Boolean Completed { get; set; }

        public DateTime CompletedDate { get; set; }

        public TodoItem()
        {
            CreatedDate = DateTime.Now;
        }

    }
}
