using Machine.Specifications;

namespace Cratis.Specifications.Specifications.for_And
{
    [Subject(typeof(Specification<>))]
    public class when_applying_an_and_rule_against_a_instance_satifying_only_one_part : given.rules_and_colored_shapes
    {
        static bool is_satisfied;

        Because of = () => is_satisfied = squares.And(green).IsSatisfiedBy(red_square);

        It should_not_be_satisfied = () => is_satisfied.ShouldBeFalse();
    }
}