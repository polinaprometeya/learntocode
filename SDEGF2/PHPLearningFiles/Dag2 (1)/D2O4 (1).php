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
        $alder = rand(-100, 200); { 
            echo $alder . "<br />";
           }
        
           if ($alder < 0 || $alder > 130){
               echo "\n Ugyldig alder.";
           } elseif ($alder < 18) {
               echo "\n Du får ungdomsrabat.";
           } elseif ($alder > 18 && $alder <65 ) {
               echo "\n Du får ingen rabat.";
           } else {
               echo "\n Du får pensionistrabat.";
           }
    ?>
    </body>
</html>
