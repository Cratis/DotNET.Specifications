using Machine.Specifications;

namespace Cratis.Specifications.Specifications
{
    [Subject(typeof(Specification<>))]
    public class when_applying_an_or_rule_against_an_instance_satifying_only_one_part : given.rules_and_colored_shapes
    {
        static bool is_satisfied;

        Because of = () => is_satisfied = squares.Or(green).IsSatisfiedBy(red_square);

        It should_be_satisfied = () => is_satisfied.ShouldBeTrue();
    }
}