using System;

public class TypeAttribute : Attribute
{
    public string Type { get; set; }
    public string Category { get; set; }

    public string Description { get; set; }
}

