using System;
using Xunit;

namespace TDD_övning_och_repetition
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var person = new Person("Emil", new DateTime(1994, 2, 7));
            Assert.Equal("Emil", person.Name);
            Assert.Equal(27, person.Age);
        }

        [Fact]
        public void Test2()
        {
            var person = new Person(null, new DateTime(2021, 9, 13));
            Assert.Null(person.Name);
            Assert.Equal(0, person.Age);
        }
    }
}
