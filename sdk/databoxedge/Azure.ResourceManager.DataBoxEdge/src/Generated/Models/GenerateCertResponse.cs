// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Used in activation key generation flow. </summary>
    public partial class GenerateCertResponse
    {
        /// <summary> Initializes a new instance of GenerateCertResponse. </summary>
        internal GenerateCertResponse()
        {
        }

        /// <summary> Initializes a new instance of GenerateCertResponse. </summary>
        /// <param name="publicKey">
        /// Gets or sets base64 encoded certificate raw data,
        /// this is the public part needed to be uploaded to cert vault
        /// </param>
        /// <param name="privateKey">
        /// Gets or sets base64 encoded private part of the certificate,
        /// needed to form the activation key
        /// </param>
        /// <param name="expiryTimeInUTC"> Gets or sets expiry time in UTC. </param>
        internal GenerateCertResponse(string publicKey, string privateKey, string expiryTimeInUTC)
        {
            PublicKey = publicKey;
            PrivateKey = privateKey;
            ExpiryTimeInUTC = expiryTimeInUTC;
        }

        /// <summary>
        /// Gets or sets base64 encoded certificate raw data,
        /// this is the public part needed to be uploaded to cert vault
        /// </summary>
        public string PublicKey { get; }
        /// <summary>
        /// Gets or sets base64 encoded private part of the certificate,
        /// needed to form the activation key
        /// </summary>
        public string PrivateKey { get; }
        /// <summary> Gets or sets expiry time in UTC. </summary>
        public string ExpiryTimeInUTC { get; }
    }
}
