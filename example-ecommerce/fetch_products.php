<?php
$products = [
    ["id" => 1, "name" => "Pikachu Plush", "price" => 9.99, "image" => "https://via.placeholder.com/150"],
    ["id" => 2, "name" => "Master Ball", "price" => 14.99, "image" => "https://via.placeholder.com/150"],
    ["id" => 3, "name" => "Potion", "price" => 4.99, "image" => "https://via.placeholder.com/150"],
];

header('Content-Type: application/json');

echo json_encode($products);
