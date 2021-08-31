using DateClass;
using HCF;
using IntToString;
using System;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace YakshaEvaluation_Test.TestCases
{
   public class FunctionalTests
    {
        /// <summary>
        /// Creating test output text file that store the result in boolean result
        /// </summary>
        static FunctionalTests()
        {
            if (!File.Exists("../../../../output_revised.txt"))
                try
                {
                    File.Create("../../../../output_revised.txt").Dispose();
                }
                catch (Exception)
                {

                }
            else
            {
                File.Delete("../../../../output_revised.txt");
                File.Create("../../../../output_revised.txt").Dispose();
            }
        }

        #region HCF 
        /// <summary>
        /// Test to find HCF of 2 numbers - result is returned as expected
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestFindHCF_ExpectedValue()
        {
            //Arrange
            bool res = false;
            int expected = 5;

            int n1 = 5, n2 = 10;
            
            HCFCalculation hCFCalculation = new HCFCalculation();
            //Act
            int result = hCFCalculation.FindHCF(n1, n2);

            //Assertion
            if (result == expected)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "TestFindHCF_ExpectedValue=" + res + "\n");
            return res;
        }
        #endregion

        #region DateClass
        /// <summary>
        /// Test to check MonthPart of Date, is in the range (1-12)
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestDateFun_CheckMonthRange_ExpectedValue()
        {
            ////Arrange
           bool res, expected = true;
           string strDateTime = DateTime.Today.ToString();
           
            DateClassOperations dateClassOperations
                = new DateClassOperations();

            //Act
            res = dateClassOperations.CheckMonthRange(strDateTime);

            //Assertion
            if (res == expected)
            {
                res = true;
            }

            ////final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "TestDateFun_CheckMonthRange_ExpectedValue=" + res + "\n");
            return res;
        }

        /// <summary>
        /// Test to check Given Date is in the range 
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestDateFun_CheckDayRange_ExpectedValue()
        {
            ////Arrange
            bool res, expected = true;
            string strDateTime = DateTime.Today.ToString();

            DateClassOperations dateClassOperations
                = new DateClassOperations();

            //Act
            res = dateClassOperations.CheckDayRange(strDateTime);

            //Assertion
            if (res == expected)
            {
                res = true;
            }

            ////final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "TestDateFun_CheckDayRange_ExpectedValue=" + res + "\n");
            return res;
        }

        /// <summary>
        /// Test to Find Week Day for the provided date is valid or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestDateFun_GetWeekDay_ExpectedValue()
        {
            ////Arrange
            bool res = false;
            string expected = DateTime.Today.DayOfWeek.ToString();

            DateClassOperations dateClassOperations
                = new DateClassOperations();

            //Act
            string result = dateClassOperations.GetWeekDayOfDate(DateTime.Today.ToString());

            //Assertion
            if (expected == result)
            {
                res = true;
            }

            ////final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "TestDateFun_GetWeekDay_ExpectedValue=" + res + "\n");
            return res;
        }
        #endregion

        #region IntToString

        /// <summary>
        /// Test to Write Int To String - result is returned as expected
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestWriteIntToString_ExpectedValue()
        {
            //Arrange
            bool res = false;
            string expexted = "Five Zero Zero";
            int number = 500;

            ConvertIntToString convertIntToString = new ConvertIntToString();
            //Act
            string result = convertIntToString.WriteIntToString(number);

            //Assertion
            if (result == expexted)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "TestWriteIntToString_ExpectedValue=" + res + "\n");
            return res;
        }

        #endregion
    }
}
