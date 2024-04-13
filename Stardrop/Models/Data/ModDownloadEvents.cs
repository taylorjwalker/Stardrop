﻿using System;
using System.Threading;

namespace Stardrop.Models.Data
{
    internal record ModDownloadStartedEventArgs(Uri Uri, string Name, long? Size, CancellationToken DownloadCancelToken);    
    internal record ModDownloadProgressEventArgs(Uri Uri, long TotalBytes);
    internal record ModDownloadCompletedEventArgs(Uri Uri);
    internal record ModDownloadFailedEventArgs(Uri Uri);
}
