﻿#define Shapes
#define EmployeePay
#define Debugging
#define StateCollection
#define Purchasing
#define EDI
#define ETL
//-----------< Comment the #undef for the project you are testing >-----------//
#undef Shapes
#undef EmployeePay
#undef Debugging
#undef StateCollection
#undef Purchasing
#undef EDI
#undef ETL

using static System.Console;


namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("<----- Student: YOUR NAME HERE ----->");
            #region Shapes
#if Shapes
            Shapes.TestShapes.Test();
#endif
            #endregion
            #region Employee Pay
#if EmployeePay
            EmployeePay.EmployeePay.Test();
#endif
            #endregion
            #region Debugging
#if Debugging
            Debugging.Debugging.Test();
#endif
            #endregion
            #region State Collection
#if StateCollection
            StateCollection.TestStateCollection.Test();
#endif
            #endregion
            #region Purchasing
#if Purchasing
            Purchasing.PurchasingTest.Test();
            //new Purchasing.TestSales();
#endif
            #endregion
            #region EDI
#if EDI
            EDI.TestEDI.Test();
#endif
            #endregion
            #region ETL
#if ETL
            ETL.TestEtl.Test();
#endif
            #endregion
            ReadKey();
        }
    }
}
