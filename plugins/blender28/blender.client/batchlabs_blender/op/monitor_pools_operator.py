import logging

import bpy
from ..constants import Constants
from ..shared import BatchSettings

class MonitorPoolsOperator(bpy.types.Operator):
    """Open Batch Explorer to monitor your pools"""
    bl_idname = "object.monitor_pools_operator"
    bl_label = "Invokes a Script"
    _preferences = None

    @classmethod
    def poll(cls, context):
        return context.active_object is not None

    def __init__(self):
        self.log = logging.getLogger(Constants.LOG_NAME) 
        self._preferences = BatchSettings.get_user_preferences().preferences


    def execute(self, context):
        self.log.debug("MonitorPoolsOperator.execute")
        handler = context.scene.batch_session.request_handler        
        arguments = {
            Constants.KEY_ACCOUNT_ID: self._preferences.account,
        }  
        handler.call_batch_labs("pools", arguments)
        return {"FINISHED"}
