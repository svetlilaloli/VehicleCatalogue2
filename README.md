Console application<br/>
Objects and Classes - Exercise<br/>

# Vehicle Catalogue
You have to create a vehicle catalogue. You will store only two types of vehicles – a **car** and a **truck**. Until you receive the **“End”** command you will be receiving **lines** of **input** in the following format:<br/><br/>
**{typeOfVehicle} {model} {color} {horsepower}**<br/><br/>
After the **“End”** command, you will start receiving **models** of **vehicles**. Print the **data** for every received vehicle in the following format:<br/><br/>
**Type: {typeOfVehicle}<br/>
Model: {modelOfVehicle}<br/>
Color: {colorOfVehicle}<br/>
Horsepower: {horsepowerOfVehicle}<br/><br/>**

When you receive the command **“Close the Catalogue”**, print the **average horsepower** for the **cars** and for the **trucks** in the following format:<br/><br/>
**{typeOfVehicles} have average horsepower of: {averageHorsepower}.**<br/><br/>
The **average horsepower** is calculated by **dividing** the **sum** of the **horsepower** of **all** vehicles from the certain type by the **total count** of **vehicles** from the **same type**. Round the answer to the **2nd digit after the decimal separator**.<br/>
## Constraints
* The type of vehicle will always be either a **car** or a **truck**.
* You will not receive the **same model twice**.
* The received horsepower will be an integer in the range **[1…1000]**
* You will receive at most **50** vehicles.
* The separator will always be a **single whitespace**.
## Examples
**Input** | **Output**
----------|-----------
truck Man red 200|
truck Mercedes blue 300|
car Ford green 120|
car Ferrari red 550|
car Lamborghini orange 570|
End|
Ferrari|Type: Car<br/>Model: Ferrari<br/>Color: red<br/>Horsepower: 550
Ford|Type: Car<br/>Model: Ford<br/>Color: green<br/>Horsepower: 120
Man|Type: Truck<br/>Model: Man<br/>Color: red<br/>Horsepower: 200
Close the Catalogue|Cars have average horsepower of: 413.33.<br/>Trucks have average horsepower of: 250.00.
