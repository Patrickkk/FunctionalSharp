namespace DiscriminatedUnions
{
	using System;
	using System.Linq;
    using System.Collections.Generic;



    public class DiscriminatedUnionWithBaseList<Type1, Type2, BaseType> : List<DiscriminatedUnionWithBase<Type1, Type2, BaseType>>
        where Type1 : BaseType 
        where Type2 : BaseType 

	{

        public void Add(Type1 item)
        {
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, BaseType>(item));
        }

		public void AddRange(IEnumerable<Type2> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public DiscriminatedUnionWithBaseList<Type1, Type2, TypeToMerge, BaseType> Merge<TypeToMerge>(IEnumerable<TypeToMerge> toMerge)
			where TypeToMerge : BaseType
        {
            var result = new DiscriminatedUnionWithBaseList<Type1, Type2, TypeToMerge, BaseType>();
            this.ForEach(item => item.Match(
			                Type1Item => result.Add(Type1Item),
				                Type2Item => result.Add(Type2Item)
                ));
	
            foreach(var item in toMerge)
            {
                result.Add(item);
            }

            return result;
        }

        public void Match(Action<Type1> Action1, Action<Type2> Action2)
        {
            this.ForEach(item => item.Match(
                type1Item => Action1(type1Item),
                type2Item => Action2(type2Item)
            ));
        }

        public IEnumerable<ReturnType> Match<ReturnType>(Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2)
        {
            return this.Select(item => item.Match(
                type1Item => Function1(type1Item),
                type2Item => Function2(type2Item)
            ));
        }

    }


    public class DiscriminatedUnionWithBaseList<Type1, Type2, Type3, BaseType> : List<DiscriminatedUnionWithBase<Type1, Type2, Type3, BaseType>>
        where Type1 : BaseType 
        where Type2 : BaseType 
        where Type3 : BaseType 

	{

        public void Add(Type1 item)
        {
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, BaseType>(item));
        }

		public void AddRange(IEnumerable<Type3> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public DiscriminatedUnionWithBaseList<Type1, Type2, Type3, TypeToMerge, BaseType> Merge<TypeToMerge>(IEnumerable<TypeToMerge> toMerge)
			where TypeToMerge : BaseType
        {
            var result = new DiscriminatedUnionWithBaseList<Type1, Type2, Type3, TypeToMerge, BaseType>();
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

        public void Match(Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3)
        {
            this.ForEach(item => item.Match(
                type1Item => Action1(type1Item),
                type2Item => Action2(type2Item),
                type3Item => Action3(type3Item)
            ));
        }

        public IEnumerable<ReturnType> Match<ReturnType>(Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3)
        {
            return this.Select(item => item.Match(
                type1Item => Function1(type1Item),
                type2Item => Function2(type2Item),
                type3Item => Function3(type3Item)
            ));
        }

    }


    public class DiscriminatedUnionWithBaseList<Type1, Type2, Type3, Type4, BaseType> : List<DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, BaseType>>
        where Type1 : BaseType 
        where Type2 : BaseType 
        where Type3 : BaseType 
        where Type4 : BaseType 

	{

        public void Add(Type1 item)
        {
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, BaseType>(item));
        }

		public void AddRange(IEnumerable<Type4> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public DiscriminatedUnionWithBaseList<Type1, Type2, Type3, Type4, TypeToMerge, BaseType> Merge<TypeToMerge>(IEnumerable<TypeToMerge> toMerge)
			where TypeToMerge : BaseType
        {
            var result = new DiscriminatedUnionWithBaseList<Type1, Type2, Type3, Type4, TypeToMerge, BaseType>();
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

        public void Match(Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3, Action<Type4> Action4)
        {
            this.ForEach(item => item.Match(
                type1Item => Action1(type1Item),
                type2Item => Action2(type2Item),
                type3Item => Action3(type3Item),
                type4Item => Action4(type4Item)
            ));
        }

        public IEnumerable<ReturnType> Match<ReturnType>(Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3, Func<Type4, ReturnType> Function4)
        {
            return this.Select(item => item.Match(
                type1Item => Function1(type1Item),
                type2Item => Function2(type2Item),
                type3Item => Function3(type3Item),
                type4Item => Function4(type4Item)
            ));
        }

    }


    public class DiscriminatedUnionWithBaseList<Type1, Type2, Type3, Type4, Type5, BaseType> : List<DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, BaseType>>
        where Type1 : BaseType 
        where Type2 : BaseType 
        where Type3 : BaseType 
        where Type4 : BaseType 
        where Type5 : BaseType 

	{

        public void Add(Type1 item)
        {
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, BaseType>(item));
        }

		public void AddRange(IEnumerable<Type5> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public DiscriminatedUnionWithBaseList<Type1, Type2, Type3, Type4, Type5, TypeToMerge, BaseType> Merge<TypeToMerge>(IEnumerable<TypeToMerge> toMerge)
			where TypeToMerge : BaseType
        {
            var result = new DiscriminatedUnionWithBaseList<Type1, Type2, Type3, Type4, Type5, TypeToMerge, BaseType>();
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

        public void Match(Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3, Action<Type4> Action4, Action<Type5> Action5)
        {
            this.ForEach(item => item.Match(
                type1Item => Action1(type1Item),
                type2Item => Action2(type2Item),
                type3Item => Action3(type3Item),
                type4Item => Action4(type4Item),
                type5Item => Action5(type5Item)
            ));
        }

        public IEnumerable<ReturnType> Match<ReturnType>(Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3, Func<Type4, ReturnType> Function4, Func<Type5, ReturnType> Function5)
        {
            return this.Select(item => item.Match(
                type1Item => Function1(type1Item),
                type2Item => Function2(type2Item),
                type3Item => Function3(type3Item),
                type4Item => Function4(type4Item),
                type5Item => Function5(type5Item)
            ));
        }

    }


    public class DiscriminatedUnionWithBaseList<Type1, Type2, Type3, Type4, Type5, Type6, BaseType> : List<DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, BaseType>>
        where Type1 : BaseType 
        where Type2 : BaseType 
        where Type3 : BaseType 
        where Type4 : BaseType 
        where Type5 : BaseType 
        where Type6 : BaseType 

	{

        public void Add(Type1 item)
        {
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, BaseType>(item));
        }

		public void AddRange(IEnumerable<Type6> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public DiscriminatedUnionWithBaseList<Type1, Type2, Type3, Type4, Type5, Type6, TypeToMerge, BaseType> Merge<TypeToMerge>(IEnumerable<TypeToMerge> toMerge)
			where TypeToMerge : BaseType
        {
            var result = new DiscriminatedUnionWithBaseList<Type1, Type2, Type3, Type4, Type5, Type6, TypeToMerge, BaseType>();
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

        public void Match(Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3, Action<Type4> Action4, Action<Type5> Action5, Action<Type6> Action6)
        {
            this.ForEach(item => item.Match(
                type1Item => Action1(type1Item),
                type2Item => Action2(type2Item),
                type3Item => Action3(type3Item),
                type4Item => Action4(type4Item),
                type5Item => Action5(type5Item),
                type6Item => Action6(type6Item)
            ));
        }

        public IEnumerable<ReturnType> Match<ReturnType>(Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3, Func<Type4, ReturnType> Function4, Func<Type5, ReturnType> Function5, Func<Type6, ReturnType> Function6)
        {
            return this.Select(item => item.Match(
                type1Item => Function1(type1Item),
                type2Item => Function2(type2Item),
                type3Item => Function3(type3Item),
                type4Item => Function4(type4Item),
                type5Item => Function5(type5Item),
                type6Item => Function6(type6Item)
            ));
        }

    }


    public class DiscriminatedUnionWithBaseList<Type1, Type2, Type3, Type4, Type5, Type6, Type7, BaseType> : List<DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, BaseType>>
        where Type1 : BaseType 
        where Type2 : BaseType 
        where Type3 : BaseType 
        where Type4 : BaseType 
        where Type5 : BaseType 
        where Type6 : BaseType 
        where Type7 : BaseType 

	{

        public void Add(Type1 item)
        {
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, BaseType>(item));
        }

		public void AddRange(IEnumerable<Type7> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public DiscriminatedUnionWithBaseList<Type1, Type2, Type3, Type4, Type5, Type6, Type7, TypeToMerge, BaseType> Merge<TypeToMerge>(IEnumerable<TypeToMerge> toMerge)
			where TypeToMerge : BaseType
        {
            var result = new DiscriminatedUnionWithBaseList<Type1, Type2, Type3, Type4, Type5, Type6, Type7, TypeToMerge, BaseType>();
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

        public void Match(Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3, Action<Type4> Action4, Action<Type5> Action5, Action<Type6> Action6, Action<Type7> Action7)
        {
            this.ForEach(item => item.Match(
                type1Item => Action1(type1Item),
                type2Item => Action2(type2Item),
                type3Item => Action3(type3Item),
                type4Item => Action4(type4Item),
                type5Item => Action5(type5Item),
                type6Item => Action6(type6Item),
                type7Item => Action7(type7Item)
            ));
        }

        public IEnumerable<ReturnType> Match<ReturnType>(Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3, Func<Type4, ReturnType> Function4, Func<Type5, ReturnType> Function5, Func<Type6, ReturnType> Function6, Func<Type7, ReturnType> Function7)
        {
            return this.Select(item => item.Match(
                type1Item => Function1(type1Item),
                type2Item => Function2(type2Item),
                type3Item => Function3(type3Item),
                type4Item => Function4(type4Item),
                type5Item => Function5(type5Item),
                type6Item => Function6(type6Item),
                type7Item => Function7(type7Item)
            ));
        }

    }


    public class DiscriminatedUnionWithBaseList<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, BaseType> : List<DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, BaseType>>
        where Type1 : BaseType 
        where Type2 : BaseType 
        where Type3 : BaseType 
        where Type4 : BaseType 
        where Type5 : BaseType 
        where Type6 : BaseType 
        where Type7 : BaseType 
        where Type8 : BaseType 

	{

        public void Add(Type1 item)
        {
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, BaseType>(item));
        }

		public void AddRange(IEnumerable<Type8> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public DiscriminatedUnionWithBaseList<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, TypeToMerge, BaseType> Merge<TypeToMerge>(IEnumerable<TypeToMerge> toMerge)
			where TypeToMerge : BaseType
        {
            var result = new DiscriminatedUnionWithBaseList<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, TypeToMerge, BaseType>();
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

        public void Match(Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3, Action<Type4> Action4, Action<Type5> Action5, Action<Type6> Action6, Action<Type7> Action7, Action<Type8> Action8)
        {
            this.ForEach(item => item.Match(
                type1Item => Action1(type1Item),
                type2Item => Action2(type2Item),
                type3Item => Action3(type3Item),
                type4Item => Action4(type4Item),
                type5Item => Action5(type5Item),
                type6Item => Action6(type6Item),
                type7Item => Action7(type7Item),
                type8Item => Action8(type8Item)
            ));
        }

        public IEnumerable<ReturnType> Match<ReturnType>(Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3, Func<Type4, ReturnType> Function4, Func<Type5, ReturnType> Function5, Func<Type6, ReturnType> Function6, Func<Type7, ReturnType> Function7, Func<Type8, ReturnType> Function8)
        {
            return this.Select(item => item.Match(
                type1Item => Function1(type1Item),
                type2Item => Function2(type2Item),
                type3Item => Function3(type3Item),
                type4Item => Function4(type4Item),
                type5Item => Function5(type5Item),
                type6Item => Function6(type6Item),
                type7Item => Function7(type7Item),
                type8Item => Function8(type8Item)
            ));
        }

    }


    public class DiscriminatedUnionWithBaseList<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, BaseType> : List<DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, BaseType>>
        where Type1 : BaseType 
        where Type2 : BaseType 
        where Type3 : BaseType 
        where Type4 : BaseType 
        where Type5 : BaseType 
        where Type6 : BaseType 
        where Type7 : BaseType 
        where Type8 : BaseType 
        where Type9 : BaseType 

	{

        public void Add(Type1 item)
        {
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, BaseType>(item));
        }

		public void AddRange(IEnumerable<Type9> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                this.Add(item);
            }
        }

        public DiscriminatedUnionWithBaseList<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, TypeToMerge, BaseType> Merge<TypeToMerge>(IEnumerable<TypeToMerge> toMerge)
			where TypeToMerge : BaseType
        {
            var result = new DiscriminatedUnionWithBaseList<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, TypeToMerge, BaseType>();
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

        public void Match(Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3, Action<Type4> Action4, Action<Type5> Action5, Action<Type6> Action6, Action<Type7> Action7, Action<Type8> Action8, Action<Type9> Action9)
        {
            this.ForEach(item => item.Match(
                type1Item => Action1(type1Item),
                type2Item => Action2(type2Item),
                type3Item => Action3(type3Item),
                type4Item => Action4(type4Item),
                type5Item => Action5(type5Item),
                type6Item => Action6(type6Item),
                type7Item => Action7(type7Item),
                type8Item => Action8(type8Item),
                type9Item => Action9(type9Item)
            ));
        }

        public IEnumerable<ReturnType> Match<ReturnType>(Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3, Func<Type4, ReturnType> Function4, Func<Type5, ReturnType> Function5, Func<Type6, ReturnType> Function6, Func<Type7, ReturnType> Function7, Func<Type8, ReturnType> Function8, Func<Type9, ReturnType> Function9)
        {
            return this.Select(item => item.Match(
                type1Item => Function1(type1Item),
                type2Item => Function2(type2Item),
                type3Item => Function3(type3Item),
                type4Item => Function4(type4Item),
                type5Item => Function5(type5Item),
                type6Item => Function6(type6Item),
                type7Item => Function7(type7Item),
                type8Item => Function8(type8Item),
                type9Item => Function9(type9Item)
            ));
        }

    }


    public class DiscriminatedUnionWithBaseList<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10, BaseType> : List<DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10, BaseType>>
        where Type1 : BaseType 
        where Type2 : BaseType 
        where Type3 : BaseType 
        where Type4 : BaseType 
        where Type5 : BaseType 
        where Type6 : BaseType 
        where Type7 : BaseType 
        where Type8 : BaseType 
        where Type9 : BaseType 
        where Type10 : BaseType 

	{

        public void Add(Type1 item)
        {
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10, BaseType>(item));
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
            this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10, BaseType>(item));
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
