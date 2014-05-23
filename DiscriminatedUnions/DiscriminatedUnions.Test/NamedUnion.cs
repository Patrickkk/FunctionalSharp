using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiscriminatedUnions.Test
{
    public class NamedUnion : DiscriminatedUnion<string, int>
    {
        public NamedUnion(int value) : base(value) { }
        public NamedUnion(string value) : base(value) { }
    }
}
