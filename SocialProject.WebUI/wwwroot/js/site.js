


function GetAllFriends(e) {

    setInterval(function () {
        $.ajax({
            url: "/Home/GetFriends",
            method: "GET",
            success: function (data) {

                let content = "";
                for (var i = 0; i < data.length; i++) {
                    let item = `<div class="col-md-3 col-sm-4 pe-2 ps-2">
                <div class="card d-block border-0 shadow-xss rounded-3 overflow-hidden mb-3">
                    <div class="card-body d-block w-100 ps-3 pe-3 pb-4 text-center">
                        <figure class="avatar ms-auto me-auto mb-0 position-relative w65 z-index-1">
                            <img style="height:100px;" src="/images/${data[i].imageUrl}" alt="image" class="float-right p-0 bg-white rounded-circle w-100 shadow-xss">
                        </figure>
                        <div class="clearfix">
                        </div>
                        <h4 class="fw-700 font-xsss mt-3 mb-1"> ${data[i].lastname} ${data[i].firstname}</h4>
                        <p class="fw-500 font-xsssss text-grey-500 mt-0 mb-3">${data[i].email}</p>
                        <a href="/Home/FindSelectedUser/${data[i].id}" class="mt-0 btn pt-2 pb-2 ps-3 pe-3 lh-24 ms-1 ls-3 d-inline-block rounded-xl bg-success font-xsssss fw-700 ls-lg text-white">ADD FRIEND</a>
                    </div>
                </div>
            </div>`
                    content += item;
                    $("#allFriends").html(content);
                    console.log(data);
                }
            },

            error: function (err) {
                console.log(err);
            }
        });
    }, 1000);
}

GetAllFriends();

