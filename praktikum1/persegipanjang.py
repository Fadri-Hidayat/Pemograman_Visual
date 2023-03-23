import tkinter as tk
from tkinter import ttk
from tkinter.messagebox import showinfo

#Function Rumus  Persegi Panjang
def hitung_luas(panjang, lebar):
    return panjang * lebar

def hitung_keliling(panjang, lebar):
    return 2 * (panjang + lebar)

# Function Hitung Persegi Panjang
def hitung():
    panjang = float(pjg_entry.get())
    lebar = float(lbr_entry.get())
    
    luas = hitung_luas(panjang,lebar)
    keliling = hitung_keliling(panjang ,lebar)
    
    showinfo("Hasil, Lukman Hakim", "Luas        : {:.2f}\nKeliling   : {:.2f}".format(luas, keliling))
    


pp = tk.Tk()
pp.geometry("400x250")
pp.title("Perhitungan luas and keliling persegi panjang")

# Frame Input
input_frame = ttk.Frame(pp)
# Penempatan (Grid, Place, Pack)
input_frame.pack(padx=10, pady=10, fill="x", expand=True)

# Komponen-komponen
pjg_label = ttk.Label(input_frame, text="Menghitung Luas & Keliling Persegi Panjang")
pjg_label.pack(padx=10, pady=20, fill="x", expand=True)
# 1. Label Panjang
pjg_label = ttk.Label(input_frame, text="Masukkan Panjang :")
pjg_label.pack(padx=10, fill="x", expand=True)
# 2. Entry Panjang
pjg_entry = ttk.Entry(input_frame)
pjg_entry.pack(padx=10, fill="x", expand=True)
# 3. Label Lebar
lbr_label = ttk.Label(input_frame, text="Masukkan Lebar :")
lbr_label.pack(padx=10, fill="x", expand=True)
# 4. Entry Lebar
lbr_entry = ttk.Entry(input_frame)
lbr_entry.pack(padx=10, fill="x", expand=True)
# 5. Tombol
tombol = ttk.Button(input_frame,text="Hitung", command=hitung)
tombol.pack(fill="x", expand="true", padx=80, pady=10)

ttk.Label(pp, text="By : Lukman Hakim",font=('arial',10)).pack()
pp.mainloop()

