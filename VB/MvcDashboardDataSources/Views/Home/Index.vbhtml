<script type="text/javascript">
    function onBeforeRender(sender) {
        var control = sender.GetDashboardControl();
        control.registerExtension(new DevExpress.Dashboard.DashboardPanelExtension(control, { dashboardThumbnail: "./Content/DashboardThumbnail/{0}.png" }));
    }
</script>
<div style="position: absolute; top: 0; left: 0; bottom: 0; right:0">
    @Html.DevExpress().Dashboard(
                Sub(settings)
                    settings.Name = "Dashboard"
                    settings.Width = Unit.Percentage(100)
                    settings.Height = Unit.Percentage(100)
                    settings.UseNeutralFilterMode = True
                    settings.ClientSideEvents.BeforeRender = "onBeforeRender"
                End Sub).GetHtml()
</div>