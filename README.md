## HMA Tarımsal Borsa Uygulaması
### Celal Bayar Üniversitesi 2. Sınıf Yazılım Yapımı Dersi Ödevi

#### Kullanıcı Tarafı

##### İlk Ekran:
  Bu ekranda sisteme kayıt olma ve giriş yapma işlemleri için yönlendirmeleri bulunur.
  ![image](https://user-images.githubusercontent.com/61211736/118716581-a8cd5480-b82d-11eb-9c6b-e0030636f38d.png)

##### Kayıt Olma:
  Kayıt ol butonuna tıkladıktan sonra kayıt olma penceresi açılır. Kayıt olma penceresinde gerekli alanları doldurduktan sonra kayıt işlemimiz tamamlanır.
  Kayıt olmak için tüm alanları eksiksiz ve kurallı olarak doldurmanız gerekmektedir.

##### Giriş Yapma:
  Karşılama ekranından “Giriş” butonuna tıkladığımızda “Giriş Yapma” penceresi açılır. Kayıt olurken kullandığımız kullanıcı adı ve parola bilgimiz ile sisteme giriş yapabiliriz.

##### Uygulama Ekranı:
  Sisteme giriş yapıldıktan sonra uygulama ekranına geçiş yaparız. Uygulama ekranında bizi sistemde aktif satışta olan ürünlerin alfabetik sıraya göre listesini görürüz. Burada sistemdeki ürünlerin isimleri, toplam miktarı ve birim başına en düşük fiyatları (EDF) görülür.
  ![image](https://user-images.githubusercontent.com/61211736/118717025-2f823180-b82e-11eb-85b7-e5c96345a8b3.png)

##### Aktif Ürün Satışları Görme:
  Uygulama ana ekranında kategorilere göre ayrılmış ürünlerden herhangi birine tıkladığımızda ilgili ürünün fiyat ve tarihe göre sıralanmış aktif pazarlarını görürüz.
  ![image](https://user-images.githubusercontent.com/61211736/118717122-4de82d00-b82e-11eb-911d-85c0051edbe5.png)

##### Bakiye İşlemleri
  Bakiye işlemlerini yönetmek için uygulamamızda üst bölümde yer alan ***“Bakiye İşlem”*** butonuna tıklamamız veya bakiyemize tıklamamız yeterlidir.
  ![image](https://user-images.githubusercontent.com/61211736/118717291-8daf1480-b82e-11eb-9e91-daa0262dcfc5.png)

##### Bakiye İşlem Ekranı
  Bakiye Ekleme ve Çekme taleplerimizi sisteme bu ekrandan iletiriz. Ayrıca geçmiş işlemlerimizi ve onaylanmayı bekleyen işlemlerimizi de bu penceredeki butonları kullanarak görüntüleyebiliriz.
  ![image](https://user-images.githubusercontent.com/61211736/118717389-added380-b82e-11eb-9418-a6eff35434da.png)

> **Not:** Bakiye Ekleme ve Çıkarma işlemleri yönetici onayına tabidir. Anlık gerçekleşmez. 
> Yöneticinin giriş bilgileri ise şu şekildedir. Kullanıcı Adı: admin ; Parola: 123

#### Sahip Olduğum Pazarlar ve Sistemde Ürün satma 
  Bu ekranda sistemde satmak istediğiniz ürünlerinizi yayınlar ve yayından kaldırırsınız. Sisteme ürün eklemek yönetici onayına tabii-iken satıştan ürün kaldırmak kullanıcının inisiyatifindedir, yönetici onayı gerektirmez

##### Sistemde Ürün Satma:
  Sisteme yeni ürün eklemek için ***“Sahip olduğum pazarlar”*** ekranında ***“pazara ürün ekle”*** butonuna tıklanır. Butona tıkladıktan sonra karşımıza ürün ekleme penceresi çıkar. Buradan ürünümüzü seçip, miktar ve fiyat bilgisini girdikten sonra ***“ONAYLA”*** butonuna tıklanır.Yönetici incelemesine tabi tutulduktan sonra ürünümüz sistemde satışa çıkar.
  ![image](https://user-images.githubusercontent.com/61211736/118717957-61e05e80-b82f-11eb-8881-7e0fa39da1ed.png)
  ![image](https://user-images.githubusercontent.com/61211736/118718341-c996a980-b82f-11eb-813b-a05c77b9b6f8.png)


> Sisteme eklenmesi talep edilen ürünleri sisteme eklenmesini yöneticiler onaylar. Sistemde halihazırda tanımlanmış olan yönetici hesabına girip onay bekleyen talepleri onaylayabilirsiniz. 
> Kullanıcı Adı: **admin** ; Parola: **123**
> ![image](https://user-images.githubusercontent.com/61211736/118718271-b5eb4300-b82f-11eb-822b-8c0883783eb3.png)

##### Alış Emri
  Alış emri verebilmek için üst menüde yer alan ***“Alış Emri”*** butonuna tıklanır. Açılan pencerede emrin uygulanacağı ürünü seçip, alış miktarını girdikten sonra sistem alıcıya ne kadar ürün alabileceğini ve bunun maliyetini iletir. Alıcı işlemi onaylarsa alış gerçekleşir. 
  > [ONCE] ![image](https://user-images.githubusercontent.com/61211736/118718437-e6cb7800-b82f-11eb-8eb6-cae44016ed56.png)
  > [SONRA] ![image](https://user-images.githubusercontent.com/61211736/118718500-fc40a200-b82f-11eb-8312-37ccd4a42af6.png)


> ##### Bilgi: 
> _Alış işlemi gerçekleşirken kullanıcıya kendi ürünleri satılmaz. Alış işlemi sistemdeki 
diğer satıcıların sattığı ürünlerde en düşükten başlayarak istenilen miktarda ürün satın alınarak 
para anlık olarak alıcının bakiyesinden düşer ve satıcılara aktarılır_


Youtube: https://www.youtube.com/watch?v=TCP_EYiEdEE


> **Eğitim Görevlisi**
> _Dr. Emin BORANDAĞ_

> **Geliştiriciler**
> _Alper ÜLGER – 182805003 (İ.Ö.)_
> _Muratcan ŞEN – 182805011 (İ.Ö.)_
> _Yakup Hamit HANCI – 182805013 (İ.Ö.)_













