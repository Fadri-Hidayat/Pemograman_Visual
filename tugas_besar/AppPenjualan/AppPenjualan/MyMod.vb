Module MyMod

    Public api_folder As String = "appakademik"
    Public users_api As String = "http://f0833857.xsph.ru/" & api_folder & "/users_api.php"

    Public customer_api As String = "http://f0833857.xsph.ru/" & api_folder & "/customer_api.php"
    Public customer_baru As Boolean

    Public sparepart_api As String = "http://f0833857.xsph.ru/" & api_folder & "/sparepart_api.php"
    Public sparepart_baru As Boolean

    Public transaksi_api As String = "http://f0833857.xsph.ru/" & api_folder & "/transaksi_api.php"
    Public transaksi_baru As Boolean

    Public Dashboard As New Dashboard
    Public Login As New login
    Public Sparepart As New Sparepart
    Public Customer As New Customer
    Public Transaksi As New Transaksi
    Public admin_role As Boolean = False
    Public login_valid As Boolean = False

End Module
