﻿using IntegratedLibrary.Models.Patron;
using LibraryData;
using LibraryData.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegratedLibrary.Controllers
{
    public class PatronController : Controller
    {
        private IPatron _patron;
        public PatronController(IPatron patron)
        {
            _patron = patron;
        }
        public IActionResult Index()
        {
            var allPatron = _patron.GetAll();
            var patronModels = allPatron.Select
                (p=>new PatronDetailModel
                {
                    Id=p.Id,
                    FirstName=p.FirstName,
                    LastName=p.LastName,
                    LibraryCardId=p.LibraryCard.Id,
                    OverdueFees=p.LibraryCard.Fees,
                    HomeLibraryBranch=p.HomeLibraryBranch.Name

            }).ToList();
            var model = new PatronIndexModel()
            {
                Patrons = patronModels
            };
            return View(model);
        }
        public IActionResult Detail(int id)
        {
            var patron = _patron.Get(id);
            var model = new PatronDetailModel
            {
                LastName = patron.LastName,
                FirstName = patron.FirstName,
                Address=patron.Address,
                HomeLibraryBranch = patron.HomeLibraryBranch.Name,
                OverdueFees = patron.LibraryCard.Fees,
                LibraryCardId = patron.LibraryCard.Id,
                Telephone = patron.TelephoneNumber,
                AssetsCheckedOut = _patron.GetCheckouts(id).ToList() ?? new List<Checkout>(),
                CheckoutHistory = _patron.GetCheckoutHistory(id),
                Holds = _patron.GetHolds(id)
            };
            return View(model);
        }
    }
}
