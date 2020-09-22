# Softuni-Exam
QA Automation 2020

---------------------------------------------------------------
---------------------------------------------------------------
2.1 AutoComplete

This task will give you 30 points if you fulfil all the main conditions above.
Create a test with Selenium WebDriver which does the following:

Navigates to https://demoqa.com/
Clicks on "Widgets"
Clicks on "Auto Complete"
Types "Red" in "Multi color names" input field
Clicks Enter
Types "Re" in "Multi color names" input filed
Asserts that only one option is shown - "Green"

---------------------------------------------------------------
---------------------------------------------------------------
2.2 Date Picker

This task will give you 45 points if you fulfil all the conditions above. You should implement three different tests with some shared steps. Doing this task, you should have in mind the Don't Repeat Yourself principle in programming.
Shared steps:

Navigate to https://demoqa.com/
Click on "Widgets"
Click on "Date Picker"
Remove date from "Select Date"
Type RANDOM Date for 2020
---------------------------------------------------------------

Sub tasks to assert:

  10 points for the following assert:
  The selected day has:

  Background: rgba(33, 107, 165, 1)
  Color: rgba(255, 255, 255, 1)
  ---------------------------------------------------------------
  
15 points for the following assert:
  On hover the selected day has:

Background: rgba(29, 93, 144, 1)
Color: rgba(255, 255, 255, 1)
---------------------------------------------------------------
20 points for the following assert:
On hover any other than selected day has:

Background: rgba(240, 240, 240, 1)
Color: rgba(0, 0, 0, 1)
