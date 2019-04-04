using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audiotheque
{
    class IntelligentPlaylist : Playlist
    {
        private List<Artist> artistList;
        private int lowerRating;
        private MusicLibrary library;


        public IntelligentPlaylist(string name, MusicLibrary library): base(name) {

            this.library = library;
        }

        public void addArtist(Artist artist) {

        }

        public void clearArtists() { }

        public void setLowestRating(int lowestRating) {

        }
    }
}
