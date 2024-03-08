using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCStokTakipSistemi.Models.Entity;
namespace MVCStokTakipSistemi.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        DBMVCSTOKEntities db=new DBMVCSTOKEntities();

        public ActionResult Index()
        {
           var degerler=db.TBLKATEGORI.ToList();
            return View(degerler);
        }
       
        [HttpGet]
        public ActionResult YeniKategori() {
            return View(); 
        }
        [HttpPost]
        public ActionResult YeniKategori(TBLKATEGORI p1){
            db.TBLKATEGORI.Add(p1);
            db.SaveChanges();
			return RedirectToAction("Index");
		}

        public ActionResult Sil(int id)
        {
            var kategori=db.TBLKATEGORI.Find(id);
            db.TBLKATEGORI.Remove(kategori);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Guncelle(int id)
        {
            var kategori = db.TBLKATEGORI.Find(id);
            //var kategori = db.TBLKATEGORI.Where(a=>a.KATEGORIID==id).FirstOrDefault();
            return View(kategori);
        }
        [HttpPost]
        public ActionResult Guncelle(TBLKATEGORI p)
        {
            var kategori = db.TBLKATEGORI.Find(p.KATEGORIID);
            kategori.KATEGORIAD=p.KATEGORIAD;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}