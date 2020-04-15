
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/16/2020 18:59:11
-- Generated from EDMX file: C:\Users\dghiuzan\source\repos\MyPhotos\MyPhotos\Model\MyPhotos.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TestPerson];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PhotoEvent_Event]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PhotoEvent] DROP CONSTRAINT [FK_PhotoEvent_Event];
GO
IF OBJECT_ID(N'[dbo].[FK_PhotoEvent_Photo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PhotoEvent] DROP CONSTRAINT [FK_PhotoEvent_Photo];
GO
IF OBJECT_ID(N'[dbo].[FK_PhotoLandscape_Landscape]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PhotoLandscape] DROP CONSTRAINT [FK_PhotoLandscape_Landscape];
GO
IF OBJECT_ID(N'[dbo].[FK_PhotoLandscape_Photo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PhotoLandscape] DROP CONSTRAINT [FK_PhotoLandscape_Photo];
GO
IF OBJECT_ID(N'[dbo].[FK_PhotoPerson_Person]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PhotoPerson] DROP CONSTRAINT [FK_PhotoPerson_Person];
GO
IF OBJECT_ID(N'[dbo].[FK_PhotoPerson_Photo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PhotoPerson] DROP CONSTRAINT [FK_PhotoPerson_Photo];
GO
IF OBJECT_ID(N'[dbo].[FK_PhotoPlace_Photo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PhotoPlace] DROP CONSTRAINT [FK_PhotoPlace_Photo];
GO
IF OBJECT_ID(N'[dbo].[FK_PhotoPlace_Place]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PhotoPlace] DROP CONSTRAINT [FK_PhotoPlace_Place];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Events]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Events];
GO
IF OBJECT_ID(N'[dbo].[Landscapes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Landscapes];
GO
IF OBJECT_ID(N'[dbo].[Persons]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Persons];
GO
IF OBJECT_ID(N'[dbo].[PhotoEvent]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PhotoEvent];
GO
IF OBJECT_ID(N'[dbo].[PhotoLandscape]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PhotoLandscape];
GO
IF OBJECT_ID(N'[dbo].[PhotoPerson]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PhotoPerson];
GO
IF OBJECT_ID(N'[dbo].[PhotoPlace]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PhotoPlace];
GO
IF OBJECT_ID(N'[dbo].[Photos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Photos];
GO
IF OBJECT_ID(N'[dbo].[Places]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Places];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Photos'
CREATE TABLE [dbo].[Photos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Path] nvarchar(max)  NOT NULL,
    [CreationDate] datetime  NOT NULL,
    [IsDeleted] bit  NOT NULL
);
GO

-- Creating table 'Landscapes'
CREATE TABLE [dbo].[Landscapes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NULL
);
GO

-- Creating table 'Events'
CREATE TABLE [dbo].[Events] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NULL,
    [Date] datetime  NULL
);
GO

-- Creating table 'Places'
CREATE TABLE [dbo].[Places] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NULL,
    [Address] nvarchar(max)  NULL
);
GO

-- Creating table 'Persons'
CREATE TABLE [dbo].[Persons] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PhotoPerson'
CREATE TABLE [dbo].[PhotoPerson] (
    [Photos_Id] int  NOT NULL,
    [Persons_Id] int  NOT NULL
);
GO

-- Creating table 'PhotoLandscape'
CREATE TABLE [dbo].[PhotoLandscape] (
    [Photos_Id] int  NOT NULL,
    [Landscapes_Id] int  NOT NULL
);
GO

-- Creating table 'PhotoEvent'
CREATE TABLE [dbo].[PhotoEvent] (
    [Photos_Id] int  NOT NULL,
    [Events_Id] int  NOT NULL
);
GO

-- Creating table 'PhotoPlace'
CREATE TABLE [dbo].[PhotoPlace] (
    [Photos_Id] int  NOT NULL,
    [Places_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Photos'
ALTER TABLE [dbo].[Photos]
ADD CONSTRAINT [PK_Photos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Landscapes'
ALTER TABLE [dbo].[Landscapes]
ADD CONSTRAINT [PK_Landscapes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Events'
ALTER TABLE [dbo].[Events]
ADD CONSTRAINT [PK_Events]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Places'
ALTER TABLE [dbo].[Places]
ADD CONSTRAINT [PK_Places]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Persons'
ALTER TABLE [dbo].[Persons]
ADD CONSTRAINT [PK_Persons]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Photos_Id], [Persons_Id] in table 'PhotoPerson'
ALTER TABLE [dbo].[PhotoPerson]
ADD CONSTRAINT [PK_PhotoPerson]
    PRIMARY KEY CLUSTERED ([Photos_Id], [Persons_Id] ASC);
GO

-- Creating primary key on [Photos_Id], [Landscapes_Id] in table 'PhotoLandscape'
ALTER TABLE [dbo].[PhotoLandscape]
ADD CONSTRAINT [PK_PhotoLandscape]
    PRIMARY KEY CLUSTERED ([Photos_Id], [Landscapes_Id] ASC);
GO

-- Creating primary key on [Photos_Id], [Events_Id] in table 'PhotoEvent'
ALTER TABLE [dbo].[PhotoEvent]
ADD CONSTRAINT [PK_PhotoEvent]
    PRIMARY KEY CLUSTERED ([Photos_Id], [Events_Id] ASC);
GO

-- Creating primary key on [Photos_Id], [Places_Id] in table 'PhotoPlace'
ALTER TABLE [dbo].[PhotoPlace]
ADD CONSTRAINT [PK_PhotoPlace]
    PRIMARY KEY CLUSTERED ([Photos_Id], [Places_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Photos_Id] in table 'PhotoPerson'
ALTER TABLE [dbo].[PhotoPerson]
ADD CONSTRAINT [FK_PhotoPerson_Photo]
    FOREIGN KEY ([Photos_Id])
    REFERENCES [dbo].[Photos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Persons_Id] in table 'PhotoPerson'
ALTER TABLE [dbo].[PhotoPerson]
ADD CONSTRAINT [FK_PhotoPerson_Person]
    FOREIGN KEY ([Persons_Id])
    REFERENCES [dbo].[Persons]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PhotoPerson_Person'
CREATE INDEX [IX_FK_PhotoPerson_Person]
ON [dbo].[PhotoPerson]
    ([Persons_Id]);
GO

-- Creating foreign key on [Photos_Id] in table 'PhotoLandscape'
ALTER TABLE [dbo].[PhotoLandscape]
ADD CONSTRAINT [FK_PhotoLandscape_Photo]
    FOREIGN KEY ([Photos_Id])
    REFERENCES [dbo].[Photos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Landscapes_Id] in table 'PhotoLandscape'
ALTER TABLE [dbo].[PhotoLandscape]
ADD CONSTRAINT [FK_PhotoLandscape_Landscape]
    FOREIGN KEY ([Landscapes_Id])
    REFERENCES [dbo].[Landscapes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PhotoLandscape_Landscape'
CREATE INDEX [IX_FK_PhotoLandscape_Landscape]
ON [dbo].[PhotoLandscape]
    ([Landscapes_Id]);
GO

-- Creating foreign key on [Photos_Id] in table 'PhotoEvent'
ALTER TABLE [dbo].[PhotoEvent]
ADD CONSTRAINT [FK_PhotoEvent_Photo]
    FOREIGN KEY ([Photos_Id])
    REFERENCES [dbo].[Photos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Events_Id] in table 'PhotoEvent'
ALTER TABLE [dbo].[PhotoEvent]
ADD CONSTRAINT [FK_PhotoEvent_Event]
    FOREIGN KEY ([Events_Id])
    REFERENCES [dbo].[Events]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PhotoEvent_Event'
CREATE INDEX [IX_FK_PhotoEvent_Event]
ON [dbo].[PhotoEvent]
    ([Events_Id]);
GO

-- Creating foreign key on [Photos_Id] in table 'PhotoPlace'
ALTER TABLE [dbo].[PhotoPlace]
ADD CONSTRAINT [FK_PhotoPlace_Photo]
    FOREIGN KEY ([Photos_Id])
    REFERENCES [dbo].[Photos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Places_Id] in table 'PhotoPlace'
ALTER TABLE [dbo].[PhotoPlace]
ADD CONSTRAINT [FK_PhotoPlace_Place]
    FOREIGN KEY ([Places_Id])
    REFERENCES [dbo].[Places]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PhotoPlace_Place'
CREATE INDEX [IX_FK_PhotoPlace_Place]
ON [dbo].[PhotoPlace]
    ([Places_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------