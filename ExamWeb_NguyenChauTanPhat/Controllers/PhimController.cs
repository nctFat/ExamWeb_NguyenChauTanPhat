using ExamWeb_NguyenChauTanPhat.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamWeb_NguyenChauTanPhat.Controllers
{
    public class PhimController : Controller
    {
        private readonly ApplicationDbContext _db;
        public PhimController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index(int? page)
        {
            var pageIndex = (int)(page != null ? page : 1);
            var pageSize = 2;

            // Thống kê số trang
            var totalItems = _db.Phims.Count();
            var pageSum = totalItems / pageSize + (totalItems % pageSize > 0 ? 1 : 0);

            // Truy xuất dữ liệu theo trang
            var productList = _db.Phims.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();

            // Truyền dữ liệu cho View
            ViewBag.PageSum = pageSum;
            ViewBag.PageIndex = pageIndex;

            // Tính tổng số lượng
            var tongsoluong = _db.Phims.Count();
            ViewBag.SUM = tongsoluong;

            var giaVeCaoNhat = _db.Phims.Max(p => p.GiaVe);
            ViewBag.MaxPrice = giaVeCaoNhat;
            return View(productList);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Phim pm)
        {
            if (ModelState.IsValid)
            {
                _db.Phims.Add(pm);
                _db.SaveChanges();
                TempData["success"] = "Đã thêm 1 phim";
                return RedirectToAction("Index");
            }
            return View(pm);
        }
        public IActionResult Update(int id)
        {
            var dt = _db.Phims.SingleOrDefault(x => x.Id == id);
            if (dt != null)
                return View(dt);

            return NotFound();
        }

        [HttpPost]
        public IActionResult Update(Phim pm)
        {
            if (ModelState.IsValid)
            {
                _db.Phims.Update(pm);
                _db.SaveChanges();
                TempData["success"] = "Đã cập nhật 1 phim";
                return RedirectToAction("Index");
            }
            return View(pm);
        }
        public IActionResult Delete(int id)
        {
            var product = _db.Phims.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        //Xử lý xóa sản phẩm
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var product = _db.Phims.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            // xoá hình cũ của sản phẩm
            // xoa san pham khoi CSDL
            _db.Phims.Remove(product);
            _db.SaveChanges();
            TempData["success"] = "Đã xoá phim thành công";
            //chuyen den action index
            return RedirectToAction("Index");
        }
    }
}
