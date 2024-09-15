namespace Arv_uppgift
{
    public class Employee
    {
        // Detta är privat attribut som vi skyddar från resten av appen och användarna
        // Vi kommer åt denna bara med hjälp av plublic metoder eller public attributer
        private string name;

        // Konstruktör - den säger när vi skapar ett objekt av klassen Employee, att vi måste specificera attributen
        public Employee (string name)
        {
            Name = name;
        }


        // Nu gör vi ett public metod för att komma åt privata attributer
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
