﻿using MongoDB.Driver;
using Poke.Mongo.Api.Models;
using Poke.Mongo.Api.Models.Documents;
using System.Collections.Generic;
using System.Linq;

namespace Poke.Mongo.Api.Services
{
    public class UsuarioService
    {
        private readonly IMongoCollection<Usuario> _usuarios;

        public UsuarioService(IPokeDatabaseSettings settings)
        {
            var client = new MongoClient(MongoClientSettings.FromConnectionString(settings.ConnectionString));
            var database = client.GetDatabase(settings.DatabaseName);

            _usuarios = database.GetCollection<Usuario>(settings.UsuarioCollectionName);
        }

        /// <summary>
        /// lista todos os usuarios cadastrados
        /// </summary>
        /// <returns></returns>
        public List<Usuario> Get() => _usuarios.Find(book => true).ToList();

        /// <summary>
        /// obtem dados do usuario apartir do id
        /// </summary>
        /// <param name="id">codigo do usuario</param>
        /// <returns></returns>
        public Usuario Get(string id) => _usuarios.Find<Usuario>(book => book.Id == id).FirstOrDefault();

        /// <summary>
        /// cria um novo usuario
        /// </summary>
        /// <param name="usuario">dados do usuario</param>
        /// <returns></returns>
        public Usuario Create(Usuario usuario)
        {
            _usuarios.InsertOne(usuario);
            return usuario;
        }

        /// <summary>
        /// atualiza um objeto apartir do usuario e id
        /// </summary>
        /// <param name="id">codigo do usuario</param>
        /// <param name="usuario">usuario</param>
        public void Update(string id, Usuario usuario) => _usuarios.ReplaceOne(book => book.Id == id, usuario);

        /// <summary>
        /// deletar usuario apartir de objeto
        /// </summary>
        /// <param name="usuario">usuario</param>
        public void Remove(Usuario usuario) => _usuarios.DeleteOne(book => book.Id == usuario.Id);

        /// <summary>
        /// deleta um usuario apartir do id
        /// </summary>
        /// <param name="id">id do usuario</param>
        public void Remove(string id) => _usuarios.DeleteOne(book => book.Id == id);
    }
}
