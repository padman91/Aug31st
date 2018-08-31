﻿CREATE TABLE [dbo].[Client] (
    [ClientID]              INT            IDENTITY (1, 1) NOT NULL,
    [ClientCode]            NVARCHAR (60)  NOT NULL,
    [Name]                  NVARCHAR (100) NOT NULL,
    [Acronym]               NVARCHAR (100) NULL,
    [SpecialityID]          INT            NOT NULL,
    [BusinessUnitID]        INT            NOT NULL,
    [SystemID]              INT            NULL,
    [SiteID]                int            NULL,
    [ContactName]           NVARCHAR (100) NULL,
    [ContactPhone]          NVARCHAR (100) NULL,
    [ContactEmail]          NVARCHAR (100) NULL,
    [PercentageOfCash]      NUMERIC (5, 2) NULL,
    [FlatFee]               INT            NULL,
    [NumberOfProviders]     INT            NULL,
    [ContractStartDate]     DATETIME       NOT NULL,
    [ContractEndDate]       DATETIME       NOT NULL,
    [NoticePeriod]          INT            NULL,
    [RelationShipManagerID] INT            NULL,
    [BillingManagerID]      INT            NULL,
    [WeeklyCheckListID]     INT            NULL,
    [MonthlyCheckListID]    INT            NULL,
    [ContractFilePath]      NVARCHAR (MAX) NULL,
    [IsActive]              CHAR (1)       NOT NULL,
    [RecordStatus]          CHAR (1)       NOT NULL,
    [CreatedDate]           DATETIME       NOT NULL,
    [CreatedBy]             NVARCHAR (60)  NOT NULL,
    [ModifiedDate]          DATETIME       NOT NULL,
    [ModifiedBy]            NVARCHAR (60)  NOT NULL,
	[StartTime]				DATETIME2 GENERATED ALWAYS AS ROW START 
		HIDDEN DEFAULT GETUTCDATE(),
    [EndTime]				DATETIME2 GENERATED ALWAYS AS ROW END
		HIDDEN DEFAULT CONVERT(DATETIME2, '9999-12-31 23:59:59.9999999'),
	PERIOD FOR SYSTEM_TIME (StartTime, EndTime),
    PRIMARY KEY CLUSTERED ([ClientID] ASC),
    FOREIGN KEY ([BillingManagerID]) REFERENCES [dbo].[UserLogin] ([ID]),
    FOREIGN KEY ([RelationShipManagerID]) REFERENCES [dbo].[UserLogin] ([ID]),
    FOREIGN KEY ([SystemID]) REFERENCES [dbo].[System] ([SystemID]),
    CONSTRAINT [FK__Client__Site__23694358] FOREIGN KEY ([SiteID]) REFERENCES [dbo].[Site] ([SiteID]),
    CONSTRAINT [FK__Client__Business__236943A5] FOREIGN KEY ([BusinessUnitID]) REFERENCES [dbo].[BusinessUnit] ([BusinessUnitID]),
    CONSTRAINT [FK__Client__MonthlyC__245D67DE] FOREIGN KEY ([MonthlyCheckListID]) REFERENCES [dbo].[CheckList] ([CheckListID]),
    CONSTRAINT [FK__Client__Speciali__25518C17] FOREIGN KEY ([SpecialityID]) REFERENCES [dbo].[Speciality] ([SpecialityID]),
    CONSTRAINT [FK__Client__WeeklyCh__2739D489] FOREIGN KEY ([WeeklyCheckListID]) REFERENCES [dbo].[CheckList] ([CheckListID]),
	CONSTRAINT UQ_Client_ClientCode UNIQUE (ClientCode)
)WITH (SYSTEM_VERSIONING = ON (HISTORY_TABLE = dbo.Client_History));
