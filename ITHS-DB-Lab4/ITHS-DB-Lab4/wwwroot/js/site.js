var imageIndex=1,imageClassCount=8;function scrollHomeBackground(){var e=document.getElementById("home-background");e.classList.remove("home-background-image-"+imageIndex),imageIndex=(imageIndex+1)%imageClassCount,e.classList.add("home-background-image-"+imageIndex)}window.onload=setInterval(scrollHomeBackground,7e3);