/* Title:           Vehicle Problems Class
 * Date:            6-30-17
 * Author:          Terry Holmes */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace VehicleProblemsDLL
{
    public class VehicleProblemClass
    {
        //setting up the classes
        EventLogClass TheEventLogClass = new EventLogClass();

        VehicleProblemsDataSet aVehicleProblemDataSet;
        VehicleProblemsDataSetTableAdapters.vehicleproblemTableAdapter aVehicleProblemsTableAdapter;

        VehicleProblemUpdateDataSet aVehicleProblemUpdateDataSet;
        VehicleProblemUpdateDataSetTableAdapters.vehicleproblemupdateTableAdapter aVehicleProblemUpdateTableAdapter;

        InsertVehicleProblemEntryTableAdapters.QueriesTableAdapter aInsertVehicleProblemEntryTableAdapter;

        InsertVehicleProblemUpdateEntryTableAdapters.QueriesTableAdapter aInsertVehicleProblemUpdateEntryTableAdapter;

        UpdateVehicleProblemCostRecordTableAdapters.QueriesTableAdapter aUpdateVehicleProblemCostRecordTableAdapter;

        UpdateVehicleVendorIDEntryTableAdapters.QueriesTableAdapter aUpdateVehicleProblemVendorIDEntryTableAdapter;

        UpdateVehicleProblemSolvedRecordTableAdapters.QueriesTableAdapter aUpdateVehicleProblemSolvedRecordTableAdapter;

        FindVehicleProblemUpdateByVehicleIDDataSet aFindVehicleProblemUpdateByVehicleIDDataSet;
        FindVehicleProblemUpdateByVehicleIDDataSetTableAdapters.FindVehicleProblemUpdateByVehicleIDTableAdapter aFindVehicleProblemUpdateByVehicleIDTableAdapter;

        FindOpenVehicleProblemsDataSet aFindOpenVehicleProblemsDataSet;
        FindOpenVehicleProblemsDataSetTableAdapters.FindOpenVehicleProblemsTableAdapter aFindOpenVehicleProblemsTableAdapter;

        FindOpenVehicleProblemsByVehicleIDDataSet aFindOpenVehicleProblemsByVehicleIDDataSet;
        FindOpenVehicleProblemsByVehicleIDDataSetTableAdapters.FindOpenVehicleProblemsByVehicleIDTableAdapter aFindOpenVehicleProblemsByVehicleIDTableAdapter;

        FindVehicleProblemByDateRangeDataSet aFindVehicleProblemByDateRangeDataSet;
        FindVehicleProblemByDateRangeDataSetTableAdapters.FindVehicleProblemByDateRangeTableAdapter aFindVehicleProblemByDateRangeTableAdapter;

        FindVehicleProblemByVehicleIDAndDateRangeDataSet aFindVehicleProblemByVehicleIDAndDateRangeDataSet;
        FindVehicleProblemByVehicleIDAndDateRangeDataSetTableAdapters.FindVehicleProblembyVehicleIDAndDateRangeTableAdapter aFindVehicleProblemByVehicleIDAndDateRangeTableAdapter;

        FindVehicleProblemByDateMatchDataSet aFindVehicleProblemByDateMatchDataSet;
        FindVehicleProblemByDateMatchDataSetTableAdapters.FindVehicleProblemByDateMatchTableAdapter aFindVehicleProblemByDateMatchTableAdapter;

        FindVehicleProblemByProblemIDDataSet aFindVehicleProblemByProblemIDDataSet;
        FindVehicleProblemByProblemIDDataSetTableAdapters.FindVehicleProblemByProblemIDTableAdapter aFindVehicleProblemByProblemIDTableAdapter;

        FindOpenVehicleProblemsNeedingServiceDataSet aFindOpenVehicleProblemsNeedingServiceDataSet;
        FindOpenVehicleProblemsNeedingServiceDataSetTableAdapters.FindOpenVehicleProblemsNeedingServiceTableAdapter aFindOpenVehicleProblemsNeedingServiceTableAdapter;

        FindVehicleProblemUpdateByProblemIDDataSet aFindVehicleProblemUpdateByProblemIDDataSet;
        FindVehicleProblemUpdateByProblemIDDataSetTableAdapters.FindVehicleProblemUpdateByProblemIDTableAdapter aFindVehicleProblemUpdateByProblemIDTableAdapter;

        FindOpenVehicleMainProblemsByVehicleIDDataSet aFindOpenVehicleMainProblemsByVehicleIDDataSet;
        FindOpenVehicleMainProblemsByVehicleIDDataSetTableAdapters.FindOpenVehicleMainProblemsByVehicleIDTableAdapter aFindOpenVehicleMainProblemsByVehicleIDTableAdapter;

        FindVehicleMainProblemByProblemIDDataSet aFindVehicleMainProblemByProblemIDDataSet;
        FindVehicleMainProblemByProblemIDDataSetTableAdapters.FindVehicleMainProblemByProblemIDTableAdapter aFindVehicleMainProblemByProblemIDTableAdapter;

        FindVehicleMainProblemByVehicleIDAndDateRangeDataSet aFindVehicleMainProblemByVehicleIDAndDateRangeDataSet;
        FindVehicleMainProblemByVehicleIDAndDateRangeDataSetTableAdapters.FindVehicleMainProblembyVehicleIDAndDateRangeTableAdapter aFindVehicleMainProblemByVehicleIDAndDateRangeTableAdapter;

        FindVehicleMainProblemByDateRangeDataSet aFindVehicleMainProblemByDateRangeDataSet;
        FindVehicleMainProblemByDateRangeDataSetTableAdapters.FindVehicleMainProblemByDateRangeTableAdapter aFindVehicleMainProblemByDateRangeTableAdapter;

        FindVehicleMainProblemUpdateByProblemIDDataSet aFindVehicleMainProblemUpdateByProblemIDDataSet;
        FindVehicleMainProblemUpdateByProblemIDDataSetTableAdapters.FindVehicleMainProblemUpdateByProblemIDTableAdapter aFindVehicleMainProblemUpdateByProblemIDTableAdapter;

        FindOpenVehicleMainDashboardProblemsByVehicleIDDataSet aFindOpenVehicleMainDashboardProblemsByVehicleIDDataSet;
        FindOpenVehicleMainDashboardProblemsByVehicleIDDataSetTableAdapters.FindOpenVehicleMainDashboardByVehicleIDTableAdapter aFindOpenVehicleMainDashboardProblemsByVehicleIDTableAdapter;

        FindVehicleMainProblemUpdateDashboardByProblemIDDataSet aFindVehicleMainProblemUpdateDashboardByVehicleIDDataSet;
        FindVehicleMainProblemUpdateDashboardByProblemIDDataSetTableAdapters.FindVehicleMainUpdateDashboardByProblemIDTableAdapter aFindVehicleMainProblemUpdateDashboardByVehicleIDTableAdpater;

        FindOpenVehicleMainProblemsDataSet aFindOpenVehicleMainProblemsDataSet;
        FindOpenVehicleMainProblemsDataSetTableAdapters.FindOpenVehicleMainProblemsTableAdapter aFindOpenVehicleMainProblemsTableAdpater;

        FindVehicleProblemHistoryByVehicleIDDataSet aFindVehicleProblemHistoryByVehicleIDDataSet;
        FindVehicleProblemHistoryByVehicleIDDataSetTableAdapters.FindVehicleProblemHistoryByVehicleIDTableAdapter aFindVehicleProblemHistoryByVehicleIDTableAdapter;

        FindAllVehicleMainProblemsByVehicleIDDataSet aFindAllVehicleMainProblemsByVehicleIDDataSet;
        FindAllVehicleMainProblemsByVehicleIDDataSetTableAdapters.FindAllVehicleMainProblemsByVehicleIDTableAdapter aFindAllVehicleMainProblemsByVehicleIDTableAdapter;

        UpdateVehicleProblemResolutionEntryTableAdapters.QueriesTableAdapter aUpdateVehicleProblemResolutionTableAdapter;

        ChangeVehicleProblemStatusEntryTableAdapters.QueriesTableAdapter aChangeVehicleProblemStatusTableAdapter;

        ChangeProblemInvoiceNumberEntryTableAdapters.QueriesTableAdapter aChangeProblemInvoiceNumberTableAdapter;

        FindAllVehicleMainProblemsByDateRangeDataSet aFindAllVehicleMainProblemsByDateRangeDataSet;
        FindAllVehicleMainProblemsByDateRangeDataSetTableAdapters.FindAllVehicleMainProblemsByDateRangeTableAdapter aFindAllVehicleMainProblemsByDateRangeTableAdapter;

        FindVehicleMainProblemReadyForInvoicingDataSet aFindVehicleMainProblemReadyForInvoicingDataSet;
        FindVehicleMainProblemReadyForInvoicingDataSetTableAdapters.FindVehicleMainProblemReadyForInvoicingTableAdapter aFindVehicleMainProblemREadyForInvoicingTableAdapter;

        public FindVehicleMainProblemReadyForInvoicingDataSet FindVehicleMainProblemReadyForInvoicing(int intVehicleID)
        {
            try
            {
                aFindVehicleMainProblemReadyForInvoicingDataSet = new FindVehicleMainProblemReadyForInvoicingDataSet();
                aFindVehicleMainProblemREadyForInvoicingTableAdapter = new FindVehicleMainProblemReadyForInvoicingDataSetTableAdapters.FindVehicleMainProblemReadyForInvoicingTableAdapter();
                aFindVehicleMainProblemREadyForInvoicingTableAdapter.Fill(aFindVehicleMainProblemReadyForInvoicingDataSet.FindVehicleMainProblemReadyForInvoicing, intVehicleID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Problem Class // Find Vehicle Main Problem Ready For Invoicing " + Ex.Message);
            }

            return aFindVehicleMainProblemReadyForInvoicingDataSet;
        }
        public FindAllVehicleMainProblemsByDateRangeDataSet FindAllVehicleMainProblemsByDateRange(int intVehicleID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindAllVehicleMainProblemsByDateRangeDataSet = new FindAllVehicleMainProblemsByDateRangeDataSet();
                aFindAllVehicleMainProblemsByDateRangeTableAdapter = new FindAllVehicleMainProblemsByDateRangeDataSetTableAdapters.FindAllVehicleMainProblemsByDateRangeTableAdapter();
                aFindAllVehicleMainProblemsByDateRangeTableAdapter.Fill(aFindAllVehicleMainProblemsByDateRangeDataSet.FindAllVehicleMainProblemsByDateRange, intVehicleID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Problem Class // Find All Vehicle Main Problems By Date Range " + Ex.Message);
            }

            return aFindAllVehicleMainProblemsByDateRangeDataSet;
        }
        public bool ChangeProblemInvoiceNumber(int intProblemID, int intInvoiceID)
        {
            bool blnFatalError = false;

            try
            {
                aChangeProblemInvoiceNumberTableAdapter = new ChangeProblemInvoiceNumberEntryTableAdapters.QueriesTableAdapter();
                aChangeProblemInvoiceNumberTableAdapter.ChangeProblemInvoiceNumber(intProblemID, intInvoiceID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Problem Class // Change Problem Invoice Number " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool ChangeVehicleProblemStatus(int intProblemID, string strProblemStatus)
        {
            bool blnFatalError = false;

            try
            {
                aChangeVehicleProblemStatusTableAdapter = new ChangeVehicleProblemStatusEntryTableAdapters.QueriesTableAdapter();
                aChangeVehicleProblemStatusTableAdapter.ChangeVehicleProblemStatus(intProblemID, strProblemStatus);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Problems Class // Change Vehicle Status " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateVehicleProblemResolution(int intProblemID, DateTime datResolutionDate, string strProblemResolution, int intInvoiceID)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateVehicleProblemResolutionTableAdapter = new UpdateVehicleProblemResolutionEntryTableAdapters.QueriesTableAdapter();
                aUpdateVehicleProblemResolutionTableAdapter.UpdateVehicleProblemResolution(intProblemID, datResolutionDate, strProblemResolution, intInvoiceID);
            }
            catch (Exception Ex)
            {
                blnFatalError = true;

                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Problem Class // Update Vehicle Problem Resolution " + Ex.Message);
            }

            return blnFatalError;
        }
        public FindAllVehicleMainProblemsByVehicleIDDataSet FindAllVehicleMainProblemsByVehicleID(int intVehicleID)
        {
            try
            {
                aFindAllVehicleMainProblemsByVehicleIDDataSet = new FindAllVehicleMainProblemsByVehicleIDDataSet();
                aFindAllVehicleMainProblemsByVehicleIDTableAdapter = new FindAllVehicleMainProblemsByVehicleIDDataSetTableAdapters.FindAllVehicleMainProblemsByVehicleIDTableAdapter();
                aFindAllVehicleMainProblemsByVehicleIDTableAdapter.Fill(aFindAllVehicleMainProblemsByVehicleIDDataSet.FindAllVehicleMainProblemsByVehicleID, intVehicleID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Problems Class // Find All Vehicle Main Problems By Vehicle ID " + Ex.Message);
            }

            return aFindAllVehicleMainProblemsByVehicleIDDataSet;
        }
        public FindVehicleProblemHistoryByVehicleIDDataSet FindVehicleProblemHistoryByVehicleID(int intVehicleID)
        {
            try
            {
                aFindVehicleProblemHistoryByVehicleIDDataSet = new FindVehicleProblemHistoryByVehicleIDDataSet();
                aFindVehicleProblemHistoryByVehicleIDTableAdapter = new FindVehicleProblemHistoryByVehicleIDDataSetTableAdapters.FindVehicleProblemHistoryByVehicleIDTableAdapter();
                aFindVehicleProblemHistoryByVehicleIDTableAdapter.Fill(aFindVehicleProblemHistoryByVehicleIDDataSet.FindVehicleProblemHistoryByVehicleID, intVehicleID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Problem Class // Find Vehicle Problem History By Vehicle ID " + Ex.Message);
            }

            return aFindVehicleProblemHistoryByVehicleIDDataSet;
        }
        public FindOpenVehicleMainProblemsDataSet FindOpenVehicleMainProblems()
        {
            try
            {
                aFindOpenVehicleMainProblemsDataSet = new FindOpenVehicleMainProblemsDataSet();
                aFindOpenVehicleMainProblemsTableAdpater = new FindOpenVehicleMainProblemsDataSetTableAdapters.FindOpenVehicleMainProblemsTableAdapter();
                aFindOpenVehicleMainProblemsTableAdpater.Fill(aFindOpenVehicleMainProblemsDataSet.FindOpenVehicleMainProblems);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Problems Class // Find Open Vehicle Problems " + Ex.Message);
            }

            return aFindOpenVehicleMainProblemsDataSet;
        }
        public FindVehicleMainProblemUpdateDashboardByProblemIDDataSet FindVehicleMainProblemUpdateDashboardByProblemID(int intProblemID)
        {
            try
            {
                aFindVehicleMainProblemUpdateDashboardByVehicleIDDataSet = new FindVehicleMainProblemUpdateDashboardByProblemIDDataSet();
                aFindVehicleMainProblemUpdateDashboardByVehicleIDTableAdpater = new FindVehicleMainProblemUpdateDashboardByProblemIDDataSetTableAdapters.FindVehicleMainUpdateDashboardByProblemIDTableAdapter();
                aFindVehicleMainProblemUpdateDashboardByVehicleIDTableAdpater.Fill(aFindVehicleMainProblemUpdateDashboardByVehicleIDDataSet.FindVehicleMainUpdateDashboardByProblemID, intProblemID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Problem Class // Find Vehicle Main Problem Update Dashboard By Problem ID" + Ex.Message);
            }

            return aFindVehicleMainProblemUpdateDashboardByVehicleIDDataSet;
        }
        public FindOpenVehicleMainDashboardProblemsByVehicleIDDataSet FindOpenVehicleMainDashboardProblemsByVehicleID(int intVehicleID)
        {
            try
            {
                aFindOpenVehicleMainDashboardProblemsByVehicleIDDataSet = new FindOpenVehicleMainDashboardProblemsByVehicleIDDataSet();
                aFindOpenVehicleMainDashboardProblemsByVehicleIDTableAdapter = new FindOpenVehicleMainDashboardProblemsByVehicleIDDataSetTableAdapters.FindOpenVehicleMainDashboardByVehicleIDTableAdapter();
                aFindOpenVehicleMainDashboardProblemsByVehicleIDTableAdapter.Fill(aFindOpenVehicleMainDashboardProblemsByVehicleIDDataSet.FindOpenVehicleMainDashboardByVehicleID, intVehicleID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Problem Class // Find Open Vehicle Main Dashboard Problems By Vehicle ID" + Ex.Message);
            }

            return aFindOpenVehicleMainDashboardProblemsByVehicleIDDataSet;
        }
        public FindVehicleMainProblemUpdateByProblemIDDataSet FindVehicleMainProblemUpdateByProblemID(int intProblemID)
        {
            try
            {
                aFindVehicleMainProblemUpdateByProblemIDDataSet = new FindVehicleMainProblemUpdateByProblemIDDataSet();
                aFindVehicleMainProblemUpdateByProblemIDTableAdapter = new FindVehicleMainProblemUpdateByProblemIDDataSetTableAdapters.FindVehicleMainProblemUpdateByProblemIDTableAdapter();
                aFindVehicleMainProblemUpdateByProblemIDTableAdapter.Fill(aFindVehicleMainProblemUpdateByProblemIDDataSet.FindVehicleMainProblemUpdateByProblemID, intProblemID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehlcle Problem Class // Find Vehicle Main Problem UPdate By Problem ID " + Ex.Message);
            }

            return aFindVehicleMainProblemUpdateByProblemIDDataSet;
        }
        public FindVehicleMainProblemByDateRangeDataSet FindVehicleMainProblemByDateRange(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindVehicleMainProblemByDateRangeDataSet = new FindVehicleMainProblemByDateRangeDataSet();
                aFindVehicleMainProblemByDateRangeTableAdapter = new FindVehicleMainProblemByDateRangeDataSetTableAdapters.FindVehicleMainProblemByDateRangeTableAdapter();
                aFindVehicleMainProblemByDateRangeTableAdapter.Fill(aFindVehicleMainProblemByDateRangeDataSet.FindVehicleMainProblemByDateRange, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Problems Class // Find Vehicle Main Problem By Date Range " + Ex.Message);
            }

            return aFindVehicleMainProblemByDateRangeDataSet;
        }
        public FindVehicleMainProblemByVehicleIDAndDateRangeDataSet FindVehicleMainProblemByVehicleIDAndDateRange(int intVehicleID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindVehicleMainProblemByVehicleIDAndDateRangeDataSet = new FindVehicleMainProblemByVehicleIDAndDateRangeDataSet();
                aFindVehicleMainProblemByVehicleIDAndDateRangeTableAdapter = new FindVehicleMainProblemByVehicleIDAndDateRangeDataSetTableAdapters.FindVehicleMainProblembyVehicleIDAndDateRangeTableAdapter();
                aFindVehicleMainProblemByVehicleIDAndDateRangeTableAdapter.Fill(aFindVehicleMainProblemByVehicleIDAndDateRangeDataSet.FindVehicleMainProblembyVehicleIDAndDateRange, intVehicleID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Problem Class // Find Vehicle Main Problem By Vehjicle ID and Date Range " + Ex.Message);
            }

            return aFindVehicleMainProblemByVehicleIDAndDateRangeDataSet;
        }
        public FindVehicleMainProblemByProblemIDDataSet FindVehicleMainProblemByProblemID(int intProblemID)
        {
            try
            {
                aFindVehicleMainProblemByProblemIDDataSet = new FindVehicleMainProblemByProblemIDDataSet();
                aFindVehicleMainProblemByProblemIDTableAdapter = new FindVehicleMainProblemByProblemIDDataSetTableAdapters.FindVehicleMainProblemByProblemIDTableAdapter();
                aFindVehicleMainProblemByProblemIDTableAdapter.Fill(aFindVehicleMainProblemByProblemIDDataSet.FindVehicleMainProblemByProblemID, intProblemID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Problem Class // Find Vehicle Main Problem By Problem ID " + Ex.Message);
            }

            return aFindVehicleMainProblemByProblemIDDataSet;
        }
        public FindOpenVehicleMainProblemsByVehicleIDDataSet FindOpenVehicleMainProblemsByVehicleID(int intVehicleID)
        {
            try
            {
                aFindOpenVehicleMainProblemsByVehicleIDDataSet = new FindOpenVehicleMainProblemsByVehicleIDDataSet();
                aFindOpenVehicleMainProblemsByVehicleIDTableAdapter = new FindOpenVehicleMainProblemsByVehicleIDDataSetTableAdapters.FindOpenVehicleMainProblemsByVehicleIDTableAdapter();
                aFindOpenVehicleMainProblemsByVehicleIDTableAdapter.Fill(aFindOpenVehicleMainProblemsByVehicleIDDataSet.FindOpenVehicleMainProblemsByVehicleID, intVehicleID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Problem Class // Find Open Vehicle Problems By Vehicle ID " + Ex.Message);
            }

            return aFindOpenVehicleMainProblemsByVehicleIDDataSet;
        }
        public FindVehicleProblemUpdateByProblemIDDataSet FindVehicleProblemUpdateByProblemID(int intProblemID)
        {
            try
            {
                aFindVehicleProblemUpdateByProblemIDDataSet = new FindVehicleProblemUpdateByProblemIDDataSet();
                aFindVehicleProblemUpdateByProblemIDTableAdapter = new FindVehicleProblemUpdateByProblemIDDataSetTableAdapters.FindVehicleProblemUpdateByProblemIDTableAdapter();
                aFindVehicleProblemUpdateByProblemIDTableAdapter.Fill(aFindVehicleProblemUpdateByProblemIDDataSet.FindVehicleProblemUpdateByProblemID, intProblemID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Problem Class // find Vehicle Problem By Problem ID " + Ex.Message);
            }

            return aFindVehicleProblemUpdateByProblemIDDataSet;
        }
        public FindOpenVehicleProblemsNeedingServiceDataSet FindOpenVehicleProblemsNeedingService()
        {
            try
            {
                aFindOpenVehicleProblemsNeedingServiceDataSet = new FindOpenVehicleProblemsNeedingServiceDataSet();
                aFindOpenVehicleProblemsNeedingServiceTableAdapter = new FindOpenVehicleProblemsNeedingServiceDataSetTableAdapters.FindOpenVehicleProblemsNeedingServiceTableAdapter();
                aFindOpenVehicleProblemsNeedingServiceTableAdapter.Fill(aFindOpenVehicleProblemsNeedingServiceDataSet.FindOpenVehicleProblemsNeedingService);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Problem Class // Find Open Vehicle Problems Needing Service " + Ex.Message);
            }

            return aFindOpenVehicleProblemsNeedingServiceDataSet;
        }

        public FindVehicleProblemByProblemIDDataSet FindVehicleProblemByProblemID(int intProblemID)
        {
            try
            {
                aFindVehicleProblemByProblemIDDataSet = new FindVehicleProblemByProblemIDDataSet();
                aFindVehicleProblemByProblemIDTableAdapter = new FindVehicleProblemByProblemIDDataSetTableAdapters.FindVehicleProblemByProblemIDTableAdapter();
                aFindVehicleProblemByProblemIDTableAdapter.Fill(aFindVehicleProblemByProblemIDDataSet.FindVehicleProblemByProblemID, intProblemID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Problem Class // Find Vehicle Problem by Problem ID " + Ex.Message);
            }

            return aFindVehicleProblemByProblemIDDataSet;
        }
        public FindVehicleProblemByDateMatchDataSet FindVehicleProblemByDateMatch(DateTime datTransactionDate)
        {
            try
            {
                aFindVehicleProblemByDateMatchDataSet = new FindVehicleProblemByDateMatchDataSet();
                aFindVehicleProblemByDateMatchTableAdapter = new FindVehicleProblemByDateMatchDataSetTableAdapters.FindVehicleProblemByDateMatchTableAdapter();
                aFindVehicleProblemByDateMatchTableAdapter.Fill(aFindVehicleProblemByDateMatchDataSet.FindVehicleProblemByDateMatch, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Problem Class // Find Vehicle Problem By Date Match " + Ex.Message);
            }

            return aFindVehicleProblemByDateMatchDataSet;
        }
        public FindVehicleProblemByVehicleIDAndDateRangeDataSet FindVehicleProblemByVehicleIDAndDateRange(int intVehicleID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindVehicleProblemByVehicleIDAndDateRangeDataSet = new FindVehicleProblemByVehicleIDAndDateRangeDataSet();
                aFindVehicleProblemByVehicleIDAndDateRangeTableAdapter = new FindVehicleProblemByVehicleIDAndDateRangeDataSetTableAdapters.FindVehicleProblembyVehicleIDAndDateRangeTableAdapter();
                aFindVehicleProblemByVehicleIDAndDateRangeTableAdapter.Fill(aFindVehicleProblemByVehicleIDAndDateRangeDataSet.FindVehicleProblembyVehicleIDAndDateRange, intVehicleID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Problems Class // Find Vehicle Problem By Date Range // " + Ex.Message);
            }

            return aFindVehicleProblemByVehicleIDAndDateRangeDataSet;
        }

        public FindVehicleProblemByDateRangeDataSet FindVehicleProblemByDateRange(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindVehicleProblemByDateRangeDataSet = new FindVehicleProblemByDateRangeDataSet();
                aFindVehicleProblemByDateRangeTableAdapter = new FindVehicleProblemByDateRangeDataSetTableAdapters.FindVehicleProblemByDateRangeTableAdapter();
                aFindVehicleProblemByDateRangeTableAdapter.Fill(aFindVehicleProblemByDateRangeDataSet.FindVehicleProblemByDateRange, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Problems Class // Find Vehicle Problem By Date Range // " + Ex.Message);
            }

            return aFindVehicleProblemByDateRangeDataSet;
        }
        public FindOpenVehicleProblemsByVehicleIDDataSet FindOpenVehicleProblemsbyVehicleID(int intVehicleID)
        {
            try
            {
                aFindOpenVehicleProblemsByVehicleIDDataSet = new FindOpenVehicleProblemsByVehicleIDDataSet();
                aFindOpenVehicleProblemsByVehicleIDTableAdapter = new FindOpenVehicleProblemsByVehicleIDDataSetTableAdapters.FindOpenVehicleProblemsByVehicleIDTableAdapter();
                aFindOpenVehicleProblemsByVehicleIDTableAdapter.Fill(aFindOpenVehicleProblemsByVehicleIDDataSet.FindOpenVehicleProblemsByVehicleID, intVehicleID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Problems Class // Find Open Vehicle Problems By Vehicle ID // " + Ex.Message);
            }

            return aFindOpenVehicleProblemsByVehicleIDDataSet;
        }
        public FindOpenVehicleProblemsDataSet FindOpenVehicleProblems()
        {
            try
            {
                aFindOpenVehicleProblemsDataSet = new FindOpenVehicleProblemsDataSet();
                aFindOpenVehicleProblemsTableAdapter = new FindOpenVehicleProblemsDataSetTableAdapters.FindOpenVehicleProblemsTableAdapter();
                aFindOpenVehicleProblemsTableAdapter.Fill(aFindOpenVehicleProblemsDataSet.FindOpenVehicleProblems);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Problems Class // Find Open Vehicle Problems // " + Ex.Message);
            }

            return aFindOpenVehicleProblemsDataSet;
        }
        public FindVehicleProblemUpdateByVehicleIDDataSet FindVehicleProblemUpdateByVehicleID(int intVehicleID)
        {
            try
            {
                aFindVehicleProblemUpdateByVehicleIDDataSet = new FindVehicleProblemUpdateByVehicleIDDataSet();
                aFindVehicleProblemUpdateByVehicleIDTableAdapter = new FindVehicleProblemUpdateByVehicleIDDataSetTableAdapters.FindVehicleProblemUpdateByVehicleIDTableAdapter();
                aFindVehicleProblemUpdateByVehicleIDTableAdapter.Fill(aFindVehicleProblemUpdateByVehicleIDDataSet.FindVehicleProblemUpdateByVehicleID, intVehicleID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Problems Class // Find Vehicle Problem Update By Vehicle ID // " + Ex.Message);
            }

            return aFindVehicleProblemUpdateByVehicleIDDataSet;
        }
        public bool UpdateVehicleProblemSolved(int intProblemID, bool blnProblemSolved)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateVehicleProblemSolvedRecordTableAdapter = new UpdateVehicleProblemSolvedRecordTableAdapters.QueriesTableAdapter();
                aUpdateVehicleProblemSolvedRecordTableAdapter.UpdateVehicleProblemSolved(intProblemID, blnProblemSolved);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Problems Class // Update Vehicle Problem Solved // " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateVehicleProblemVendorID(int intProblemID, int intVendorID)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateVehicleProblemVendorIDEntryTableAdapter = new UpdateVehicleVendorIDEntryTableAdapters.QueriesTableAdapter();
                aUpdateVehicleProblemVendorIDEntryTableAdapter.UpdateVehicleVendorID(intProblemID, intVendorID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Problems Class // Update Vehicle Problem Invoice Path // " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateVehiclePRoblemCost(int intProblemID, float fltProblemCost)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateVehicleProblemCostRecordTableAdapter = new UpdateVehicleProblemCostRecordTableAdapters.QueriesTableAdapter();
                aUpdateVehicleProblemCostRecordTableAdapter.UpdateVehicleProblemCost(intProblemID, fltProblemCost);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Problem Class // Updte Vehicle Problem Cost // " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertVehicleProblemUpdate(int intProblemID, int intEmployeeID, string strProblemUpdate, DateTime datTransactionDate)
        {
            bool blnFatalError = false;

            try
            {
                aInsertVehicleProblemUpdateEntryTableAdapter = new InsertVehicleProblemUpdateEntryTableAdapters.QueriesTableAdapter();
                aInsertVehicleProblemUpdateEntryTableAdapter.InsertVehicleProblemUpdate(intProblemID, intEmployeeID, strProblemUpdate, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Problems Class // Insert Vehicle Problem Update // " + Ex.Message);

                blnFatalError = false;
            }

            return blnFatalError;
        }
        public bool InsertVehicleProblem(int intVehicleID, DateTime datTransactionDate, string strProblem)
        {
            bool blnFatalError = false;

            try
            {
                aInsertVehicleProblemEntryTableAdapter = new InsertVehicleProblemEntryTableAdapters.QueriesTableAdapter();
                aInsertVehicleProblemEntryTableAdapter.InsertVehicleProblem(intVehicleID, datTransactionDate, strProblem);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Problem Class // Insert Vehicle Problem // " + Ex.Message);

                blnFatalError = true;
            } 

            return blnFatalError;
        }
        public VehicleProblemUpdateDataSet GetVehicleProblemUpdateInfo()
        {
            try
            {
                aVehicleProblemUpdateDataSet = new VehicleProblemUpdateDataSet();
                aVehicleProblemUpdateTableAdapter = new VehicleProblemUpdateDataSetTableAdapters.vehicleproblemupdateTableAdapter();
                aVehicleProblemUpdateTableAdapter.Fill(aVehicleProblemUpdateDataSet.vehicleproblemupdate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Problem Class // Get Vehicle Problem Update Info " + Ex.Message);
            }

            return aVehicleProblemUpdateDataSet;
        }
        public void UpdateVehicleProblemUpdateDB(VehicleProblemUpdateDataSet aVehicleProblemUpdateDataSet)
        {
            try
            {
                aVehicleProblemUpdateTableAdapter = new VehicleProblemUpdateDataSetTableAdapters.vehicleproblemupdateTableAdapter();
                aVehicleProblemUpdateTableAdapter.Update(aVehicleProblemUpdateDataSet.vehicleproblemupdate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Problem Class // Update Vehicle Problem Update DB " + Ex.Message);
            }
        }
        public VehicleProblemsDataSet GetVehicleProblemsInfo()
        {
            try
            {
                aVehicleProblemDataSet = new VehicleProblemsDataSet();
                aVehicleProblemsTableAdapter = new VehicleProblemsDataSetTableAdapters.vehicleproblemTableAdapter();
                aVehicleProblemsTableAdapter.Fill(aVehicleProblemDataSet.vehicleproblem);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Problem Class // Get Vehicle Problems Info " + Ex.Message);
            }
                
            return aVehicleProblemDataSet;
        }
        public void UpdateVehicleProblemsDB(VehicleProblemsDataSet aVehicleProblemDataSet)
        {
            try
            {
                aVehicleProblemsTableAdapter = new VehicleProblemsDataSetTableAdapters.vehicleproblemTableAdapter();
                aVehicleProblemsTableAdapter.Update(aVehicleProblemDataSet.vehicleproblem);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Problem Class // Update Vehicle Problems DB " + Ex.Message);
            }
        }
    }
}
