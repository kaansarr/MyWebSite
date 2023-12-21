var silinecekID;

$(".aboutDelete").click(function () {
    silinecekID = $(this).attr("rowID")
    $("#modelDelete").modal();

});

$(".skillsDelete").click(function () {
    silinecekID = $(this).attr("rowID")
    $("#modelDelete").modal();

});


$(".educationDelete").click(function () {
    silinecekID = $(this).attr("rowID")
    $("#modelDelete").modal();

});






function deleteAbout() {
    $.ajax({
        type: "POST",
        url: "/admin/hakkimda/sil",
        data: { id: silinecekID },
        success: function (result) {
            if (result == "OK") location.href = "/admin/hakkimda";
            else alert(result);
        }
    });
}


function deleteSkills() {
    $.ajax({
        type: "POST",
        url: "/admin/yeteneklerim/sil",
        data: { id: silinecekID },
        success: function (result) {
            if (result == "OK") location.href = "/admin/yeteneklerim";
            else alert(result);
        }
    });
}

function deleteEducation() {
    $.ajax({
        type: "POST",
        url: "/admin/egitim/sil",
        data: { id: silinecekID },
        success: function (result) {
            if (result == "OK") location.href = "/admin/egitim";
            else alert(result);
        }
    });
}


