import importlib
import os
import bpy

bl_info = {
    "name" : "Batch-Blender-plugin",
    "author": "Microsoft Corporation <bigcompute@microsoft.com>",
    "version": (0, 1, 0),
    "blender": (2, 80, 0),
    "location": "Render Menu",
    "description": "Render your Blender scene externally with Azure Batch and BatchLabs.",
    "category": "Render"
}

_APP_DIR = os.path.dirname(__file__)


from . menu import BatchLabsBlenderMenu, BatchLabsBlenderSubMenu
from . shared import BatchSettings
from . batchlabs_request_handler import BatchLabsRequestHandler
from . preferences import UserPreferences
from . op.monitor_pools_operator import MonitorPoolsOperator
from . op.monitor_jobs_operator import MonitorJobsOperator
from . op.download_renders_operator import DownloadRendersOperator
from . op.submit_job_operator import SubmitJobOperator
from . constants import Constants


@bpy.app.handlers.persistent
def start_session():
    """
    Initializes the Batch session and registers all the property
    classes to the Blender context.
    This is handled in an event to allow it to run under the full
    Blender context rather than the limited loading scope.

    Once the session has started (or reported an error), this function
    is removed from the event handlers.
    """
    try:
        session = BatchSettings()

        def get_session(self):
            return session

        bpy.types.Scene.batch_session = property(get_session)

    except Exception as error:
        print("BatchLabs plugin failed to load.")
        print("Error: {0}".format(error))
        bpy.types.Scene.batch_error = error

def menu_draw(self, context):
    self.layout.menu(BatchLabsBlenderMenu.bl_idname)


start_session()

bpy.types.TOPBAR_MT_render.append(menu_draw)


classes = (
    BatchLabsBlenderMenu,
    BatchLabsBlenderSubMenu,    
    UserPreferences,
    MonitorPoolsOperator,
    MonitorJobsOperator,
    DownloadRendersOperator, 
    SubmitJobOperator,
    
)

register, unregister = bpy.utils.register_classes_factory(classes)