// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Product profile.
    /// </summary>
    public partial class ProductTagResourceContractProperties : ProductEntityBaseParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ProductTagResourceContractProperties class.
        /// </summary>
        public ProductTagResourceContractProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ProductTagResourceContractProperties class.
        /// </summary>
        /// <param name="name">Product name.</param>
        /// <param name="description">Product description. May include HTML
        /// formatting tags.</param>
        /// <param name="terms">Product terms of use. Developers trying to
        /// subscribe to the product will be presented and required to accept
        /// these terms before they can complete the subscription
        /// process.</param>
        /// <param name="subscriptionRequired">Whether a product subscription
        /// is required for accessing APIs included in this product. If true,
        /// the product is referred to as "protected" and a valid subscription
        /// key is required for a request to an API included in the product to
        /// succeed. If false, the product is referred to as "open" and
        /// requests to an API included in the product can be made without a
        /// subscription key. If property is omitted when creating a new
        /// product it's value is assumed to be true.</param>
        /// <param name="approvalRequired">whether subscription approval is
        /// required. If false, new subscriptions will be approved
        /// automatically enabling developers to call the product’s APIs
        /// immediately after subscribing. If true, administrators must
        /// manually approve the subscription before the developer can any of
        /// the product’s APIs. Can be present only if subscriptionRequired
        /// property is present and has a value of false.</param>
        /// <param name="subscriptionsLimit">Whether the number of
        /// subscriptions a user can have to this product at the same time. Set
        /// to null or omit to allow unlimited per user subscriptions. Can be
        /// present only if subscriptionRequired property is present and has a
        /// value of false.</param>
        /// <param name="state">whether product is published or not. Published
        /// products are discoverable by users of developer portal. Non
        /// published products are visible only to administrators. Default
        /// state of Product is notPublished. Possible values include:
        /// 'notPublished', 'published'</param>
        /// <param name="id">Identifier of the product in the form of
        /// /products/{productId}</param>
        public ProductTagResourceContractProperties(string name, string description = default(string), string terms = default(string), bool? subscriptionRequired = default(bool?), bool? approvalRequired = default(bool?), int? subscriptionsLimit = default(int?), ProductState? state = default(ProductState?), string id = default(string))
            : base(description, terms, subscriptionRequired, approvalRequired, subscriptionsLimit, state)
        {
            Id = id;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets identifier of the product in the form of
        /// /products/{productId}
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets product name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Name != null)
            {
                if (Name.Length > 300)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Name", 300);
                }
                if (Name.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Name", 1);
                }
            }
        }
    }
}