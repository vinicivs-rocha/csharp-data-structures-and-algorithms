using DataStructuresAndAlgorithms.DataStructures;

namespace DataStructuresAndAlgorithms.Algorithms.Lists;

public class QueryPeopleOverAge(List<Person> people)
{
  public List<Person> Execute(int age) => [..(
    from person in people
    where person.Age > age
    orderby person.Name
    select person
  )];
}
