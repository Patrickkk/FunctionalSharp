Option types allow you to clearly specify that a function or argument passed can be Null. This is especially powerfull combined with [Fody.NullGuard](https://github.com/Fody/NullGuard) to eliminate Nullreference exceptions all together.

## Using option types
turning a value into an optiontype is quite easy, if you have a typed variable that you want to turn into an option type you can use the ```ToOption()``` Extension method. for example:

    var stringValue = "stringValue".ToOption();
    var result = stringValue.Match(value => value, nullstring);

the resulting ```IOption<string>``` contains a couple of methods that you can use to match if the type has a value or not. The main difference between using the option type and using null checks directly is that the consumer of the method can immediately see where null might be allowed/expected and if used consistently does not have to worry about checking null every time
