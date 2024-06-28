namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        enum Languages
        {
            English,
            Spanish,
            French
        }

        static string GetOfficialName(Languages lang)
        {
            switch (lang)
            {
                case Languages.English:
                    return "English";
                case Languages.Spanish:
                    return "Español";
                case Languages.French:
                    return "Français";
                // ... other cases
                default:
                    return "Unknown";
            }
        }
    }
}
