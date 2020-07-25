(function ($, w) {
    w.CommonValidation = {
        EmptyValidation: function (ControllerName, Message) {
            var ControllerName = '#' + ControllerName;
            if ($(ControllerName).val().length == 0) {
                $(ControllerName + "_div").addClass('item bad');
                $(ControllerName + "_errmsg").removeClass('text-hide');
                $(ControllerName + "_errmsg").addClass('alert');
                $(ControllerName + "_errmsg").html('');
                $(ControllerName + "_errmsg").html(Message);
                return 1;
            }
            else {
                CommonValidation.ClearText(ControllerName);
                return 0;
            }
        },

        checkradiobuttonValidation: function (ControllerName, Message) {

            if ($('input[name="' + ControllerName + '"]:checked').length <= 0) {
                var ControllerName = '#' + ControllerName;
                $(ControllerName + "_div").addClass('item bad');
                $(ControllerName + "_errmsg").removeClass('text-hide');
                $(ControllerName + "_errmsg").addClass('alert');
                $(ControllerName + "_errmsg").html('');
                $(ControllerName + "_errmsg").html(Message);
                return 1;
            }
            else {
                return 0;
            }
        },

        AllowNumbersOnly: function (e) {
            // Allow: backspace, delete, tab, enter 
            if ($.inArray(e.keyCode, [46, 8, 9, 13]) !== -1 ||
                // Allow: Ctrl+A,Ctrl+C,Ctrl+V, Command+A
                ((e.keyCode == 65 || e.keyCode == 86 || e.keyCode == 67) && (e.ctrlKey === true || e.metaKey === true)) ||
                // Allow: home, end, left, right, down, up
                (e.keyCode >= 35 && e.keyCode <= 40)) {
                // let it happen, don't do anything
                return;
            }
            // Ensure that it is a number and stop the keypress
            if ((e.shiftKey || (e.keyCode < 48 || e.keyCode > 57)) && (e.keyCode < 96 || e.keyCode > 105)) {
                e.preventDefault();
            }
        },

        AllowOnlyNumbers: function validate(evt) {
            if ((event.which < 48 || event.which > 57)) {
                event.preventDefault();
            }
        },

        Allowalphanumerics: function (e) {
            $('#txtOwnerName,#txtCompanyName,#txtPAN,#txtEmployeeName').keydown(function (e) {
                if (e.shiftKey || e.ctrlKey || e.altKey) {
                    e.preventDefault();
                } else {
                    var key = e.keyCode;
                    if (!((key == 8) || (key == 32) || (key == 46) || (key >= 35 && key <= 40) || (key >= 65 && key <= 90) || (key >= 48 && key <= 57) || (key >= 96 && key <= 105))) {
                        e.preventDefault();
                    }
                }
            });
        },

        FileValidation: function (ControllerName, Message) {           

            if (window.FormData !== undefined) {
                ControllerName = '#' + ControllerName;
                var fileUpload = $(ControllerName).get(0);
                var files = fileUpload.files;
                
                if (files.length == 0) {
                    $(ControllerName + "_div").addClass('item bad');
                    $(ControllerName + "_errmsg").removeClass('text-hide');
                    $(ControllerName + "_errmsg").addClass('alert');
                    $(ControllerName + "_errmsg").html('');
                    $(ControllerName + "_errmsg").html(Message);
                    return 1;
                }
                else {
                    return 0;
                }
            }
            else {
                alert("FormData is not supported.");
            }
        },

        FileTypeValidation: function ValidateExtension(ControllerName) {
            var allowedFiles = [".doc", ".docx", ".pdf", ".jpeg", ".jpg", ".png"];
            if (window.FormData !== undefined) {
                ControllerName = '#' + ControllerName;
                var fileUpload = $(ControllerName).get(0);
                var files = fileUpload.files;
                var Message;
                if (files.length > 0) {
                    var regex = new RegExp("([a-zA-Z0-9\s_\\.\-:])+(" + allowedFiles.join('|') + ")$");
                    if (!regex.test(fileUpload.value.toLowerCase())) {
                        Message = "Please upload files having extensions: <b>" + allowedFiles.join(', ') + "</b> only.";
                        $(ControllerName + "_div").addClass('item bad');
                        $(ControllerName + "_errmsg").removeClass('text-hide');
                        $(ControllerName + "_errmsg").addClass('alert');
                        $(ControllerName + "_errmsg").html('');
                        $(ControllerName + "_errmsg").html(Message);
                        return 1;
                    }
                    else {
                        return 0;
                    }
                }
            }
        },

        EMailValidation: function (ControllerName, Message) {
            var ControllerName = '#' + ControllerName;
            var sVal = $(ControllerName).val();

            var TextReg = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
            if (TextReg.test(sVal) == false) {
                $(ControllerName + "_div").addClass('item bad');
                $(ControllerName + "_errmsg").removeClass('text-hide');
                $(ControllerName + "_errmsg").addClass('alert');
                $(ControllerName + "_errmsg").html('');
                $(ControllerName + "_errmsg").html(Message);
                return 1;
            } else {
                CommonValidation.ClearText(ControllerName);
                return 0;
            }
        },
    WebsiteValidation: function (ControllerName, Message) {
        // 
        var ControllerName = '#' + ControllerName;
        var sVal = $(ControllerName).val();

        var TextReg = /(http(s)?:\\)?([\w-]+\.)+[\w-]+[.com|.in|.org]+(\[\?%&=]*)?/;
        if (TextReg.test(sVal) == false) {
            $(ControllerName + "_div").addClass('item bad');
            $(ControllerName + "_errmsg").removeClass('text-hide');
            $(ControllerName + "_errmsg").addClass('alert');
            $(ControllerName + "_errmsg").html('');
            $(ControllerName + "_errmsg").html(Message);
            return 1;
        } else {
            CommonValidation.ClearText(ControllerName);
            return 0;
        }
    },
    DigitalValidation: function (ControllerName, Message) {
        var ControllerName = '#' + ControllerName;
        var sVal = $(ControllerName).val();

        var TextReg = /^[0-9]+$/;
        if (TextReg.test(sVal) == false) {
            $(ControllerName + "_div").addClass('item bad');
            $(ControllerName + "_errmsg").removeClass('text-hide');
            $(ControllerName + "_errmsg").addClass('alert');
            $(ControllerName + "_errmsg").html('');
            $(ControllerName + "_errmsg").html(Message);
            return 1;
        } else {
            CommonValidation.ClearText(ControllerName);
            return 0;
        }
    },
    AlphaNumericwithSpace: function (ControllerName, Message) {
        var ControllerName = '#' + ControllerName;
        var sVal = $(ControllerName).val();

        var TextReg = /^[a-zA-Z0-9 ]+$/;
        if (TextReg.test(sVal) == false) {
            $(ControllerName + "_div").addClass('item bad');
            $(ControllerName + "_errmsg").removeClass('text-hide');
            $(ControllerName + "_errmsg").addClass('alert');
            $(ControllerName + "_errmsg").html('');
            $(ControllerName + "_errmsg").html(Message);
            return 1;
        } else {
            CommonValidation.ClearText(ControllerName);
            return 0;
        }
    },
    AlphaNumeric: function (ControllerName, Message) {
        var ControllerName = '#' + ControllerName;
        var sVal = $(ControllerName).val();

        var TextReg = /^[a-zA-Z0-9]+$/;
        if (TextReg.test(sVal) == false) {
            $(ControllerName + "_div").addClass('item bad');
            $(ControllerName + "_errmsg").removeClass('text-hide');
            $(ControllerName + "_errmsg").addClass('alert');
            $(ControllerName + "_errmsg").html('');
            $(ControllerName + "_errmsg").html(Message);
            return 1;
        } else {
            CommonValidation.ClearText(ControllerName);
            return 0;
        }
    },
    AlphawithSpaceCommadot: function (ControllerName, Message) {
        var ControllerName = '#' + ControllerName;
        var sVal = $(ControllerName).val();

        var TextReg = /^[a-zA-Z0-9 ,.]+$/;
        if (TextReg.test(sVal) == false) {
            $(ControllerName + "_div").addClass('item bad');
            $(ControllerName + "_errmsg").removeClass('text-hide');
            $(ControllerName + "_errmsg").addClass('alert');
            $(ControllerName + "_errmsg").html('');
            $(ControllerName + "_errmsg").html(Message);
            return 1;
        } else {
            CommonValidation.ClearText(ControllerName);
            return 0;
        }
    },
    AlphawithSpace: function (ControllerName, Message) {
        var ControllerName = '#' + ControllerName;
        var sVal = $(ControllerName).val();

        var TextReg = /^[a-zA-Z ]+$/;
        if (TextReg.test(sVal) == false) {
            $(ControllerName + "_div").addClass('item bad');
            $(ControllerName + "_errmsg").removeClass('text-hide');
            $(ControllerName + "_errmsg").addClass('alert');
            $(ControllerName + "_errmsg").html('');
            $(ControllerName + "_errmsg").html(Message);
            return 1;
        } else {
            CommonValidation.ClearText(ControllerName);
            return 0;
        }
    },
    EmailIDValidation: function (ControllerName, Message) {
        var ControllerName = '#' + ControllerName;
        var sVal = $(ControllerName).val();

        var TextReg = /^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$/;
        if (TextReg.test(sVal) == false) {
            $(ControllerName + "_div").addClass('item bad');
            $(ControllerName + "_errmsg").removeClass('text-hide');
            $(ControllerName + "_errmsg").addClass('alert');
            $(ControllerName + "_errmsg").html('');
            $(ControllerName + "_errmsg").html(Message);
            return 1;
        } else {
            CommonValidation.ClearText(ControllerName);
            return 0;
        }
    },
    DateFormateValidation: function (ControllerName, Message) {
        //(?&lt;Day&gt;[1-9]|[0-3][0-9])/(?&lt;Month&gt;[01][012]|[1-9]|0[1-9])/(?&lt;Year&gt;[12]\d{3}|\d{2})

        var ControllerName = '#' + ControllerName;
        var sVal = $(ControllerName).val();

        var TextReg = /^\d{2}[.-/]\d{2}[.-/]\d{4}$/;
        if (TextReg.test(sVal) == false) {
            $(ControllerName + "_div").addClass('item bad');
            $(ControllerName + "_errmsg").removeClass('text-hide');
            $(ControllerName + "_errmsg").addClass('alert');
            $(ControllerName + "_errmsg").html('');
            $(ControllerName + "_errmsg").html(Message);
            return 1;
        } else {
            CommonValidation.ClearText(ControllerName);
            return 0;
        }
    },
    DropDownList: function (ControllerName, Message) {
        var ControllerName = '#' + ControllerName;
        var sVal = $(ControllerName).val();

        if (sVal.length == 0 || sVal == "") {
            $(ControllerName + "_div").addClass('item bad');
            $(ControllerName + "_errmsg").removeClass('text-hide');
            $(ControllerName + "_errmsg").addClass('alert');
            $(ControllerName + "_errmsg").html('');
            $(ControllerName + "_errmsg").html(Message);
            return 1;
        }
        else {
            CommonValidation.ClearText(ControllerName);
            return 0;
        }
    },
    ClearText: function (ControllerName) {

        if (!ControllerName.indexOf("#", 1)) {
            ControllerName = '#' +ControllerName;
        }

        $(ControllerName + "_div").removeClass('item bad');
        $(ControllerName + "_errmsg").addClass('text-hide');
        $(ControllerName + "_errmsg").html('');
    },

    ClearTextonceValueentered: function (ControllerName) {
        if (!ControllerName.indexOf("#", 1)) {
            ControllerName = '#' +ControllerName;
        }

        var inp = $(ControllerName).val();
        if (inp.length > 0) {
            $(ControllerName + "_div").removeClass('item bad');
            $(ControllerName + "_errmsg").addClass('text-hide');
            $(ControllerName + "_errmsg").html('');
        }
    },

    DigitKeypress: function(ControllerName){
        $("#" + ControllerName).keydown(function (e) {
            // Allow: backspace, delete, tab, escape, enter and .
            if ($.inArray(e.keyCode, [46, 8, 9, 27, 13, 110]) !== -1 ||
                // Allow: Ctrl+A, Command+A
                (e.keyCode === 65 && (e.ctrlKey === true || e.metaKey === true)) || 
                // Allow: home, end, left, right, down, up
                (e.keyCode >= 35 && e.keyCode <= 40)) {
                // let it happen, don't do anything
                return;
            }
            // Ensure that it is a number and stop the keypress
            if ((e.shiftKey || (e.keyCode < 48 || e.keyCode > 57)) && (e.keyCode < 96 || e.keyCode > 105)) {
                e.preventDefault();
            }
        });
    }
};
})(jQuery, window);


