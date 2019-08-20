Public Class Product

    Public Property Id As Guid = Guid.NewGuid()


    Public Property ProductName As String = "unnamed Product"

    Public Property ProductPrice As Decimal = 0

    Public Property MaintenanceKitPrice As Decimal = 0

    Public Property RentsUntilMaintenance As Double = 0

    Public Property HoursOfCheck As Double = 0

    Public Property ConsumablesPrice As Decimal = 0

    Public Property ShippingFee As Decimal = 0

    Public Property ProductComment As String = String.Empty
End Class
