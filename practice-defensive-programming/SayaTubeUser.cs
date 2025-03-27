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
                checked
                {
                    if (username.Length >= 100)
                    {

                        Debug.Assert(username.Length >= 100);
                        throw new ArgumentOutOfRangeException("panjang Maksimal dari username adalah 200 karakter");

                    }
                    else if (string.IsNullOrEmpty(username))
                    {

                        Debug.Assert(string.IsNullOrEmpty(username));
                        throw new ArgumentNullException("username tidak boleh kosong");

                    }
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
            int result = 0;

            foreach (SayaTubeVideo data in listVideo)
            {
                result += data.getPlaycount();
            }

            return result;
        }

        public void addVideo(SayaTubeVideo video)
        {
            try
            {
                if (video == null)
                {

                    Debug.Assert(video == null);
                    throw new ArgumentNullException("Data Video harus diisi");

                }else if (video.getPlaycount() > int.MaxValue)
                {

                    Debug.Assert(video.getPlaycount() > int.MaxValue);
                    throw new OverflowException("Total Play Count tidak boleh lebih dari 25000000");

                }else
                {
                    listVideo.Add(video);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error Message : {e.Message}");
            }
        }

        public void printAllVideoPlayCount()
        {
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine($"Username : {username}");

            for (int i = 0; i < listVideo.Count; i++)
            {
                Console.WriteLine($"Video {i+1} judul : {listVideo[i].getTitle}");
            }
        }
    }
}
