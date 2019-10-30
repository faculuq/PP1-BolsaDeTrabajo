Imports Microsoft.VisualBasic
Imports System.DataSqlClient
Imports System.Data
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration

Public Class cPostulantes

    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub

    Public Function Agregar(ByVal IdUsuario As Integer) As Double
        Return oDatabase.ExecuteScalar("PostulantesAgregar", IdUsuario)
    End Function

    Public Function AgregarDatosPersonales(ByVal IdUsuario As Integer, ByVal Nombre As String, ByVal Apellido As String, ByVal TipoDoc As Integer, ByVal NumeroDoc As String, ByVal EstadoCivil As Integer, ByVal SituacionLaboral As Integer, ByVal FechaNac As Date) As Double
        Return oDatabase.ExecuteScalar("PostulantesAgregarDatosPersonales", IdUsuario, Nombre, Apellido, TipoDoc, NumeroDoc, EstadoCivil, SituacionLaboral, FechaNac)
    End Function

    Public Function AgregarDatosContacto(ByVal IdUsuario As Integer, ByVal TelCel As String, ByVal TelFijo As String, ByVal IdLocalidad As Integer, ByVal Calle As String, ByVal Numero As String) As Double
        Return oDatabase.ExecuteScalar("PostulantesAgregarDatosContacto", IdUsuario, TelCel, TelFijo, IdLocalidad, Calle, Numero)
    End Function

    Public Function BuscarMail(ByVal IdUsuario As Integer) As DataSet
        Return oDatabase.ExecuteDataSet("PostulanteBuscarEmail", IdUsuario)
    End Function

    Public Function BuscarPorUsuario(ByVal IdUsuario As Integer) As DataSet
        Return oDatabase.ExecuteDataSet("PostulanteBuscarPorUsuario", IdUsuario)
    End Function

End Class
