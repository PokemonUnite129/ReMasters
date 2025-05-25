<?php
session_start();

$id = intval($_POST['id'] ?? 0);

if (!isset($_SESSION['cart'])) {
    $_SESSION['cart'] = [];
}

if ($id > 0) {
    if (!isset($_SESSION['cart'][$id])) {
        $_SESSION['cart'][$id] = 0;
    }
    $_SESSION['cart'][$id]++;
}

echo count($_SESSION['cart']);
