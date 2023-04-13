
using Autodesk.Max;
using BatchLabs.Plugin.Common.Actions;

namespace BatchLabs.Max2019.Plugin.Actions
{
    public class ActionWrapper
    {
        public ActionWrapper(IActionItem action)
        {
            Action = action;
            Order = GetActionOrder(action);
        }

        public IActionItem Action { get; set; }

        public int Order { get; }

        private int GetActionOrder(IActionItem action)
        {
            switch (action.DescriptionText)
            {
                case ActionStrings.MonitorJobsActionText:
                    return 1;

                case ActionStrings.MonitorPoolsActionText:
                    return 2;

                case ActionStrings.ManageDataActionText:
                    return 3;

                case ActionStrings.SubmitJobActionText:
                    return 4;

                default:
                    return -1;
            }
        }
    }
}
