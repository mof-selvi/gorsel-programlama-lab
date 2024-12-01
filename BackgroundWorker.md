# BackgroundWorker Alıştırması

- Aşağıdaki bileşenlerden oluşan bir arayüz oluşturunuz:
  - Sadece sayma sayısı kabul eden bir giriş
  - Bir liste kutusu (listbox)
  - 2 buton
  - İlerleme çubuğu (progress bar)

- Uygulamanızın iki butonundan birinde `Başla` diğerinde `Bekle` yazmalıdır.
- `Başla` butonuna basıldığında aşağıda açıklanan işlem başlamalı veya kaldığı yerden devam etmeli, `Bekle` butonuna basıldığında işlem duraklatılmalı.
- İşlem devam ettiği sürece ilerleme çubuğu dolmalıdır. İlerleme çubuğu için minimum değer 0, maksimum değer 100 olmalıdır.

- Uygulamanız işleme devam etme durumundayken, sayma sayısı girdisi ile belirtilen adede kadar rastgele sayı üretmelidir.
  - Her üretilen yeni sayı liste kutusuna thread-safe olarak eklenmelidir. Bunun için BackgroundWorker bileşeni kullanınız.
  - Her sayı üretimi sonrasında programınız yaklaşık yarım saniye beklemelidir. Fakat bu işlemlerin hiçbiri kullanıcının arayüzü kullanımını engellememelidir.

---

Yardımcı kaynak: [Görsel Programlama - BackgroundWorker - Threads.pdf](Görsel%20Programlama%20-%20BackgroundWorker%20-%20Threads.pdf)

---

  ## Bonus:
  - Tüm işlem bittiğinde, ilerleme çubuğunun rengi mor olacak şekilde değişmelidir.
    > Not: progress bar'larda ForeColor düzenlemesi ile renk değişimi seçtiğiniz framework/core versiyonuna bağlı olarak çalışmayabilir.
    > Programınızdaki `Application.EnableVisualStyles();` satırını kapatmayı deneyebilirsiniz veya kendi progress bar'ınızı var olan sınıftan kalıtım alarak implement edebilirsiniz.
