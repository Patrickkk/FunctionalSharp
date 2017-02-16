
var camelCaseTokenizer = function (obj) {
    var previous = '';
    return obj.toString().trim().split(/[\s\-]+|(?=[A-Z])/).reduce(function(acc, cur) {
        var current = cur.toLowerCase();
        if(acc.length === 0) {
            previous = current;
            return acc.concat(current);
        }
        previous = previous.concat(current);
        return acc.concat([current, previous]);
    }, []);
}
lunr.tokenizer.registerFunction(camelCaseTokenizer, 'camelCaseTokenizer')
var searchModule = function() {
    var idMap = [];
    function y(e) { 
        idMap.push(e); 
    }
    var idx = lunr(function() {
        this.field('title', { boost: 10 });
        this.field('content');
        this.field('description', { boost: 5 });
        this.field('tags', { boost: 50 });
        this.ref('id');
        this.tokenizer(camelCaseTokenizer);

        this.pipeline.remove(lunr.stopWordFilter);
        this.pipeline.remove(lunr.stemmer);
    });
    function a(e) { 
        idx.add(e); 
    }

    a({
        id:0,
        title:"DiscriminatedUnion",
        content:"DiscriminatedUnion",
        description:'',
        tags:''
    });

    a({
        id:1,
        title:"DiscriminatedUnion",
        content:"DiscriminatedUnion",
        description:'',
        tags:''
    });

    a({
        id:2,
        title:"DiscriminatedUnionWithBase",
        content:"DiscriminatedUnionWithBase",
        description:'',
        tags:''
    });

    a({
        id:3,
        title:"LinqExtensions",
        content:"LinqExtensions",
        description:'',
        tags:''
    });

    a({
        id:4,
        title:"DiscriminatedUnion",
        content:"DiscriminatedUnion",
        description:'',
        tags:''
    });

    a({
        id:5,
        title:"PatternMatchContext",
        content:"PatternMatchContext",
        description:'',
        tags:''
    });

    a({
        id:6,
        title:"DiscriminatedUnionList",
        content:"DiscriminatedUnionList",
        description:'',
        tags:''
    });

    a({
        id:7,
        title:"DiscriminatedUnionWithBase",
        content:"DiscriminatedUnionWithBase",
        description:'',
        tags:''
    });

    a({
        id:8,
        title:"DiscriminatedUnionIEnumerableExtensions",
        content:"DiscriminatedUnionIEnumerableExtensions",
        description:'',
        tags:''
    });

    a({
        id:9,
        title:"PatternMatch",
        content:"PatternMatch",
        description:'',
        tags:''
    });

    a({
        id:10,
        title:"DiscriminatedUnionList",
        content:"DiscriminatedUnionList",
        description:'',
        tags:''
    });

    a({
        id:11,
        title:"Some",
        content:"Some",
        description:'',
        tags:''
    });

    a({
        id:12,
        title:"DiscriminatedUnionWithBaseList",
        content:"DiscriminatedUnionWithBaseList",
        description:'',
        tags:''
    });

    a({
        id:13,
        title:"DiscriminatedPatternMatch",
        content:"DiscriminatedPatternMatch",
        description:'',
        tags:''
    });

    a({
        id:14,
        title:"DiscriminatedUnionWithBaseList",
        content:"DiscriminatedUnionWithBaseList",
        description:'',
        tags:''
    });

    a({
        id:15,
        title:"PatternMatchExtensions",
        content:"PatternMatchExtensions",
        description:'',
        tags:''
    });

    a({
        id:16,
        title:"DiscriminatedUnion",
        content:"DiscriminatedUnion",
        description:'',
        tags:''
    });

    a({
        id:17,
        title:"DiscriminatedUnionWithBaseList",
        content:"DiscriminatedUnionWithBaseList",
        description:'',
        tags:''
    });

    a({
        id:18,
        title:"DiscriminatedUnionList",
        content:"DiscriminatedUnionList",
        description:'',
        tags:''
    });

    a({
        id:19,
        title:"IOption",
        content:"IOption",
        description:'',
        tags:''
    });

    a({
        id:20,
        title:"None",
        content:"None",
        description:'',
        tags:''
    });

    a({
        id:21,
        title:"DiscriminatedUnion",
        content:"DiscriminatedUnion",
        description:'',
        tags:''
    });

    a({
        id:22,
        title:"DiscriminatedUnionWithBaseList",
        content:"DiscriminatedUnionWithBaseList",
        description:'',
        tags:''
    });

    a({
        id:23,
        title:"DiscriminatedUnionList",
        content:"DiscriminatedUnionList",
        description:'',
        tags:''
    });

    a({
        id:24,
        title:"DiscriminatedUnionWithBaseList",
        content:"DiscriminatedUnionWithBaseList",
        description:'',
        tags:''
    });

    a({
        id:25,
        title:"DiscriminatedUnionWithBase",
        content:"DiscriminatedUnionWithBase",
        description:'',
        tags:''
    });

    a({
        id:26,
        title:"DiscriminatedUnionWithBase",
        content:"DiscriminatedUnionWithBase",
        description:'',
        tags:''
    });

    a({
        id:27,
        title:"PatternMatchAction",
        content:"PatternMatchAction",
        description:'',
        tags:''
    });

    a({
        id:28,
        title:"PatternMatchSingleContext",
        content:"PatternMatchSingleContext",
        description:'',
        tags:''
    });

    a({
        id:29,
        title:"PatternMatchSingle",
        content:"PatternMatchSingle",
        description:'',
        tags:''
    });

    a({
        id:30,
        title:"PatternMatchSingleAction",
        content:"PatternMatchSingleAction",
        description:'',
        tags:''
    });

    a({
        id:31,
        title:"DiscriminatedUnion",
        content:"DiscriminatedUnion",
        description:'',
        tags:''
    });

    a({
        id:32,
        title:"DiscriminatedUnionWithBaseList",
        content:"DiscriminatedUnionWithBaseList",
        description:'',
        tags:''
    });

    a({
        id:33,
        title:"DiscriminatedPatternMatch",
        content:"DiscriminatedPatternMatch",
        description:'',
        tags:''
    });

    a({
        id:34,
        title:"MultipleResultsException",
        content:"MultipleResultsException",
        description:'',
        tags:''
    });

    a({
        id:35,
        title:"DiscriminatedUnionList",
        content:"DiscriminatedUnionList",
        description:'',
        tags:''
    });

    a({
        id:36,
        title:"DiscriminatedPatternMatch",
        content:"DiscriminatedPatternMatch",
        description:'',
        tags:''
    });

    a({
        id:37,
        title:"DiscriminatedPatternMatchExtensions",
        content:"DiscriminatedPatternMatchExtensions",
        description:'',
        tags:''
    });

    a({
        id:38,
        title:"DiscriminatedUnion",
        content:"DiscriminatedUnion",
        description:'',
        tags:''
    });

    a({
        id:39,
        title:"DiscriminatedUnionWithBase",
        content:"DiscriminatedUnionWithBase",
        description:'',
        tags:''
    });

    a({
        id:40,
        title:"DiscriminatedPatternMatchContext",
        content:"DiscriminatedPatternMatchContext",
        description:'',
        tags:''
    });

    a({
        id:41,
        title:"DiscriminatedUnion",
        content:"DiscriminatedUnion",
        description:'',
        tags:''
    });

    a({
        id:42,
        title:"DiscriminatedUnionList",
        content:"DiscriminatedUnionList",
        description:'',
        tags:''
    });

    a({
        id:43,
        title:"DiscriminatedUnionList",
        content:"DiscriminatedUnionList",
        description:'',
        tags:''
    });

    a({
        id:44,
        title:"DiscriminatedUnionWithBase",
        content:"DiscriminatedUnionWithBase",
        description:'',
        tags:''
    });

    a({
        id:45,
        title:"DiscriminatedUnionWithBaseList",
        content:"DiscriminatedUnionWithBaseList",
        description:'',
        tags:''
    });

    a({
        id:46,
        title:"PatternMatchCase",
        content:"PatternMatchCase",
        description:'',
        tags:''
    });

    a({
        id:47,
        title:"DiscriminatedUnionListExtensions",
        content:"DiscriminatedUnionListExtensions",
        description:'',
        tags:''
    });

    a({
        id:48,
        title:"DiscriminatedUnionWithBase",
        content:"DiscriminatedUnionWithBase",
        description:'',
        tags:''
    });

    a({
        id:49,
        title:"DiscriminatedUnionWithBaseList",
        content:"DiscriminatedUnionWithBaseList",
        description:'',
        tags:''
    });

    a({
        id:50,
        title:"DiscriminatedUnionList",
        content:"DiscriminatedUnionList",
        description:'',
        tags:''
    });

    a({
        id:51,
        title:"EmptySequenceException",
        content:"EmptySequenceException",
        description:'',
        tags:''
    });

    a({
        id:52,
        title:"DiscriminatedUnionWithBase",
        content:"DiscriminatedUnionWithBase",
        description:'',
        tags:''
    });

    a({
        id:53,
        title:"DiscriminatedPatternMatch",
        content:"DiscriminatedPatternMatch",
        description:'',
        tags:''
    });

    a({
        id:54,
        title:"DiscriminatedPatternMatch",
        content:"DiscriminatedPatternMatch",
        description:'',
        tags:''
    });

    a({
        id:55,
        title:"DiscriminatedPatternMatch",
        content:"DiscriminatedPatternMatch",
        description:'',
        tags:''
    });

    a({
        id:56,
        title:"DiscriminatedUnionList",
        content:"DiscriminatedUnionList",
        description:'',
        tags:''
    });

    a({
        id:57,
        title:"DiscriminatedUnion",
        content:"DiscriminatedUnion",
        description:'',
        tags:''
    });

    a({
        id:58,
        title:"OptionExtensions",
        content:"OptionExtensions",
        description:'',
        tags:''
    });

    a({
        id:59,
        title:"DiscriminatedPatternMatch",
        content:"DiscriminatedPatternMatch",
        description:'',
        tags:''
    });

    a({
        id:60,
        title:"DiscriminatedPatternMatch",
        content:"DiscriminatedPatternMatch",
        description:'',
        tags:''
    });

    a({
        id:61,
        title:"DiscriminatedPatternMatch",
        content:"DiscriminatedPatternMatch",
        description:'',
        tags:''
    });

    a({
        id:62,
        title:"DiscriminatedUnionWithBase",
        content:"DiscriminatedUnionWithBase",
        description:'',
        tags:''
    });

    a({
        id:63,
        title:"DiscriminatedUnionWithBaseList",
        content:"DiscriminatedUnionWithBaseList",
        description:'',
        tags:''
    });

    a({
        id:64,
        title:"OptionTypeLinqExtensions",
        content:"OptionTypeLinqExtensions",
        description:'',
        tags:''
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.DiscriminatedUnions/DiscriminatedUnion_6',
        title:"DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.DiscriminatedUnions/DiscriminatedUnion_4',
        title:"DiscriminatedUnion<Type1, Type2, Type3, Type4>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.DiscriminatedUnions/DiscriminatedUnionWithBase_4',
        title:"DiscriminatedUnionWithBase<Type1, Type2, Type3, BaseType>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.DiscriminatedUnions/LinqExtensions',
        title:"LinqExtensions",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.DiscriminatedUnions/DiscriminatedUnion_10',
        title:"DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.PatternMatching/PatternMatchContext_1',
        title:"PatternMatchContext<T>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.DiscriminatedUnions/DiscriminatedUnionList_2',
        title:"DiscriminatedUnionList<Type1, Type2>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.DiscriminatedUnions/DiscriminatedUnionWithBase_9',
        title:"DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, BaseType>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.DiscriminatedUnions/DiscriminatedUnionIEnumerableExtensions',
        title:"DiscriminatedUnionIEnumerableExtensions",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.PatternMatching/PatternMatch_2',
        title:"PatternMatch<T, TResult>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.DiscriminatedUnions/DiscriminatedUnionList_9',
        title:"DiscriminatedUnionList<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.OptionTypes/Some_1',
        title:"Some<T>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.DiscriminatedUnions/DiscriminatedUnionWithBaseList_8',
        title:"DiscriminatedUnionWithBaseList<Type1, Type2, Type3, Type4, Type5, Type6, Type7, BaseType>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.PatternMatching/DiscriminatedPatternMatch_2',
        title:"DiscriminatedPatternMatch<T, TResult1>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.DiscriminatedUnions/DiscriminatedUnionWithBaseList_3',
        title:"DiscriminatedUnionWithBaseList<Type1, Type2, BaseType>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.PatternMatching/PatternMatchExtensions',
        title:"PatternMatchExtensions",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.DiscriminatedUnions/DiscriminatedUnion_9',
        title:"DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.DiscriminatedUnions/DiscriminatedUnionWithBaseList_11',
        title:"DiscriminatedUnionWithBaseList<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10, BaseType>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.DiscriminatedUnions/DiscriminatedUnionList_6',
        title:"DiscriminatedUnionList<Type1, Type2, Type3, Type4, Type5, Type6>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.OptionTypes/IOption_1',
        title:"IOption<T>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.OptionTypes/None_1',
        title:"None<T>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.DiscriminatedUnions/DiscriminatedUnion_3',
        title:"DiscriminatedUnion<Type1, Type2, Type3>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.DiscriminatedUnions/DiscriminatedUnionWithBaseList_7',
        title:"DiscriminatedUnionWithBaseList<Type1, Type2, Type3, Type4, Type5, Type6, BaseType>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.DiscriminatedUnions/DiscriminatedUnionList_10',
        title:"DiscriminatedUnionList<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.DiscriminatedUnions/DiscriminatedUnionWithBaseList_10',
        title:"DiscriminatedUnionWithBaseList<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, BaseType>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.DiscriminatedUnions/DiscriminatedUnionWithBase_7',
        title:"DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, BaseType>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.DiscriminatedUnions/DiscriminatedUnionWithBase_3',
        title:"DiscriminatedUnionWithBase<Type1, Type2, BaseType>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.PatternMatching/PatternMatchAction_1',
        title:"PatternMatchAction<T>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.PatternMatching/PatternMatchSingleContext_1',
        title:"PatternMatchSingleContext<T>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.PatternMatching/PatternMatchSingle_2',
        title:"PatternMatchSingle<T, TResult>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.PatternMatching/PatternMatchSingleAction_1',
        title:"PatternMatchSingleAction<T>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.DiscriminatedUnions/DiscriminatedUnion_8',
        title:"DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.DiscriminatedUnions/DiscriminatedUnionWithBaseList_5',
        title:"DiscriminatedUnionWithBaseList<Type1, Type2, Type3, Type4, BaseType>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.PatternMatching/DiscriminatedPatternMatch_6',
        title:"DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.DiscriminatedUnions.Exceptions/MultipleResultsException',
        title:"MultipleResultsException",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.DiscriminatedUnions/DiscriminatedUnionList_3',
        title:"DiscriminatedUnionList<Type1, Type2, Type3>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.PatternMatching/DiscriminatedPatternMatch_4',
        title:"DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.PatternMatching/DiscriminatedPatternMatchExtensions',
        title:"DiscriminatedPatternMatchExtensions",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.DiscriminatedUnions/DiscriminatedUnion_5',
        title:"DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.DiscriminatedUnions/DiscriminatedUnionWithBase_5',
        title:"DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, BaseType>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.PatternMatching/DiscriminatedPatternMatchContext_1',
        title:"DiscriminatedPatternMatchContext<T>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.DiscriminatedUnions/DiscriminatedUnion_2',
        title:"DiscriminatedUnion<Type1, Type2>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.DiscriminatedUnions/DiscriminatedUnionList_5',
        title:"DiscriminatedUnionList<Type1, Type2, Type3, Type4, Type5>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.DiscriminatedUnions/DiscriminatedUnionList_7',
        title:"DiscriminatedUnionList<Type1, Type2, Type3, Type4, Type5, Type6, Type7>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.DiscriminatedUnions/DiscriminatedUnionWithBase_10',
        title:"DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, BaseType>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.DiscriminatedUnions/DiscriminatedUnionWithBaseList_6',
        title:"DiscriminatedUnionWithBaseList<Type1, Type2, Type3, Type4, Type5, BaseType>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.PatternMatching/PatternMatchCase_2',
        title:"PatternMatchCase<T, TResult>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.DiscriminatedUnions/DiscriminatedUnionListExtensions',
        title:"DiscriminatedUnionListExtensions",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.DiscriminatedUnions/DiscriminatedUnionWithBase_6',
        title:"DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, BaseType>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.DiscriminatedUnions/DiscriminatedUnionWithBaseList_9',
        title:"DiscriminatedUnionWithBaseList<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, BaseType>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.DiscriminatedUnions/DiscriminatedUnionList_4',
        title:"DiscriminatedUnionList<Type1, Type2, Type3, Type4>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.DiscriminatedUnions.Exceptions/EmptySequenceException',
        title:"EmptySequenceException",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.DiscriminatedUnions/DiscriminatedUnionWithBase_11',
        title:"DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10, BaseType>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.PatternMatching/DiscriminatedPatternMatch_5',
        title:"DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.PatternMatching/DiscriminatedPatternMatch_10',
        title:"DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.PatternMatching/DiscriminatedPatternMatch_3',
        title:"DiscriminatedPatternMatch<T, TResult1, TResult2>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.DiscriminatedUnions/DiscriminatedUnionList_8',
        title:"DiscriminatedUnionList<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.DiscriminatedUnions/DiscriminatedUnion_7',
        title:"DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.OptionTypes/OptionExtensions',
        title:"OptionExtensions",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.PatternMatching/DiscriminatedPatternMatch_8',
        title:"DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.PatternMatching/DiscriminatedPatternMatch_9',
        title:"DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.PatternMatching/DiscriminatedPatternMatch_7',
        title:"DiscriminatedPatternMatch<T, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.DiscriminatedUnions/DiscriminatedUnionWithBase_8',
        title:"DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, BaseType>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.DiscriminatedUnions/DiscriminatedUnionWithBaseList_4',
        title:"DiscriminatedUnionWithBaseList<Type1, Type2, Type3, BaseType>",
        description:""
    });

    y({
        url:'/FunctionalSharp/FunctionalSharp/api/FunctionalSharp.OptionTypes/OptionTypeLinqExtensions',
        title:"OptionTypeLinqExtensions",
        description:""
    });

    return {
        search: function(q) {
            return idx.search(q).map(function(i) {
                return idMap[i.ref];
            });
        }
    };
}();
