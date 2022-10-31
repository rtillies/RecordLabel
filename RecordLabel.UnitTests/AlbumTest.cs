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
    }
}