# Museum-Windows-Forms-App
The diagram of the MuzeuDB database is the following:

![MuzueDB diagram](https://github.com/Ampersand25/Museum-Windows-Forms-App/blob/main/Database%20diagram/Diagram_MuzeuDB.png)
<hr>

Below are some screenshots taken during the run of the 3 applications:

- <b>1st application - MuseumWindowsFormsApp (simple application that displays data from two particular tables from the database which are in a one to many (1:n) relation)</b>

![1st ss](https://github.com/Ampersand25/Museum-Windows-Forms-App/blob/main/Screenshots/Screenshot%201.png)
<p align="center"><strong>Image 1</strong> - first background of the first application</p>
<hr>

![2nd ss](https://github.com/Ampersand25/Museum-Windows-Forms-App/blob/main/Screenshots/Screenshot%202.png)
<p align="center"><strong>Image 2</strong> - second background of the first application</p>
<hr>

![3rd ss](https://github.com/Ampersand25/Museum-Windows-Forms-App/blob/main/Screenshots/Screenshot%203.png)
<p align="center"><strong>Image 3</strong> - third background of the first application</p>
<hr>

- <b>2nd application - BasicMuseumGenericWindowsFormsApp (first application but general (the app shows the records/lines/rows from two tables from the database with the condition that the tables are in a one to many (1:n) relation))</b>

![4th ss](https://github.com/Ampersand25/Museum-Windows-Forms-App/blob/main/Screenshots/Screenshot%204.png)
<p align="center"><strong>Image 4</strong> - first running scenario for the second application: first DataGridView displays the records/lines/rows from the table named "Ghizi" (parent table from MuzeuDB database that represents the part 1 (one) of the relation 1:n (one to many)) and the second DataGridView displays, for the selected record/line/row from the parent table, the records/lines/rows asscociated from the table named "FosileDinozauri" (child table from MuzeuDB database that represents the part n (many) of the relation 1:n (one to many))</p>
<hr>

![5th ss](https://github.com/Ampersand25/Museum-Windows-Forms-App/blob/main/Screenshots/Screenshot%205.png)
<p align="center"><strong>Image 5</strong> - second running scenario for the second application: first DataGridView displays the records/lines/rows from the table named "Vitrine" (parent table from MuzeuDB database that represents the part 1 (one) of the relation 1:n (one to many)) and the second DataGridView displays, for the selected record/line/row from the parent table, the records/lines/rows asscociated from the table named "Vase" (child table from MuzeuDB database that represents the part n (many) of the relation 1:n (one to many))</p>
<hr>

![6th ss](https://github.com/Ampersand25/Museum-Windows-Forms-App/blob/main/Screenshots/Screenshot%206.png)
<p align="center"><strong>Image 6</strong> - third (and last) running scenario for the second application: first DataGridView displays the records/lines/rows from the table named "Paznici" (parent table from MuzeuDB database that represents the part 1 (one) of the relation 1:n (one to many)) and the second DataGridView displays, for the selected record/line/row from the parent table, the records/lines/rows asscociated from the table named "Bijuterii" (child table from MuzeuDB database that represents the part n (many) of the relation 1:n (one to many))</p>
<hr>

- <b>3rd application - MuseumGenericWindowsFormsApp (second application but with: log in (sign in) window/form, registration (sign up) window/form and two splash screens for transitioning between different forms)</b>

![7th ss](https://github.com/Ampersand25/Museum-Windows-Forms-App/blob/main/Screenshots/Screenshot%207.png)
<p align="center"><strong>Image 7</strong> - start splash screen (loading screen) which is displayed when the application starts and shows the loading progress of the app/p>
<hr>
  
![8th ss](https://github.com/Ampersand25/Museum-Windows-Forms-App/blob/main/Screenshots/Screenshot%208.png)
<p align="center"><strong>Image 8</strong> - log/sign in window (form) where the user can enter his credentials (if the user has an account created in the application)</p>
<hr>

![9th ss](https://github.com/Ampersand25/Museum-Windows-Forms-App/blob/main/Screenshots/Screenshot%209.png)
<p align="center"><strong>Image 9</strong> - completing the username and password inputs from the log in (sign in) page</p>
<hr>

![10th ss](https://github.com/Ampersand25/Museum-Windows-Forms-App/blob/main/Screenshots/Screenshot%2010.png)
<p align="center"><strong>Image 10</strong> - pressing "Show Password" button (the effect of pressing the button is that now the password is visible to the user (if the user presses "Hide Password" then the password from the input will be again displayed using '*' characters))</p>
<hr>

![11th ss](https://github.com/Ampersand25/Museum-Windows-Forms-App/blob/main/Screenshots/Screenshot%2011.png)
<p align="center"><strong>Image 11</strong> - sign up (registration) window (form) where the user can create an account for the application (the password will be encrypted, before storing it in the database, using an encryption algorithms)</p>
<hr>

![12th ss](https://github.com/Ampersand25/Museum-Windows-Forms-App/blob/main/Screenshots/Screenshot%2012.png)
<p align="center"><strong>Image 12</strong> - image that demonstrates how the user can complete incorrectly (the two passwords ("Password" and "Confirm Password") do not match) the inputs from registration form</p>
<hr>

![13th ss](https://github.com/Ampersand25/Museum-Windows-Forms-App/blob/main/Screenshots/Screenshot%2013.png)
<p align="center"><strong>Image 13</strong> - image that demonstrates how the user can complete correctly the inputs from registration form</p>
<hr>

![14th ss](https://github.com/Ampersand25/Museum-Windows-Forms-App/blob/main/Screenshots/Screenshot%2014.png)
<p align="center"><strong>Image 14</strong> - splash screen that is used to transition between log/sign in form or sign up and main window</p>
<hr>

![15th ss](https://github.com/Ampersand25/Museum-Windows-Forms-App/blob/main/Screenshots/Screenshot%2015.png)
<p align="center"><strong>Image 15</strong> - first running scenario for the third application: first DataGridView displays the records/lines/rows from the table named "Ghizi" (parent table from MuzeuDB database that represents the part 1 (one) of the relation 1:n (one to many)) and the second DataGridView displays, for the selected record/line/row from the parent table, the records/lines/rows asscociated from the table named "FosileDinozauri" (child table from MuzeuDB database that represents the part n (many) of the relation 1:n (one to many))</p>
<hr>

![16th ss](https://github.com/Ampersand25/Museum-Windows-Forms-App/blob/main/Screenshots/Screenshot%2016.png)
<p align="center"><strong>Image 16</strong> - second running scenario for the third application: first DataGridView displays the records/lines/rows from the table named "Vitrine" (parent table from MuzeuDB database that represents the part 1 (one) of the relation 1:n (one to many)) and the second DataGridView displays, for the selected record/line/row from the parent table, the records/lines/rows asscociated from the table named "Vase" (child table from MuzeuDB database that represents the part n (many) of the relation 1:n (one to many))</p>
<hr>

![17th ss](https://github.com/Ampersand25/Museum-Windows-Forms-App/blob/main/Screenshots/Screenshot%2017.png)
<p align="center"><strong>Image 17</strong> - third (and last) running scenario for the third application: first DataGridView displays the records/lines/rows from the table named "Paznici" (parent table from MuzeuDB database that represents the part 1 (one) of the relation 1:n (one to many)) and the second DataGridView displays, for the selected record/line/row from the parent table, the records/lines/rows asscociated from the table named "Bijuterii" (child table from MuzeuDB database that represents the part n (many) of the relation 1:n (one to many))</p>
<hr>
