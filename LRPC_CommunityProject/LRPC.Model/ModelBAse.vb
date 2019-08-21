Imports System.ComponentModel.DataAnnotations

<Serializable>
Public MustInherit Class ModelBase

    Public Property Id As Guid = Guid.NewGuid()

    Public Property CreatedBy As String = Environment.UserName

    Public Property CreationTimeStamp As DateTime = DateTime.Now

    Public Property LastModifiedBy As String = Environment.UserName

    Public Property LastModifiedTimeStamp As DateTime = DateTime.Now


    ''' <summary>
    ''' Gibt vorhandene Validierungsfehler der Modelinstanz zurück.
    ''' </summary>
    ''' <returns>Eine Auflistung von ValidationResults</returns>
    Public Overridable Function Validate() As IEnumerable(Of ValidationResult)
        Return ModelValidator.ValidateEntity(Me)
    End Function

    ''' <summary>
    ''' Gibt zurück ob das Model Validiert werden konnte oder nicht, also ob alle Eigenschaften korrekte Werte besitzen.
    ''' </summary>
    ''' <returns>Gibt True zurück wenn es keine Validierungsfehler gibt</returns>
    Public Function IsValid() As Boolean
        Return Validate() Is Nothing OrElse Validate.Count = 0
    End Function

End Class