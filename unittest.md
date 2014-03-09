Unit test
=========

!

##Forberedelse:

Hent koden: [https://github.com/steenhulthin/CircleCalculation](https://github.com/steenhulthin/CircleCalculation)

(Slides: [http://steenhulthin.github.io/CircleCalculation](http://steenhulthin.github.io/CircleCalculation))

!

##Hvad er en unit test?

Kode der tester kode 
- p&aring; klasse eller funktions niveau.

!

#Testpyramiden

* UI - Der hvor brugeren er.
* Service
* Unit

!

##Hvorfor unit test?

Det er jo det brugeren ser der t&aelig;ller!

!

#Eksempel:

##CircleCalculation.exe

TV-køkken!!!

!

#Navngivning

Brug [Roy Osherove's konvention](http://osherove.com/blog/2005/4/3/naming-standards-for-unit-tests.html) til at starte med.

`<Metode/function>_<tilstand/input>_<forventetResultat>`

!

#&Oslash;velse 1

##Skriv en test til `CalculateArea`

`Assert` at en cirkel med radius 3 har arealet 9 * Pi

!

#Hvordan gik det?

!

##Test Driven Development (TDD)

- `Red` - Skriv og k&oslash;r test der fejler

- `Green` - F&aring; den til at virke

- `Refactor` - Refaktorer og se at det stadig virker

!

#&Oslash;velse 2

##Skriv en test til `CalculateCircumference`

(den findes ikke endnu...)

En cirkel med radius 3 har omkredsen 6 * Pi

!

Lykkedes det?

!

#Versionsstyring

Hvorn&aring;r kan jeg checke ind i TFS?

!

#Bonusrunden

[Build/CI server](https://ci.appveyor.com/project/steenhulthin/circlecalculation)

!

#Hvordan kommer man i gang?

* (Build Server!)
* Skriv kun tests til nyt kode
* Skriv først testen som kommentarer
* Skriv kode sammen!
* Skriv (mindst) een test om dagen

!

#Kunne det bruges til noget?

!

#Hjemmeopgaver!

* Hvad med negativ radius??
* Argumentparsning er ikke køn, gør noget!?

(Man kunne måske forestille sig en argumentparserklasse?)

!

*Skrub så ud og skriv nogle unit tests!*