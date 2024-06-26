using System;
using UnityEditor.Experimental.GraphView;

namespace H8.FlowGraph
{
    [AttributeUsage(AttributeTargets.Property)]
    public class OutputAttribute : PortAttribute
    {
        public OutputAttribute(string backingFieldName = null) : base(backingFieldName) { }

        public override Direction Direction => Direction.Output; 
    }
}
