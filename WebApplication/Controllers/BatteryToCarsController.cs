using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication.abbas_lkb;

namespace WebApplication.Controllers
{
    public class BatteryToCarsController : Controller
    {
        // GET
        public IActionResult Index(int catId = 6)
        {
            ViewBag.catId = catId;
            using (var db = new abbas_lkbContext())
            {
                ViewBag.cats = db.TblCategory.ToList();

                var list = db.TblCar.Include(t => t.TblItemCar)
                    .ThenInclude(t => t.Item)
                    .Include(t => t.Cat)
                    .OrderBy(d => d.Id).ToList();

                ViewBag.bats = db.TblItem.Where(t => t.CatId == catId).ToList();
                return View(list);
            }
        }


        [HttpPost]
        public IActionResult AddItem(AddItemViewModel vm)
        {
            using (var db = new abbas_lkbContext())
            {
                var _caritems = db.TblItemCar.AsQueryable();
                _caritems = _caritems.Where(c => c.CarId == vm.CarId);

                if (_caritems.Any(c => vm.Items.FirstOrDefault(item => item == c.ItemId) == null))
                {
                    throw new Exception("آیتم تکراری ارسال شده است ، ماشین مورد نظر آیتم را دارد");
                }

                foreach (var item in vm.Items)
                {
                    var carItem = new TblItemCar
                    {
                        CarId = vm.CarId,
                        ItemId = item
                    };
                    db.TblItemCar.Add(carItem);
                }

                TempData["backToCarItemUrl"]= vm.backToCarItemUrl;

                db.SaveChanges();
            }

            return RedirectToAction("index", new {catId = vm.ItemCategoryTypeId});
        }

        [HttpPost]
        public IActionResult RemoveItem(int carid, int itemid)
        {
            using (var db = new abbas_lkbContext())
            {
                var itemCar = db.TblItemCar.FirstOrDefault(c => c.CarId == carid && c.ItemId == itemid);
                if (itemCar == null)
                {
                    throw new Exception();
                }

                db.TblItemCar.Remove(itemCar);
                db.SaveChanges();
                return Json("successful");
            }
        }
    }

    public class AddItemViewModel
    {
        public string backToCarItemUrl { get; set; }
        public int[] Items { get; set; }
        public int CarId { get; set; }

        public int ItemCategoryTypeId { get; set; }
    }
}