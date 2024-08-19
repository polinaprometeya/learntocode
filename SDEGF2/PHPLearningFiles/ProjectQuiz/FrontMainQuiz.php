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

       <ui:include src="VariablesQuiz.php" />
        
    <title> Geography Questionnaire </title>
    
    <form action = "BodyQuiz.php"  method = "POST" > 
      <input type="radio" name="q1" value = "a" id = "$q1a"/> <?php  $q1a = London; ?>
      <input type="radio" name="q1" value = "b" id ="$q1b"/> <?php $q1b = Paris;  ?>
      <button type="submit">Submit</button>
  
    </form>
   
    </body>
</html>




