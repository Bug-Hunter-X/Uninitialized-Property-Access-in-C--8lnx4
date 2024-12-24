public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property before it's initialized can lead to unexpected behavior.
        int value = this.MyProperty; //Uncommon bug: Accessing uninitialized property
        Console.WriteLine(value); 
    }
}