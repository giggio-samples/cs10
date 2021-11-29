const string x = "x";
const string y = $"{x}y"; // constant interpolated string
WriteLine(y); // global using
string firstName;
(firstName, var lastName) = new Person("Giovanni", "Bassi"); // deconstruction mixing assignment and declaration
WriteLine($"{firstName} {lastName}");
Animal caramelo = new Dog("Caramelo", new Person(firstName, lastName));
if (caramelo is Dog { Owner.FirstName: "Giovanni" } dog) // extended property pattern
    dog.Bark();

var f4 = () => 1; // lambda improvements
WriteLine(f4());
var scopedWriteLine = (string text) => WriteLine($"    {text}"); // lambda improvements
scopedWriteLine("Hello");

var someClass = new cs10.SomeNamespace.SomeClass(); // file scoped namespaces

WriteLine(new SomeEntity("Giovanni"));
WriteLine(new HasConstructor().j);

static T Sum<T>(params T[] values) where T : INumber<T>
{
    T result = T.Zero; // static abstract interface method // PREVIEW!
    foreach (var value in values)
        result += value; // static abstract interface method // PREVIEW!
    return result;
}

WriteLine("Soma de ints: {0}", Sum(1, 2, 3));
WriteLine("Soma de doubles: {0}", Sum(1.0, 2.0, 3.0));
WriteLine("Soma de decimals: {0}", Sum(1m, 2m, 3m));

record struct Person(string FirstName, string LastName); // record struct
record class Animal; // record class: explicit
record Dog(string name, Person Owner) : Animal
{
    public void Bark() => WriteLine("auau");
}

record struct SomeEntity(string Name)
{
    private static int id = 0;
    private static int GetNextId() => ++id;
    public int Id { get; init; } = GetNextId(); // struct field initializer
}

public struct HasConstructor
{
    public HasConstructor() // Parameterless struct constructors
    {
        k = 2;
    }
    public int i = 0; // struct field initializer
    public int j = 1;
    public int k;
}
