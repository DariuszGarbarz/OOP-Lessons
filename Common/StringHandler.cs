namespace Common
{
    public static class StringHandler
    {
        public static string SpaceInsert(this string source)
        {

            var result = !string.IsNullOrWhiteSpace(source) ? CheckString(source) : string.Empty;
            
            return result;
        }

        public static string CheckString(string source) 
        { 
                string result = string.Empty;
                foreach (var letter in source)
                {
                    if (char.IsUpper(letter) && !string.IsNullOrEmpty(result))
                    {
                            result = result.Trim();
                            result += " ";  
                    }
                    result += letter;
                }
                return result;
        }

    }
}
