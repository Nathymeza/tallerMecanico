﻿using Microsoft.AspNetCore.Mvc;
using TallerMecanico.Datos;
using TallerMecanico.Models;

namespace TallerMecanico.Controllers
{
    public class MantenedorController : Controller
    {
        PersonaDatos Persona_Datos = new PersonaDatos();
        public IActionResult Listar()
        {
            var oLista = Persona_Datos.Listar();

            return View(oLista);
        }
        public IActionResult Guardar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar(PersonaModel oPersona)
        {
            if (!ModelState.IsValid)
                return View();

            var respuesta = Persona_Datos.Guardar(oPersona);

            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }
        public IActionResult Editar(int IdPersona)
        {
            var oPersona = Persona_Datos.Obtener(IdPersona);
            return View(oPersona);
        }

        [HttpPost]
        public IActionResult Editar(PersonaModel oPersona)
        {
            if (!ModelState.IsValid)
                return View();


            var respuesta = Persona_Datos.Editar(oPersona);

            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }

        public IActionResult Eliminar(int IdPersona)
        {
            
            var opersona = Persona_Datos.Obtener(IdPersona);
            return View(opersona);
        }

        [HttpPost]
        public IActionResult Eliminar(PersonaModel oPersona)
        {
            var respuesta = Persona_Datos.Eliminar(oPersona.IdPersona);

            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }
    }
}
