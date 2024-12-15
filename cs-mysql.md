# C# & MySQL Bağlantı ve CRUD İşlemleri

## Uygulama #1
- Bir depoda bulunan ürünlerin isimlerini, ID numaralarını ve miktarlarını tutan bir sistem geliştirmeniz beklenmektedir.
- Form arayüzünüz, yeni ürün bilgilerini kaydetmeye ve kayıtlı ürünleri listelemeye uygun olacak şekilde herhangi bir yöntem ile tasarlanabilir.
- Uygulamanız sadece bir defa MySQL bağlantısı oluşturmalı ve kapanana kadar bu bağlantı üzerinden CRUD işlemleri yapabilmelidir.
- Veritabanı olarak lab cihazlarımızda bulunan Xampp dizinindeki MySQL kurulumunu kullanınız.

---


C# ile bir form uygulamasında MySQL'e bağlanmak ve CRUD (Create, Read, Update, Delete) işlemleri yapmak için aşağıdaki yönergeleri takip edebilirsiniz.

---

### **1. Gerekli NuGet Paketini Yükleme**
- `MySql.Data` NuGet paketini yükleyin:
  - Visual Studio'da **Tools > NuGet Package Manager > Manage NuGet Packages for Solution** yolunu izleyin.
  - **Browse** sekmesinde `MySql.Data` paketini arayın ve yükleyin.

---

### **2. MySQL Bağlantısı ve CRUD İşlemleri İçin Temel Kodlar**

Aşağıda, bir MySQL veritabanına bağlanıp CRUD işlemleri gerçekleştiren bir örnek kod bulunmaktadır:

#### **Bağlantı Stringi ve MySqlConnection**
```csharp
using MySql.Data.MySqlClient;

string connectionString = "Server=localhost;Database=ornek_db;Uid=kullanici_adi;Pwd=sifre;";
MySqlConnection connection = new MySqlConnection(connectionString);

try
{
    connection.Open();
    MessageBox.Show("Bağlantı başarılı!");
}
catch (Exception ex)
{
    MessageBox.Show($"Bağlantı hatası: {ex.Message}");
}
finally
{
    connection.Close();
}
```

---

### **3. CRUD İşlemleri**

#### **Create (Ekleme)**
```csharp
string insertQuery = "INSERT INTO tablo_adi (kolon1, kolon2) VALUES (@deger1, @deger2)";
using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
{
    command.Parameters.AddWithValue("@deger1", "veri1");
    command.Parameters.AddWithValue("@deger2", "veri2");

    try
    {
        connection.Open();
        int rowsAffected = command.ExecuteNonQuery();
        MessageBox.Show($"{rowsAffected} kayıt eklendi.");
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Hata: {ex.Message}");
    }
    finally
    {
        connection.Close();
    }
}
```

#### **Read (Okuma)**
```csharp
string selectQuery = "SELECT * FROM tablo_adi";
using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
{
    try
    {
        connection.Open();
        using (MySqlDataReader reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                Console.WriteLine($"Kolon1: {reader["kolon1"]}, Kolon2: {reader["kolon2"]}");
            }
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Hata: {ex.Message}");
    }
    finally
    {
        connection.Close();
    }
}
```

#### **Update (Güncelleme)**
```csharp
string updateQuery = "UPDATE tablo_adi SET kolon1 = @yeniDeger WHERE id = @id";
using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
{
    command.Parameters.AddWithValue("@yeniDeger", "güncellenmiş_veri");
    command.Parameters.AddWithValue("@id", 1);

    try
    {
        connection.Open();
        int rowsAffected = command.ExecuteNonQuery();
        MessageBox.Show($"{rowsAffected} kayıt güncellendi.");
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Hata: {ex.Message}");
    }
    finally
    {
        connection.Close();
    }
}
```

#### **Delete (Silme)**
```csharp
string deleteQuery = "DELETE FROM tablo_adi WHERE id = @id";
using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
{
    command.Parameters.AddWithValue("@id", 1);

    try
    {
        connection.Open();
        int rowsAffected = command.ExecuteNonQuery();
        MessageBox.Show($"{rowsAffected} kayıt silindi.");
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Hata: {ex.Message}");
    }
    finally
    {
        connection.Close();
    }
}
```

---

### **4. Form Elemanları ile Entegrasyon**
Formdaki **TextBox**, **DataGridView** veya diğer bileşenler ile CRUD işlemlerini birleştirebilirsiniz.

#### **Örnek: DataGridView ile Veri Listeleme**
```csharp
string selectQuery = "SELECT * FROM tablo_adi";
DataTable dataTable = new DataTable();

using (MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection))
{
    try
    {
        adapter.Fill(dataTable);
        dataGridView1.DataSource = dataTable;
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Hata: {ex.Message}");
    }
}
```

---

