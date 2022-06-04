# ST10084433-PROG6211-POE

Welcome to the README for the Budgeting App program:
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
This app has been designed to allow the user to manage their finances and provides an easy method of viewing their funds after monthly deductions have been made

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
Author: Matthew Kidwell
Version: 2.0

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
Software requirements:

- Microsoft Visual Studio 2022 
- Netframework version (6.0)

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
Installation instructions:

- download the zipped folder (unzip after downloading)
- place the unzipped folder in your repos which can be found on filepath: C:\Users\"your user name"\source\repos
- ensure that microsoft visual studio is installed before launching application, if not, it can be downloaded here: https://visualstudio.microsoft.com/downloads/ (choose the community edition)
- launch program in visual studio 	

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
Instructions for using the application:

Once in Visual Studio:

Step 1 - launch the budgeting app

Step 2 - input your figures into the required fields as they appear

Step 3 - you will be prompted on whether you are making a property purchase or renting monthly, choose accordingly

Step 4 - if purchasing a property is chosen, then you will be prompted to input values in order for a loan amount to be calculated

Step 5 - if rent is chosen, Step 4 is skipped and you will be prompted on whether you would like to purhcase a vehicle or not

Step 6 - if yes, then you will be able to input values for the make ,model and other relevant figures required, which in turn will calculate your monthly car repayment cost

Step 7 - if you do not purchase a car step 6 will be skipped, you will be prompted on whether you want to display all your expenses, 
         if yes they will be displayed, if not, this step will be skipped

Step 8 -  a final prompt will be made for whether you may want to run the app again or not, if yes, follow steps 1 through 7 again, if not
         , the app will close down
         
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
Frequently Asked Questions:

Q: Will I be able to save data entered and use it upon a rerun of the program?

A: No, the data is not persistent and will not carry over upon a second run of the program.


Q: Will I be able to use an older edition of Microsoft Visual Studio?

A: It is recommended that the latest version of Microsoft Visual Studio is installed, it is not guaranteed that older versions will run our program without error.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
Contact info: 

Cell no: 084 737 0358

Email: st10084433@vcconnect.edu.za

VC Student number: ST10084433

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
Github:
https://github.com/Mxttk/ST100084433-PROG-POE.git

**NOTE: Never committed first attempt to repository, first commit was made with Part 2 of the POE only**

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
Code Attribution:

Reversing the list<T>:  https://tinyurl.com/2p96thsy
         
Delegates:  https://tinyurl.com/237tdwh7
         
Anon method:  https://tinyurl.com/3ts45zh2
         
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
Changes implemented after feedback:

Main class:
- removed input method call + added vehicle method call
- edited housekeeping to be more visually pleasing
- added input method call from vehicle class
- additional housekeeping when user decsion is required

Expenses class:
- added housekeeping
- removed input class and moved method from input class into expenses class for 
  code efficiency (new method called expenses)
- added new abstract method "input"
- moved list of T into expenses class --> made it static
- created new variable totalExpenses == expensesList.Sum

Homeloan class:
- renamed accomodation class to input --> overrides from expenses class
- added housekeeping  
- neatened up code with additional Console.Writelines and addition of colour

Calc class:
- calc now inherits from expenses 
- changed endAmount method to input --> overrides from expenses class
- Housekeeping added 
- removed expenses local vartiable --> totalExpenses variable used from expenses class in calc
- created delegate "msgDel" + anon method that warns user if expenses are over 75% of income
- sorted the list of T, reversed it and printed it out using a foreach loop

**Vehicle class added**:
- housekeeping added
- takes user input if decision to buy car is made
- monthly amount calaculated
- prints out at the end the monthly repayment amount 

**Detailed Expenses class added**:
- prompts for decision to view detailed expenses list
- if yes, then all inputted expenses will be displayed to the user

General:
- added additional documentation throughout the code
         
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
We hope this guide will assist you in effectively utilising our budgeting app 

