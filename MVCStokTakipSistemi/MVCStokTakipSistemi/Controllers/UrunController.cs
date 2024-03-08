using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCStokTakipSistemi.Models.Entity;

namespace MVCStokTakipSistemi.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun
        DBMVCSTOKEntities db = new DBMVCSTOKEntities();
        public ActionResult Index()
        {
            var degerler=db.TBLURUN.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult UrunEkle() {
            
            return View(); 
        }
        [HttpPost]
        public ActionResult UrunEkle(TBLURUN p1) {
        
            db.TBLURUN.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Sil(int id)
        {
            var urun=db.TBLURUN.Find(id);
            db.TBLURUN.Remove(urun);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Guncelle(int id)
        {
            var urun=db.TBLURUN.Find(id);
            return View(urun);
        }
        [HttpPost]
        public ActionResult Guncelle(TBLURUN p1)
        {
            var urun=db.TBLURUN.Find(p1.URUNID);
            urun.URUNAD=p1.URUNAD;
            urun.URUNMARKA=p1.URUNMARKA;
            urun.URUKATEGORİ=p1.URUKATEGORİ;
            urun.FİYAT=p1.FİYAT;
            urun.STOK=p1.STOK;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}