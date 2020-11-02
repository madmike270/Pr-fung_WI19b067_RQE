Feature: SpecFlowFeature1

 In order to avoid silly mistakes
 As a mathematician
 I want to be told the result of specific operations

@mytag

Scenario: CalcPi

 Given null
 Then pi is returned

 Scenario: CalcSin

 Given the first number is 50
 Then sin is -0.26


Scenario: CalcCos

 Given the first number is 50
 Then Cos is 0.96



Scenario: CalcTan

 Given the first number is 50

 Then tan is -0.27



