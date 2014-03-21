





namespace DiscriminatedUnions
{
	using System;
    using System.Collections.Generic;
    using System.Linq;


    public class DiscriminatedUnionList<Type1, Type2> : List<DiscriminatedUnion<Type1, Type2>>
    {

        public void Add(Type1 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2>(item));
        }

        public void AddRange(IEnumerable<Type1> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type2 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2>(item));
        }

        public void AddRange(IEnumerable<Type2> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public DiscriminatedUnionList<Type1, Type2, TypeToMerge> Merge<TypeToMerge>(IEnumerable<TypeToMerge> toMerge)
        {
            var result = new DiscriminatedUnionList<Type1, Type2, TypeToMerge>();
            this.ForEach(item => item.Match(
                            Type1Item => result.Add(Type1Item),
                                Type2Item => result.Add(Type2Item)
                ));

            foreach (var item in toMerge)
            {
                result.Add(item);
            }

            return result;
        }


        public IEnumerable<ReturnType> Match<ReturnType>(Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2)
        {
            return this.Select(item => item.Match(
                item1 => Function1(item1),
                item2 => Function2(item2)
                ));//TODO Move to extension methods
        }
    }


    public class DiscriminatedUnionList<Type1, Type2, Type3> : List<DiscriminatedUnion<Type1, Type2, Type3>>
    {

        public void Add(Type1 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3>(item));
        }

		public void AddRange(IEnumerable<Type1> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type2 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3>(item));
        }

		public void AddRange(IEnumerable<Type2> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type3 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3>(item));
        }

		public void AddRange(IEnumerable<Type3> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public DiscriminatedUnionList<Type1, Type2, Type3, TypeToMerge> Merge<TypeToMerge>(IEnumerable<TypeToMerge> toMerge)
        {
            var result = new DiscriminatedUnionList<Type1, Type2, Type3, TypeToMerge>();
            this.ForEach(item => item.Match(
			                Type1Item => result.Add(Type1Item),
				                Type2Item => result.Add(Type2Item),
				                Type3Item => result.Add(Type3Item)
                ));
	
            foreach(var item in toMerge)
            {
                result.Add(item);
            }

            return result;
        }

    }


    public class DiscriminatedUnionList<Type1, Type2, Type3, Type4> : List<DiscriminatedUnion<Type1, Type2, Type3, Type4>>
    {

        public void Add(Type1 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4>(item));
        }

		public void AddRange(IEnumerable<Type1> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type2 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4>(item));
        }

		public void AddRange(IEnumerable<Type2> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type3 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4>(item));
        }

		public void AddRange(IEnumerable<Type3> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type4 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4>(item));
        }

		public void AddRange(IEnumerable<Type4> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public DiscriminatedUnionList<Type1, Type2, Type3, Type4, TypeToMerge> Merge<TypeToMerge>(IEnumerable<TypeToMerge> toMerge)
        {
            var result = new DiscriminatedUnionList<Type1, Type2, Type3, Type4, TypeToMerge>();
            this.ForEach(item => item.Match(
			                Type1Item => result.Add(Type1Item),
				                Type2Item => result.Add(Type2Item),
				                Type3Item => result.Add(Type3Item),
				                Type4Item => result.Add(Type4Item)
                ));
	
            foreach(var item in toMerge)
            {
                result.Add(item);
            }

            return result;
        }

    }


    public class DiscriminatedUnionList<Type1, Type2, Type3, Type4, Type5> : List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>>
    {

        public void Add(Type1 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(item));
        }

		public void AddRange(IEnumerable<Type1> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type2 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(item));
        }

		public void AddRange(IEnumerable<Type2> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type3 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(item));
        }

		public void AddRange(IEnumerable<Type3> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type4 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(item));
        }

		public void AddRange(IEnumerable<Type4> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type5 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(item));
        }

		public void AddRange(IEnumerable<Type5> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public DiscriminatedUnionList<Type1, Type2, Type3, Type4, Type5, TypeToMerge> Merge<TypeToMerge>(IEnumerable<TypeToMerge> toMerge)
        {
            var result = new DiscriminatedUnionList<Type1, Type2, Type3, Type4, Type5, TypeToMerge>();
            this.ForEach(item => item.Match(
			                Type1Item => result.Add(Type1Item),
				                Type2Item => result.Add(Type2Item),
				                Type3Item => result.Add(Type3Item),
				                Type4Item => result.Add(Type4Item),
				                Type5Item => result.Add(Type5Item)
                ));
	
            foreach(var item in toMerge)
            {
                result.Add(item);
            }

            return result;
        }

    }


    public class DiscriminatedUnionList<Type1, Type2, Type3, Type4, Type5, Type6> : List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>>
    {

        public void Add(Type1 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(item));
        }

		public void AddRange(IEnumerable<Type1> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type2 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(item));
        }

		public void AddRange(IEnumerable<Type2> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type3 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(item));
        }

		public void AddRange(IEnumerable<Type3> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type4 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(item));
        }

		public void AddRange(IEnumerable<Type4> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type5 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(item));
        }

		public void AddRange(IEnumerable<Type5> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type6 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(item));
        }

		public void AddRange(IEnumerable<Type6> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public DiscriminatedUnionList<Type1, Type2, Type3, Type4, Type5, Type6, TypeToMerge> Merge<TypeToMerge>(IEnumerable<TypeToMerge> toMerge)
        {
            var result = new DiscriminatedUnionList<Type1, Type2, Type3, Type4, Type5, Type6, TypeToMerge>();
            this.ForEach(item => item.Match(
			                Type1Item => result.Add(Type1Item),
				                Type2Item => result.Add(Type2Item),
				                Type3Item => result.Add(Type3Item),
				                Type4Item => result.Add(Type4Item),
				                Type5Item => result.Add(Type5Item),
				                Type6Item => result.Add(Type6Item)
                ));
	
            foreach(var item in toMerge)
            {
                result.Add(item);
            }

            return result;
        }

    }


    public class DiscriminatedUnionList<Type1, Type2, Type3, Type4, Type5, Type6, Type7> : List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>>
    {

        public void Add(Type1 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(item));
        }

		public void AddRange(IEnumerable<Type1> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type2 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(item));
        }

		public void AddRange(IEnumerable<Type2> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type3 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(item));
        }

		public void AddRange(IEnumerable<Type3> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type4 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(item));
        }

		public void AddRange(IEnumerable<Type4> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type5 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(item));
        }

		public void AddRange(IEnumerable<Type5> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type6 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(item));
        }

		public void AddRange(IEnumerable<Type6> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type7 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(item));
        }

		public void AddRange(IEnumerable<Type7> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public DiscriminatedUnionList<Type1, Type2, Type3, Type4, Type5, Type6, Type7, TypeToMerge> Merge<TypeToMerge>(IEnumerable<TypeToMerge> toMerge)
        {
            var result = new DiscriminatedUnionList<Type1, Type2, Type3, Type4, Type5, Type6, Type7, TypeToMerge>();
            this.ForEach(item => item.Match(
			                Type1Item => result.Add(Type1Item),
				                Type2Item => result.Add(Type2Item),
				                Type3Item => result.Add(Type3Item),
				                Type4Item => result.Add(Type4Item),
				                Type5Item => result.Add(Type5Item),
				                Type6Item => result.Add(Type6Item),
				                Type7Item => result.Add(Type7Item)
                ));
	
            foreach(var item in toMerge)
            {
                result.Add(item);
            }

            return result;
        }

    }


    public class DiscriminatedUnionList<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8> : List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>>
    {

        public void Add(Type1 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(item));
        }

		public void AddRange(IEnumerable<Type1> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type2 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(item));
        }

		public void AddRange(IEnumerable<Type2> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type3 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(item));
        }

		public void AddRange(IEnumerable<Type3> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type4 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(item));
        }

		public void AddRange(IEnumerable<Type4> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type5 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(item));
        }

		public void AddRange(IEnumerable<Type5> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type6 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(item));
        }

		public void AddRange(IEnumerable<Type6> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type7 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(item));
        }

		public void AddRange(IEnumerable<Type7> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type8 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(item));
        }

		public void AddRange(IEnumerable<Type8> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public DiscriminatedUnionList<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, TypeToMerge> Merge<TypeToMerge>(IEnumerable<TypeToMerge> toMerge)
        {
            var result = new DiscriminatedUnionList<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, TypeToMerge>();
            this.ForEach(item => item.Match(
			                Type1Item => result.Add(Type1Item),
				                Type2Item => result.Add(Type2Item),
				                Type3Item => result.Add(Type3Item),
				                Type4Item => result.Add(Type4Item),
				                Type5Item => result.Add(Type5Item),
				                Type6Item => result.Add(Type6Item),
				                Type7Item => result.Add(Type7Item),
				                Type8Item => result.Add(Type8Item)
                ));
	
            foreach(var item in toMerge)
            {
                result.Add(item);
            }

            return result;
        }

    }


    public class DiscriminatedUnionList<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9> : List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>>
    {

        public void Add(Type1 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(item));
        }

		public void AddRange(IEnumerable<Type1> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type2 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(item));
        }

		public void AddRange(IEnumerable<Type2> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type3 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(item));
        }

		public void AddRange(IEnumerable<Type3> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type4 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(item));
        }

		public void AddRange(IEnumerable<Type4> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type5 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(item));
        }

		public void AddRange(IEnumerable<Type5> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type6 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(item));
        }

		public void AddRange(IEnumerable<Type6> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type7 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(item));
        }

		public void AddRange(IEnumerable<Type7> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type8 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(item));
        }

		public void AddRange(IEnumerable<Type8> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type9 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(item));
        }

		public void AddRange(IEnumerable<Type9> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public DiscriminatedUnionList<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, TypeToMerge> Merge<TypeToMerge>(IEnumerable<TypeToMerge> toMerge)
        {
            var result = new DiscriminatedUnionList<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, TypeToMerge>();
            this.ForEach(item => item.Match(
			                Type1Item => result.Add(Type1Item),
				                Type2Item => result.Add(Type2Item),
				                Type3Item => result.Add(Type3Item),
				                Type4Item => result.Add(Type4Item),
				                Type5Item => result.Add(Type5Item),
				                Type6Item => result.Add(Type6Item),
				                Type7Item => result.Add(Type7Item),
				                Type8Item => result.Add(Type8Item),
				                Type9Item => result.Add(Type9Item)
                ));
	
            foreach(var item in toMerge)
            {
                result.Add(item);
            }

            return result;
        }

    }


    public class DiscriminatedUnionList<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10> : List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>>
    {

        public void Add(Type1 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(item));
        }

		public void AddRange(IEnumerable<Type1> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type2 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(item));
        }

		public void AddRange(IEnumerable<Type2> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type3 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(item));
        }

		public void AddRange(IEnumerable<Type3> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type4 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(item));
        }

		public void AddRange(IEnumerable<Type4> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type5 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(item));
        }

		public void AddRange(IEnumerable<Type5> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type6 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(item));
        }

		public void AddRange(IEnumerable<Type6> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type7 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(item));
        }

		public void AddRange(IEnumerable<Type7> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type8 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(item));
        }

		public void AddRange(IEnumerable<Type8> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type9 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(item));
        }

		public void AddRange(IEnumerable<Type9> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public void Add(Type10 item)
        {
            this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(item));
        }

		public void AddRange(IEnumerable<Type10> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

    }

}
