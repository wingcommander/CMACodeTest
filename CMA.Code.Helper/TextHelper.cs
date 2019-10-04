using System.Text;

namespace CMA.Code.Helper
{
  public static class TextHelper
    {       
        public static int Match(int startPos, string text, string subText)
        {
            var match = new StringBuilder(subText.Length);

            for (int iteration = startPos - 1; iteration < text.Length; iteration++)
            {
                match.Append(text[iteration]);
               
                if(match.ToString().ToLower() == subText.ToLower())
                {
                    // return non-zero based position
                    return (iteration + 1 - subText.Length + 1);                                      
               }              
            }

            // <no matches>
            return -1;
        }
    }
}
