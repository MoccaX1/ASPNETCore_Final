﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPCore_Final.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPCore_Final.Controllers
{
    public class HangHoaController : Controller
    {
        private readonly ESHOPContext db;
        public HangHoaController(ESHOPContext ctx)
        {
            db = ctx;
        }
        public IActionResult Index(string loai)
        {
            List<HangHoa> hangHoas = db.HangHoa.Where(p => p.MaLoai == loai).ToList();
            return View(hangHoas);
        }
    }
}