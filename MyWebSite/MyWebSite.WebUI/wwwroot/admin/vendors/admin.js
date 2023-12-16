var silinecekID;

$(".aboutDelete").click(function () {
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