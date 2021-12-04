namespace Common
{
    public static class StringHandler
    {
        public static string SpaceInsert(this string source)
        {
            string resoult = string.Empty;

            if (!string.IsNullOrWhiteSpace(source))
            {
                foreach (var letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        if (!string.IsNullOrEmpty(resoult))
                        {
                            resoult = resoult.Trim();
                            resoult += " ";
                        }
                        
                    }
                    resoult += letter;
                }
                
            }
            return resoult;
        }


    }
}
