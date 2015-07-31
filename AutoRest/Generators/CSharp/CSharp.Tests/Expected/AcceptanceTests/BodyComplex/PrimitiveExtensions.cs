// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsBodyComplex
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    public static partial class PrimitiveExtensions
    {
            /// <summary>
            /// Get complex types with integer properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IntWrapper GetInt(this IPrimitive operations)
            {
                return Task.Factory.StartNew(s => ((IPrimitive)s).GetIntAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get complex types with integer properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IntWrapper> GetIntAsync( this IPrimitive operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                HttpOperationResponse<IntWrapper> result = await operations.GetIntWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Put complex types with integer properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='complexBody'>
            /// Please put -1 and 2
            /// </param>
            public static void PutInt(this IPrimitive operations, IntWrapper complexBody)
            {
                Task.Factory.StartNew(s => ((IPrimitive)s).PutIntAsync(complexBody), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put complex types with integer properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='complexBody'>
            /// Please put -1 and 2
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutIntAsync( this IPrimitive operations, IntWrapper complexBody, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PutIntWithHttpMessagesAsync(complexBody, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get complex types with long properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static LongWrapper GetLong(this IPrimitive operations)
            {
                return Task.Factory.StartNew(s => ((IPrimitive)s).GetLongAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get complex types with long properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LongWrapper> GetLongAsync( this IPrimitive operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                HttpOperationResponse<LongWrapper> result = await operations.GetLongWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Put complex types with long properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='complexBody'>
            /// Please put 1099511627775 and -999511627788
            /// </param>
            public static void PutLong(this IPrimitive operations, LongWrapper complexBody)
            {
                Task.Factory.StartNew(s => ((IPrimitive)s).PutLongAsync(complexBody), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put complex types with long properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='complexBody'>
            /// Please put 1099511627775 and -999511627788
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutLongAsync( this IPrimitive operations, LongWrapper complexBody, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PutLongWithHttpMessagesAsync(complexBody, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get complex types with float properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static FloatWrapper GetFloat(this IPrimitive operations)
            {
                return Task.Factory.StartNew(s => ((IPrimitive)s).GetFloatAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get complex types with float properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FloatWrapper> GetFloatAsync( this IPrimitive operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                HttpOperationResponse<FloatWrapper> result = await operations.GetFloatWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Put complex types with float properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='complexBody'>
            /// Please put 1.05 and -0.003
            /// </param>
            public static void PutFloat(this IPrimitive operations, FloatWrapper complexBody)
            {
                Task.Factory.StartNew(s => ((IPrimitive)s).PutFloatAsync(complexBody), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put complex types with float properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='complexBody'>
            /// Please put 1.05 and -0.003
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutFloatAsync( this IPrimitive operations, FloatWrapper complexBody, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PutFloatWithHttpMessagesAsync(complexBody, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get complex types with double properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static DoubleWrapper GetDouble(this IPrimitive operations)
            {
                return Task.Factory.StartNew(s => ((IPrimitive)s).GetDoubleAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get complex types with double properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DoubleWrapper> GetDoubleAsync( this IPrimitive operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                HttpOperationResponse<DoubleWrapper> result = await operations.GetDoubleWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Put complex types with double properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='complexBody'>
            /// Please put 3e-100 and
            /// -0.000000000000000000000000000000000000000000000000000000005
            /// </param>
            public static void PutDouble(this IPrimitive operations, DoubleWrapper complexBody)
            {
                Task.Factory.StartNew(s => ((IPrimitive)s).PutDoubleAsync(complexBody), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put complex types with double properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='complexBody'>
            /// Please put 3e-100 and
            /// -0.000000000000000000000000000000000000000000000000000000005
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutDoubleAsync( this IPrimitive operations, DoubleWrapper complexBody, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PutDoubleWithHttpMessagesAsync(complexBody, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get complex types with bool properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static BooleanWrapper GetBool(this IPrimitive operations)
            {
                return Task.Factory.StartNew(s => ((IPrimitive)s).GetBoolAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get complex types with bool properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BooleanWrapper> GetBoolAsync( this IPrimitive operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                HttpOperationResponse<BooleanWrapper> result = await operations.GetBoolWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Put complex types with bool properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='complexBody'>
            /// Please put true and false
            /// </param>
            public static void PutBool(this IPrimitive operations, BooleanWrapper complexBody)
            {
                Task.Factory.StartNew(s => ((IPrimitive)s).PutBoolAsync(complexBody), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put complex types with bool properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='complexBody'>
            /// Please put true and false
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutBoolAsync( this IPrimitive operations, BooleanWrapper complexBody, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PutBoolWithHttpMessagesAsync(complexBody, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get complex types with string properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static StringWrapper GetString(this IPrimitive operations)
            {
                return Task.Factory.StartNew(s => ((IPrimitive)s).GetStringAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get complex types with string properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<StringWrapper> GetStringAsync( this IPrimitive operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                HttpOperationResponse<StringWrapper> result = await operations.GetStringWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Put complex types with string properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='complexBody'>
            /// Please put 'goodrequest', '', and null
            /// </param>
            public static void PutString(this IPrimitive operations, StringWrapper complexBody)
            {
                Task.Factory.StartNew(s => ((IPrimitive)s).PutStringAsync(complexBody), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put complex types with string properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='complexBody'>
            /// Please put 'goodrequest', '', and null
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutStringAsync( this IPrimitive operations, StringWrapper complexBody, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PutStringWithHttpMessagesAsync(complexBody, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get complex types with date properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static DateWrapper GetDate(this IPrimitive operations)
            {
                return Task.Factory.StartNew(s => ((IPrimitive)s).GetDateAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get complex types with date properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DateWrapper> GetDateAsync( this IPrimitive operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                HttpOperationResponse<DateWrapper> result = await operations.GetDateWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Put complex types with date properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='complexBody'>
            /// Please put '0001-01-01' and '2016-02-29'
            /// </param>
            public static void PutDate(this IPrimitive operations, DateWrapper complexBody)
            {
                Task.Factory.StartNew(s => ((IPrimitive)s).PutDateAsync(complexBody), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put complex types with date properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='complexBody'>
            /// Please put '0001-01-01' and '2016-02-29'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutDateAsync( this IPrimitive operations, DateWrapper complexBody, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PutDateWithHttpMessagesAsync(complexBody, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get complex types with datetime properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static DatetimeWrapper GetDateTime(this IPrimitive operations)
            {
                return Task.Factory.StartNew(s => ((IPrimitive)s).GetDateTimeAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get complex types with datetime properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DatetimeWrapper> GetDateTimeAsync( this IPrimitive operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                HttpOperationResponse<DatetimeWrapper> result = await operations.GetDateTimeWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Put complex types with datetime properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='complexBody'>
            /// Please put '0001-01-01T12:00:00-04:00' and '2015-05-18T11:38:00-08:00'
            /// </param>
            public static void PutDateTime(this IPrimitive operations, DatetimeWrapper complexBody)
            {
                Task.Factory.StartNew(s => ((IPrimitive)s).PutDateTimeAsync(complexBody), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put complex types with datetime properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='complexBody'>
            /// Please put '0001-01-01T12:00:00-04:00' and '2015-05-18T11:38:00-08:00'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutDateTimeAsync( this IPrimitive operations, DatetimeWrapper complexBody, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PutDateTimeWithHttpMessagesAsync(complexBody, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get complex types with byte properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static ByteWrapper GetByte(this IPrimitive operations)
            {
                return Task.Factory.StartNew(s => ((IPrimitive)s).GetByteAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get complex types with byte properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ByteWrapper> GetByteAsync( this IPrimitive operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                HttpOperationResponse<ByteWrapper> result = await operations.GetByteWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Put complex types with byte properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='complexBody'>
            /// Please put non-ascii byte string hex(FF FE FD FC 00 FA F9 F8 F7 F6)
            /// </param>
            public static void PutByte(this IPrimitive operations, ByteWrapper complexBody)
            {
                Task.Factory.StartNew(s => ((IPrimitive)s).PutByteAsync(complexBody), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put complex types with byte properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='complexBody'>
            /// Please put non-ascii byte string hex(FF FE FD FC 00 FA F9 F8 F7 F6)
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutByteAsync( this IPrimitive operations, ByteWrapper complexBody, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PutByteWithHttpMessagesAsync(complexBody, null, cancellationToken).ConfigureAwait(false);
            }

    }
}
