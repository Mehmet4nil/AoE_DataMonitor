# AoE_DataMonitor
Visual display of a sample game data.

# Installing and Requirements

Microsoft .NET Framework 4.7.2 yüklü olmalıdır.

1- Clone this repository

**git clone https://github.com/Mehmet4nil/AoE_DataMonitor.git**

2- Install the project dependencies
Visual Studio, VS Code..

Uygulamayı çalıştırmak için .zip yada git clone kullanarak proje dosyalarını indiriniz. "AoE_DataMonitor\AoE_DataMonitor\bin\Debug" klasör yoluna gidiniz. Çalıştırma dosyası burda bulunur, verilen url den indirilecek olan örnek veri dosyası da bu klasörde indirilip kaydedilecektir. Uygulamayı "AoE_DataMonitor.exe" dosyası ile çalıştırınız.  Proje kodlarına erişmek için "AoE_DataMonitor\" klasöründe bulunan "AoE_DataMonitor.sln" dosyasını Visual Studio yada muadil IDE ler ile çalıştırabilirsiniz. Kodlara herhangi bir text editörü ile ulaşmak istiyorsanız "AoE_DataMonitor\AoE_DataMonitor" klasöründe bulunan dosyalar ile ulaşabilirsiniz.

# Notes
Uygulama oyuncu sayısının değişiklik gösterebileceği, veri setinde başlangıç milisaniyesinin 0 dan faklı olabileceği, varsayılarak yazılmıştır. Veri yazdırma hızı Timer yenileme hızı değiştirilerek sağlanmaya çalışılmıştır ancak sistem real time çalışmamıştır. Birçek test yapılmasına rağmen Timer ın Interval değeri ile real time yakalanamıştır. Interval değeri 100 msec > örnek olarak 10 000 msec lik bir veri  = 11 048, 11 044 msec gibi değerlerde yazdırma yapmıştır. .net, stopwatch nesnesi ile süreler ölçülmüştür. Onun yerine hız ayarlaması veri yazdırılırken satırlar arası istenen hız kadar atlama yapılarak sağlanmıştır.

# Contact
Sorularınız için iletişime geçebilirsiniz.
mehmetislicik@gmail.com
