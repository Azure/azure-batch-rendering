import logging
import os
import re
import bpy
from ..constants import Constants
from ..shared import BatchSettings

class SubmitJobOperator(bpy.types.Operator):
    bl_idname = "object.submit_job_operator"
    bl_label = "SubmitJobOperator"
    job_type = bpy.props.StringProperty()
    
    _log = None
    _preferences = None

    _prefix = "blender-"
    _maxFileGroupLength = 55
    _maxUsableLength = _maxFileGroupLength - len(_prefix)

    def __init__(self):
        self._log = logging.getLogger(Constants.LOG_NAME)
        self._preferences = BatchSettings.get_user_preferences().preferences

    def execute(self, context):
        # todo: check for and throw error if no job_type set
        self._log.debug("SubmitJobOperator.execute: " + self.job_type)

        handler = context.scene.batch_session.request_handler
        launch_url = str.format("market/blender/actions/{}/{}", self.job_type, "submit")
        arguments = {
            Constants.KEY_USE_AUTO_POOL: self._preferences.pool_type,
            Constants.KEY_INPUT_PARAMETER: "inputData"
        }

        if bpy.data.filepath:
            sceneName = self._containerizeBlendFile(bpy.data.filepath)
            arguments[Constants.KEY_SCENE_FILE] = os.path.basename(bpy.data.filepath)
            arguments[Constants.KEY_ASSET_CONTAINER] = sceneName
            arguments[Constants.KEY_ASSET_PATHS] = os.path.dirname(bpy.data.filepath)
            arguments[Constants.KEY_JOB_NAME] = sceneName

        self._log.debug("SubmitJobOperator - passing args: " + str(arguments))
        handler.call_batch_labs(launch_url, arguments)

        return {"FINISHED"}

    def _containerizeBlendFile(self, blendFile):
        """
        Given the main data file path, turn it into a valid storage container name
        for us to use as a file group name.
        """
        if not blendFile:
            return ""

        sansPath = os.path.basename(blendFile)
        # get the filename only and lower case it
        sansExtension = os.path.splitext(sansPath)[0].lower()
        
        # replace underscores and multiple dashes
        sansExtension = re.sub(r'[_-]{1,}', "-", sansExtension)

        # check that the filename is not too long, if it is then trim it
        if len(sansExtension) > self._maxUsableLength:
            self._log.info("SubmitJobOperator: file name length is longer than: " + str(self._maxUsableLength) + ", trimming")
            sansExtension = sansExtension[0:self._maxUsableLength]

        # replace any start and end hyphens
        sansExtension = re.sub(r'^[-]|[-]+$', "", sansExtension)
        self._log.info("SubmitJobOperator: after sanitizing filename: " + sansExtension)
        self._log.info("SubmitJobOperator: returning: " + self._prefix + sansExtension)

        return self._prefix + sansExtension
      