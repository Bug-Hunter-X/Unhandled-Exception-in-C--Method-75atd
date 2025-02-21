public class ExampleClass
{
    private int _value;

    public int Value
    {
        get { return _value; }
        set { _value = value; }
    }

    public void DoSomething()
    {
        if (Value == 0)
        {
            // Some code here that might throw an exception
            throw new Exception("Value is zero!");
        }
        // Other code here 
    }
}