﻿(function ($) {
    var operations = {
        init: function () {
            if (System != null) {
                System.import("app").catch(function (err) { console.error(err); });
            }
        },

        documentReadySetup: function () {
            if ($.fn.sideNav !== "undefined") {
                $(".button-collapse").sideNav("destroy");
                $(".button-collapse").sideNav({ menuWidth: 320 });
            }

            //if ($.fn.material_select !== "undefined") {
            //    $("select").material_select();
            //}

            $(window).on("scroll", function () {
                if ($(this).scrollTop() > $(".jumbotron").height()) {
                    $(".navigation-bar").addClass("navbar-fixed");
                    $(".navigation-bar > nav").css({ top: 0 });
                } else {
                    $(".navigation-bar > nav").css({ top: $(".jumbotron").height() });
                    $(".navigation-bar").removeClass("navbar-fixed");
                }
            });
        }
    };

    operations.init();
    $(document).ready(operations.documentReadySetup);
})(jQuery);
