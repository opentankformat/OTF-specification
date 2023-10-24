using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTF.SampleGenerator
{
    public static class SampleData
    {

        //1 - LESSEE INFO (lessee, transport info, ETA, etc.)
        //1A - LESSEE BASIC
        public static string Lessee_ID = "Oscar Operator Inc.";
        public static string Lessee_ContactName = "Oscar Operator";

        //1B - LESSEE TRANSPORT INFO
        public static string ContainerNumber = "ABCD-123456-0";
        public static string ContainerType = "20TC";

        public static string Arrival_HaulierName = "Tango Transport Inc.";
        public static string Arrival_TruckDriverName = "Tommy Truck Driver";
        public static string Arrival_TruckLicensePlate = "AAA-111";

        public static bool Arrival_ContainerState_IsLoaded = false;
        public static double Arrival_ContainerState_FullLoadedAmount = 0;
        public static string Arrival_ContainerState_FullLoadedAmountUnit = "kg";
        public static bool Arrival_ContainerState_IsClean = false;
        public static bool Arrival_ContainerState_IsPressurized = true;
        public static bool Arrival_ContainerState_IsNitrogen = false;

        public static string Arrival_ContainerState_LoadedAmountUnit = "L";
        public static int Arrival_ContainerState_Compartment1_CompartmentNumber = 1;
        public static double Arrival_ContainerState_Compartment1_LoadedAmount = 0;
        public static string Arrival_ContainerState_Compartment1_CurrentProductMainName = "CHEMICAL PRODUCT";
        public static string Arrival_ContainerState_Compartment1_CurrentProductTradeName = "CHARLIE PRODUCT";
        public static string Arrival_ContainerState_Compartment1_PreviousProduct1MainName = "CHEMICAL PRODUCT";
        public static string Arrival_ContainerState_Compartment1_PreviousProduct1TradeName = "CHARLIE PRODUCT";
        public static string Arrival_ContainerState_Compartment1_PreviousProduct2MainName = "CHEMICAL PRODUCT";
        public static string Arrival_ContainerState_Compartment1_PreviousProduct2TradeName = "CHARLIE PRODUCT";
        public static string Arrival_ContainerState_Compartment1_PreviousProduct3MainName = "CHEMICAL PRODUCT";
        public static string Arrival_ContainerState_Compartment1_PreviousProduct3TradeName = "CHARLIE PRODUCT";
        public static int Arrival_ContainerState_Compartment2_CompartmentNumber = 2;
        public static double Arrival_ContainerState_Compartment2_LoadedAmount = 0;
        public static string Arrival_ContainerState_Compartment2_CurrentProductMainName = "CHEMICAL PRODUCT";
        public static string Arrival_ContainerState_Compartment2_CurrentProductTradeName = "CHARLIE PRODUCT";
        public static string Arrival_ContainerState_Compartment2_PreviousProduct1MainName = "CHEMICAL PRODUCT";
        public static string Arrival_ContainerState_Compartment2_PreviousProduct1TradeName = "CHARLIE PRODUCT";
        public static string Arrival_ContainerState_Compartment2_PreviousProduct2MainName = "CHEMICAL PRODUCT";
        public static string Arrival_ContainerState_Compartment2_PreviousProduct2TradeName = "CHARLIE PRODUCT";
        public static string Arrival_ContainerState_Compartment2_PreviousProduct3MainName = "CHEMICAL PRODUCT";
        public static string Arrival_ContainerState_Compartment2_PreviousProduct3TradeName = "CHARLIE PRODUCT";


        //1C - LESSEE HEATING & TRANSHIPMENT ORDER INFO
        public static bool Lessee_HeatingServiceRequest = false;
        public static double? Lessee_HeatingServiceRequest_TargetTemperature = null;
        public static string Lessee_HeatingServiceRequest_TargetTemperatureUnit = "C";
        public static string Lessee_TranshipmentServiceRequest_AuthorizationReference = "AA23055-T";

        //1C - LESSEE OFFHIRE ORDER INFO
        public static string MessageIdentifier_Container_PreNotification_ConversationID = "d372cada-f69a-49fd-b090-31ed032f5b1a";
        public static string MessageIdentifier_Container_PreNotification_MessageID = "380d2c85-23cb-4ff6-8676-526910d504c9";
        public static string MessageIdentifier_Container_PreNotificationStatusUpdate_MessageID = "35fabb51-b415-46b9-8b24-51b4822cf740";
        public static string Orderflow_Container_PreNotification_ByLessee = "2000-01-01T06:52:00.0000000+01:00";

        public static string Arrival_ETA = "2000-01-01T11:00:00.0000000+01:00";

        public static string Lessee_OrderReference = "AA23055";
        public static string Lessee_RedeliveryReference = "REL5556";

        public static bool Lessee_StorageServiceRequest = true;

        public static bool Lessee_CleaningServiceRequest = true;
        public static string Lessee_CleaningServiceRequest_AuthorizationReference = "AA23055-C";
        public static bool Lessee_CleaningServiceRequest_RequestPolymerCleaning = false;
        public static string Lessee_CleaningServiceRequest_SpecialInstructionID = "";
        public static int Lessee_CleaningServiceRequest_AdditionalCleaningAction1_CompartmentNumber = 1;
        public static string Lessee_CleaningServiceRequest_AdditionalCleaningAction1_Code = "E90";
        public static int Lessee_CleaningServiceRequest_AdditionalCleaningAction1_Quantity = 1;

        public static bool Lessee_Work_RepairServiceRequest = true;
        public static string Lessee_Work_RepairServiceRequest_AuthorizationReference = "";
        public static string Lessee_Work_RepairServiceRequest_SpecialInstructionID = "PACKAGE DEAL A";

        public static string Remark_PreNotification_ID = "8ea3d430-06e8-4d42-a98f-1eb984f08ff2";
        public static string Remark_PreNotification_Date = "2000-01-01T06:52:00.0000000+01:00";
        public static string Remark_PreNotification_Author = "Oscar Operator";
        public static string Remark_PreNotification = "This is a remark";


        //2 - DEPOT INFO (depot, order process info, etc.)
        //2A - DEPOT BASIC
        public static string Depot_ID = "Delta Depot Inc.";
        public static string Depot_LocationID = "Houston";
        public static string Depot_Localization_CurrencyISO = "EUR";
        public static double Depot_Localization_CurrencyExchangeRate = 1;

        public static bool Depot_Localization_RoundingPerLine = true;
        public static double Depot_Pricing_MandR_LaborRate = 35.50;

        //2B - DEPOT PROFORMA INFO
        public static string Orderflow_Container_PreNotification_StatusUpdate_ByDepot = "2000-01-01T06:54:00.0000000+01:00";
        public static string Depot_ProformaReference = "PF2301010003";
        

        //2C - DEPOT ORDER PROCESS INFO
        public static string Depot_OrderReference = "D230101.0001";

        public static string MessageIdentifier_Container_GateInStatusUpdate_MessageID = "50bbfe89-751e-4a99-aa49-65ea265c2fb2";
        public static string Depot_OrderReference_GateIn = Depot_OrderReference + ".I1";
        public static string Orderflow_Container_StatusUpdate_GateIn_ByDepot = "2000-01-01T11:04:00.0000000+01:00";
        public static otf23.OrderStatusInfoOrderStatus Orderflow_Container_StatusUpdate_GateInStatusUpdate_ByDepot_Status = otf23.OrderStatusInfoOrderStatus.IN_UNCLEAN_CLEANING_PENDING_UNAUTHORIZED;
        public static string Orderflow_Container_StatusUpdate_GateInStatusUpdate_ByDepot_Status_Description = "IN_UNCLEAN_CLEANING_PENDING_UNAUTHORIZED";

        public static string MessageIdentifier_TankContainer_HeatingStatusUpdate_MessageID = "1e72f620-9fb9-4cf0-a330-cee6150fbbc7";
        public static string Depot_OrderReference_Heating = Depot_OrderReference + ".H1";
        public static string Orderflow_Container_StatusUpdate_Heating_ByDepot_Started = "2000-01-01T11:30:00.0000000+01:00";
        public static otf23.OrderStatusInfoOrderStatus Orderflow_Container_StatusUpdate_Heating_ByDepot_Status = otf23.OrderStatusInfoOrderStatus.IN_LOADED_HEATING_IN;
        public static string Orderflow_Container_StatusUpdate_Heating_ByDepot_StatusDescription = "IN_LOADED_HEATING_IN";

        public static string MessageIdentifier_TankContainer_TranshipmentStatusUpdate_MessageID = "35b0fcd5-b5d2-4112-836f-d18923b7c849";
        public static string Depot_OrderReference_Transhipment = Depot_OrderReference + ".T1";
        public static string Orderflow_Container_StatusUpdate_Transhipment_ByDepot_Planned = "2000-01-01T09:33:00.0000000+01:00";
        public static string Orderflow_Container_StatusUpdate_Transhipment_ByDepot_PlannedOn = "2000-01-01T19:00:00.0000000+01:00";
        public static string Orderflow_Container_StatusUpdate_Transhipment_ByDepot_Started = "2000-01-01T20:46:00.0000000+01:00";
        public static string Orderflow_Container_StatusUpdate_Transhipment_ByDepot_Finished = "2000-01-01T21:14:00.0000000+01:00";
        public static otf23.OrderStatusInfoOrderStatus Orderflow_Container_StatusUpdate_Transhipment_ByDepot_Status = otf23.OrderStatusInfoOrderStatus.IN_UNCLEAN_HEEL_PENDING_UNAUTHORIZED;
        public static string Orderflow_Container_StatusUpdate_Transhipment_ByDepot_Status_Description = "IN_UNCLEAN_HEEL_PENDING_UNAUTHORIZED";

        public static string MessageIdentifier_TankContainer_HeelDisposalStatusUpdate_MessageID = "0604a73d-d440-49a1-8c23-f88e11b9fb8e";
        public static string Depot_OrderReference_HeelDisposal = Depot_OrderReference + ".HE1";
        public static string Orderflow_Container_StatusUpdate_HeelDisposal_ByDepot_Started = "2000-01-01T11:45:00.0000000+01:00";
        public static string Orderflow_Container_StatusUpdate_HeelDisposal_ByDepot_Finished = "2000-01-01T11:55:00.0000000+01:00";
        public static otf23.OrderStatusInfoOrderStatus Orderflow_Container_StatusUpdate_HeelDisposal_ByDepot_Status = otf23.OrderStatusInfoOrderStatus.IN_UNCLEAN_CLEANING_PENDING_UNAUTHORIZED;
        public static string Orderflow_Container_StatusUpdate_HeelDisposal_ByDepot_Status_Description = "IN_UNCLEAN_CLEANING_PENDING_UNAUTHORIZED";

        public static string MessageIdentifier_TankContainer_CleaningStatusUpdate_MessageID = "31a40ee4-9f12-4411-8ac2-a70f22c530c2";
        public static string Depot_OrderReference_Cleaning = Depot_OrderReference + ".C1";
        public static string Orderflow_Container_StatusUpdate_Cleaning_ByDepot_Started = "2000-01-01T12:01:00.0000000+01:00";
        public static string Orderflow_Container_StatusUpdate_Cleaning_ByDepot_Finished = "2000-01-01T12:23:00.0000000+01:00";
        public static string Orderflow_Container_StatusUpdate_Cleaning_ByDepot_CleaningCertificateID = "BE6000001";
        public static otf23.OrderStatusInfoOrderStatus Orderflow_Container_StatusUpdate_Cleaning_ByDepot_Status = otf23.OrderStatusInfoOrderStatus.IN_CLEAN_REPAIR_PENDING_UNAUTHORIZED;
        public static string Orderflow_Container_StatusUpdate_Cleaning_ByDepot_Status_Description = "IN_CLEAN_REPAIR_PENDING_UNAUTHORIZED";

        public static string MessageIdentifier_Container_Work_Repair_ConversationID = "3e818a60-5941-4615-911e-e1f540d6f314";
        public static string MessageIdentifier_Container_Work_Repair_Estimate_MessageID = "3995e18b-73a7-46e0-b92b-381d2b5aa527";
        public static string MessageIdentifier_Container_Work_Repair_StatusUpdate_MessageID = "ad47590-acd7-4f7d-b8b1-9d422f00b994";
        public static string Depot_OrderReference_Work = Depot_OrderReference + ".R1";

        public static otf23.OrderStatusInfoOrderStatus Orderflow_Container_StatusUpdate_Work_Estimate_ByDepot_Status = otf23.OrderStatusInfoOrderStatus.IN_CLEAN_REPAIR_ESTIMATED_UNAUTHORIZED;
        public static string Orderflow_Container_StatusUpdate_Work_Estimate_ByDepot_Status_Description = "IN_CLEAN_REPAIR_ESTIMATED_UNAUTHORIZED";
        public static string Orderflow_Container_StatusUpdate_Work_ByDepot_Estimate_Finished = "2000-01-02T16:23:00.0000000+01:00";
        public static string Orderflow_Container_StatusUpdate_Work_Repair_ByDepot_LessorAuthorizationDate = "2000-01-02T17:23:00.0000000+01:00";
        public static string Orderflow_Container_StatusUpdate_Work_Repair_ByDepot_Work_Started = "2000-01-03T08:55:00.0000000+01:00";
        public static otf23.OrderStatusInfoOrderStatus Orderflow_Container_StatusUpdate_Work_Repair_ByDepot_Status = otf23.OrderStatusInfoOrderStatus.IN_CLEAN_REPAIR_IN_AUTHORIZED;
        public static string Orderflow_Container_StatusUpdate_Work_Repair_ByDepot_Status_Description = "IN_CLEAN_REPAIR_IN_AUTHORIZED";
        public static string MessageIdentifier_TankContainer_InspectionStatusUpdate_MessageID = "9dacc705-e77f-4c49-890d-d66bfbec04eb";
        public static string Depot_OrderReference_Inspection = Depot_OrderReference + ".A1";
        public static string Orderflow_Container_StatusUpdate_Inspection_ByDepot_Started = "2000-01-04T14:21:00.0000000+01:00";
        public static string Orderflow_Container_StatusUpdate_Inspection_ByDepot_Status_Description = "IN Inspection";

        public static string MessageIdentifier_Container_AvailableStatusUpdate_MessageID = "83cabe25-bdaa-4bc0-aa52-24526edc4ac1";
        public static string Orderflow_Container_StatusUpdate_Available_ByDepot = "2000-01-05T16:00:00.0000000+01:00";
        public static otf23.OrderStatusInfoOrderStatus Orderflow_Container_StatusUpdate_Available_ByDepot_Status = otf23.OrderStatusInfoOrderStatus.IN_CLEAN_AVAILABLE;
        public static string Orderflow_Container_StatusUpdate_Available_ByDepot_Status_Description = "IN_CLEAN_AVAILABLE";

        public static string MessageIdentifier_Container_GateOutStatusUpdate_MessageID = "25b1b798-308c-4ed8-92e4-60b3935a09e0";
        public static string Depot_OrderReference_GateOut = Depot_OrderReference + ".O1";
        public static string Orderflow_Container_StatusUpdate_GateOut_ByDepot = "2000-01-09T09:00:00.0000000+01:00";
        public static otf23.OrderStatusInfoOrderStatus Orderflow_Container_StatusUpdate_GateOut_ByDepot_Status = otf23.OrderStatusInfoOrderStatus.OUT;
        public static string Orderflow_Container_StatusUpdate_GateOut_ByDepot_Status_Description = "OUT";

        //2D - DEPOT M&R INFO

        //M&R Repair Info
        public static string Orderflow_Container_Work_Repair_ByDepot_Version = "V1";
        public static string Orderflow_Container_Work_Repair_ByDepot_EstimatorName = "Eddy Estimator";
        public static string Orderflow_Container_Work_Repair_ByDepot_DefaultCodesetName = "Classic codes";
        public static string Orderflow_Container_Work_Repair_EstimateLineInfo1_MandREstimateLineID = "162012ca-015b-4f4d-92f7-bcef9f8f438d";
        public static string Orderflow_Container_Work_Repair_EstimateLineInfo1_MandREstimateLineOriginID = "1855";
        public static int Orderflow_Container_Work_Repair_EstimateLineInfo1_SortOrder = 1;
        public static string Orderflow_Container_Work_Repair_EstimateLineInfo1_Description = "REMOVE AND REBUILD BUTTERFLY VALVE";
        public static string Orderflow_Container_Work_Repair_EstimateLineInfo1_CategoryCode = "GEN";
        public static string Orderflow_Container_Work_Repair_EstimateLineInfo1_CategoryCodeDescription = "GENERAL";
        public static string Orderflow_Container_Work_Repair_EstimateLineInfo1_LocationCode = "BTM";
        public static string Orderflow_Container_Work_Repair_EstimateLineInfo1_LocationCodeDescription = "BOTTOM";
        public static string Orderflow_Container_Work_Repair_EstimateLineInfo1_DamageCode = "";
        public static string Orderflow_Container_Work_Repair_EstimateLineInfo1_DamageCodeDescription = "";
        public static string Orderflow_Container_Work_Repair_EstimateLineInfo1_RepairCode = "";
        public static string Orderflow_Container_Work_Repair_EstimateLineInfo1_RepairCodeDescription = "";
        public static double Orderflow_Container_Work_Repair_EstimateLineInfo1_LaborHours = 2;
        public static double Orderflow_Container_Work_Repair_EstimateLineInfo1_MaterialPrice = 71.00;
        public static double Orderflow_Container_Work_Repair_EstimateLineInfo1_LumpSumPrice = 0;
        public static double Orderflow_Container_Work_Repair_EstimateLineInfo1_Quantity = 1;
        public static bool Orderflow_Container_Work_Repair_EstimateLineInfo1_DoAction = true;
        public static bool Orderflow_Container_Work_Repair_EstimateLineInfo1_ThirdParty = false;
        public static string Orderflow_Container_Work_Repair_EstimateLineInfo2_MandREstimateLineID = "642e95fa-9872-4013-ae44-3c2c7c1d3e4e";
        public static string Orderflow_Container_Work_Repair_EstimateLineInfo2_MandREstimateLineOriginID = "777";
        public static int Orderflow_Container_Work_Repair_EstimateLineInfo2_SortOrder = 2;
        public static string Orderflow_Container_Work_Repair_EstimateLineInfo2_Description = "REPLACE DOME GASKET";
        public static string Orderflow_Container_Work_Repair_EstimateLineInfo2_CategoryCode = "GEN";
        public static string Orderflow_Container_Work_Repair_EstimateLineInfo2_CategoryCodeDescription = "GENERAL";
        public static string Orderflow_Container_Work_Repair_EstimateLineInfo2_LocationCode = "BTM";
        public static string Orderflow_Container_Work_Repair_EstimateLineInfo2_LocationCodeDescription = "BOTTOM";
        public static string Orderflow_Container_Work_Repair_EstimateLineInfo2_DamageCode = "BR";
        public static string Orderflow_Container_Work_Repair_EstimateLineInfo2_DamageCodeDescription = "BROKEN";
        public static string Orderflow_Container_Work_Repair_EstimateLineInfo2_RepairCode = "";
        public static string Orderflow_Container_Work_Repair_EstimateLineInfo2_RepairCodeDescription = "";
        public static double Orderflow_Container_Work_Repair_EstimateLineInfo2_LaborHours = 3;
        public static double Orderflow_Container_Work_Repair_EstimateLineInfo2_MaterialPrice = 20.00;
        public static double Orderflow_Container_Work_Repair_EstimateLineInfo2_LumpSumPrice = 50;
        public static double Orderflow_Container_Work_Repair_EstimateLineInfo2_Quantity = 2;
        public static bool Orderflow_Container_Work_Repair_EstimateLineInfo2_DoAction = true;
        public static bool Orderflow_Container_Work_Repair_EstimateLineInfo2_ThirdParty = false;

        public static string Remark_Work_Repair_ID = "121fdc2d-f169-4e39-b951-61a18a093ed3";
        public static string Remark_Work_Repair_Date = "2000-01-02T16:23:00.0000000+01:00";
        public static string Remark_Work_Repair_Author = "Eddy Estimator";
        public static string Remark_Work_Repair = "This is a remark";

        //3 - LESSOR INFO (lessor, container information
        //3A - LESSOR BASIC
        public static string Lessor_ID = "Lima Leasing Inc.";

        //3B - LESSOR OFFHIRE INFO
        public static string Lessor_Work_RepairServiceRequest_AuthorizationReference = "REP5559";
        public static bool Lessor_InspectionServiceRequest = true;
        public static string Lessor_InspectionServiceRequest_SpecialInstructionID = "2.5 YR TEST";

        //3C - LESSOR FLEET MANAGEMENT INFO
        public static string ContainerManufacturer = "Mike Manufacturer NV";
        public static string ContainerBuildingYear = "1996-11-25T20:30:00.0000000+01:00";
        public static int ContainerCapacity = 20080;
        public static string LastTestDate = "1998-06-20T00:00:00.0000000+01:00";
        public static string LastTestType = "H";
        public static string CSCDate = "1999-01-01T00:00:00.0000000+01:00";

        //3D - LESSOR ONHIRE INFO
        public static string Lessor_OrderReference = "XX2251";
        public static string Lessor_ReleaseReference = "";

        public static string Departure_ContainerDestination = "935 Pennsylvania Avenue NW, Washington D.C.";
        public static string Departure_HaulierName = "Tango Transport Inc.";
        public static string Departure_TruckDriverName = "Tina Truck Driver";
        public static string Departure_TruckLicensePlate = "BBB-111";

        //4 - INSPECTION BUREAU
        public static string MessageIdentifier_TankContainer_Inspection_MessageID = "56c03e52-2436-4573-927a-641662d4124d";
        public static string InspectionBureauID = "India Inspection Bureau Inc.";
        public static string SurveyorName = "Simon Surveyor";
        public static string InspectionHardcopyURL = "https://indiainspectionbureau/credentials/order/inspectionreport_hardcopy.pdf";

        public static string Inspection_IMDG = "AA/AAA/AA 00000";
        public static string Inspection_RID_ADR = "AA/AA/AA 00000";
        public static string Inspection_CSC = "AA/AA 00000-00/00";
        public static string Inspection_USDOT = "AA 000";
        public static string Inspection_RID_ADRCode = "A0AA";

        public static string InspectionRemark = "Inspection remark";

        //5 - Spare Parts
        public static string SparePartsManufacturer = "Sierra Spare Parts Supplier Inc.";
    }
}
