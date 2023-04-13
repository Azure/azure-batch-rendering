
import datetime
import logging
import os 
import time 
import tempfile

"""
Module to set up logging so that it logs to the local temp directory.
"""

# set the temp file location for logging
temp_folder = tempfile.gettempdir()
log_folder = os.path.join(temp_folder, "batch-runner", datetime.datetime.now().strftime("%Y-%m-%d %H%M%S"))   

# create the log folder if it doesn't exist, which it won't as we stamp it with a date
if not os.path.exists(log_folder):
    os.makedirs(log_folder)

log_file_path = os.path.join(log_folder, "runner.log")
log_writer = logging.getLogger("runner")
log_writer.setLevel(logging.DEBUG)

# create file handler which logs even debug messages
fh = logging.FileHandler(log_file_path)
fh.setLevel(logging.DEBUG)

# create console handler with a higher log level
ch = logging.StreamHandler()
ch.setLevel(logging.WARN)

# create formatter and add it to the handlers
formatter = logging.Formatter("%(asctime)s - %(name)s - %(levelname)s - %(message)s", "%Y-%m-%d %H:%M:%S")
ch.setFormatter(formatter)
fh.setFormatter(formatter)

# add the handlers to logger
log_writer.addHandler(ch)
log_writer.addHandler(fh)


def console(message: str):
    print(message)
    info(message)


def info(message: str):
    if log_writer.isEnabledFor(logging.INFO):
        log_writer.info(message)


def debug(message: str):
    if log_writer.isEnabledFor(logging.DEBUG):
        log_writer.debug(message)


def warn(message: str):
    if log_writer.isEnabledFor(logging.WARN):
        log_writer.warn(message)


def error(message: str):
    if log_writer.isEnabledFor(logging.ERROR):
        log_writer.error(message)


def critical(message: str):
    if log_writer.isEnabledFor(logging.CRITICAL):
        log_writer.critical(message)


def pass_test(message: str):
    info("PASS PRECONDITION: {}".format(message))


def fail_test(message: str):
    warn("FAIL PRECONDITION: {}".format(message))


def alert(message: str):
    warn("ALERT: {}".format(message))
