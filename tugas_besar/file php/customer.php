<?php
//Simpanlah dengan nama file : Mahasiswa.php
require_once 'database.php';
class Customer
{
    private $db;
    private $table = 'customer';
    public $kdcustomer = "";
    public $nama = "";
    public $jk = "";
    public $telepon = "";
    public function __construct(MySQLDatabase $db)
    {
        $this->db = $db;
    }
    public function get_all()
    {
        $query = "SELECT * FROM $this->table";
        $result_set = $this->db->query($query);
        return $result_set;
    }
    public function get_by_id(int $id)
    {
        $query = "SELECT * FROM $this->table WHERE id = $id";
        $result_set = $this->db->query($query);
        return $result_set;
    }
    public function get_by_kdcustomer(int $kdcustomer)
    {
        $query = "SELECT * FROM $this->table WHERE kdcustomer = $kdcustomer";
        $result_set = $this->db->query($query);
        return $result_set;
    }
    public function insert(): int
    {
        $query = "INSERT INTO $this->table (`kdcustomer`,`nama`,`jk`,`telepon`) VALUES ('$this->kdcustomer','$this->nama','$this->jk','$this->telepon')";
        $this->db->query($query);
        return $this->db->insert_id();
    }
    public function update(int $id): int
    {
        $query = "UPDATE $this->table SET kdcustomer = '$this->kdcustomer', nama = '$this->nama', jk = '$this->jk', telepon = '$this->telepon' 
        WHERE id = $id";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function update_by_kdcustomer($kdcustomer): int
    {
        $query = "UPDATE $this->table SET kdcustomer = '$this->kdcustomer', nama = '$this->nama', jk = '$this->jk', telepon = '$this->telepon' 
        WHERE kdcustomer = $kdcustomer";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function delete(int $id): int
    {
        $query = "DELETE FROM $this->table WHERE id = $id";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function delete_by_kdcustomer($kdcustomer): int
    {
        $query = "DELETE FROM $this->table WHERE kdcustomer = $kdcustomer";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
}