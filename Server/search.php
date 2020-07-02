<?PHP

    header('Content-type: application/json');
    $db = mysqli_connect('127.0.0.1','root','88042785');
    
    if(!mysqli_select_db($db,"3DFurnitureSimulation")){
        echo 'Unable to select mydbname: ';
        exit;
    }
    
    $do=$_GET['do'];
    $si=$_GET['si'];
    
    $sql = "SELECT * FROM `RoomList` WHERE ((addressdosi LIKE '%$do%') AND (addressdosi LIKE '%$si%'))";
    
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

