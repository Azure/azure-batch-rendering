
using BatchLabs.Max2016.Plugin.Common;
using BatchLabs.Max2016.Plugin.Max;

using BatchLabs.Plugin.Common.Actions;
using BatchLabs.Plugin.Common.Code;
using BatchLabs.Plugin.Common.Resources;

namespace BatchLabs.Max2016.Plugin.Actions
{
    public class MonitorJobsAction : ActionBase
    {
        public override void InternalExecute()
        {
            MaxGlobalInterface.Instance.COREInterface16.PushPrompt(Strings.MonitorJobs_Log);
            Log.Instance.Debug(Strings.MonitorJobs_Log);

            LabsRequestHandler.CallBatchLabs(Constants.BatchLabsUrs.Jobs);
        }

        public override string InternalActionText => ActionStrings.MonitorJobsActionText;
    }
}
