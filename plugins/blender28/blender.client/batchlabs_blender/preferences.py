import os
import bpy

class UserPreferences(bpy.types.AddonPreferences):
    """BatchLabs Blender plugin user preferences."""
    bl_idname = __package__.split('.')[0]

    log_dir = bpy.props.StringProperty(
        name="Log directory",
        description="Location of log file",
        subtype='DIR_PATH',
        default=os.path.expanduser('~'))

    log_level = bpy.props.EnumProperty(items=(('10', 'Debug', ''),
                                              ('20', 'Info', ''),
                                              ('30', 'Warning', ''),
                                              ('40', 'Error', ''),
                                              ('50', 'Critical', '')),
                                       name="Logging level",
                                       description="Level of logging detail",
                                       default="20")
    account = bpy.props.StringProperty(
        name="Batch Account",
        description="Fully qualified Batch account identifier."
                    " (/subscriptions/<sub-id>/resourceGroups/<resource-group>/"
                    "providers/Microsoft.Batch/batchAccounts/<account>)",
        default="")

    pool_type = bpy.props.EnumProperty(items=(('0', 'Pre-existing pool', ''),
                                              ('1', 'Auto-pool', '')),
                                       name="Pool Type",
                                       description="Type of pool to use when submitting a job",
                                       default="0")

    def draw(self, context):
        """
        Draw the display for the settings in the User Preferences
        with next to the Addon entry.

        :Args:
            - context (bpy.types.Context): Blenders current runtime
              context.

        """
        layout = self.layout
        layout.label(text="Blender will need to be restarted for changes to "
                          "take effect.")

        layout.label(text="")
        layout.label(text="Log Settings")
        layout.prop(self, "log_dir")
        layout.prop(self, "log_level")

        layout.label(text="")
        layout.label(text="Account Settings")
        layout.prop(self, "account")
        layout.prop(self, "pool_type")
