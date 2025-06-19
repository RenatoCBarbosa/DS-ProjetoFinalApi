using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace ProjetoFinalApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class LocacaoExemploController : ControllerBase
    {
        private static List<Locacao> Locacoes = new List<Locacao>()
        {
            new Locacao() {Id = 1, Nome = "Anual", Classe=ValorEnum.Anual},
            new Locacao() {Id = 2, Nome = "Mensal", Classe=ValorEnum.Mensal},
            new Locacao() {Id = 3, Nome = "Diario", Classe=ValorEnum.Diario},
        };

        public IActionResult Get()
        {
            Locacao lc = Locacoes[0];
            return Ok(lc);
        }

        [HttpGet("Get")]
        public IActionResult GetFirst()
        {
            return Ok(Locacoes[0]);
        }

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(Locacoes);
        }

        [HttpGet("{id}")]
        public IActionResult GetSingle(int id)
        {
            return Ok(Locacoes.FisrtOrDefault(lc => lc.Id == id));
        }
        
        [HttpPost]
        public IActionResult AddLocacao(IdLocacao novoLocacao)
        {
            locacao.Add(novoLocacao);
            return Ok(Locacoes);
        }

        /*Ordenando uma lista por critério*/
        [HttpGet("GetOrdenado")]
        public IActionResult GetOrdem()
        {
            List<Locacao> listaFinal = Locacoes.OrderBy(lc => lc.Anual).ToList();
            return Ok(listaFinal);
        }

        /*Contar Itens de uma lista*/
        [HttpGet("GetContagem")]
        public IActionResult GetQuantidade()
        {
            return Ok("Quandidade de possibilidades de locações: " + Locacoes.Count);
        }

        /*Filtrando dados de uma lista de acordo com critérios*/
        [HttpGet("GetSemAnual")]
        public IActionResult GetSemAnual()
        {
            List<locacao> listaBusca = Locacoes.FindAll(lc => lc.Classe != ValorEnum.Anual);
            return Ok(listaBusca);
        }

        /*Busca por nome aproximado*/
        [HttpGet("GetByNomeAproximado/{nome}")]
        public IActionResult GetByNomeAproximado(string nome)
        {
            List<locacao> listaBusca = Locacoes.FindAll(lc => lc.Nome.Contains(nome));
            return Ok(listaBusca);
        }

        /*Filtrando um personagem por algum critério e removendo o mesmo da lista*/
        [HttpGet("GetRemovendoAnual")]
        public IActionResult GetRemovendoAnual()
        {
            Locacao lcRemove = Locacoes.Find(lc => lc.Classe == ValorEnum.Anual);
            locacao.lcRemove(lcRemove);
            return Ok("Locacao removida: " + lcRemove.Nome);
        }

        [HttpPost]
        public IActionResult AddLocacao(IdLocacao novoLocacao)
        {
            if (novoLocacao.Anual == 0)
                return BadRequest("A locação não pode durar menos de 30 minutos.");

            Locacoes.Add(novoLocacao);
            return Ok(Locacoes);
        }
    }
}