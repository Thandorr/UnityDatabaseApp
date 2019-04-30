<?php 
include('connection.php');



$date = $_POST['date'];
$backDate = $_POST['backDate'];
$car = $_POST['car'];
$employee = $_POST['employee'];
$status = 0;


$sql = "select ID, nazwisko from Mechanicy where nazwisko = '".$employee."';";
$result = mysqli_query($connect,$sql);
if(mysqli_num_rows($result)>0)
{
    while($row = mysqli_fetch_assoc($result))
    {
        $id_pracownika = $row["ID"];
    }
    
}
$sql = "select ID from Pojazdy where numer_rej = '".$car."';";
$result = mysqli_query($connect,$sql);
if(mysqli_num_rows($result)>0)
{
    while($row = mysqli_fetch_assoc($result))
    {
        $id_samochodu = $row["ID"];
    }
}


$sql = "insert into Naprawy values (null,'".$id_samochodu."','".$id_pracownika."','".$date."','".$status."','".$backDate."')";
$result = mysqli_query($connect,$sql);
echo "0";
?>