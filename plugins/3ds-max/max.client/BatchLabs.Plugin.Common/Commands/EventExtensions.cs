
using System;

namespace BatchLabs.Plugin.Common.Commands
{
    public static class EventExtensions
    {
        /// <summary>
        /// Safely raises an event.
        /// </summary>
        public static void Raise(this EventHandler @event, object sender, EventArgs e)
        {
            @event?.Invoke(sender, e);
        }

        public static void Raise<T>(this EventHandler<T> @event, object sender, T e)
            where T : EventArgs
        {
            @event?.Invoke(sender, e);
        }
    }
}
