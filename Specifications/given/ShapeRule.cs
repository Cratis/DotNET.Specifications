namespace Cratis.Specifications.Specifications.given
{
    public class ShapeRule : Specification<ColoredShape>
    {
        readonly string _shape;

        public ShapeRule(string matchingShape)
        {
            _shape = matchingShape;
            Predicate = shape => shape.Shape == _shape;
        }
    }
}