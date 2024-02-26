using System;

namespace PlaylistManager
{
    /// <summary>
    /// Represents a song in the playlist.
    /// </summary>
    class Song
    {
        /// <summary>
        /// Gets the title of the song.
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// Gets the artist of the song.
        /// </summary>
        public string Artist { get; }

        /// <summary>
        /// Gets the album associated with the song.
        /// </summary>
        public Album Album { get; }

        /// <summary>
        /// Gets the genre of the song.
        /// </summary>
        public string Genre { get; }

        /// <summary>
        /// Initializes a new instance of the Song class.
        /// </summary>
        /// <param name="title">The title of the song.</param>
        /// <param name="artist">The artist of the song.</param>
        /// <param name="album">The album associated with the song.</param>
        /// <param name="genre">The genre of the song.</param>
        public Song(string title, string artist, Album album, string genre)
        {
            Title = title;
            Artist = artist;
            Album = album;
            Genre = genre;
        }

        /// <summary>
        /// Returns a string representation of the song.
        /// </summary>
        /// <returns>A string containing the title, artist, album, and genre of the song.</returns>
        public override string ToString()
        {
            return $"Title: {Title}, Artist: {Artist}, Album: {Album}, Genre: {Genre}";
        }
    }
}
