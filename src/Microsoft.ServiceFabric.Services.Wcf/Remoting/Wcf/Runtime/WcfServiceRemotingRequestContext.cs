﻿// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------
namespace Microsoft.ServiceFabric.Services.Remoting.Wcf.Runtime
{
    using System.ServiceModel;
    using Microsoft.ServiceFabric.Services.Remoting;
    using Microsoft.ServiceFabric.Services.Remoting.Runtime;
    using Microsoft.ServiceFabric.Services.Remoting.Wcf;

    internal sealed class WcfServiceRemotingRequestContext : IServiceRemotingRequestContext
    {
        public IServiceRemotingCallbackClient GetCallbackClient()
        {
            return new WcfServiceRemotingCommunicationCallback(
                OperationContext.Current.GetCallbackChannel<IServiceRemotingCallbackContract>());
        }
    }
}