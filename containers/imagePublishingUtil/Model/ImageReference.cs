using System;
using System.Collections.Generic;
using System.Text;

namespace PublishContainerImages.Model
{
    class ImageReference
    {
        public string Id;

        // ReSharper disable once InconsistentNaming needs to match python naming convention
        public string node_sku_id;

        public string Publisher;

        public string Offer;

        public string Sku;

        public string Version;


        public static IEnumerable<ImageReference> GetAllImageReferences()
        {
            return new ImageReference[]
            {
                new ImageReference
                {
                    Id = "centos-75-container",
                    node_sku_id = "batch.node.centos 7",
                    Publisher = "microsoft-azure-batch",
                    Offer = "centos-container",
                    Sku = "7-5",
                    Version = "latest"
                },
                new ImageReference
                {
                    Id = "ubuntu-1604lts-container",
                    node_sku_id = "batch.node.ubuntu 16.04",
                    Publisher = "microsoft-azure-batch",
                    Offer = "ubuntu-server-container",
                    Sku = "16-04-lts",
                    Version = "latest"
                },
                new ImageReference
                {
                    Id = "windowsserver-2016-container",
                    node_sku_id = "batch.node.windows amd64",
                    Publisher = "MicrosoftWindowsServer",
                    Offer = "WindowsServer",
                    Sku = "2016-DataCenter-With-Containers",
                    Version = "latest"
                }
            };
        }
    }
}
