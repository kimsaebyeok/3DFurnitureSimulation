<?PHP

    header('Content-type: application/json');
    $db = mysqli_connect('127.0.0.1','root','88042785');
    
    if(!mysqli_select_db($db,"3DFurnitureSimulation")){
        echo 'Unable to select mydbname: ';
        exit;
    }
    
    $roomid=$_GET['ROOMID'];
    
    $sql = "SELECT * FROM `ObjectList` WHERE ROOMID = '$roomid'";
    
    $result = mysqli_query($db,$sql);
    
    $rows = array();
    
    while($row = $result->fetch_assoc()){
        $rows[]=$row;
    }
    
    $qryResult = array();
    $qryResult=$rows;
    
    echo json_encode($qryResult, JSON_UNESCAPED_UNICODE);
    
    mysqli_close($db);
    
?>

