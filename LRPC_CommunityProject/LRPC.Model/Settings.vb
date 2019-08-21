Imports System.ComponentModel.DataAnnotations

<Serializable>
Public Class Settings
    Inherits ModelBase

    <Range(1, 999, ErrorMessage:="The price of one hour of Labor should be between {1} and {2}.")>
    Public Property Labor As Decimal = 115

    <Range(1, 100, ErrorMessage:="Price will be splitted by this value, please enter a value between {1} and {2}.")>
    Public Property PriceSplitter As Decimal = 40

    <Required(ErrorMessage:="A path to the DataBase-file has to be entered")>
    Public Property XmlPath As String = AppDomain.CurrentDomain.BaseDirectory & "\LRPC_DB.xml"


    Public Overrides Function ToString() As String
        Return $"{Labor} - {PriceSplitter} - {XmlPath}"
    End Function
End Class