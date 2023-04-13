import importlib
import os

import bpy

bl_info = {
    "name": "BatchLabs Blender Plugin",
    "author": "Microsoft Corporation <bigcompute@microsoft.com>",
    "version": (0, 1, 0),
    "blender": (2, 7, 9),
    "location": "Render Menu",
    "description": "Render your Blender scene externally with Azure Batch and BatchLabs.",
    "category": "Render"
}

_APP_DIR = os.path.dirname(__file__)

from batchlabs_blender.preferences import UserPreferences
from batchlabs_blender.shared import BatchSettings

from batchlabs_blender.menu import BatchLabsBlenderSubMenu
from batchlabs_blender.menu import BatchLabsBlenderMenu

from batchlabs_blender.op.download_renders_operator import DownloadRendersOperator
from batchlabs_blender.op.monitor_jobs_operator import MonitorJobsOperator
from batchlabs_blender.op.monitor_pools_operator import MonitorPoolsOperator
from batchlabs_blender.op.submit_job_operator import SubmitJobOperator

@bpy.app.handlers.persistent
def start_session(self):
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

    finally:
        bpy.app.handlers.scene_update_post.remove(start_session)


def menu_func(self, context):
    """
    Add the BatchLabs menu options to the 'Render' menu in the main toolbar
    """
    self.layout.separator()
    self.layout.menu("BatchLabsBlenderMenu")


def register():
    """
    Register module and applicable classes.
    Here we also register the User Preferences for the Addon, so it can
    be configured in the Blender User Preferences window.
    """
    bpy.app.handlers.scene_update_post.append(start_session)
    bpy.utils.register_class(UserPreferences)
    bpy.utils.register_class(DownloadRendersOperator)
    bpy.utils.register_class(MonitorPoolsOperator)
    bpy.utils.register_class(MonitorJobsOperator)
    bpy.utils.register_class(SubmitJobOperator)
    bpy.utils.register_class(BatchLabsBlenderSubMenu)
    bpy.utils.register_class(BatchLabsBlenderMenu)
    bpy.types.INFO_MT_render.append(menu_func)


def unregister():
    """
    Unregister the addon if deselected from the User Preferences window.
    """
    bpy.utils.unregister_class(UserPreferences)
    bpy.utils.unregister_class(DownloadRendersOperator)
    bpy.utils.unregister_class(MonitorPoolsOperator)
    bpy.utils.unregister_class(MonitorJobsOperator)
    bpy.utils.unregister_class(SubmitJobOperator)
    bpy.utils.unregister_class(BatchLabsBlenderSubMenu)
    bpy.utils.unregister_class(BatchLabsBlenderMenu)
    bpy.types.INFO_MT_render.remove(menu_func)

if __name__ == "__main__":
    register()
