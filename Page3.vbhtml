@Code
Dim db = 
Database.Open("Bakery")
Dim query = "SELECT Id,Name,Description,Price FROM Products"   
End Code

<!DOCTYPE html>
<html lang="en">
    <body>
        <h3>Ejemplo de base de datos VB</h3> 
        <br>
        <h1>Productos Humantis Tecnologic</h1> 
<table border="1" width="100%"> 
<tr>
<th>Id</th> 
<th>Product</th> 
<th>Description</th> 
<th>Price</th> </tr>
@Code
Dim row 
for each row in db.Query(query)
End Code
<tr> 
    <td>@row.Id</td> 
    <td>@row.Name</td> 
    <td>@row.Description</td> 
    <td>@row.Price</td> 
 </tr>
@Code next End Code</table> 
    </body>
</html>
