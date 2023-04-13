import json
import urllib.request
from urllib.error import HTTPError
import webbrowser

import bpy
from . constants import Constants

class SubmitMenuOption:
    def __init__(self, key, name):
        self.key = key
        self.name = name

class BatchLabsRequestHandler(object):
    """
    Handles calls to BatchLabs as well as requests to the NCJ data repo
    """
    _session_id = None
    _submit_actions = []
    _logger = None
    _preferences = None

    def __init__(self, session_id, logger, preferences):
        self._session_id = session_id
        self._logger = logger
        self._preferences = preferences

        self._load_menu_options()
        self._logger.info("Initialised BatchLabsRequestHandler with session_id: " + str(session_id))

    def menu_options(self):
        return self._submit_actions

    def call_batch_labs(self, action_str, argument_dict={}):
        batchlabs_url = str.format(
            "{}/{}?session={}",
            Constants.BATCH_LABS_BASE_URL,
            action_str,
            self._session_id)

        # initialize if not already
        if not argument_dict:
            argument_dict = {}

        print(self._preferences.account)
        
        # add accountId if we have one in user settings
        # if self._preferences.account:
        #   argument_dict[Constants.KEY_ACCOUNT_ID] =  self._preferences.account[1].get("default")

        # add any other parameters that were passed in via the argument_dict
        if argument_dict:
            for key, value in argument_dict.items():
                batchlabs_url = "{}&{}={}".format(batchlabs_url, key, value)

        self._logger.debug("Calling labs with URL: " + batchlabs_url)
        webbrowser.open(batchlabs_url, 1, True)

    def _load_menu_options(self):
        """
        Calls the BatchLabs-data repo to load the submit actions
        for this application.
        """
        self._logger.debug("Initializing submit menu items")
        del self._submit_actions[:]

        try:
            response = urllib.request.urlopen(Constants.DATA_REPO_APP_INDEX_URL)
        except HTTPError as error:
            self._logger.error("Failed to call the GitHub BatchLabs-data "
                               "repository: {}".format(str(error)))
            raise

        try:
            str_response = response.read().decode("utf-8")
        except Exception as error:
            self._logger.error("An error occurred while reading the response:"
                               " {}".format(str(error)))
            raise

        json_content = json.loads(str_response)
        for action in json_content:
            self._logger.debug("Found action: " + str(action))
            self._submit_actions.append(SubmitMenuOption(action["id"],
                                                         action["name"]))
