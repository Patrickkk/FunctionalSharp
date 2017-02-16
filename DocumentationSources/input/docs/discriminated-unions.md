Discriminated unions can be used to have typed who can be one of multiple types, while preserving static typing.
For example suppose you have a list of Animals where you can have cats and dogs. 
Cats and dogs might have some similarities but also have some specific methods. Suppose you want to access specific methods, 
you first have to use the ```is``` operator and some casting to get the desired type. in .net4.5 you can the linq extensionmethod ofType() 
but there is no way of knowing if the type is actually part of the collection, maybe it was a list of only cats and parrots.

A simple example of converting a list of Dogs and cats into a list of strings with their name

    IEnumerable<DiscriminatedUnion<Dog,Cat>> animals = GetAnimals();
    IEnumerable<string> annimalStrings = animals.Match(dog => "Dog - whoof", cat => "cat - miauw");

But you can do a lot more. for example you can have a object that in different states can do different things. By creating a Type for each state you can make sure that the correct methods can only be called for the correct state.