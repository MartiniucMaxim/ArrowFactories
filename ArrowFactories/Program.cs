

class Arrow
{
    public enum ArrowHead
    {
        Wood,
        Obsidian,
        Steel,
        Null
    }

    public enum FletchingType
    {
        GooseFeathered,
        TurkeyFeathered,
        Plastic,
        Null
    }

    private static ArrowHead _arrowHead;
    private static FletchingType _fletchingType;
    private static int _length;

    public ArrowHead ArrowHeadType
    {
        get { return _arrowHead; }
    }

    public FletchingType FletchingTypeChoice
    {
        get { return _fletchingType; }
    }

    public int Length
    {
        get { return _length; }
    }


    //creating constructor without any parameters. 
    //but he accepts methods for default and will construct fields for object.
    public Arrow()
    {
        _arrowHead = GetArrowHeadFromUser();
        _fletchingType = GetFletchingTypeFromUser();
        _length = GetLengthFromUser();
    }

    //creating another constructor with 3 parameters
    public Arrow(ArrowHead arrowHead,FletchingType fletchingType,int length)
    {
        _arrowHead = arrowHead;
        _fletchingType = fletchingType;
        _length = length;
    }

  

    //Making methods
    //which allows user choose 3 pre-defined arrows
    //if he wants create his own arrow, he can press 4.
    public static Arrow? MakeArrow()
    {
        Console.WriteLine("Choose your arrow sample from 1-4 || \nif you want to finish program, press number higher then 4:");
        int arrowChoice = Convert.ToInt32(Console.ReadLine());
        switch (arrowChoice)
        {
            case 1:
                CreateEliteArrow();
                break;
            case 2:
                CreateMarksmanArrow();
                break;
            case 3:
                CreateBeginnerArrow();
                break;
            case 4:
                Console.WriteLine("You choose custome building of arrow");
                return new();
            default:
                Console.WriteLine("Your option is out of range.Restart program!!!");
                System.Environment.Exit(0);
                break;
        }
        return null;
        
    }

    //Creating method CreateEliteArrow
    //Whick makes me new object EliteArrow and returns his values;
    public static Arrow CreateEliteArrow()
    {
        Arrow EliteArrow = new Arrow(ArrowHead.Steel,FletchingType.Plastic,95);
        Console.WriteLine($"Your Elite Arrow have:\n arrow head - {ArrowHead.Steel} \n fletching type - {FletchingType.Plastic} \n length shaft - {95} cm"); //?
        Console.WriteLine($" Price for Elite arrow is:{EliteArrow.ArrowCost}");
        return EliteArrow;
    }

    //Creating method CreateMarksmanArrow
    //Whick makes me new object MarksmanArrow and returns his values;
    public static Arrow CreateMarksmanArrow()
    {
        Arrow MarksmanArrow = new Arrow(ArrowHead.Obsidian, FletchingType.TurkeyFeathered,75);
        Console.WriteLine($"Your Marksman Arrow sample have:\n arrow head - {ArrowHead.Obsidian}\n fletching type - {FletchingType.TurkeyFeathered} \n length shaft - {75} cm");
        Console.WriteLine($" Price for Marksman arrow is:{MarksmanArrow.ArrowCost}");
        return MarksmanArrow;
        

    }

    //Creating method CreateBeginnerArrow
    //Whick makes me new object BeginnerArrow and returns his values;
    public static Arrow  CreateBeginnerArrow()
    {
        Arrow BeginnerArrow = new Arrow(ArrowHead.Wood, FletchingType.GooseFeathered,65);
        Console.WriteLine($"Your Marksman Arrow sample have:\n arrow head - {ArrowHead.Wood}\n fletching type - {FletchingType.GooseFeathered} \n length shaft - {65} cm");
        Console.WriteLine($" Price for Beginner arrow is:{BeginnerArrow.ArrowCost}");
        return BeginnerArrow;
    }

    //Making methods which allow user choose ArrowHead choice
    //From enum ArrowHead
    private ArrowHead GetArrowHeadFromUser()
    {
        int arrowHead = Convert.ToInt32(Console.ReadLine());
        switch (arrowHead)
        {
            case (int)ArrowHead.Wood:
                Console.WriteLine($"Your arrows will have a {ArrowHead.Wood} arrowhead");
                return ArrowHead.Wood;
            case (int)ArrowHead.Obsidian:
                Console.WriteLine($"Your arrows will have an {ArrowHead.Obsidian} arrowhead");
                return ArrowHead.Obsidian;
            case (int)ArrowHead.Steel:
                Console.WriteLine($"Your arrows will have an {ArrowHead.Steel}");
                return ArrowHead.Steel;
            default:
                Console.WriteLine($"Your arrow have {ArrowHead.Null} arrowhead. You hadn't choose anything from Wood/Obsidian/Steel choice");
                return ArrowHead.Null;
                //break;
        }
    }

    //Making methods which allow user choose FletchingType choice
    //Depending on enum FletchingType 
    private FletchingType GetFletchingTypeFromUser()
    {
        int fletchingType = Convert.ToInt32(Console.ReadLine()); ;
        switch (fletchingType)
        {
            case (int)FletchingType.GooseFeathered:
                Console.WriteLine($"Your fletching type is {FletchingType.GooseFeathered}");
                return FletchingType.GooseFeathered;
            case (int)FletchingType.TurkeyFeathered:
                Console.WriteLine($"Your fletching type is {FletchingType.TurkeyFeathered}");
                return FletchingType.TurkeyFeathered;
            case (int)FletchingType.Plastic:
                Console.WriteLine($"Your fletching type is {FletchingType.Plastic}");
                return FletchingType.Plastic;
            default:
                Console.WriteLine($"Your fletching type is {FletchingType.Null}. Choose between Goose/Turkey/Plastic feathers.");
                return FletchingType.Null;
                //break;
        }
    }

    //Making Method which allow user input Length type
    private int GetLengthFromUser()
    {
        int length = Convert.ToInt32(Console.ReadLine());
        if (length >= 60 && length <= 100)
        {
            Console.WriteLine($"Your arrow have length:{length}");
        }
        return length;
    }

    //Method, where calculates costs from arrowHead/FletchingType/Length
    //And results with addition of three costs into one.
    private static float GetCost()
    {
        float totalCost = 0;
        float arrowHeadCost = _arrowHead switch
        {
            ArrowHead.Wood => 3f,
            ArrowHead.Obsidian => 5f,
            ArrowHead.Steel => 10f,
            ArrowHead.Null => 0f
        };

        float fletchingCost = _fletchingType switch
        {
            FletchingType.GooseFeathered => 3f,
            FletchingType.TurkeyFeathered => 5f,
            FletchingType.Plastic => 10f,
            FletchingType.Null => 0f
        };
        float lengthCost = _length * 0.05f;
        return totalCost = fletchingCost + arrowHeadCost + lengthCost;

    }

    private float ArrowCost => GetCost();

    public static void Main()
    {
        var arrowType = Arrow.MakeArrow();
    }

  
}

