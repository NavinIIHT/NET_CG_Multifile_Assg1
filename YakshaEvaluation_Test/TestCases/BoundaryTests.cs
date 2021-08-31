using System;
using System.IO;
using System.Threading.Tasks;
using Xunit;
using IntToString;
using DateClass;
using HCF;

namespace YakshaEvaluation_Test.TestCases
{
    public class BoundaryTests
    {
        /// <summary>
        /// Creating test output text file that store the result in boolean result
        /// </summary>
        static BoundaryTests()
        {
            if (!File.Exists("../../../../output_boundary_revised.txt"))
                try
                {
                    File.Create("../../../../output_boundary_revised.txt").Dispose();
                }
                catch (Exception)
                {

                }
            else
            {
                File.Delete("../../../../output_boundary_revised.txt");
                File.Create("../../../../output_boundary_revised.txt").Dispose();
            }
        }

        #region HCF

        /// <summary>
        /// Test to find HCF for zero value is return 0 or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestFindHCF_ForZeroValues()
        {
            //Arrange
            bool res = false;

            int n1 = 0 , n2 = 0, expected=0;

            HCFCalculation hCF = new HCFCalculation();
            int result = hCF.FindHCF(n1, n2);

            //Act
            //Assertion
            if (result == expected)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "TestFindHCF_ForZeroValues=" + res + "\n");
            return res;
        }

        /// <summary>
        /// Test to find find HCF for maximum boundary value is return
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestFindHCFFor_MaxValues()
        {
            //Arrange
            bool res = false;
            int n1 = 2147483647, n2 = 2147483646, expected = 1;
            HCFCalculation hCF = new HCFCalculation();
           
            //Act
            int result = hCF.FindHCF(n1, n2);
            
            //Assertion
            if (result == expected)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "TestFindHCFFor_MaxValues=" + res + "\n");
            return res;
        }

        #endregion

        #region DateClass

        /// <summary>
        /// Test to check Month range - For Minimal value 
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestDateFun_CheckMonthRange_ForMinimalValue()
        {
            //Arrange
            bool res = false, expected = true;
            string strDateTime = DateTime.MinValue.ToString();

            DateClassOperations dateClassOperations
                = new DateClassOperations();

            //Act
            bool result = dateClassOperations.CheckMonthRange(strDateTime);

            //Assertion
            if (result == expected)
            {
                res = true;
            }
            
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "TestDateFun_CheckMonthRange_ForMinimalValue=" + res + "\n");
            return res;
        }

        /// <summary>
        /// Test to check Month range - For Max value 
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestDateFun_CheckMonthRange_ForMaxValue()
        {
            ////Arrange
            bool res, expected = true;
            string strDateTime = DateTime.MaxValue.ToString();

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
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "TestDateFun_CheckMonthRange_ForMaxValue=" + res + "\n");
            return res;
        }

        /// <summary>
        /// Test to check Date range - For Minimal value 
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestDateFun_CheckDayRange_ForMinimalValue()
        {
            //Arrange
            bool res = false, expected = true;
            string strDateTime = DateTime.MinValue.ToString();

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
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "TestDateFun_CheckDayRange_ForMinimalValue=" + res + "\n");
            return res;
        }

        /// <summary>
        /// Test to check Date range - For Max value 
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestDateFun_CheckDayRange_ForMaxValue()
        {
            ////Arrange
            bool res = false, expected = true;
            string strDateTime = DateTime.MaxValue.ToString();

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
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "TestDateFun_CheckDayRange_ForMaxValue=" + res + "\n");
            return res;
        }

        /// <summary>
        /// Test to Find weekDay for the Minimum Date Value
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestDateFun_GetWeekDay_ForMinimalValue()
        {
            //Arrange
            string expected = DateTime.MinValue.DayOfWeek.ToString();
            bool res = false;
            string minDate = DateTime.MinValue.ToString();

            DateClassOperations dateClassOperations
                = new DateClassOperations();

            //Act
            string result = dateClassOperations.GetWeekDayOfDate(minDate);

            //Assertion
            if (result == expected)
            {
                res = true;
            }

            ////final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "TestDateFun_GetWeekDay_ForMinimalValue=" + res + "\n");
            return res;
        }

        /// <summary>
        /// Test to Find WeekDay for the Maximum Date Value
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestDateFun_GetWeekDay_ForMaxValue()
        {
            ////Arrange
            string expected = DateTime.MaxValue.DayOfWeek.ToString();
            bool res = false;
            string maxDate = DateTime.MaxValue.ToString();
            DateClassOperations dateClassOperations
                = new DateClassOperations();

            //Act
            string result = dateClassOperations.GetWeekDayOfDate(maxDate);

            //Assertion
            if (result == expected)
            {
                res = true;
            }

            ////final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "TestDateFun_GetWeekDay_ForMaxValue=" + res + "\n");
            return res;
        }

        #endregion

        #region NumberToString
        /// <summary>
        /// Test to Write Int To String for Zero value 
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestWriteIntToString_ForZeroValue()
        {
            //Arrange
            bool res = false;

            ConvertIntToString convertIntToString = new ConvertIntToString();
            //Act
            string result = convertIntToString.WriteIntToString(0);

            //Assertion
            if (result == "Zero")
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "TestWriteIntToString_ForZeroValue=" + res + "\n");
            return res;
        }
        #endregion
    }
}
