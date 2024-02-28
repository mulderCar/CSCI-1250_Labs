using System;

namespace PlaylistManager
{
    /// <summary>
    /// Represents an album associated with a song.
    /// </summary>
    class Album
    {
        /// <summary>
        /// Gets the title of the album.
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// Gets the release date of the album.
        /// </summary>
        public DateTime ReleaseDate { get; }

        /// <summary>
        /// Initializes a new instance of the Album class.
        /// </summary>
        /// <param name="title">The title of the album.</param>
        /// <param name="releaseDate">The release date of the album.</param>
        public Album(string title, DateTime releaseDate)
        {
            Title = title;
            ReleaseDate = releaseDate;
        }

        /// <summary>
        /// Returns a string representation of the album.
        /// </summary>
        /// <returns>A string containing the title and release date of the album.</returns>
        public override string ToString()
        {
            return $"Title: {Title}, Release Date: {ReleaseDate:yyyy-MM-dd}";
        }
    }
}
