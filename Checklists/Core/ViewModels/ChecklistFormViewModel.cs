﻿using System.ComponentModel.DataAnnotations;
using Checklists.Core.Models;

namespace Checklists.Core.ViewModels
{
    public class ChecklistFormViewModel
    {
        public ChecklistFormViewModel()
        {
            Id = 0;
        }

        public ChecklistFormViewModel(Checklist checklist)
        {
            Id = checklist.Id;
            Name = checklist.Name;
        }

        public string Title
        {
            get { return Id == 0 ? "New checklist" : "Modify checklist name"; }
        }

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}