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
        $tal = rand(1, 6); { 
            echo "Du slog nummer ". $tal . "<br />";
           }
           if ($tal == 1 ){echo "\n Eller med Romertal 'I'.";
           } elseif ($tal == 2 ){echo "\n Eller en Romertal 'II'.";
           } elseif ($tal == 3 ){echo "\n Eller en Romertal 'III'.";
           } elseif ($tal == 4 ){echo "\n Eller en Romertal 'IV'.";
           } elseif ($tal == 5 ){echo "\n Eller en Romertal 'V'.";
           } else { echo "\n Eller en Romertal 'VI'."; }
    ?>
    </body>
</html>
