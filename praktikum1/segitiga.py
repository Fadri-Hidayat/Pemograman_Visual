import tkinter as tk
from tkinter import ttk
from tkinter.messagebox import showinfo


#Function Rumus Segitiga
def hitung_luas(alas, tinggi):
    return (alas *tinggi)/2

def hitung_keliling(sisi1,sisi2,sisi3):
    return sisi1 + sisi2 + sisi3

# Function Hitung Segitiga
def hitung():
    alas = float(als_entry.get())
    tinggi = float(tnggi_entry.get())
    sisi1 = float(s1_entry.get())
    sisi2 = float(s2_entry.get())
    sisi3 = float(s3_entry.get())
    
    luas = hitung_luas(alas,tinggi)
    keliling = hitung_keliling(sisi1,sisi2,sisi3)
    
    showinfo("Hasil, By. Lukman Hakim", "Luas        : {:.2f}\nKeliling   : {:.2f}".format(luas, keliling))


pp = tk.Tk()
pp.geometry("400x350")
pp.title("Perhitungan luas and keliling segitiga")

# Frame Input
input_frame = ttk.Frame(pp)
# Penempatan (Grid, Place, Pack)
input_frame.pack(padx=10, pady=10, fill="x", expand=True)

# Komponen-komponen
als_label = ttk.Label(input_frame, text="Menghitung Luas & Keliling Segitiga")
als_label.pack(padx=10, pady=20, fill="x", expand=True)

# 1. Label alas
als_label = ttk.Label(input_frame, text="Masukkan alas Segitiga :")
als_label.pack(padx=10, fill="x", expand=True)

# 2. Entry alas
als_entry = ttk.Entry(input_frame)
als_entry.pack(padx=10, fill="x", expand=True)

# 3. Label tinggi
tnggi_label = ttk.Label(input_frame, text="Masukkan tinggi Segitiga :")
tnggi_label.pack(padx=10, fill="x", expand=True)

# 4. Entry tinggi
tnggi_entry = ttk.Entry(input_frame)
tnggi_entry.pack(padx=10, fill="x", expand=True)

# 5. Label sisi1
s1_label = ttk.Label(input_frame, text="Masukkan sisi1 Segitiga :")
s1_label.pack(padx=10, fill="x", expand=True)

# 6. Entry sisi1
s1_entry = ttk.Entry(input_frame)
s1_entry.pack(padx=10, fill="x", expand=True)

# 7. Label sisi2
s2_label = ttk.Label(input_frame, text="Masukkan sisi2 Segitiga :")
s2_label.pack(padx=10, fill="x", expand=True)

# 8. Entry sisi2
s2_entry = ttk.Entry(input_frame)
s2_entry.pack(padx=10, fill="x", expand=True)

# 9. Label sisi3
s3_label = ttk.Label(input_frame, text="Masukkan sisi3 Segitiga :")
s3_label.pack(padx=10, fill="x", expand=True)

# 10. Entry sisi3
s3_entry = ttk.Entry(input_frame)
s3_entry.pack(padx=10, fill="x", expand=True)
# 11. Tombol
tombol = ttk.Button(input_frame,text="Hitung", command=hitung)
tombol.pack(fill="x", expand="true", padx=80, pady=10)

ttk.Label(pp, text="By : Lukman Hakim",font=('arial',10)).pack()
pp.mainloop()

