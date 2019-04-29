<?php 
include('connection.php');

$numer_rej = $_POST['addNrRej'];

$sql = "insert into Pojazdy values (null,'".$numer_rej."')";

$result = mysqli_query($connect,$sql);


?>