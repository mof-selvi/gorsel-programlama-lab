## Main() metodunuzun bulunduğu sınıfa aşağıdaki fonksiyonları ekleyin:

```
private static void SetTimer()
{
    aTimer = new System.Timers.Timer(1000);
    aTimer.Elapsed += OnTimedEvent;
    aTimer.AutoReset = true;
    aTimer.Enabled = true;
}

private static void OnTimedEvent(Object source, ElapsedEventArgs e)
{
    System.Diagnostics.Debug.WriteLine("Tetiklenme zamanı: {0:HH:mm:ss.fff}",e.SignalTime);
}
```

## Aynı sınıfta global scope'ta bir Timer nesnesi tanımlayın:

```
private static System.Timers.Timer aTimer;
```

## Main() metodunuzda SetTimer() fonksiyonunu çağırın:


```
static void Main()
{
    SetTimer();

    //...
}
```

## Programı çalıştırdığınızda her saniye konsola güncel tarih çıktılanacaktır.

### Bu sistemi kullanarak bir alarm programı yazınız. UI nesneleri ile Timer etkileşimi için çözüm tavsiyelerinde bulununuz.
