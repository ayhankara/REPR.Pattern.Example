# REPR.Pattern.Example
FastEndpoints, geleneksel Asp.NET Core controller ya da minimal api yapılanmalarına karşın daha akıcı bir şekilde REPR pattern’ını uygulamamızı sağlayan bir kütüphanedir.
REPR Pattern’ının Bileşenleri Nelerdir?
REPR pattern’ı, üç temel aşamadan oluşmaktadır;

Request
Kullanıcı veya client’lardna gelen istekleri ifade etmektedir.
Genellikle bir API çağrısı ya da HTTP isteği şeklindedir.
JSON, XML vs. gibi belirli bir formattadır.
Endpoint
Gelen request’in yölendirildiği servisi ifade etmektedir.
Request bu servis tarafından alını ve gerekli iş mantığı işlenerek, çalıştırılır.
Ve çalışma neticesinde bir result(sonuç) elde edilir.
Response
Request neticesinde endpoint’te oluşturulan result’ı tekrar kullanıcı ya da client’a döndüren yapıyı ifade etmektedir.
Çoğunlukla HTTP durum kodları(200, 404, 500 vb.) ile birlikte dönen result içermektedir.
REPR Pattern Nasıl Uygulanır?
REPR pattern, manuel uygulanabileceği gibi FastEndpoints ya da ApiEndpoints gibi kütüphaneler aracılığıyla da uygulanabilmektedir.
