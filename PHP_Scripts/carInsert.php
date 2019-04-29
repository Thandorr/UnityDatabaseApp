<?php 
include('connection.php');

$numer_rej = $_POST['addNrRej'];

$sql = "select ID from Pojazdy where numer_rej='".$numer_rej."'";
$nameCheck = mysqli_query($connect,$sql);
if(mysqli_num_rows($nameCheck)>0)
{
   echo "Istnieje pojazd o takich numerach rejestracyjnych!";
   exit;
}

$sql = "insert into Pojazdy values (null,'".$numer_rej."')";

$result = mysqli_query($connect,$sql);
echo "0";

?>