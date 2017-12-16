// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text;

namespace NuGet.Packaging.Signing
{
    /// <summary>
    /// This class is used to hold metadata about the central directory archive structure
    /// </summary>
    public class CentralDirectoryHeaderMetadata
    {
        /// <summary>
        /// Position in bytes of the corresponding central directory header relative to the start of the archive
        /// </summary>
        public long Position { get; set; }

        /// <summary>
        /// Offset in bytes to the corresponding file header relative to the start of the archive
        /// </summary>
        public long OffsetToFileHeader { get; set; }

        /// <summary>
        /// Total size of corresponding file entry in bytes
        /// This should include size of local file header + encryption header + file data + data descriptor
        /// </summary>
        public long FileEntryTotalSize { get; set; }

        /// <summary>
        /// Filename for the central directory header
        /// </summary>
        public string Filename { get; set; }

        /// <summary>
        /// Size of central directory header, in bytes, excluding the central directory header signature.
        /// </summary>
        public long HeaderSize { get; set; }

        /// <summary>
        /// Value used to identify how much the position of the OffsetToFileHeader property will change by
        /// the presence of a signature file in bytes
        /// </summary>
        public long ChangeInOffset { get; set; }

        /// <summary>
        /// Index in which the central directory record was read from the archive.
        /// This index represents the order of the central directory record as it is in the file.
        /// </summary>
        public int IndexInHeaders { get; set; }
    }
}
