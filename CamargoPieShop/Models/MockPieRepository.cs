using BethanysPieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Model
{
    public class MockPieRepository : IPieRepository
    {
        private List<Pie> _pies;

        public MockPieRepository()
        {
            if(_pies == null)
            {
                InitializePies();
            }
        }
        
        private void InitializePies()
        {
            _pies = new List<Pie>
            {
                    new Pie {Id = 1, Name = "Html e Css - Projete e Construa Websites", Price = 205.90M, ShortDescription = "Duckett,Jon - Alta Books", LongDescription = "Bem-vindo a uma melhor maneira de aprender HTML & CSS. Se você quer projetar, construir do zero ou ter mais controle sobre um site existente, este livro lhe ajudará a criar conteúdos atrativos e amigáveis. Sabemos que código pode ser um pouco intimidador, mas dê uma olhada e veja como este guia difere dos livros de programação mais tradicionais. Toda as páginas apresentam um novo tópico e maneira simples e visual, com explicações diretas acompanhadas das amostras de código. Você encontrará ajuda em como organizar e projetar as páginas do seu site para que possa criar websites fantásticos e fáceis de usar. Não é necessário ter experiência!", ImageUrl = "https://livrariascuritiba.vteximg.com.br/arquivos/ids/1822310-1000-1000/LV394210.jpg?v=636833995595900000", IsPieOfTheWeek = true, ImageThumbnailUrl = "https://livrariascuritiba.vteximg.com.br/arquivos/ids/1822310-1000-1000/LV394210.jpg?v=636833995595900000" },new Pie {Id = 2, Name = "Blueberry Cheese Cake", Price = 18.95M, ShortDescription = "You'll love it!", LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg", IsPieOfTheWeek = false, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg"},
                    new Pie {Id = 3, Name = "Cheese Cake", Price = 18.95M, ShortDescription = "Plain cheese cake. Plain pleasure.", LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", IsPieOfTheWeek = false, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg"},
                    new Pie {Id = 4, Name = "Cherry Pie", Price = 15.95M, ShortDescription = "A summer classic!", LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg", IsPieOfTheWeek = false, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg"}
                };

        }
        public IEnumerable<Pie> GetAllPies()
        {
            return _pies;
        }

        public Pie GetPieByID(int pieId)
        {
            return _pies.FirstOrDefault(p => p.Id == pieId);
        }
    }
}
