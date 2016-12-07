using Machine.Specifications;

namespace Cratis.Specifications.Specifications.for_Negative
{
    [Subject(typeof(Specification<>))]
    public class when_applying_a_not_rule_against_a_satisfying_instance : given.rules_and_colored_shapes
    {
        static bool is_satisfied;

        Because of = () => is_satisfied = Is.Not(squares).IsSatisfiedBy(green_square);

        It should_be_not_satisfied = () => is_satisfied.ShouldBeFalse();
    }
}