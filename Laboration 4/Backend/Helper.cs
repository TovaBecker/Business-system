using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Laboration_4.Backend
{
    class Helper
    {
        public static bool  dataFileCheck(string path)
        {
            //Check if file exsist
            if (!File.Exists(path))
            {
                //Create file
                using (var myFile = File.Create(path))
                {
                    //Return false if file do not exist
                    return false;
                }
            }
            else
            {
                try
                {
                    //Check if file is availibel for the program
                    using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None))
                    {
                        //Close the program
                        stream.Close();
                    }
                }
                catch (IOException)
                {
                    //Thor a error to show for the user that the file is not availible
                    throw new Exception("Filen är inte tillgänglig.\n" +
                        "Programmet kommer avslutas.");
                }
            }
            return true;
        }

        public static Type GetType(string type)
        {
            if (type == "Bok")
                return Type.Bok;
            else if (type == "DVD")
                return Type.DVD;
            else if (type == "Spel")
                return Type.Spel;

            throw new Exception("Type does not exists");

        }

        public static Status GetStatus(string status)
        {
            if (status == "InBasket")
                return Status.InBasket;
            else if (status == "Bought")
                return Status.Bought;
            else if (status == "Repuchased")
                return Status.Repuchased;

            throw new Exception("Status does not exists");

        }

        public static int ConvertInteger(string value)
        {
            //Check if value is a int value or set it too zero
            try
            {
                return value == "" ? 0 : Convert.ToInt32(value);
            }
            catch (FormatException)
            {
                return 0;
            }
        }

        public static double ConvertDouble(string value)
        {
            //Check if value is a int value or set it too zero
            try
            {
                return value == "" ? 0 : Convert.ToDouble(value);
            }
            catch (FormatException)
            {
                return 0;
            }
        }

        public static DateTime ConvertDate(string value)
        {
            //Check if value is a int value or set it too zero
            try
            {
                return value == "" ? DateTime.MinValue : Convert.ToDateTime(value);
            }
            catch (FormatException)
            {
                return DateTime.MinValue;
            }
        }

    }
}
