using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornekproje
{
    class Urun
    {
        public int urun_id { get; set; }
        public string urun_ad { get; set; }
        public string urun_miktar { get; set; }
        public string urun_fiyat { get; set; }
        Db_projeEntities0 db = new Db_projeEntities0();

        public void setter(int id)
        {
            var list = db.tblurun.Find(id);
            urun_id = list.urun_id;
            urun_ad = list.urun_ad;
            urun_miktar = list.urun_miktar;
            urun_fiyat = list.urun_fiyat;

        }
    }
}
