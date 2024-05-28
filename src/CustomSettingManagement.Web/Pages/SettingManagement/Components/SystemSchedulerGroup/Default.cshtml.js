(function ($) {
    $(function () {
        var l = abp.localization.getResource('CustomSettingManagement');

        abp.utils.createNamespace(window, 'settingManagement.systemSchedulerSettings');

        settingManagement.systemSchedulerSettings.update = function (settings, ajaxParams) {
            return abp.ajax($.extend(true, {
                url: abp.appPath + 'api/setting-management/system-scheduler',
                type: 'POST',
                dataType: null,
                data: JSON.stringify(settings)
            }, ajaxParams));
        };

        $("#SystemSchedulerSettingsForm").on('submit', function (event) {
            event.preventDefault();

            if (!$(this).valid()) {
                return;
            }

            var schedulerPollingIntervalMins = parseInt($("#SchedulerPollingIntervalMins").val(), 10);
            var businessDaysLookahead = parseInt($("#BusinessDaysLookahead").val(), 10);

            settingManagement.systemSchedulerSettings.update({
                schedulerPollingIntervalMins: schedulerPollingIntervalMins,
                businessDaysLookahead: businessDaysLookahead
            })
                .then(function (result) {
                    $(document).trigger("AbpSettingSaved");
            });
        });
    });
})(jQuery);