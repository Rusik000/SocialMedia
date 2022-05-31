function GetUsers(e) {
    setInterval(function () {

        $.ajax({
            url: "/Home/GetAllActiveUsers",
            method: "GET",
            success: function (data) {
                let content = "";
                for (var i = 0; i < data.length; i++) {

                    let item = "";
                    if (data[i].isOnline == true) {


                        item = `<li class="bg-transparent list-group-item no-icon pe-0 ps-0 pt-2 pb-2 border-0 d-flex align-items-center">
                                            <figure class="avatar float-left mb-0 me-2">
                                                <img src="~/images/${data[i].imageUrl}" alt="image" class="w35">
                                            </figure>

                                            <h3 class="fw-700 mb-0 mt-0">
                                                <a class="font-xssss text-grey-600 d-block text-dark model-popup-chat" href="#">${data[i].lastname}  ${data[i].firstname} </a>
                                            </h3>
                                             <span class="bg-success ms-auto btn-round-xss"></span>
                                            </li>`
                    }
                    else {
                        item = `<li class="bg-transparent list-group-item no-icon pe-0 ps-0 pt-2 pb-2 border-0 d-flex align-items-center">
                                            <figure class="avatar float-left mb-0 me-2">
                                                <img src="~/images/${data[i].imageUrl}" alt="image" class="w35">
                                            </figure>

                                            <h3 class="fw-700 mb-0 mt-0">
                                                <a class="font-xssss text-grey-600 d-block text-dark model-popup-chat" href="#">${data[i].lastname}  ${data[i].firstname}</a>
                                            </h3>

                                             <span class="bg-warning ms-auto btn-round-xss"></span>

                                            </li>`
                    }
                    content += item;
                }
                $("#ActiveUsers").html(content);
                console.log(data);
            },
            error: function (err) {
                console.log(err);
            }
        });
    }, 1000);
}

GetUsers();