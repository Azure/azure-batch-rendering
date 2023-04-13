
class AuthSettings(object):
    """
    Self contained authentication settings class. Holds all of the keys and tokens 
    needed to create the various authentication tokens
    """
    def __init__(self,
                 batch_acc_name: str,
                 batch_acc_url: str,
                 batch_acc_subscription: str,
                 storage_acc_name: str,
                 storage_acc_url: str,
                 storage_acc_key: str,
                 sp_client_id: str,
                 sp_client_secret: str,
                 sp_client_tenant: str):
        """
        :param batch_acc_name: Name of the Batch account.
        :param batch_acc_url: Base URL of the Batch account including the
        region.
        :param batch_acc_subscription: Subscription ID of the Batch account.
        :param storage_acc_name: Storage account name.
        :param storage_acc_url: Base URL of the storage account.
        :param storage_acc_key: Shared access key for the storage account.
        :param sp_client_id: Application/Client ID of the Azure service
        principal.
        :param sp_client_secret: Shared secret of the Azure service principal.
        :param sp_client_tenant: AAD tenant of the service principal.
        """
        self.batch_acc_name = batch_acc_name
        self.batch_acc_url = batch_acc_url
        self.batch_acc_subscription = batch_acc_subscription
        self.storage_acc_name = storage_acc_name
        self.storage_acc_url = storage_acc_url
        self.storage_acc_key = storage_acc_key
        self.sp_client_id = sp_client_id
        self.sp_client_secret = sp_client_secret
        self.sp_client_tenant = sp_client_tenant
