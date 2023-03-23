import tkinter as tk
from tkinter import ttk
from tkinter.messagebox import showinfo


#Function Rumus  Persegi 
def hitung_luas(sisi):
    return sisi**2

def hitung_keliling(sisi):
    return 4*sisi

# Function Rumus Persegi / Bujur Sangkar
def hitung():
    sisi = float(ss_entry.get())
    
    luas = hitung_luas(sisi)
    keliling = hitung_keliling(sisi)
    
    showinfo("Hasil, Lukman Hakim", "Luas        : {:.2f}\nKeliling   : {:.2f}".format(luas, keliling))

pp = tk.Tk()
pp.geometry("400x250")
pp.title("Perhitungan luas and keliling persegi.")

# Frame Input
input_frame = ttk.Frame(pp)
# Penempatan (Grid, Place, Pack)
input_frame.pack(padx=10, pady=10, fill="x", expand=True)    

# Komponen-komponen
ss_label = ttk.Label(input_frame, text="Menghitung Luas & Keliling Persegi")
ss_label.pack(padx=10, pady=20, fill="x", expand=True)
# 1. Label sisi
ss_label = ttk.Label(input_frame, text="Masukkan sisi :")
ss_label.pack(padx=10, fill="x", expand=True)
# 2. Entry sisi
ss_entry = ttk.Entry(input_frame)
ss_entry.pack(padx=10, fill="x", expand=True)
# 3. Tombol
tombol = ttk.Button(input_frame,text="Hitung", command=hitung)
tombol.pack(fill="x", expand="true", padx=80, pady=10)

ttk.Label(pp, text="By : Lukman Hakim",font=('arial',10)).pack()
pp.mainloop()
