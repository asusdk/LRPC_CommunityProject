Imports LRPC.Model
Imports System.ComponentModel.DataAnnotations

Class Application
    ' Ereignisse auf Anwendungsebene wie Startup, Exit und DispatcherUnhandledException
    ' können in dieser Datei verarbeitet werden.


    Private Sub Application_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
        TestErrorMessages()
    End Sub

    Private Sub TestErrorMessages()

        Dim prd As New Product With {.ProductName = "", .ProductPrice = -99, .MaintenanceKitPrice = -99, .RentsUntilMaintenance = -99, .HoursOfCheck = -99, .ConsumablesPrice = -99, .ShippingFee = -99}

        Debug.WriteLine($"WARNING:  found {prd.Validate.Count.ToString} Errors.")
        For Each itm As ValidationResult In prd.Validate
            Debug.WriteLine($"ERRORMESSAGE: {itm.ErrorMessage}")
        Next

    End Sub

End Class