
namespace DataAccessLibrary
{
   public interface IArtigosData
    {
       
        Task<List<ArtigoModels>> GetArtigo();
        Task InsertArtigo(ArtigoModels artigo);
        Task UpdateArtigo(ArtigoModels artigo);
        Task DeleteArtigo(ArtigoModels artigo);
        
    }
}