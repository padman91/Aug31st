﻿CREATE TABLE [dbo].[DateDimension] (
    [DateKey]             INT                  IDENTITY (1, 1) NOT NULL,
    [Date]                DATE                 NOT NULL,
    [Day]                 TINYINT              NOT NULL,
    [Weekday]             TINYINT              NOT NULL,
    [WeekDayName]         NVARCHAR (10)        NOT NULL,
    [IsWeekend]           BIT                  NOT NULL,
    [IsHoliday]           BIT                  NOT NULL,
    [HolidayText]         NVARCHAR (64) SPARSE NULL,
    [DOWInMonth]          TINYINT              NOT NULL,
    [DayOfYear]           SMALLINT             NOT NULL,
    [WeekOfMonth]         TINYINT              NOT NULL,
    [WeekOfYear]          TINYINT              NOT NULL,
    [ISOWeekOfYear]       TINYINT              NOT NULL,
    [Month]               TINYINT              NOT NULL,
    [MonthName]           VARCHAR (10)         NOT NULL,
    [Quarter]             TINYINT              NOT NULL,
    [QuarterName]         NVARCHAR (6)         NOT NULL,
    [Year]                INT                  NOT NULL,
    [MMYYYY]              CHAR (6)             NOT NULL,
    [MonthYear]           CHAR (7)             NOT NULL,
    [FirstDayOfMonth]     DATE                 NOT NULL,
    [LastDayOfMonth]      DATE                 NOT NULL,
    [FirstDayOfQuarter]   DATE                 NOT NULL,
    [LastDayOfQuarter]    DATE                 NOT NULL,
    [FirstDayOfYear]      DATE                 NOT NULL,
    [LastDayOfYear]       DATE                 NOT NULL,
    [FirstDayOfNextMonth] DATE                 NOT NULL,
    [FirstDayOfNextYear]  DATE                 NOT NULL,
    [RecordStatus]        CHAR (7)             NOT NULL,
    [CreatedDate]         DATETIME             NOT NULL,
    [CreatedBy]           NVARCHAR (60)        NOT NULL,
    [ModifiedDate]        DATETIME             NOT NULL,
    [ModifiedBy]          NVARCHAR (60)        NOT NULL,
    PRIMARY KEY CLUSTERED ([DateKey] ASC)
);
