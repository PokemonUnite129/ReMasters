<?php
session_start();
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Demo E-Commerce</title>
    <link rel="stylesheet" href="style.css">
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="scripts.js"></script>
</head>
<body>
    <header>
        <h1>Demo Shop</h1>
        <div id="cart">Cart: <span id="cart-count">0</span> items</div>
    </header>

    <main>
        <div id="products" class="product-grid"></div>
    </main>
</body>
</html>
