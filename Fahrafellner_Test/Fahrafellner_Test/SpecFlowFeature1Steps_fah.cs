using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Fahrafellner_Test
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        private double _number;

        [Given(@"the number is Pi")]
        public void GivenTheNumberIsPi()
        {
            _number = Math.PI;
        }
        
        [Then(@"sinus is (.*)")]
        public void ThenSinusIs(int p0)
        {
            Assert.AreEqual(p0,Math.Sin(_number),5);
        }
        
        [Then(@"cos is (.*)")]
        public void ThenCosIs(int p0)
        {
            Assert.AreEqual(p0, Math.Cos(_number), 5);
        }
        
        [Then(@"tang is (.*)")]
        public void ThenTangIs(int p0)
        {
            Assert.AreEqual(p0, Math.Tan(_number), 5);
        }
    }
}
