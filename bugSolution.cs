public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass()
    {
        // Initialize the property in the constructor
        MyProperty = 0; 
    }

    public void MyMethod()
    {
        Console.WriteLine(MyProperty); // Now, it's guaranteed to print 0.
    }

    public void MyOtherMethod(int value)
    {
        MyProperty = value; // Assigning a value before using it.
        Console.WriteLine(MyProperty);
    }
}