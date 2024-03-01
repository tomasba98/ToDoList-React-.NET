﻿using TodoList.Entities;
using TodoList.Models;

namespace TodoList.Services.TaskList
{
    public interface ITaskService
    {
        TaskEntity CreateTask(TaskEntity taskEntity);

        TaskEntity? GetTaskById(int taskId);

        Task<bool> UpdateTask(TaskEntity taskEntity);

        Task<bool> DeleteTask(TaskEntity taskEntity);

        IEnumerable<TaskEntity> GetAllTasks();

    }
}
