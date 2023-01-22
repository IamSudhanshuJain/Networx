
function GetEmployees() {
    $.ajax({
        type: 'GET',
        url: "/Employee/GetAllEmployees",
        success: function (data) {
            $("#GetAllEmployeesTable").html(data);
        },
        error: function (ex) {
            alert("Employee Record does not found");
            console.log(ex);
        }
    });
}


function loadEmployeeStatus() {
    $('#EmployeeStatus').empty();

    $.ajax({
        type: 'GET',
        url: "/DataSource/GetAllStatus",
        dataType: 'json',
        async: false,
        success: function (data) {
            for (var i = 0; i < data.length; i++) {
                $('#EmployeeStatus').append(
                    $('<option></option>').val(data[i].Id).html(data[i].Name)
                );
            }
        },
        error: function (ex) {
            alert("Employee Record does not found");
            console.log(ex);
        }
    });
}

function GetEmployee(id) {
    $.ajax({
        type: 'GET',
        url: "/Employee/GetEmployee",
        data: { Id: id },
        success: function (data) {
            $("#editModal").html(data);
            loadEmployeeStatus();
            $("#editModal .modal-body #EmployeeStatus").val($("#statusId").val());
            $("#editModal").modal("show");
        },
        error: function (ex) {
            alert("Employee Record does not found");
            console.log(ex);
        }
    });
}

function AddEmployeePopup(id) {
    $.ajax({
        type: 'GET',
        url: "/Employee/AddEmployeePopup",
        success: function (data) {
            $("#editModal").html(data);
            loadEmployeeStatus();
            $("#editModal").modal("show");
        },
        error: function (ex) {
            alert("Employee Record does not found");
            console.log(ex);
        }
    });
}


function AddEmployee() {

    var obj = {
        EmployeeId: parseInt($("#editModal .modal-body #EmployeeId").val()),
        FirstName: $("#editModal .modal-body #EmployeeFirstName").val(),
        LastName: $("#editModal .modal-body #EmployeeLastName").val(),
        Email: $("#editModal .modal-body #EmployeeEmail").val(),
        Status: $("#editModal .modal-body #EmployeeStatus").val(),
    };

    $.ajax({
        type: 'POST',
        url: "/Employee/SaveEmployee",
        dataType: 'json',
        data: obj,
        success: function (data) {
            GetEmployees();
            $('#editModal').modal('toggle');
        },
        error: function (ex) {
            alert("Employee Record does not save successfully");
            console.log(ex);
        }
    });
}

function EditEmployee(Id) {

    var obj = {
        Id: Id,
        FirstName: $("#editModal .modal-body #EmployeeFirstName").val(),
        LastName: $("#editModal .modal-body #EmployeeLastName").val(),
        Email: $("#editModal .modal-body #EmployeeEmail").val(),
        Status: $("#editModal .modal-body #EmployeeStatus").val(),
    };

    $.ajax({
        type: 'POST',
        url: "/Employee/EditEmployee",
        dataType: 'json',
        data: obj,
        success: function () {
            GetEmployees();
            $('#editModal').modal('toggle');
        },
        error: function (ex) {
            alert("Employee Record does not updated successfully");
            console.log(ex);
        }
    });
}


function DeleteEmployee(id) {
    $.ajax({
        type: 'POST',
        url: "/Employee/DeleteEmployee",
        dataType: 'json',
        data: { Id: id },
        success: function () {
            GetEmployees();
            alert("Employee details deleted Successfully");
        },
        error: function (ex) {
            alert("Employee Details does not deleted Successfully");
            console.log(ex);
        }
    });
}




