import tkinter as tk
from tkinter import ttk
from tkinter.messagebox import showinfo

#Function Rumus  Persegi 
def hitung_luas(jari):
    return 3.14 * (jari**2)

def hitung_keliling(jari):
    return 2*3.14*jari

# Function Rumus Lingkaran
def hitung():
    r = float(r_entry.get())
    
    luas = hitung_luas(r)
    keliling = hitung_keliling(r)
    
   
    
    showinfo("Hasil, By. Lukman", "Luas        : {:.2f}\nKeliling   : {:.2f}".format(luas, keliling))
    
pp = tk.Tk()
pp.geometry("400x250")
pp.title("Perhitungan luas and keliling Lingkaran")

# Frame Input
input_frame = ttk.Frame(pp)
# Penempatan (Grid, Place, Pack)
input_frame.pack(padx=10, pady=10, fill="x", expand=True)

# Komponen-komponen
r_label = ttk.Label(input_frame, text="Menghitung Luas & Keliling Lingkaran")
r_label.pack(padx=10, pady=20, fill="x", expand=True)
# 1. Label jari_jari
r_label = ttk.Label(input_frame, text="Masukkan jari_jari :")
r_label.pack(padx=10, fill="x", expand=True)
# 2. Entry jari_jari
r_entry = ttk.Entry(input_frame)
r_entry.pack(padx=10, fill="x", expand=True)
# 3. Tombol
tombol = ttk.Button(input_frame,text="Hitung", command=hitung)
tombol.pack(fill="x", expand="true", padx=80, pady=10)

ttk.Label(pp, text="By : Lukman Hakim",font=('arial',10)).pack()
pp.mainloop()

