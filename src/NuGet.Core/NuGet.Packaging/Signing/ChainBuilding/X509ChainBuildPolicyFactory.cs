// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using NuGet.Common;

namespace NuGet.Packaging.Signing
{
    internal static class X509ChainBuildPolicyFactory
    {
        internal const string EnvironmentVariableName = "NUGET_EXPERIMENTAL_CHAIN_BUILD_RETRY_POLICY";
        internal const char ValueDelimiter = ',';

        internal static IX509ChainBuildPolicy Create(IEnvironmentVariableReader reader)
        {
            if (reader is null)
            {
                throw new ArgumentNullException(nameof(reader));
            }

            string value = reader.GetEnvironmentVariable(EnvironmentVariableName);

            if (string.IsNullOrWhiteSpace(value))
            {
                return DefaultX509ChainBuildPolicy.Instance;
            }

            string[] parts = value.Split(ValueDelimiter);

            if (parts.Length == 2
                && int.TryParse(parts[0], out int retryCount)
                && retryCount >= 0
                && int.TryParse(parts[1], out int sleepIntervalInMilliseconds)
                && sleepIntervalInMilliseconds >= 0)
            {
                TimeSpan sleepInterval = TimeSpan.FromMilliseconds(sleepIntervalInMilliseconds);

                return new RetriableX509ChainBuildPolicy(retryCount, sleepInterval);
            }

            return DefaultX509ChainBuildPolicy.Instance;
        }
    }
}
