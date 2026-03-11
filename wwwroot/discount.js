document.addEventListener("DOMContentLoaded", function() {
    document.getElementById('discount-row').addEventListener('click', function(e){
        if (e.target.classList.contains('discount')) {
            e.preventDefault();
            document.getElementById('code').innerHTML = e.target.dataset['code'];
            document.getElementById('product').innerHTML = e.target.dataset['product'];
            document.getElementById('title').innerHTML = e.target.dataset['title'];
            bootstrap.Toast.getOrCreateInstance(document.getElementById('liveToast')).show();
        }
    });
});
$(document).ready(function() {
    /*$(document).on('keydown', function(e) {
        e.preventDefault();
        if (e.key === "Escape") {
            bootstrap.Toast.getOrCreateInstance(document.getElementById('liveToast')).hide();
        }
    });

    $('.discount-toast').click(function(e) {
        e.preventDefault();

        $('.toast-header strong').html(e.target.dataset['product']);
        $('.toast-header small').html(e.target.dataset['discounttitle']);
        $('.toast-body').html("Discount Code: " + e.target.dataset['discountcode']);

        bootstrap.Toast.getOrCreateInstance(document.getElementById('liveToast')).show();
    });*/
    
})

///////////
///////////



/*document.addEventListener("DOMContentLoaded", function() {
    document.getElementById('discount-row').addEventListener('click', function(e){
        e.preventDefault();
        bootstrap.Toast.getOrCreateInstance(document.getElementById('liveToast')).show();
    });
});*/