﻿// <copyright file="PdfConversionFailedMessage.cs" company="ne1410s">
// Copyright (c) ne1410s. All rights reserved.
// </copyright>

namespace ne14.library.message_contracts.Docs;

using System;

/// <summary>
/// Data emitted when notifying of pdf conversion failure.
/// </summary>
/// <param name="UserId">The user who sent the original request.</param>
/// <param name="FileName">The original name of the file as it was received.</param>
/// <param name="InboundBlobReference">The inbound blob reference.</param>
/// <param name="FailureReason">The failure reason.</param>
public record PdfConversionFailedMessage(
    string UserId,
    string FileName,
    Guid InboundBlobReference,
    string FailureReason);
