// Copyright (c) 2020, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

using System;

namespace Moryx.ClientFramework
{
    /// <summary>
    /// BaseClass for exceptions within Client code. It should add usable information to the System.Exception, 
    /// that may be used by a superior component/module/plugin to handle the exception.
    /// </summary>
    public class ClientException : Exception
    {
        /// <summary>
        /// Display text of this exception
        /// </summary>
        public string DisplayText { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientException"/> class.
        /// </summary>
        public ClientException(string message, Exception innerException, string displayText)
            : base(message, innerException)
        {
            DisplayText = displayText;
        }
    }
}
