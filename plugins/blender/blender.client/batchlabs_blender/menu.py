import logging
import bpy

from batchlabs_blender.constants import Constants


class BatchLabsBlenderSubMenu(bpy.types.Menu):
    """
    Submit job sub menu. Calls off to the BatchLabs-data repo to get the submit job
    option types and displays them.
    """
    bl_idname = Constants.SUBMIT_MENU_ID
    bl_label = Constants.SUBMIT_MENU_LABEL

    def __init__(self):
        self.log = logging.getLogger(Constants.LOG_NAME)

    def draw(self, context):
        self.log.debug("Showing submit job menu")
        submit_actions = context.scene.batch_session.request_handler.menu_options()

        self.log.debug("submit_actions: " + str(len(submit_actions)))
        if len(submit_actions) > 0:
            for option in submit_actions:
                self.layout.operator(Constants.OP_ID_SUBMIT_JOB,
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

    def __init__(self):
        self.log = logging.getLogger(Constants.LOG_NAME)

    def draw(self, context):
        self.layout.menu(Constants.SUBMIT_MENU_ID)
        self.layout.operator(Constants.OP_ID_DOWNLOAD_RENDERS, text="Manage Data")
        self.layout.operator(Constants.OP_ID_MONITOR_JOBS, text="Monitor Jobs")
        self.layout.operator(Constants.OP_ID_MONITOR_POOLS, text="Monitor Pools")
        self.log.info("BatchLabs menu shown")
