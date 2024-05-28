(function ($) {
    $(function () {
        var l = abp.localization.getResource('CustomSettingManagement');

        $("#SystemSchedulerSettingsForm").on('submit', function (event) {
            event.preventDefault();

            if (!$(this).valid()) {
                return;
            }

            var schedulerPollingIntervalMins = parseInt($("#SchedulerPollingIntervalMins").val(), 10);
            customSettingManagement.systemScheduler.systemScheduler.update({ schedulerPollingIntervalMins: schedulerPollingIntervalMins })
                .then(function (result) {
                    $(document).trigger("AbpSettingSaved");
            });
        });
    });
})(jQuery);