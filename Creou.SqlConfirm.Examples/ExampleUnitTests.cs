using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Creou.SqlConfirm.Examples
{
    [TestClass()]
    public class ExampleUnitTests : SqlDatabaseTestClass
    {

        public ExampleUnitTests()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        [TestMethod()]
        public void SimpleExample_SingleColumnByName_SingleRowByFilter()
        {
            SqlDatabaseTestActions testActions = this.SimpleExample_SingleColumnByName_SingleRowByFilterData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            // Execute the test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
            SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            // Execute the post-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
            SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
        }
        [TestMethod()]
        public void SimpleExample_SingleColumnByIndex_SingleRowByIndex()
        {
            SqlDatabaseTestActions testActions = this.SimpleExample_SingleColumnByIndex_SingleRowByIndexData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        public void AdvancedExample_MultipleColumns()
        {
            SqlDatabaseTestActions testActions = this.AdvancedExample_MultipleColumnsData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        public void AdvancedExample_MultipleColumns_MultipleRows()
        {
            SqlDatabaseTestActions testActions = this.AdvancedExample_MultipleColumns_MultipleRowsData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        public void AdvancedExample_RepeatedRows()
        {
            SqlDatabaseTestActions testActions = this.AdvancedExample_RepeatedRowsData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        public void AdvancedExample_MatchingTheLastRow()
        {
            SqlDatabaseTestActions testActions = this.AdvancedExample_MatchingTheLastRowData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        public void SimpleExample_TheFirstThreeRows()
        {
            SqlDatabaseTestActions testActions = this.SimpleExample_TheFirstThreeRowsData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }







        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction SimpleExample_SingleColumnByName_SingleRowByFilter_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExampleUnitTests));
            Creou.SqlConfirm.SqlConfirmCondition sqlConfirmCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction SimpleExample_SingleColumnByIndex_SingleRowByIndex_TestAction;
            Creou.SqlConfirm.SqlConfirmCondition sqlConfirmCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction AdvancedExample_MultipleColumns_TestAction;
            Creou.SqlConfirm.SqlConfirmCondition sqlConfirmCondition3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction AdvancedExample_MultipleColumns_MultipleRows_TestAction;
            Creou.SqlConfirm.SqlConfirmCondition sqlConfirmCondition4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction AdvancedExample_RepeatedRows_TestAction;
            Creou.SqlConfirm.SqlConfirmCondition sqlConfirmCondition5;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction AdvancedExample_MatchingTheLastRow_TestAction;
            Creou.SqlConfirm.SqlConfirmCondition sqlConfirmCondition6;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction SimpleExample_TheFirstThreeRows_TestAction;
            Creou.SqlConfirm.SqlConfirmCondition sqlConfirmCondition7;
            this.SimpleExample_SingleColumnByName_SingleRowByFilterData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.SimpleExample_SingleColumnByIndex_SingleRowByIndexData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.AdvancedExample_MultipleColumnsData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.AdvancedExample_MultipleColumns_MultipleRowsData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.AdvancedExample_RepeatedRowsData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.AdvancedExample_MatchingTheLastRowData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.SimpleExample_TheFirstThreeRowsData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            SimpleExample_SingleColumnByName_SingleRowByFilter_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            sqlConfirmCondition1 = new Creou.SqlConfirm.SqlConfirmCondition();
            SimpleExample_SingleColumnByIndex_SingleRowByIndex_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            sqlConfirmCondition2 = new Creou.SqlConfirm.SqlConfirmCondition();
            AdvancedExample_MultipleColumns_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            sqlConfirmCondition3 = new Creou.SqlConfirm.SqlConfirmCondition();
            AdvancedExample_MultipleColumns_MultipleRows_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            sqlConfirmCondition4 = new Creou.SqlConfirm.SqlConfirmCondition();
            AdvancedExample_RepeatedRows_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            sqlConfirmCondition5 = new Creou.SqlConfirm.SqlConfirmCondition();
            AdvancedExample_MatchingTheLastRow_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            sqlConfirmCondition6 = new Creou.SqlConfirm.SqlConfirmCondition();
            SimpleExample_TheFirstThreeRows_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            sqlConfirmCondition7 = new Creou.SqlConfirm.SqlConfirmCondition();
            // 
            // SimpleExample_SingleColumnByName_SingleRowByFilter_TestAction
            // 
            SimpleExample_SingleColumnByName_SingleRowByFilter_TestAction.Conditions.Add(sqlConfirmCondition1);
            resources.ApplyResources(SimpleExample_SingleColumnByName_SingleRowByFilter_TestAction, "SimpleExample_SingleColumnByName_SingleRowByFilter_TestAction");
            // 
            // sqlConfirmCondition1
            // 
            sqlConfirmCondition1.ColumnSelector = "TestString";
            sqlConfirmCondition1.Enabled = true;
            sqlConfirmCondition1.Name = "sqlConfirmCondition1";
            sqlConfirmCondition1.RowFilter = "Id = 2";
            sqlConfirmCondition1.RowSelector = "";
            sqlConfirmCondition1.RowSort = null;
            sqlConfirmCondition1.Validator = "[\"Value2\"]";
            // 
            // SimpleExample_SingleColumnByIndex_SingleRowByIndex_TestAction
            // 
            SimpleExample_SingleColumnByIndex_SingleRowByIndex_TestAction.Conditions.Add(sqlConfirmCondition2);
            resources.ApplyResources(SimpleExample_SingleColumnByIndex_SingleRowByIndex_TestAction, "SimpleExample_SingleColumnByIndex_SingleRowByIndex_TestAction");
            // 
            // sqlConfirmCondition2
            // 
            sqlConfirmCondition2.ColumnSelector = "2";
            sqlConfirmCondition2.Enabled = true;
            sqlConfirmCondition2.Name = "sqlConfirmCondition2";
            sqlConfirmCondition2.RowFilter = null;
            sqlConfirmCondition2.RowSelector = "1";
            sqlConfirmCondition2.RowSort = null;
            sqlConfirmCondition2.Validator = "[\"Value1\"]";
            // 
            // AdvancedExample_MultipleColumns_TestAction
            // 
            AdvancedExample_MultipleColumns_TestAction.Conditions.Add(sqlConfirmCondition3);
            resources.ApplyResources(AdvancedExample_MultipleColumns_TestAction, "AdvancedExample_MultipleColumns_TestAction");
            // 
            // sqlConfirmCondition3
            // 
            sqlConfirmCondition3.ColumnSelector = "TestString,TestInteger";
            sqlConfirmCondition3.Enabled = true;
            sqlConfirmCondition3.Name = "sqlConfirmCondition3";
            sqlConfirmCondition3.RowFilter = "Id = 2";
            sqlConfirmCondition3.RowSelector = null;
            sqlConfirmCondition3.RowSort = null;
            sqlConfirmCondition3.Validator = "[\"Value2\",2]";
            // 
            // AdvancedExample_MultipleColumns_MultipleRows_TestAction
            // 
            AdvancedExample_MultipleColumns_MultipleRows_TestAction.Conditions.Add(sqlConfirmCondition4);
            resources.ApplyResources(AdvancedExample_MultipleColumns_MultipleRows_TestAction, "AdvancedExample_MultipleColumns_MultipleRows_TestAction");
            // 
            // sqlConfirmCondition4
            // 
            sqlConfirmCondition4.ColumnSelector = "TestString,TestInteger";
            sqlConfirmCondition4.Enabled = true;
            sqlConfirmCondition4.Name = "sqlConfirmCondition4";
            sqlConfirmCondition4.RowFilter = "Id = 2 OR Id = 3";
            sqlConfirmCondition4.RowSelector = null;
            sqlConfirmCondition4.RowSort = null;
            sqlConfirmCondition4.Validator = "[\"Value2\",2],[\"Value3\",3]";
            // 
            // AdvancedExample_RepeatedRows_TestAction
            // 
            AdvancedExample_RepeatedRows_TestAction.Conditions.Add(sqlConfirmCondition5);
            resources.ApplyResources(AdvancedExample_RepeatedRows_TestAction, "AdvancedExample_RepeatedRows_TestAction");
            // 
            // sqlConfirmCondition5
            // 
            sqlConfirmCondition5.ColumnSelector = "TestString,TestInteger";
            sqlConfirmCondition5.Enabled = true;
            sqlConfirmCondition5.Name = "sqlConfirmCondition5";
            sqlConfirmCondition5.ResultRepeat = Creou.SqlConfirm.ResultRepeat.RowOnly;
            sqlConfirmCondition5.RowFilter = "Id >= 10 AND Id <=20";
            sqlConfirmCondition5.RowSelector = null;
            sqlConfirmCondition5.RowSort = null;
            sqlConfirmCondition5.Validator = "[\"Value10To20\",1020]";
            // 
            // SimpleExample_SingleColumnByName_SingleRowByFilterData
            // 
            this.SimpleExample_SingleColumnByName_SingleRowByFilterData.PosttestAction = null;
            this.SimpleExample_SingleColumnByName_SingleRowByFilterData.PretestAction = null;
            this.SimpleExample_SingleColumnByName_SingleRowByFilterData.TestAction = SimpleExample_SingleColumnByName_SingleRowByFilter_TestAction;
            // 
            // SimpleExample_SingleColumnByIndex_SingleRowByIndexData
            // 
            this.SimpleExample_SingleColumnByIndex_SingleRowByIndexData.PosttestAction = null;
            this.SimpleExample_SingleColumnByIndex_SingleRowByIndexData.PretestAction = null;
            this.SimpleExample_SingleColumnByIndex_SingleRowByIndexData.TestAction = SimpleExample_SingleColumnByIndex_SingleRowByIndex_TestAction;
            // 
            // AdvancedExample_MultipleColumnsData
            // 
            this.AdvancedExample_MultipleColumnsData.PosttestAction = null;
            this.AdvancedExample_MultipleColumnsData.PretestAction = null;
            this.AdvancedExample_MultipleColumnsData.TestAction = AdvancedExample_MultipleColumns_TestAction;
            // 
            // AdvancedExample_MultipleColumns_MultipleRowsData
            // 
            this.AdvancedExample_MultipleColumns_MultipleRowsData.PosttestAction = null;
            this.AdvancedExample_MultipleColumns_MultipleRowsData.PretestAction = null;
            this.AdvancedExample_MultipleColumns_MultipleRowsData.TestAction = AdvancedExample_MultipleColumns_MultipleRows_TestAction;
            // 
            // AdvancedExample_RepeatedRowsData
            // 
            this.AdvancedExample_RepeatedRowsData.PosttestAction = null;
            this.AdvancedExample_RepeatedRowsData.PretestAction = null;
            this.AdvancedExample_RepeatedRowsData.TestAction = AdvancedExample_RepeatedRows_TestAction;
            // 
            // AdvancedExample_MatchingTheLastRowData
            // 
            this.AdvancedExample_MatchingTheLastRowData.PosttestAction = null;
            this.AdvancedExample_MatchingTheLastRowData.PretestAction = null;
            this.AdvancedExample_MatchingTheLastRowData.TestAction = AdvancedExample_MatchingTheLastRow_TestAction;
            // 
            // AdvancedExample_MatchingTheLastRow_TestAction
            // 
            AdvancedExample_MatchingTheLastRow_TestAction.Conditions.Add(sqlConfirmCondition6);
            resources.ApplyResources(AdvancedExample_MatchingTheLastRow_TestAction, "AdvancedExample_MatchingTheLastRow_TestAction");
            // 
            // sqlConfirmCondition6
            // 
            sqlConfirmCondition6.ColumnSelector = "TestInteger";
            sqlConfirmCondition6.Enabled = true;
            sqlConfirmCondition6.Name = "sqlConfirmCondition6";
            sqlConfirmCondition6.RowFilter = null;
            sqlConfirmCondition6.RowSelector = "1";
            sqlConfirmCondition6.RowSort = "Id DESC";
            sqlConfirmCondition6.Validator = "[5]";
            // 
            // SimpleExample_TheFirstThreeRowsData
            // 
            this.SimpleExample_TheFirstThreeRowsData.PosttestAction = null;
            this.SimpleExample_TheFirstThreeRowsData.PretestAction = null;
            this.SimpleExample_TheFirstThreeRowsData.TestAction = SimpleExample_TheFirstThreeRows_TestAction;
            // 
            // SimpleExample_TheFirstThreeRows_TestAction
            // 
            SimpleExample_TheFirstThreeRows_TestAction.Conditions.Add(sqlConfirmCondition7);
            resources.ApplyResources(SimpleExample_TheFirstThreeRows_TestAction, "SimpleExample_TheFirstThreeRows_TestAction");
            // 
            // sqlConfirmCondition7
            // 
            sqlConfirmCondition7.ColumnSelector = "TestInteger";
            sqlConfirmCondition7.Enabled = true;
            sqlConfirmCondition7.Name = "sqlConfirmCondition7";
            sqlConfirmCondition7.RowFilter = null;
            sqlConfirmCondition7.RowSelector = "1-3";
            sqlConfirmCondition7.RowSort = null;
            sqlConfirmCondition7.Validator = "1,2,3";
        }

        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        #endregion

        private SqlDatabaseTestActions SimpleExample_SingleColumnByName_SingleRowByFilterData;
        private SqlDatabaseTestActions SimpleExample_SingleColumnByIndex_SingleRowByIndexData;
        private SqlDatabaseTestActions AdvancedExample_MultipleColumnsData;
        private SqlDatabaseTestActions AdvancedExample_MultipleColumns_MultipleRowsData;
        private SqlDatabaseTestActions AdvancedExample_RepeatedRowsData;
        private SqlDatabaseTestActions AdvancedExample_MatchingTheLastRowData;
        private SqlDatabaseTestActions SimpleExample_TheFirstThreeRowsData;
    }
}
