
UI and API AUTOMATION USING BDD FRAMEWORK

Contents:
1.	Purpose of  UI and API Automation Framework.
2.	Overview
3.	Framework structure
6.	Packages used
7.	Code Optimization
8.	Reporting

Purpose of SpecFlow UI andAPI Automation Framework:

The purpose for this  automation framework is to serve a technical implementation guideline for automation testing.
With the help for BDD implementation this framework not only helps to reuse the code but also helps to set standard for test scripts.

Overview:

To automate UI and  API this framework uses SpecFlow which is a testing framework that supports Behaviour Driven Development (BDD). 


Framework structure:
1.	Tests Folder:

All the feature files and step definition files are kept under the Test folder. These tests are described here in a simple English language called as Gherkin language.

2.	Test Class Folder:

This folder contains the class file for the tests which helps us to convert JSON inputs or JSON response to .Net type.

3.	Test Data Folder:

This folder contains various combination of json inputs/params required to provide for an API. These files are in json format. You can provide positive as well as negative inputs to the API.

4.	Reports Folder:

The test results are under this folder. This report is in html format.

5.	 Helper Folder:

The helper folder contains helper classes which intends to give quick implementation of basic methods that can be used again and again.

Packages used: 
Microsoft.AspNet.WebApi.Client, Version: 5.2.7 NUnit, Version: 3.12.0 Newtonsoft.Json, Verison: 12.0.2 Specflow, Version: 2.3.2 ExtentReports, Version: 3.1.3

Tools:
C#
Specflow
Selenium
Use JetBrains Rider for Best Experience

Description:
This framework created as a part of the challenge to facilitate the API and UI both together.

