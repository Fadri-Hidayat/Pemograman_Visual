<?php
//Simpanlah dengan nama file : transaksi.php
require_once 'database.php';

class transaksi
{
    private $db;
    private $table = 'transaksi';
    public $kdtransaksi = "";
    public $kdcustomer = "";
    public $kdsparepart = "";
    public $harga = "";
    public $jumlah_barang = "";
    public $total = "";


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

    public function get_by_kode(int $kdtransaksi)
    {
        $query = "SELECT * FROM $this->table WHERE kdtransaksi = '$kdtransaksi'";
        $result_set = $this->db->query($query);
        return $result_set;
    }

    public function insert(): int
    {
        $query = "INSERT INTO $this->table (`kdtransaksi`,`kdcustomer`,`kdsparepart`,`harga`,`jumlah_barang`,`total`) VALUES ('$this->kdsparepart','$this->kdcustomer','$this->kdsparepart','$this->harga','$this->jumlah_barang','$this->total')";
        $this->db->query($query);
        return $this->db->insert_id();
    }

    public function update_by_id(int $id): int
    {
        $query = "UPDATE $this->table SET kdtransaksi = '$this->kdtransaksi',kdcustomer='$this->kdcustomer', kdsparepart='$this->kdsparepart',harga = '$this->harga', jumlah_barang = '$this->jumlah_barang' , total = '$this->total'
        WHERE id = $id";
        $this->db->query($query);
        return $this->db->affected_rows();
    }

    public function update_by_kode($kdtransaksi): int
    {
        $query = "UPDATE $this->table SET  kdtransaksi = '$this->kdtransaksi', kdcustomer='$this->kdcustomer', kdsparepart='$this->kdsparepart',harga = '$this->harga', jumlah_barang = '$this->jumlah_barang' , total = '$this->total'
        WHERE kdtransaksi = '$kdtransaksi'";
        $this->db->query($query);
        return $this->db->affected_rows();
    }

    public function delete_by_id(int $id): int
    {
        $query = "DELETE FROM $this->table WHERE id = $id";
        $this->db->query($query);
        return $this->db->affected_rows();
    }

    public function delete_by_kode($kdtransaksi): int
    {
        $query = "DELETE FROM $this->table WHERE kdtransaksi = '$kdtransaksi'";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
}
