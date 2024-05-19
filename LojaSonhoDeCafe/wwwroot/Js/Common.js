﻿window.ShowToastr = (type, message) => {

    toastr.options.toastClass = "toastr";

    toastr.options = {
        toastClass: "toastr toastr-custom",
        timeOut: 2000
    };


    if (type === "success") {
        toastr.success(message, "Operação realizado com Sucesso!!!", { timeOut: 2000 });
    }
    if (type === "fail") {
        toastr.error(message, "Falha ao realizado Operação!!!", { timeOut: 2000 });
    }
};