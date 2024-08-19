<!DOCTYPE html>
<!--
Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
Click nbfs://nbhost/SystemFileSystem/Templates/Scripting/EmptyPHPWebPage.php to edit this template
-->
<html>
    <head>
        <meta charset="UTF-8">
        <title> </title>
    </head>
    <body>
         
    <?php
    include 'VariablesQuiz.php';
   $answer1 = isset($_POST["q1"]);
   
   $totalCorrect = 0;
           
    if($answer1 == $q1r){ 
    $totalCorrect = $totalCorrect + 1; }
    else  {echo "Total correct answer is:". $totalCorrect; } 
 
    ?>
    
    </body>
</html>
