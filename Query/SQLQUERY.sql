create database KueTradisionalDB;

create table Kue (
    KueID int primary key identity(1,1),
    NamaKue varchar(20) NOT NULL,
    Harga int NOT NULL
);

create table Pesanan (
    PesananID int primary key identity(1,1),
    KueID int NOT NULL,
	NamaPelanggan varchar(20),
    Jumlah int NOT NULL,
    TanggalPesan date NOT NULL,
    TanggalAmbil date NOT NULL,
    TotalHarga int NOT NULL,
    foreign key (KueID) references Kue(KueID)
);

SELECT * FROM Pesanan;
Select * From  Kue;


CREATE TABLE LogError (
    LogID INT IDENTITY(1,1) PRIMARY KEY,
    ErrorMessage VARCHAR(MAX),
    ErrorProcedure VARCHAR(100),
    ErrorLine INT,
    ErrorTime DATETIME DEFAULT GETDATE()
);

CREATE TABLE LogAktivitas (
    LogID INT IDENTITY(1,1) PRIMARY KEY,
    NamaTabel VARCHAR(50),
    Aksi VARCHAR(20),
    Keterangan VARCHAR(MAX),
    Waktu DATETIME DEFAULT GETDATE()
);

CREATE PROCEDURE sp_ReportPesanan
    @TanggalAwal DATE,
    @TanggalAkhir DATE
AS
BEGIN
    SELECT
        p.PesananID,
        pl.NamaPelanggan,
        k.NamaKue,
        p.Jumlah,
        p.TanggalPesan,
        p.TanggalAmbil,
        p.TotalHarga
    FROM Pesanan p
    INNER JOIN Pelanggan pl ON p.PelangganID = pl.PelangganID
    INNER JOIN Kue k ON p.KueID = k.KueID
    WHERE p.TanggalPesan BETWEEN @TanggalAwal AND @TanggalAkhir
    ORDER BY p.TanggalPesan DESC;
END;

CREATE TRIGGER trg_InsertKue
ON Kue
AFTER INSERT
AS
BEGIN
    INSERT INTO LogAktivitas (NamaTabel, Aksi, Keterangan)
    SELECT
        'Kue',
        'INSERT',
        'Menambahkan data kue: ' + NamaKue
    FROM inserted;
END;

CREATE TRIGGER trg_UpdateKue
ON Kue
AFTER UPDATE
AS
BEGIN
    INSERT INTO LogAktivitas (NamaTabel, Aksi, Keterangan)
    SELECT
        'Kue',
        'UPDATE',
        'Mengubah data kue: ' + NamaKue
    FROM inserted;
END;

CREATE TRIGGER trg_DeleteKue
ON Kue
AFTER DELETE
AS
BEGIN
    INSERT INTO LogAktivitas (NamaTabel, Aksi, Keterangan)
    SELECT
        'Kue',
        'DELETE',
        'Menghapus data kue: ' + NamaKue
    FROM deleted;
END;

CREATE PROCEDURE sp_ImportKue
    @NamaKue VARCHAR(100),
    @Harga INT
AS
BEGIN
    INSERT INTO Kue (NamaKue, Harga)
    VALUES (@NamaKue, @Harga);
END;

EXEC sp_ReportPesanan 
    @TanggalAwal = '2026-01-01',
    @TanggalAkhir = '2026-12-31';



INSERT INTO Kue (NamaKue, Harga)
VALUES ('Klepon', 3000);

SELECT * FROM LogAktivitas;



CREATE TRIGGER trg_InsertPelanggan
ON Pelanggan
AFTER INSERT
AS
BEGIN
    INSERT INTO LogAktivitas (NamaTabel, Aksi, Keterangan)
    SELECT
        'Pelanggan',
        'INSERT',
        'Menambahkan data pelanggan: ' + NamaPelanggan
    FROM inserted;
END;

CREATE TRIGGER trg_UpdatePelanggan
ON Pelanggan
AFTER UPDATE
AS
BEGIN
    INSERT INTO LogAktivitas (NamaTabel, Aksi, Keterangan)
    SELECT
        'Pelanggan',
        'UPDATE',
        'Mengubah data pelanggan: ' + NamaPelanggan
    FROM inserted;
END;


CREATE TRIGGER trg_DeletePelanggan
ON Pelanggan
AFTER DELETE
AS
BEGIN
    INSERT INTO LogAktivitas (NamaTabel, Aksi, Keterangan)
    SELECT
        'Pelanggan',
        'DELETE',
        'Menghapus data pelanggan: ' + NamaPelanggan
    FROM deleted;
END;


CREATE TRIGGER trg_InsertPesanan
ON Pesanan
AFTER INSERT
AS
BEGIN
    INSERT INTO LogAktivitas (NamaTabel, Aksi, Keterangan)
    SELECT
        'Pesanan',
        'INSERT',
        'Menambahkan pesanan ID: ' + CAST(PesananID AS VARCHAR(10))
    FROM inserted;
END;


CREATE TRIGGER trg_UpdatePesanan
ON Pesanan
AFTER UPDATE
AS
BEGIN
    INSERT INTO LogAktivitas (NamaTabel, Aksi, Keterangan)
    SELECT
        'Pesanan',
        'UPDATE',
        'Mengubah pesanan ID: ' + CAST(PesananID AS VARCHAR(10))
    FROM inserted;
END;



CREATE TRIGGER trg_DeletePesanan
ON Pesanan
AFTER DELETE
AS
BEGIN
    INSERT INTO LogAktivitas (NamaTabel, Aksi, Keterangan)
    SELECT
        'Pesanan',
        'DELETE',
        'Menghapus pesanan ID: ' + CAST(PesananID AS VARCHAR(10))
    FROM deleted;
END;


