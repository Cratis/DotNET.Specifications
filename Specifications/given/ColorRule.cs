namespace Cratis.Specifications.Specifications.given
{
    public class ColorRule : Specification<ColoredShape>
    {
        readonly string _Color;

        public ColorRule(string matchingColor)
        {
            _Color = matchingColor;
            Predicate = shape => shape.Color == _Color;
        }
    }
}