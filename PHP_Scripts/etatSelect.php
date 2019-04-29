<?php 
include('connection.php');

$sql = "select nazwa from Etaty";

$result = mysqli_query($connect,$sql);

if(mysqli_num_rows($result)>0)
{
    while($row = mysqli_fetch_assoc($result))
    {
        echo "Etat".$row["nazwa"].";";
    }
}

?>