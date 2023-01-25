using Microsoft.AspNetCore.Mvc;
using Tarefas.Web.Models;

namespace Tarefas.Web.Controllers;

public class TarefasController : Controller {
    public List<TarefaViewModel> listaDeTarefas {get;set;}

    public TarefasController(){
        listaDeTarefas = new List<TarefaViewModel>(){
            new TarefaViewModel() {Id=1, Titulo = "Escovar os dentes", Descricao = "Usar sensodine"},
            new TarefaViewModel() {Id=2, Titulo = "Arrumar a cama"},
            new TarefaViewModel() {Id=3, Titulo = "Por o lixo pra fora", Descricao = "Somente às terças"}
        
        };
    }

    public IActionResult Create (){
        return View();
    }

    public IActionResult Index(){
        return View(listaDeTarefas);
    }
    
    public IActionResult Details (int id){
        var tarefa = listaDeTarefas.Find(tarefa => tarefa.Id == id);
        return View(tarefa);
    }
}