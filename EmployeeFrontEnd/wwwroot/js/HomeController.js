$(document).ready(function () {
    getData();
});

function getData() {
    $.ajax({
        url: 'https://localhost:44376/api/Employee',
        dataType: "json",
        method: 'GET',
        success: function (data) {
            var employeeTable = $('#displayTable tbody');
            employeeTable.empty();

            $(data).each(function (index, emp) {
                employeeTable.append('<tr><td>' + emp.FirstName + '</td><td>'
                    + emp.LastName + '</td><td>' + emp.EmpAddress + '</td><td>'
                    + emp.MobileNumber + '</td><td>' + emp.ZipCode + '</td></tr>');
            });
        }
    });
}