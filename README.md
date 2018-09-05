# SimpleConsole
Console App to fulfill an input-output task 
 create a command line application that takes in an user input. After an input the application will ask the user for another. the application will only quit with the word "quit".
The input will be either a numerical array or a string.
If a numerical array input, please find the average, medium, mode, and range. Spaces are the delimiter.

example input = "1 2 3 4 5 6 7"
output:
average = 4
median = 4
mode = none
range = 7

If a literal string, please count the occurrence of each character and display it in alphabetical order. Spaces and special characters are ignored.
example: 
input: "thisis a samplestring"
output:
a: 2
e: 1
g: 1
h: 1
i: 3
l: 1
m: 1
n: 1
p: 1
r: 1
s: 4
t: 2

Here are some some test cases for you:
"1 2 13 45 99 0 0 0 1"
"0"
"sunsoutgunsout"
"quit quit"
"I am n0thing m0r3 than a string. I t00 hav3 a l3xic0graphic 0rd3r."

Please check in your code in your personal git account, this will make it public. Please make sure to have a git ignore file and a Readme file.
if you make any assumptions, please list them in the readme.
if you have any questions please let me know.

If you really want to wooooo me:
add the ability to handle negative numbers - done
add the ability to handle special characters - done
add unit tests  - researching

#Implementation:
1. Handle special cases, like ending the session, or sending null input.
2. Depending on the input the data structure would be different
Check is the string is all integers . Implement mathematical actions per description.
Check if it has spaces and integers only --> if yes, do the computations per req.
Otherwise, make a dictionary from the symbols (special characters and letters, excluding spaces) and their count, rpint out.

