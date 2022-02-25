using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class ArtigosData : IArtigosData
    {
        private readonly ISqlDataAccess _db;
        public ArtigosData(ISqlDataAccess db)
        {
            _db = db;
        }
        //public class CRUDModels<T> : object
        public Task<List<ArtigoModels>> GetArtigo()
        {
            string sql = "SELECT TOP 1000 [id_artigo] ,[cod_artigo] ,[descricao] ,[cod_barra] FROM [dbo].[Table]";
            return _db.LoadData<ArtigoModels, dynamic>(sql, new { });
        }
        public async Task InsertArtigo(ArtigoModels artigo)
        {
            string sql = @" INSERT INTO [dbo].[Table] ([cod_artigo], [descricao], [cod_barra]) VALUES (@cod_artigo, @descricao, @cod_barra)";

            await _db.SaveData(sql, artigo);
        }
        public async Task DeleteArtigo(ArtigoModels artigo)
        {
            string sql = @" delete from [dbo].[Table] WHERE [cod_artigo] = (@cod_artigo)";

            await _db.SaveData(sql, artigo);
           

        }
        public async Task UpdateArtigo(ArtigoModels artigo)
        {
            string sql = @" UPDATE [dbo].[Table] SET [cod_artigo] = @cod_artigo , [descricao] = @descricao, [cod_barra] =  @cod_barra WHERE [id_artigo] = (@id_artigo)";

            await _db.SaveData(sql, artigo);
        }
        
    }
}
