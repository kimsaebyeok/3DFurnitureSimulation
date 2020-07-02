<?PHP

    header('Content-type: application/json');
    $db = mysqli_connect('127.0.0.1','root','88042785');
    
    if(!mysqli_select_db($db,"3DFurnitureSimulation")){
        echo 'Unable to select mydbname: ';
        exit;
    }
    
    $roomx=$_GET['roomx'];
    $roomy=$_GET['roomy'];
    $roomz=$_GET['roomz'];
    $addressdosi=$_GET['addressdosi'];
    $address=$_GET['address'];
    $password=$_GET['password'];
    
    $sql  = "INSERT INTO `RoomList`(`roomx`, `roomy`, `roomz`, `addressdosi`, `address`, `password`) VALUES ('$roomx','$roomy','$roomz','$addressdosi','$address','$password')";
    
    $result = mysqli_query($db,$sql);
    
    $sqll = "SELECT * FROM `RoomList` WHERE `address` LIKE '$address'";

    $resultt = mysqli_query($db,$sqll);

    $rows = array();

    while($row = $resultt->fetch_assoc()){
        $rows[]=$row;
    }

    $qryResult = array();
    $qryResult=$rows;

    echo json_encode($qryResult, JSON_UNESCAPED_UNICODE);
    
    mysqli_close($db);
    
?>

