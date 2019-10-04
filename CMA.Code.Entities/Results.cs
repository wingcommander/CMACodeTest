using System;
using System.Collections;

namespace CMA.Code.Entities
{
    public class Result : IEnumerable
    {
        public string SubText { get; set; }
        public ArrayList OutPut { get; set; }
       
        public Result(string subText)
        {
            this.SubText = subText;
            this.OutPut = new ArrayList();
        }

        public Result(string subText, ArrayList output)
        {
            this.SubText = subText;
            this.OutPut = new ArrayList(output);
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }        
    }
}
