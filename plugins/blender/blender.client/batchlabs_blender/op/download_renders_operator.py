import logging

import bpy

from batchlabs_blender.constants import Constants

class DownloadRendersOperator(bpy.types.Operator):
    bl_idname = Constants.OP_ID_DOWNLOAD_RENDERS
    bl_label = "DownloadRendersOperator"

    def __init__(self):
        self.log = logging.getLogger(Constants.LOG_NAME)

    def execute(self, context):
        self.log.debug("DownloadRendersOperator.execute")
        handler = context.scene.batch_session.request_handler
        handler.call_batch_labs("data")

        return {"FINISHED"}
