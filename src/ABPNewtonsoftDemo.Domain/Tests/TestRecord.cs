using System;
using Volo.Abp.Domain.Entities;

namespace ABPNewtonsoftDemo.Tests;

public class TestRecord : BasicAggregateRoot<Guid>
{
    protected TestRecord()
    {

    }

    public TestRecord(string name, string value)
    {
        Name = name;
        Value = value;
    }
    
    public string Name { get; set; }
    public string Value { get; set; }
}
