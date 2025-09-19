/*
 * 3 Ett företag har namn, adress, telefonnummer, faxnummer, hemsida och chef. 
 * Chefen har förnamn, efternamn, e-postadress och telefonnummer. 
 * Skriv ett program som läser informationen om företaget och chefen och skriver dem 
 * till konsolen.
 */

using _03_Företagsinformation;

Company KYH = new Company();
KYH.name = "KYH";
KYH.address = "Storgatan 7";
KYH.phoneNumber = "+46812345678";
KYH.faxNumber = "+46898765431";
KYH.webSite = "https://kyh.se";

// Skriv ut data
KYH.PrintInformation();



Console.Write("\n\nTryck på en tangent för att fortsätta...");
Console.ReadKey();