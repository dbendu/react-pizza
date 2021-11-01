using System;

namespace Domain.CommonLogic
{
    public static class EnumMapper
    {
        public static TOut Map<TIn, TOut>(TIn input)
            where TIn : Enum
            where TOut : Enum
        {
            return (TOut)Enum.Parse(typeof(TOut), input.ToString());
        }
    }
}
