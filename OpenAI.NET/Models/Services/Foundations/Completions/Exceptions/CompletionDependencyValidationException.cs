﻿// --------------------------------------------------------------- 
// Copyright (c) Coalition of the Good-Hearted Engineers 
// ---------------------------------------------------------------

using Xeptions;

namespace OpenAI.NET.Models.Services.Foundations.Completions.Exceptions
{
    internal class CompletionDependencyValidationException : Xeption
    {
        public CompletionDependencyValidationException(Xeption innerException)
            : base(message: "Completion dependency validation error occurred. Fix errors and try again.", innerException)
        { }
    }
}