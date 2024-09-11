using listaGenerica;

List <double> numbers = new List<double>(); 

do
{
    Console.WriteLine("informe um numero:");
    string? numberstr = Console.ReadLine();
    //validando a entrada do usuário
    if(!double.TryParse(numberstr, out double number))
    {
        break;
    }
    numbers.Add(number);
    Console.WriteLine(
        $"A média dos valores é {numbers.Average()}"
    );
}
while(true);

// --Lista de Pessoas
List<Person> people = new List<Person>();
Person p1 = new Person();
p1.Name = "Joaquim";
p1.Age = 12;
p1.Country = CountryEnum.PY;
people.Add(p1);

p1.Name = "Joaquim José da Silva Xavier";

people.Add(new Person() {
    Name = "Sharon Stone",
    Age = 60,
    Country = CountryEnum.PY,

});

Person p3 = new Person(){
    Name = "Arnold E-SuasNega",
    Age = 65,
    Country = CountryEnum.JP,
};
people.Add(p3);

//formas de percorrer a Lista Genérica

foreach(Person p in people)
{
    Console.WriteLine(p.Name);

}

//modo for tradicional
for(int i = 0; i < people.Count; i++)
{
    Console.WriteLine(
        $"Nome: {people[i].Name}"
        );
}