Imports System.ComponentModel.DataAnnotations

''' <summary>
''' Generische Modelvalidierung
''' </summary>
''' <typeparam name="T">Mit T wird der Typ des zu Überprüfenden Models übergeben. T macht diese Funktion generisch</typeparam>
Public Class ModelValidation(Of T As ModelBase)

    ''' <summary>
    ''' Gibt eine Auflistung von ermittelten ValidationResults zurück welche anhand der DatenAnnotation geprüft wird.
    ''' </summary>
    ''' <param name="entity">Die Entität (also das Model-Objekt) welches geprüft werden soll</param>
    Public Function Validate(entity As T) As IEnumerable(Of ValidationResult)
        Dim validationResults As List(Of ValidationResult) = New List(Of ValidationResult)()
        Dim validationContext As ValidationContext = New ValidationContext(entity, Nothing, Nothing)
        Try
            Validator.TryValidateObject(entity, validationContext, validationResults, True)
        Catch ex As Exception
            Debug.WriteLine(String.Format("FEHLER Validate: {0}", ex.ToString))

        End Try
        Return validationResults
    End Function

End Class
