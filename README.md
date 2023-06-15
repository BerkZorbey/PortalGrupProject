# PortalGrupProject

Bu proje PortalGrop'un teknik gereksinimlerine göre oluşturulmuştur.
<br/><br/>

- Öncelikle uygulamamızda bir şirket oluşturuyoruz. Şirket oluşturmak için sadece şirketin adını girmemiz yeterli oluyor.
<img src="https://github.com/BerkZorbey/PortalGrupProject/assets/63355948/7b061273-5356-40e5-8474-26564a397067.png" width="900px" height="400px">
<br/><br/><br/>

- Şirketi oluşturduktan sonra Şirket için bir proje oluşturuyoruz. Proje oluşturmak için Proje Adı,Projeyi Yöneten Kişi,
Proje Anahtarı ve Bu Projenin hangi Şirkete atanacağını belirleyen Şirket Id'sini giriyoruz.
<img src="https://github.com/BerkZorbey/PortalGrupProject/assets/63355948/402c0986-3ea9-4c0a-9561-5a42eb6b2972" width="900px" height="400px">
<br/><br/><br/>

- Şirketi ve Projeyi oluşturduktan sonra Çalışan ekliyoruz. Çalışan'ın adı, soyadı, Tc Kimlik No., Email,Telefon No. ve Doğum yılını giriyoruz.
Kişinin tüzel bir kişi olduğunu belirlemek için Adı,Soyadı,Tc Kimlik No. ve Doğum Yılı doğru girilmelidir.
<img src="https://github.com/BerkZorbey/PortalGrupProject/assets/63355948/46e29b61-689c-4ff7-9940-06ab66fd9afd" width="900px" height="400px">
<br/><br/><br/>

- Çalışanı ekledikten sonra Çalışanı Projeye dahil etmek için Çalışanın Id'si ve Projenin Id'sini giriyoruz. 
Bu sayede çalışan projeye başarıyla atanmış olmaktadır.
<img src="https://github.com/BerkZorbey/PortalGrupProject/assets/63355948/9e12a888-8426-44ce-8049-f255365b29a4" width="900px" height="400px">
<br/><br/><br/>

- Çalışan Projeye atandıktan sonra SQL Trigger ile Projede çalışan sayısını arttırıyoruz. 
Bu sayede Rapor almamız gerektiğinde projede çalışan sayısını kolaylıkla belirleyebiliriz.
<img src="https://github.com/BerkZorbey/PortalGrupProject/assets/63355948/d870a7aa-d44d-4f0e-b96c-d261669a8a41" width="900px" height="400px">
<br/><br/><br/>

- Burada İşimizi oluşturuyoruz. İş oluşturuken İşimizin başlığını,açıklamasını,bu işi hangi çalışanın açtığını belirlemek için çalışanın Id'si,
iş tagı(Back-End Developer vb.),İş No'yu(Proje Anahtarına göre oluşturulur) ve bu işin hangi projeye atanacağını belirleyen Proje Id'sini giriyoruz.
<img src="https://github.com/BerkZorbey/PortalGrupProject/assets/63355948/c3ec45ef-7e41-461d-be50-d3bf79589489" width="900px" height="400px">
<br/><br/><br/>

- Bu işimizi oluşturduktan sonra SQL Trigger ile Projede açılan işlerin sayısını arttırıyoruz.
<img src="https://github.com/BerkZorbey/PortalGrupProject/assets/63355948/b7862ad4-00ab-4f4f-943e-74ae1d9e3696" width="900px" height="400px">
<br/><br/><br/>

- İşimizi oluşturduk sırada bu işi tamamlayacak kişiyi atamak gerekiyor. İşe çalışan atamak için işin Id'si ve Çalışanın Id'si gerekmektedir.
<img src="https://github.com/BerkZorbey/PortalGrupProject/assets/63355948/4bc64d1e-6f52-49ae-80fb-5950c773306a" width="900px" height="400px">
<br/><br/><br/>

- Çalışanı işe atadıktan sonra SQL Trigger ile çalışanın çalıştığı işleri arttırıyoruz. Bu sayede bir çalışanın kaç tane işte çalışmış olduğunu görebiliriz.
<img src="https://github.com/BerkZorbey/PortalGrupProject/assets/63355948/b8bcdcc1-ef7d-4957-9457-c01e39c76313" width="900px" height="400px">
<br/><br/><br/>

- İş tamamlandıktan sonra Çalışanın tamamladığı işleri ve projede tamamlanan işleri SQL Trigger ile arttırıyoruz.
<img src="https://github.com/BerkZorbey/PortalGrupProject/assets/63355948/d9219cff-0a0b-445d-952b-a88c1b3351c2" width="900px" height="400px">
<br/><br/><br/>

- Raporlama gerektiğinde Şirketin Id'si ile şirkette bulunan projeleri bu projelerdeki işlerinin kaç tane olduğu, kaç tanesinin tamamladığını ve bu projelerde bulunan çalışanların kaç tane iş aldığı ve bunları tamamladığını detaylıca görebiliriz.
<img src="https://github.com/BerkZorbey/PortalGrupProject/assets/63355948/7fd6640b-0839-48b3-8931-eeed87de3abd" width="700px" height="700px">
<br/><br/><br/>
