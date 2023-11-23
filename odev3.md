# Bir sayının asal olup olmadığının kontrolünü yapan bir programı arayüzünü hazırlayarak yazınız.

* Arayüz ekranınızda sadece bir metin girdi (TextBox) ve bir metin çıktı (Label) alanı olmalı. Buton koymayınız.

* TextBox'a bir sayı girildikten sonra kullanıcı "Enter" tuşuna bastığında kontrol işlemi başlamalı ve sayının asallık durumu Label metninde bir cümle ile belirtilmeli.

* "Enter" tuşu tespiti için "KeyPress" veya "KeyDown" gibi bir event oluşturunuz. Event fonksiyonunuz içerisinde aşağıdaki gibi bir kontrol kullanabilirsiniz:
```
if (e.KeyChar == (char)Keys.Return)
{
  
}
```

* Programınız standart haliyle çalışır hale geldikten sonra büyük sayıları deneyiniz. İşlem bitene kadar arayüzün donup donmadığına dikkat ediniz.

* Donmalar -varsa- muhtemel çözümleri düşünüp uygun birini implement etmeyi deneyiniz.

  
