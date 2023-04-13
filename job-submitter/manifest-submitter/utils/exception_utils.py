
import logger

from azure.batch.models import BatchErrorException


def print_batch_exception(ex: BatchErrorException):
    """
    Prints and logs the contents of the specified Batch exception.
    
    :param `azure.batch.models.BatchErrorException` ex:
        The exception to convert into something readable
    """
    if ex.error and ex.error.message and ex.error.message.value:
        error = ex.error.message.value
        if ex.error.values:
            for mesg in ex.error.values:
                error += "\n{}:\t{}".format(mesg.key, mesg.value)

        logger.error(error)
