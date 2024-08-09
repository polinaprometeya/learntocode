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
      <title> Geography Questionnaire </title>
    <form action = "Quiz php.php"  method = "POST" > 
        q1: <input type="radio" name="q1" id= "<?php echo  $q1a ?>" value = London"<?php echo  $q1a ?>"/>
        q1: <input type="radio" name="q1" id= "<?php echo  $q1b ?>" value = Paris"<?php echo  $q1b ?>"/>
    <div>
    <button type="submit">Submit</button>
    </div>
     

    </form>
    </body>
</html>




