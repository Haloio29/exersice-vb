Imports Microsoft.Data.SqlClient
Module Module1
    Public vStok As String
    Public vCustomer As String
    Public vSupplier As String

    Function AutoCode(X As String, Y As DateTime) As String
        Dim Z As Boolean = True
        Dim Last As Integer

        Using cnn = New SqlConnection
            cnn.ConnectionString = "Data Source = DESKTOP-OG4H5R3 ; Initial Catalog = JualBeli ; Encrypt = False ; Integrated Security = True"
            Using cmdX As New SqlCommand
                cnn.Open()
                cmdX.Connection = cnn
                Select Case X
                    Case "Beli"
                        cmdX.CommandText = "SELECT TOP 1 no_beli FROM beli WHERE SUBSTRING (no_beli,3,2) = '" & Format(Y, "yy") &
                                       "' And SUBSTRING (no_beli,5,2) = '" & Format(Y, "MM") & "' ORDER BY no_beli DESC"
                End Select

                Using drX As SqlDataReader = cmdX.ExecuteReader
                    If drX.HasRows Then
                        While drX.Read()
                            Last = CInt(Mid(drX.Item("no_beli"), 7, 4))
                            Z = False
                        End While
                    End If
                    drX.Close()
                End Using
            End Using
        End Using

        Select Case X
            Case "Beli"
                If Z Then
                    Return "BL" & Format(Y, "yyMM") & "1001"
                Else
                    Return "BL" & Format(Y, "yyMM") & (Last + 1).ToString
                End If
        End Select
        Return ""
    End Function

End Module