// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.MirrorPolymorphic.Models
{
    using MirrorPolymorphic;
    using Newtonsoft.Json;
    using System.Linq;
    using System.Net.Http;

    public partial class HimalayanCat : SiameseCat
    {
        /// <summary>
        /// Initializes a new instance of the HimalayanCat class.
        /// </summary>
        public HimalayanCat() { }

        /// <summary>
        /// Initializes a new instance of the HimalayanCat class.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <param name="description">Description of a Animal.</param>
        /// <param name="color">cat color</param>
        /// <param name="length">cat length</param>
        /// <param name="hairLength">cat hair length</param>
        public HimalayanCat(string id = default(string), string description = default(string), string color = default(string), int? length = default(int?), int? hairLength = default(int?))
            : base(id, description, color, length)
        {
            HairLength = hairLength;
        }

        /// <summary>
        /// Gets or sets cat hair length
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "hairLength")]
        public int? HairLength { get; set; }

    }
}
