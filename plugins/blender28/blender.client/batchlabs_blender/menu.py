import logging
import bpy

from bpy.types import Operator, Menu
from . constants import Constants

class BatchLabsBlenderSubMenu(bpy.types.Menu):
    bl_label = Constants.SUBMIT_MENU_LABEL
    bl_idname = "OBJECT_MT_batch_labs_blender_sub_menu"

    def __init__(self):
        self.log = logging.getLogger(Constants.LOG_NAME)

    def draw(self, context):
        self.log.debug("Showing submit job menu")
        submit_actions = context.scene.batch_session.request_handler.menu_options()

        self.log.debug("submit_actions: " + str(len(submit_actions)))
        if len(submit_actions) > 0:
            for option in submit_actions:
                self.layout.operator("object.submit_job_operator",
                                     text=option.name).job_type = option.key
        else:
            self.log.warn("Submit job menu empty")
            self.log.warn("Check: " + Constants.DATA_REPO_APP_INDEX_URL)


class BatchLabsBlenderMenu(bpy.types.Menu):
    """
    BatchLabs menu options for Blender.
    Displays a menu item under the info > render menu.
    Azure Batch Rendering
        > Submit Job (BatchLabsBlenderSubMenu)
            > [Dynamic submit actions ...]
        > Download Renders
        > Monitor Pools
        > Monitor Jobs
    """
    bl_label = Constants.MAIN_MENU_LABEL
    bl_idname = "OBJECT_MT_batch_labs_blender_menu"
    
    def __init__(self):
        self.log = logging.getLogger(Constants.LOG_NAME)

    def draw(self, context):
        layout = self.layout
        layout.menu("OBJECT_MT_batch_labs_blender_sub_menu")
        self.layout.operator("object.download_renders_operator", text = 'Manage Data')
        self.layout.operator("object.monitor_pools_operator", text = 'Monitor Pools')
        self.layout.operator("object.monitor_jobs_operator", text = 'Monitor Jobs')