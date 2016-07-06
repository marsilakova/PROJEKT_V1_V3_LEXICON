<?php

$to = "marinasilakova@yahoo.se";
$from = $_POST["email"];
$subject = "Kontakt från webbplatsen!";
$fnamn = $_POST["fnamn"];
//$enamn = $_POST["enamn"];
$message = $_POST["message"];

#################################################
// HEADERS för innehållstyp och textkodning
$headers = "Content-Type: text/html; charset=utf-8 \r\n";
$headers .= "From:  <".$from.">\r\n";

#################################################

if (mail($to, $subject, $message, $headers))
{echo "<h2>Ditt meddelande har skickats!</h2>" ;
exit();
}
else
{
echo "Det gick inte att skicka ditt meddelande";
}
?>