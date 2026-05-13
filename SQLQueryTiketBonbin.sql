CREATE DATABASE DBKebunBinatangADO;
GO
USE DBKebunBinatangADO;
GO

CREATE TABLE Tiket (
    IDTiket INT IDENTITY(1,1) PRIMARY KEY,
    NamaTiket VARCHAR(50) NOT NULL,
    Harga INT NOT NULL,
    KuotaHarian INT NOT NULL
);

CREATE TABLE Pengunjung (
    IDPengunjung INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(50) UNIQUE NOT NULL,
    Email VARCHAR(100) UNIQUE NOT NULL,
    Password VARCHAR(15) NOT NULL
);

CREATE TABLE Admin (
    IDAdmin INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(50) UNIQUE NOT NULL,
    Password VARCHAR(15) NOT NULL
);

CREATE TABLE Booking (
    IDBooking INT IDENTITY(1,1) PRIMARY KEY,
    KodeBooking VARCHAR(50) UNIQUE NOT NULL,
    IDPengunjung INT,
    IDAdmin INT, 
    IDTiket INT, 
    Nama VARCHAR(100) NOT NULL,
    NoHp VARCHAR(15) NOT NULL,
    Email VARCHAR(100) NOT NULL,
    TanggalKunjungan DATE NOT NULL,
    TiketDewasa INT DEFAULT 0,
    TiketPelajar INT DEFAULT 0,
    TiketAnak INT DEFAULT 0,
    DetailTiket VARCHAR(255) NOT NULL,
    TotalHarga INT NOT NULL,
    StatusPembayaran VARCHAR(50) DEFAULT 'Bayar di Loket',
    
    CONSTRAINT FK_Booking_Pengunjung FOREIGN KEY (IDPengunjung) REFERENCES Pengunjung(IDPengunjung),
    CONSTRAINT FK_Booking_Admin FOREIGN KEY (IDAdmin) REFERENCES Admin(IDAdmin),
    CONSTRAINT FK_Booking_Tiket FOREIGN KEY (IDTiket) REFERENCES Tiket(IDTiket)
);

CREATE TABLE Laporan (
    IDLaporan INT IDENTITY(1,1) PRIMARY KEY,
    IDBooking INT,
    Tanggal DATE DEFAULT CAST(GETDATE() AS DATE),
    TotalTransaksi INT DEFAULT 0,
    CONSTRAINT FK_Laporan_Booking FOREIGN KEY (IDBooking) REFERENCES Booking(IDBooking)
);
GO

INSERT INTO Tiket (NamaTiket, Harga, KuotaHarian) VALUES
('Dewasa', 70000, 300),
('Pelajar', 50000, 300),
('Anak', 30000, 200);

INSERT INTO Admin (Username, Password) VALUES ('admin', 'admin123');

INSERT INTO Pengunjung (Username, Email, Password) VALUES
('budi_santoso', 'budi@email.com', 'pass123'),
('siti_aminah', 'siti@email.com', 'pass456');

INSERT INTO Booking (KodeBooking, IDPengunjung, IDAdmin, IDTiket, Nama, NoHp, Email, TanggalKunjungan, TiketDewasa, TiketPelajar, TiketAnak, DetailTiket, TotalHarga) VALUES
('ZOO-001', 1, 1, 1, 'Budi Santoso', '08123', 'budi@email.com', '2026-04-20', 2, 1, 0, '2 Dewasa, 1 Pelajar', 135000),
('ZOO-002', 2, 1, 2, 'Siti Aminah', '08567', 'siti@email.com', '2026-04-20', 1, 0, 1, '1 Dewasa, 1 Anak', 75000);

INSERT INTO Laporan (IDBooking, TotalTransaksi) VALUES (1, 1), (2, 1);

CREATE VIEW vw_DataBooking AS
SELECT 
    IDBooking, KodeBooking, Nama, NoHp, Email, 
    TanggalKunjungan, TotalHarga, StatusPembayaran 
FROM Booking;
GO

SELECT * INTO Booking_Backup FROM Booking;

-- 1. SP untuk Mengambil Semua Data
CREATE PROCEDURE sp_GetTiket
AS
BEGIN
    SET NOCOUNT ON;
    SELECT IDTiket, NamaTiket, Harga, KuotaHarian FROM Tiket;
END
GO

-- 2. SP untuk Tambah Data
CREATE PROCEDURE sp_InsertTiket
    @nama VARCHAR(100),
    @harga INT,
    @kuota INT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Tiket (NamaTiket, Harga, KuotaHarian)
    VALUES (@nama, @harga, @kuota);
END
GO

-- 3. SP untuk Update Data
CREATE PROCEDURE sp_UpdateTiket
    @id INT,
    @nama VARCHAR(100),
    @harga INT,
    @kuota INT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE Tiket 
    SET NamaTiket = @nama, Harga = @harga, KuotaHarian = @kuota 
    WHERE IDTiket = @id;
END
GO

-- 4. SP untuk Hapus Data
CREATE PROCEDURE sp_DeleteTiket
    @id INT
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM Tiket WHERE IDTiket = @id;
END
GO