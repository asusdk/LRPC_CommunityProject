'TODO DataAnnotations
'TODO In jeder KLasse das ToString überschreiben
'TODO Eine Model-Basisklasse schaffen und dort die ID reinpacken.



Imports System.ComponentModel.DataAnnotations

<Serializable>
Public Class Product
    Inherits ModelBase


    <StringLength(100, MinimumLength:=1, ErrorMessage:="The product name should contain a minimum of {2} and a maximum of {1} characters.")>
    Public Property ProductName As String = "unnamed product"

    <Range(0.1, 9999999.9, ErrorMessage:="The price of the product should be at least {1} and a maximum of {2}.")>
    Public Property ProductPrice As Decimal = 0

    <Range(0, 9999.9, ErrorMessage:="The price of the maintenance kit should be between {1} and {2}.")>
    Public Property MaintenanceKitPrice As Decimal = 0

    <Range(1, 999, ErrorMessage:="An indication of how many rents are permissible before maintenance is required is necessary. Please enter a value between {1} and {2}.")>
    Public Property RentsUntilMaintenance As Double = 0

    <Range(0, 999, ErrorMessage:="Indicate the expected hours of inspection. Please enter a value between {1} and {2}.")>
    Public Property HoursOfCheck As Double = 0

    <Range(0, 9999.9, ErrorMessage:="The price of consumables should be at least {1} and a maximum of {2}.")>
    Public Property ConsumablesPrice As Decimal = 0

    <Range(0, 9999.9, ErrorMessage:="The price of Shipping should be at least {1} and a maximum of {2}.")>
    Public Property ShippingFee As Decimal = 0

    Public Property ProductComment As String = String.Empty


    Public Overrides Function ToString() As String
        Return ProductName
    End Function


End Class