interface IIdentifiable{
    string ID { get; }
}

interface IPeople
{
    string Name { get; }
    int Age { get; }
}
interface IBirthdate {
    DateTime Birthdate { get; }
}