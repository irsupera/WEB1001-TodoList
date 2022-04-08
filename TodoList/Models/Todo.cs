using System;
using System.ComponentModel.DataAnnotations;

namespace TodoList.Models
{
    public class Todo
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public bool IsComplete { get; set; }

        [DataType(DataType.Date)]
        public DateTime AddDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime CompleteDate { get; set; }
    }
}
