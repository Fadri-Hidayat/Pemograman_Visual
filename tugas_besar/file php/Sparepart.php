<?php

require_once 'database.php';

class sparepart
{
    private $db;
    private $table = 'sparepart';
    public $kdsparepart = "";
    public $nama = "";
    public $stok = "";
    public $harga = "";

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
    public function get_by_kdsparepart(int $kdsparepart)
    {
        $query = "SELECT * FROM $this->table WHERE kdsparepart = $kdsparepart";
        $result_set = $this->db->query($query);
        return $result_set;
    }
    public function insert(): int
    {
        $query = "INSERT INTO $this->table (`kdsparepart`,`nama`,`stok`,`harga`) VALUES ('$this->kdsparepart','$this->nama','$this->stok','$this->harga')";
        $this->db->query($query);
        return $this->db->insert_id();
    }
    public function update(int $id): int
    {
        $query = "UPDATE $this->table SET kdsparepart = '$this->kdsparepart', nama = '$this->nama', stok = '$this->stok', harga = '$this->harga'
        WHERE id = $id";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function update_by_kdsparepart($kdsparepart): int
    {
        $query = "UPDATE $this->table SET kdsparepart = '$this->kdsparepart', nama = '$this->nama',  stok = '$this->stok', harga = '$this->harga'
        WHERE kdsparepart = $kdsparepart";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function delete(int $id): int
    {
        $query = "DELETE FROM $this->table WHERE id = $id";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function delete_by_kdsparepart($kdsparepart): int
    {
        $query = "DELETE FROM $this->table WHERE kdsparepart = $kdsparepart";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
}
