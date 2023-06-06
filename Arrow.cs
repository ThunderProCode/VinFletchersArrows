using System;

namespace Challenge
{
    public enum ArrowheadType
    {
        Steel,
        Wood,
        Obsidian
    }

    public enum FletchingType
    {
        Plastic,
        TurkeyFeathers,
        GooseFeathers
    }

    public class Arrow
    {
        // Properties
        public ArrowheadType ArrowheadType { get; set; }
        public FletchingType FletchingType { get; set; }
        public float Length { get; set; }

        // Constructor
        public Arrow(ArrowheadType arrowheadType, FletchingType fletchingType, float length)
        {
            ArrowheadType = arrowheadType;
            FletchingType = fletchingType;
            Length = length;
        }

        // Method to calculate and return the arrow's cost
        public float GetCost()
        {
            float arrowheadCost = 0.0f;
            float fletchingCost = 0.0f;
            float shaftCost = Length * 0.05f;

            switch (ArrowheadType)
            {
                case ArrowheadType.Steel:
                    arrowheadCost = 10.0f;
                    break;
                case ArrowheadType.Wood:
                    arrowheadCost = 3.0f;
                    break;
                case ArrowheadType.Obsidian:
                    arrowheadCost = 5.0f;
                    break;
            }

            switch (FletchingType)
            {
                case FletchingType.Plastic:
                    fletchingCost = 10.0f;
                    break;
                case FletchingType.TurkeyFeathers:
                    fletchingCost = 5.0f;
                    break;
                case FletchingType.GooseFeathers:
                    fletchingCost = 3.0f;
                    break;
            }

            return arrowheadCost + fletchingCost + shaftCost;
        }

        public override string ToString()
        {
            return $"{ArrowheadType}, {FletchingType}, {Length}";
        }

        // Static method to create an Elite Arrow
        public static Arrow CreateEliteArrow()
        {
            return new Arrow(ArrowheadType.Steel, FletchingType.Plastic, 95);
        }

        // Static method to create a Beginner Arrow
        public static Arrow CreateBeginnerArrow()
        {
            return new Arrow(ArrowheadType.Wood, FletchingType.GooseFeathers, 75);
        }

        // Static method to create a Marksman Arrow
        public static Arrow CreateMarksmanArrow()
        {
            return new Arrow(ArrowheadType.Steel, FletchingType.GooseFeathers, 65);
        }
    }
}