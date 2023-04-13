import logging

import bpy

from batchlabs_blender.constants import Constants

class MonitorPoolsOperator(bpy.types.Operator):
    bl_idname = Constants.OP_ID_MONITOR_POOLS
    bl_label = "MonitorPoolsOperator"

    def __init__(self):
        self.log = logging.getLogger(Constants.LOG_NAME)

    def execute(self, context):
        self.log.debug("MonitorPoolsOperator.execute")
        handler = context.scene.batch_session.request_handler
        handler.call_batch_labs("pools")

        return {"FINISHED"}
