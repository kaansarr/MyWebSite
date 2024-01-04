var silinecekID;
var projeID;

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

$(".projectDelete").click(function () {
    silinecekID = $(this).attr("rowID")
    $("#modelDelete").modal();

});

$(".communicationDelete").click(function () {
    silinecekID = $(this).attr("rowID")
    $("#modelDelete").modal();

});

$(".projePictureDelete").click(function () {
    silinecekID = $(this).attr("rowID")
    projeID = $(this).attr("projeID")
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

function deleteProject() {
    $.ajax({
        type: "POST",
        url: "/admin/proje/sil",
        data: { id: silinecekID },
        success: function (result) {
            if (result == "OK") location.href = "/admin/proje";
            else alert(result);
        }
    });
}

function deleteCommunication() {
    $.ajax({
        type: "POST",
        url: "/admin/iletisim/sil",
        data: { id: silinecekID },
        success: function (result) {
            if (result == "OK") location.href = "/admin/iletisim";
            else alert(result);
        }
    });
}

function deleteProjePicture() {
    $.ajax({
        type: "POST",
        url: "/admin/projePicture/sil",
        data: { id: silinecekID },
        success: function (result) {
            if (result == "OK") location.href = "/admin/projePicture?projeid=" + projeID;
            else alert(result);
        }
    });
}



