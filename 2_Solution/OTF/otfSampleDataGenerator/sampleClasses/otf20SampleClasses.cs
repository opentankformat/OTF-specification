using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OTF.SampleGenerator;
using otf20;
using otfSampleDataGenerator.utils;

namespace otfSampleDataGenerator.sampleClasses
{
    public static class otf20SampleClasses
    {
		public static void GenerateSampleMessages(string targetFolder)
        {
			//PreNotification flow
			Utils.GenerateSamples(sample_Message_Container_PreNotification(), string.Format("{0}{1}", targetFolder, "sample_Message_Container_PreNotification"));
			Utils.GenerateSamples(sample_Message_Container_PreNotification_StatusUpdate(), string.Format("{0}{1}", targetFolder, "sample_Message_Container_PreNotification_StatusUpdate"));

			//Status updates
			Utils.GenerateSamples(sample_Message_Container_StatusUpdate_Storage_Arrival(), string.Format("{0}{1}", targetFolder, "sample_Message_Container_StatusUpdate_Storage_Arrival"));
			Utils.GenerateSamples(sample_Message_Container_StatusUpdate_Storage_Available(), string.Format("{0}{1}", targetFolder, "sample_Message_Container_StatusUpdate_Storage_Available"));
			Utils.GenerateSamples(sample_Message_Container_StatusUpdate_Storage_Departure(), string.Format("{0}{1}", targetFolder, "sample_Message_Container_StatusUpdate_Storage_Departure"));
			Utils.GenerateSamples(sample_Message_TankContainer_StatusUpdate_Cleaning(), string.Format("{0}{1}", targetFolder, "sample_Message_TankContainer_StatusUpdate_Cleaning"));
			Utils.GenerateSamples(sample_Message_TankContainer_StatusUpdate_Heating(), string.Format("{0}{1}", targetFolder, "sample_Message_TankContainer_StatusUpdate_Heating"));
			Utils.GenerateSamples(sample_Message_TankContainer_StatusUpdate_Inspection(), string.Format("{0}{1}", targetFolder, "sample_Message_TankContainer_StatusUpdate_Inspection"));
			Utils.GenerateSamples(sample_Message_TankContainer_StatusUpdate_Transhipment(), string.Format("{0}{1}", targetFolder, "sample_Message_TankContainer_StatusUpdate_Transhipment"));

			//Work flow
			Utils.GenerateSamples(sample_Message_Container_Work_Estimate(), string.Format("{0}{1}", targetFolder, "sample_Message_Container_Work_Estimate"));
			Utils.GenerateSamples(sample_Message_Container_StatusUpdate_Work(), string.Format("{0}{1}", targetFolder, "sample_Message_Container_StatusUpdate_Work"));

			//Inspection Certificates
			Utils.GenerateSamples(sample_Message_TankContainer_InspectionReport(), string.Format("{0}{1}", targetFolder, "sample_Message_TankContainer_InspectionReport"));
		}

		#region "PreNotification"
		static Message_Container_PreNotification sample_Message_Container_PreNotification()
        {
			Message_Container_PreNotification m = new Message_Container_PreNotification
			{
				MessageHeaderInfo = new MessageHeaderInfo
				{
					MessageID = SampleData.MessageIdentifier_Container_PreNotification_MessageID,
					ConversationID = SampleData.MessageIdentifier_Container_PreNotification_ConversationID,
					SenderID = SampleData.Lessee_ID,
					RecipientID = SampleData.Depot_ID,
					ContactName = SampleData.Lessee_ContactName,
					SentDate = DateTime.Parse(SampleData.Orderflow_Container_PreNotification_ByLessee),
					MessageType = MessageHeaderInfoMessageType.New,
				},
				ContainerPreNotificationType = Message_Container_PreNotificationContainerPreNotificationType.Redelivery,
				OrderInfo = new OrderInfo
				{
					SupplierID = SampleData.Depot_ID,
					SupplierLocationID = SampleData.Depot_LocationID,
					ClientID = SampleData.Lessor_ID,
					ClientOrderReference = SampleData.Lessor_OrderReference
				},
				ContainerInfo = new ContainerInfo
				{
					ContainerNumber = SampleData.ContainerNumber,
					ContainerType = SampleData.ContainerType
				},
				ArrivalInfo = new Message_Container_PreNotificationArrivalInfo
				{
					ETA = DateTime.Parse(SampleData.Arrival_ETA),
					RedeliveryReference = SampleData.Lessee_RedeliveryReference,
					Container_HaulierInfo = new Container_HaulierInfo
					{
						HaulierName = SampleData.Arrival_HaulierName,
						TruckDriverName = SampleData.Arrival_TruckDriverName,
						TruckLicensePlate = SampleData.Arrival_TruckLicensePlate,
					},
					TankContainer_StateInfo = new TankContainer_StateInfo
					{
						IsLoaded = SampleData.Arrival_ContainerState_IsLoaded,
						FullLoadedAmount = (SampleData.Arrival_ContainerState_Compartment1_LoadedAmount + SampleData.Arrival_ContainerState_Compartment2_LoadedAmount),
						FullLoadedAmountUnit = SampleData.Arrival_ContainerState_LoadedAmountUnit,
						IsClean = false,
						IsPressurized = true,
						IsNitrogen = false,
						Compartments = new TankContainer_CompartmentsTankContainer_Compartment[]
						{
							new TankContainer_CompartmentsTankContainer_Compartment
							{
								CompartmentNumber = 1,
								CurrentProduct = new TankContainer_CompartmentsTankContainer_CompartmentCurrentProduct
								{
									ProductInfo = new ProductInfo
									{
										MainName = SampleData.Arrival_ContainerState_Compartment1_CurrentProductMainName,
										TradeName = SampleData.Arrival_ContainerState_Compartment1_CurrentProductTradeName
									},
									LoadedAmount = SampleData.Arrival_ContainerState_Compartment1_LoadedAmount,
									LoadedAmountUnit = SampleData.Arrival_ContainerState_LoadedAmountUnit
								},
								PreviousProduct1 = new TankContainer_CompartmentsTankContainer_CompartmentPreviousProduct1
								{
									ProductInfo = new ProductInfo
									{
										MainName = SampleData.Arrival_ContainerState_Compartment1_PreviousProduct1MainName,
										TradeName = SampleData.Arrival_ContainerState_Compartment1_PreviousProduct1TradeName
									}
								},
								PreviousProduct2 = new TankContainer_CompartmentsTankContainer_CompartmentPreviousProduct2
								{
									ProductInfo = new ProductInfo
									{
										MainName = SampleData.Arrival_ContainerState_Compartment1_PreviousProduct2MainName,
										TradeName = SampleData.Arrival_ContainerState_Compartment1_PreviousProduct2TradeName
									}
								},
								PreviousProduct3 = new TankContainer_CompartmentsTankContainer_CompartmentPreviousProduct3
								{
									ProductInfo = new ProductInfo
									{
										MainName = SampleData.Arrival_ContainerState_Compartment1_PreviousProduct3MainName,
										TradeName = SampleData.Arrival_ContainerState_Compartment1_PreviousProduct3TradeName
									}
								}
							},
							new TankContainer_CompartmentsTankContainer_Compartment
							{
								CompartmentNumber = 2,
								CurrentProduct = new TankContainer_CompartmentsTankContainer_CompartmentCurrentProduct
								{
									ProductInfo = new ProductInfo
									{
										MainName = SampleData.Arrival_ContainerState_Compartment2_CurrentProductMainName,
									},
									LoadedAmount = SampleData.Arrival_ContainerState_Compartment2_LoadedAmount,
									LoadedAmountUnit = SampleData.Arrival_ContainerState_LoadedAmountUnit
								},
								PreviousProduct1 = new TankContainer_CompartmentsTankContainer_CompartmentPreviousProduct1
								{
									ProductInfo = new ProductInfo
									{
										MainName = SampleData.Arrival_ContainerState_Compartment2_PreviousProduct1MainName,
										TradeName = SampleData.Arrival_ContainerState_Compartment2_PreviousProduct1TradeName
									}
								},
								PreviousProduct2 = new TankContainer_CompartmentsTankContainer_CompartmentPreviousProduct2
								{
									ProductInfo = new ProductInfo
									{
										MainName = SampleData.Arrival_ContainerState_Compartment2_PreviousProduct2MainName,
										TradeName = SampleData.Arrival_ContainerState_Compartment2_PreviousProduct2TradeName
									}
								},
								PreviousProduct3 = new TankContainer_CompartmentsTankContainer_CompartmentPreviousProduct3
								{
									ProductInfo = new ProductInfo
									{
										MainName = SampleData.Arrival_ContainerState_Compartment2_PreviousProduct3MainName,
										TradeName = SampleData.Arrival_ContainerState_Compartment2_PreviousProduct3TradeName
									}
								}
							},
						}
					}

				},
				ServicesRequestInfo = new Message_Container_PreNotificationServicesRequestInfo
				{
					Container_ServiceRequest_Storage = new Container_ServiceRequest_Storage
					{
						Container_ServiceRequestInfo = new Container_ServiceRequestInfo
						{
							IsRequested = true,
						}
					},
					TankContainer_ServiceRequest_Cleaning = new TankContainer_ServiceRequest_Cleaning
					{
						Container_ServiceRequestInfo = new Container_ServiceRequestInfo
						{
							IsRequested = true,
							ClientAuthorizationReference = SampleData.Lessee_CleaningServiceRequest_AuthorizationReference
						},
						RequestPolymerCleaning = SampleData.Lessee_CleaningServiceRequest_RequestPolymerCleaning,
						AdditionalCleaningActions = new TankContainer_CleaningActionsTankContainer_CleaningAction[]
						{
							new TankContainer_CleaningActionsTankContainer_CleaningAction
							{
								CompartmentNumber = SampleData.Lessee_CleaningServiceRequest_AdditionalCleaningAction1_CompartmentNumber,
								Quantity = SampleData.Lessee_CleaningServiceRequest_AdditionalCleaningAction1_Quantity,
								ActionID = SampleData.Lessee_CleaningServiceRequest_AdditionalCleaningAction1_Code
							}
						}

					},
					Container_ServiceRequest_Work_Repair = new Container_ServiceRequest_Work_Repair
					{
						IsRequested = true,
						LessorID = SampleData.Lessor_ID,
						LessorAuthorizationReference = SampleData.Lessor_Work_RepairServiceRequest_AuthorizationReference,
						LesseeID = SampleData.Lessee_ID,
						LesseeAuthorizationReference = SampleData.Lessee_Work_RepairServiceRequest_AuthorizationReference

					}

				},
				DepartureInfo = new Message_Container_PreNotificationDepartureInfo
				{
					ReleaseReference = SampleData.Lessor_ReleaseReference,
					ContainerDestination = SampleData.Departure_ContainerDestination,

					Container_HaulierInfo = new Container_HaulierInfo
					{
						HaulierName = SampleData.Departure_HaulierName,
						TruckDriverName = SampleData.Departure_TruckDriverName,
						TruckLicensePlate = SampleData.Departure_TruckLicensePlate,
					}
				},
				Remarks = new RemarksRemark[]
				{
					new RemarksRemark
					{
						RemarkID = SampleData.Remark_PreNotification_ID,
						RemarkDate = DateTime.Parse(SampleData.Remark_PreNotification_Date),
						RemarkAuthor = SampleData.Remark_PreNotification_Author,
						RemarkText = SampleData.Remark_PreNotification
                    }
                }
			
			};

			return m;
		}
		static Message_Container_PreNotification_StatusUpdate sample_Message_Container_PreNotification_StatusUpdate()
		{
			Message_Container_PreNotification_StatusUpdate m = new Message_Container_PreNotification_StatusUpdate
			{
				MessageHeaderInfo = new MessageHeaderInfo
				{
					MessageID = SampleData.MessageIdentifier_Container_PreNotificationStatusUpdate_MessageID,
					ConversationID = SampleData.MessageIdentifier_Container_PreNotification_ConversationID,
					SenderID = SampleData.Depot_ID,
					RecipientID = SampleData.Lessee_ID,
					ContactName = SampleData.Lessee_ContactName,
					SentDate = DateTime.Parse(SampleData.Orderflow_Container_PreNotification_StatusUpdate_ByDepot),
					MessageType = MessageHeaderInfoMessageType.New,
				},
				OrderInfo = new OrderInfo
				{
					SupplierID = SampleData.Depot_ID,
					SupplierLocationID = SampleData.Depot_LocationID,
					SupplierProformaReference = SampleData.Depot_ProformaReference,
					ClientID = SampleData.Lessor_ID,
					ClientOrderReference = SampleData.Lessor_OrderReference
				},
				ContainerInfo = new ContainerInfo
				{
					ContainerNumber = SampleData.ContainerNumber,
					ContainerType = SampleData.ContainerType
				},
				PreNotificationStatus = new Message_Container_PreNotification_StatusUpdatePreNotificationStatus
				{
					Status = Message_Container_PreNotification_StatusUpdatePreNotificationStatusStatus.Approved
				}
			};

			return m;
		}
        #endregion

        #region "Status updates"
        static Message_Container_StatusUpdate_Storage_Arrival sample_Message_Container_StatusUpdate_Storage_Arrival()
        {
			Message_Container_StatusUpdate_Storage_Arrival m = new Message_Container_StatusUpdate_Storage_Arrival
			{
				MessageHeaderInfo = new MessageHeaderInfo
				{
					MessageID = SampleData.MessageIdentifier_Container_GateInStatusUpdate_MessageID,
					SenderID = SampleData.Depot_ID,
					RecipientID = SampleData.Lessee_ID,
					ContactName = SampleData.Lessee_ContactName,
					SentDate = DateTime.Parse(SampleData.Orderflow_Container_StatusUpdate_GateIn_ByDepot),
					MessageType = MessageHeaderInfoMessageType.New,
				},
				OrderInfo = new OrderInfo
				{
					SupplierID = SampleData.Depot_ID,
					SupplierLocationID = SampleData.Depot_LocationID,
					SupplierOrderReference = SampleData.Depot_OrderReference,
					OrderStatusInfo = new OrderStatusInfo
                    {
						OrderStatusDescription = SampleData.Orderflow_Container_StatusUpdate_GateInStatusUpdate_ByDepot
					},
					ClientID = SampleData.Lessor_ID,
					ClientOrderReference = SampleData.Lessor_OrderReference		
				},
				ContainerInfo = new ContainerInfo
				{
					ContainerNumber = SampleData.ContainerNumber,
					ContainerType = SampleData.ContainerType
				},
				ContainerStorageArrivalInfo = new Message_Container_StatusUpdate_Storage_ArrivalContainerStorageArrivalInfo
				{
					ClientDeliveryReference = SampleData.Lessee_RedeliveryReference,
					ContainerDeliveryDate = DateTime.Parse(SampleData.Orderflow_Container_StatusUpdate_GateIn_ByDepot)
				}
			};

			return m;
		}

		static Message_Container_StatusUpdate_Storage_Available sample_Message_Container_StatusUpdate_Storage_Available()
		{
			Message_Container_StatusUpdate_Storage_Available m = new Message_Container_StatusUpdate_Storage_Available
			{
				MessageHeaderInfo = new MessageHeaderInfo
				{
					MessageID = SampleData.MessageIdentifier_Container_AvailableStatusUpdate_MessageID,
					SenderID = SampleData.Depot_ID,
					RecipientID = SampleData.Lessor_ID,
					SentDate = DateTime.Parse(SampleData.Orderflow_Container_StatusUpdate_Available_ByDepot),
					MessageType = MessageHeaderInfoMessageType.New,
				},
				OrderInfo = new OrderInfo
				{
					SupplierID = SampleData.Depot_ID,
					SupplierLocationID = SampleData.Depot_LocationID,
					SupplierOrderReference = SampleData.Depot_OrderReference,
					OrderStatusInfo = new OrderStatusInfo
					{
						OrderStatusDescription = SampleData.Orderflow_Container_StatusUpdate_Available_ByDepot_StatusDescription
					},
					ClientID = SampleData.Lessor_ID,
					ClientOrderReference = SampleData.Lessor_OrderReference
				},
				ContainerInfo = new ContainerInfo
				{
					ContainerNumber = SampleData.ContainerNumber,
					ContainerType = SampleData.ContainerType
				},
				ContainerStorageAvailableInfo = new Message_Container_StatusUpdate_Storage_AvailableContainerStorageAvailableInfo
				{
					ContainerAvailableDate = DateTime.Parse(SampleData.Orderflow_Container_StatusUpdate_Available_ByDepot)
				}
			};
			return m;
		} 

		static Message_Container_StatusUpdate_Storage_Departure sample_Message_Container_StatusUpdate_Storage_Departure()
		{
			Message_Container_StatusUpdate_Storage_Departure m = new Message_Container_StatusUpdate_Storage_Departure
			{
				MessageHeaderInfo = new MessageHeaderInfo
				{
					MessageID = SampleData.MessageIdentifier_Container_GateOutStatusUpdate_MessageID,
					SenderID = SampleData.Depot_ID,
					RecipientID = SampleData.Lessor_ID,
					SentDate = DateTime.Parse(SampleData.Orderflow_Container_StatusUpdate_GateOut_ByDepot),
					MessageType = MessageHeaderInfoMessageType.New,
				},
				OrderInfo = new OrderInfo
				{
					SupplierID = SampleData.Depot_ID,
					SupplierLocationID = SampleData.Depot_LocationID,
					SupplierOrderReference = SampleData.Depot_OrderReference,
					OrderStatusInfo = new OrderStatusInfo
					{
						OrderStatusDescription = SampleData.Orderflow_Container_StatusUpdate_GateOut_ByDepot_StatusDescription
					},
					ClientID = SampleData.Lessor_ID,
					ClientOrderReference = SampleData.Lessor_OrderReference
				},
				ContainerInfo = new ContainerInfo
				{
					ContainerNumber = SampleData.ContainerNumber,
					ContainerType = SampleData.ContainerType
				},
				ContainerStorageDepartureInfo = new Message_Container_StatusUpdate_Storage_DepartureContainerStorageDepartureInfo
				{
					ClientReleaseReference = SampleData.Lessor_ReleaseReference,
					ContainerReleaseDate = DateTime.Parse(SampleData.Orderflow_Container_StatusUpdate_GateOut_ByDepot)
				}
			};
			return m;
		} 

		static Message_TankContainer_StatusUpdate_Cleaning sample_Message_TankContainer_StatusUpdate_Cleaning()
		{
			Message_TankContainer_StatusUpdate_Cleaning m = new Message_TankContainer_StatusUpdate_Cleaning
			{
				MessageHeaderInfo = new MessageHeaderInfo
				{
					MessageID = SampleData.MessageIdentifier_TankContainer_CleaningStatusUpdate_MessageID,
					SenderID = SampleData.Depot_ID,
					RecipientID = SampleData.Lessee_ID,
					ContactName = SampleData.Lessee_ContactName,
					SentDate = DateTime.Parse(SampleData.Orderflow_Container_StatusUpdate_Cleaning_ByDepot_Finished),
					MessageType = MessageHeaderInfoMessageType.New,
				},
				OrderInfo = new OrderInfo
				{
					SupplierID = SampleData.Depot_ID,
					SupplierLocationID = SampleData.Depot_LocationID,
					SupplierOrderReference = SampleData.Depot_OrderReference,
					OrderStatusInfo = new OrderStatusInfo
					{
						OrderStatusDescription = SampleData.Orderflow_Container_StatusUpdate_Cleaning_ByDepot_StatusDescription
					},
					ClientID = SampleData.Lessor_ID,
					ClientOrderReference = SampleData.Lessor_OrderReference
				},
				ContainerInfo = new ContainerInfo
				{
					ContainerNumber = SampleData.ContainerNumber,
					ContainerType = SampleData.ContainerType
				},
				Container_ServiceProgressInfo = new Container_ServiceProgressInfo
				{
					SupplierReference = SampleData.Depot_OrderReference_Cleaning,
					Container_ServiceProgress_AuthorizationInfo = new Container_ServiceProgress_AuthorizationInfo
					{
						AuthorizationReference = SampleData.Lessee_CleaningServiceRequest_AuthorizationReference
					},
					Container_ServiceProgress_DateInfo = new Container_ServiceProgress_DateInfo
					{
						Started = DateTime.Parse(SampleData.Orderflow_Container_StatusUpdate_Cleaning_ByDepot_Started),
						Finished = DateTime.Parse(SampleData.Orderflow_Container_StatusUpdate_Cleaning_ByDepot_Finished)
					}
				},
				TankContainerCleaningInfo = new Message_TankContainer_StatusUpdate_CleaningTankContainerCleaningInfo
				{
					CleaningCertificateID = SampleData.Orderflow_Container_StatusUpdate_Cleaning_ByDepot_CleaningCertificateID
				}
			};
			return m;
		} 

		static Message_TankContainer_StatusUpdate_Heating sample_Message_TankContainer_StatusUpdate_Heating()
		{
			Message_TankContainer_StatusUpdate_Heating m = new Message_TankContainer_StatusUpdate_Heating
			{
				MessageHeaderInfo = new MessageHeaderInfo
				{
					MessageID = SampleData.MessageIdentifier_TankContainer_HeatingStatusUpdate_MessageID,
					SenderID = SampleData.Depot_ID,
					RecipientID = SampleData.Lessee_ID,
					ContactName = SampleData.Lessee_ContactName,
					SentDate = DateTime.Parse(SampleData.Orderflow_Container_StatusUpdate_Heating_ByDepot_Started),
					MessageType = MessageHeaderInfoMessageType.New,
				},
				OrderInfo = new OrderInfo
				{
					SupplierID = SampleData.Depot_ID,
					SupplierLocationID = SampleData.Depot_LocationID,
					SupplierOrderReference = SampleData.Depot_OrderReference,
					OrderStatusInfo = new OrderStatusInfo
					{
						OrderStatusDescription = SampleData.Orderflow_Container_StatusUpdate_Heating_ByDepot_StatusDescription
					},
					ClientID = SampleData.Lessor_ID,
					ClientOrderReference = SampleData.Lessor_OrderReference
				},
				ContainerInfo = new ContainerInfo
				{
					ContainerNumber = SampleData.ContainerNumber,
					ContainerType = SampleData.ContainerType
				},
				Container_ServiceProgressInfo = new Container_ServiceProgressInfo
				{
					SupplierReference = SampleData.Depot_OrderReference_Heating,
					Container_ServiceProgress_DateInfo = new Container_ServiceProgress_DateInfo
					{
						Started = DateTime.Parse(SampleData.Orderflow_Container_StatusUpdate_Heating_ByDepot_Started),
					}
				},
			};
			return m;
		}

		static Message_TankContainer_StatusUpdate_Inspection sample_Message_TankContainer_StatusUpdate_Inspection()
		{
			Message_TankContainer_StatusUpdate_Inspection m = new Message_TankContainer_StatusUpdate_Inspection
			{
				MessageHeaderInfo = new MessageHeaderInfo
				{
					MessageID = SampleData.MessageIdentifier_TankContainer_InspectionStatusUpdate_MessageID,
					SenderID = SampleData.Depot_ID,
					RecipientID = SampleData.Lessor_ID,
					SentDate = DateTime.Parse(SampleData.Orderflow_Container_StatusUpdate_Inspection_ByDepot_Started),
					MessageType = MessageHeaderInfoMessageType.New,
				},
				OrderInfo = new OrderInfo
				{
					SupplierID = SampleData.Depot_ID,
					SupplierLocationID = SampleData.Depot_LocationID,
					SupplierOrderReference = SampleData.Depot_OrderReference,
					OrderStatusInfo = new OrderStatusInfo
					{
						OrderStatusDescription = SampleData.Orderflow_Container_StatusUpdate_Inspection_ByDepot_StatusDescription
					},
					ClientID = SampleData.Lessor_ID,
					ClientOrderReference = SampleData.Lessor_OrderReference
				},
				ContainerInfo = new ContainerInfo
				{
					ContainerNumber = SampleData.ContainerNumber,
					ContainerType = SampleData.ContainerType
				},
				Container_ServiceProgressInfo = new Container_ServiceProgressInfo
				{
					SupplierReference = SampleData.Depot_OrderReference_Inspection,
					Container_ServiceProgress_DateInfo = new Container_ServiceProgress_DateInfo
					{
						Started = DateTime.Parse(SampleData.Orderflow_Container_StatusUpdate_Inspection_ByDepot_Started),
					}
				}
			};
			return m;
		}

		static Message_TankContainer_StatusUpdate_Transhipment sample_Message_TankContainer_StatusUpdate_Transhipment()
		{
			Message_TankContainer_StatusUpdate_Transhipment m = new Message_TankContainer_StatusUpdate_Transhipment
			{
				MessageHeaderInfo = new MessageHeaderInfo
				{
					MessageID = SampleData.MessageIdentifier_TankContainer_TranshipmentStatusUpdate_MessageID,
					SenderID = SampleData.Depot_ID,
					RecipientID = SampleData.Lessee_ID,
					ContactName = SampleData.Lessee_ContactName,
					SentDate = DateTime.Parse(SampleData.Orderflow_Container_StatusUpdate_Transhipment_ByDepot_Finished),
					MessageType = MessageHeaderInfoMessageType.New,
				},
				OrderInfo = new OrderInfo
				{
					SupplierID = SampleData.Depot_ID,
					SupplierLocationID = SampleData.Depot_LocationID,
					SupplierOrderReference = SampleData.Depot_OrderReference,
					OrderStatusInfo = new OrderStatusInfo
					{
						OrderStatusDescription = SampleData.Orderflow_Container_StatusUpdate_Transhipment_ByDepot_StatusDescription
					},
					ClientID = SampleData.Lessor_ID,
					ClientOrderReference = SampleData.Lessor_OrderReference
				},
				ContainerInfo = new ContainerInfo
				{
					ContainerNumber = SampleData.ContainerNumber,
					ContainerType = SampleData.ContainerType
				},
				Container_ServiceProgressInfo = new Container_ServiceProgressInfo
				{
					SupplierReference = SampleData.Depot_OrderReference_Transhipment,
					Container_ServiceProgress_DateInfo = new Container_ServiceProgress_DateInfo
					{
						Planned = DateTime.Parse(SampleData.Orderflow_Container_StatusUpdate_Transhipment_ByDepot_Planned),
						PlannedToTakePlaceOn = DateTime.Parse(SampleData.Orderflow_Container_StatusUpdate_Transhipment_ByDepot_PlannedOn),
						Started = DateTime.Parse(SampleData.Orderflow_Container_StatusUpdate_Transhipment_ByDepot_Started),
						Finished = DateTime.Parse(SampleData.Orderflow_Container_StatusUpdate_Transhipment_ByDepot_Finished)
					}
				}
			};
			return m;
		} 
		#endregion

		#region "Work flow"

		static Message_Container_Work_Estimate sample_Message_Container_Work_Estimate()
		{
			Message_Container_Work_Estimate m = new Message_Container_Work_Estimate
			{
				MessageHeaderInfo = new MessageHeaderInfo
				{
					MessageID = SampleData.MessageIdentifier_Container_Work_Repair_Estimate_MessageID,
					ConversationID = SampleData.MessageIdentifier_Container_Work_Repair_ConversationID,
					SenderID = SampleData.Depot_ID,
					RecipientID = SampleData.Lessor_ID,
					SentDate = DateTime.Parse(SampleData.Orderflow_Container_StatusUpdate_Work_ByDepot_Estimate_Finished),
					MessageType = MessageHeaderInfoMessageType.New,
				},
				OrderInfo = new OrderInfo
				{
					SupplierID = SampleData.Depot_ID,
					SupplierLocationID = SampleData.Depot_LocationID,
					SupplierOrderReference = SampleData.Depot_OrderReference,
					OrderStatusInfo = new OrderStatusInfo
					{
						OrderStatusDescription = SampleData.Orderflow_Container_StatusUpdate_Work_Estimate_ByDepot_StatusDescription
					},
					ClientID = SampleData.Lessor_ID,
					ClientOrderReference = SampleData.Lessor_OrderReference
				},
				LocalizationInfo = new LocalizationInfo()
				{
					CurrencyISO = SampleData.Depot_Localization_CurrencyISO
				},
				TankContainerInfo = new TankContainerInfo
				{
					ContainerInfo = new ContainerInfo
					{
						ContainerNumber = SampleData.ContainerNumber,
						ContainerType = SampleData.ContainerType
					},
					TankContainerCharacteristicsInfo = new TankContainerInfoTankContainerCharacteristicsInfo
					{
						Manufacturer = SampleData.ContainerManufacturer,
						BuildingYearMonth = DateTime.Parse(SampleData.ContainerBuildingYear),
						Capacity = SampleData.ContainerCapacity,
					},
					InspectionDates = new TankContainerInfoInspectionDates
					{
						LastInspectionDate = DateTime.Parse(SampleData.LastTestDate),
						LastInspectionScopeDescription = SampleData.LastTestType,
						CSCValidityDate = DateTime.Parse(SampleData.CSCDate)
					}
				},
				Container_Work_EstimateStatusInfo = new Container_Work_EstimateStatusInfo
				{
					ContainerWorkEstimateStatusInfo = new Container_Work_EstimateStatusInfoContainerWorkEstimateStatusInfo
					{
						Version = SampleData.Orderflow_Container_Work_Repair_ByDepot_Version,
						Container_ServiceProgress_DateInfo = new Container_ServiceProgress_DateInfo
						{
							Finished = DateTime.Parse(SampleData.Orderflow_Container_StatusUpdate_Work_ByDepot_Estimate_Finished)
						}
					},

					ContainerWorkAuthorizationInfo = new Container_Work_EstimateStatusInfoContainerWorkAuthorizationInfo
					{
						ContainerWorkLessorAuthorizationInfo = new Container_Work_EstimateStatusInfoContainerWorkAuthorizationInfoContainerWorkLessorAuthorizationInfo
						{
							LessorID = SampleData.Lessor_ID,
							Container_ServiceProgress_AuthorizationInfo = new Container_ServiceProgress_AuthorizationInfo
							{
								AuthorizationReference = SampleData.Lessor_Work_RepairServiceRequest_AuthorizationReference,
								Authorized = DateTime.Parse(SampleData.Orderflow_Container_StatusUpdate_Work_Repair_ByDepot_LessorAuthorizationDate)
							}
						}
					}
				},
				ContainerStorageArrivalInfo = new Message_Container_Work_EstimateContainerStorageArrivalInfo
				{
					ContainerDeliveryDate = DateTime.Parse(SampleData.Orderflow_Container_StatusUpdate_GateIn_ByDepot)
				},
				EstimateLines = new Container_Work_EstimateLinesContainer_Work_EstimateLine[]
				{
					 new Container_Work_EstimateLinesContainer_Work_EstimateLine
					 {
						 LineID = SampleData.Orderflow_Container_Work_Repair_EstimateLineInfo1_MandREstimateLineID,
						 OriginID = SampleData.Orderflow_Container_Work_Repair_EstimateLineInfo1_MandREstimateLineOriginID,
						 SortOrder = SampleData.Orderflow_Container_Work_Repair_EstimateLineInfo1_SortOrder,
						 Description = SampleData.Orderflow_Container_Work_Repair_EstimateLineInfo1_Description,
						 CategoryCode = new Container_Work_EstimateLinesContainer_Work_EstimateLineCategoryCode
						 {
							  Code = new Code
							  {
								  Value = SampleData.Orderflow_Container_Work_Repair_EstimateLineInfo1_CategoryCode,
								  Description = SampleData.Orderflow_Container_Work_Repair_EstimateLineInfo1_CategoryCodeDescription
							  }
						 },
						 GeneralCodes = new Container_Work_EstimateLinesContainer_Work_EstimateLineGeneralCodes
						 {
							  DamageCode =  new Container_Work_EstimateLinesContainer_Work_EstimateLineGeneralCodesDamageCode
							  {
								  Code = new Code
								  {
									Value =  SampleData.Orderflow_Container_Work_Repair_EstimateLineInfo1_DamageCode,
									Description = SampleData.Orderflow_Container_Work_Repair_EstimateLineInfo1_DamageCodeDescription
								  }
							  },
							  LocationCode = new Container_Work_EstimateLinesContainer_Work_EstimateLineGeneralCodesLocationCode
							  {
								  Code = new Code
								  {
									Value =  SampleData.Orderflow_Container_Work_Repair_EstimateLineInfo1_LocationCode,
									Description = SampleData.Orderflow_Container_Work_Repair_EstimateLineInfo1_LocationCodeDescription
								  }

							  },
							  RepairCode = new Container_Work_EstimateLinesContainer_Work_EstimateLineGeneralCodesRepairCode
							  {
								  Code = new Code
								  {
									Value =  SampleData.Orderflow_Container_Work_Repair_EstimateLineInfo1_RepairCode,
									Description = SampleData.Orderflow_Container_Work_Repair_EstimateLineInfo1_RepairCodeDescription
								  }

							  }
						 },
						 Proposal = new Container_Work_EstimateLinesContainer_Work_EstimateLineProposal
						 {
							  Container_Work_EstimateLineProposal = new Container_Work_EstimateLineProposal
							  {
								  LaborRate = SampleData.Depot_Pricing_MandR_LaborRate,
								  LaborHours = SampleData.Orderflow_Container_Work_Repair_EstimateLineInfo1_LaborHours,
								  MaterialPrice = SampleData.Orderflow_Container_Work_Repair_EstimateLineInfo1_MaterialPrice,
								  LineTotal = ((SampleData.Depot_Pricing_MandR_LaborRate*SampleData.Orderflow_Container_Work_Repair_EstimateLineInfo1_LaborHours)+SampleData.Orderflow_Container_Work_Repair_EstimateLineInfo1_MaterialPrice),
								  DoAction = SampleData.Orderflow_Container_Work_Repair_EstimateLineInfo1_DoAction,
							  }
						 }	
					 },
					 new Container_Work_EstimateLinesContainer_Work_EstimateLine
					 {
						 LineID = SampleData.Orderflow_Container_Work_Repair_EstimateLineInfo2_MandREstimateLineID,
						 OriginID = SampleData.Orderflow_Container_Work_Repair_EstimateLineInfo2_MandREstimateLineOriginID,
						 SortOrder = SampleData.Orderflow_Container_Work_Repair_EstimateLineInfo2_SortOrder,
						 Description = SampleData.Orderflow_Container_Work_Repair_EstimateLineInfo2_Description,
						 CategoryCode = new Container_Work_EstimateLinesContainer_Work_EstimateLineCategoryCode
						 {
							  Code = new Code
							  {
								  Value = SampleData.Orderflow_Container_Work_Repair_EstimateLineInfo2_CategoryCode,
								  Description = SampleData.Orderflow_Container_Work_Repair_EstimateLineInfo2_CategoryCodeDescription
							  }
						 },
						 GeneralCodes = new Container_Work_EstimateLinesContainer_Work_EstimateLineGeneralCodes
						 {
							  DamageCode =  new Container_Work_EstimateLinesContainer_Work_EstimateLineGeneralCodesDamageCode
							  {
								  Code = new Code
								  {
									Value =  SampleData.Orderflow_Container_Work_Repair_EstimateLineInfo2_DamageCode,
									Description = SampleData.Orderflow_Container_Work_Repair_EstimateLineInfo2_DamageCodeDescription
								  }
							  },
							  LocationCode = new Container_Work_EstimateLinesContainer_Work_EstimateLineGeneralCodesLocationCode
							  {
								  Code = new Code
								  {
									Value =  SampleData.Orderflow_Container_Work_Repair_EstimateLineInfo2_LocationCode,
									Description = SampleData.Orderflow_Container_Work_Repair_EstimateLineInfo2_LocationCodeDescription
								  }

							  },
							  RepairCode = new Container_Work_EstimateLinesContainer_Work_EstimateLineGeneralCodesRepairCode
							  {
								  Code = new Code
								  {
									Value =  SampleData.Orderflow_Container_Work_Repair_EstimateLineInfo2_RepairCode,
									Description = SampleData.Orderflow_Container_Work_Repair_EstimateLineInfo2_RepairCodeDescription
								  }

							  }
						 },
						 Proposal = new Container_Work_EstimateLinesContainer_Work_EstimateLineProposal
						 {
							  Container_Work_EstimateLineProposal = new Container_Work_EstimateLineProposal
							  {
								  LaborRate = SampleData.Depot_Pricing_MandR_LaborRate,
								  LaborHours = SampleData.Orderflow_Container_Work_Repair_EstimateLineInfo2_LaborHours,
								  MaterialPrice = SampleData.Orderflow_Container_Work_Repair_EstimateLineInfo2_MaterialPrice,
								  LumpSumPrice = SampleData.Orderflow_Container_Work_Repair_EstimateLineInfo2_LumpSumPrice,
								  LineTotal = SampleData.Orderflow_Container_Work_Repair_EstimateLineInfo2_LumpSumPrice,
								  DoAction = SampleData.Orderflow_Container_Work_Repair_EstimateLineInfo1_DoAction,
							  }
						 }
					}
				},
				Remarks = new RemarksRemark[]
                {
					new RemarksRemark
                    {
						RemarkID = SampleData.Remark_Work_Repair_ID,
						RemarkDate = DateTime.Parse(SampleData.Remark_Work_Repair_Date),
						RemarkAuthor = SampleData.Remark_Work_Repair_Author,
						RemarkText	= SampleData.Remark_Work_Repair
                    }
                }
				
			};
			return m;
		}

		static Message_Container_StatusUpdate_Work sample_Message_Container_StatusUpdate_Work()
		{
			Message_Container_StatusUpdate_Work m = new Message_Container_StatusUpdate_Work
			{
				MessageHeaderInfo = new MessageHeaderInfo
				{
					MessageID = SampleData.MessageIdentifier_Container_Work_Repair_StatusUpdate_MessageID,
					ConversationID = SampleData.MessageIdentifier_Container_Work_Repair_ConversationID,
					SenderID = SampleData.Depot_ID,
					RecipientID = SampleData.Lessor_ID,
					SentDate = DateTime.Parse(SampleData.Orderflow_Container_StatusUpdate_Work_Repair_ByDepot_Work_Started),
					MessageType = MessageHeaderInfoMessageType.New,
				},
				OrderInfo = new OrderInfo
				{
					SupplierID = SampleData.Depot_ID,
					SupplierLocationID = SampleData.Depot_LocationID,
					SupplierOrderReference = SampleData.Depot_OrderReference,
					OrderStatusInfo = new OrderStatusInfo
					{
						OrderStatusDescription = SampleData.Orderflow_Container_StatusUpdate_Work_Repair_ByDepot_StatusDescription
					},
					ClientID = SampleData.Lessor_ID,
					ClientOrderReference = SampleData.Lessor_OrderReference
				},
				ContainerInfo = new ContainerInfo
				{
					ContainerNumber = SampleData.ContainerNumber,
					ContainerType = SampleData.ContainerType
				},
				SupplierReference = SampleData.Depot_OrderReference_Work,
				Container_Work_EstimateStatusInfo = new Container_Work_EstimateStatusInfo
				{
					ContainerWorkEstimateStatusInfo = new Container_Work_EstimateStatusInfoContainerWorkEstimateStatusInfo
					{
						Version = SampleData.Orderflow_Container_Work_Repair_ByDepot_Version,
						Container_ServiceProgress_DateInfo = new Container_ServiceProgress_DateInfo
                        {
							Finished = DateTime.Parse(SampleData.Orderflow_Container_StatusUpdate_Work_ByDepot_Estimate_Finished)
						}
                    },
					ContainerWorkAuthorizationInfo = new Container_Work_EstimateStatusInfoContainerWorkAuthorizationInfo
                    {
						 ContainerWorkLessorAuthorizationInfo = new Container_Work_EstimateStatusInfoContainerWorkAuthorizationInfoContainerWorkLessorAuthorizationInfo
                         {
							  LessorID = SampleData.Lessor_ID,
							  Container_ServiceProgress_AuthorizationInfo = new Container_ServiceProgress_AuthorizationInfo
                              {
								 AuthorizationReference = SampleData.Lessor_Work_RepairServiceRequest_AuthorizationReference,
								 Authorized = DateTime.Parse(SampleData.Orderflow_Container_StatusUpdate_Work_Repair_ByDepot_LessorAuthorizationDate)
							  }
						 }
                    }
                },
				Container_Work_WorkStatusInfo = new Message_Container_StatusUpdate_WorkContainer_Work_WorkStatusInfo
                {
				   Container_ServiceProgress_DateInfo = new Container_ServiceProgress_DateInfo
                   {
						Started = DateTime.Parse(SampleData.Orderflow_Container_StatusUpdate_Work_Repair_ByDepot_Work_Started)
				   }
				}
			};
			return m;
		}

		#endregion

		#region "Inspection Certificates"
		static Message_TankContainer_InspectionReport sample_Message_TankContainer_InspectionReport()
		{
			Message_TankContainer_InspectionReport m = new Message_TankContainer_InspectionReport
			{
				MessageHeaderInfo = new MessageHeaderInfo
				{
					MessageID = SampleData.MessageIdentifier_TankContainer_Inspection_MessageID,
					SenderID = SampleData.InspectionBureauID,
					RecipientID = SampleData.Lessor_ID,
					SentDate = DateTime.Parse(SampleData.Orderflow_Container_StatusUpdate_Inspection_ByDepot_Started),
					MessageType = MessageHeaderInfoMessageType.New,
				},
				HardCopyInfo = new Message_TankContainer_InspectionReportHardCopyInfo
				{
					HardCopyURL = "https://dummyInspectionBureay/credentials/order/inspectionreport.pdf"
				},
				InspectionOrderInfo = new Message_TankContainer_InspectionReportInspectionOrderInfo
				{
					SupplierID = SampleData.InspectionBureauID,
					SupplierInspectionReference = "",
					SupplierInspectionRevision = "",
					SupplierInspectionRevisionRemarks = new RemarksRemark[]
					{
					},
					SupplierTermsAndConditions = "",
					InspectionScope = TankContainer_ServiceRequest_InspectionInspectionScope.Item5YearTest,
					ClientID = SampleData.Lessor_ID,
					ClientInspectionReference = SampleData.Lessor_OrderReference,
				},
				InspectionResultsInfo = new Message_TankContainer_InspectionReportInspectionResultsInfo
				{
					InspectionLocationID = SampleData.Depot_LocationID,
					InspectionCenterID = "",
					InspectionDate = DateTime.Parse(SampleData.Orderflow_Container_StatusUpdate_Inspection_ByDepot_Started),
					InspectorName = "",
					OperatorID = SampleData.Lessee_ID,
					TankContainerMarkings = new RemarksRemark[]
					{

					},
					TankContainerRegulationsApplicableAccordingToMarkingsInfo = new Message_TankContainer_InspectionReportInspectionResultsInfoTankContainerRegulationsApplicableAccordingToMarkingsInfo
					{
						IMDG = "GB/IMO/LR 10277",
						RID_ADR = "GB/TC/LR 10277",
						CSC = "GB/LR 10277-02/00",
						USDOT = "IM 101"
					},

					TankContainerInfo = new TankContainerInfo
					{
						ContainerInfo = new ContainerInfo
						{
							ContainerNumber = SampleData.ContainerNumber,
							ContainerType = SampleData.ContainerType
						},
						OwnerID = SampleData.Lessor_ID,

						TankContainerSuitabilityInfo = new TankContainerInfoTankContainerSuitabilityInfo
						{
							PortableTankType = TankContainerInfoTankContainerSuitabilityInfoPortableTankType.T11,
							RID_ADRCode = "L4BN",
							SubstancesSuitableForTransport = new TankContainerInfo_SubstancesSuitableForTransportTankContainerInfo_SubstanceSuitableForTransport[]
							{
								new TankContainerInfo_SubstancesSuitableForTransportTankContainerInfo_SubstanceSuitableForTransport
								{
									UNNumber = ""
								}
							},
							SpecialProvisions = new TankContainerInfo_SpecialProvisionsTankContainerInfo_SpecialProvision[]
							{
								new TankContainerInfo_SpecialProvisionsTankContainerInfo_SpecialProvision
								{
									SpecialProvision = ""
								}
							}


						},
						TankContainerCharacteristicsInfo = new TankContainerInfoTankContainerCharacteristicsInfo
						{
							Manufacturer = SampleData.ContainerManufacturer,
							BuildingYearMonth = DateTime.Parse(SampleData.ContainerBuildingYear),
							ISO6346SizeTypeCode = TankContainerInfoTankContainerCharacteristicsInfoISO6346SizeTypeCode.Item20G0,
							ISO6346SizeTypeCodeDescription = "",
							DimensionsXMillimeter = 0,
							DimensionsYMillimeter = 0,
							DimensionsZMillimeter = 0,
							MaxGrossMass = 0,
							Payload = 0,
							Tare = 3280,
							Capacity = SampleData.ContainerCapacity
						},

						TankContainerTankInfo = new TankContainerInfoTankContainerTankInfo
						{
							CompartmentQuantity = 1,
							ShellMaterial = "",
							ShellEquivalentThicknessRefSteelMillimeter = 0,
							SurgePlates = false,
							SurgePlatesCapacityBetweenIsLowerThan7500L = true,
							WorkPressureMaximumBar = 0,
							DesignPressureExternalBar = 0,
							TestPressureHydraulicBar = 0,
							DesignTemperatureMinimum = 0,
							DesignTemperatureMaximum = 0,
							DesignTemperatureUnit = TankContainerInfoTankContainerTankInfoDesignTemperatureUnit.Celcius

						},
						TankContainerEquipmentInfo = new TankContainerInfoTankContainerEquipmentInfo
						{
							TopDischarge = "",
							TopQuantityOfEnclosuresInSeries = 0,
							BottomDischarge = "",
							BottomQuantityOfEnclosuresInSeries = 0,
							Heater = "",
							HeaterWorkingPressureBar = 0,
							ReliefValveQuantity = 0,
							ReliefValves = new TankContainerInfo_ReliefValvesTankContainerInfo_ReliefValve[]
							{
								new TankContainerInfo_ReliefValvesTankContainerInfo_ReliefValve
								{
									Manufacturer = "Perolo Superventix",
									SerialNumber = "015400",
									SettingPlus = 4.4
								}
							},
							RuptureDiscQuantity = 0,
						},
						TankContainerLiningInfo = new TankContainerInfoTankContainerLiningInfo
						{
							InternalCoating = "",
							Insulation = "",
							Material = ""
						},
						InspectionDates = new TankContainerInfoInspectionDates
						{
							LastInspectionDate = DateTime.Parse(SampleData.LastTestDate),
							LastInspectionScopeDescription = SampleData.LastTestType,
							CSCValidityDate = DateTime.Parse(SampleData.CSCDate)
						}
					},

					Inspections = new Message_TankContainer_InspectionReportInspectionResultsInfoInspections
					{
						InternalInspection = new Message_TankContainer_InspectionReportInspectionResultsInfoInspectionsInternalInspection
						{
							TankContainer_Inspection = new TankContainer_Inspection
							{
								InspectionResult = TankContainer_InspectionInspectionResult.SatisfactoryWithRemark,
								InspectionRemark = "Inspection remark",
								InspectionDate = DateTime.Now								
							}
						},
						ExternalInspection= new Message_TankContainer_InspectionReportInspectionResultsInfoInspectionsExternalInspection
						{
							TankContainer_Inspection = new TankContainer_Inspection
							{
								InspectionResult = TankContainer_InspectionInspectionResult.Satisfactory
							}
						},
						ThicknessMeasurements = new Message_TankContainer_InspectionReportInspectionResultsInfoInspectionsThicknessMeasurements 
						{
							TankContainer_Inspection = new TankContainer_Inspection
							{
								InspectionResult = TankContainer_InspectionInspectionResult.Remark,
								InspectionRemark = "Another remark"								
							}
						},
						HydraulicTest = new Message_TankContainer_InspectionReportInspectionResultsInfoInspectionsHydraulicTest 
						{
							TankContainer_Inspection = new TankContainer_Inspection
							{
								InspectionResult = TankContainer_InspectionInspectionResult.NotApplicable
							}
						},
						LeakproofnessTest = new  Message_TankContainer_InspectionReportInspectionResultsInfoInspectionsLeakproofnessTest 
						{
							TankContainer_Inspection = new TankContainer_Inspection
							{
								InspectionResult = TankContainer_InspectionInspectionResult.NotApplicable
							}
						},
						VacuumMeasurement = new  Message_TankContainer_InspectionReportInspectionResultsInfoInspectionsVacuumMeasurement 
						{
							TankContainer_Inspection = new TankContainer_Inspection
							{
								InspectionResult = TankContainer_InspectionInspectionResult.NotApplicable
							}
						},
						HeaterPressureTest = new Message_TankContainer_InspectionReportInspectionResultsInfoInspectionsHeaterPressureTest 
						{
							TankContainer_Inspection = new TankContainer_Inspection
							{
								InspectionResult = TankContainer_InspectionInspectionResult.NotApplicable
							}
						},
						ValveSettingsCheck = new Message_TankContainer_InspectionReportInspectionResultsInfoInspectionsValveSettingsCheck
						{
							TankContainer_Inspection = new TankContainer_Inspection
							{
								InspectionResult = TankContainer_InspectionInspectionResult.NotApplicable
							}
						},
						ServiceEquipmentCheck = new Message_TankContainer_InspectionReportInspectionResultsInfoInspectionsServiceEquipmentCheck 
						{
							TankContainer_Inspection = new TankContainer_Inspection
							{
								InspectionResult = TankContainer_InspectionInspectionResult.NotApplicable
							}
						},
						FrameExamination = new Message_TankContainer_InspectionReportInspectionResultsInfoInspectionsFrameExamination 
						{
							TankContainer_Inspection = new TankContainer_Inspection
							{
								InspectionResult = TankContainer_InspectionInspectionResult.NotApplicable
							}
						},
						MarkingExamination = new Message_TankContainer_InspectionReportInspectionResultsInfoInspectionsMarkingExamination 
						{
							TankContainer_Inspection = new TankContainer_Inspection
							{
								InspectionResult = TankContainer_InspectionInspectionResult.NotApplicable
							}
						},
						RefOfMeasurementInstrumentsUsed = ""
					}
                },
				InspectionVerification = new Message_TankContainer_InspectionReportInspectionVerification
                {
					VerificationDate = DateTime.Now,
					VerificatorName = "Guybrush Threepwood"
				}
			};

			return m;
		} //TODO
		#endregion
	}
}