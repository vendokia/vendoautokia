<!DOCTYPE html>
<html lang="en">
<body> 
@if(IsPost)
Dim companyname = Request("CompanyName")
Dim contactname = Request("ContactName")
@<p>You entered:<br><br>
Company Name:@companyname <br> 
Contact Name:@contactname </p> 
else
@<form method="post" action=""> 
Company Name:<br>
<input type="text" name="CompanyName" value=""><br>
Contact Name:<br>
<input type="text" name="ContactName" value=""><br><br>
<input type="submit" value="Enviar" class="submit"><br> 
</form>
end if
</body>
</html>
