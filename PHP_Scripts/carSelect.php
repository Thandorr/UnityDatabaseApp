<?php 
include('connection.php');

$sql = "select ID, numer_rej from Pojazdy";

$result = mysqli_query($connect,$sql);

if(mysqli_num_rows($result)>0)
{
    while($row = mysqli_fetch_assoc($result))
    {
        echo "ID pojadu".$row["ID"]."|numer rejestracyjny".$row["numer_rej"];
    }
}

?>