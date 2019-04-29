<?php 
include('connection.php');

$sql = "select numer_rej from Pojazdy";

$result = mysqli_query($connect,$sql);

if(mysqli_num_rows($result)>0)
{
    while($row = mysqli_fetch_assoc($result))
    {
        echo $row["numer_rej"].";";
    }
}

?>