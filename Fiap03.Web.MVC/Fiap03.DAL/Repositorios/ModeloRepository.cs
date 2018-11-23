﻿using Dapper;
using Fiap03.DAL.Repositorios.Interfaces;
using Fiap03.MOD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap03.DAL.Repositorios
{
    public class ModeloRepository : IModeloRepository
    {
        public void Cadastrar(ModeloMOD modelo)
        {
            throw new NotImplementedException();
        }

        public IList<ModeloMOD> Listar(int marcaId)
        {
            using (var db = ConnectionFactories.ConnectionFactory.GetConnection())
            {
                string sql = "SELECT * FROM Modelo WHERE MarcaId = @MarcaId";

                return db.Query<ModeloMOD>(sql, new { MarcaId = marcaId }).ToList();
            }
        }
    }
}