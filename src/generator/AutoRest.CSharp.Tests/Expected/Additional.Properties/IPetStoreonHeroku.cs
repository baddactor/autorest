// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AdditionalProperties
{
    using Models;
    using Newtonsoft.Json;
    using System.Net.Http;

    /// <summary>
    /// **This example has a working backend hosted in Heroku**
    /// 
    /// </summary>
    public partial interface IPetStoreonHeroku : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        Newtonsoft.Json.JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        Newtonsoft.Json.JsonSerializerSettings DeserializationSettings { get; }


        /// <summary>
        /// Gets the IGet.
        /// </summary>
        IGet Get { get; }

        /// <summary>
        /// Gets the IPost.
        /// </summary>
        IPost Post { get; }

        /// <summary>
        /// Gets the IPut.
        /// </summary>
        IPut Put { get; }

    }
}
