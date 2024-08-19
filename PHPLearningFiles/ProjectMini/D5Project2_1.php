<!DOCTYPE html>
<!--
Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
Click nbfs://nbhost/SystemFileSystem/Templates/Scripting/EmptyPHPWebPage.php to edit this template
-->
<html>
    <head>
        <meta charset="UTF-8">
        
    </head>
    <body>

   <?php
     $tal = rand(0,100);

    if (isset($_GET["gæt"]))
    {
  
    $gæt = $_GET ["gæt"];
    $dif = abs($tal - $gæt);
  
    $count= 0;
          
     if ( $count <10)
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
        $count += 1; //change variable
  
    }
    
    ?>
  

    
    </body>
</html>
