using System;
using Xunit;

namespace TDD_övning_och_repetition
{
    public class UnitTest1
    {
        private DateTime GetDateForAge(int years)
        {
            return DateTime.Now.AddYears(-years);

        }

        [Fact]
        public void Test1()
        {

            var person = new Person("Elvis", GetDateForAge(41));
            Assert.Equal("Elvis", person.Name);
            Assert.Equal(41, person.Age);
        }

        [Fact]
        public void Test2()
        { 
            //var person = new Person(new DateTime(2021, 9, 13));
            var person = new Person(null, GetDateForAge(0));
            Assert.Null(person.Name);
            Assert.Equal(0, person.Age);
        }

        [Fact]
        public void Test3()
        {
           // var birthDate = new DateTime(2005, 1, 1);
           var birthDate = GetDateForAge(16);
            var person = new Person("Pelle", birthDate);
            Assert.False(person.canGetMarried);
            Assert.Equal(16, person.Age);
        }

        [Fact]
        public void Test4()
        {
            //var birthDate = new DateTime(2003, 1, 1);
            var birthDate = GetDateForAge(18);
            var person = new Person("Johan", birthDate);
            Assert.True(person.canGetMarried);
            Assert.Equal(18,person.Age);
        }

    }
}
