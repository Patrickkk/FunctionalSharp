namespace FunctionalSharp.DiscriminatedUnions
{
	using System;
	using System.Linq;
	using System.Collections.Generic;


	/// <summary>
	/// Represents a list of Discriminated unions with a common baseclass. Using this list you can add items without having to specify the union type.
	/// </summary>
	[Serializable]
	public class DiscriminatedUnionWithBaseList<Type1, Type2, BaseType> : List<DiscriminatedUnionWithBase<Type1, Type2, BaseType>>
		where Type1 : BaseType 
		where Type2 : BaseType 

	{
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type1 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type1> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type2 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type2> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}

		/// <summary>
		/// Merges a type into the existing discriminated union list. 
		/// </summary>
		/// <typeparam name="TypeToMerge">The type of the items to merge.</typeparam>
		/// <param name="toMerge">The Items to merge.</param>
		/// <returns></returns>
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

	}

	/// <summary>
	/// Represents a list of Discriminated unions with a common baseclass. Using this list you can add items without having to specify the union type.
	/// </summary>
	[Serializable]
	public class DiscriminatedUnionWithBaseList<Type1, Type2, Type3, BaseType> : List<DiscriminatedUnionWithBase<Type1, Type2, Type3, BaseType>>
		where Type1 : BaseType 
		where Type2 : BaseType 
		where Type3 : BaseType 

	{
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type1 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type1> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type2 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type2> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type3 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type3> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}

		/// <summary>
		/// Merges a type into the existing discriminated union list. 
		/// </summary>
		/// <typeparam name="TypeToMerge">The type of the items to merge.</typeparam>
		/// <param name="toMerge">The Items to merge.</param>
		/// <returns></returns>
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

	}

	/// <summary>
	/// Represents a list of Discriminated unions with a common baseclass. Using this list you can add items without having to specify the union type.
	/// </summary>
	[Serializable]
	public class DiscriminatedUnionWithBaseList<Type1, Type2, Type3, Type4, BaseType> : List<DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, BaseType>>
		where Type1 : BaseType 
		where Type2 : BaseType 
		where Type3 : BaseType 
		where Type4 : BaseType 

	{
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type1 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type1> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type2 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type2> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type3 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type3> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type4 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type4> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}

		/// <summary>
		/// Merges a type into the existing discriminated union list. 
		/// </summary>
		/// <typeparam name="TypeToMerge">The type of the items to merge.</typeparam>
		/// <param name="toMerge">The Items to merge.</param>
		/// <returns></returns>
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

	}

	/// <summary>
	/// Represents a list of Discriminated unions with a common baseclass. Using this list you can add items without having to specify the union type.
	/// </summary>
	[Serializable]
	public class DiscriminatedUnionWithBaseList<Type1, Type2, Type3, Type4, Type5, BaseType> : List<DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, BaseType>>
		where Type1 : BaseType 
		where Type2 : BaseType 
		where Type3 : BaseType 
		where Type4 : BaseType 
		where Type5 : BaseType 

	{
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type1 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type1> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type2 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type2> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type3 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type3> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type4 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type4> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type5 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type5> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}

		/// <summary>
		/// Merges a type into the existing discriminated union list. 
		/// </summary>
		/// <typeparam name="TypeToMerge">The type of the items to merge.</typeparam>
		/// <param name="toMerge">The Items to merge.</param>
		/// <returns></returns>
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

	}

	/// <summary>
	/// Represents a list of Discriminated unions with a common baseclass. Using this list you can add items without having to specify the union type.
	/// </summary>
	[Serializable]
	public class DiscriminatedUnionWithBaseList<Type1, Type2, Type3, Type4, Type5, Type6, BaseType> : List<DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, BaseType>>
		where Type1 : BaseType 
		where Type2 : BaseType 
		where Type3 : BaseType 
		where Type4 : BaseType 
		where Type5 : BaseType 
		where Type6 : BaseType 

	{
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type1 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type1> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type2 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type2> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type3 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type3> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type4 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type4> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type5 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type5> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type6 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type6> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}

		/// <summary>
		/// Merges a type into the existing discriminated union list. 
		/// </summary>
		/// <typeparam name="TypeToMerge">The type of the items to merge.</typeparam>
		/// <param name="toMerge">The Items to merge.</param>
		/// <returns></returns>
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

	}

	/// <summary>
	/// Represents a list of Discriminated unions with a common baseclass. Using this list you can add items without having to specify the union type.
	/// </summary>
	[Serializable]
	public class DiscriminatedUnionWithBaseList<Type1, Type2, Type3, Type4, Type5, Type6, Type7, BaseType> : List<DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, BaseType>>
		where Type1 : BaseType 
		where Type2 : BaseType 
		where Type3 : BaseType 
		where Type4 : BaseType 
		where Type5 : BaseType 
		where Type6 : BaseType 
		where Type7 : BaseType 

	{
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type1 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type1> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type2 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type2> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type3 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type3> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type4 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type4> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type5 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type5> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type6 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type6> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type7 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type7> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}

		/// <summary>
		/// Merges a type into the existing discriminated union list. 
		/// </summary>
		/// <typeparam name="TypeToMerge">The type of the items to merge.</typeparam>
		/// <param name="toMerge">The Items to merge.</param>
		/// <returns></returns>
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

	}

	/// <summary>
	/// Represents a list of Discriminated unions with a common baseclass. Using this list you can add items without having to specify the union type.
	/// </summary>
	[Serializable]
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
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type1 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type1> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type2 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type2> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type3 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type3> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type4 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type4> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type5 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type5> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type6 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type6> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type7 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type7> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type8 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type8> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}

		/// <summary>
		/// Merges a type into the existing discriminated union list. 
		/// </summary>
		/// <typeparam name="TypeToMerge">The type of the items to merge.</typeparam>
		/// <param name="toMerge">The Items to merge.</param>
		/// <returns></returns>
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

	}

	/// <summary>
	/// Represents a list of Discriminated unions with a common baseclass. Using this list you can add items without having to specify the union type.
	/// </summary>
	[Serializable]
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
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type1 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type1> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type2 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type2> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type3 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type3> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type4 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type4> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type5 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type5> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type6 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type6> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type7 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type7> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type8 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type8> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type9 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type9> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}

		/// <summary>
		/// Merges a type into the existing discriminated union list. 
		/// </summary>
		/// <typeparam name="TypeToMerge">The type of the items to merge.</typeparam>
		/// <param name="toMerge">The Items to merge.</param>
		/// <returns></returns>
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

	}

	/// <summary>
	/// Represents a list of Discriminated unions with a common baseclass. Using this list you can add items without having to specify the union type.
	/// </summary>
	[Serializable]
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
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type1 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type1> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type2 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type2> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type3 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type3> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type4 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type4> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type5 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type5> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type6 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type6> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type7 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type7> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type8 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type8> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type9 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type9> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}
        
		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		public void Add(Type10 item)
		{
			this.Add(new DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10, BaseType>(item));
		}

		/// <summary>
		/// Adds a Enumerable of items to the list.
		/// </summary>
		/// <param name="collectionToAdd">The items to add.</param>
		public void AddRange(IEnumerable<Type10> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}

	}

}

