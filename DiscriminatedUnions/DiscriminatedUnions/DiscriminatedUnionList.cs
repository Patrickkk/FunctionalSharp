namespace DiscriminatedUnions
{
	using System;
    using System.Collections.Generic;

    public class DiscriminatedUnionList<Type1, Type2> : List<DiscriminatedUnion<Type1, Type2>>
    {
        public void Add(Type1 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2>(item));
        }
        public void Add(Type2 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2>(item));
        }
    }

    public class DiscriminatedUnionList<Type1, Type2, Type3> : List<DiscriminatedUnion<Type1, Type2, Type3>>
    {
        public void Add(Type1 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3>(item));
        }
        public void Add(Type2 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3>(item));
        }
        public void Add(Type3 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3>(item));
        }
    }

    public class DiscriminatedUnionList<Type1, Type2, Type3, Type4> : List<DiscriminatedUnion<Type1, Type2, Type3, Type4>>
    {
        public void Add(Type1 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4>(item));
        }
        public void Add(Type2 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4>(item));
        }
        public void Add(Type3 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4>(item));
        }
        public void Add(Type4 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4>(item));
        }
    }

    public class DiscriminatedUnionList<Type1, Type2, Type3, Type4, Type5> : List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>>
    {
        public void Add(Type1 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(item));
        }
        public void Add(Type2 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(item));
        }
        public void Add(Type3 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(item));
        }
        public void Add(Type4 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(item));
        }
        public void Add(Type5 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(item));
        }
    }

    public class DiscriminatedUnionList<Type1, Type2, Type3, Type4, Type5, Type6> : List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>>
    {
        public void Add(Type1 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(item));
        }
        public void Add(Type2 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(item));
        }
        public void Add(Type3 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(item));
        }
        public void Add(Type4 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(item));
        }
        public void Add(Type5 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(item));
        }
        public void Add(Type6 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(item));
        }
    }

    public class DiscriminatedUnionList<Type1, Type2, Type3, Type4, Type5, Type6, Type7> : List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>>
    {
        public void Add(Type1 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(item));
        }
        public void Add(Type2 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(item));
        }
        public void Add(Type3 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(item));
        }
        public void Add(Type4 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(item));
        }
        public void Add(Type5 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(item));
        }
        public void Add(Type6 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(item));
        }
        public void Add(Type7 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(item));
        }
    }

    public class DiscriminatedUnionList<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8> : List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>>
    {
        public void Add(Type1 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(item));
        }
        public void Add(Type2 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(item));
        }
        public void Add(Type3 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(item));
        }
        public void Add(Type4 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(item));
        }
        public void Add(Type5 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(item));
        }
        public void Add(Type6 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(item));
        }
        public void Add(Type7 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(item));
        }
        public void Add(Type8 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(item));
        }
    }

    public class DiscriminatedUnionList<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9> : List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>>
    {
        public void Add(Type1 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(item));
        }
        public void Add(Type2 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(item));
        }
        public void Add(Type3 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(item));
        }
        public void Add(Type4 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(item));
        }
        public void Add(Type5 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(item));
        }
        public void Add(Type6 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(item));
        }
        public void Add(Type7 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(item));
        }
        public void Add(Type8 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(item));
        }
        public void Add(Type9 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(item));
        }
    }

    public class DiscriminatedUnionList<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10> : List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>>
    {
        public void Add(Type1 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(item));
        }
        public void Add(Type2 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(item));
        }
        public void Add(Type3 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(item));
        }
        public void Add(Type4 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(item));
        }
        public void Add(Type5 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(item));
        }
        public void Add(Type6 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(item));
        }
        public void Add(Type7 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(item));
        }
        public void Add(Type8 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(item));
        }
        public void Add(Type9 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(item));
        }
        public void Add(Type10 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(item));
        }
    }
}
