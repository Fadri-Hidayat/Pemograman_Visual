<?php
require_once 'database.php';
require_once 'transaksi.php';
$db = new MySQLDatabase();
$transaksi = new transaksi($db);

$id = 0;
$kdtransaksi = 0;
// Check the HTTP request method
$method = $_SERVER['REQUEST_METHOD'];

// Handle the different HTTP methods
switch ($method) {
    case 'GET':
        if (isset($_GET['id'])) {
            $id = $_GET['id'];
        }
        if (isset($_GET['kdtransaksi'])) {
            $kdtransaksi = $_GET['kdtransaksi'];
        }
        if ($id > 0) {
            $result = $transaksi->get_by_id($id);
        } elseif ($kdtransaksi > 0) {
            $result = $transaksi->get_by_kode($kdtransaksi);
        } else {
            $result = $transaksi->get_all();
        }

        $val = array();
        while ($row = $result->fetch_assoc()) {
            $val[] = $row;
        }

        header('Content-Type: application/json');
        echo json_encode($val);
        break;

    case 'POST':
        // Add a new transaksi
        $transaksi->kdtransaksi = $_POST['kdtransaksi'];
        $transaksi->kdcustomer = $_POST['kdcustomer'];
        $transaksi->kdsparepart = $_POST['kdsparepart'];
        $transaksi->harga = $_POST['harga'];
        $transaksi->jumlah_barang = $_POST['jumlah_barang'];
        $transaksi->total = $_POST['total'];

        $transaksi->insert();
        $a = $db->affected_rows();
        if ($a > 0) {
            $data['status'] = 'success';
            $data['message'] = 'Data transaksi created successfully.';
        } else {
            $data['status'] = 'failed';
            $data['message'] = 'Data transaksi not created.';
        }
        header('Content-Type: application/json');
        echo json_encode($data);
        break;

    case 'PUT':
        // Update an existing data
        $_PUT = [];
        if(isset($_GET['id'])){
            $id = $_GET['id'];
        }
        if(isset($_GET['kdtransaksi'])){
            $kdtransaksi = $_GET['kdtransaksi'];
        }
        parse_str(file_get_contents("php://input"), $_PUT);
        $transaksi->kdtransaksi = $_PUT['kdtransaksi'];
        $transaksi->kdcustomer = $_PUT['kdcustomer'];
        $transaksi->kdsparepart = $_PUT['kdsparepart'];
        $transaksi->harga = $_PUT['harga'];
        $transaksi->jumlah_barang = $_PUT['jumlah_barang'];
        $transaksi->total = $_PUT['total'];

        if($id>0){    
            $transaksi->update_by_id($id);
        }elseif($kdtransaksi<>""){
            $transaksi->update_by_kode($kdtransaksi);
        } else {
            
        } 

        $a = $db->affected_rows();
        if ($a > 0) {
            $data['status'] = 'success';
            $data['message'] = 'Data transaksi updated successfully.';
        } else {
            $data['status'] = 'failed';
            $data['message'] = 'Data transaksi update failed.';
        }
        header('Content-Type: application/json');
        echo json_encode($data);
        break;

    case 'DELETE':
        // Delete a user
        if (isset($_GET['id'])) {
            $id = $_GET['id'];
        }
        if (isset($_GET['kdtransaksi'])) {
            $kdtransaksi = $_GET['kdtransaksi'];
        }
        if ($id > 0) {
            $transaksi->delete_by_id($id);
        } elseif ($kdtransaksi != "") {
            $transaksi->delete_by_kode($kdtransaksi);
        } else {
            // Handle delete request without id_transaksi or id_transaksi
        }

        $a = $db->affected_rows();
        if ($a > 0) {
            $data['status'] = 'success';
            $data['message'] = 'Data transaksi deleted successfully.';
        } else {
            $data['status'] = 'failed';
            $data['message'] = 'Data transaksi delete failed.';
        }
        header('Content-Type: application/json');
        echo json_encode($data);
        break;

    default:
        header("HTTP/1.0 405 Method Not Allowed");
        break;
}

$db->close();
