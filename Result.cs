using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
