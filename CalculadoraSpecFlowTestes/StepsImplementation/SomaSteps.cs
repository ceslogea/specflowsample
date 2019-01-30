using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace CalculadoraSpecFlowTestes.StepsImplementation
{
    [Binding]
    public class SomaSteps
    {
        private List<int> _arrSoma = new List<int>();
        private int _result;
        
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            _arrSoma.Add(p0);
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            _result = _arrSoma.Sum();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.AreEqual(_result, p0);
        }
    }
}
