namespace BlazorServerCRUD.Data
{
    public interface IGameService
    {
        List<Game> Games { get; set; }
        Task LoadGames();
        Task<Game> GetSingleGame(int id);
        Task CreateGame(Game game);
        Task UpdateGame(Game game, int id);
        Task DeleteGame(int id);
    }
}
