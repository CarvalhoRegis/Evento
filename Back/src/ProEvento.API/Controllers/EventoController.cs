using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEvento.API.Models;

namespace ProEvento.API.Controllers
{
    [ApiController]
    [Route("[api/controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[] {
                new Evento() {
                    EventoId = 1,
                    Tema = "Full Stack pt 1",
                    Local = "São Paulo",
                    Lote = "1° Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    ImagemURL = "foto.png",
                },
                new Evento() {
                    EventoId = 2,
                    Tema = "Full Stack pt 2",
                    Local = "São Paulo",
                    Lote = "2° Lote",
                    QtdPessoas = 350,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    ImagemURL = "foto1.png",
                },
        };
        public EventoController() {
            
        }

        [HttpGet] //rota de busca total de eventos
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")] //buscar a rota por id
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Teste Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo Put = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo Delete = {id}";
        }
    }
}
