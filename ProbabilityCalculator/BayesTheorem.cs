using System;
namespace ProbabilityCalculator;

public static class BayesTheorem
{
    // probabilityOfH - probability of HYPOTHESIS.
    // P(H)
    // Prior probability the hyphothesis is true.
    // How likely you thought you were to have the desiase prior to the result.

    // probabilityOfEGivenH - probability of EVENT given HYPOTHESIS
    // P(E|H)
    // Probability of the event given the hyphothesis is true.
    // The probability you were tested posetive if you had the desease.
    public static decimal Probability(decimal probabilityOfH, decimal probabilityOfEGivenH)
    {
        // P(E|H) * P(H)
        // How likely the hyphothesis(H) is true given the event(E).
        // How likely you have the desease.
        var probabilityOfHAndE = probabilityOfH * probabilityOfEGivenH;

        // P(-H)
        var probabilityOfNotH = 1 - probabilityOfH;
        //  P(E|-H)
        var probabilityOfEGivenNotH = 1 - probabilityOfEGivenH;

        // P(E) = P(H) * P(E|H) + P(-H) * P(E|-H)
        // Total probability of the event occurring.
        // Probability of testing posetive.
        var probabilityOfE = (probabilityOfH * probabilityOfEGivenH) + (probabilityOfNotH * probabilityOfEGivenNotH);

        // The result.
        var probabilityOfHGivenE = probabilityOfHAndE / probabilityOfE;
        return probabilityOfHGivenE;
    }

    public static decimal ProbabilityInPercents(decimal probabilityOfH, decimal probabilityOfEGivenH)
    {
        return Probability(probabilityOfH, probabilityOfEGivenH) * 100;
    }
}