using C_ASSIGNMENT_BUILDER.Engine.AssignmentBuilder;
namespace C_ASSIGNMENT_BUILDER.CurrentAssignment;

/*
Fullstack tester: DiceRoller
Interne tester i bibliotek: TestAssignment
Backend tester: TestMethods, TestDatastructures, TestArrayAndListMethods

authors:
https://github.com/johnb08
https://github.com/jorgenmjobloop
*/

public class AssignmentList : AssignmentListBase
{
    /* Her legger man inn alle typeof av oppgavene, så guiden kan tracke og følge progresjon. - John*/
    public AssignmentList()
    {
        /* Types skal inneholde en Typeof oppgavesettet man vil tracke. - John*/
        Types = [
            typeof(TestMethods),
            typeof(TestDatastructures),
            typeof(TestArrayAndListMethods),
            typeof(TDDTests),
            typeof(MyTestClass)
        ];
    }
}

public class MyTestClass
{
    public bool TestPrimitiveDataTypes()
    {
        int x = 10;
        double y = 15.5;
        return (x + y == 25.5);
    }


public bool TestClassObjects()
{
    Person person = new Person { Name = "Andy", Age = 30 };
    return person.Name == "Andy" && person.Age == 30;
} 
}
