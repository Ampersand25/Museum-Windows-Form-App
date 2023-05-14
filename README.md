# Museum-Windows-Forms-App
Credits for the icons used in the application (visit https://www.flaticon.com/ for more amazing free icons):
- Museum icons created by Freepik              - Flaticon: https://www.flaticon.com/free-icons/museum
- Info icons created by Freepik                - Flaticon: https://www.flaticon.com/free-icons/info
- User icons created by Phoenix Group          - Flaticon: https://www.flaticon.com/free-icons/user
- Password icons created by Prosymbols Premium - Flaticon: https://www.flaticon.com/free-icons/password
- Eye icons created by Kiranshastry            - Flaticon: https://www.flaticon.com/free-icons/eye
- Password icons created by th studio          - Flaticon: https://www.flaticon.com/free-icons/password
- Museum icons created by Freepik              - Flaticon: https://www.flaticon.com/free-icons/museum
- Register icons created by Freepik            - Flaticon: https://www.flaticon.com/free-icons/register
- Eye icons created by Freepik                 - Flaticon: https://www.flaticon.com/free-icons/eye
- Show password icons created by Stasy         - Flaticon: https://www.flaticon.com/free-icons/show-password
- Dinosaur icons created by Smashicons         - Flaticon: https://www.flaticon.com/free-icons/dinosaur
- Logout icons created by Pixel perfect        - Flaticon: https://www.flaticon.com/free-icons/logout
- Wrong icons created by Vector Squad          - Flaticon: https://www.flaticon.com/free-icons/wrong
- Ok icons created by icon wind                - Flaticon: https://www.flaticon.com/free-icons/ok
- Pillar icons created by Freepik              - Flaticon: https://www.flaticon.com/free-icons/pillar
<hr>

The diagram of the MuzeuDB database is the following (the database scripts can be found at the following link: https://github.com/Ampersand25/Museum-Windows-Forms-App/tree/main/Database%20scripts):

![MuzueDB diagram](https://github.com/Ampersand25/Museum-Windows-Forms-App/blob/main/Database%20diagram/Diagram_MuzeuDB.png)
<hr>

Each app has the following:
- a master detail window (generic for second and third applications)
- two DataGridView tables that shows all the entries from the two tables (parent table ("master") and child table ("detail"))
- different backgrounds that can be changed
- labels for displaying text
- buttons for the CRUD (Create, Read, Update, Delete) operations, for refreshing the content of the two tables and for changing the current background
- NumericUpDown controls for number columns/fields/attributes (like primary key which is an integer value) from child (the part n/many of the relation one to many (1:n)) table
- TextBox controls (inputs) for text (varchar) columns/fields/attributes from child (the part n/many of the relation one to many (1:n)) table
- ComboBox control for selecting the column/field/attribute which is the foreign key in the child (the part n/many of the relation one to many (1:n)) table (the ComboBoxes contains all the primary keys from the parent ("master") table)
<hr>

All applications have the following features:
- viewing data (all the entries) from the two tables (parent one and child one) from the database
- creating/adding a new record/line/row for the child ("detail") table
- updating/modifying an existing record/line/row from the child ("detail") table
- removing/deleting an existing record/line/row from the child ("detail") table
- refreshing the two DataGridView tables (after add, update and delete operations we need to refresh the two tables so that the data displayed will be updated)
<hr>

Running scenarios (that can also be found at the following link: https://github.com/Ampersand25/Museum-Windows-Forms-App/tree/main/Running%20scenarios%20for%20generic%20app) for the generic applications (2nd and 3rd apps):
- <b>first running scenario ("master" table is table "Ghizi" from the database and "detail" table is the table "FosileDinozauri" from the database)</b>:
<add key="parentTable" value="[MuzeuDB].[dbo].[Ghizi]" />
<add key="childTable" value="[MuzeuDB].[dbo].[FosileDinozauri]" />
<add key="parentTableName" value="Ghizi" />
<add key="childTableName" value="FosileDinozauri" />
<add key="foreignKeyName" value="CNPGhid" />
<add key="foreignKeyRelation" value="fk_FosileDinozauri_CNPGhid" />
<add key="insertColumns" value="[FosilaDinozaurID], [TipDinozaur], [FamilieDinozaur], [Epoca], [NrOase], [CNPGhid]" />
<add key="insertValues" value="@value1, @value2, @value3, @value4, @value5, @value6" />
<add key="updateValues" value="[TipDinozaur]=@value2, [FamilieDinozaur]=@value3, [Epoca]=@value4, [NrOase]=@value5, [CNPGhid]=@value6" />
<add key="updateCondition" value="[FosilaDinozaurID]=@value1" />
<add key="deleteCondition" value="[FosilaDinozaurID]=@value1" />
- <b>second running scenario ("master" table is table "Vitrine" from the database and "detail" table is the table "Vase" from the database)</b>:
<add key="parentTable" value="[MuzeuDB].[dbo].[Vitrine]" />
<add key="childTable" value="[MuzeuDB].[dbo].[Vase]" />
<add key="parentTableName" value="Vitrine" />
<add key="childTableName" value="Vase" />
<add key="foreignKeyName" value="VitrinaID" />
<add key="foreignKeyRelation" value="fk_Vase_VitrinaID" />
<add key="insertColumns" value="[VasID], [Culoare], [Material], [Vechime], [VitrinaID]" />
<add key="insertValues" value="@value1, @value2, @value3, @value4, @value5" />
<add key="updateValues" value="[Culoare]=@value2, [Material]=@value3, [Vechime]=@value4, [VitrinaID]=@value5" />
<add key="updateCondition" value="[VasID]=@value1" />
<add key="deleteCondition" value="[VasID]=@value1" />
- <b>third running scenario ("master" table is table "Paznici" from the database and "detail" table is the table "Bijuterii" from the database)</b>:
<add key="parentTable" value="[MuzeuDB].[dbo].[Paznici]" />
<add key="childTable" value="[MuzeuDB].[dbo].[Bijuterii]" />
<add key="parentTableName" value="Paznici" />
<add key="childTableName" value="Bijuterii" />
<add key="foreignKeyName" value="CNPPaznic" />
<add key="foreignKeyRelation" value="fk_Bijuterii_CNPPaznic" />
<add key="insertColumns" value="[Material], [Valoare], [CNPPaznic]" />
<add key="insertValues" value="@value2, @value3, @value4" />
<add key="updateValues" value="[Material]=@value2, [Valoare]=@value3, [CNPPaznic]=@value4" />
<add key="updateDeCondition" value="[BijuterieID]=@value1" />
<add key="deleteCondition" value="[BijuterieID]=@value1" />
Important note: for changing the current running scenario, for second or third application, you need to update the App.config (which is an XML file)!
<hr>

Below are some screenshots taken during the run of the 3 applications:

- <b>1st application - MuseumWindowsFormsApp (simple application that displays data from two particular tables from the database which are in a one to many (1:n) relation), link: https://github.com/Ampersand25/Museum-Windows-Forms-App/tree/main/MuseumWindowsFormsApp</b>

![1st ss](https://github.com/Ampersand25/Museum-Windows-Forms-App/blob/main/Screenshots/Screenshot%201.png)
<p align="center"><strong>Image 1</strong> - first background of the first application</p>
<hr>

![2nd ss](https://github.com/Ampersand25/Museum-Windows-Forms-App/blob/main/Screenshots/Screenshot%202.png)
<p align="center"><strong>Image 2</strong> - second background of the first application</p>
<hr>

![3rd ss](https://github.com/Ampersand25/Museum-Windows-Forms-App/blob/main/Screenshots/Screenshot%203.png)
<p align="center"><strong>Image 3</strong> - third background of the first application</p>
<hr>

- <b>2nd application - BasicMuseumGenericWindowsFormsApp (first application but general (the app shows the records/lines/rows from two tables from the database with the condition that the tables are in a one to many (1:n) relation)), link: https://github.com/Ampersand25/Museum-Windows-Forms-App/tree/main/BasicMuseumGenericWindowsFormsApp</b>

![4th ss](https://github.com/Ampersand25/Museum-Windows-Forms-App/blob/main/Screenshots/Screenshot%204.png)
<p align="center"><strong>Image 4</strong> - first running scenario for the second application: first DataGridView displays the records/lines/rows from the table named "Ghizi" (parent table from MuzeuDB database that represents the part 1 (one) of the relation 1:n (one to many)) and the second DataGridView displays, for the selected record/line/row from the parent table, the records/lines/rows asscociated from the table named "FosileDinozauri" (child table from MuzeuDB database that represents the part n (many) of the relation 1:n (one to many))</p>
<hr>

![5th ss](https://github.com/Ampersand25/Museum-Windows-Forms-App/blob/main/Screenshots/Screenshot%205.png)
<p align="center"><strong>Image 5</strong> - second running scenario for the second application: first DataGridView displays the records/lines/rows from the table named "Vitrine" (parent table from MuzeuDB database that represents the part 1 (one) of the relation 1:n (one to many)) and the second DataGridView displays, for the selected record/line/row from the parent table, the records/lines/rows asscociated from the table named "Vase" (child table from MuzeuDB database that represents the part n (many) of the relation 1:n (one to many))</p>
<hr>

![6th ss](https://github.com/Ampersand25/Museum-Windows-Forms-App/blob/main/Screenshots/Screenshot%206.png)
<p align="center"><strong>Image 6</strong> - third (and last) running scenario for the second application: first DataGridView displays the records/lines/rows from the table named "Paznici" (parent table from MuzeuDB database that represents the part 1 (one) of the relation 1:n (one to many)) and the second DataGridView displays, for the selected record/line/row from the parent table, the records/lines/rows asscociated from the table named "Bijuterii" (child table from MuzeuDB database that represents the part n (many) of the relation 1:n (one to many))</p>
<hr>

- <b>3rd application - MuseumGenericWindowsFormsApp (second application but with: log in (sign in) window/form, registration (sign up) window/form and two splash screens for transitioning between different forms), link: https://github.com/Ampersand25/Museum-Windows-Forms-App/tree/main/MuseumGenericWindowsFormsApp</b>

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
