/// <reference path="c:\Users\LaNave\Documents\Visual Studio 2015\Projects\JSONWithAspNetMVC\JSONWithAspNetMVC\Scripts/jquery-1.10.2.min.js" />

$(document).ready(function () {
    $("#CategoryId").change(function () {
        $.ajax({
            type: 'GET',
            url: '@Url.Action("GetBlogDetailByCategory")',
            datatype: JSON,
            data: { 'categoryId': $("#CategoryId").val() },
            success: function (data) {
                $('#blogTable tbody').empty();

                $.each(data, function (i, item) {
                    var rows = "<tr>"
            + "<td>" + item.PostedId + "</td>"
            + "<td>" + item.PostTitle + "</td>"
            + "<td>" + item.ShortPostContent + "</td>"
            + "<td>" + item.MetaDescription + "</td>"
            + "</tr>";
                    $('#blogTable tbody').append(rows);
                });
            },
            error: function (ex) {
                alert('Failed to retrieve Cities.' + ex);
            }
        });
        return false;
    });
});