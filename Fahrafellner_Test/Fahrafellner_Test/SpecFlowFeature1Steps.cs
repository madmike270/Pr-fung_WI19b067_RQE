using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Fahrafellner_Test
{
    [Binding]
    public class SpecFlowFeature1Steps
    {

        [Given(@"null")]
        public void GivenNull()
        { 

        }
        
        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"pi is returned")]
        public void ThenPiIsReturned()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"sin is (.*)")]
        public void ThenSinIs(Decimal p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Cos is (.*)")]
        public void ThenCosIs(Decimal p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"tan is (.*)")]
        public void ThenTanIs(Decimal p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
