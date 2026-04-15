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