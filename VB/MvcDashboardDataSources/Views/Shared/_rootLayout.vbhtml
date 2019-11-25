<!DOCTYPE html>

<html>
<head>
    <meta charset="UTF-8" />
    <title>Dashboard Web Application</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no" />
    
    @Html.DevExpress().GetStyleSheets(
        New  StyleSheet With { .ExtensionSuite = ExtensionSuite.Dashboard }
    )
    @Html.DevExpress().GetScripts( 
        New Script With { .ExtensionSuite = ExtensionSuite.Dashboard }
    )    
</head>
<body>
    @RenderBody()
</body>
</html>