using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCStokTakipSistemi.Models.Entity;

namespace MVCStokTakipSistemi.Controllers
{
    public class MüsteriController : Controller
    {
        // GET: Müsteri
        DBMVCSTOKEntities db=new DBMVCSTOKEntities();
        public ActionResult Index()
        {
            var musteri=db.TBLMUSTERI.ToList();
            return View(musteri);
        }
        [HttpGet]
        public ActionResult MusteriEkle()
        {
            return View();
        }
		[HttpPost]
		public ActionResult MusteriEkle(TBLMUSTERI p2)
		{
            db.TBLMUSTERI.Add(p2);
            db.SaveChanges();
			return RedirectToAction("Index");
		}
        public ActionResult Sil(int id)
        {
            var musteri=db.TBLMUSTERI.Find(id);
            db.TBLMUSTERI.Remove(musteri);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Guncelle(int id)
        {
            var musteri = db.TBLMUSTERI.Find(id);
            return View(musteri);
        }
        [HttpPost]
		public ActionResult Guncelle(TBLMUSTERI p)
		{
            var musteri = db.TBLMUSTERI.Find(p.MUSTERIID);

            musteri.MUSTERIAD=p.MUSTERIAD;
            musteri.MUSTERISOYAD=p.MUSTERISOYAD;
            db.SaveChanges();
            return RedirectToAction("Index");
		}
	}
}