namespace RecordLabel.UnitTests
{
    public class AlbumTest
    {
        [Fact]
        public void WhenCreated_HasTitleAndArtistAndNoSongs()
        {
            Album stopMakingSense = new Album("Talking Heads", "Stop Making Sense");

            Assert.Equal("Talking Heads", stopMakingSense.Artist);
            Assert.Equal("Stop Making Sense", stopMakingSense.Title);
            Assert.Equal(new List<string>(), stopMakingSense.SideASongs);
            Assert.Equal(new List<string>(), stopMakingSense.SideBSongs);
        }

        // You will write additional tests for the Record class, and the Inventory Class.
        [Fact]
        public void Album_AddSong_AddsSongToCorrectList()
        {
            // Arrange
            Album stopMakingSense = new Album("Talking Heads", "Stop Making Sense");

            // Act: add 4 songs
            stopMakingSense.AddSong("Song 1");
            stopMakingSense.AddSong("Song 2");
            stopMakingSense.AddSong("Song 3");
            stopMakingSense.AddSong("Song 4");

            // Assert: Side A 4, Side B 0
            Assert.Equal(4, stopMakingSense.SideASongs.Count);
            Assert.Empty(stopMakingSense.SideBSongs);

            // Act: add 4 more songs
            stopMakingSense.AddSong("Song 5");
            stopMakingSense.AddSong("Song 6");
            stopMakingSense.AddSong("Song 7");
            stopMakingSense.AddSong("Song 8");

            // Assert: Side A 5, Side B 3
            Assert.Equal(5, stopMakingSense.SideASongs.Count);
            Assert.Equal(3, stopMakingSense.SideBSongs.Count);

            // Act: add 2 more songs
            stopMakingSense.AddSong("Song 9");
            stopMakingSense.AddSong("Song 10");

            // Assert: Side A 5, Side B 5
            Assert.Equal(5, stopMakingSense.SideASongs.Count);
            Assert.Equal(5, stopMakingSense.SideBSongs.Count);

            // Act: add 2 more songs
            stopMakingSense.AddSong("Song 11");
            stopMakingSense.AddSong("Song 12");

            // Assert: Side A 5, Side B 5, none added
            Assert.Equal(5, stopMakingSense.SideASongs.Count);
            Assert.Equal(5, stopMakingSense.SideBSongs.Count);
        }

        [Fact]
        public void Album_Songs_ReturnsListOfAllSongs()
        {
            // Arrange
            Album stopMakingSense = new Album("Talking Heads", "Stop Making Sense");
            List<string> expected = new List<string>
            {
                "Song 1", "Song 2", "Song 3", "Song 4", "Song 5",
                "Song 6", "Song 7", "Song 8", "Song 9", "Song 10"
            };

            // Act: add 10 songs
            stopMakingSense.AddSong("Song 1");
            stopMakingSense.AddSong("Song 2");
            stopMakingSense.AddSong("Song 3");
            stopMakingSense.AddSong("Song 4");
            stopMakingSense.AddSong("Song 5");
            stopMakingSense.AddSong("Song 6");
            stopMakingSense.AddSong("Song 7");
            stopMakingSense.AddSong("Song 8");
            stopMakingSense.AddSong("Song 9");
            stopMakingSense.AddSong("Song 10");

            // Act
            var actual = stopMakingSense.Songs();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Inventory_Constructor_EmptyInventoryCreated()
        {
            var myAlbums = new Inventory();
            Assert.Empty(myAlbums.Albums);
        }

    }
}