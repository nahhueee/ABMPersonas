Public Class PersonasClass
    Dim id_, codPostal_, idProvincia_ As Integer
    Dim nombre_, direccion_, tipoDocumento_ As String
    Dim nroDocumento_ As Decimal

    Public Property id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property

    Public Property codPostal() As Integer
        Get
            Return codPostal_
        End Get
        Set(ByVal value As Integer)
            codPostal_ = value
        End Set
    End Property

    Public Property idProvincia() As Integer
        Get
            Return idProvincia_
        End Get
        Set(ByVal value As Integer)
            idProvincia_ = value
        End Set
    End Property

    Public Property nombre() As String
        Get
            Return nombre_
        End Get
        Set(ByVal value As String)
            nombre_ = value
        End Set
    End Property

    Public Property direccion() As String
        Get
            Return direccion_
        End Get
        Set(ByVal value As String)
            direccion_ = value
        End Set
    End Property

    Public Property tipoDocumento() As String
        Get
            Return tipoDocumento_
        End Get
        Set(ByVal value As String)
            tipoDocumento_ = value
        End Set
    End Property

    Public Property nroDocumento() As Decimal
        Get
            Return nroDocumento_
        End Get
        Set(ByVal value As Decimal)
            nroDocumento_ = value
        End Set
    End Property
    Dim documentos_() As String = {"DNI", "LE", "LC", "CI", "PAS"}

    Dim provincias_() As String = _
    {"Ciudad Autónoma de Buenos Aires", _
    "Buenos Aires", _
    "Catamarca", _
    "Córdoba", _
    "Corrientes", _
    "Entre Ríos", _
    "Jujuy", _
    "Mendoza", _
    "La Rioja", _
    "Salta", _
    "San Juan", _
    "San Luis", _
    "Santa Fe", _
    "Santiago del Estero", _
    "Tucumán", _
    "Chaco", _
    "Chubut", _
    "Formosa", _
    "Misiones", _
    "Neuquén", _
    "La Pampa", _
    "Río Negro", _
    "Santa Cruz", _
    "Tierra del Fuego"}

    Public ReadOnly Property documentos() As Array
        Get
            Return documentos_
        End Get
    End Property

    Public ReadOnly Property TipodeDocumento() As String
        Get
            If tipoDocumento_ <= 0 Then
                Return ""
            End If

            Return documentos_(CInt(tipoDocumento_))
        End Get
    End Property

    Public ReadOnly Property provincias() As Array
        Get
            Return provincias_
        End Get
    End Property

    Public ReadOnly Property Provincia() As String
        Get
            If idProvincia_ <= 0 Then
                Return ""
            End If

            Return provincias_(CInt(idProvincia_))
        End Get
    End Property

End Class
