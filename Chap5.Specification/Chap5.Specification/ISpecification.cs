using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap5.Specification
{
    public interface ISpecification<T>
    {
        bool ISpatisfiedBy(T candidate);
    }
}
