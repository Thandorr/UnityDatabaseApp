<?php 
include('connection.php');

$sql = "select nazwisko from Mechanicy";

$result = mysqli_query($connect,$sql);

if(mysqli_num_rows($result)>0)
{
    while($row = mysqli_fetch_assoc($result))
    {
        echo $row["nazwisko"].";";
    }
}

?>