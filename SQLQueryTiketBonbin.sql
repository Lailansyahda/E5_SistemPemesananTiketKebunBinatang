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

ALTER VIEW vw_DataBooking AS
SELECT 
    IDBooking, KodeBooking, Nama, NoHp, Email, 
    TanggalKunjungan, TotalHarga, StatusPembayaran 
FROM Booking;
GO

ALTER VIEW vw_DataBooking AS
SELECT 
    IDBooking AS [ID],
    KodeBooking AS [Kode Booking], 
    Nama AS [Nama Pengunjung], 
    NoHp AS [No. HP], 
    Email AS [Email], 
    TanggalKunjungan AS [Tanggal], 
    TotalHarga AS [Total Harga], 
    StatusPembayaran AS [Status]
FROM Booking;
GO

ALTER VIEW vw_DataBooking AS
SELECT 
    IDBooking, 
    KodeBooking, 
    Nama, 
    NoHp, 
    Email, 
    TanggalKunjungan, 
    DetailTiket,      -- <--- Tambahkan kolom ini agar bisa dibaca oleh C#
    TotalHarga, 
    StatusPembayaran 
FROM Booking;

SELECT * FROM vw_DataBooking

SELECT * INTO Booking_Backup FROM Booking;

/*==================================================
STORED PROCEDURE DATA BOOKING (GET DATA & SEARCH)
================================================ */
CREATE PROCEDURE sp_GetBooking
    @CariKeyword VARCHAR(100) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF @CariKeyword IS NULL OR @CariKeyword = ''
    BEGIN
        SELECT 
            IDBooking, KodeBooking, IDPengunjung, IDAdmin, IDTiket, 
            Nama, NoHp, Email, TanggalKunjungan, TiketDewasa, TiketPelajar, 
            TiketAnak, DetailTiket, TotalHarga, StatusPembayaran
        FROM Booking;
    END
    ELSE
    BEGIN
        SELECT 
            IDBooking, KodeBooking, IDPengunjung, IDAdmin, IDTiket, 
            Nama, NoHp, Email, TanggalKunjungan, TiketDewasa, TiketPelajar, 
            TiketAnak, DetailTiket, TotalHarga, StatusPembayaran
        FROM Booking
        WHERE KodeBooking LIKE '%' + @CariKeyword + '%' 
           OR Nama LIKE '%' + @CariKeyword + '%';
    END
END
GO

/*==================================================
STORED PROCEDURE KELOLA TIKET - SELECT ALL
================================================ */
CREATE PROCEDURE sp_GetTiket
AS
BEGIN
    SET NOCOUNT ON;
    SELECT IDTiket, NamaTiket, Harga, KuotaHarian FROM Tiket;
END
GO

/*==================================================
STORED PROCEDURE KELOLA TIKET - INSERT
================================================ */
CREATE PROCEDURE sp_InsertTiket
    @NamaTiket VARCHAR(50),
    @Harga INT,
    @KuotaHarian INT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Tiket (NamaTiket, Harga, KuotaHarian)
    VALUES (@NamaTiket, @Harga, @KuotaHarian);
END
GO

/*==================================================
STORED PROCEDURE KELOLA TIKET - UPDATE
================================================ */
CREATE PROCEDURE sp_UpdateTiket
    @IDTiket INT,
    @NamaTiket VARCHAR(50),
    @Harga INT,
    @KuotaHarian INT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE Tiket
    SET NamaTiket = @NamaTiket,
        Harga = @Harga,
        KuotaHarian = @KuotaHarian
    WHERE IDTiket = @IDTiket;
END
GO

/*==================================================
STORED PROCEDURE KELOLA TIKET - DELETE
================================================ */
CREATE PROCEDURE sp_DeleteTiket
    @IDTiket INT
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM Tiket WHERE IDTiket = @IDTiket;
END
GO

/*==================================================
STORED PROCEDURE LAPORAN - GET BY DATE
================================================ */
CREATE PROCEDURE sp_GetReportByDate
    @TanggalPilih DATE
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        IDBooking,
        KodeBooking,
        Nama,
        TanggalKunjungan,
        TotalHarga,
        StatusPembayaran
    FROM Booking
    WHERE TanggalKunjungan = @TanggalPilih;
END
GO

/*==================================================
STORED PROCEDURE VERIFIKASI - GET DATA BY KODE
================================================ */
CREATE PROCEDURE sp_GetVerifikasi
    @KodeBooking VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        IDBooking,
        KodeBooking,
        Nama,
        TanggalKunjungan,
        TotalHarga,
        StatusPembayaran
    FROM Booking
    WHERE KodeBooking = @KodeBooking;
END
GO

/*==================================================
STORED PROCEDURE VERIFIKASI - ACTION VERIFIKASI
================================================ */
CREATE PROCEDURE sp_VerifikasiBooking
    @KodeBooking VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    -- Mengubah StatusPembayaran menjadi Lunas saat ditekan tombol Verifikasi
    UPDATE Booking
    SET StatusPembayaran = 'Lunas'
    WHERE KodeBooking = @KodeBooking;
END
GO

USE DBKebunBinatangADO;
GO

-- ==================================================
-- 3. MEMBUAT TABEL LOGGING & KEAMANAN (Sesuai Modul Praktikum)
-- ==================================================

-- Mengikuti Modul Halaman 3
CREATE TABLE LogError (
    id_log INT IDENTITY(1,1) PRIMARY KEY,
    waktu DATETIME DEFAULT GETDATE(),
    pesan_error VARCHAR(MAX)
);

-- Mengikuti Modul Halaman 4
CREATE TABLE LogAktivitas (
    id_log INT IDENTITY(1,1) PRIMARY KEY,
    aktivitas VARCHAR(100),
    waktu DATETIME DEFAULT GETDATE()
);

-- Mengikuti Modul Halaman 6
CREATE TABLE LogKeamanan (
    id_log INT IDENTITY(1,1) PRIMARY KEY,
    aktivitas VARCHAR(200),
    jumlah_data INT,
    waktu DATETIME DEFAULT GETDATE()
);
GO

--trigger
CREATE TRIGGER trg_InsertBooking
ON Booking
AFTER INSERT
AS
BEGIN
    INSERT INTO LogAktivitas (aktivitas, waktu)
    VALUES ('Tambah data booking', GETDATE());
END;
GO

CREATE TRIGGER trg_DeleteBooking
ON Booking
AFTER DELETE
AS
BEGIN
    INSERT INTO LogAktivitas (aktivitas, waktu)
    VALUES ('Hapus data booking', GETDATE());
END;
GO

select * from  LogAktivitas;

CREATE TABLE Laporan (
    IDLaporan INT IDENTITY(1,1) PRIMARY KEY,
    IDBooking INT,
    Tanggal DATE,
    TotalTransaksi INT
);

CREATE VIEW vw_Laporan AS
SELECT 
    IDBooking AS IDLaporan, 
    IDBooking, 
    TanggalKunjungan AS Tanggal, 
    TotalHarga AS TotalTransaksi
FROM Booking;
GO


--membuat report laporan
USE DBKebunBinatangADO;
GO

CREATE PROCEDURE sp_ReportBookingByDate
    @inTanggal DATE
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        Booking.KodeBooking,
        Booking.Nama,
        Booking.NoHp,
        Booking.Email,
        Booking.TanggalKunjungan,
        Booking.TotalHarga,
        Booking.StatusPembayaran
    FROM Booking
    WHERE CONVERT(DATE, Booking.TanggalKunjungan) = @inTanggal;
END;
GO


--membuat report booking 
USE DBKebunBinatangADO;
GO

CREATE PROCEDURE sp_ReportRingkasanBooking
    @inKodeBooking VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        Booking.KodeBooking AS [Kode Booking],
        Booking.Nama AS [Nama Pengunjung],
        Booking.NoHp AS [No HP],
        Booking.Email AS [Email],
        Booking.TanggalKunjungan AS [Tanggal Kunjungan],
        
        -- Detail Jumlah Per Kategori Tiket
        Booking.TiketDewasa AS [Jumlah Dewasa],
        Booking.TiketPelajar AS [Jumlah Pelajar],
        Booking.TiketAnak AS [Jumlah Anak],
        Booking.DetailTiket AS [Detail Kategori Tiket],
        
        -- Perhitungan Total Harga & Status Pembayaran Default
        Booking.TotalHarga AS [Total Harga],
        Booking.StatusPembayaran AS [Status Pembayaran]
    FROM 
        Booking
    WHERE 
        Booking.KodeBooking = @inKodeBooking;
END;
GO