
namespace FunctionalSharp.DiscriminatedUnions
{
	using System;
	using System.Collections.Generic;


	/// <summary>
	/// Represents a list of Discriminated unions. Using this list you can add items without having to specify the union type.
	/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
	[Serializable]
	public class DiscriminatedUnionList<Type1, Type2> : List<DiscriminatedUnion<Type1, Type2>>
	{
        /// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="item"></param>
		public void Add(Type1 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type2 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		public DiscriminatedUnionList<Type1, Type2, TypeToMerge> Merge<TypeToMerge>(IEnumerable<TypeToMerge> toMerge)
		{
			var result = new DiscriminatedUnionList<Type1, Type2, TypeToMerge>();
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
	/// Represents a list of Discriminated unions. Using this list you can add items without having to specify the union type.
	/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
	[Serializable]
	public class DiscriminatedUnionList<Type1, Type2, Type3> : List<DiscriminatedUnion<Type1, Type2, Type3>>
	{
        /// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="item"></param>
		public void Add(Type1 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type2 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type3 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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

	/// <summary>
	/// Represents a list of Discriminated unions. Using this list you can add items without having to specify the union type.
	/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
	[Serializable]
	public class DiscriminatedUnionList<Type1, Type2, Type3, Type4> : List<DiscriminatedUnion<Type1, Type2, Type3, Type4>>
	{
        /// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="item"></param>
		public void Add(Type1 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type2 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type3 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type4 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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

	/// <summary>
	/// Represents a list of Discriminated unions. Using this list you can add items without having to specify the union type.
	/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
	[Serializable]
	public class DiscriminatedUnionList<Type1, Type2, Type3, Type4, Type5> : List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>>
	{
        /// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="item"></param>
		public void Add(Type1 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type2 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type3 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type4 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type5 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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

	/// <summary>
	/// Represents a list of Discriminated unions. Using this list you can add items without having to specify the union type.
	/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
        /// <typeparam name="Type6">Type6</typeparam>
	[Serializable]
	public class DiscriminatedUnionList<Type1, Type2, Type3, Type4, Type5, Type6> : List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>>
	{
        /// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="item"></param>
		public void Add(Type1 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type2 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type3 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type4 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type5 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type6 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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

	/// <summary>
	/// Represents a list of Discriminated unions. Using this list you can add items without having to specify the union type.
	/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
        /// <typeparam name="Type6">Type6</typeparam>
        /// <typeparam name="Type7">Type7</typeparam>
	[Serializable]
	public class DiscriminatedUnionList<Type1, Type2, Type3, Type4, Type5, Type6, Type7> : List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>>
	{
        /// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="item"></param>
		public void Add(Type1 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type2 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type3 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type4 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type5 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type6 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type7 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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

	/// <summary>
	/// Represents a list of Discriminated unions. Using this list you can add items without having to specify the union type.
	/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
        /// <typeparam name="Type6">Type6</typeparam>
        /// <typeparam name="Type7">Type7</typeparam>
        /// <typeparam name="Type8">Type8</typeparam>
	[Serializable]
	public class DiscriminatedUnionList<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8> : List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>>
	{
        /// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="item"></param>
		public void Add(Type1 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type2 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type3 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type4 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type5 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type6 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type7 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type8 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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

	/// <summary>
	/// Represents a list of Discriminated unions. Using this list you can add items without having to specify the union type.
	/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
        /// <typeparam name="Type6">Type6</typeparam>
        /// <typeparam name="Type7">Type7</typeparam>
        /// <typeparam name="Type8">Type8</typeparam>
        /// <typeparam name="Type9">Type9</typeparam>
	[Serializable]
	public class DiscriminatedUnionList<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9> : List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>>
	{
        /// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="item"></param>
		public void Add(Type1 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type2 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type3 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type4 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type5 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type6 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type7 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type8 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type9 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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

	/// <summary>
	/// Represents a list of Discriminated unions. Using this list you can add items without having to specify the union type.
	/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
        /// <typeparam name="Type6">Type6</typeparam>
        /// <typeparam name="Type7">Type7</typeparam>
        /// <typeparam name="Type8">Type8</typeparam>
        /// <typeparam name="Type9">Type9</typeparam>
        /// <typeparam name="Type10">Type10</typeparam>
	[Serializable]
	public class DiscriminatedUnionList<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10> : List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>>
	{
        /// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="item"></param>
		public void Add(Type1 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type2 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type3 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type4 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type5 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type6 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type7 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type8 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type9 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
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
		/// <param name="item"></param>
		public void Add(Type10 item)
		{
			this.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(item));
		}

		/// <summary>
		/// Adds the object to the end of the DiscriminatedUnionList
		/// </summary>
		/// <param name="collectionToAdd"></param>
		public void AddRange(IEnumerable<Type10> collectionToAdd)
		{
			foreach (var item in collectionToAdd)
			{
				this.Add(item);
			}
		}

	}

}

