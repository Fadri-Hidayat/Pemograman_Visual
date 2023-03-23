import tkinter as tk
from tkinter import ttk
from tkinter.messagebox import showinfo

def hitung_luas(d1,d2):
    return 0.5*d1*d2

def hitung_keliling(sisi):
    return 4*sisi

# Function Rumus Belah Ketupat
def hitung():
    diagonal1 = float(d1_entry.get())
    diagonal2 = float(d2_entry.get())
    sisi = float(sisi_entry.get())
    
    luas = hitung_luas(diagonal1,diagonal2)
    keliling = hitung_keliling(sisi)
    
    showinfo("Hasil, By. Lukman Hakim", "Luas        : {:.2f}\nKeliling   : {:.2f}".format(luas, keliling))
    
pp = tk.Tk()
pp.geometry("500x400")
pp.title("Perhitungan luas and keliling belah ketupat")

# Frame Input
input_frame = ttk.Frame(pp)
# Penempatan (Grid, Place, Pack)
input_frame.pack(padx=10, pady=10, fill="x", expand=True)

# Komponen-komponen
d1_label = ttk.Label(input_frame, text="Menghitung Luas & Keliling Belah Ketupat")
d1_label.pack(padx=10, pady=20, fill="x", expand=True)
# 1. Label diagonal_1
d1_label = ttk.Label(input_frame, text="Masukkan diagonal 1 :")
d1_label.pack(padx=10, fill="x", expand=True)
# 2. Entry diagonal_1
d1_entry = ttk.Entry(input_frame)
d1_entry.pack(padx=10, fill="x", expand=True)
# 3. Label diagonal_2
d2_label = ttk.Label(input_frame, text="Masukkan diagonal 2 :")
d2_label.pack(padx=10, fill="x", expand=True)
# 4. Entry diagonal_2
d2_entry = ttk.Entry(input_frame)
d2_entry.pack(padx=10, fill="x", expand=True)
# 5. Label sisi
sisi_label = ttk.Label(input_frame, text="Masukkan sisi :")
sisi_label.pack(padx=10, fill="x", expand=True)
# 6. Entry sisi
sisi_entry = ttk.Entry(input_frame)
sisi_entry.pack(padx=10, fill="x", expand=True)

# 7. Tombol
tombol = ttk.Button(input_frame,text="Hitung", command=hitung)
tombol.pack(fill="x", expand="true", padx=80, pady=10)

ttk.Label(pp, text="By : Lukman Hakim",font=('arial',10)).pack()
pp.mainloop()

