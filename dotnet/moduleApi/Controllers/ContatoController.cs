using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using moduleApi.Context;
using moduleApi.Entities;

namespace moduleApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController: ControllerBase
    {
        private readonly AgendaContext _context;
        public ContatoController(AgendaContext context){
            _context = context;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id){
            var contato = _context.Contatos.Find(id);

            if(contato == null){
                return NotFound();
            }

            return Ok(contato);
        }

        [HttpGet("GetByName")]
        public IActionResult GetByName(string name){
            var contatos = _context.Contatos.Where(index => index.Nome.Contains(name));

            if(contatos == null){
                return NotFound();
            }

            return Ok(contatos);
        }

        [HttpPost]
        public IActionResult Create(Contato contato){
            _context.Add(contato);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new {id = contato.Id}, contato);
        }

        [HttpPut("{id}")] 
        public IActionResult update(int id, Contato contato){
            var contatoBanco = _context.Contatos.Find(id);

            if(contatoBanco == null){
                return NotFound();
            }

            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Ativo = contato.Ativo;
            _context.Contatos.Update(contatoBanco);
            _context.SaveChanges();

            return Ok(contatoBanco);
        }

        [HttpDelete("{id}")] 
        public IActionResult Delete(int id){
            var contatoBanco = _context.Contatos.Find(id);

            if(contatoBanco == null){
                return NotFound();
            }

            _context.Contatos.Remove(contatoBanco);
            _context.SaveChanges();
            return NoContent();
        }
    }
}