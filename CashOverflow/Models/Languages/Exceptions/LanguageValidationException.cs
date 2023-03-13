﻿// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Developed by CashOverflow Team
// --------------------------------------------------------

using Xeptions;

namespace CashOverflow.Models.Languages.Exceptions {
    public class LanguageValidationException : Xeption {
        public LanguageValidationException(Xeption innerException)
            : base(message: "Location validation error occurred, fix the errors and try again.", innerException) { }
    }
}