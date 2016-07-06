<?php

$to = "marinasilakova@yahoo.se";
$from = $_POST["email"];
$subject = 'Kontakt från webbplatsen!';
$fnamn = $_POST["fnamn"];
//$enamn = $_POST["enamn"];
$message = $_POST["message"];

#################################################
// HEADERS för innehållstyp och textkodning
$headers = "Content-Type: text/plain; charset=utf-8 \r\n";
$headers .= "From:".$fnamn."  <".$from.">"."\r\n";
$headers .= "MIME-Version: 1.0 \r\n";
#################################################

if (mail($to, $subject, $message, $headers))

echo nl2br("<h2>Ditt meddelande har skickats!</h2>
<b>mottagare:</b> $to
<b>meddelande:</b>
$message
");

else
echo "Det gick inte att skicka ditt meddelande";


?>