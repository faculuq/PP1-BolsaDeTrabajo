Imports Microsoft.VisualBasic
Imports System.DataSqlClient
Imports System.Data
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration

Public Class cEmpresas

    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub

    Public Function Agregar(ByVal IdUsuario As Integer) As Double
        Return oDatabase.ExecuteScalar("EmpresasAgregar", IdUsuario)
    End Function

    Public Function EmpresaGuardarInformacion(ByVal Nombre As String, ByVal RazonSocial As String, ByVal IdTipoDoc As Integer, ByVal NumeroDocumento As Integer, ByVal IdRubro As Integer, ByVal FechaFundacion As Integer, ByVal Rubro As String) As Double
        Return oDatabase.ExecuteScalar("EmpresaGuardarInformacion", Nombre, RazonSocial, IdTipoDoc, NumeroDocumento, FechaFundacion, Rubro)
    End Function
    Public Function EmpresaGuardarDatos(ByVal TelFijo As Integer, ByVal Pais As Integer, ByVal Provincia As Integer, ByVal Departamento As Integer, ByVal Localidad As Integer, ByVal Calle As Integer, ByVal Numero As Integer) As Double
        Return oDatabase.ExecuteScalar("EmpresaGuardarDatos", TelFijo, Pais, Provincia, Departamento, Localidad, Calle, Numero)
    End Function
End Class
