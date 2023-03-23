import tkinter as tk
from tkinter import ttk
from tkinter.messagebox import showinfo


#Function Rumus  Persegi 
def hitung_luas(d1,d2):
    return (d1*d2)/2

def hitung_keliling(sisi1,sisi2,sisi3,sisi4):
    return sisi1 + sisi2 + sisi3 + sisi4

# Function Rumus Layang - Layang
def hitung():
    diagonal1 = float(diagonal1_entry.get())
    diagonal2 = float(diagonal2_entry.get())
    s1 = float(s1_entry.get())
    s2 = float(s2_entry.get())
    s3 = float(s3_entry.get())
    s4 = float(s4_entry.get())
    
    luas =  hitung_luas(diagonal1,diagonal2)
    keliling = hitung_keliling(s1,s2,s3,s4)
    
    showinfo("Hasil, By. Lukman Hakim", "Luas        : {:.2f}\nKeliling   : {:.2f}".format(luas, keliling))
    
pp = tk.Tk()
pp.geometry("500x400")
pp.title("Perhitungan luas and keliling Layang-layang")

# Frame Input
input_frame = ttk.Frame(pp)
# Penempatan (Grid, Place, Pack)
input_frame.pack(padx=10, pady=10, fill="x", expand=True)

# Komponen-komponen
diagonal1_label = ttk.Label(input_frame, text="Menghitung Luas & Keliling Layang - Layang")
diagonal1_label.pack(padx=10, pady=20, fill="x", expand=True)
# 1. Label diagonal_1
diagonal1_label = ttk.Label(input_frame, text="Masukkan diagonal 1 :")
diagonal1_label.pack(padx=10, fill="x", expand=True)
# 2. Entry diagonal_1
diagonal1_entry = ttk.Entry(input_frame)
diagonal1_entry.pack(padx=10, fill="x", expand=True)
# 3. Label diagonal_2
diagonal2_label = ttk.Label(input_frame, text="Masukkan diagonal 2 :")
diagonal2_label.pack(padx=10, fill="x", expand=True)
# 4. Entry diagonal_2
diagonal2_entry = ttk.Entry(input_frame)
diagonal2_entry.pack(padx=10, fill="x", expand=True)
# 5. Label sisi_1
s1_label = ttk.Label(input_frame, text="Masukkan sisi 1 :")
s1_label.pack(padx=10, fill="x", expand=True)
# 6. Entry sisi_1
s1_entry = ttk.Entry(input_frame)
s1_entry.pack(padx=10, fill="x", expand=True)
# 7. Label sisi_2
s2_label = ttk.Label(input_frame, text="Masukkan sisi 2 :")
s2_label.pack(padx=10, fill="x", expand=True)
# 8. Entry sisi_2
s2_entry = ttk.Entry(input_frame)
s2_entry.pack(padx=10, fill="x", expand=True)
# 9. Label sisi_3
s3_label = ttk.Label(input_frame, text="Masukkan sisi 3 :")
s3_label.pack(padx=10, fill="x", expand=True)
# 10. Entry sisi_3
s3_entry = ttk.Entry(input_frame)
s3_entry.pack(padx=10, fill="x", expand=True)
# 11. Label sisi_4
s4_label = ttk.Label(input_frame, text="Masukkan sisi 4 :")
s4_label.pack(padx=10, fill="x", expand=True)
# 12. Entry sisi_4
s4_entry = ttk.Entry(input_frame)
s4_entry.pack(padx=10, fill="x", expand=True)
# 13. Tombol
tombol = ttk.Button(input_frame,text="Hitung", command=hitung)
tombol.pack(fill="x", expand="true", padx=80, pady=10)

ttk.Label(pp, text="By : Lukman Hakim",font=('arial',10)).pack()
pp.mainloop()

