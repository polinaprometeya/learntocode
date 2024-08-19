<!DOCTYPE html>
<!--
Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
Click nbfs://nbhost/SystemFileSystem/Templates/Scripting/EmptyPHPWebPage.php to edit this template
-->
<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
    </head>
    <body>
    <?php
       
        $maks = 10;   
        $i = 0;
        $sum = 0;
          
        do{ 
            $sum = $sum + $i; 
            $i++ . "<br />";
         } while ($i < $maks);
           echo $sum;
    ?>
    </body>
</html>
