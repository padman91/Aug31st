﻿CREATE TABLE [dbo].[KPIAlert] (
[KPIAlertID]                   INT  IDENTITY (1, 1) NOT NULL,
[KPIID]                        INT  NOT NULL,
[SendAlert]                    BIT  NULL,
[SendAlertTitle]               nvarchar(400) NULL,
[SendToRelationshipManager]    BIT NULL,
[SendToBillingManager]         BIT NULL,
[EscalateAlert]                BIT  NULL,
[EscalateAlertTitle]           nvarchar(400) NULL,
[EscalateTriggerTime]          nvarchar(60)  NULL,
[IncludeKPItarget]             BIT NULL,
[IncludeDeviationTarget]       BIT NULL,
[IsSLA]                        BIT NULL,
[RecordStatus]                 CHAR (1)       NOT NULL,
[CreatedDate]                  DATETIME       NOT NULL,
[CreatedBy]                    NVARCHAR (60)  NOT NULL,
[ModifiedDate]                 DATETIME       NOT NULL,
[ModifiedBy]                   NVARCHAR (60)  NOT NULL,
PRIMARY KEY CLUSTERED ([KPIAlertID] ASC),
CONSTRAINT FK_KPIAlert_KPIID  FOREIGN KEY (KPIID) REFERENCES [KPI](KPIID),
);
