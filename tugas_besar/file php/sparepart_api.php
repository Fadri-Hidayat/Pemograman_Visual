<?php

require_once 'database.php';
require_once 'Sparepart.php';

$db = new MySQLDatabase();
$sparepart = new sparepart($db);

$id = 0;
$kdsparepart = 0;

// Check the HTTP request method
$method = $_SERVER['REQUEST_METHOD'];

// Handle the different HTTP methods
switch ($method) {

    case 'GET':
        if (isset($_GET['id'])) {
            $id = $_GET['id'];
        }
        if (isset($_GET['kdsparepart'])) {
            $kdsparepart = $_GET['kdsparepart'];
        }
        if ($id > 0) {
            $result = $sparepart->get_by_id($id);
        } elseif ($kdsparepart > 0) {
            $result = $sparepart->get_by_kdsparepart($kdsparepart);
        } else {
            $result = $sparepart->get_all();
        }

        $val = array();
        while ($row = $result->fetch_assoc()) {
            $val[] = $row;
        }

        header('Content-Type: application/json');
        echo json_encode($val);
        break;

    case 'POST':
        // Add a new sparepart
        $sparepart->kdsparepart = $_POST['kdsparepart'];
        $sparepart->nama = $_POST['nama'];
        $sparepart->stok = $_POST['stok'];
        $sparepart->harga = $_POST['harga'];

        $sparepart->insert();
        $a = $db->affected_rows();
        if ($a > 0) {
            $data['status'] = 'success';
            $data['message'] = 'Data sparepart created successfully.';
        } else {
            $data['status'] = 'failed';
            $data['message'] = 'Data sparepart not created.';
        }
        header('Content-Type: application/json');
        echo json_encode($data);
        break;

    case 'PUT':
        // Update an existing data
        $_PUT = [];
        if (isset($_GET['id'])) {
            $id = $_GET['id'];
        }
        if (isset($_GET['kdsparepart'])) {
            $kdsparepart = $_GET['kdsparepart'];
        }
        parse_str(file_get_contents("php://input"), $_PUT);
        $sparepart->kdsparepart = $_PUT['kdsparepart'];
        $sparepart->nama = $_PUT['nama'];
        $sparepart->stok = $_PUT['stok'];
        $sparepart->harga = $_PUT['harga'];

        if ($id > 0) {
            $sparepart->update($id);
        } elseif ($kdsparepart <> "") {
            $sparepart->update_by_kdsparepart($kdsparepart);
        } else {
        }

        $a = $db->affected_rows();
        if ($a > 0) {
            $data['status'] = 'success';
            $data['message'] = 'Data sparepart updated successfully.';
        } else {
            $data['status'] = 'failed';
            $data['message'] = 'Data sparepart update failed.';
        }
        header('Content-Type: application/json');
        echo json_encode($data);
        break;

    case 'DELETE':
        // Delete a user
        if (isset($_GET['id'])) {
            $id = $_GET['id'];
        }
        if (isset($_GET['kdsparepart'])) {
            $kdsparepart = $_GET['kdsparepart'];
        }
        if ($id > 0) {
            $sparepart->delete($id);
        } elseif ($kdsparepart > 0) {
            $sparepart->delete_by_kdsparepart($kdsparepart);
        } else {
        }

        $a = $db->affected_rows();
        if ($a > 0) {
            $data['status'] = 'success';
            $data['message'] = 'Data sparepart deleted successfully.';
        } else {
            $data['status'] = 'failed';
            $data['message'] = 'Data sparepart delete failed.';
        }
        header('Content-Type: application/json');
        echo json_encode($data);
        break;

    default:
        header("HTTP/1.0 405 Method Not Allowed");
        break;
}
$db->close();