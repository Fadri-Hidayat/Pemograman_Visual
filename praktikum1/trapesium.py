import tkinter as tk
from tkinter import ttk
from tkinter.messagebox import showinfo

#Function Rumus Trapesium
def hitung_luas(altas,albaw, tinggi):
    return ((altas+albaw)*tinggi)/2

def hitung_keliling(altas,albaw,skan,skir):
    return altas + albaw + skan + skir

# Function Rumus Trapesium
def hitung():
    atas = float(altas_entry.get())
    bawah = float(albaw_entry.get())
    tinggi = float(tggi_entry.get())
    atas = float(altas_entry.get())
    bawah = float(albaw_entry.get())
    kanan = float(skan_entry.get())
    kiri = float(skir_entry.get())
    
    luas = hitung_luas(atas,bawah,tinggi)
    keliling = hitung_keliling(atas,bawah,kanan,kiri)
    showinfo("Hasil, by. Lukman Hakim", f"Luas        : {luas} \nKeliling   : {keliling}")
    
    
pp = tk.Tk()
pp.geometry("400x350")
pp.title("Perhitungan luas and keliling trapesium")

# Frame Input
input_frame = ttk.Frame(pp)
# Penempatan (Grid, Place, Pack)
input_frame.pack(padx=10, pady=10, fill="x", expand=True)

# Komponen-komponen
altas_label = ttk.Label(input_frame, text="Menghitung Luas & Keliling Trapesium")
altas_label.pack(padx=10, pady=20, fill="x", expand=True)
# 1. Label ab
altas_label = ttk.Label(input_frame, text="Masukkan sisi atas :")
altas_label.pack(padx=10, fill="x", expand=True)
# 2. Entry ab
altas_entry = ttk.Entry(input_frame)
altas_entry.pack(padx=10, fill="x", expand=True)
# 3. Label cd
albaw_label = ttk.Label(input_frame, text="Masukkan sisi bawah :")
albaw_label.pack(padx=10, fill="x", expand=True)
# 4. Entry cd
albaw_entry = ttk.Entry(input_frame)
albaw_entry.pack(padx=10, fill="x", expand=True)
# 5. Label bc
skan_label = ttk.Label(input_frame, text="Masukkan sisi kanan :")
skan_label.pack(padx=10, fill="x", expand=True)
# 6. Entry bc
skan_entry = ttk.Entry(input_frame)
skan_entry.pack(padx=10, fill="x", expand=True)
# 7. Label da
skir_label = ttk.Label(input_frame, text="Masukkan sisi kiri :")
skir_label.pack(padx=10, fill="x", expand=True)
# 8. Entry da
skir_entry = ttk.Entry(input_frame)
skir_entry.pack(padx=10, fill="x", expand=True)
# 9. Label t
tggi_label = ttk.Label(input_frame, text="Masukkan tinggi :")
tggi_label.pack(padx=10, fill="x", expand=True)
# 10. Entry t
tggi_entry = ttk.Entry(input_frame)
tggi_entry.pack(padx=10, fill="x", expand=True)
# 11. Tombol
tombol = ttk.Button(input_frame,text="Hitung", command=hitung)
tombol.pack(fill="x", expand="true", padx=80, pady=10)

ttk.Label(pp, text="By : Lukman Hakim",font=('arial',10)).pack()
pp.mainloop()

