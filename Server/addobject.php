<?PHP

    header('Content-type: application/json');
    $db = mysqli_connect('127.0.0.1','root','88042785');
    
    if(!mysqli_select_db($db,"3DFurnitureSimulation")){
        echo 'Unable to select mydbname: ';
        exit;
    }
    
    $ROOMID=$_GET['ROOMID'];
    $objectx=$_GET['objectx'];
    $objecty=$_GET['objecty'];
    $objectz=$_GET['objectz'];
    $objectkey=$_GET['objectkey'];
    $objectsizex=$_GET['objectsizex'];
    $objectsizey=$_GET['objectsizey'];
    $objectsizez=$_GET['objectsizez'];
    $objectroatation=$_GET['objectrotation'];
    
    
    $sql = "INSERT INTO `ObjectList`(`ROOMID`, `objectx`, `objecty`, `objectz`, `objectkey`, `objectsizex`, `objectsizey`, `objectsizez`, `objectrotation`) VALUES ('$ROOMID','$objectx','$objecty','$objectz','$objectkey','$objectsizex','$objectsizey','$objectsizez','$objectroatation')";

    $result = mysqli_query($db,$sql);
    
    mysqli_close($db);
    
?>

