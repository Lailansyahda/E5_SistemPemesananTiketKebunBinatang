CREATE DATABASE DBKebunBinatangADO;
GO
USE DBKebunBinatangADO;
GO

-- 1. Tabel Tiket
CREATE TABLE Tiket (
    IDTiket INT IDENTITY(1,1) PRIMARY KEY,
    NamaTiket VARCHAR(50) NOT NULL, -- 'Dewasa', 'Pelajar', 'Anak'
    Harga INT NOT NULL,
    KuotaHarian INT NOT NULL
);

-- 2. Tabel Pengunjung
CREATE TABLE Pengunjung (
    IDPengunjung INT IDENTITY(1,1) PRIMARY KEY,
    Nama VARCHAR(100) NOT NULL,
    NoHp VARCHAR(15) NOT NULL,
    Email VARCHAR(100) UNIQUE NOT NULL,
    Password VARCHAR(255) NOT NULL
);

-- 3. Tabel Admin
CREATE TABLE Admin (
    IDAdmin INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(50) UNIQUE NOT NULL,
    Password VARCHAR(255) NOT NULL
);

-- 4. Tabel Booking (dengan DetailTiket untuk ringkasan)
CREATE TABLE Booking (
    IDBooking INT IDENTITY(1,1) PRIMARY KEY,
    KodeBooking VARCHAR(50) UNIQUE NOT NULL,
    Nama VARCHAR(100) NOT NULL,
    NoHp VARCHAR(15) NOT NULL,
    Email VARCHAR(100) NOT NULL,
    TanggalKunjungan DATE NOT NULL,
    TiketDewasa INT DEFAULT 0,
    TiketPelajar INT DEFAULT 0,
    TiketAnak INT DEFAULT 0,
    DetailTiket VARCHAR(255) NOT NULL, -- contoh: "2 Dewasa, 1 Pelajar"
    TotalHarga INT NOT NULL,
    StatusPembayaran VARCHAR(50) DEFAULT 'Bayar di Loket',
    TanggalBooking DATETIME DEFAULT GETDATE()
);

-- 5. Tabel Laporan (ringkasan harian)
CREATE TABLE Laporan (
    IDLaporan INT IDENTITY(1,1) PRIMARY KEY,
    Tanggal DATE DEFAULT CAST(GETDATE() AS DATE),
    TotalTransaksi INT DEFAULT 0,
);

-- =====================================================
-- INSERT DATA KE SEMUA TABEL
-- =====================================================

-- 1. Tabel Tiket
INSERT INTO Tiket (NamaTiket, Harga, KuotaHarian) VALUES
('Dewasa',   70.000, 300),
('Pelajar',  50.000, 300),
('Anak',     25.000, 200);

-- 2. Tabel Admin
INSERT INTO Admin (Username, Password) VALUES
('admin',     'admin123');

-- 3. Tabel Pengunjung (minimal 2 contoh)
INSERT INTO Pengunjung (Nama, NoHp, Email, Password) VALUES
('Budi Santoso',   '08123456789',   'budi@email.com',   'pass123'),
('Siti Aminah',    '08567890123',   'siti@email.com',   'pass456'),
('Joko Widodo',    '081122334455',  'joko@email.com',   'pass789');

-- 4. Tabel Booking (contoh transaksi)
INSERT INTO Booking (
    KodeBooking, Nama, NoHp, Email, TanggalKunjungan,
    TiketDewasa, TiketPelajar, TiketAnak, DetailTiket, TotalHarga, StatusPembayaran, TanggalBooking
) VALUES
('BOOK001', 'Budi Santoso', '08123456789', 'budi@email.com',    '2026-04-20', 2, 1, 0, '2 Dewasa, 1 Pelajar', 135000, 'Bayar di Loket', GETDATE()),
('BOOK002', 'Siti Aminah',  '08567890123', 'siti@email.com',    '2026-04-20', 1, 0, 1, '1 Dewasa, 1 Anak',     75000,  'Lunas',          GETDATE()),
('BOOK003', 'Joko Widodo',  '081122334455', 'joko@email.com',   '2026-04-21', 0, 2, 0, '2 Pelajar',            70000,  'Belum Bayar',    GETDATE());

-- 5. Tabel Laporan (ringkasan per tanggal)
INSERT INTO Laporan (Tanggal, TotalTransaksi) VALUES
('2026-04-20', 2),   -- dari BOOK001 & BOOK002
('2026-04-21', 1);   -- dari BOOK003