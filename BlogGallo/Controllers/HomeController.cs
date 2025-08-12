using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BlogGallo.Models;

namespace BlogGallo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // Criar objetos
        List<Categoria> categorias = [
            new() { Id = 1, Nome = "Mundo" },
            new() { Id = 2, Nome = "Brasil" },
            new() { Id = 3, Nome = "Tecnologia" },
            new() { Id = 4, Nome = "Design" },
            new() { Id = 5, Nome = "Cultura" },
            new() { Id = 6, Nome = "Negócios" },
            new() { Id = 7, Nome = "Política" },
            new() { Id = 8, Nome = "Opinião" },
            new() { Id = 9, Nome = "Ciências" },
            new() { Id = 10, Nome = "Saúde" },
            new() { Id = 11, Nome = "Estilo" },
            new() { Id = 12, Nome = "Viagens" }
        ];

        List<Postagem> postagens = [
            new() {
                Id = 1,
                Nome = "Crise humanitária cresce em zonas de conflito no Oriente Médio",
                CategoriaId = 1,
                Categoria = categorias.Find(c => c.Id == 1),
                DataPostagem = DateTime.Parse("06/08/2025"),
                Descricao = "Agências alertam para a escassez de alimentos e medicamentos nas regiões afetadas",
                Texto = "Conflitos armados continuam a agravar a situação humanitária em várias regiões do Oriente Médio. A ONU declarou estado de emergência em áreas críticas.",
                Thumbnail = "/img/1.jpeg",
                Foto = "/img/1.jpeg"
            },
            new() {
                Id = 2,
                Nome = "Novo marco fiscal é aprovado no Congresso",
                CategoriaId = 2,
                Categoria = categorias.Find(c => c.Id == 2),
                DataPostagem = DateTime.Parse("05/08/2025"),
                Descricao = "A medida visa controlar os gastos públicos e estimular o crescimento econômico no país.",
                Texto = "Com ampla maioria, o novo marco fiscal foi aprovado e agora segue para sanção presidencial. Especialistas avaliam os impactos no orçamento de 2026.",
                Thumbnail = "/img/2.png",
                Foto = "/img/2.png"
            },
            new() {
                Id = 3,
                Nome = "Internet discada ainda existia – e só agora ela vai acabar",
                CategoriaId = 3,
                Categoria = categorias.Find(c => c.Id == 3),
                DataPostagem = DateTime.Parse("07/08/2025"),
                Descricao = "Serviço que já gerou milhões em receita agora se torna peça de museu, enquanto conexões modernas dominam o mercado",
                Texto = "Você provavelmente nunca mais tinha ouvido falar em internet discada e assumiu que ela ficou totalmente no passado, mas, na realidade, a tecnologia ainda existia. Até agora.<br>A empresa <b>AOL</b> anunciou em um comunicado que encerrará seu serviço de internet discada em 30 de setembro, junto com o software associado.<br><br><strong>Sim, ainda existiam pessoas que usavam internet discada</strong><ul><li>Embora muitos considerem a conexão discada uma relíquia do passado, estima-se que ainda existam cerca de 163 mil domicílios nos EUA usando exclusivamente essa tecnologia.</li></ul>",
                Thumbnail = "/img/3.jpg",
                Foto = "/img/3.jpg"
            },
            new() {
                Id = 4,
                Nome = "Tendências do design minimalista em 2025",
                CategoriaId = 4,
                Categoria = categorias.Find(c => c.Id == 4),
                DataPostagem = DateTime.Parse("04/08/2025"),
                Descricao = "Linhas limpas e cores neutras continuam em alta nos projetos de design gráfico e interiores.",
                Texto = "O design minimalista ganha novas interpretações com o uso de tecnologia sustentável e foco na funcionalidade.",
                Thumbnail = "/img/4.png",
                Foto = "/img/4.png"
            },
            new() {
                Id = 5,
                Nome = "Festival internacional de cinema celebra diversidade",
                CategoriaId = 5,
                Categoria = categorias.Find(c => c.Id == 5),
                DataPostagem = DateTime.Parse("03/08/2025"),
                Descricao = "Mostra reúne produções de mais de 40 países com foco em representatividade.",
                Texto = "A nova edição do festival de cinema traz à tona temas sociais e políticos, dando voz a minorias e novos talentos.",
                Thumbnail = "/img/5.jpg",
                Foto = "/img/5.jpg"
            },
            new() {
                Id = 6,
                Nome = "Startups brasileiras atraem investimento estrangeiro recorde",
                CategoriaId = 6,
                Categoria = categorias.Find(c => c.Id == 6),
                DataPostagem = DateTime.Parse("02/08/2025"),
                Descricao = "Setores como fintechs e agritechs lideram captação de recursos.",
                Texto = "Com um ambiente de inovação favorável, empresas emergentes brasileiras conquistam investidores dos EUA, Europa e Ásia.",
                Thumbnail = "/img/6.jpg",
                Foto = "/img/6.jpg"
            },
            new() {
                Id = 7,
                Nome = "Nova legislação eleitoral é sancionada",
                CategoriaId = 7,
                Categoria = categorias.Find(c => c.Id == 7),
                DataPostagem = DateTime.Parse("01/08/2025"),
                Descricao = "Mudanças impactam campanhas e regras para financiamento partidário.",
                Texto = "As alterações na lei eleitoral foram aprovadas com o objetivo de aumentar a transparência e limitar abusos no uso de verbas públicas.",
                Thumbnail = "/img/7.jpg",
                Foto = "/img/7.jpg"
            },
            new() {
                Id = 8,
                Nome = "A urgência de repensar nosso consumo digital",
                CategoriaId = 8,
                Categoria = categorias.Find(c => c.Id == 8),
                DataPostagem = DateTime.Parse("31/07/2025"),
                Descricao = "A quantidade de conteúdo que consumimos está afetando nossa atenção e bem-estar.",
                Texto = "Vivemos numa era de excesso de informação, e isso está nos deixando ansiosos e dispersos. Precisamos parar e refletir sobre o uso consciente da tecnologia.",
                Thumbnail = "/img/8.jpg",
                Foto = "/img/8.jpg"
            },
            new() {
                Id = 9,
                Nome = "Descoberta de planeta com atmosfera semelhante à Terra intriga cientistas",
                CategoriaId = 9,
                Categoria = categorias.Find(c => c.Id == 9),
                DataPostagem = DateTime.Parse("30/07/2025"),
                Descricao = "Observatório europeu identifica exoplaneta com potencial para abrigar vida.",
                Texto = "Astrônomos encontraram um planeta localizado a 120 anos-luz da Terra, com atmosfera rica em oxigênio e vapor d'água.",
                Thumbnail = "/img/9.jpeg",
                Foto = "/img/9.jpeg"
            },
            new() {
                Id = 10,
                Nome = "Estudo mostra impacto do sono na saúde cardiovascular",
                CategoriaId = 10,
                Categoria = categorias.Find(c => c.Id == 10),
                DataPostagem = DateTime.Parse("29/07/2025"),
                Descricao = "Dormir mal pode aumentar riscos de doenças cardíacas em até 35%, alerta pesquisa.",
                Texto = "Uma boa noite de sono é mais importante do que se imaginava. Cientistas reforçam a ligação entre qualidade do sono e saúde do coração.",
                Thumbnail = "/img/10.png",
                Foto = "/img/10.png"
            },
            new() {
                Id = 11,
                Nome = "Moda sustentável domina passarelas europeias",
                CategoriaId = 11,
                Categoria = categorias.Find(c => c.Id == 11),
                DataPostagem = DateTime.Parse("28/07/2025"),
                Descricao = "Coleções usam tecidos reciclados e processos ecológicos como tendência principal.",
                Texto = "Grifes consagradas estão adotando práticas sustentáveis e mostrando que é possível unir estilo e consciência ambiental.",
                Thumbnail = "/img/11.jpeg",
                Foto = "/img/11.jpeg"
            },
            new() {
                Id = 12,
                Nome = "Os destinos mais procurados para o final de 2025",
                CategoriaId = 12,
                Categoria = categorias.Find(c => c.Id == 12),
                DataPostagem = DateTime.Parse("27/07/2025"),
                Descricao = "Europa e Ásia lideram as buscas entre os viajantes, com destaque para roteiros culturais.",
                Texto = "Segundo agências de turismo, cidades como Lisboa, Tóquio e Istambul estão entre os destinos mais desejados neste fim de ano.",
                Thumbnail = "/img/12.jpg",
                Foto = "/img/12.jpg"
            }
        ];
        return View(postagens);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
