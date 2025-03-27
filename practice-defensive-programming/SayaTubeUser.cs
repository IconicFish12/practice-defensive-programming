using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_defensive_programming
{
    class SayaTubeUser
    {

        private int id;
        private List<SayaTubeVideo> listVideo;
        private string username;

        Random rnd = new Random();

        public SayaTubeUser(string username)
        {
            try
            {
                if (username.Length >= 100)
                {

                    Debug.Assert(username.Length >= 100);
                    throw new ArgumentOutOfRangeException("panjang Maksimal dari username adalah 200 karakter");

                }
                else if (!string.IsNullOrEmpty(username))
                {

                    Debug.Assert(!string.IsNullOrEmpty(username));
                    //throw new ArgumentNullException("username tidak boleh kosong");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error Message : {e.Message}");
            }

            this.id = rnd.Next(1, 100);
            this.username = username;
        }

        public int getTotalVideoPlayCount()
        {
            return 0;
        }

        public void addVideo(SayaTubeVideo video)
        {

        }

        public void printAllVideoPlayCount()
        {

        }
    }
}
