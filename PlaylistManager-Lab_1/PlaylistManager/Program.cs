using System;

namespace PlaylistManager
{
    /// <summary>
    /// The main program class for managing a playlist.
    /// </summary>
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            // Create an instance of the PlaylistManager class
            PlaylistManager playlistManager = new PlaylistManager();

            // Main loop for the Playlist Manager
            while (true)
            {
                Console.WriteLine("Playlist Manager");
                Console.WriteLine("1. Add Song");
                Console.WriteLine("2. Remove Song");
                Console.WriteLine("3. Retrieve Song");
                Console.WriteLine("4. Display Playlist");
                Console.WriteLine("5. Shuffle Playlist");
                Console.WriteLine("6. Exit");
                Console.Write("Select an option: ");

                // Get the user's choice
                string choice = Console.ReadLine();

                // Perform actions based on user's choice
                switch (choice)
                {
                    case "1":
                        // Add a new song to the playlist
                        Console.Write("Enter the song title: ");
                        string songTitle = Console.ReadLine();
                        Console.Write("Enter the artist: ");
                        string artist = Console.ReadLine();
                        Console.Write("Enter the album title: ");
                        string albumTitle = Console.ReadLine();
                        Console.Write("Enter the release date (YYYY-MM-DD): ");
                        DateTime releaseDate = DateTime.Parse(Console.ReadLine());
                        Console.Write("Enter the genre: ");
                        string genre = Console.ReadLine();

                        Song newSong = new Song(songTitle, artist, new Album(albumTitle, releaseDate), genre);
                        playlistManager.AddSong(newSong);
                        Console.WriteLine("Song added to the playlist.");
                        break;

                    case "2":
                        // Remove a song from the playlist
                        Console.Write("Enter the song title to remove: ");
                        string titleToRemove = Console.ReadLine();
                        if (playlistManager.RemoveSong(titleToRemove))
                            Console.WriteLine("Song removed from the playlist.");
                        else
                            Console.WriteLine("Song not found in the playlist.");
                        break;

                    case "3":
                        // Retrieve information about a specific song
                        Console.Write("Enter the song title to retrieve: ");
                        string titleToRetrieve = Console.ReadLine();
                        Song retrievedSong = playlistManager.RetrieveSong(titleToRetrieve);
                        if (retrievedSong != null)
                            Console.WriteLine($"Song found: {retrievedSong}");
                        else
                            Console.WriteLine("Song not found in the playlist.");
                        break;

                    case "4":
                        // Display the entire playlist
                        playlistManager.DisplayPlaylist();
                        break;

                    case "5":
                        // Shuffle the playlist
                        playlistManager.ShufflePlaylist();
                        Console.WriteLine("Playlist shuffled.");
                        break;

                    case "6":
                        // Exit the Playlist Manager
                        Console.WriteLine("Exiting Playlist Manager. Goodbye!");
                        return;

                    default:
                        // Invalid option
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
