# Hastane Otomasyonu

Bu proje, bir hastanenin temel işleyişini (hasta kaydı, doktor kaydı, randevu alma ve listeleme) yönetmek amacıyla geliştirilmiş bir Windows Forms uygulamasıdır. Öğrenci ödevi seviyesinde, sade ve anlaşılır bir kod yapısına sahiptir.

## Kullanılan Teknolojiler
- **Dil:** C#
- **Platform:** Windows Forms (.NET)
- **Veritabanı:** SQL Server LocalDB
- **Veri Erişimi:** ADO.NET (System.Data.SqlClient)

## Özellikler
- **Hasta Yönetimi:** Hasta ekleme ve tüm hastaları listeleme.
- **Doktor Yönetimi:** Doktor ekleme ve tüm doktorları listeleme.
- **Randevu Sistemi:** Kayıtlı hastalar ve doktorlar arasından seçim yaparak randevu oluşturma.
- **Randevu Takibi:** Alınan randevuları detaylı (hasta adı, doktor adı, branş vb.) şekilde listeleme.
- **Otomatik Veritabanı Kurulumu:** Program ilk çalıştığında veritabanını ve tabloları otomatik olarak oluşturur.

## Ekran Görüntüleri
Projenin görsellerine aşağıdaki bağlantılardan ulaşabilirsiniz (Görsellerin `images` klasöründe olması beklenmektedir):

- Ana Form: ![Ana Form](images/anaform.png)
- Hasta Ekle: ![Hasta Ekle](images/hastaekle.png)
- Doktor Ekle: ![Doktor Ekle](images/doktorekle.png)
- Randevu Al: ![Randevu Al](images/randevual.png)
- Hasta Listele: ![Hasta Listele](images/hastalistele.png)
- Doktor Listele: ![Doktor Listele](images/doktorlistele.png)
- Randevu Listele: ![Randevu Listele](images/randevulistele.png)

## Kurulum ve Çalıştırma
Projeyi çalıştırmak için aşağıdaki adımları izleyebilirsiniz:

1. **Terminali açın.**
2. **Projeyi oluşturun veya dosyaları indirin.**
3. **Proje klasörüne gidin:**
   ```bash
   cd HastaneOtomasyonu
   ```
4. **Projeyi derleyin:**
   ```bash
   dotnet build
   ```
5. **Visual Studio ile açın:**
   `HastaneOtomasyonu.csproj` dosyasını Visual Studio ile açarak projeyi inceleyebilirsiniz.
6. **Çalıştırın:**
   Visual Studio üzerinden **Start (Başlat)** butonuna basarak uygulamayı çalıştırabilirsiniz.

## Kullanım Açıklaması
- Program açıldığında karşınıza 6 butonlu bir ana ekran gelir.
- Öncelikle **Hasta Ekle** ve **Doktor Ekle** bölümlerinden sisteme kayıt girmelisiniz.
- Kayıtlar tamamlandıktan sonra **Randevu Al** ekranından uygun hasta ve doktoru seçerek randevu oluşturabilirsiniz.
- **Listele** butonları ile sistemdeki tüm verileri tablo halinde görebilirsiniz.

İbrahim Can Yurtsev 