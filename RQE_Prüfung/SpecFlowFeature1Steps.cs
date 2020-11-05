using System;
using System.Globalization;
using TechTalk.SpecFlow;
using Xunit;

namespace Übung2
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        double number, x;
        [Given(@"the number is PI")]
        public void GivenTheNumberIsPI()
        {
            number = Math.PI;
        }
        [When(@"the sinus is taken")]
        public void WhenTheSinusIsTaken()
        {
            x = Math.Sin(number);
        }
        [When(@"the kosinus is taken")]
        public void WhenTheKosinusIsTaken()
        {
            x = Math.Cos(number);
        }
        [When(@"the tangens is taken")]
        public void WhenTheTangensIsTaken()
        {
            x = Math.Tan(number);
        }
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.Equal(p0, x, 5);
        }
    }
}
