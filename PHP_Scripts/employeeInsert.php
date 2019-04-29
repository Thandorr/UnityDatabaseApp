<?php 
include('connection.php');



$lastname = $_POST['addLastname'];
$etat = $_POST['etat'];

$sql = "select nazwisko from Mechanicy where nazwisko = '".$lastname."';";
$nameCheck = mysqli_query($connect,$sql);
if(mysqli_num_rows($nameCheck)>0)
{
   echo "Istnieje pracownik o takim nazwisku!";
   exit;
}


$sql = "select id_etatu,nazwa from Etaty";
$result = mysqli_query($connect,$sql);


if(mysqli_num_rows($result)>0)
{
    while($row = mysqli_fetch_assoc($result))
    {
        if($row["nazwa"] == $etat)
        {
            $id_etatu = $row["id_etatu"];
        }
    }
}

$sql = "insert into Mechanicy values (null,'".$lastname."','".$id_etatu."')";

$result = mysqli_query($connect,$sql);
echo "0";
?>