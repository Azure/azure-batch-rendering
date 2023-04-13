import logging
import os
import uuid

import bpy

from batchlabs_blender.batchlabs_request_handler import BatchLabsRequestHandler
from batchlabs_blender.constants import Constants


class BatchSettings(object):
    """
    Initializes and manages the BatchLabs plugin session.
    Registers all classes and handles all sub-pages. Configures logging and
    User Preferences.
    """

    def __init__(self):
        self.session_id = uuid.uuid4()
        self.props = self._register_props()
        self.log = self._configure_logging()
        self.request_handler = BatchLabsRequestHandler(self.session_id,
                                                       self.log,
                                                       self.props)
        self.log.info("Initialised BatchSettings")

    @staticmethod
    def get_user_preferences():
        return bpy.context.user_preferences.addons[__package__].preferences
    
    @staticmethod
    def _register_props():
        """
        Retrieves the shared addon properties - in this case the User
        Preferences.

        :Returns:
            - :class:`.UserPreferences`
        """
        props = BatchSettings.get_user_preferences()
        if not os.path.isdir(props.log_dir):
            try:
                os.mkdir(props.log_dir)
            except:
                raise EnvironmentError(
                    "Data directory not created at '{0}'.\n"
                    "Please ensure you have adequate permissions.".format(
                        props.log_dir))

        return props

    def _configure_logging(self):
        """
        Configures the logger for the addon based on the User Preferences.
        Sets up a stream handler to log to Blenders console and a file
        handler to log to the Batch log file.
        """
        logger = logging.getLogger(Constants.LOG_NAME)
        logger.setLevel(int(self.props.log_level))
        console_format = logging.Formatter("Batch: [%(levelname)s] %(message)s")
        file_format = logging.Formatter(
            "%(asctime)-15s [%(levelname)s] %(module)s: %(message)s")

        console_logging = logging.StreamHandler()
        console_logging.setFormatter(console_format)
        logger.addHandler(console_logging)

        logfile = os.path.join(self.props.log_dir, "batched_blender.log")
        file_logging = logging.FileHandler(logfile)
        file_logging.setFormatter(file_format)
        logger.addHandler(file_logging)

        return logger
