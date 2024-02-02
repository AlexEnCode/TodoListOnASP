using System.ComponentModel.DataAnnotations;

namespace TodoList.Models
{
    public class MyTask
    {
        public int Id { get; set; }

        [Display(Name = "Title")]
        public string? Title { get; set; }


        [Display(Name = "Description")]
        public string? Description { get; set; }

        [Display(Name = "State")]
        public State TaskState { get; set; } = 0;
    }
    public enum State
    {
        ToStart,
       OnGoing,
        Finished    
    }
}


