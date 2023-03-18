using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoAnCoSo.Models;
using DoAnCoSo.Generation;
namespace DoAnCoSo.Controllers
{
    public class BookingController : Controller
    {
        // GET: Book

        LinQDataContext data = new LinQDataContext();
        
        public ActionResult SelectSpecialist()
        {
            var specialList = from dt in data.KHOAs
                              select dt;
            return View(specialList);
        }

        public ActionResult SearchDoctor(FormCollection collection)
        {
            var specialistId = collection.Get("specialist");
            var searchResult = from dt in data.BACSIs
                               where dt.MAKHOA.ToString() == specialistId
                               select dt;
            return View(searchResult);
        }

        public ActionResult LoadTimeOfDoctor(int id)
        {           
            var timeOfDoctor = from dt in data.GIOKHAMs
                               where dt.MABS == id
                               select dt;
            return PartialView(timeOfDoctor);
        }

        public ActionResult SelectDoctor()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FillForm(int id)
        {
            var doctorDetail = from dt in data.BACSIs
                               where dt.MABS == id
                               select dt;
            return View(doctorDetail);
        }

        [HttpPost]
        public ActionResult SendBookingForm(FormCollection collection,PHIEUHEN ph)
        {
            try
            {
                var name = collection.Get("name").Trim().ToUpper();
                var gender = collection.Get("gender");
                var dob = string.Format("{0:MM/dd/yyyy}", collection.Get("dob"));
                var address = collection.Get("address").ToUpper();
                var phone = collection.Get("phone").Trim();
                var detail = collection.Get("detail");
                var bookingDate = string.Format("{0:MM/dd/yyyy}", collection.Get("selectdate"));
                var bookingTime = collection.Get("time");
                var doctorID = int.Parse(collection.Get("doctorID"));

                ph.HOTEN = name;
                ph.GIOITINH = gender;
                ph.NAMSINH = DateTime.Parse(dob);
                ph.DIACHI = address;
                ph.SDT = phone;
                ph.GIOKHAM = TimeSpan.Parse(bookingTime);
                ph.NGAYKHAM = DateTime.Parse(bookingDate);
                ph.MOTA = detail;
                ph.MABS =doctorID;
                ph.TRANGTHAI = "Chưa xác thực";
                ph.MAXACTHUC = GenerateRandomString.GetRandomString();

                data.PHIEUHENs.InsertOnSubmit(ph);
                data.SubmitChanges();

                Session["SDT"] = phone;
                Session["Message"] = "Dat lich kham thanh cong" + " " + name +" " + bookingDate + " " + bookingTime;
                return RedirectToAction("Send", "SMS");

                //return RedirectToAction("BookingSuccess", "Booking");
            }
            catch (Exception)
            {
                return HttpNotFound();
            }
        }

        public ActionResult BookingSuccess()
        {
            return View();
        }
    }
}