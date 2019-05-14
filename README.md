# Gradebook

We need an electronic gradebook to read scores of individual student and then compute some simple statistics from the scores. 

The grades are entered as floating point numbers from 0 to 100, and the statistics should show us the highest grade, lowest grade, and the average grade. 

## Usage
$ dotnet run --project \<Path to the cs proj\> \<Usename\>\
Example\-\
$ dotnet run --project src/GradeBook/ Aditya

## Interaction
#### Add or remove grades
For now, the Program.cs file needs to be tweaked to add/remove grades and to change the name of the gradebook.