namespace IMDB
{
    public class FavoriteList
    {
        private string favoriteListName;
        public Movie[] favoriteList = new Movie[100];
        private User creatorUserOfFavoriteList;

        public FavoriteList(string favoriteListName, User user)
        {
            this.favoriteListName = favoriteListName;
            creatorUserOfFavoriteList = user;
        }
        public string FavoriteListName { get { return favoriteListName; } set { favoriteListName = value; } }
    }
}
