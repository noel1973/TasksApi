﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TasksAPI.Models
{
    public class Tasks
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Day { get; set; }
        public bool Reminder { get; set; }

    }
}