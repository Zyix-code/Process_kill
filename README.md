# ⚡ ProcessKiller – Hızlı İşlem Sonlandırma Aracı

<p align="center">
  <img src="https://media.giphy.com/media/Y4ak9Ki2GZCbJxAnJD/giphy.gif" width="150px">
</p>

<p align="center">
  <b>Yanıt vermeyen veya istenmeyen uygulamaları adıyla bulup anında sonlandıran sistem aracı.</b><br>
  Görev yöneticisiyle uğraşmadan, hızlı ve etkili çözüm sunar.
</p>

---

## 🚀 Özellikler

- ✔ **İsimle Hedefleme:** Sonlandırmak istediğiniz uygulamanın adını (örn: `chrome`) girerek işlem yapma.
- ✔ **Otomatik Tarama:** Girilen isme ait çalışan tüm işlemleri (Process ID) arka planda tespit etme.
- ✔ **Zorla Durdurma:** Yanıt vermeyen uygulamaları `Kill` komutu ile anında kapatma.
- ✔ **Geri Bildirim:** İşlem başarısız olduğunda veya uygulama bulunamadığında kullanıcıyı bilgilendirme.

<p align="center">
  <img src="https://img.shields.io/badge/Language-C%23-239120?logo=c-sharp&logoColor=white&style=flat-square">
  <img src="https://img.shields.io/badge/.NET-Framework-512BD4?logo=dotnet&logoColor=white&style=flat-square">
  <img src="https://img.shields.io/badge/Platform-Windows-0078D6?logo=windows&logoColor=white&style=flat-square">
  <img src="https://img.shields.io/badge/License-GPLv3-blue.svg?style=flat-square">
</p>

---

## 🧠 Sistem Nasıl Çalışır?

Uygulama, temel olarak Windows işlem listesi üzerinde çalışır ve aşağıdaki adımları izler:

### 1️⃣ Veri Girişi
- Kullanıcı, kapatmak istediği uygulamanın işlemsel adını (Process Name) arayüze girer.

### 2️⃣ Tarama ve Tespit (Discovery)
- Program, işletim sistemindeki tüm aktif işlemleri tarar.
- Girilen isimle eşleşen (örn: `Notepad` -> `notepad.exe`) tüm işlemler listelenir.

### 3️⃣ Sonlandırma (Termination)
- Eşleşen işlemler bulunduğunda, sistem bu işlemlere sonlandırma sinyali gönderir ve bellekten temizler.

---

## 🛠️ Geliştirme ve Özelleştirme

Bu proje açık kaynaklı bir temel yapıdır. İhtiyaçlarınıza göre aşağıdaki alanları geliştirebilirsiniz:

### 🔧 Hata Yönetimi (Error Handling)
- [ ] Uygulama bulunamadığında gösterilecek özel mesajlar.
- [ ] Yönetici izni gerektiren sistem işlemlerini (System Processes) filtreleme veya engelleme.

### 🎨 Kullanıcı Arayüzü (UI/UX)
- [ ] İşlem listesi (Task List) görüntüleme özelliği ekleme.
- [ ] Modern ve şeffaf bir arayüz tasarımı (WPF veya WinForms).

---

## ⚖️ Lisans
Bu proje **GNU General Public License v3.0** ile lisanslanmıştır.
Projenin tüm kullanıcıları, lisansın koşullarına uymak kaydıyla projeyi özgürce kullanabilir, değiştirebilir ve paylaşabilir.

---

## 🤝 İletişim

<p align="left">
  <a href="https://discordapp.com/users/481831692399673375"><img src="https://img.shields.io/badge/Discord-Zyix%231002-7289DA?logo=discord&style=flat-square"></a>
  <a href="https://www.youtube.com/channel/UC7uBi3y2HOCLde5MYWECynQ?view_as=subscriber"><img src="https://img.shields.io/badge/YouTube-Subscribe-red?logo=youtube&style=flat-square"></a>
  <a href="https://www.reddit.com/user/_Zyix"><img src="https://img.shields.io/badge/Reddit-Profile-orange?logo=reddit&style=flat-square"></a>
  <a href="https://open.spotify.com/user/07288iyoa19459y599jutdex6"><img src="https://img.shields.io/badge/Spotify-Follow-green?logo=spotify&style=flat-square"></a>
</p>
