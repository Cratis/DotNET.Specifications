using Machine.Specifications;

namespace Cratis.Specifications.Specifications
{
    [Subject(typeof(Specification<>))]
    public class when_applying_a_not_rule_against_a_non_satisfying_instance : given.rules_and_colored_shapes
    {
        static bool is_satisfied;

        Because of = () => is_satisfied = Is.Not(squares).IsSatisfiedBy(green_circle);

        It should_be_satisfied = () => is_satisfied.ShouldBeTrue();
    }
}