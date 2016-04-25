$(document).ready(function () {
    var lineNum = 0;
 
  
    $("h1").click(function () {
        $("p").css("background-color", "yellow");
        $("p").eq(lineNum).css("background-color", "red");
        lineNum++;
        if (lineNum > 2) { lineNum = 0;}
    });
});                    