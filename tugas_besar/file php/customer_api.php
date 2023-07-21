<?php
require_once 'database.php';
require_once 'Customer.php';
$db = new MySQLDatabase();
$customer = new Customer($db);
$id = 0;
$kdcustomer = 0;
// Check the HTTP request method
$method = $_SERVER['REQUEST_METHOD'];
// Handle the different HTTP methods
switch ($method) {
    case 'GET':
        if (isset($_GET['id'])) {
            $id = $_GET['id'];
        }
        if (isset($_GET['kdcustomer'])) {
            $kdcustomer = $_GET['kdcustomer'];
        }
        if ($id > 0) {
            $result = $customer->get_by_id($id);
        } elseif ($kdcustomer > 0) {
            $result = $customer->get_by_kdcustomer($kdcustomer);
        } else {
            $result = $customer->get_all();
        }

        $val = array();
        while ($row = $result->fetch_assoc()) {
            $val[] = $row;
        }

        header('Content-Type: application/json');
        echo json_encode($val);
        break;

    case 'POST':
        // Add a new customer
        $customer->kdcustomer = $_POST['kdcustomer'];
        $customer->nama = $_POST['nama'];
        $customer->jk = $_POST['jk'];
        $customer->telepon = $_POST['telepon'];

        $customer->insert();
        $a = $db->affected_rows();
        if ($a > 0) {
            $data['status'] = 'success';
            $data['message'] = 'Data Customer created successfully.';
        } else {
            $data['status'] = 'failed';
            $data['message'] = 'Data Customer not created.';
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
        if (isset($_GET['kdcustomer'])) {
            $kdcustomer = $_GET['kdcustomer'];
        }
        parse_str(file_get_contents("php://input"), $_PUT);
        $customer->kdcustomer = $_PUT['kdcustomer'];
        $customer->nama = $_PUT['nama'];
        $customer->jk = $_PUT['jk'];
        $customer->telepon = $_PUT['telepon'];
        if ($id > 0) {
            $customer->update($id);
        } elseif ($kdcustomer <> "") {
            $customer->update_by_kdcustomer($kdcustomer);
        } else {
        }

        $a = $db->affected_rows();
        if ($a > 0) {
            $data['status'] = 'success';
            $data['message'] = 'Data Customer updated successfully.';
        } else {
            $data['status'] = 'failed';
            $data['message'] = 'Data Customer update failed.';
        }
        header('Content-Type: application/json');
        echo json_encode($data);
        break;
    case 'DELETE':
        // Delete a user
        if (isset($_GET['id'])) {
            $id = $_GET['id'];
        }
        if (isset($_GET['kdcustomer'])) {
            $kdcustomer = $_GET['kdcustomer'];
        }
        if ($id > 0) {
            $customer->delete($id);
        } elseif ($kdcustomer > 0) {
            $customer->delete_by_kdcustomer($kdcustomer);
        } else {
        }

        $a = $db->affected_rows();
        if ($a > 0) {
            $data['status'] = 'success';
            $data['message'] = 'Data Customer deleted successfully.';
        } else {
            $data['status'] = 'failed';
            $data['message'] = 'Data Customer delete failed.';
        }
        header('Content-Type: application/json');
        echo json_encode($data);
        break;
    default:
        header("HTTP/1.0 405 Method Not Allowed");
        break;
}
$db->close();