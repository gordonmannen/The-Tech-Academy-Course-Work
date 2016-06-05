// Creation of a struct

public struct Test
{
    // field
    private string testString;
    private int testNumber;

    // property
    public string TestString
    {
        get
        {
            return testString;
        }
        set
        {
            testString = value;
        }
    }

    // method
    public int GetTestNumber()
    {
        return testNumber;

    }
}