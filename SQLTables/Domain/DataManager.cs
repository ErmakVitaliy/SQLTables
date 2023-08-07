using SQLTables.Domain.Entity;
using SQLTables.Domain.Interfaces;

namespace SQLTables.Domain
{
    public class DataManager 
    {
        public DataManager(IBaseRepository<Author> authorRepository, IBaseRepository<Book> bookRepository, IBaseRepository<BuyBook> buyBookRepository, IBaseRepository<Buy> buyRepository, IBaseRepository<City> cityRepository, IBaseRepository<Client> clientRepository, IBaseRepository<Genre> genreRepository, IBaseRepository<BuyStep> buyStepRepository, IBaseRepository<Step> stepRepository)
        {
            AuthorRepository = authorRepository;
            BookRepository = bookRepository;
            BuyBookRepository = buyBookRepository;
            BuyRepository = buyRepository;
            CityRepository = cityRepository;
            ClientRepository = clientRepository;
            GenreRepository = genreRepository;
            BuyStepRepository = buyStepRepository;
            StepRepository = stepRepository;
        }

        public IBaseRepository<Author> AuthorRepository { get; set; }
        public IBaseRepository<Book> BookRepository { get; set; }
        public IBaseRepository<BuyBook> BuyBookRepository { get; set; }
        public IBaseRepository<Buy> BuyRepository { get; set; }
        public IBaseRepository<City> CityRepository { get; set; }
        public IBaseRepository<Client> ClientRepository { get; set; }
        public IBaseRepository<Genre> GenreRepository { get; set; }
        public IBaseRepository<BuyStep> BuyStepRepository { get; set; }
        public IBaseRepository<Step> StepRepository { get; set; }
    }
}
