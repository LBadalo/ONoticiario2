namespace ONoticiario.Migrations
{
    using ONoticiario.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using IdentitySample.Models;
    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            //Inicio do SEED

            //Categorias

            var categorias = new List<Categorias>
            {
                new Categorias{ID=1,TipoCategoria="Mundo"},
                new Categorias{ID=2,TipoCategoria="Gaming"},
                new Categorias{ID=3,TipoCategoria="Politica"},
                new Categorias{ID=4,TipoCategoria="Saude"},
                new Categorias{ID=5,TipoCategoria="Esports"},
                new Categorias{ID=6,TipoCategoria="Mobile"},
                new Categorias{ID=7,TipoCategoria="Informatica"},
                new Categorias{ID=8,TipoCategoria="Outros"}
            };
            categorias.ForEach(aa => context.Categorias.AddOrUpdate(a => a.TipoCategoria, aa));
            context.SaveChanges();

            //Utilizadores
            var utilizadores = new List<Utilizadores> {
                new Utilizadores {Avatar="default.png", ID=1,Descricao="Administrador da Aplicaçao web",Nome="Luis Badalo",Username="admin@ipt.pt",DataNascimento= new DateTime(1997, 9, 29) },
                new Utilizadores {Avatar = "default.png", ID = 2, Descricao = "Jornalista da Aplicaçao web", Nome = "Rafael Sousa", Username = "Jornalista@ipt.com", DataNascimento = new DateTime(1985, 2, 23) },
                new Utilizadores {Avatar="default.png", ID=3, Descricao="Jornalista da pagina web", Nome="Joao Martins",Username="teste@ipt.pt", DataNascimento=new DateTime(1995,2,20)}  
            };
            utilizadores.ForEach(aa => context.Utilizadores.AddOrUpdate(a => a.Nome, aa));
            context.SaveChanges();

            //criação das noticias
            var noticias = new List<Noticias>
            {
                new Noticias{
                    ID =1,
                    Data=new DateTime(2020,10,24),
                    Titulo ="Portugal com mais 21 mortes e 3.669 casos de Covid-19 nas últimas 24 horas!",
                    Capa="covid19_24_10_2020.png",
                    UtilizadorFK=1,
                    Descricao="Novo recorde de infeções e internamentos, segundo os dados da DGS.",
                    Conteudo="A Direção-Geral da Saúde (DGS) anunciou no boletim diário deste sábado que há mais 21 mortes e 3.669 novos casos de Covid-19 em Portugal. O número de mortes subiu de 2.276 para 2.297, mais 21 do que na sexta - feira. Deste total, 11 mortes registaram-se no Norte, 6 na região de Lisboa e Vale do Tejo, 1 no Centro, 2 no Alentejo e 1 no Algarve. O número de infetados subiu de 112.440 para 116.109, mais 3.669 em 24 horas, o número mais alto desde que declarado o início da pandemia.Os internamentos hospitalares também atingiram nas últimas 24 horas os valores máximos registados desde o início da pandemia, num total de 1.455, mais 37 pessoas internadas do que na sexta - feira. Na quarta-feira Portugal tinha superado o valor máximo registado em abril de 1.302 com o registo de 1.365 casos de internamento e na sexta-feira esse valor foi superado com o boletim a revelar que 1.418 pessoas se encontravam internadas em unidades hospitalares.Nos cuidados intensivos estão internados 221 doentes, mais 23 do que na sexta - feira.O máximo de internamentos em Unidades de Cuidados Intensivos foi registado em 07 de abril, dia em que 271 pessoas estavam nestas unidades com covid-19, a doença provocada pelo novo coronavírus SARS - CoV - 2. As autoridades de saúde têm 57.024 pessoas em vigilância, menos 431 do que na sexta - feira. A DGS revela ainda que estão ativos 45.970 casos, mais 1.686 que nas últimas 24 horas.Nas últimas 24 horas 1.962 doentes recuperaram, totalizando 67.842 desde o início da pandemia.",
                    ListaCategorias = new List<Categorias>{categorias[3]},
                    ListaComentarios= new List<Comentarios>{ }
                },
                 new Noticias{
                    ID =2,
                    Data=new DateTime(2020,10,24),
                    Titulo ="MagSafe da Apple",
                    Capa="MagSafeIphone_24_10_2020.jpg",
                    UtilizadorFK=1,
                    Descricao="MagSafe: carregador sem fios da Apple é extremamente lento nos iPhones antigos",
                    Conteudo="O MagSafe mantém a compatibilidade com o carregamento Qi e, assim, permite um carregamento wireless também no iPhone 8 ou posterior, bem como nos modelos AirPods com caixa de carregamento sem fios. No entanto, a funcionalidade de alinhamento magnético aplica-se apenas ao iPhone 12 e ao iPhone 12 Pro. Comparativamente a outros carregadores sem fios baseados em Qi, o novo equipamento da Apple é bastante mais lento. O MacRumors comparou o desempenho do MagSafe com um carregador Qi de 7,5 W e verificou uma maior rapidez deste último.Ou seja, um carregador Qi de 7,5 W é capaz de carregar a bateria do iPhone mais antigo até cerca de 25 % em meia hora. Em termos comparativos, é quase o dobro daquilo que o MagSafe consegue.Noutro teste ao iPhone XS Max com um carregador Belkin 7,5 W, o smartphone carregou 26 % em 30 minutos. Assim, apesar de o MagSafe funcionar perfeitamente nos novos iPhone 12, depois destes testes o site aconselha a quem tem um modelo mais antigo a não investir neste novo carregador wireless da Apple.",
                    ListaCategorias = new List<Categorias>{categorias[6],categorias[7]},
                    ListaComentarios= new List<Comentarios>{ }
                },
                new Noticias{
                    ID =3,
                    Data=new DateTime(2019,6,28),
                    Titulo ="O ultimo jogo entre os DAMWON e G2 é o mais rápido da história do Torneio",
                    Capa="DamWon_24_10_2020.jpg",
                    UtilizadorFK=1,
                    Descricao="Apesar do equilibrio que houve nos três primeiros jogos a equipa europeia não resistiu à grande equipa coreana.",
                    Conteudo="Neste sábado (24), a DAMWON Gaming entraram para a história do Torneio de League of Legends com a partida mais rápida da competição. O feito aconteceu durante o quarto jogo da semifinal contra a G2 Esports, saindo vitoriosa a equipa dos sul-coreanos.Os atuais campeões da LCK terminaram os jogo contra os campeões europeus em 19 minutos e 3 segundos, sendo desta a primeira vez que uma equipa consegue vencer uma partida em menos de 20 minutos!",
                    ListaCategorias = new List<Categorias>{categorias[1],categorias[4]},
                    ListaComentarios= new List<Comentarios>{ }
                }
            };
            noticias.ForEach(aa => context.Noticias.AddOrUpdate(a => a.Data, aa));
            context.SaveChanges();

            //criação de comentários
            var comentarios = new List<Comentarios>
            {
                new Comentarios{ID=1,Descricao="Comentário de teste1",Data=new DateTime(2020,10,25),UtilizadorFK=3,NoticiasFK=1},
                new Comentarios{ID=2,Descricao="Comentário de teste2",Data=new DateTime(2020,10,26),UtilizadorFK=2,NoticiasFK=1},
                new Comentarios{ID=3,Descricao="Outro comentário1",Data=new DateTime(2020,3,28),UtilizadorFK=3,NoticiasFK=3},
                new Comentarios{ID=4,Descricao="Comentário novo2",Data=new DateTime(2020,3,28),UtilizadorFK=1,NoticiasFK=3},
                 new Comentarios{ID=5,Descricao="Outro comentário3",Data=new DateTime(2020,5,28),UtilizadorFK=3,NoticiasFK=3},
                new Comentarios{ID=6,Descricao="Outro comentário1",Data=new DateTime(2020,10,26),UtilizadorFK=3,NoticiasFK=2}


            };
            comentarios.ForEach(aa => context.Comentarios.AddOrUpdate(a => a.Descricao, aa));
            context.SaveChanges();
        }
    }
}