
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/31/2017 20:52:25
-- Generated from EDMX file: C:\Users\kanu3\source\repos\SureSafety_.NET\SureSafetyDB\SureSafetyDBModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SureSafety_.Net];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_EmployeeDetailsIncidentDetails_EmployeeDetails]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmployeeDetailsIncidentDetails] DROP CONSTRAINT [FK_EmployeeDetailsIncidentDetails_EmployeeDetails];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeeDetailsIncidentDetails_IncidentDetails]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmployeeDetailsIncidentDetails] DROP CONSTRAINT [FK_EmployeeDetailsIncidentDetails_IncidentDetails];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[EmployeeDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmployeeDetails];
GO
IF OBJECT_ID(N'[dbo].[IncidentDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[IncidentDetails];
GO
IF OBJECT_ID(N'[dbo].[EmployeeDetailsIncidentDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmployeeDetailsIncidentDetails];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'EmployeeDetails'
CREATE TABLE [dbo].[EmployeeDetails] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [EmployeeID] nvarchar(max)  NOT NULL,
    [Supervisor] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'IncidentDetails'
CREATE TABLE [dbo].[IncidentDetails] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SuddenEvent] bit  NOT NULL,
    [SEDate] nvarchar(max)  NULL,
    [SETime] nvarchar(max)  NULL,
    [GradualOT] bit  NOT NULL,
    [GDate] nvarchar(max)  NULL,
    [GTime] nvarchar(max)  NULL,
    [ReportedDate] nvarchar(max)  NOT NULL,
    [ReportedTime] nvarchar(max)  NOT NULL,
    [ReprotedTo] nvarchar(max)  NOT NULL,
    [LocationOfIncident] nvarchar(max)  NOT NULL,
    [Exposures] nvarchar(max)  NOT NULL,
    [IncidentDescription] nvarchar(max)  NOT NULL,
    [WhatHappened] nvarchar(max)  NOT NULL,
    [InjuryDescription] nvarchar(max)  NOT NULL,
    [ToolsUsed] nvarchar(max)  NOT NULL,
    [PersonalProtectiveEquipment] nvarchar(max)  NOT NULL,
    [Witness] nvarchar(max)  NOT NULL,
    [FirstAidRequired] bit  NOT NULL,
    [FirstAidDate] nvarchar(max)  NULL,
    [FirstAiderName] nvarchar(max)  NOT NULL,
    [FirstAiderPosition] nvarchar(max)  NOT NULL,
    [AbsenceDueToIncident] bit  NOT NULL,
    [FirstDayOff] nvarchar(max)  NULL,
    [MedicalTreatmentRequired] bit  NULL,
    [MTDate] datetime  NULL,
    [FacilityType] nvarchar(max)  NOT NULL,
    [FacilityName_Address] nvarchar(max)  NOT NULL,
    [Practitioner] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'EmployeeDetailsIncidentDetails'
CREATE TABLE [dbo].[EmployeeDetailsIncidentDetails] (
    [EmployeeDetails_Id] int  NOT NULL,
    [IncidentDetails_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'EmployeeDetails'
ALTER TABLE [dbo].[EmployeeDetails]
ADD CONSTRAINT [PK_EmployeeDetails]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'IncidentDetails'
ALTER TABLE [dbo].[IncidentDetails]
ADD CONSTRAINT [PK_IncidentDetails]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [EmployeeDetails_Id], [IncidentDetails_Id] in table 'EmployeeDetailsIncidentDetails'
ALTER TABLE [dbo].[EmployeeDetailsIncidentDetails]
ADD CONSTRAINT [PK_EmployeeDetailsIncidentDetails]
    PRIMARY KEY CLUSTERED ([EmployeeDetails_Id], [IncidentDetails_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [EmployeeDetails_Id] in table 'EmployeeDetailsIncidentDetails'
ALTER TABLE [dbo].[EmployeeDetailsIncidentDetails]
ADD CONSTRAINT [FK_EmployeeDetailsIncidentDetails_EmployeeDetails]
    FOREIGN KEY ([EmployeeDetails_Id])
    REFERENCES [dbo].[EmployeeDetails]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IncidentDetails_Id] in table 'EmployeeDetailsIncidentDetails'
ALTER TABLE [dbo].[EmployeeDetailsIncidentDetails]
ADD CONSTRAINT [FK_EmployeeDetailsIncidentDetails_IncidentDetails]
    FOREIGN KEY ([IncidentDetails_Id])
    REFERENCES [dbo].[IncidentDetails]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeeDetailsIncidentDetails_IncidentDetails'
CREATE INDEX [IX_FK_EmployeeDetailsIncidentDetails_IncidentDetails]
ON [dbo].[EmployeeDetailsIncidentDetails]
    ([IncidentDetails_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------