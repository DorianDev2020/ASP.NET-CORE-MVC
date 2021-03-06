﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using heroproject1.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using heroproject1.Models;

namespace heroproject1.Controllers
{
    public class HerosController : Controller
    {
        // GET: Heros
        private ApplicationDbContext db;

        public HerosController(ApplicationDbContext db)
        {
            this.db = db;
        }

        // GET: Heroes
        public ActionResult Index()
        {
            var Heroes = db.Heroes;
            return View(Heroes);
        }

        // GET: Heroes/Details/5
        public ActionResult Details(int id)
        {
            Hero hero = db.Heroes.Find(id);
            return View();
        }

        // GET: Heroes/Create
        public ActionResult Create()
        {
            Hero suit = new Hero();
            return View();
        }

        // POST: Heroes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Hero hero)
        {
            try
            {
                // TODO: Add insert logic here
                db.Heroes.Add(hero);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Heroes/Edit
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Heroes/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Hero hero)
        {
            try
            {
                // TODO: Add update logic here
                Hero editHero = db.Heroes.Find(id);
                hero.HeroNumber = editHero.HeroNumber;
                hero.HeroName = editHero.HeroName;
                hero.HeroPower = editHero.HeroPower;
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Heroes/Delete
        public ActionResult Delete(int id)
        {

            return View();
        }

        // POST: Heroes/Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Hero hero)
        {
            try
            {
                // TODO: Add delete logic here
                Hero heroToRemove = db.Heroes.Find(id); 
                db.Heroes.Remove(heroToRemove); 
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}