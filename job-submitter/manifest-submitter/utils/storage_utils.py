def build_container_sas_uri(storage_acc_url: str, container: str, sas: str) -> str:
    """
    Create a container SAS URL in the format of: {account-url}/{container}?{SAS}
    Note that this method is not responsible for the generation of the SAS token.
    
    :param storage_acc_url: Base URL to the storage account
    :param container: Name of the container in the storage account
    :param sas: Generated SAS token
    """
    return "{}/{}?{}".format(storage_acc_url, container, sas)
