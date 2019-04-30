<?php 
include('connection.php');

$nazwa = $_POST['profession'];

$sql = "select id_etatu from Etaty where nazwa='".$nazwa."'";
$nameCheck = mysqli_query($connect,$sql);
if(mysqli_num_rows($nameCheck)>0)
{
   echo "Istnieje już taki etat w bazie danych";
   exit;
}

$sql = "insert into Etaty values (null,'".$nazwa."')";

$result = mysqli_query($connect,$sql);
echo "0";

?>