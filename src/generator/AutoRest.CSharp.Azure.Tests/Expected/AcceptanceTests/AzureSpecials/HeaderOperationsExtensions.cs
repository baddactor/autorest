// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.Azure.AcceptanceTestsAzureSpecials
{
    using Azure;
    using Microsoft.Rest;
   using Microsoft.Rest.Azure;
   using Models;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for HeaderOperations.
    /// </summary>
    public static partial class HeaderOperationsExtensions
    {
            /// <summary>
            /// Send foo-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 in the
            /// header of the request
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fooClientRequestId'>
            /// The fooRequestId
            /// </param>
            public static HeaderCustomNamedRequestIdHeaders CustomNamedRequestId(this IHeaderOperations operations, string fooClientRequestId)
            {
                return Task.Factory.StartNew(s => ((IHeaderOperations)s).CustomNamedRequestIdAsync(fooClientRequestId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Send foo-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 in the
            /// header of the request
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fooClientRequestId'>
            /// The fooRequestId
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<HeaderCustomNamedRequestIdHeaders> CustomNamedRequestIdAsync(this IHeaderOperations operations, string fooClientRequestId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CustomNamedRequestIdWithHttpMessagesAsync(fooClientRequestId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Send foo-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 in the
            /// header of the request, via a parameter group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='headerCustomNamedRequestIdParamGroupingParameters'>
            /// Additional parameters for the operation
            /// </param>
            public static HeaderCustomNamedRequestIdParamGroupingHeaders CustomNamedRequestIdParamGrouping(this IHeaderOperations operations, HeaderCustomNamedRequestIdParamGroupingParameters headerCustomNamedRequestIdParamGroupingParameters)
            {
                return Task.Factory.StartNew(s => ((IHeaderOperations)s).CustomNamedRequestIdParamGroupingAsync(headerCustomNamedRequestIdParamGroupingParameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Send foo-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 in the
            /// header of the request, via a parameter group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='headerCustomNamedRequestIdParamGroupingParameters'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<HeaderCustomNamedRequestIdParamGroupingHeaders> CustomNamedRequestIdParamGroupingAsync(this IHeaderOperations operations, HeaderCustomNamedRequestIdParamGroupingParameters headerCustomNamedRequestIdParamGroupingParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CustomNamedRequestIdParamGroupingWithHttpMessagesAsync(headerCustomNamedRequestIdParamGroupingParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

    }
}
