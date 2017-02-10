## when to use
Discriminatedunions are usefull for several situations.

## how to use
Here i will explain how to use this librairy with some simple examples.

### simple usage
To create a discriminated union you can use the constructor.
```csharp
var union = new DiscriminatedUnion<string, int>("string");
```
now that you hav a discriminated union you can use the Match method. It comes with 2 overloads: one that executes an action, and one that executes a function. In the example below we use the function overload
```csharp
var union = new DiscriminatedUnion<string, int>("string");
var result = union.Match(
    stringValue => -1,
    intValue => intValue);
```
In this example the result will hold a value of -1.

### Collections
When using collections with disciminatedunions you get the most out of discriminated unions. 
You can use the merge methods in the DiscriminatedUnionsNamespace to create discripminatedunions from existing IEnumerables if you want.
```csharp
var stringEnumerable = new string[] { "string1", "string2" };
var merged = stringEnumerable.Merge(new int[] { 1, 2, 3 });
merged.Match(
    stringItem => ActionForString(stringItem),
    intItem => ActionForInt(intItem));
```
The above example creates an IEumerable of Discriminatedunions from 2 IEnumerables. after the creation you can use the Match method to Match specific types.

To easily work with lists of discriminated unions you can use the DiscriminatedUnionList

### best practices
use "named unions" for types that are used multiple times.

```csharp
public class NamedUnion : DiscriminatedUnion<string, int>
{
    public NamedUnion(int value) : base(value) { }
    public NamedUnion(string value) : base(value) { }
}
```