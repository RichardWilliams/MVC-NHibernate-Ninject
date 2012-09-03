using System;

namespace MvcApplication1.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class TransactionAttribute : Attribute
    {         
    }
}