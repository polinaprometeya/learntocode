<?php
    session_start();
    
    function spider_conn()
    {
        $host="localhost";
        $username="root";
        $password="";
        $db_name="spiderdatabase";


        try{
            $conn = mysqli_connect($host, $username, $password, $db_name);
        } catch (Exception $ex){
            echo "CONNECTION FAILLLERED: ";
            header("refresh:3");
        }

        if (!$conn) {
            die("connection failed: " . mysqli_connect_error());
        }
        echo 'connection done!';
        return $conn;
    }
    
    function spider_sendcheck() {
        $test = True;
        
        if ($_POST['username'] == ''){$test = False;echo "mangler bruger";}

        if ($_POST['email'] == ''){$test = False;echo "mangler email";}
        
        if ($_POST['mobile'] == ''){$test = False;echo "mangler nummer";}
                
        return $test;
    }
    
    if (isset($_POST['submit'])){
        

        
        
        
        switch ($_POST['submit']) {
    case 'Join':
        echo "Save!!";
        
        if(spider_sendcheck()){
            echo "Data i alle felter!!!";
            $my_username=$_POST["username"];
        
            $conn = spider_conn();
        
            $my_email = $_POST["email"];
            $my_mobile = $_POST["mobile"];
            $my_date = date('Y-m-d H:i:s'); //mysql datetime standard
        
            $sql = "INSERT INTO `SpiderWeb`(`Name`, `Email`, `Mobil`, `Dato`) VALUES ('$my_username','$my_email','$my_mobile','$my_date')";
        
            mysqli_query($conn, $sql);
            
            
            header("Refresh:3");
        }else{
            echo "Data mangler et eller flere felter!!!";
        }
        
        
        //
        
        break;
    
    case 'Reset':
        echo "Reset!!";
        header("Refresh:0");
        break;
    
    default:
        break;
        }
}

?>
<!DOCTYPE html>

<html>
    <head>
        <meta charset="UTF-8">
        <title>SpiderSport</title>
    </head>
    <body>
        <h1>SpiderSport</h1>
        <h2>Udfyld alle felter</h2>
        <form name="form2" method="post" action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]);?>">
            <table width="550px" border="0" cellpadding="3" cellspacing="1" bgcolor="#FFFFFF">
                <tr>
                    <td colspan="3"><strong>SpiderSport Kunde Klub</strong></td>
                </tr>
                <tr>
                    <td width="78">Navn</td>
                    <td width="6">:</td>
                    <td width="794"><input name="username" type="text"></td>
                </tr>
                <tr>
                    <td>E_mail</td>
                    <td>:</td>
                    <td><input name="email" type="text"></td>
                </tr>
                <tr>
                    <td>Mobil nr.</td>
                    <td>:</td>
                    <td><input name="mobile" type="text"></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td><input type="submit" name="submit" value="Join"> <input type="submit" name="submit" value="Reset"></td>
                </tr>
            </table>
        </form>            
    </body>
</html>
