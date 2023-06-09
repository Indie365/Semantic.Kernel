﻿// Copyright (c) Microsoft. All rights reserved.

using System;

namespace Microsoft.SemanticKernel.Diagnostics;

/// <summary>
/// Provides the base exception from which all Semantic Kernel exceptions derive.
/// </summary>
public abstract class SKException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SKException"/> class with a default message.
    /// </summary>
    protected SKException()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SKException"/> class with its message set to <paramref name="message"/>.
    /// </summary>
    /// <param name="message">A string that describes the error.</param>
    protected SKException(string? message) : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SKException"/> class with its message set to <paramref name="message"/>.
    /// </summary>
    /// <param name="message">A string that describes the error.</param>
    /// <param name="innerException">The exception that is the cause of the current exception.</param>
    protected SKException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
