// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.Azure.AcceptanceTestsAzureSpecials
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for SubscriptionInMethodOperations.
    /// </summary>
    public static partial class SubscriptionInMethodOperationsExtensions
    {
            /// <summary>
            /// POST method with subscriptionId modeled in the method.  pass in
            /// subscription id = '1234-5678-9012-3456' to succeed
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// This should appear as a method parameter, use value '1234-5678-9012-3456'
            /// </param>
            public static void PostMethodLocalValid(this ISubscriptionInMethodOperations operations, string subscriptionId)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((ISubscriptionInMethodOperations)s).PostMethodLocalValidAsync(subscriptionId), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// POST method with subscriptionId modeled in the method.  pass in
            /// subscription id = '1234-5678-9012-3456' to succeed
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// This should appear as a method parameter, use value '1234-5678-9012-3456'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task PostMethodLocalValidAsync(this ISubscriptionInMethodOperations operations, string subscriptionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.PostMethodLocalValidWithHttpMessagesAsync(subscriptionId, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// POST method with subscriptionId modeled in the method.  pass in
            /// subscription id = null, client-side validation should prevent you from
            /// making this call
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// This should appear as a method parameter, use value null, client-side
            /// validation should prvenet the call
            /// </param>
            public static void PostMethodLocalNull(this ISubscriptionInMethodOperations operations, string subscriptionId)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((ISubscriptionInMethodOperations)s).PostMethodLocalNullAsync(subscriptionId), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// POST method with subscriptionId modeled in the method.  pass in
            /// subscription id = null, client-side validation should prevent you from
            /// making this call
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// This should appear as a method parameter, use value null, client-side
            /// validation should prvenet the call
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task PostMethodLocalNullAsync(this ISubscriptionInMethodOperations operations, string subscriptionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.PostMethodLocalNullWithHttpMessagesAsync(subscriptionId, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// POST method with subscriptionId modeled in the method.  pass in
            /// subscription id = '1234-5678-9012-3456' to succeed
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Should appear as a method parameter -use value '1234-5678-9012-3456'
            /// </param>
            public static void PostPathLocalValid(this ISubscriptionInMethodOperations operations, string subscriptionId)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((ISubscriptionInMethodOperations)s).PostPathLocalValidAsync(subscriptionId), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// POST method with subscriptionId modeled in the method.  pass in
            /// subscription id = '1234-5678-9012-3456' to succeed
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Should appear as a method parameter -use value '1234-5678-9012-3456'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task PostPathLocalValidAsync(this ISubscriptionInMethodOperations operations, string subscriptionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.PostPathLocalValidWithHttpMessagesAsync(subscriptionId, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// POST method with subscriptionId modeled in the method.  pass in
            /// subscription id = '1234-5678-9012-3456' to succeed
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// The subscriptionId, which appears in the path, the value is always
            /// '1234-5678-9012-3456'
            /// </param>
            public static void PostSwaggerLocalValid(this ISubscriptionInMethodOperations operations, string subscriptionId)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((ISubscriptionInMethodOperations)s).PostSwaggerLocalValidAsync(subscriptionId), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// POST method with subscriptionId modeled in the method.  pass in
            /// subscription id = '1234-5678-9012-3456' to succeed
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// The subscriptionId, which appears in the path, the value is always
            /// '1234-5678-9012-3456'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task PostSwaggerLocalValidAsync(this ISubscriptionInMethodOperations operations, string subscriptionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.PostSwaggerLocalValidWithHttpMessagesAsync(subscriptionId, null, cancellationToken).ConfigureAwait(false);
            }

    }
}