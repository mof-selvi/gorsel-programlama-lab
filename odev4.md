# MVC mimarisinde "işletmeler için ön-muhasebe" projesi


## Visual Studio üzerinde C# dilinde MVC mimarisini kullanarak basit bir ön-muhasebe uygulamasını aşağıdaki maddeleri dikkate alarak kodlayınız.

### Projenizi geliştirirken öğretim üyesi hocamızın hazırladığı [MVCExperiment.zip](MVCExperiment.zip) dosyasındaki projeden faydalanabilirsiniz.


## Senaryo

* Yazacağınız program bir toptancıya ait işletmedeki tek bir çalışan tarafından kullanılacak. Bu çalışan, işletmede masasında otururken siparişleri müşterilerden yüz yüze alıp sisteme girmektedir. (Dolayısıyla kullanıcı modeli/kaydı vs oluşturma gereği bulunmuyor.)
* Tüm sepet tamamlandıktan sonra programdaki arayüz, sisteme önceden girilmiş olan kampanyalara göre en uygun iskontoyu belirleyip nihai fiyatı ve indirim miktarını göstermelidir.
* Sistem, tüm kampanyaları incelemeli ve aralarından en yüksek indirimi sağlayan kampanyayı seçmelidir. Bir anda tek bir kampanyadan faydalanılabilir.


## Teknik Bilgiler

### Yazılacak program, "Ürün", "Sepet Ürünü" ve "Kampanya" isimlerinde toplam 3 adet modele sahip olmalı.

* Ürün modeli verileri: "Ürün ID'si, ürün ismi, ürün birim fiyatı, stok adedi"
* Sepet Ürünü modeli verileri: "Sepet ürünü ID'si, Ürün ID'si, adet"
* Kampanya: "Kampanya ID'si, minimum toplam sepet tutarı, iskonto yüzdesi"


### View için tek form kullanınız.
* "TabControl" ögesini formunuza ekleyerek her bir model için ayrı birer sekme oluşturunuz ve uygun UI ögeleriyle tasarımı tamamlayınız.
* Not: Normal koşullarda, projelerde model ve controller'lara göre uygun sayıda ayrı ayrı birim view'lar oluşturmak gerekir. Birden fazla view aynı ekranda kullanılacaksa, MVC framework'lerinin özelliklerinden faydalanılarak view'lar birleştirilir. Bu projede, kolaylık sağlamak amacıyla, tek view kullanımı serbesttir.


## Bonus

* Kampanya modelinin yapısını ürün ID'si ile 1:N ilişkili olacak şekilde değiştiriniz (1 üründe N kampanya).
* Kampanyalar ürünlere özel olarak girilmeli ve bir ürün için birden fazla kampanya olabilmeli.
* Bu yapıda sepet tutarına bakmak yerine seçili ürünlerden kaç adet alındığına bakılmalıdır. Örn: X ürününden 5 adet alımda %5, 10 adet alımda %7, 15 adet alımda %10 indirim sepetin son tutarına uygulanmalıdır.

