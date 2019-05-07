/*Menu Toggle Script*/
$("#menu-toggle").click(function (e) {
    e.preventDefault();
    $("#wrapper").toggleClass("toggled");

    //Not working
    if ($(this).find($(".fa")).hasClass('fa-arrow-left')) {
        console.log("test");
        }

   

});

/*
/* Menu Click Script
$('.list-group-item').on('click', function () {
    var $this = $(this);
    //var $alias = $this.data('alias');

    $('.active').removeClass('active');
    $this.toggleClass('active')

    // Pass clicked link element to another function
    //myfunction($this, $alias)
})*/