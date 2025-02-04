// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace System;

public class UserFriendlyException : Exception
{
    public UserFriendlyException(string message)
        : base(message)
    {
    }
}
