using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class Product
    {           // Property -- Özellik
        // encapsulation = Nesne yönelimli programlamanın ilk prensibi kapsülleme (encapsulation) olarak adlandırılır. Bu özellik, dilin nesne kullanıcısından gereksiz uygulama ayrıntılarını saklar. Oluşturulan bir sınıf (class) içerisinde kullanıcının işlemlerini daha kolay gerçekleştirebilmesi için bazı işlemler birleştirilerek tek bir işlem gibi gösterilir. Bu birleştirme işlemine kapsülleme denir.
        // Düzensizi düzenli hale getiriyor. Ayrı ayrı olan veriyi bütünleştirmedir.
        
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }

        public string UrunKategorisi { get; set; }      




    }


}
