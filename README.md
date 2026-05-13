# 🍰 KueTradisional

## Skenario SQL Injection

Pada aplikasi ini terdapat simulasi SQL Injection pada form data kue. Simulasi dilakukan melalui textbox pencarian kue dan tombol Test Injection.

Input yang digunakan:

```sql
' OR 1=1 --

Query tidak aman yang digunakan:
UPDATE Kue SET NamaKue = 'HACKED' WHERE NamaKue = '' OR 1=1 --'
Dampaknya, seluruh data pada kolom NamaKue berubah menjadi HACKED karena kondisi OR 1=1 selalu bernilai benar.

## Cara Reset Data

Setelah melakukan simulasi SQL Injection, data kue dapat dikembalikan menggunakan tombol Reset Data.

Sebelumnya dibuat tabel backup dengan query:

```sql
SELECT * INTO Kue_Backup
FROM Kue;

Query reset:
DELETE FROM Kue;

INSERT INTO Kue
SELECT * FROM Kue_Backup;
Dengan cara ini, data kue yang berubah akibat simulasi SQL Injection dapat dikembalikan seperti semula.

## 📸 Screenshot Aplikasi

<img src="Pictures/Screenshot 2026-04-15 122855.png" width="100%"/>

<img src="Pictures/Screenshot 2026-04-15 122908.png" width="100%"/>

<img src="Pictures/Screenshot 2026-04-15 122925.png" width="100%"/>

<img src="Pictures/Screenshot 2026-04-15 122952.png" width="100%"/>

<img src="Pictures/Screenshot 2026-04-15 123013.png" width="100%"/>

<img src="Pictures/Screenshot 2026-04-15 123045.png" width="100%"/>

<img src="Pictures/Screenshot 2026-04-15 123102.png" width="100%"/>

<img src="Pictures/Screenshot 2026-04-15 123113.png" width="100%"/>

<img src="Pictures/Screenshot 2026-04-15 123127.png" width="100%"/>

<img src="Pictures/Screenshot 2026-04-15 123142.png" width="100%"/>

<img src="Pictures/Screenshot 2026-04-15 123157.png" width="100%"/>

<img src="Pictures/Screenshot 2026-04-15 123223.png" width="100%"/>

<img src="Pictures/Screenshot 2026-04-15 123256.png" width="100%"/>

<img src="Pictures/Screenshot 2026-04-15 123334.png" width="100%"/>

<img src="Pictures/Screenshot 2026-04-15 123519.png" width="100%"/>
