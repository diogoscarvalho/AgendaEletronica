using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Configuration;
using System.Threading.Tasks;

namespace AgendaEletronica
{
    public class MongoDB
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["connectionStringMongo"].ConnectionString;
        protected static IMongoClient _client;
        protected static IMongoDatabase _database;

        public MongoDB()
        {
            _client = new MongoClient(connectionString);
        }

        public T Obter<T>(Func<T, bool> expressao) where T : class
        {
            _database = _client.GetDatabase("AgendaEletronica");

            return _database.GetCollection<T>(typeof(T).GetType().Name.ToLower()).AsQueryable().Where(expressao).SingleOrDefault();
        }

        public IQueryable<T> ObterTodos<T>() where T : class
        {
            _database = _client.GetDatabase("AgendaEletronica");

            return _database.GetCollection<T>(typeof(T).GetType().Name.ToLower()).AsQueryable();
        }

        public async void Inserir<T>(T objeto) where T : class
        {
            _database = _client.GetDatabase("AgendaEletronica");

            await _database.GetCollection<T>(typeof(T).GetType().Name.ToLower()).InsertOneAsync(objeto);
        }

        public async void Deletar<T>(FilterDefinition<T> filtro) where T : class
        {
            _database = _client.GetDatabase("AgendaEletronica");
            await _database.GetCollection<T>(typeof(T).GetType().Name.ToLower()).DeleteOneAsync(filtro);
        }

        public async void Salvar<T>(T objeto) where T : class
        {
            _database = _client.GetDatabase("AgendaEletronica");
            await _database.GetCollection<T>(typeof(T).GetType().Name.ToLower()).InsertOneAsync(objeto);
        }
    }
}