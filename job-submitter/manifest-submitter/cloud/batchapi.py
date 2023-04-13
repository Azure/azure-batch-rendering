
import logger

from azure.batch import BatchServiceClient
from azure.batch.models import BatchErrorException
from azure.batch.models import JobGetOptions
from azure.storage.blob import BlockBlobService


def does_job_exist(batch_client: BatchServiceClient, job_id: str) -> bool:
    """
    Returns true or false depending on if a job already exsits with the 
    supplied identifier.
    
    :param `azure.batch.BatchServiceClient` batch_client:
        A client for issuing REST requests to the Azure Batch service.
    :param `str` job_id:
        Unique identifier of the job to look for.
    """
    try:
        options = JobGetOptions(select="id")
        batch_client.job.get(job_id, job_get_options=options)
        return True
    except BatchErrorException as ex:
        if ex.response.status_code == 404:
            return False
        else:
            logger.error("error getting job: {}".format(str(ex)))
            raise


def scene_file_exists(storage_client: BlockBlobService, container_name: str, scene_file: str) -> bool:
    """
    Returns true or false depending on if a scene file exists in the
    supplied container. False could mean that either the container or 
    the file doesn't exist.

    :param `azure.storage.blob.BlockBlobService` storage_client:
            A client for issuing REST requests to the Azure blob storage service.
    :param `str` container_name:
        Name of the container in the storage account.
    :param `str` scene_file:
        Relative path to the blob in the container that acts as the scene 
        file for the job.
    """
    try:
        return storage_client.exists(container_name, scene_file)
    except Exception as ex:
        logger.error("error checking for scene file: {} in container: {}. With error: {}".format(scene_file, container_name, str(ex)))
        raise
