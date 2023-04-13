
import logger

from azext.batch import BatchExtensionsClient
from azure.batch import BatchServiceClient
from azure.common.credentials import ServicePrincipalCredentials
from azure.storage.blob import BlockBlobService

from models.auth_settings import AuthSettings


class AuthenticationProvider(object):
    """
    Self contained authentication provider class. Creates connections to 
    Azure Batch SDK client libraries.

    :ivar `str` PS_SERVICE_PRINCIPAL_CREDENTIALS_RESOUCE: 
        Default resource URI for the Azure Service Principal
    """
    PS_SERVICE_PRINCIPAL_CREDENTIALS_RESOUCE = "https://batch.core.windows.net/"

    def __init__(self, auth_settings: AuthSettings):
        """
        :param `models.auth_settings.AuthSettings` auth_settings:
            Authentication settings from the manifest file.
        """
        self.auth_settings = auth_settings

    def create_batch_client(self) -> BatchServiceClient:
        """
        Create a 'Batch client' using an Azure Service Principal
        """
        logger.info("creating a 'batch' client using a service principal")
        credentials = self._get_service_principal()
        return BatchServiceClient(credentials, base_url=self.auth_settings.batch_acc_url)

    def create_storage_client(self) -> BlockBlobService:
        """
        Create the 'Storage Blob' client for use in obtaining references to 
        blob storage containers and uploading files to containers.
        """
        # TODO: figure out if i can create this with a Service Principal as well
        logger.info("creating a 'storage' client using key auth")
        return BlockBlobService(
            account_name=self.auth_settings.storage_acc_name, 
            account_key=self.auth_settings.storage_acc_key)

    def create_batch_extensions_client(self) -> BatchExtensionsClient:
        """
        Create a 'Batch Extenstions' client using an Azure Service Principal.
        """
        logger.info("creating a 'batch extenstions' client using AAD")
        credentials = self._get_service_principal()

        return BatchExtensionsClient(
            credentials=credentials,
            batch_account=self.auth_settings.batch_acc_name,
            base_url=self.auth_settings.batch_acc_url,
            subscription_id=self.auth_settings.batch_acc_subscription)

    def _get_service_principal(self) -> ServicePrincipalCredentials:
        """
        Create an Azure Service Principal for connecting to the Batch and Batch Extensions SDKs
        """
        return ServicePrincipalCredentials(
            client_id=self.auth_settings.sp_client_id,
            secret=self.auth_settings.sp_client_secret,
            tenant=self.auth_settings.sp_client_tenant,
            resource=self.PS_SERVICE_PRINCIPAL_CREDENTIALS_RESOUCE)
