<Serializable>
Public MustInherit Class ModelBase

    Public Property Id As Guid = Guid.NewGuid()

    Public Property CreatedBy As String = Environment.UserName

    Public Property CreationTimeStamp As DateTime = DateTime.Now

    Public Property LastModifiedBy As String = Environment.UserName

    Public Property LastModifiedTimeStamp As DateTime = DateTime.Now

End Class