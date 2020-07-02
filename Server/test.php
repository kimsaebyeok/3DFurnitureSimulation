<?php
    
    $db = mysqli_connect('127.0.0.1','root','88042785','mysql');
    if($db){echo 'connect!!';}
    else{echo 'fail';}
    
phpinfo();
?>
