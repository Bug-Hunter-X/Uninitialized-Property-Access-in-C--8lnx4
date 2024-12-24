public class ExampleClass
{
    public int MyProperty { get; set; }

    // Constructor to initialize the property
    public ExampleClass()
    {
        this.MyProperty = 10; // Initialize the property
    }

    public void MyMethod()
    {
        int value = this.MyProperty; 
        Console.WriteLine(value); 
    }
}