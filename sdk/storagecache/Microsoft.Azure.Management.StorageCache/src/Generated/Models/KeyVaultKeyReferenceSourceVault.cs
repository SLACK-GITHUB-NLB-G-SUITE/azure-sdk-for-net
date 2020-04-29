// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageCache.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes a resource Id to source Key Vault.
    /// </summary>
    public partial class KeyVaultKeyReferenceSourceVault
    {
        /// <summary>
        /// Initializes a new instance of the KeyVaultKeyReferenceSourceVault
        /// class.
        /// </summary>
        public KeyVaultKeyReferenceSourceVault()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KeyVaultKeyReferenceSourceVault
        /// class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        public KeyVaultKeyReferenceSourceVault(string id = default(string))
        {
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource Id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

    }
}