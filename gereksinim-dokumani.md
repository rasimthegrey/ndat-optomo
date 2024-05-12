# Gereksinim Dokümanı
---
## Fonksiyonel Gereksinimler
---
## Fonksiyonel Olmayan Gereksinimler

### Ürün Gereksinimleri
- **Kullanılabilirlik Gereksinimleri**
    - Sistem arayüz elemanları, kullanıcının kolayca okuyup, menüleri birbirinden ayırt edebileceği şekilde tasarlanmış olmalıdır.
    - Sistem arayüzünde bulunan buton ve menüler beklenen işlev ve çıktıları karşılamalıdır.
    - Kullanıcı, 2 boyutlu görselleri sırasıyla görüntüleyebilmeli ve  3 boyutlu görselleri açısal olarak görüntüleyebilmelidir.
- **Performans Gereksinimleri**
- **Güvenilirlik Gereksinimleri** 
- **Güvenlik Gereksinimleri**

### Organizasyonel Gereksinimler
- **Geliştirme Gereksinimleri**

### Dış Gereksinimler
- **Yasal Gereksinimler**

---

# Kullanım Durumları

- **Kullanıcı Giriş-Çıkış**
    ```
    UC1: Giriş Yapma
    Birincil Aktör: Doktor
    Ön Koşul: Doktorun sisteme kayıtlı olması.
    Son Koşul: Doktor Uygulamanın ana sayfasına başarılı bir şekilde giriş yapmış olmalı.
    Ana Başarı Senaryosu:
    1- Kullanıcı sistem tarafından atanan kullanıcı adı ve şifre ile sisteme giriş isteği gönderir.
    2- Sistem ana sayfayı görüntüler.
    ```

    ```
    UC2: Çıkış Yapma
    Birincil Aktör: Doktor
    Ön Koşul: Doktorun sisteme giriş yapmış olmalı.
    Son Koşul: Doktor başarılı bir şekilde uygulamadan giriş ekranına yönlendirilmeli.
    Ana Başarı Senaryosu:
    1-Kullanıcı sisteme çıkış yapma isteği gönderir.
    2-Sistem kullanıcıya giriş ekranını görüntüler ve işlem sonlanır.
    ```

- **Cihaz Bağlantısı**
    ```
    UC3: Bağlantı Kurma
    Birincil Aktör: Doktor
    Ön Koşul: Doktorun sisteme giriş yapmış olmalı.
    Son Koşul: Doktor cihazın port bağlanıtısını başarıyla gerçekleştirmeli.
    Ana Başarı Senaryosu:
    1- Doktor sisteme e-bağlantı isteği gönderir.
    2- Sistem e-bağlantı sayfasını görüntüler.
    3- Doktor bağlantı tipini seçme isteği gönderir.
    4- Sistem aktif bağlantı tiplerini görüntüler.
    5- Doktor bağlantı tipini seçer, port numarasını girer ve bağlantı isteği gönderir. 
    Alternatif Senaryolar:
    4a Bağlantı tipi bulunamadı.
        1a Doktor bağlantıları denetler ve adımı tekrarlar.
    5a Geçersiz port numarası.
        1a Sistem seçilen bağlantı tipinde portun kullanılabilir olmadığına dair ekranı görüntüler ve 2.adıma yönlendirir.
        1b Sistem girilen port numarasının aktif olmadığını gösteren ekranı görüntüler ve 2.adıma yönlendirir.
    5b Port zaten kullanımda
        1.kullanımda hata ekranı görüntülenir ve 2.adım tekrarlanır.
    ///
    özel gereksinimler:
        bağlantılı fonksiyonel olmayan gereksinimler
    teknoloji ve veri tipleri listesi:
        veri tipleri ve i/o methodları
    ///
    ```

- **Cihaz Testi**
    ```
    UC4: X-Ray Görüntü Testi
    Birincil Aktör: Doktor
    Ön Koşul: Devam eden bir bağlantı kurma işlemi olmalı.
    Son Koşul: Cihaz başarıyla xray testini sonlandırmalı.
    Ana Başarı Senaryosu:
    1- Doktor sisteme optomo cihaz testine giriş isteği gönderir.
    2- Sistem test arayüzünü görüntüler.
    3- Doktor xray test isteği gönderir.
    4- Sistem xray cihazına isteği gönderir.
    Alternatif Senaryolar:
    *a Bağlantı sorunu
        1. Sistem çalışmayı durdurur, bağlantı hatası ekranını görüntüler ve e-bağlantı sayfasına yönlendirir.
    ```
    ```
    UC5 : Yatay Hareket Testi
    Birincil Aktör: Doktor
    Ön Koşul: Devam eden bir bağlantı kurma işlemi olmalı.
    Son Koşul: Test işlemi başarılı sonlanmalıdır.
    Ana Başarı Senaryosu:
    1- Doktor sisteme optomo cihaz testine giriş isteği gönderir.
    2- Sistem test arayüzünü görüntüler.
    3- Doktor mesafe değerini girer ve yön seçer.
    4- Sistem mesafe ve yön bilgisini cihaza gönderir.
    Alternatif Senaryolar:
    *a Bağlantı sorunu
        1. Sistem çalışmayı durdurur, bağlantı hatası ekranını görüntüler ve e-bağlantı sayfasına yönlendirir.
    3a Girilen değer uygun formatta değil.
        1- Hata mesajı gönderilir ve yeni değer beklenir.
    3b Girilen değer uygun olmayan aralıkta.
        1- Hata mesajı gönderilir ve yeni değer beklenir.
    ```
    ```
    UC6: Açısal Tarama Testi
    Birincil Aktör: Doktor
    Ön Koşul: Devam eden bir bağlantı kurma işlemi olmalı.
    Son Koşul: Test işlemi başarılı sonlanmalıdır.
    Ana Başarı Senaryosu:
    1- Doktor sisteme optomo cihaz testine giriş isteği gönderir.
    2- Sistem test arayüzünü görüntüler.
    3- Doktor tarama açısı ve atış sayısını girerek açısal tarama testi işlemi başlatır.
    4- Sistem açı ve atış değerlerini cihaza gönderir.
    Alternatif Senaryolar:
    *a Bağlantı sorunu
        1. Sistem çalışmayı durdurur, bağlantı hatası ekranını görüntüler ve e-bağlantı sayfasına yönlendirir.
    3a Girilen değer uygun formatta değil.
        1- Hata mesajı gönderilir ve yeni değer beklenir.
    3b Girilen değer uygun olmayan aralıkta.
        1- Hata mesajı gönderilir ve yeni değer beklenir.

    ```
- **Bekleyen Hasta Görüntüleme**
    ```
    UC7: Bekleyen Hasta Görüntüleme
    Brinicil Aktör: Doktor
    Ön Koşul: Hastalar ve doktor sisteme kayıtlı olmalıdır ve Devam eden bir bağlantı kurma işlemi olmalı.
    Son Koşul: Hastalar sırayla başarılı bir şekilde görüntülenmeli.
    Ana Başarı Senaryosu:
    1- Doktor bekleyen hasta görüntüleme isteği yollar.
    2- Sistem bekleyen hastaları görüntüler.
    ```
    ```
    UC8: Bekleyen hasta Seçme
    Birincil Aktör: Doktor
    Ön Koşul: Devam eden bir hasta görüntüleme işlemi olmalıdır.
    Son Koşul: Hasta görüntü alma sayfası doğru bir şekilde görüntülenmeli.
    Ana başarı senaryosu:
    1- Doktor bekleyen hastayı seçerek görüntü alma isteği gönderir.
    2- Sistem Hastanın bilgilerini ve sayfayı görüntüler.
    Alternatif Senaryolar:
    *a Bağlantı sorunu.
        1. Sistem çalışmayı durdurur, bağlantı hatası ekranını görüntüler ve e-bağlantı sayfasına yönlendirir.
    1a Hasta bulunamadı.
        1- Hastanın kimliğinin bulunamaması durumunda manuel olarak ıd ile de hasta seçilebilmeli.

- **Görüntü Toplama**
    ```
    UC9: 2D ve 3D Görüntü Toplama
    Birincil Aktör: Doktor
    Ön Koşul: Bekleyen hasta işlemi tamamlanmış olmalıdır.
    Son Koşul: Sistem girilen değerlerdeki görüntüleri hastaya ilişkilendirmiş olmalıdır.
    Ana Başarı Senaryosu:
    1- Doktor açı ve atış sayısını girerek sisteme görüntü çekme isteği gönderir.
    2- Sistem değerleri cihaza gönderir.
    3- Sistem cihazdan gelen görüntüleri görüntüler.
    4- Doktor görüntü kayıt isteği gönderir.
    5- Sistem görüntüleri hastayla ilişkilendirir ve kaydeder.
    Alternatif Senaryoları:
    *a Bağlantı sorunu
        1. Sistem çalışmayı durdurur, bağlantı hatası ekranını görüntüler ve e-bağlantı sayfasına yönlendirir.
    1a Girilen değer uygun formatta değil.
        1- Hata mesajı gönderilir ve yeni değer beklenir.
    1b Girilen değer uygun olmayan aralıkta.
        1- Hata mesajı gönderilir ve yeni değer beklenir.
    4a görüntü toplama hatası
        1- Sistem hata mesajı gönderir ve cihaza tekrar istek gönderir.
    ```
- **Hasta Sonucu Görüntüleme**
    ```
    UC10: Kayıtlı Hasta Görüntüleme
    Birincil Aktör: Doktor
    Ön Koşul: Hasta sisteme kayıtlı olmalıdır.
    Son Koşul: Hasta bilgileri doğru görüntülenmelidir.
    Ana Başarı Senaryosu: 
    1- Doktor kayıtlı hasta görüntüleme isteği gönderir.
    2- Sistem kayıtlı hastaları görüntüler.
    3- Doktor kayıtlı hastayı seçer.
    4- Sistem hastanın bilgilerini görüntüler.
    
- Olası Hatalar
    - Motor arızası
    - Elektrik kesintisi
    - Donanım arızası
    - Bağlantı arızası