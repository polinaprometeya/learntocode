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
      
           
   <?php
   
    if (isset($_GET["gæt"]))
    {
    $tal = rand(0,100);
    
    $gæt = $_GET ["gæt"];
    $dif = abs($tal - $gæt);
   
   session_start();
         $_SESSION["count"] = 0;
   session_write_close(); //close
   
     if ( $_SESSION["count"] <10)
     {     
      if ($tal == $gæt)
         {echo "flot - rigtig gættet!";}
      elseif ($dif<0 or $dif >100)
           {echo "Udenfor angivet interval på 1-100";}
      elseif ($dif >50)
          {echo "Meget langt forbi";}
      elseif ($dif >19 and $dif <49)
          {echo "Du er ikke helt ved siden af";}  
      else  
          {echo "Tampen brænder!";} 
     }     
    session_start(); //open the session again for editing a variable
        $_SESSION["count"] += 1; //change variable
    session_write_close(); //now close the session again!  
    }
    
    ?>
        
<p>
<form action="" method="post">
<input type="text" name="num">
<button type="submit" name="submit">Guess</button>
<button type="reset" name="Reset">Reset</button>
</form>
</p>

    
    </body>
</html>
