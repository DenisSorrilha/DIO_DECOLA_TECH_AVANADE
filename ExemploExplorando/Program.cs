using ExemploExplorando.Models;

Pessoa p1 = new Pessoa("Denis", "Sorrilha");


Pessoa p2 = new Pessoa("Douglas", "Pereira");


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();



// Pessoa p1 = new Pessoa();

// p1.Nome = "Denis";
// p1.Sobrenome = "Sorrilha";
// p1.Idade = 42;
// p1.Apresentar();
