using System;
using System.Linq;
using API.Data.Collections;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;


namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InfectadoController : ControllerBase
    {
        Data.MongoDB _mongoDB;
        IMongoCollection<Infectado> _infectadosCollection;


        public InfectadoController(Data.MongoDB mongoDB)
        {
            _mongoDB = mongoDB;
            _infectadosCollection = _mongoDB.DB.GetCollection<Infectado>(typeof(Infectado).Name.ToLower());
        }

        [HttpPost]
        public ActionResult SalvaarInfectado([FromBody] InfectadoDTO dto)
        {
            var infectado = new Infectado(dto.DataNascimento, dto.Sexo, dto.Latitude, dto.Longitude);

            _infectadosCollection.InsertOne(infectado);

            return StatusCode(201, "Infectado adicionado com sucesso");
        }

        [HttpGet]
        public ActionResult ObterInfectados()
        {
            var infectados = _infectadosCollection.Find(Builders<Infectado>.Filter.Empty).ToList();

            return Ok(infectados);
        }



        [HttpPut]
        public ActionResult AtualizarInfectados([FromBody] InfectadoDTO dto)
        {
            _infectadosCollection.UpdateOne(Builders<Infectado>.Filter
                .Where(_ => _.DataNascimento == dto.DataNascimento),
                Builders<Infectado>.Update.Set("sexo", dto.Sexo));

            return Ok("Atualizado com sucesso!");
        }

        [HttpDelete("{dataNascimento}")]
        public ActionResult Deletear(DateTime dataNascimento)
        {
            _infectadosCollection.DeleteOne(Builders<Infectado>.Filter
                .Where(_ => _.DataNascimento == dataNascimento));

            return Ok("Deletado com sucesso!");
        }
    }
}
