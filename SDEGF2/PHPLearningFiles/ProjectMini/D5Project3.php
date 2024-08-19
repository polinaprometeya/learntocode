<!DOCTYPE html>
<!--
Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
Click nbfs://nbhost/SystemFileSystem/Templates/Scripting/EmptyPHPWebPage.php to edit this template
-->
<html>
    <head>
        <meta charset="UTF-8">
        <title> print("Gæt et tal")</title>
    </head>
    <body>
        <h1>Fyld ud din email</h1>
        <form action="D5Project3.php" method="GET">
            Email: <input type="Text" name="Email"/>
               <input type="submit" />
        </form>      
        
    <?php
            
    if (isset($_GET["Email"]))
    {
  
   $Email = $_GET ["Email"];
   $length = strlen($Email);
   $at = "@";
   
        if ($length > 7 and $length <30) 
        {
             if (str_contains($Email, $at))
             {
                 if (endwith($Email,"@"))  {echo "Din email er valid";}
                 else { echo "Invalid email";}
             }
        }
    }
    ?>
    
    </body>
</html>
