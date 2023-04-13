
using BatchLabs.Max2019.Plugin.Common;
using BatchLabs.Max2019.Plugin.Max;
using BatchLabs.Plugin.Common.Actions;
using BatchLabs.Plugin.Common.Code;
using BatchLabs.Plugin.Common.Resources;

namespace BatchLabs.Max2019.Plugin.Actions
{
    public class ManageDataAction : ActionBase
    {
        public override void InternalExecute()
        {            
            MaxGlobalInterface.Instance.COREInterface16.PushPrompt(Strings.ManageData_Log);
            Log.Instance.Debug(Strings.ManageData_Log);

            LabsRequestHandler.CallBatchLabs(Constants.BatchLabsUrs.Data);
        }

        public override string InternalActionText => ActionStrings.ManageDataActionText;
    }
}
