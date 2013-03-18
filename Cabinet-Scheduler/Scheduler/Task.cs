﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Scheduler
{
    public class Task
    {
        public TaskInfo info;
        public TaskState state;
        public DateTime addingErrorTimeout = DateTime.MinValue;
        public DateTime deletingErrorTimeout = DateTime.MinValue;

        public Task(string id)
        {
            info = TaskInfo.Unserialize(Path.Combine("tasks", id + ".info.data"));
            state = TaskState.Unserialize(Path.Combine("tasks", id + ".state.data"));
        }

        public void Save()
        {
            state.Serialize(Path.Combine("tasks", info.id + ".state.data"));
        }
    }
}
