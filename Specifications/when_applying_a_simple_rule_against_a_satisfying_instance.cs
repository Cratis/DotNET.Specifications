using Machine.Specifications;

namespace Cratis.Specifications.Specifications
{
    [Subject(typeof (Specification<>))]
    public class when_applying_a_simple_rule_against_a_satisfying_instance : given.rules_and_colored_shapes
    {
        static bool is_satisfied;

        Because of = () => is_satisfied = squares.IsSatisfiedBy(green_square);

        It should_be_satisfied = () => is_satisfied.ShouldBeTrue();
    }
}