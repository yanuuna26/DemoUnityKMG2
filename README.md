# Kredensial Mikro Guru - H1
Senin, 10 Nov 2025

Asset:
3D mest > .fbx
Audio > .wav, .mp3, .ogg
Image > .bmp, .tif, .jpg, .psd
Font > .ttf, .otf

Scene
Dimensi atau environtment di game dalam unity

Component
Modular piece of functional yang dapat di attached to gameObject untuk define behavior or properties

Build
Proses compiling and packaging game project

Type data dan Variable
Mirip dengan lainya
Ada type data Vector
Vector3 > x, y, z
Vector2 > x, y

# Kredensial Mikro Guru - H2
Selasa, 11 Nov 2025

SerializedField
atribut yang digunakan untuk menampilkan variabel private di Inspector, agar bisa diatur lewat editor tanpa harus menjadikannya public.
Tidak bisa dipakai di variabel lokal atau method
[SerializeField] hanya untuk field (variabel di luar method), bukan di dalam fungsi.


Array > Statis
List > DInamis

Langkah-langkah Membuat Bola Memantul di Tanah (Unity 2D)
🟢 1. Buat Proyek 2D
1. Buka Unity Hub → New Project → 2D (URP optional).
2. Kasih nama misalnya: BolaMemantul2D.

⚪ 2. Buat Objek Bola
1. Di Hierarchy → Right click → 2D Object → Sprite → Circle.
2. Ganti nama jadi "Bola".
3. (Opsional) Ubah warna bola di Sprite Renderer → Color.

🟤 3. Tambahkan Komponen Fisika ke Bola
Agar bisa jatuh & memantul otomatis:
1. Pilih Bola di Hierarchy.
2. Klik Add Component → Rigidbody 2D, Rigidbody biar jadi gravitasi
    * Pastikan:
        * Gravity Scale = 1 (supaya jatuh ke bawah).
        * Mass = 1 (standar).
3. Klik Add Component → Circle Collider 2D (untuk collider-nya).

🟫 4. Buat Tanah
1. Hierarchy → Right click → 2D Object → Sprite → Square.
2. Ganti nama jadi "Tanah".
3. Atur posisinya di bawah bola (misal posisi Y = -3).
4. Atur scale X lebarnya (misal Scale X = 10, Y = 1).
5. Tambahkan Box Collider 2D ke Tanah:
    * Klik Add Component → Box Collider 2D.
    * Tidak perlu Rigidbody (biarkan statis agar jadi “lantai”).

⚙️ 5. Tambahkan Physics Material 2D untuk Efek Pantulan
Supaya bola benar-benar memantul, bukan cuma berhenti di tanah.
1. Di Project Window, klik kanan → Create → Physics 2D Material.
2. Ganti nama jadi “Pantul”.
3. Di Inspector:
    * Bounciness = 1 (maksimal pantulan).
    * Friction = 0 (supaya tidak lengket).
4. Drag & drop material “Pantul” ke:
    * Komponen Circle Collider 2D milik Bola.

🔵 6. Coba Jalankan (Play)
Tekan tombol ▶️ Play di atas. Hasilnya:
* Bola akan jatuh ke bawah karena gravitasi.
* Saat menyentuh tanah, bola akan memantul naik.

Ada dua properti penting di Physics Material 2D:
1. Friction (Gesekan)
    * Menentukan seberapa licin atau kesat suatu permukaan.
    * Nilai 0 = sangat licin (seperti es).
    * Nilai 1 atau lebih = sangat kesat (menahan gerak saat bersentuhan).
2. 💡 Contoh: bola berhenti cepat di tanah = friction tinggi.
3. Bounciness (Pantulan)
    * Menentukan seberapa kuat objek memantul setelah bertumbukan.
    * Nilai 0 = tidak memantul sama sekali.
    * Nilai 1 = pantulan sempurna (seperti bola karet).
    * Nilai >1 bisa menyebabkan pantulan berlebihan (jarang dipakai).
4. 💡 Contoh: bola basket memantul di lantai → bounciness sekitar 0.8.

<img width="551" height="133" alt="Screenshot 2025-11-14 at 08 47 39" src="https://github.com/user-attachments/assets/7a5c7bfa-1031-49d5-8526-f4bb4a13069a" />

