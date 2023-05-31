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
        // Fields
        private ArrowheadType arrowheadType;
        private FletchingType fletchingType;
        private float length;

        // Constructor
        public Arrow(ArrowheadType arrowheadType, FletchingType fletchingType, float length)
        {
            this.arrowheadType = arrowheadType;
            this.fletchingType = fletchingType;
            this.length = length;
        }

        public ArrowheadType GetArrowHeadType()
        {
            return this.arrowheadType;
        }

        public void SetArrowHeadType(ArrowheadType NewArrowHeadType)
        {
            this.arrowheadType = NewArrowHeadType;
        }

        public FletchingType GetFletchingType()
        {
            return this.fletchingType;
        }

        public void SetFletchingType(FletchingType NewFletchingType)
        {
            this.fletchingType = NewFletchingType;
        }

        public float GetLength()
        {
            return this.length;
        }

        public void SetLength(float NewLength)
        {
            this.length = NewLength;
        }

        // Method to calculate and return the arrow's cost
        public float GetCost()
        {
            float arrowheadCost = 0.0f;
            float fletchingCost = 0.0f;
            float shaftCost = length * 0.05f;

            switch (arrowheadType)
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

            switch (fletchingType)
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
            return $"{this.arrowheadType}, {this.fletchingType}, {this.length}";
        }
    }   
}

