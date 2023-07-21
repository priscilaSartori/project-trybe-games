namespace TrybeGames;

public class TrybeGamesDatabase
{
  public List<Game> Games = new List<Game>();

  public List<GameStudio> GameStudios = new List<GameStudio>();

  public List<Player> Players = new List<Player>();

  // 4. Crie a funcionalidade de buscar jogos desenvolvidos por um estúdio de jogos
  public List<Game> GetGamesDevelopedBy(GameStudio gameStudio)
  {
    var filteredGames = from Game in Games
                        where Game.DeveloperStudio == gameStudio.Id
                        select Game;
    return filteredGames.ToList();
  }

  // 5. Crie a funcionalidade de buscar jogos jogados por uma pessoa jogadora
  public List<Game> GetGamesPlayedBy(Player player)
  {
    var filteredGames = from Game in Games
                        where Game.Players.Contains(player.Id)
                        select Game;
    return filteredGames.ToList();
  }

  // 6. Crie a funcionalidade de buscar jogos comprados por uma pessoa jogadora
  public List<Game> GetGamesOwnedBy(Player playerEntry)
  {
    var filteredGames = from Game in Games
                        where playerEntry.GamesOwned.Contains(Game.Id)
                        select Game;
    return filteredGames.ToList();
  }


  // 7. Crie a funcionalidade de buscar todos os jogos junto do nome do estúdio desenvolvedor
  public List<GameWithStudio> GetGamesWithStudio()
  {
    var filteredGames = from game in Games
                        from gameStudio in GameStudios
                        where game.DeveloperStudio == gameStudio.Id
                        select new GameWithStudio
                        {
                          GameName = game.Name,
                          StudioName = gameStudio.Name,
                          NumberOfPlayers = game.Players.Count
                        };
    return filteredGames.ToList();
  }

  // 8. Crie a funcionalidade de buscar todos os diferentes Tipos de jogos dentre os jogos cadastrados
  public List<GameType> GetGameTypes()
  {
    var filteredGames = from game in Games
                        select game.GameType;
    return filteredGames.Distinct().ToList();
  }

  // 9. Crie a funcionalidade de buscar todos os estúdios de jogos junto dos seus jogos desenvolvidos com suas pessoas jogadoras
  public List<StudioGamesPlayers> GetStudiosWithGamesAndPlayers()
  {
    // Implementar
    throw new NotImplementedException();
  }

}
