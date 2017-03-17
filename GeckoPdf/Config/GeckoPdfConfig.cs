﻿namespace GeckoPdf.Config
{
    public class GeckoPdfConfig
    {
        /// <summary>
        /// Printing bakground images
        /// </summary>
        public bool PrintBackgroundImages { get; set; }

        /// <summary>
        /// First page of range to print (default 1)
        /// </summary>
        public int StartPageRange { get; set; } = 1;

        /// <summary>
        /// Last page of range to print (default int.MaxValue)
        /// </summary>
        public int EndPageRange { get; set; } = int.MaxValue;

        /// <summary>
        /// Shrink document to fit page size (default true)
        /// </summary>
        public bool ShrinkToFit { get; set; } = true;

        /// <summary>
        /// Print even pages (default true)
        /// </summary>
        public bool PrintEvenPages { get; set; } = true;

        /// <summary>
        /// Print odd pages (default true)
        /// </summary>
        public bool PrintOddPages { get; set; }

        /// <summary>
        /// Scale of document content (default 1.0)
        /// </summary>
        public double DocumentScale { get; set; } = 1.0;

        public bool IsJavaScriptEnabled { get; set; } = true;
    }
}