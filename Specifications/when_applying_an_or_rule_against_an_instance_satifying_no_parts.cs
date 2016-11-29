using Machine.Specifications;

namespace Cratis.Specifications.Specifications
{
    [Subject(typeof(Specification<>))]
    public class when_applying_an_or_rule_against_an_instance_satifying_no_parts : given.rules_and_colored_shapes
    {
        static bool is_satisfied;

        Because of = () => is_satisfied = squares.Or(green).IsSatisfiedBy(red_circle);

        It should_not_be_satisfied = () => is_satisfied.ShouldBeFalse();
    }
}