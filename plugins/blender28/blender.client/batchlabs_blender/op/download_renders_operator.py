import logging

import bpy
from ..constants import Constants
from ..shared import BatchSettings

class DownloadRendersOperator(bpy.types.Operator):
    """Open Batch Explorer to monitor your files"""
    bl_idname = "object.download_renders_operator"
    bl_label = "DownloadRendersOperator"
    _preferences = None


    def __init__(self):
        self.log = logging.getLogger(Constants.LOG_NAME)
        self._preferences = BatchSettings.get_user_preferences().preferences


    def execute(self, context):
        self.log.debug("DownloadRendersOperator.execute")
        handler = context.scene.batch_session.request_handler
        handler.call_batch_labs("data")
        arguments = {
            Constants.KEY_ACCOUNT_ID: self._preferences.account,
        }  
        handler.call_batch_labs("pools", arguments)
        return {"FINISHED"}
