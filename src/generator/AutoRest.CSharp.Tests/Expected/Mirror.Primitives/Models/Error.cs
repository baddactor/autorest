// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.MirrorPrimitives.Models
{
    using MirrorPrimitives;
    using Newtonsoft.Json;
    using System.Linq;
    using System.Net.Http;

    public partial class Error
    {
        /// <summary>
        /// Initializes a new instance of the Error class.
        /// </summary>
        public Error() { }

        /// <summary>
        /// Initializes a new instance of the Error class.
        /// </summary>
        public Error(int? code = default(int?), string message = default(string), string fields = default(string))
        {
            Code = code;
            Message = message;
            Fields = fields;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "code")]
        public int? Code { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "fields")]
        public string Fields { get; set; }

    }
}
