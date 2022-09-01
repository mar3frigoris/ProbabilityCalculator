using System;
using ProbabilityCalculator;

namespace ProbabilityTests;

public class BayesTheoremTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void RareDeseaseTestedPosetive()
    {
        // Hyphothesis: The desiase affects 0.1% of the population.
        // 0.1% - 1 of 1000 = 0.001
        var probabilityOfHyphothesis = 0.001m;
        // Event: You have tested posetive.
        // The accuracy of the test is 99%.
        var probabilityOfEventGivenHyphothesis = 0.99m;

        var probability = BayesTheorem.ProbabilityInPercents(probabilityOfHyphothesis, probabilityOfEventGivenHyphothesis);
        var roundedProbability = Math.Round(probability);
        Assert.AreEqual(9, roundedProbability);
    }

    [Test]
    public void RareDeseaseTestedPosetiveTwice()
    {
        // Hyphothesis: The desiase affects 0.1% of the population.
        // 0.1% - 1 of 1000 = 0.001
        var probabilityOfHyphothesis = 0.001m;
        // Event: You have tested posetive.
        // The accuracy of the test is 99%.
        var probabilityOfEventGivenHyphothesis = 0.99m;
        // Counting probability after you were tested posetive once.
        var probabilityAfterFirstTest = BayesTheorem.ProbabilityInPercents(probabilityOfHyphothesis, probabilityOfEventGivenHyphothesis);
        // Probability after you were tested posetive twice.
        var probabilityAfterSecondTest = BayesTheorem.ProbabilityInPercents(probabilityAfterFirstTest / 100, probabilityOfEventGivenHyphothesis);

        var roundedProbability = Math.Round(probabilityAfterSecondTest);
        Assert.AreEqual(91, roundedProbability);
    }
}

