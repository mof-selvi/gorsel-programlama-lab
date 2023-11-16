# Aşağıdaki görseldeki gibi bir Piyano arayüzünü oluşturunuz.

![Piano1](https://github.com/mof-selvi/gorsel-programlama-lab/assets/58203457/f251b0b7-af2a-410c-ae86-fae4e0e7f8af)

* Sadece sağ-sol butonları sürükle-bırak ile oluşturulabilir. Piyano tuşları tamamen kodlarla oluşturulmalı.

* Kod buton oluşturmak için aşağıdaki örnekten faydalanabilirsiniz (Form nesnesinden kalıtım alan sınıf içerisinde kullanılabilir):
```
Button button = new Button();
button.Text = "Buton metni";
button.Location = new Point(10, 10);
button.Size = new Size(30, 30);
button.BackColor = Color.Turquoise;
button.ForeColor = Color.Black;
button.Visible = true;
button.BringToFront();
this.Controls.Add(button);
```

* Siyah tuşların sayısına ve beyaz tuşlara göre konumlarına dikkat ediniz.

* Tuşları kendi renkleri içerisinde numaralandırınız.

* Aynı renk tuşlar birbiri üzerine binmemelidir.

* Üstteki iki yön butonu ile piyano tuşları sağa-sola kaydırılabilmelidir.

  ![Piano2](https://github.com/mof-selvi/gorsel-programlama-lab/assets/58203457/aeb976cf-6a8d-4a6e-8813-91c3a8d7f9a6)


* Form pencereniz yeniden boyutlandırılabilir olmamalıdır! Pencerenizin sabit boyutta kalması için gerekli ayarları araştırınız.

---

# Bonus

* Butonlara basıldığında çalınacak notayı A-F aralığında konsola çıktılayınız. İlk oluşturduğunuz butonu, 1. oktavın Do notası olarak kabul ediniz.

* İlk Do notasının konsoldaki çıktısı şöyle olmalıdır:
```
C0
```

* "3. oktav Fa-diyez" notasının çıktısı:
```
F#2
```



