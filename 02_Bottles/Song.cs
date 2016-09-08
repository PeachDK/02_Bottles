using System;
namespace _02_Bottles
{
    internal class Song
    {
        public string CountBottles(int v)
        {
            switch (v)
            {


                case 0:

                    return " No more bottles of beer on the wall.";

                    break;

                case 1:

                    return "1 bottle of beer on the wall."
                + " 1 bottle of beer."
                + " Take one down and pass it around."
                + " No more bottles of beer on the wall.";
                
                    break;


                case 2:

                    return "2 bottles of beer on the wall."
                + " 2 bottles of beer."
                + " Take one down and pass it around."
                + " 1 bottle of beer on the wall."
                + " 1 bottle of beer on the wall."
                + " 1 bottle of beer."
                + " Take one down and pass it around."
                + " No more bottles of beer on the wall.";

                    break;


                case 3:

                    return "3 bottles of beer on the wall."
                  + " 3 bottles of beer."
                  + " Take one down and pass it around."
                  + " 2 bottles of beer on the wall."
                  + " 2 bottles of beer on the wall."
                  + " 2 bottles of beer."
                  + " Take one down and pass it around."
                  + " 1 bottle of beer on the wall."
                  + " 1 bottle of beer on the wall."
                  + " 1 bottle of beer."
                  + " Take one down and pass it around."
                  + " No more bottles of beer on the wall.";

                    break;

                default:

                  

                    break;


            }



            return "0";

            

        }




    }
}