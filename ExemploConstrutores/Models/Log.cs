namespace ExemploConstrutores.Models
{
    public class Log
    {
        private static Log _log;
        public string PropriedadeLog { get; set; }
        //construtor privado uma classe que pode ser chamada varias vezes (singleton)
        private Log()
        {

        }

        public static Log GetInstance()
        {
            if (_log == null)
            {
                _log = new Log();
            }
            return _log;
        }
    }

}