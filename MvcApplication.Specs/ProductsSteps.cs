using System;
using TechTalk.SpecFlow;

namespace MvcApplication.Specs
{
    [Binding]
    public class ProductsSteps
    {
        [Given(@"I navigate to the '(.*)' page")]
public void GivenINavigateToThePage(string p0)
{
    ScenarioContext.Current.Pending();
}

        [Given(@"I enter a Name of '(.*)'")]
public void GivenIEnterANameOf(string p0)
{
    ScenarioContext.Current.Pending();
}

        [Given(@"I enter a Price of '(.*)'")]
public void GivenIEnterAPriceOf(Decimal p0)
{
    ScenarioContext.Current.Pending();
}

        [When(@"I click '(.*)'")]
public void WhenIClick(string p0)
{
    ScenarioContext.Current.Pending();
}

        [Then(@"the last product should have title '(.*)'")]
public void ThenTheLastProductShouldHaveTitle(string p0)
{
    ScenarioContext.Current.Pending();
}

        [Then(@"the last product should have price '(.*)'")]
public void ThenTheLastProductShouldHavePrice(Decimal p0)
{
    ScenarioContext.Current.Pending();
}
    }
}
