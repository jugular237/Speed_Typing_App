﻿using System;

namespace LibraryCl
{
    public class Result
    {
        public readonly double wpmRes;

        public readonly DateTime date;

        public Result(double wpm, DateTime date)
        {
            wpmRes = wpm;
            this.date = date;
        }
    }
}
