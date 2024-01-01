// <copyright file="PdfConversionRequiredMessage.cs" company="ne1410s">
// Copyright (c) ne1410s. All rights reserved.
// </copyright>

namespace ne14.library.message_contracts.Docs;

using System;

/// <summary>
/// Data to include when requesting pdf conversion.
/// </summary>
/// <param name="InboundBlobReference">The inbound blob reference.</param>
public record PdfConversionRequiredMessage(
    Guid InboundBlobReference);
