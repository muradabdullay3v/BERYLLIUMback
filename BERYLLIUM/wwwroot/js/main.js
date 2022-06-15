function myFunction() {
    var x = document.getElementById("sidebar");
    if (x.className === "sidebar close") {
      x.className = "sidebar opened";
    } else {
      x.className = "sidebar close";
    }
  }

  var side_buttons = document.querySelectorAll(".side-dropdown_button");
  [...side_buttons].forEach(btn =>{
    btn.onclick = function () {
      console.log(btn.nextElementSibling);
      if (btn.nextElementSibling.className === "side-dropdown-content") {
        btn.nextElementSibling.className += " opened";
      } else {
        btn.nextElementSibling.className = "side-dropdown-content";
      }
    };
  });

  var sub_side_buttons = document.querySelectorAll(".sub_side-dropdown_button");
  [...sub_side_buttons].forEach(btn =>{
    btn.onclick = function () {
      console.log(btn.nextElementSibling);
      if (btn.nextElementSibling.className === "sub_side-dropdown-content") {
            btn.nextElementSibling.className += " opened";
          } 
      else{
            btn.nextElementSibling.className = "sub_side-dropdown-content";
          }
    };
  });

function closeside() {
    var x = document.getElementById("sidebar");
    if (x.className === "sidebar opened") {
      x.className = "sidebar close";
    } else{
      x.className = "sidebar opened";
    }
  }

  $(document).ready(function(){
    $('.slider').slick({
      autoplay: true,
      autoplaySpeed : 3000,
      arrows : true,
      dots : true,
    });
    $('.work_cards').slick({
      autoplay: true,
      autoplaySpeed : 3000,
      arrows : false,
      dots : false,
      infinite: true,
      slidesToShow: 3,
    });
        
  });

  