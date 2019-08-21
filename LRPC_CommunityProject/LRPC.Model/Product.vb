'TODO DataAnnotations
'TODO In jeder KLasse das ToString überschreiben
'TODO Eine Model-Basisklasse schaffen und dort die ID reinpacken.



Imports System.ComponentModel.DataAnnotations

<Serializable>
Public Class Product
    Inherits ModelBase

    <MinLength(1, ErrorMessage:="ProductName have to be Above {1} characters")>
    <MaxLength(100, ErrorMessage:="ProductName have to be below {1} characters")>
    Public Property ProductName As String = "unnamed Product"

    <Range(0.1, 999.9, ErrorMessage:="ProductPrice accepts values between {1} and {2}")>
    Public Property ProductPrice As Decimal = 0

    <Range(0.1, 999.9, ErrorMessage:="MaintenanceKitPrice accepts values between {1} and {2}")>
    Public Property MaintenanceKitPrice As Decimal = 0

    <Range(1, 100, ErrorMessage:="RentsuntilMaintenance accepts values between {1} and {2}")>
    Public Property RentsUntilMaintenance As Double = 0

    <Range(1, 100, ErrorMessage:="HoursOfCheck accepts values between {1} and {2}")>
    Public Property HoursOfCheck As Double = 0

    <Range(0.1, 999.9, ErrorMessage:="ConsumablesPrice accepts values between {1} and {2}")>
    Public Property ConsumablesPrice As Decimal = 0

    <Range(0.1, 999.9, ErrorMessage:="ShippingFee accepts values between {1} and {2}")>
    Public Property ShippingFee As Decimal = 0

    Public Property ProductComment As String = String.Empty

    Public Overrides Function ToString() As String
        Return $"{Id} - {ProductName}"
    End Function
End Class
