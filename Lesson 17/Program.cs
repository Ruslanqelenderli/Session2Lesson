namespace Lesson_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {


                //FormatException
                //int value = int.Parse(Console.ReadLine());

                //NullReferenceException
                //string str = null;
                //str.Trim();

                //DivideByZeroException
                //int a = 5;
                //int b = 0;
                //int c = a / b;
                var directory = "C:\\Users\\User\\Desktop\\ExceptionLogs";
                var fileName = "error.txt";
                var filePath = Path.Combine(directory, fileName);
                try
                {
                    int a = 5;
                    int b = 0;
                    int c = a / b;
                }
                catch (DivideByZeroException ex)
                {
                    throw new MyException("MY exception is working.",ex);
                }
                catch (NullReferenceException ex)
                {

                }
                catch (Exception ex)
                {

                }

                Console.WriteLine("Hello, World!");
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static void WriteLog(string path, Exception ex)
        {
            // var fileExistsResult = File.Exists(path);

            File.AppendAllText(path, $"\n{DateTime.Now.ToString("dd.MM.yyyy :HH,mm,ss")}\n" + ex.ToString());

        }
    }
}
