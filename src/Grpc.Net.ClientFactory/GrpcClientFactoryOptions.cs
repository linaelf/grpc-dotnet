﻿#region Copyright notice and license

// Copyright 2019 The gRPC Authors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

#endregion

using System;
using System.Collections.Generic;
using Grpc.Core;
using Grpc.Core.Interceptors;
using Grpc.Net.Client;

namespace Grpc.Net.ClientFactory
{
    /// <summary>
    /// Options used to configure a gRPC client.
    /// </summary>
    public class GrpcClientFactoryOptions
    {
        /// <summary>
        /// The address to use when making gRPC calls.
        /// </summary>
        public Uri? Address { get; set; }

        /// <summary>
        /// Gets a list of operations used to configure a <see cref="GrpcChannelOptions"/>.
        /// </summary>
        public IList<Action<GrpcChannelOptions>> ChannelOptionsActions { get; } = new List<Action<GrpcChannelOptions>>();

        /// <summary>
        /// Gets a list of <see cref="Interceptor"/> instances used to configure a gRPC client pipeline.
        /// </summary>
        public IList<Interceptor> Interceptors { get; } = new List<Interceptor>();

        /// <summary>
        /// Gets or sets a delegate that will override how a client is created.
        /// </summary>
        public Func<CallInvoker, object>? Creator { get; set; }
    }
}
