import datetime

from azure.storage.blob import BlockBlobService
from azure.storage.blob.models import ContainerPermissions


class ParameterMapper:
    def map_parameters(
            self,
            storage_acc_url: str,
            storage_client: BlockBlobService,
            parameter_json: object,
            job_id: str,
            container_name: str,
            scene_file: str,
            priority: int,
            start_frame: int,
            end_frame: int,
            pool_name: str,
            addtional_args: str = None,
            output_container: str = None
    ) -> object:
        """
        Given the job parameter json payload and the data to populate it, set 
        the values in the parameter json for applying to the job template.

        :param storage_acc_url: Base URL of the storage account.
        :param storage_client: Storage connection client.
        :param parameter_json: JSON paramter object as defined in the
        job.template.json file.
        :param job_id: Identifier of the job.
        :param container_name: Name of the container in which the job assets
        are stored.
        :param scene_file: Name of the main scene file to pass to 3ds Max.
        :param priority: Priority of the job. Jobs will be run in approximate order based on
            the priority. Priority values can range from -1000 to 1000, with -1000 being 
            the lowest priority and 1000 being the highest priority.
        :param start_frame: First frame to render
        :param end_frame: Last frame to render
        :param pool_name: Name of the pool to run the job on. The pool must
        exist.
        :param addtional_args: Any additional arguments to pass to the renderer
        :param output_container: Name of the output container. Defaults to
        "outputs" should it not be supplied.

        :return object:
            JSON object based on the job.template.json file with all of the appropriate 
            values mapped with the values from the manifest file. Once mapped, it should be able 
            to be applied to the job.template.json file and sent to the Batch Extensions client
            for submission to the Batch API.
        """

        # we need the input file group to not have the fgrp prefix
        if container_name.startswith("fgrp-"):
            container_name_without_prefix = container_name.replace("fgrp-", "", 1)
        else:
            container_name_without_prefix = container_name

        # get the container read SAS for accessing render assets in the continer
        container_sas = self._get_container_sas(container_name, storage_client,
                                                storage_acc_url)
        print("got container_sas: ", container_sas)

        parameter_json["jobName"]["value"] = job_id
        parameter_json["poolId"]["value"] = pool_name
        parameter_json["inputFilegroup"]["value"] = container_name_without_prefix
        parameter_json["inputFilegroupSas"]["value"] = container_sas
        parameter_json["sceneFile"]["value"] = scene_file
        parameter_json["additionalArgs"]["value"] = addtional_args or " "
        parameter_json["jobPriority"]["value"] = priority
        parameter_json["frameStart"]["value"] = start_frame
        parameter_json["frameEnd"]["value"] = end_frame
        parameter_json["outputs"]["value"] = output_container or "outputs"

        return parameter_json

    @staticmethod
    def _get_container_sas(
            container: str,
            storage_client: BlockBlobService,
            storage_acc_url: str
    ) -> str:
        """
        Obtains a shared access signature granting the specified permissions to the
        container. We set no start time, so the shared access signature becomes valid 
        immediately.

        :param container: The name of the Azure Blob storage container.
        :param storage_client: Storage connection client.
        :param storage_acc_url: Base URL of the storage account.

        :return: SAS token granting the specified permissions to access the container in
            the format {base-storage-url}/{container}?{SAS}.
        """
        permissions = ContainerPermissions.READ + ContainerPermissions.LIST
        sas = storage_client.generate_container_shared_access_signature(
            container,
            permission=permissions,
            expiry=datetime.datetime.utcnow() + datetime.timedelta(days=7))

        # take the sas and add it to the storage acc url and container
        return "{}/{}?{}".format(storage_acc_url, container, sas)
