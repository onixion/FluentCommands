﻿using System;

namespace AlinSpace.FluentCommands
{
    /// <summary>
    /// Fluent command manager interface.
    /// </summary>
    public interface IFluentCommandManager
    {
        /// <summary>
        /// Add execution group.
        /// </summary>
        /// <param name="exectionGroupCallback">Execution group callback.</param>
        /// <param name="lock">Lock.</param>
        /// <returns>Command manager.</returns>
        IFluentCommandManager AddGroup(Action<ICommandGroup> exectionGroupCallback, GroupLockBehavior @lock = GroupLockBehavior.LockAllGroups);
    }
}
