require('./aside.less');
$(function () {
    function switchNavModuleStatus(module, status) {
        status = $.trim(status);
        if (status === "expand") {
            module.find("dd").show(200);
            module.find("dt .handle").addClass("glyphicon-chevron-up").removeClass("glyphicon-chevron-down");
            module.attr("data-status", "contract");
        } else {
            module.find("dd").hide();
            module.find("dt .handle").addClass("glyphicon-chevron-down").removeClass("glyphicon-chevron-up");
            module.attr("data-status", "expand");
        }
    };

    $(".aside dl").each(function () {
        var dl = $(this);
        switchNavModuleStatus($(this), $(this).attr("data-status"));
        $(dl).find("dt").click(function () {
            $(".aside dl").each(function () {
                switchNavModuleStatus($(this), "contract");
            });
            switchNavModuleStatus(dl, "expand");
        });
    });
});
