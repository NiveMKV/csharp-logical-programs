using System;
using System.Linq;
public static class CountTrueValues{
    public static int countTrueValues(bool[] values)
    {
        var trueValues =    from trueValue in values
                                where (trueValue.ToString().ToLower() == "true")
                                select trueValue;
        return trueValues.Count();
    }
}
