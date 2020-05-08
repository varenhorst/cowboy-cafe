// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

//js for the button to see flavors.
var el = document.getElementById('sodaFlavors');
var el2 = document.getElementById("selections");
el2.innerHTML = "See Flavors";
var checked = false;
el2.onclick = function () {
    if (checked) {
        el.style.display = 'none';
        checked = false;
        el2.innerHTML = "See Flavors";
    } else {
        el.style.display = 'block';
        checked = true;
        el2.innerHTML = "See Less";

    }
};

//js button to see extra search parameters
var searchbutton = document.getElementById("advanced-search");
var searchcontainer = document.getElementById("menu-list");
searchbutton.innerHTML = "Advanved Search";
var ifClicked = false;
searchbutton.onclick = function () {
    if (ifClicked) {
        searchcontainer.style.display = 'none';
        ifClicked = false;
        searchbutton.innerHTML = 'Advanced Search';
    } else {
        searchcontainer.style.display = 'block';
        ifClicked = true;
        searchbutton.innerHTML = 'See Less';
    }

}