using DateClass;
using HCF;
using IntToString;
using System;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace YakshaEvaluation_Test.TestCases
{
    public class ExceptionalTests
    {
        /// <summary>
        /// Creating test output text file that store the result in boolean result
        /// </summary>
        static ExceptionalTests()
        {
            if (!File.Exists("../../../../output_exception_revised.txt"))
                try
                {
                    File.Create("../../../../output_exception_revised.txt").Dispose();
                }
                catch (Exception)
                {

                }
            else
            {
                File.Delete("../../../../output_exception_revised.txt");
                File.Create("../../../../output_exception_revised.txt").Dispose();
            }
        }

        #region HCF

        /// <summary>
        /// Test to find HCF for negative values 
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestFindHCFFor_NegativeValues()
        {

            //Arrange
            bool res = false;

            int n1 = -5, n2 = -10;

            HCFCalculation hCF = new HCFCalculation();
            int result = hCF.FindHCF(n1, n2);

            //Act
            //Assertion
            if (result == 0)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "TestFindHCFFor_NegativeValues=" + res + "\n");
            return res;
        }

        /// <summary>
        /// Test to find HCF of 2 Max numbers result is returned as expected
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestFindHCF_ForMaxValues()
        {
            //Arrange
            bool res = false;
            int expexted = 0;

            int n1 = 2147483647, n2 = 2147483647;

            HCFCalculation hCFCalculation = new HCFCalculation();
            //Act
            int result = hCFCalculation.FindHCF(n1, n2);

            //Assertion
            if (result == expexted)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "TestFindHCF_ForMaxValues=" + res + "\n");
            return res;
        }
        #endregion

        #region DateClass

        /// <summary>
        /// Test to check Month range - For Null value 
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestDateFun_CheckMonthRange_ForNullValue()
        {
            ////Arrange
            bool res = false,  expected = false; ;

            DateClassOperations dateClassOperations
                = new DateClassOperations();

            //Act
           bool result = dateClassOperations.CheckMonthRange(null);

            //Assertion
            if (result == expected)
            {
                res = true;
            }

            ////final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "TestDateFun_CheckMonthRange_ForNullValue=" + res + "\n");
            return res;
        }

        /// <summary>
        /// Test to check Month range - For Invalid Date Foramt 
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestDateFun_CheckMonthRange_ForInvalidDate()
        {
            ////Arrange
            bool expected = false, res = false;
            string strDateTime = "123/234/0000";

            DateClassOperations dateClassOperations
                = new DateClassOperations();

            //Act
            bool result = dateClassOperations.CheckMonthRange(strDateTime);

            //Assertion
            if (result == expected)
            {
                res = true;
            }

            ////final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "TestDateFun_CheckMonthRange_ForInvalidDate=" + res + "\n");
            return res;
        }

        /// <summary>
        /// Test to check Month range - For string value 
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestDateFun_CheckMonthRange_ForString()
        {
            ////Arrange
            bool res = false, expected = false;
            string strDateTime = "thisisstring";

            DateClassOperations dateClassOperations
                = new DateClassOperations();

            //Act
            bool result = dateClassOperations.CheckMonthRange(strDateTime);

            //Assertion
            if (result == expected)
            {
                res = true;
            }

            ////final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "TestDateFun_CheckMonthRange_ForString=" + res + "\n");
            return res;
        }

        /// <summary>
        /// Test to check Date range - For Null value 
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestDateFun_CheckDayRange_ForNullValue()
        {
            ////Arrange
            bool res = false, expected = false;

            DateClassOperations dateClassOperations
                = new DateClassOperations();

            //Act
            bool result = dateClassOperations.CheckDayRange(null);

            //Assertion
            if (result == expected)
            {
                res = true;
            }

            ////final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "TestDateFun_CheckDayRange_ForNullValue=" + res + "\n");
            return res;
        }

        /// <summary>
        /// Test to check Date range - For Invalid Date Foramt 
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestDateFun_CheckDayRange_ForInvalidDate()
        {
            ////Arrange
            bool res = false, expected = false;
            string strDateTime = "123/234/0000";

            DateClassOperations dateClassOperations
                = new DateClassOperations();

            //Act
            bool result = dateClassOperations.CheckDayRange(strDateTime);

            //Assertion
            if (result == expected)
            {
                res = true;
            }

            ////final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "TestDateFun_CheckDayRange_ForInvalidDate=" + res + "\n");
            return res;
        }

        /// <summary>
        /// Test to check Date range - For string value 
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestDateFun_CheckDayRange_ForString()
        {
            ////Arrange
            bool res = false, expected = false;
            string strDateTime = "samplestring";

            DateClassOperations dateClassOperations
                = new DateClassOperations();

            //Act
            bool result = dateClassOperations.CheckDayRange(strDateTime);

            //Assertion
            if (result == expected)
            {
                res = true;
            }

            ////final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "TestDateFun_CheckDayRange_ForString=" + res + "\n");
            return res;
        }

        /// <summary>
        /// Test to Find Week Day for the Null Value
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestDateFun_GetWeekDay_ForNullValue()
        {
            ////Arrange
            bool res = false;

            DateClassOperations dateClassOperations
                = new DateClassOperations();

            //Act
            string result = dateClassOperations.GetWeekDayOfDate(null);

            //Assertion
            if (result == "Format Exception Occurred")
            {
                res = true;
            }

            ////final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "TestDateFun_GetWeekDay_ForNullValue=" + res + "\n");
            return res;
        }

        /// <summary>
        /// Test to Find Week Day For Invalid Date Foramt
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestDateFun_GetWeekDay_ForInvalidDate()
        {
            ////Arrange
            bool res = false;
            string strDateTime = "123/234/0000";

            DateClassOperations dateClassOperations
                = new DateClassOperations();

            //Act
            string result = dateClassOperations.GetWeekDayOfDate(strDateTime);

            //Assertion
            if (result == "Format Exception Occurred")
            {
                res = true;
            }

            ////final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "TestDateFun_GetWeekDay_ForInvalidDate=" + res + "\n");
            return res;
        }

        /// <summary>
        /// Test to Find Week Day - For string value 
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestDateFun_GetWeekDay_ForString()
        {
            ////Arrange
            bool res = false;
            string strDateTime = "TestString";

            DateClassOperations dateClassOperations
                = new DateClassOperations();

            //Act
            string result = dateClassOperations.GetWeekDayOfDate(strDateTime);

            //Assertion
            if (result == "Format Exception Occurred")
            {
                res = true;
            }

            ////final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "TestDateFun_GetWeekDay_ForString=" + res + "\n");
            return res;
        }
        #endregion

        #region WriteIntToString
        /// <summary>
        /// Test to Write Int To String - for Negative value
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestWriteIntToString_ForNegativeValue()
        {
            //Arrange
            bool res = false;
            int number = -500;
            ConvertIntToString convertIntToString = new ConvertIntToString();
            
            //Act
            string result = convertIntToString.WriteIntToString(number);

            //Assertion
            if (result == null)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "TestWriteIntToString_ForNegativeValue=" + res + "\n");
            return res;
        }
        #endregion
    }
}
