# Development Project
To gain a better understanding of your technical, design and logic skills, we would like you to create a project using the technologies of your choice (preferably .NET, C#, AngularJS, Angular) with the following requirements.

 
# Task
As a Member I would like to have an ability to choose various options on the screen So that I can view the monthly premiums calculated and displayed on the screen

 

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
Given all the input fields are specified, change in the occupation dropdown should trigger the premium calculation