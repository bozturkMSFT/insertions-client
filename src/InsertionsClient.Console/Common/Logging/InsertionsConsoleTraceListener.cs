﻿// Copyright (c) Microsoft. All rights reserved.

using System.Diagnostics;

namespace Microsoft.Net.Insertions.Common.Logging
{
    internal sealed class InsertionsConsoleTraceListener : ConsoleTraceListener
    {
        public override void WriteLine(string message)
        {
            base.WriteLine(Utilities.MessageToLogString(message));
            Flush();
        }
    }
}