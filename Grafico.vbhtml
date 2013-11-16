@Code
Dim db = Database.Open("bakery")
Dim dbdata = db.Query("SELECT Name, Price FROM PRODUCTS")
Dim myChart = new Chart(600,400)
myChart.AddTitle("Producto de Ventas")
myChart.DataBindTable(dbdata,"Name")
myChart.Write()
End Code

<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="utf-8" />
        <title>Grafica de una base de datos</title>
    </head>
    <body>
        
    </body>
</html>
