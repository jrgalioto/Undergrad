<?php
DEFINE('HOST', 'localhost');
DEFINE('USER', 'jrgalioto');
DEFINE('PASS', 'becauseyouaa55');
DEFINE('DB', 'jrgalioto_ecommerce');

$link = @mysqli_connect(HOST, USER, PASS, DB) or die('The following error occurred: '.mysqli_connect_error());
mysqli_set_charset($link, 'utf8');
?>