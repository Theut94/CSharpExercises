namespace ClassLibrary1;

public class Service : IService
{
    public object FindElement(IEnumerable<object> data, int index)
    {
        return data.ElementAt(index);
    }

    public bool AreTheseStringsEqual(string str1, string str2)
    {
        return str1.Equals(str2);
    }

    public int Factorial(int n)
    {
        if (n == 1)
            return n;
        else
        {
            return n * Factorial(n - 1);
        }
    }

    public int Fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
            return (Fibonacci(n - 1) + Fibonacci(n - 2));

    }

    public IEnumerable<int> FindValuesGreaterThan(IEnumerable<int> data, int value)
    {
        List<int> list = new List<int>();
        foreach (int x in data)
        {
            if (x > value)
            {
                list.Add(x);

            }
        }
        return list;
    }

    public double FindAverage(IEnumerable<int> data)
    {
        return data.Average();
    }

    public string SwapCharacters(string testString, char swapA, char swapB)
    {
        String returnstring = "";
        for (int i = 0; i < testString.Length; i++)
        {
            if (testString.ElementAt(i).Equals(swapA))
            {
                returnstring = returnstring + swapB;
            }
            else if (testString.ElementAt(i).Equals(swapB))
            {
                returnstring = returnstring + swapA;
            }
            else
                returnstring = returnstring + testString.ElementAt(i);
        }
        return returnstring;
    }

    public int ConvertStringToIntIfValidIntegerValue(string testString)
    {
        try
        {
            return Int32.Parse(testString);
        }
        catch (FormatException e)
        {
            throw e;

        }
    }
    class Cheese
    {
        public int field;

        public int property
        {
            get
            {
                return field ;
            }
            set
            {
                field = value;
            }

        }
    }
        public object CreateObjectWithPropretyWhichHasAccessors()
    {
      
        return new Cheese();
    }

    public IEnumerable<object> CreateListWithObjectsContainingIntAndItsSquare(IEnumerable<int> data)
    {
        
    }

    public Dictionary<int, int> CreateDictionrayWithIntsAndTheirFrequency(IEnumerable<int> data)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<int> CreateListOfHighestFiveNumbers(IEnumerable<int> data)
    {
        throw new NotImplementedException();
    }

    public bool IsDateEarlierThanToday(DateTime date)
    {
        throw new NotImplementedException();
    }

    public DateTime CreateDateFromNumberOfMillisecondsSinceUnixEpoch(long milliseconds)
    {
        throw new NotImplementedException();
    }

    public List<DateTime> CreateListOfLatestTwoDates(IEnumerable<DateTime> dates)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<string> PerformInMemoryInnerJoin(IEnumerable<string> left, IEnumerable<string> right)
    {
        throw new NotImplementedException();
    }

    public List<int> EvilNumbers(List<int> data)
    {
        throw new NotImplementedException();
    }

    public List<int> AbundantNumbers(IEnumerable<int> data)
    {
        throw new NotImplementedException();
    }
}