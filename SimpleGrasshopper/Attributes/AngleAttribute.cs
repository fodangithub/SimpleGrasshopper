﻿using Grasshopper.Kernel.Parameters;

namespace SimpleGrasshopper.Attributes;

/// <summary>
/// The attribute to enable the property <see cref="Param_Number.AngleParameter"/>.
/// </summary>
[AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
public class AngleAttribute : Attribute
{
}
