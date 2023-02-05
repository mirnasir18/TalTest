
# This project will is developed in .net core as back end and Anular 15 as front end.


# Develop an UI which accepts the below data and return a monthly premium amount to be calculated.

Name
Age
Date of Birth
Occupation
Death – Sum Insured.
 

The UI provides a below list of occupations

Occupation

Occupation

Rating

Cleaner

Light Manual

Doctor

Professional

Author

White Collar

Farmer

Heavy Manual

Mechanic

Heavy Manual

Florist

Light Manual

 

There is a factor associated with each rating as below,

 

Occupation Rating

Rating

Factor

Professional

1.0

White Collar

1.25

Light Manual

1.50

Heavy Manual

1.75

  

For any given individual the monthly premium is calculated using the below formula
Death Premium = (Death Cover amount * Occupation Rating Factor * Age) /1000 * 12

All input fields are mandatory.
Given all the input fields are specified, change in the occupation dropdown  trigger the premium calculation