using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using CMA.Code.Entities;
using CMA.Code.Helper;

namespace CMA.Code.Processor
{
    public class TextProcessor
    {
        public IList MatchText(string inputText, IList<Result> selectedMatches )
        {

            foreach (Result result in selectedMatches)
            {
                for (int startPosition = 1; startPosition <= inputText.Length;)
                {         
                    int position =  TextHelper.Match(startPosition, inputText, result.SubText);

                    if (position != -1)
                    {
                        result.OutPut.Add(position);                        
                        startPosition += result.SubText.Length;
                    }
                    else
                    {
                        startPosition++;
                    }
                }
            }

            return (IList) selectedMatches;
        }       
    }
}
