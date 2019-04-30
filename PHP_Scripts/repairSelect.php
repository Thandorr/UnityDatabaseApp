<?php 
include('connection.php');


$sql = "select id_pojazdu, id_mechanika from Naprawy";

$result = mysqli_query($connect,$sql);


if(mysqli_num_rows($result)>0)
{
    while($row = mysqli_fetch_assoc($result))
    {
        $sql = "select numer_rej from Pojazdy where ID = '".$row["id_pojazdu"]."'";
        $result2 = mysqli_query($connect,$sql);
        $car = mysqli_fetch_assoc($result2);

        $sql = "select nazwisko from Mechanicy where ID = '".$row["id_mechanika"]."'";
        $result3 = mysqli_query($connect,$sql);
        $employee = mysqli_fetch_assoc($result3);

        echo $car["numer_rej"]." -> ".$employee["nazwisko"].";";

    }
}

?>