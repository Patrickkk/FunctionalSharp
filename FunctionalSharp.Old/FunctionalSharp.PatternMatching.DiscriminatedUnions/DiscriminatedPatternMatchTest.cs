//using FunctionalSharp.DiscriminatedUnions;
//using System;
//using System.Collections.Generic;

//namespace FunctionalSharp.PatternMatching
//{
//    public class DiscriminatedPatternMatch<T, TResult1>
//    {
//        protected Func<int> numberOfElements;
//        protected int numberOfPatterns = 1;
//        internal List<DiscriminatedPatternMatchCase<T, TResult1>> result1Patterns = new List<DiscriminatedPatternMatchCase<T, TResult1>>();
//        protected IEnumerable<T> values;

//        public DiscriminatedPatternMatch(IEnumerable<T> values, Func<T, bool> pattern, Func<T, TResult1> resultFunction)
//        {
//            this.numberOfElements = () => result1Patterns.Count;
//            this.values = values;
//            this.result1Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult1>
//            {
//                Condition = pattern,
//                Order = result1Patterns.Count,
//                Value = resultFunction
//            });
//        }

//        public DiscriminatedPatternMatch<T, TResult1> With(Func<T, bool> pattern, TResult1 resultValue)
//        {
//            return With(pattern, _ => resultValue);
//        }

//        public DiscriminatedPatternMatch<T, TResult1> With(Func<T, bool> pattern, Func<T, TResult1> resultFunction)
//        {
//            this.result1Patterns.Add(new DiscriminatedPatternMatchCase<T, TResult1>
//            {
//                Condition = pattern,
//                Order = result1Patterns.Count,
//                Value = resultFunction
//            });
//            return this;
//        }

//        public DiscriminatedPatternMatch<T, TResult1> With(T equalObject, TResult1 resultValue)
//        {
//            return With(value => value.Equals(equalObject), _ => resultValue);
//        }

//        public DiscriminatedPatternMatch<T, TResult1, TResult2> With<TResult2>(Func<T, bool> pattern, TResult2 resultValue)
//        {
//            return With(pattern, _ => resultValue);
//        }

//        public DiscriminatedPatternMatch<T, TResult1, TResult2> With<TResult2>(Func<T, bool> pattern, Func<T, TResult2> resultFunction)
//        {
//            return new DiscriminatedPatternMatch<T, TResult1, TResult2>();
//        }

//        public DiscriminatedPatternMatch<T, TResult1, TResult2> With<TResult2>(T equalObject, TResult2 resultValue)
//        {
//            return With(value => value.Equals(equalObject), _ => resultValue);
//        }
//    }

//    public class DiscriminatedPatternMatch<T, TResult1, TResult2>
//    {
//        public IEnumerable<DiscriminatedUnion<TResult1, TResult2, TElse>> Else<TElse>(TElse elseValue)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}