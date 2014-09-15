






namespace FunctionalSharp.PatternMatching
{
    using FunctionalSharp.DiscriminatedUnions;
    using System;
	using System.Linq;
    using System.Collections.Generic;


    public class DiscriminatedPatternMatch<T, TResult1>
    {
        protected Func<int> numberOfElements;
        internal List<DiscriminatedPatternMatchCase<T, TResult1>> result1Patterns = new List<DiscriminatedPatternMatchCase<T, TResult1>>();
        protected IEnumerable<T> values;
		
		public DiscriminatedPatternMatch(IEnumerable<T> values, Func<T, bool> pattern, Func<T, TResult1> resultFunction)
        {
            this.values = values;
            this.result1Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult1>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
        }

		private int CountAllResultPatterns()
		{
			return result1Patterns.Count;
		}

		
        public DiscriminatedPatternMatch<T, TResult1> With(Func<T, bool> pattern, TResult1 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1> With(T equalObject, TResult1 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1> With(Func<T, bool> pattern, Func<T, TResult1> resultFunction)
        {
            this.result1Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult1>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
		public IEnumerable<DiscriminatedUnion<TResult1, TResult2>> Else<TResult2>(Func<T, TResult2> elseResult)
        {
            foreach (var value in values)
            {
			    for (int i = 0; i < CountAllResultPatterns(); i++)
                {
                    if(FindMatchForNumber(result1Patterns, i, value, var match))
                    {
                        yield return new DiscriminatedUnion<TResult1, TResult2>(match.Value(value));
                    }
                    else
                    {
                        yield return new DiscriminatedUnion<TResult1, TResult2>(result(elseResult));
                    }
                }

                //var match = matches.FirstOrDefault(matchItem => matchItem.Condition(value));
                //if (match != null)
                //{
                //    yield return match.Value(value);
                //}
                //else
                //{
                //    yield return result(value);
                //}
            }
        }

		private bool FindMatchForNumber<TResult>(List<DiscriminatedPatternMatchCase<T, TResult>> list, int number, T value, out TResult resultValue)
		{
			var discriminatedPatternMatchCase = list.Where(pattern => pattern.Order == number && pattern.Condition(value)).SingleOrDefault();
			if(discriminatedPatternMatchCase != null)
			{
				resultValue = discriminatedPatternMatchCase.Value(value);
			}
			else
            {
                resultValue = default(T);
            }
			return discriminatedPatternMatchCase != null;
		}

        public IEnumerable<DiscriminatedUnion<TResult1, TResult2>> Else<TResult2>(TResult2 result)
        {
            return Else(_ => result);
        }

        public IEnumerable<DiscriminatedUnion<TResult1, TResult2>> ElseException()
        {
            return ElseException(new Exception("No Pattern matched"));
        }

        public IEnumerable<DiscriminatedUnion<TResult1, TResult2>> ElseException(Exception exception)
        {
            return Else(_ => { throw exception; });
        }

		        public DiscriminatedPatternMatch<T, TResult1, TResult2> With<TResult2>(Func<T, bool> pattern, TResult2 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2> With<TResult2>(Func<T, bool> pattern, Func<T, TResult2> resultFunction)
        {
            return new DiscriminatedPatternMatch<T, TResult1, TResult2>();
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2> With<TResult2>(T equalObject, TResult2 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }
		
	}

    public class DiscriminatedPatternMatch<T, TResult1, TResult2>
    {
        protected Func<int> numberOfElements;
        internal List<DiscriminatedPatternMatchCase<T, TResult1>> result1Patterns = new List<DiscriminatedPatternMatchCase<T, TResult1>>();
        internal List<DiscriminatedPatternMatchCase<T, TResult2>> result2Patterns = new List<DiscriminatedPatternMatchCase<T, TResult2>>();
        protected IEnumerable<T> values;
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2> With(Func<T, bool> pattern, TResult1 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2> With(T equalObject, TResult1 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2> With(Func<T, bool> pattern, Func<T, TResult1> resultFunction)
        {
            this.result1Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult1>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2> With(Func<T, bool> pattern, TResult2 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2> With(T equalObject, TResult2 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2> With(Func<T, bool> pattern, Func<T, TResult2> resultFunction)
        {
            this.result2Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult2>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
		public IEnumerable<DiscriminatedUnion<TResult1, TResult2, TResult3>> Else<TResult3>(Func<T, TResult3> elseResult)
        {
            foreach (var value in values)
            {
			    for (int i = 0; i < CountAllResultPatterns(); i++)
                {
                    if(FindMatchForNumber(result1Patterns, i, value, var match))
                    {
                        yield return new DiscriminatedUnion<TResult1, TResult2>(match.Value(value));
                    }
                    else
                    {
                        yield return new DiscriminatedUnion<TResult1, TResult2>(result(elseResult));
                    }
                }

                //var match = matches.FirstOrDefault(matchItem => matchItem.Condition(value));
                //if (match != null)
                //{
                //    yield return match.Value(value);
                //}
                //else
                //{
                //    yield return result(value);
                //}
            }
        }

		private bool FindMatchForNumber<TResult>(List<DiscriminatedPatternMatchCase<T, TResult>> list, int number, T value, out TResult resultValue)
		{
			var discriminatedPatternMatchCase = list.Where(pattern => pattern.Order == number && pattern.Condition(value)).SingleOrDefault();
			if(discriminatedPatternMatchCase != null)
			{
				resultValue = discriminatedPatternMatchCase.Value(value);
			}
			else
            {
                resultValue = default(T);
            }
			return discriminatedPatternMatchCase != null;
		}

        public IEnumerable<DiscriminatedUnion<TResult1, TResult2, TResult3>> Else<TResult3>(TResult3 result)
        {
            return Else(_ => result);
        }

        public IEnumerable<DiscriminatedUnion<TResult1, TResult2, TResult3>> ElseException()
        {
            return ElseException(new Exception("No Pattern matched"));
        }

        public IEnumerable<DiscriminatedUnion<TResult1, TResult2, TResult3>> ElseException(Exception exception)
        {
            return Else(_ => { throw exception; });
        }

		        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3> With<TResult3>(Func<T, bool> pattern, TResult3 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3> With<TResult3>(Func<T, bool> pattern, Func<T, TResult3> resultFunction)
        {
            return new DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3>();
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3> With<TResult3>(T equalObject, TResult3 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }
		
	}

    public class DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3>
    {
        protected Func<int> numberOfElements;
        internal List<DiscriminatedPatternMatchCase<T, TResult1>> result1Patterns = new List<DiscriminatedPatternMatchCase<T, TResult1>>();
        internal List<DiscriminatedPatternMatchCase<T, TResult2>> result2Patterns = new List<DiscriminatedPatternMatchCase<T, TResult2>>();
        internal List<DiscriminatedPatternMatchCase<T, TResult3>> result3Patterns = new List<DiscriminatedPatternMatchCase<T, TResult3>>();
        protected IEnumerable<T> values;
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3> With(Func<T, bool> pattern, TResult1 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3> With(T equalObject, TResult1 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3> With(Func<T, bool> pattern, Func<T, TResult1> resultFunction)
        {
            this.result1Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult1>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3> With(Func<T, bool> pattern, TResult2 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3> With(T equalObject, TResult2 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3> With(Func<T, bool> pattern, Func<T, TResult2> resultFunction)
        {
            this.result2Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult2>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3> With(Func<T, bool> pattern, TResult3 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3> With(T equalObject, TResult3 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3> With(Func<T, bool> pattern, Func<T, TResult3> resultFunction)
        {
            this.result3Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult3>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
		public IEnumerable<DiscriminatedUnion<TResult1, TResult2, TResult3, TResult4>> Else<TResult4>(Func<T, TResult4> elseResult)
        {
            foreach (var value in values)
            {
			    for (int i = 0; i < CountAllResultPatterns(); i++)
                {
                    if(FindMatchForNumber(result1Patterns, i, value, var match))
                    {
                        yield return new DiscriminatedUnion<TResult1, TResult2>(match.Value(value));
                    }
                    else
                    {
                        yield return new DiscriminatedUnion<TResult1, TResult2>(result(elseResult));
                    }
                }

                //var match = matches.FirstOrDefault(matchItem => matchItem.Condition(value));
                //if (match != null)
                //{
                //    yield return match.Value(value);
                //}
                //else
                //{
                //    yield return result(value);
                //}
            }
        }

		private bool FindMatchForNumber<TResult>(List<DiscriminatedPatternMatchCase<T, TResult>> list, int number, T value, out TResult resultValue)
		{
			var discriminatedPatternMatchCase = list.Where(pattern => pattern.Order == number && pattern.Condition(value)).SingleOrDefault();
			if(discriminatedPatternMatchCase != null)
			{
				resultValue = discriminatedPatternMatchCase.Value(value);
			}
			else
            {
                resultValue = default(T);
            }
			return discriminatedPatternMatchCase != null;
		}

        public IEnumerable<DiscriminatedUnion<TResult1, TResult2, TResult3, TResult4>> Else<TResult4>(TResult4 result)
        {
            return Else(_ => result);
        }

        public IEnumerable<DiscriminatedUnion<TResult1, TResult2, TResult3, TResult4>> ElseException()
        {
            return ElseException(new Exception("No Pattern matched"));
        }

        public IEnumerable<DiscriminatedUnion<TResult1, TResult2, TResult3, TResult4>> ElseException(Exception exception)
        {
            return Else(_ => { throw exception; });
        }

		        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4> With<TResult4>(Func<T, bool> pattern, TResult4 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4> With<TResult4>(Func<T, bool> pattern, Func<T, TResult4> resultFunction)
        {
            return new DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4>();
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4> With<TResult4>(T equalObject, TResult4 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }
		
	}

    public class DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4>
    {
        protected Func<int> numberOfElements;
        internal List<DiscriminatedPatternMatchCase<T, TResult1>> result1Patterns = new List<DiscriminatedPatternMatchCase<T, TResult1>>();
        internal List<DiscriminatedPatternMatchCase<T, TResult2>> result2Patterns = new List<DiscriminatedPatternMatchCase<T, TResult2>>();
        internal List<DiscriminatedPatternMatchCase<T, TResult3>> result3Patterns = new List<DiscriminatedPatternMatchCase<T, TResult3>>();
        internal List<DiscriminatedPatternMatchCase<T, TResult4>> result4Patterns = new List<DiscriminatedPatternMatchCase<T, TResult4>>();
        protected IEnumerable<T> values;
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4> With(Func<T, bool> pattern, TResult1 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4> With(T equalObject, TResult1 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4> With(Func<T, bool> pattern, Func<T, TResult1> resultFunction)
        {
            this.result1Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult1>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4> With(Func<T, bool> pattern, TResult2 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4> With(T equalObject, TResult2 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4> With(Func<T, bool> pattern, Func<T, TResult2> resultFunction)
        {
            this.result2Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult2>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4> With(Func<T, bool> pattern, TResult3 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4> With(T equalObject, TResult3 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4> With(Func<T, bool> pattern, Func<T, TResult3> resultFunction)
        {
            this.result3Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult3>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4> With(Func<T, bool> pattern, TResult4 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4> With(T equalObject, TResult4 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4> With(Func<T, bool> pattern, Func<T, TResult4> resultFunction)
        {
            this.result4Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult4>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
		public IEnumerable<DiscriminatedUnion<TResult1, TResult2, TResult3, TResult4, TResult5>> Else<TResult5>(Func<T, TResult5> elseResult)
        {
            foreach (var value in values)
            {
			    for (int i = 0; i < CountAllResultPatterns(); i++)
                {
                    if(FindMatchForNumber(result1Patterns, i, value, var match))
                    {
                        yield return new DiscriminatedUnion<TResult1, TResult2>(match.Value(value));
                    }
                    else
                    {
                        yield return new DiscriminatedUnion<TResult1, TResult2>(result(elseResult));
                    }
                }

                //var match = matches.FirstOrDefault(matchItem => matchItem.Condition(value));
                //if (match != null)
                //{
                //    yield return match.Value(value);
                //}
                //else
                //{
                //    yield return result(value);
                //}
            }
        }

		private bool FindMatchForNumber<TResult>(List<DiscriminatedPatternMatchCase<T, TResult>> list, int number, T value, out TResult resultValue)
		{
			var discriminatedPatternMatchCase = list.Where(pattern => pattern.Order == number && pattern.Condition(value)).SingleOrDefault();
			if(discriminatedPatternMatchCase != null)
			{
				resultValue = discriminatedPatternMatchCase.Value(value);
			}
			else
            {
                resultValue = default(T);
            }
			return discriminatedPatternMatchCase != null;
		}

        public IEnumerable<DiscriminatedUnion<TResult1, TResult2, TResult3, TResult4, TResult5>> Else<TResult5>(TResult5 result)
        {
            return Else(_ => result);
        }

        public IEnumerable<DiscriminatedUnion<TResult1, TResult2, TResult3, TResult4, TResult5>> ElseException()
        {
            return ElseException(new Exception("No Pattern matched"));
        }

        public IEnumerable<DiscriminatedUnion<TResult1, TResult2, TResult3, TResult4, TResult5>> ElseException(Exception exception)
        {
            return Else(_ => { throw exception; });
        }

		        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5> With<TResult5>(Func<T, bool> pattern, TResult5 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5> With<TResult5>(Func<T, bool> pattern, Func<T, TResult5> resultFunction)
        {
            return new DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5>();
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5> With<TResult5>(T equalObject, TResult5 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }
		
	}

    public class DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5>
    {
        protected Func<int> numberOfElements;
        internal List<DiscriminatedPatternMatchCase<T, TResult1>> result1Patterns = new List<DiscriminatedPatternMatchCase<T, TResult1>>();
        internal List<DiscriminatedPatternMatchCase<T, TResult2>> result2Patterns = new List<DiscriminatedPatternMatchCase<T, TResult2>>();
        internal List<DiscriminatedPatternMatchCase<T, TResult3>> result3Patterns = new List<DiscriminatedPatternMatchCase<T, TResult3>>();
        internal List<DiscriminatedPatternMatchCase<T, TResult4>> result4Patterns = new List<DiscriminatedPatternMatchCase<T, TResult4>>();
        internal List<DiscriminatedPatternMatchCase<T, TResult5>> result5Patterns = new List<DiscriminatedPatternMatchCase<T, TResult5>>();
        protected IEnumerable<T> values;
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5> With(Func<T, bool> pattern, TResult1 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5> With(T equalObject, TResult1 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5> With(Func<T, bool> pattern, Func<T, TResult1> resultFunction)
        {
            this.result1Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult1>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5> With(Func<T, bool> pattern, TResult2 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5> With(T equalObject, TResult2 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5> With(Func<T, bool> pattern, Func<T, TResult2> resultFunction)
        {
            this.result2Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult2>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5> With(Func<T, bool> pattern, TResult3 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5> With(T equalObject, TResult3 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5> With(Func<T, bool> pattern, Func<T, TResult3> resultFunction)
        {
            this.result3Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult3>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5> With(Func<T, bool> pattern, TResult4 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5> With(T equalObject, TResult4 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5> With(Func<T, bool> pattern, Func<T, TResult4> resultFunction)
        {
            this.result4Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult4>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5> With(Func<T, bool> pattern, TResult5 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5> With(T equalObject, TResult5 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5> With(Func<T, bool> pattern, Func<T, TResult5> resultFunction)
        {
            this.result5Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult5>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
		public IEnumerable<DiscriminatedUnion<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>> Else<TResult6>(Func<T, TResult6> elseResult)
        {
            foreach (var value in values)
            {
			    for (int i = 0; i < CountAllResultPatterns(); i++)
                {
                    if(FindMatchForNumber(result1Patterns, i, value, var match))
                    {
                        yield return new DiscriminatedUnion<TResult1, TResult2>(match.Value(value));
                    }
                    else
                    {
                        yield return new DiscriminatedUnion<TResult1, TResult2>(result(elseResult));
                    }
                }

                //var match = matches.FirstOrDefault(matchItem => matchItem.Condition(value));
                //if (match != null)
                //{
                //    yield return match.Value(value);
                //}
                //else
                //{
                //    yield return result(value);
                //}
            }
        }

		private bool FindMatchForNumber<TResult>(List<DiscriminatedPatternMatchCase<T, TResult>> list, int number, T value, out TResult resultValue)
		{
			var discriminatedPatternMatchCase = list.Where(pattern => pattern.Order == number && pattern.Condition(value)).SingleOrDefault();
			if(discriminatedPatternMatchCase != null)
			{
				resultValue = discriminatedPatternMatchCase.Value(value);
			}
			else
            {
                resultValue = default(T);
            }
			return discriminatedPatternMatchCase != null;
		}

        public IEnumerable<DiscriminatedUnion<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>> Else<TResult6>(TResult6 result)
        {
            return Else(_ => result);
        }

        public IEnumerable<DiscriminatedUnion<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>> ElseException()
        {
            return ElseException(new Exception("No Pattern matched"));
        }

        public IEnumerable<DiscriminatedUnion<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>> ElseException(Exception exception)
        {
            return Else(_ => { throw exception; });
        }

		        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6> With<TResult6>(Func<T, bool> pattern, TResult6 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6> With<TResult6>(Func<T, bool> pattern, Func<T, TResult6> resultFunction)
        {
            return new DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>();
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6> With<TResult6>(T equalObject, TResult6 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }
		
	}

    public class DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>
    {
        protected Func<int> numberOfElements;
        internal List<DiscriminatedPatternMatchCase<T, TResult1>> result1Patterns = new List<DiscriminatedPatternMatchCase<T, TResult1>>();
        internal List<DiscriminatedPatternMatchCase<T, TResult2>> result2Patterns = new List<DiscriminatedPatternMatchCase<T, TResult2>>();
        internal List<DiscriminatedPatternMatchCase<T, TResult3>> result3Patterns = new List<DiscriminatedPatternMatchCase<T, TResult3>>();
        internal List<DiscriminatedPatternMatchCase<T, TResult4>> result4Patterns = new List<DiscriminatedPatternMatchCase<T, TResult4>>();
        internal List<DiscriminatedPatternMatchCase<T, TResult5>> result5Patterns = new List<DiscriminatedPatternMatchCase<T, TResult5>>();
        internal List<DiscriminatedPatternMatchCase<T, TResult6>> result6Patterns = new List<DiscriminatedPatternMatchCase<T, TResult6>>();
        protected IEnumerable<T> values;
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6> With(Func<T, bool> pattern, TResult1 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6> With(T equalObject, TResult1 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6> With(Func<T, bool> pattern, Func<T, TResult1> resultFunction)
        {
            this.result1Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult1>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6> With(Func<T, bool> pattern, TResult2 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6> With(T equalObject, TResult2 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6> With(Func<T, bool> pattern, Func<T, TResult2> resultFunction)
        {
            this.result2Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult2>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6> With(Func<T, bool> pattern, TResult3 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6> With(T equalObject, TResult3 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6> With(Func<T, bool> pattern, Func<T, TResult3> resultFunction)
        {
            this.result3Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult3>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6> With(Func<T, bool> pattern, TResult4 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6> With(T equalObject, TResult4 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6> With(Func<T, bool> pattern, Func<T, TResult4> resultFunction)
        {
            this.result4Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult4>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6> With(Func<T, bool> pattern, TResult5 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6> With(T equalObject, TResult5 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6> With(Func<T, bool> pattern, Func<T, TResult5> resultFunction)
        {
            this.result5Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult5>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6> With(Func<T, bool> pattern, TResult6 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6> With(T equalObject, TResult6 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6> With(Func<T, bool> pattern, Func<T, TResult6> resultFunction)
        {
            this.result6Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult6>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
		public IEnumerable<DiscriminatedUnion<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>> Else<TResult7>(Func<T, TResult7> elseResult)
        {
            foreach (var value in values)
            {
			    for (int i = 0; i < CountAllResultPatterns(); i++)
                {
                    if(FindMatchForNumber(result1Patterns, i, value, var match))
                    {
                        yield return new DiscriminatedUnion<TResult1, TResult2>(match.Value(value));
                    }
                    else
                    {
                        yield return new DiscriminatedUnion<TResult1, TResult2>(result(elseResult));
                    }
                }

                //var match = matches.FirstOrDefault(matchItem => matchItem.Condition(value));
                //if (match != null)
                //{
                //    yield return match.Value(value);
                //}
                //else
                //{
                //    yield return result(value);
                //}
            }
        }

		private bool FindMatchForNumber<TResult>(List<DiscriminatedPatternMatchCase<T, TResult>> list, int number, T value, out TResult resultValue)
		{
			var discriminatedPatternMatchCase = list.Where(pattern => pattern.Order == number && pattern.Condition(value)).SingleOrDefault();
			if(discriminatedPatternMatchCase != null)
			{
				resultValue = discriminatedPatternMatchCase.Value(value);
			}
			else
            {
                resultValue = default(T);
            }
			return discriminatedPatternMatchCase != null;
		}

        public IEnumerable<DiscriminatedUnion<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>> Else<TResult7>(TResult7 result)
        {
            return Else(_ => result);
        }

        public IEnumerable<DiscriminatedUnion<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>> ElseException()
        {
            return ElseException(new Exception("No Pattern matched"));
        }

        public IEnumerable<DiscriminatedUnion<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>> ElseException(Exception exception)
        {
            return Else(_ => { throw exception; });
        }

		        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7> With<TResult7>(Func<T, bool> pattern, TResult7 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7> With<TResult7>(Func<T, bool> pattern, Func<T, TResult7> resultFunction)
        {
            return new DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>();
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7> With<TResult7>(T equalObject, TResult7 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }
		
	}

    public class DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>
    {
        protected Func<int> numberOfElements;
        internal List<DiscriminatedPatternMatchCase<T, TResult1>> result1Patterns = new List<DiscriminatedPatternMatchCase<T, TResult1>>();
        internal List<DiscriminatedPatternMatchCase<T, TResult2>> result2Patterns = new List<DiscriminatedPatternMatchCase<T, TResult2>>();
        internal List<DiscriminatedPatternMatchCase<T, TResult3>> result3Patterns = new List<DiscriminatedPatternMatchCase<T, TResult3>>();
        internal List<DiscriminatedPatternMatchCase<T, TResult4>> result4Patterns = new List<DiscriminatedPatternMatchCase<T, TResult4>>();
        internal List<DiscriminatedPatternMatchCase<T, TResult5>> result5Patterns = new List<DiscriminatedPatternMatchCase<T, TResult5>>();
        internal List<DiscriminatedPatternMatchCase<T, TResult6>> result6Patterns = new List<DiscriminatedPatternMatchCase<T, TResult6>>();
        internal List<DiscriminatedPatternMatchCase<T, TResult7>> result7Patterns = new List<DiscriminatedPatternMatchCase<T, TResult7>>();
        protected IEnumerable<T> values;
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7> With(Func<T, bool> pattern, TResult1 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7> With(T equalObject, TResult1 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7> With(Func<T, bool> pattern, Func<T, TResult1> resultFunction)
        {
            this.result1Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult1>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7> With(Func<T, bool> pattern, TResult2 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7> With(T equalObject, TResult2 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7> With(Func<T, bool> pattern, Func<T, TResult2> resultFunction)
        {
            this.result2Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult2>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7> With(Func<T, bool> pattern, TResult3 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7> With(T equalObject, TResult3 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7> With(Func<T, bool> pattern, Func<T, TResult3> resultFunction)
        {
            this.result3Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult3>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7> With(Func<T, bool> pattern, TResult4 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7> With(T equalObject, TResult4 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7> With(Func<T, bool> pattern, Func<T, TResult4> resultFunction)
        {
            this.result4Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult4>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7> With(Func<T, bool> pattern, TResult5 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7> With(T equalObject, TResult5 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7> With(Func<T, bool> pattern, Func<T, TResult5> resultFunction)
        {
            this.result5Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult5>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7> With(Func<T, bool> pattern, TResult6 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7> With(T equalObject, TResult6 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7> With(Func<T, bool> pattern, Func<T, TResult6> resultFunction)
        {
            this.result6Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult6>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7> With(Func<T, bool> pattern, TResult7 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7> With(T equalObject, TResult7 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7> With(Func<T, bool> pattern, Func<T, TResult7> resultFunction)
        {
            this.result7Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult7>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
		public IEnumerable<DiscriminatedUnion<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8>> Else<TResult8>(Func<T, TResult8> elseResult)
        {
            foreach (var value in values)
            {
			    for (int i = 0; i < CountAllResultPatterns(); i++)
                {
                    if(FindMatchForNumber(result1Patterns, i, value, var match))
                    {
                        yield return new DiscriminatedUnion<TResult1, TResult2>(match.Value(value));
                    }
                    else
                    {
                        yield return new DiscriminatedUnion<TResult1, TResult2>(result(elseResult));
                    }
                }

                //var match = matches.FirstOrDefault(matchItem => matchItem.Condition(value));
                //if (match != null)
                //{
                //    yield return match.Value(value);
                //}
                //else
                //{
                //    yield return result(value);
                //}
            }
        }

		private bool FindMatchForNumber<TResult>(List<DiscriminatedPatternMatchCase<T, TResult>> list, int number, T value, out TResult resultValue)
		{
			var discriminatedPatternMatchCase = list.Where(pattern => pattern.Order == number && pattern.Condition(value)).SingleOrDefault();
			if(discriminatedPatternMatchCase != null)
			{
				resultValue = discriminatedPatternMatchCase.Value(value);
			}
			else
            {
                resultValue = default(T);
            }
			return discriminatedPatternMatchCase != null;
		}

        public IEnumerable<DiscriminatedUnion<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8>> Else<TResult8>(TResult8 result)
        {
            return Else(_ => result);
        }

        public IEnumerable<DiscriminatedUnion<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8>> ElseException()
        {
            return ElseException(new Exception("No Pattern matched"));
        }

        public IEnumerable<DiscriminatedUnion<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8>> ElseException(Exception exception)
        {
            return Else(_ => { throw exception; });
        }

		        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8> With<TResult8>(Func<T, bool> pattern, TResult8 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8> With<TResult8>(Func<T, bool> pattern, Func<T, TResult8> resultFunction)
        {
            return new DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8>();
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8> With<TResult8>(T equalObject, TResult8 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }
		
	}

    public class DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8>
    {
        protected Func<int> numberOfElements;
        internal List<DiscriminatedPatternMatchCase<T, TResult1>> result1Patterns = new List<DiscriminatedPatternMatchCase<T, TResult1>>();
        internal List<DiscriminatedPatternMatchCase<T, TResult2>> result2Patterns = new List<DiscriminatedPatternMatchCase<T, TResult2>>();
        internal List<DiscriminatedPatternMatchCase<T, TResult3>> result3Patterns = new List<DiscriminatedPatternMatchCase<T, TResult3>>();
        internal List<DiscriminatedPatternMatchCase<T, TResult4>> result4Patterns = new List<DiscriminatedPatternMatchCase<T, TResult4>>();
        internal List<DiscriminatedPatternMatchCase<T, TResult5>> result5Patterns = new List<DiscriminatedPatternMatchCase<T, TResult5>>();
        internal List<DiscriminatedPatternMatchCase<T, TResult6>> result6Patterns = new List<DiscriminatedPatternMatchCase<T, TResult6>>();
        internal List<DiscriminatedPatternMatchCase<T, TResult7>> result7Patterns = new List<DiscriminatedPatternMatchCase<T, TResult7>>();
        internal List<DiscriminatedPatternMatchCase<T, TResult8>> result8Patterns = new List<DiscriminatedPatternMatchCase<T, TResult8>>();
        protected IEnumerable<T> values;
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8> With(Func<T, bool> pattern, TResult1 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8> With(T equalObject, TResult1 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8> With(Func<T, bool> pattern, Func<T, TResult1> resultFunction)
        {
            this.result1Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult1>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8> With(Func<T, bool> pattern, TResult2 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8> With(T equalObject, TResult2 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8> With(Func<T, bool> pattern, Func<T, TResult2> resultFunction)
        {
            this.result2Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult2>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8> With(Func<T, bool> pattern, TResult3 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8> With(T equalObject, TResult3 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8> With(Func<T, bool> pattern, Func<T, TResult3> resultFunction)
        {
            this.result3Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult3>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8> With(Func<T, bool> pattern, TResult4 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8> With(T equalObject, TResult4 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8> With(Func<T, bool> pattern, Func<T, TResult4> resultFunction)
        {
            this.result4Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult4>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8> With(Func<T, bool> pattern, TResult5 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8> With(T equalObject, TResult5 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8> With(Func<T, bool> pattern, Func<T, TResult5> resultFunction)
        {
            this.result5Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult5>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8> With(Func<T, bool> pattern, TResult6 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8> With(T equalObject, TResult6 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8> With(Func<T, bool> pattern, Func<T, TResult6> resultFunction)
        {
            this.result6Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult6>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8> With(Func<T, bool> pattern, TResult7 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8> With(T equalObject, TResult7 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8> With(Func<T, bool> pattern, Func<T, TResult7> resultFunction)
        {
            this.result7Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult7>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8> With(Func<T, bool> pattern, TResult8 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8> With(T equalObject, TResult8 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8> With(Func<T, bool> pattern, Func<T, TResult8> resultFunction)
        {
            this.result8Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult8>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
		public IEnumerable<DiscriminatedUnion<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9>> Else<TResult9>(Func<T, TResult9> elseResult)
        {
            foreach (var value in values)
            {
			    for (int i = 0; i < CountAllResultPatterns(); i++)
                {
                    if(FindMatchForNumber(result1Patterns, i, value, var match))
                    {
                        yield return new DiscriminatedUnion<TResult1, TResult2>(match.Value(value));
                    }
                    else
                    {
                        yield return new DiscriminatedUnion<TResult1, TResult2>(result(elseResult));
                    }
                }

                //var match = matches.FirstOrDefault(matchItem => matchItem.Condition(value));
                //if (match != null)
                //{
                //    yield return match.Value(value);
                //}
                //else
                //{
                //    yield return result(value);
                //}
            }
        }

		private bool FindMatchForNumber<TResult>(List<DiscriminatedPatternMatchCase<T, TResult>> list, int number, T value, out TResult resultValue)
		{
			var discriminatedPatternMatchCase = list.Where(pattern => pattern.Order == number && pattern.Condition(value)).SingleOrDefault();
			if(discriminatedPatternMatchCase != null)
			{
				resultValue = discriminatedPatternMatchCase.Value(value);
			}
			else
            {
                resultValue = default(T);
            }
			return discriminatedPatternMatchCase != null;
		}

        public IEnumerable<DiscriminatedUnion<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9>> Else<TResult9>(TResult9 result)
        {
            return Else(_ => result);
        }

        public IEnumerable<DiscriminatedUnion<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9>> ElseException()
        {
            return ElseException(new Exception("No Pattern matched"));
        }

        public IEnumerable<DiscriminatedUnion<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9>> ElseException(Exception exception)
        {
            return Else(_ => { throw exception; });
        }

		        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9> With<TResult9>(Func<T, bool> pattern, TResult9 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9> With<TResult9>(Func<T, bool> pattern, Func<T, TResult9> resultFunction)
        {
            return new DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9>();
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9> With<TResult9>(T equalObject, TResult9 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }
		
	}

    public class DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9>
    {
        protected Func<int> numberOfElements;
        internal List<DiscriminatedPatternMatchCase<T, TResult1>> result1Patterns = new List<DiscriminatedPatternMatchCase<T, TResult1>>();
        internal List<DiscriminatedPatternMatchCase<T, TResult2>> result2Patterns = new List<DiscriminatedPatternMatchCase<T, TResult2>>();
        internal List<DiscriminatedPatternMatchCase<T, TResult3>> result3Patterns = new List<DiscriminatedPatternMatchCase<T, TResult3>>();
        internal List<DiscriminatedPatternMatchCase<T, TResult4>> result4Patterns = new List<DiscriminatedPatternMatchCase<T, TResult4>>();
        internal List<DiscriminatedPatternMatchCase<T, TResult5>> result5Patterns = new List<DiscriminatedPatternMatchCase<T, TResult5>>();
        internal List<DiscriminatedPatternMatchCase<T, TResult6>> result6Patterns = new List<DiscriminatedPatternMatchCase<T, TResult6>>();
        internal List<DiscriminatedPatternMatchCase<T, TResult7>> result7Patterns = new List<DiscriminatedPatternMatchCase<T, TResult7>>();
        internal List<DiscriminatedPatternMatchCase<T, TResult8>> result8Patterns = new List<DiscriminatedPatternMatchCase<T, TResult8>>();
        internal List<DiscriminatedPatternMatchCase<T, TResult9>> result9Patterns = new List<DiscriminatedPatternMatchCase<T, TResult9>>();
        protected IEnumerable<T> values;
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9> With(Func<T, bool> pattern, TResult1 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9> With(T equalObject, TResult1 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9> With(Func<T, bool> pattern, Func<T, TResult1> resultFunction)
        {
            this.result1Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult1>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9> With(Func<T, bool> pattern, TResult2 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9> With(T equalObject, TResult2 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9> With(Func<T, bool> pattern, Func<T, TResult2> resultFunction)
        {
            this.result2Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult2>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9> With(Func<T, bool> pattern, TResult3 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9> With(T equalObject, TResult3 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9> With(Func<T, bool> pattern, Func<T, TResult3> resultFunction)
        {
            this.result3Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult3>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9> With(Func<T, bool> pattern, TResult4 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9> With(T equalObject, TResult4 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9> With(Func<T, bool> pattern, Func<T, TResult4> resultFunction)
        {
            this.result4Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult4>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9> With(Func<T, bool> pattern, TResult5 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9> With(T equalObject, TResult5 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9> With(Func<T, bool> pattern, Func<T, TResult5> resultFunction)
        {
            this.result5Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult5>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9> With(Func<T, bool> pattern, TResult6 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9> With(T equalObject, TResult6 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9> With(Func<T, bool> pattern, Func<T, TResult6> resultFunction)
        {
            this.result6Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult6>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9> With(Func<T, bool> pattern, TResult7 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9> With(T equalObject, TResult7 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9> With(Func<T, bool> pattern, Func<T, TResult7> resultFunction)
        {
            this.result7Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult7>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9> With(Func<T, bool> pattern, TResult8 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9> With(T equalObject, TResult8 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9> With(Func<T, bool> pattern, Func<T, TResult8> resultFunction)
        {
            this.result8Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult8>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9> With(Func<T, bool> pattern, TResult9 resultValue)
        {
            return With(pattern, _ => resultValue);
        }

		public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9> With(T equalObject, TResult9 resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9> With(Func<T, bool> pattern, Func<T, TResult9> resultFunction)
        {
            this.result9Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult9>
            {
                Condition = pattern,
                Order = CountAllResultPatterns(),
                Value = resultFunction
            });
            return this;
        }
		
		public IEnumerable<DiscriminatedUnion<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10>> Else<TResult10>(Func<T, TResult10> elseResult)
        {
            foreach (var value in values)
            {
			    for (int i = 0; i < CountAllResultPatterns(); i++)
                {
                    if(FindMatchForNumber(result1Patterns, i, value, var match))
                    {
                        yield return new DiscriminatedUnion<TResult1, TResult2>(match.Value(value));
                    }
                    else
                    {
                        yield return new DiscriminatedUnion<TResult1, TResult2>(result(elseResult));
                    }
                }

                //var match = matches.FirstOrDefault(matchItem => matchItem.Condition(value));
                //if (match != null)
                //{
                //    yield return match.Value(value);
                //}
                //else
                //{
                //    yield return result(value);
                //}
            }
        }

		private bool FindMatchForNumber<TResult>(List<DiscriminatedPatternMatchCase<T, TResult>> list, int number, T value, out TResult resultValue)
		{
			var discriminatedPatternMatchCase = list.Where(pattern => pattern.Order == number && pattern.Condition(value)).SingleOrDefault();
			if(discriminatedPatternMatchCase != null)
			{
				resultValue = discriminatedPatternMatchCase.Value(value);
			}
			else
            {
                resultValue = default(T);
            }
			return discriminatedPatternMatchCase != null;
		}

        public IEnumerable<DiscriminatedUnion<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10>> Else<TResult10>(TResult10 result)
        {
            return Else(_ => result);
        }

        public IEnumerable<DiscriminatedUnion<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10>> ElseException()
        {
            return ElseException(new Exception("No Pattern matched"));
        }

        public IEnumerable<DiscriminatedUnion<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10>> ElseException(Exception exception)
        {
            return Else(_ => { throw exception; });
        }

		
	}

}

