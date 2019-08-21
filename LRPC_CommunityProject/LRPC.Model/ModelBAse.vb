Imports System.ComponentModel.DataAnnotations

<Serializable>
Public MustInherit Class ModelBase

    Public Property Id As Guid = Guid.NewGuid()

    Public Property CreatedBy As String = Environment.UserName

    Public Property CreationTimeStamp As DateTime = DateTime.Now

    Public Property LastModifiedBy As String = Environment.UserName

    Public Property LastModifiedTimeStamp As DateTime = DateTime.Now


    Public Function Validate() As IList(Of ValidationResult)
        Dim validationResults As New List(Of ValidationResult)()
        Dim validationContext As New ValidationContext(Me)
        Validator.TryValidateObject(Me, validationContext, validationResults, True)
        Return validationResults
    End Function
    Public Function IsValid() As Boolean
        Return Validate().Count = 0
    End Function

End Class