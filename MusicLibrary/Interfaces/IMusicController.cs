using System.Collections.Generic;
using MusicLibrary.Models;

namespace MusicLibrary.Interfaces
{
    public interface IMusicController
    {
        /// <summary>
        /// Gets a list of all Movies
        /// </summary>
        /// <returns></returns>
        List<Movie> GetMoviesList();
        
        /// <summary>
        /// Gets a list of all movies which has matching name parameter
        /// </summary>
        /// <param name="name">Movie name</param>
        /// <returns>List of all movies that match the movie name</returns>
        List<Movie> GetMovies(string movieName);
        
        /// <summary>
        /// Gets a list of all Songs related to that movie
        /// </summary>
        /// <param name="movieId"></param>
        /// <param name="movieName"></param>
        /// <returns></returns>
        List<Song> GetSongsList(int movieId, string movieName);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="songName"></param>
        /// <returns></returns>
        List<Song> GetSongs(string songName);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="songId"></param>
        /// <returns></returns>
        Song GetSong(int songId);


    }
}
