﻿using AnimalAdoptionCenter.Models;
using AnimalAdoptionCenter.Services;
using Microsoft.AspNetCore.Mvc;

namespace AnimalAdoptionCenter.Controllers
{
    public class ProfileController : Controller
    {
        ITempDataReposService _tempDataReposService;
        public ProfileController(ITempDataReposService tempDataReposService) => _tempDataReposService = tempDataReposService;
        public IActionResult Index(int id)
        {
            Animal animal = _tempDataReposService.GetAllAnimals().Where(animal => animal.AnimalId == id).First();
            return View(animal);
        }
    }
}