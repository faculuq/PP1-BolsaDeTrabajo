Imports Microsoft.VisualBasic
Imports System.DataSqlClient
Imports System.Data
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration

Public Class cRubrosLaborales

    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub

    Public Function Agregar(ByVal Nombre As String, ByVal Estado As Boolean) As Double
        Return oDatabase.ExecuteScalar("RubrosLaboralesAgregar", Nombre, Estado)
    End Function

    Public Function Modificar(ByVal IdRubroLaboral As Integer, ByVal Nombre As String, ByVal Estado As Boolean) As Double
        Return oDatabase.ExecuteScalar("RubrosLaboralesModificar", IdRubroLaboral, Nombre, Estado)
    End Function

    Public Function BuscarTodos() As DataSet
        Return oDatabase.ExecuteDataSet("RubrosLaboralesBuscarTodos")
    End Function

    Public Function BuscarPorID(ByVal IdRubroLaboral As Integer) As DataSet
            Return oDatabase.ExecuteDataSet("RubrosLaboralesBuscarPorID", IdRubroLaboral)
    End Function

End Class
