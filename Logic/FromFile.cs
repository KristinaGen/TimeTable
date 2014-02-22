namespace Logic
{
    public class FromFile
    {
        private static FromFile _instance;

        private FromFile()
        {
        }

        public static FromFile GetInstance()
        {
            return _instance ?? (_instance = new FromFile());
        }
    }
}
