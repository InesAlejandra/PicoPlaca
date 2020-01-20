# PicoPlaca

## Author
Inés Alejandra Burbano Ninabanda

## Project Description 🚀
Write a "Pico y Placa" predictor. Entries must be a license plate number (the complete number, not the last digit), a date (such as a Chain) and a time, and the program will return if that car may or may not be on the road.

## Schedule for vehicle.

- Monday: vehicles with plates finished in 1 and 2 have vehicle restrictions
- Tuesday: vehicles with plates finished in 3 and 4 have vehicle restrictions
- Wednesday: vehicles with plates finished in 5 and 6 have vehicle restrictions
- Thursday: vehicles with plates finished in 7 and 7 have vehicle restrictions
- Friday: vehicles with plates finished in 9 and 0 have vehicle restrictions

Note: This project was considered the past rules of the "Pico y Placa". (Hours: 7:00 a.m. - 9:30 a.m. / 4:00 p.m. - 7:30 p.m)

## Tests ⚙️
The tests were performed, with the Visual Studio 2017 tool itself

## Description of the tests 🔩
1. TestSchedule
 ###### Input 
 * Enter the time
 * Enter the range where peak and plate are applied.
 ###### Output
./ Returns true, if the time entered is within a specific specific range of the peak and plate. If it is outside the single range, it returns false.

2. TestRange
###### Input 
 * Enter the time
 ###### Output
Returns true if the time entered is within the ranges defined in the project.
If the time is outside the defined ranges, the function returns false

3. Test_VerifyDayPlate
###### Input 
 * Enter the license plate
###### Output 
 The test returns the day you have the vehicle restriction

4. Test_VerifyPicoyPlaca
###### Input 
 * Enter the time
 * Enter the Date
 ###### Output
This function returns the final result.
If the plaque and time entered is within the day and time of restriction, it returns "This car has vehicle restriction"
If the plate and time entered is outside the day and time of restriction, it returns "This car has no vehicle restriction"


## Development 🛠️
This project was developed with Visual Studio 2017.
The language used was C#


