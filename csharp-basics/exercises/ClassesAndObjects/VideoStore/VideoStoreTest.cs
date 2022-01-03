using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    internal class VideoStoreTest
    {
        private VideoStore _videoStore;
        public string matrix = "The Matrix";
        public string godfather = "Godfather II";
        public string starWarsEpIV = "Star Wars Episode IV: A New Hope";

        public VideoStoreTest()
        {
            _videoStore = new VideoStore();
        }

        public void TestVideoStore()
        {
            
            _videoStore.AddVideo(matrix);
            _videoStore.AddVideo(godfather);
            _videoStore.AddVideo(starWarsEpIV);

            _videoStore.TakeUsersRating(3, matrix);
            _videoStore.TakeUsersRating(4, matrix);
            _videoStore.TakeUsersRating(2, godfather);
            _videoStore.TakeUsersRating(4, starWarsEpIV);
            _videoStore.TakeUsersRating(5, godfather);
            _videoStore.TakeUsersRating(3, starWarsEpIV);

            _videoStore.Checkout(matrix);
            _videoStore.Checkout(godfather);
            _videoStore.ReturnVideo(matrix);
            _videoStore.Checkout(starWarsEpIV);
            _videoStore.ReturnVideo(godfather);
            _videoStore.ReturnVideo(starWarsEpIV);

            _videoStore.Checkout(godfather);

            _videoStore.ListInventory();
        }
    }
}
