using Xunit;
using Moq;
using SDC.Core;
using FluentAssertions;

namespace SDC.UseCases.Tests
{
    public class CreateEventTests
    {
        [Fact]
        public void ShouldCreateAnEvent()
        {
            // ARRANGE
            var expected = new EventEntity();
            var stubRepository = new Mock<IEventRepository>().Object;
            var useCase = new CreateEventUseCase(stubRepository);

            // ACT
            var actual = useCase.Handle();

            // ASSERT
            actual.Should().Be(expected);
        }
    }
}
