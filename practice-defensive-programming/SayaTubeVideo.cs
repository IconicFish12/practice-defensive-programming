using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_defensive_programming
{
    class SayaTubeVideo
    {

        private int id, playCount = 0;
        private string title;

        Random rnd = new Random();

        public SayaTubeVideo(string title)
        {
            try
            {
                checked
                {

                    if (title.Length >= 200)
                    {

                        Debug.Assert(title.Length >= 200);
                        throw new ArgumentOutOfRangeException("panjang Maksimal dari judul video adalah 200 karakter");

                    }
                    else if (string.IsNullOrEmpty(title))
                    {

                        Debug.Assert(string.IsNullOrEmpty(title));
                        throw new ArgumentNullException("judul video tidak boleh kosong");

                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error Message : {e.Message}");
            }

            this.id = rnd.Next(1 , 5);
            this.title = title;
        }

        public void increasePlayCount(int count)
        {

            try
            {

                checked
                {
                    
                    if (count >= 25_000_000)
                    {

                        Debug.Assert(count >= 25_000_000);
                        throw new OverflowException("Total Play Count tidak boleh lebih dari 25000000");

                    }
                    else
                    {

                        playCount += count;

                    }

                }
                

            }
            catch (Exception e)
            {
                Console.WriteLine($"Error Message : {e.Message}");
            }

        }

        public void printAllVideo()
        {
            Console.WriteLine($"Judul Video : {title}, dengan id {id}, dan memiliki play count sebesar {playCount} menit");
        }

        public int getPlaycount()
        {
            return this.playCount;
        }

        public string getTitle()
        {
            return this.title;
        }
    }
}
