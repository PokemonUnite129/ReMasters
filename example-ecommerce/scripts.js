$(function() {
    function loadProducts() {
        $.getJSON('fetch_products.php', function(data) {
            var container = $('#products');
            container.empty();
            $.each(data, function(i, item) {
                var product = $('<div class="product">');
                product.append('<img src="' + item.image + '" alt="' + item.name + '">');
                product.append('<h3>' + item.name + '</h3>');
                product.append('<p>$' + item.price.toFixed(2) + '</p>');
                var btn = $('<button class="add">Add to Cart</button>');
                btn.data('id', item.id);
                product.append(btn);
                container.append(product);
            });
        });
    }

    loadProducts();

    $('#products').on('click', 'button.add', function() {
        var id = $(this).data('id');
        $.post('add_to_cart.php', {id: id}, function(count) {
            $('#cart-count').text(count);
        });
    });
});
