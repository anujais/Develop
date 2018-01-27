using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public interface INode
    {
        INode GetNext();
        void SetNext(INode node);
        void Print();
    }
}
