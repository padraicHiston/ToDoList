using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }

        // The User property below will allow us to link a user to the item when it is created
        // so that only items created by the user can be seen by that user.
        public virtual ApplicationUser User { get; set; }
    }
}