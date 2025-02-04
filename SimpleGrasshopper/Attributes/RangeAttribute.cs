﻿namespace SimpleGrasshopper.Attributes;

/// <summary>
/// Add the range for this config.
/// </summary>
/// <param name="min">minimum</param>
/// <param name="max">maximum</param>
/// <param name="place">decimal places</param>
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public class RangeAttribute(double min, double max, int place) : Attribute
{
    internal decimal Min => Convert.ToDecimal(min);
    internal decimal Max => Convert.ToDecimal(max);
    internal int Place => place;
}
