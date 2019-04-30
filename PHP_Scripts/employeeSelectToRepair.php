<?php 
include('connection.php');

$sql = "select ID from Mechanicy";

$result = mysqli_query($connect,$sql);

if(mysqli_num_rows($result)>0)
{
    while($row = mysqli_fetch_assoc($result))
    {
        echo $row["ID"].";";
    }
}

?>