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
       
                   
//** @var type $_GET */
    $navn=  $_GET["navn"]; 
        $alder= $_GET["alder"]; 
        $sum = $alder + 5;
        
        echo "Velkommen " . $navn. "." . "<br>";
        echo "Der er " . strlen($navn) . " bogstaver i dit navn" . "<br>";
        echo "og dit navn ststavet bagfra som " . strrev($navn). "<br>";
        echo "Om 5 år er du " . $sum . " år gammel." . "<br>";
    ?>
        
    </body>
    

</html>
