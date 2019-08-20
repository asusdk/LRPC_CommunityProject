
Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Namespace Infrastructure
    Public MustInherit Class ViewModelBase
        Implements INotifyPropertyChanged

        Private Shared ReadOnly HostProcesses As New List(Of String)({"XDesProc", "devenv", "WDExpress"})

        ''' <summary>
        ''' Gibt zurück ob sich die ausführung des Codes aktuell in der Entwicklungszeit oder in der Laufzeit befindet.
        ''' </summary>
        ''' <returns>Wird Code des ViewModels vom XAML Designer ausgeführt wird True zurückgegeben.</returns>
        Public ReadOnly Property IsInDesignMode As Boolean
            Get
                Dim ret = HostProcesses.Contains(Process.GetCurrentProcess().ProcessName)
                Return ret
            End Get
        End Property





#Region "INotifyPropertyChanged"
        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged


        ''' <summary>
        ''' Prozedur wirft den INotifyPropertyChanged Event welcher in der WPF benötigt wird um die UI zu verständingen
        ''' das eine Änderung an einem Property stattgefunden hat.
        ''' </summary>
        ''' <param name="prop">Das Propertie welches sich geändert hat. Ist Optional da als Parameter "CallerMemberName" verwendet wird. Wird Nothing übergeben werden alle PRoperties des Views aktualisiert!!</param>
        Protected Overridable Sub RaisePropertyChanged(<CallerMemberName> Optional ByVal prop As String = "")
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(prop))
        End Sub


#End Region


    End Class
End Namespace