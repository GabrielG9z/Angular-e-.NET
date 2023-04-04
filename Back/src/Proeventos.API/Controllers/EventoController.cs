using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proeventos.API.Data;
using Proeventos.API.Models;

namespace Proeventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
            
            // O IEnumerable espera receber um Array usamos pois trazemos os dados através de funções
            // E assim exibimos como um Array, isso deve otimizar tempo, se estiver certo voltarei aqui pra afirmar, se for pra corrigir também :)
       
        // public IEnumerable<Evento> _evento = new Evento[] {

            //         new Evento() {
            //         EventoId = 1,
            //         Tema = "Angular e .NET5",
            //         Local = "Itaquaquecetuba",
            //         Lote = "Os cupinxas",
            //         QtdesPessoas = "5",
            //         DataEvento = DateTime.Now.AddDays(17).ToString(),
            //         ImageURL = "foto.png"
            //     },

            //     new Evento() {
            //         EventoId = 2,
            //         Tema = "Angular e suas novidades",
            //         Local = "Itapecirica da Serra",
            //         Lote = "3° Lote ",
            //         QtdesPessoas = "5",
            //         DataEvento = DateTime.Now.AddDays(17).ToString("dd/mm/yyyy"),
            //         ImageURL = "foto1.png"
            //     }
            // };
            

        private readonly DataContexto contexto;
        public DataContexto Contexto { get; set; }
        
        public EventoController(DataContexto contexto)
        {
            this.contexto = contexto;
            
        }
        

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            
            {
                return contexto.Eventos;
            }
        } 

        [HttpGet("{id}")]
        // Retirando o IEnumerable pois não queremos que o retorno do database, venha dentro de colchetes e sim um array 
        // Também retiramos o return (contexto.Eventos.Where) pois utilizaremos outro meio de retorno
        // No caso pedimos o FirstOrDefault para nos retornar apenas um elemento
        public Evento GetBy(int id)
        
            {
                return contexto.Eventos.FirstOrDefault(evento => evento.EventoId == id);    
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

