class Constants:    
    """
    Class for holding globally used constants.
    """
    SUBMIT_MENU_ID = "BATCH_LABS_submit_menu"
    SUBMIT_MENU_LABEL = "Submit Job"
    MAIN_MENU_LABEL = "Azure Batch Rendering"

    LOG_NAME = "blender-plugin"

    # External URL's
    DATA_REPO_APP_INDEX_URL = "https://raw.githubusercontent.com/Azure/BatchLabs" \
                              "-data/master/ncj/blender/index.json"
    BATCH_LABS_BASE_URL = "ms-batchlabs://route"

    # Operation keys
    OP_ID_DOWNLOAD_RENDERS = "download_renders"
    OP_ID_MONITOR_JOBS = "monitor_jobs"
    OP_ID_MONITOR_POOLS = "monitor_pools"
    OP_ID_SUBMIT_JOB = "submit_job"

    # Dictionary keys
    KEY_ACCOUNT_ID = "accountId"
    KEY_SCENE_FILE = "blendFile"
    KEY_USE_AUTO_POOL = "auto-pool"
    KEY_INPUT_PARAMETER = "input-parameter"
    KEY_ASSET_CONTAINER = "asset-container"
    KEY_ASSET_PATHS = "asset-paths"
    KEY_JOB_NAME = "jobName"

