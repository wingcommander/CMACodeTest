using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CMA.Code.Helper;
using CMA.Code.Entities;
using CMA.Code.Processor;

namespace CMA.Code.Unit.Tests
{
    [TestClass]
    public class UnitTest
    {

        public static string text;

        public UnitTest()
        {
           
        }

        private TestContext testContextInstance;

       
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
      
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {

            text = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea";
        }
        
        #endregion

        [TestMethod]
        public void AcceptanceCriteriaOne()
        {
            const string subText = "Polly";

            var expectedResults = new int[3]{1,26,51};
            var results = new int[3];

            for (int i = 0; i < results.Length; i++)
            {
                int startPosition = expectedResults[i];
                results[i] = TextHelper.Match(startPosition, text, subText);
            }         

            CollectionAssert.AreEqual(expectedResults, results);
        }

        [TestMethod]
        public void AcceptanceCriteriaTwo()
        {
            const string subText = "polly";

            var expectedResults = new int[3] { 1, 26, 51 };
            var results = new int[3];

            for (int i = 0; i < results.Length; i++)
            {
                int startPosition = expectedResults[i];
                results[i] = TextHelper.Match(startPosition, text, subText);
            }

            CollectionAssert.AreEqual(expectedResults, results);
        }

        [TestMethod]
        public void AcceptanceCriteriaThree()
        {
            const string subText = "ll";

            var expectedResults = new int[5] { 3, 28, 53, 78, 82 };
            var results = new int[5];

            for(int i = 0; i < results.Length; i++ )
            {
                int startPosition = expectedResults[i];
                results[i] = TextHelper.Match(startPosition, text, subText);              
            }
           
            CollectionAssert.AreEqual(expectedResults, results);
        }

        [TestMethod]
        public void AcceptanceCriteriaFour()
        {
            const string subText = "Ll";

            var expectedResults = new int[5] { 3, 28, 53, 78, 82 };
            var results = new int[5];

            for (int i = 0; i < results.Length; i++)
            {
                int startPosition = expectedResults[i];
                results[i] = TextHelper.Match(startPosition, text, subText);
            }

            CollectionAssert.AreEqual(expectedResults, results);
        }

        [TestMethod]
        public void AcceptanceCriteriaFive()
        {
            const string subText = "X";
            const int expectedResults = -1;

            int result = TextHelper.Match(1, text, subText);

            Assert.AreEqual(expectedResults, result);
        }

        [TestMethod]
        public void AcceptanceCriteriaSix()
        {
            const string subText = "Polx";
            const int expectedResults = -1;            
           
            int result = TextHelper.Match(1, text, subText);
            
            Assert.AreEqual(expectedResults, result);
        }

        

        [TestMethod]
        public void AcceptanceCriteriaAll()
        {
            IList<Result> matches = new List<Result>();
            IList<Result> expectedResults = new List<Result>();

            matches.Add(new Result("Polly"));
            matches.Add(new Result("polly"));
            matches.Add(new Result("ll"));
            matches.Add(new Result("Ll"));
            matches.Add(new Result("X"));
            matches.Add(new Result("Polx"));           

            expectedResults.Add(new Result("Polly", new ArrayList(new int[3] {1,26,51})));
            expectedResults.Add(new Result("polly", new ArrayList(new int[3] { 1, 26, 51 })));
            expectedResults.Add(new Result("ll", new ArrayList(new int[5] { 3, 28, 53, 78, 82 })));
            expectedResults.Add(new Result("Ll", new ArrayList(new int[5] { 3, 28, 53, 78, 82 })));
            expectedResults.Add(new Result("X"));
            expectedResults.Add(new Result("Polx"));            
           
            var processor = new TextProcessor();

            IList results = processor.MatchText(text, matches);                        

            //Tried to use CollectionAssert.AreEqual here sometimes fails erroneously when passed a structure containing a nested structure
            //CollectionAssert.AreEqual((ICollection)expectedResults, (ICollection)results);

            int i = 0;

            foreach (Result result in results)
            {
                foreach (int outPut in result.OutPut)
                {
                    Assert.AreEqual(outPut, expectedResults[i].OutPut[result.OutPut.IndexOf(outPut)]);
                }
                i++;
            }
        }        
    }
}