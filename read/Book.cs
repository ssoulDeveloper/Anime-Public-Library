
using System;
using AnimePublicLibrary.core;

namespace AnimePublicLibrary.read
{
    public class Book : SerieItem
    {
        private uint mPageCount;
        private uint mChpCount;

        public Book(string title, uint number) : this(title, number, 1, 1){ }

        public Book(string title, uint number, uint chapters, uint pages) : base(title, number)
        {
            mPageCount = pages;
            mChpCount = chapters;
        }

        public uint PageCount
        {
            get
            {
                return mPageCount;
            }
            set
            {
                mPageCount = value;
            }
        }

        public uint ChapterCount
        {
            get
            {
                return mChpCount;
            }
            set
            {
                mChpCount = value;
            }
        }


    }
}
