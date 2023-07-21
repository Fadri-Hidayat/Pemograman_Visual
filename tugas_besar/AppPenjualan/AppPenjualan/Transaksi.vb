Imports System.Net
Imports System.Text
Imports System.Net.Http
Imports Newtonsoft.Json

Public Class Transaksi
    Private Sub Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reloaded()
    End Sub

    Private Sub Reloaded()

        ' Create a WebClient instance to make the HTTP request
        Dim client As New WebClient()

        ' Make the GET request and retrieve the response
        Dim response As String = client.DownloadString(transaksi_api)

        ' Deserialize the JSON response into a list of objects
        Dim data As List(Of classTransaksi) = JsonConvert.DeserializeObject(Of List(Of classTransaksi))(response)

        ' Bind the data to the DataGridView
        dgvData.DataSource = data
    End Sub


    Private Sub GetData()
        Using client As New HttpClient()
            ' Send a GET request to the API endpoint
            Dim response As HttpResponseMessage = client.GetAsync(transaksi_api & "?kdtransaksi=" & txtKodeTransaksi.Text).Result

            ' Check if the request was successful
            If response.IsSuccessStatusCode Then
                ' Read the response content as a string
                Dim jsonString As String = response.Content.ReadAsStringAsync().Result

                Try
                    If (jsonString = "[]") Then
                        transaksi_baru = True
                        MessageBox.Show("Data Not Found")
                        Exit Sub
                    Else
                        transaksi_baru = False
                        Exit Sub
                    End If
                Catch ex As Exception

                Finally
                    If (transaksi_baru = False) Then
                        ' Deserialize the JSON into objects
                        Dim data As List(Of classTransaksi) = JsonConvert.DeserializeObject(Of List(Of classTransaksi))(jsonString)

                        ' Create textboxes dynamically and set their values
                        For Each mydata As classTransaksi In data
                            txtKodeTransaksi.Text = mydata.kdtransaksi
                            txtKodeCustomer.Text = mydata.kdcustomer
                            txtKodeSparepart.Text = mydata.kdsparepart
                            txtHarga.Text = mydata.harga
                            txtJumlah.Text = mydata.jumlah_barang
                            txtTotal.Text = mydata.total

                        Next
                    End If

                End Try

            Else
                ' Request failed, handle the error
                MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}")

            End If
        End Using
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (transaksi_baru = True) Then
            TambahData()
        Else
            UpdateData()
        End If
    End Sub

    Private Sub TambahData()

        ' Set the data you want to send as key-value pairs
        Dim kdtransaksi As String = txtKodeTransaksi.Text
        Dim kdcustomer As String = txtKodeCustomer.Text
        Dim kdsparepart As String = txtKodeSparepart.Text
        Dim harga As String = txtHarga.Text
        Dim jumlah_barang As String = txtJumlah.Text
        Dim total As String = txtTotal.Text

        Dim postData As String = $"kdtransaksi={kdtransaksi}&kdcustomer={kdcustomer}&kdsparepart={kdsparepart}&harga={harga}&jumlah_barang={jumlah_barang}&total={total}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the POST request and get the response
            Dim responseBytes As Byte() = client.UploadData(transaksi_api, "POST", byteArray)

            ' Convert the response bytes to a string
            Dim responseBody As String = Encoding.ASCII.GetString(responseBytes)

            ' Display the response
            MessageBox.Show(responseBody, "Response")
        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try
        GetClear()
    End Sub

    Private Sub UpdateData()

        ' Set the data you want to send as key-value pairs
        Dim kdtransaksi As String = txtKodeTransaksi.Text
        Dim kdcustomer As String = txtKodeCustomer.Text
        Dim kdsparepart As String = txtKodeSparepart.Text
        Dim harga As String = txtHarga.Text
        Dim jumlah_barang As String = txtJumlah.Text
        Dim total As String = txtTotal.Text

        Dim postData As String = $"kdtransaksi={kdtransaksi}&kdcustomer={kdcustomer}&kdsparepart={kdsparepart}&harga={harga}&jumlah_barang={jumlah_barang}&total={total}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(transaksi_api & "?kdtransaksi=" & txtKodeTransaksi.Text, "PUT", byteArray)

            ' Convert the response bytes to a string
            Dim responseBody As String = Encoding.ASCII.GetString(responseBytes)

            ' Display the response
            MessageBox.Show(responseBody, "Response")
        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try
        GetClear()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        GetClear()
    End Sub

    Private Sub DeleteData()

        ' Set the data you want to send as key-value pairs
        Dim kdtransaksi As String = txtKodeTransaksi.Text
        Dim kdcustomer As String = txtKodeCustomer.Text
        Dim kdsparepart As String = txtKodeSparepart.Text
        Dim harga As String = txtHarga.Text
        Dim jumlah_barang As String = txtJumlah.Text
        Dim total As String = txtTotal.Text

        Dim postData As String = $"kdtransaksi={kdtransaksi}&kdcustomer={kdcustomer}&kdsparepart={kdsparepart}&harga={harga}&jumlah_barang={jumlah_barang}&total={total}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(transaksi_api & "?kdtransaksi=" & txtKodeTransaksi.Text, "DELETE", byteArray)

            ' Convert the response bytes to a string
            Dim responseBody As String = Encoding.ASCII.GetString(responseBytes)

            ' Display the response
            MessageBox.Show(responseBody, "Response")
        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try
        GetClear()
    End Sub

    Private Sub GetClear()
        txtKodeTransaksi.Clear()
        txtKodeCustomer.Clear()
        txtKodeSparepart.Clear()
        txtHarga.Clear()
        txtJumlah.Clear()
        txtTotal.Clear()
        Reloaded()
        txtKodeTransaksi.Focus()
    End Sub

    Private Sub txtKodeTransaksi_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKodeTransaksi.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            GetData()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteData()
    End Sub
End Class