namespace Challenge
{
    class Program
    {
        public static void Main()
        {
            
            System.Console.WriteLine("Choose an arrow type:\n1)Elite Arrow\n2)Beginner Arrow\n3)Marksman Arrow\n4)Custom Arrow\nChoose an option: ");            
            string input = Console.ReadLine();
            int option;
            while(!(Int32.TryParse(input, out option)))
            {
                input = Console.ReadLine();
            }

            Arrow arrow;
            switch(option)
            {
                case 1:
                    arrow = Arrow.CreateEliteArrow();
                    System.Console.WriteLine("Elite Arrow Created");
                    System.Console.WriteLine(arrow.GetCost());
                
                break;
                case 2:
                    arrow = Arrow.CreateBeginnerArrow();
                    System.Console.WriteLine("Beginner Arrow Created");
                    System.Console.WriteLine(arrow.GetCost());
                break;
                case 3:
                    arrow = Arrow.CreateMarksmanArrow();
                    System.Console.WriteLine("Marksman Arrow Created");
                    System.Console.WriteLine(arrow.GetCost());
                break;
                case 4:
                    CustomArrow();
                break;
                default:
                    System.Console.WriteLine("Invalid Option");
                break;
            }

        }


        public static void CustomArrow ()
        {
            System.Console.WriteLine("Pick an arrowhead:\n1)Steel\n2)Wood\n3)Obsidian\nChoose an option: ");
            ArrowheadType HeadType = ArrowheadType.Wood;

            if(Int32.TryParse(Console.ReadLine(), out int ArrowHeadNum))
            {
                HeadType = GetArrowHead(ArrowHeadNum);
            }

            System.Console.WriteLine("Pick a fletching type:\n1)Plastic,\n2)TurkeyFeathers,\n3)GooseFeathers ");
            FletchingType Fletching = FletchingType.Plastic;
    
            if(Int32.TryParse(Console.ReadLine(), out int FletchingTypeNum))
            {
               Fletching = GetFletchingType(FletchingTypeNum);
            }

            System.Console.WriteLine("Type the arrow length: ");
            int ArrowLenght;
            if(!(Int32.TryParse(Console.ReadLine(), out ArrowLenght)))
            {
                System.Console.WriteLine("Please type a valid length!");
            }

            Arrow NewArrow = new Arrow(HeadType,Fletching,ArrowLenght);
            System.Console.WriteLine(NewArrow.GetCost());
        }

        public static ArrowheadType GetArrowHead(int ArrowHeadNum)
        {
            ArrowheadType HeadType = ArrowheadType.Wood;
            switch(ArrowHeadNum)
            {
                case 1:
                    HeadType = ArrowheadType.Steel;
                break;
                case 2:
                    HeadType = ArrowheadType.Wood;
                break;
                case 3:
                    HeadType = ArrowheadType.Obsidian;
                break;
                default:
                    System.Console.WriteLine("Invalid Option");
                break;
            }
            return HeadType;
        }

        public static FletchingType GetFletchingType(int FletchingTypeNum)
        {
            FletchingType Fletching = FletchingType.Plastic;
            switch(FletchingTypeNum)
            {
                case 1:
                    Fletching = FletchingType.Plastic;
                break;
                case 2:
                    Fletching = FletchingType.TurkeyFeathers;
                break;
                case 3:
                    Fletching = FletchingType.GooseFeathers;
                break;
                default:
                    System.Console.WriteLine("Invalid Option");
                break;
            }
            return Fletching;
        }
    }
}