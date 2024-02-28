using System;
using System.Collections.Generic;

namespace PlaylistManager
{
    /// <summary>
    /// Manages a playlist of songs.
    /// </summary>
    class PlaylistManager
    {
        private List<Song> playlist;

        /// <summary>
        /// Initializes a new instance of the PlaylistManager class.
        /// </summary>
        public PlaylistManager()
        {
            playlist = new List<Song>();
        }

        /// <summary>
        /// Adds a song to the playlist.
        /// </summary>
        /// <param name="song">The song to be added.</param>
        public void AddSong(Song song)
        {
            playlist.Add(song);
        }

        /// <summary>
        /// Removes a song from the playlist based on its title.
        /// </summary>
        /// <param name="title">The title of the song to be removed.</param>
        /// <returns>True if the song is removed, false if the song is not found in the playlist.</returns>
        public bool RemoveSong(string title)
        {
            Song songToRemove = playlist.Find(s => s.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (songToRemove != null)
            {
                playlist.Remove(songToRemove);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retrieves a song from the playlist based on its title.
        /// </summary>
        /// <param name="title">The title of the song to be retrieved.</param>
        /// <returns>The song with the specified title, or null if not found.</returns>
        public Song RetrieveSong(string title)
        {
            return playlist.Find(s => s.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Displays the entire playlist.
        /// </summary>
        public void DisplayPlaylist()
        {
            Console.WriteLine("\nPlaylist:");
            if (playlist.Count == 0)
                Console.WriteLine("No songs in the playlist.");
            else
            {
                foreach (var song in playlist)
                {
                    Console.WriteLine($"Title: {song.Title}, Artist: {song.Artist}, Album: {song.Album}");
                }
            }
        }

        /// <summary>
        /// Shuffles the order of songs in the playlist.
        /// </summary>
        public void ShufflePlaylist()
        {
            Random random = new Random();
            int n = playlist.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Song value = playlist[k];
                playlist[k] = playlist[n];
                playlist[n] = value;
            }
        }
    }
}
