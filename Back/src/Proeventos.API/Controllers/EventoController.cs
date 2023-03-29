using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proeventos.API.Models;

namespace Proeventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
            
            // O IEnumerable espera receber um Array usamos pois trazemos os dados através de funções
            // E assim exibimos como um Array, isso deve otimizar tempo, se estiver certo voltarei aqui pra afirmar, se for pra corrigir também :)
       
        public IEnumerable<Evento> _evento = new Evento[] {

                    new Evento() {
                    EventoId = 1,
                    Tema = "Angular e .NET5",
                    Local = "Itaquaquecetuba",
                    Lote = "Os cupinxas",
                    QtdesPessoas = "5",
                    DataEvento = DateTime.Now.AddDays(17).ToString(),
                    ImageURL = "foto.png"
                },

                new Evento() {
                    EventoId = 2,
                    Tema = "Angular e suas novidades",
                    Local = "Itapecirica da Serra",
                    Lote = "3° Lote ",
                    QtdesPessoas = "5",
                    DataEvento = DateTime.Now.AddDays(17).ToString("dd/mm/yyyy"),
                    ImageURL = "foto1.png"
                }
            };
            

        
        public EventoController()
        {
            
        }
        

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            
            {
                return _evento;    
            }
        } 

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetBy(int id)
        
            {
                return _evento.Where(evento => evento.EventoId == id);    
            }
         

         [HttpPost]
        public string Post()
        {
            return "foi de base lotado";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"coitado do condenado = {id}";
        }

        [HttpDelete("{id}")]
        public string DeHttpDelete(int id)
        {
            return $"la se vai um lascado = {id}";
        }

           
        }
    } 

