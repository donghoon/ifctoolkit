
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/03/2014 19:53:29
-- Generated from EDMX file: C:\dev\ifctoolkit\Sem\Definition\BbDbModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BlackBoxDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_BbHierarchy]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Definitions_BbDefinition] DROP CONSTRAINT [FK_BbHierarchy];
GO
IF OBJECT_ID(N'[dbo].[FK_SEntityBbDefinition_SEntity]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SEntityBbDefinition] DROP CONSTRAINT [FK_SEntityBbDefinition_SEntity];
GO
IF OBJECT_ID(N'[dbo].[FK_SEntityBbDefinition_BbDefinition]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SEntityBbDefinition] DROP CONSTRAINT [FK_SEntityBbDefinition_BbDefinition];
GO
IF OBJECT_ID(N'[dbo].[FK_EntityAttributeBbDefinition]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Definitions_EntityAttribute] DROP CONSTRAINT [FK_EntityAttributeBbDefinition];
GO
IF OBJECT_ID(N'[dbo].[FK_EntityAttributeSEntity]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Definitions_EntityAttribute] DROP CONSTRAINT [FK_EntityAttributeSEntity];
GO
IF OBJECT_ID(N'[dbo].[FK_BbTypeAttributeBbDefinition]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Definitions_BbTypeAttribute] DROP CONSTRAINT [FK_BbTypeAttributeBbDefinition];
GO
IF OBJECT_ID(N'[dbo].[FK_BbTypeForAttribute]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Definitions_BbTypeAttribute] DROP CONSTRAINT [FK_BbTypeForAttribute];
GO
IF OBJECT_ID(N'[dbo].[FK_NameSpaceAciExchange]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MvdExchanges] DROP CONSTRAINT [FK_NameSpaceAciExchange];
GO
IF OBJECT_ID(N'[dbo].[FK_AciExchangeMvdDefinition]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Definitions_MvdDefinition] DROP CONSTRAINT [FK_AciExchangeMvdDefinition];
GO
IF OBJECT_ID(N'[dbo].[FK_BbDefinitionNameSpace_BbDefinition]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BbDefinitionNameSpace] DROP CONSTRAINT [FK_BbDefinitionNameSpace_BbDefinition];
GO
IF OBJECT_ID(N'[dbo].[FK_BbDefinitionNameSpace_NameSpace]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BbDefinitionNameSpace] DROP CONSTRAINT [FK_BbDefinitionNameSpace_NameSpace];
GO
IF OBJECT_ID(N'[dbo].[FK_BbDefinitionNameSpace1_BbDefinition]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BbDefinitionNameSpace1] DROP CONSTRAINT [FK_BbDefinitionNameSpace1_BbDefinition];
GO
IF OBJECT_ID(N'[dbo].[FK_BbDefinitionNameSpace1_NameSpace]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BbDefinitionNameSpace1] DROP CONSTRAINT [FK_BbDefinitionNameSpace1_NameSpace];
GO
IF OBJECT_ID(N'[dbo].[FK_BbDefinitionBbDefinition]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Definitions_BbDefinition] DROP CONSTRAINT [FK_BbDefinitionBbDefinition];
GO
IF OBJECT_ID(N'[dbo].[FK_BbDefinition_inherits_Definition]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Definitions_BbDefinition] DROP CONSTRAINT [FK_BbDefinition_inherits_Definition];
GO
IF OBJECT_ID(N'[dbo].[FK_SEntity_inherits_Definition]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Definitions_SEntity] DROP CONSTRAINT [FK_SEntity_inherits_Definition];
GO
IF OBJECT_ID(N'[dbo].[FK_AttributeDefinition_inherits_Definition]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Definitions_AttributeDefinition] DROP CONSTRAINT [FK_AttributeDefinition_inherits_Definition];
GO
IF OBJECT_ID(N'[dbo].[FK_EntityAttribute_inherits_AttributeDefinition]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Definitions_EntityAttribute] DROP CONSTRAINT [FK_EntityAttribute_inherits_AttributeDefinition];
GO
IF OBJECT_ID(N'[dbo].[FK_BbTypeAttribute_inherits_AttributeDefinition]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Definitions_BbTypeAttribute] DROP CONSTRAINT [FK_BbTypeAttribute_inherits_AttributeDefinition];
GO
IF OBJECT_ID(N'[dbo].[FK_MvdDefinition_inherits_Definition]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Definitions_MvdDefinition] DROP CONSTRAINT [FK_MvdDefinition_inherits_Definition];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Definitions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Definitions];
GO
IF OBJECT_ID(N'[dbo].[MvdExchanges]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MvdExchanges];
GO
IF OBJECT_ID(N'[dbo].[NameSpaces]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NameSpaces];
GO
IF OBJECT_ID(N'[dbo].[Definitions_BbDefinition]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Definitions_BbDefinition];
GO
IF OBJECT_ID(N'[dbo].[Definitions_SEntity]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Definitions_SEntity];
GO
IF OBJECT_ID(N'[dbo].[Definitions_AttributeDefinition]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Definitions_AttributeDefinition];
GO
IF OBJECT_ID(N'[dbo].[Definitions_EntityAttribute]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Definitions_EntityAttribute];
GO
IF OBJECT_ID(N'[dbo].[Definitions_BbTypeAttribute]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Definitions_BbTypeAttribute];
GO
IF OBJECT_ID(N'[dbo].[Definitions_MvdDefinition]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Definitions_MvdDefinition];
GO
IF OBJECT_ID(N'[dbo].[SEntityBbDefinition]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SEntityBbDefinition];
GO
IF OBJECT_ID(N'[dbo].[BbDefinitionNameSpace]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BbDefinitionNameSpace];
GO
IF OBJECT_ID(N'[dbo].[BbDefinitionNameSpace1]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BbDefinitionNameSpace1];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Definitions'
CREATE TABLE [dbo].[Definitions] (
    [Guid] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [InterpretedName] nvarchar(max)  NULL,
    [Description] nvarchar(max)  NULL
);
GO

-- Creating table 'MvdExchanges'
CREATE TABLE [dbo].[MvdExchanges] (
    [Guid] uniqueidentifier  NOT NULL,
    [ExchangeMaker] nvarchar(max)  NULL,
    [EmNumber] int  NULL,
    [Title] nvarchar(max)  NOT NULL,
    [ProjectStage] nvarchar(max)  NULL,
    [Disciplines] nvarchar(max)  NULL,
    [DiscriptionPurpose] nvarchar(max)  NULL,
    [DescriptionIncludes] nvarchar(max)  NULL,
    [DescriptionDetail] nvarchar(max)  NULL,
    [DescriptionMajor] nvarchar(max)  NULL,
    [DescriptionSpecial] nvarchar(max)  NULL,
    [SoftwareExport] nvarchar(max)  NULL,
    [SoftwareImport] nvarchar(max)  NULL,
    [SoftwareNotes] nvarchar(max)  NULL,
    [CreationDate] datetime  NULL,
    [RelatedModel] nvarchar(max)  NULL,
    [OfInterest] bit  NOT NULL,
    [IsDeleted] bit  NOT NULL,
    [NameSpaceGuid] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'NameSpaces'
CREATE TABLE [dbo].[NameSpaces] (
    [Guid] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NULL
);
GO

-- Creating table 'Definitions_BbDefinition'
CREATE TABLE [dbo].[Definitions_BbDefinition] (
    [CreationDate] datetime  NOT NULL,
    [Creator] nvarchar(max)  NOT NULL,
    [FkSuperTypeGuid] uniqueidentifier  NULL,
    [FkCompositionGuid] uniqueidentifier  NULL,
    [Guid] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Definitions_SEntity'
CREATE TABLE [dbo].[Definitions_SEntity] (
    [Schema] nvarchar(8)  NOT NULL,
    [Guid] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Definitions_AttributeDefinition'
CREATE TABLE [dbo].[Definitions_AttributeDefinition] (
    [DataType] nvarchar(max)  NOT NULL,
    [LowerBound] smallint  NOT NULL,
    [UpperBound] smallint  NOT NULL,
    [Guid] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Definitions_EntityAttribute'
CREATE TABLE [dbo].[Definitions_EntityAttribute] (
    [IfcEntityAttribute] nvarchar(max)  NULL,
    [FkBbDefinitionGuid] uniqueidentifier  NULL,
    [FkSEntityGuid] uniqueidentifier  NULL,
    [Guid] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Definitions_BbTypeAttribute'
CREATE TABLE [dbo].[Definitions_BbTypeAttribute] (
    [FkBbGuidInAttributes] uniqueidentifier  NOT NULL,
    [FkBbDefinitionGuid] uniqueidentifier  NOT NULL,
    [Guid] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Definitions_MvdDefinition'
CREATE TABLE [dbo].[Definitions_MvdDefinition] (
    [Creator] nvarchar(max)  NULL,
    [CreationDate] datetime  NULL,
    [Version] int  NULL,
    [IsDeleted] bit  NOT NULL,
    [definition] nvarchar(max)  NULL,
    [MvdExchangeGuid] uniqueidentifier  NOT NULL,
    [Guid] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'SEntityBbDefinition'
CREATE TABLE [dbo].[SEntityBbDefinition] (
    [SEntities_Guid] uniqueidentifier  NOT NULL,
    [BbDefinitions_Guid] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'BbDefinitionNameSpace'
CREATE TABLE [dbo].[BbDefinitionNameSpace] (
    [BbDefinitions_Guid] uniqueidentifier  NOT NULL,
    [NameSpaces_Guid] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'BbDefinitionNameSpace1'
CREATE TABLE [dbo].[BbDefinitionNameSpace1] (
    [RootBbs_Guid] uniqueidentifier  NOT NULL,
    [RootBbsInNS_Guid] uniqueidentifier  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Guid] in table 'Definitions'
ALTER TABLE [dbo].[Definitions]
ADD CONSTRAINT [PK_Definitions]
    PRIMARY KEY CLUSTERED ([Guid] ASC);
GO

-- Creating primary key on [Guid] in table 'MvdExchanges'
ALTER TABLE [dbo].[MvdExchanges]
ADD CONSTRAINT [PK_MvdExchanges]
    PRIMARY KEY CLUSTERED ([Guid] ASC);
GO

-- Creating primary key on [Guid] in table 'NameSpaces'
ALTER TABLE [dbo].[NameSpaces]
ADD CONSTRAINT [PK_NameSpaces]
    PRIMARY KEY CLUSTERED ([Guid] ASC);
GO

-- Creating primary key on [Guid] in table 'Definitions_BbDefinition'
ALTER TABLE [dbo].[Definitions_BbDefinition]
ADD CONSTRAINT [PK_Definitions_BbDefinition]
    PRIMARY KEY CLUSTERED ([Guid] ASC);
GO

-- Creating primary key on [Guid] in table 'Definitions_SEntity'
ALTER TABLE [dbo].[Definitions_SEntity]
ADD CONSTRAINT [PK_Definitions_SEntity]
    PRIMARY KEY CLUSTERED ([Guid] ASC);
GO

-- Creating primary key on [Guid] in table 'Definitions_AttributeDefinition'
ALTER TABLE [dbo].[Definitions_AttributeDefinition]
ADD CONSTRAINT [PK_Definitions_AttributeDefinition]
    PRIMARY KEY CLUSTERED ([Guid] ASC);
GO

-- Creating primary key on [Guid] in table 'Definitions_EntityAttribute'
ALTER TABLE [dbo].[Definitions_EntityAttribute]
ADD CONSTRAINT [PK_Definitions_EntityAttribute]
    PRIMARY KEY CLUSTERED ([Guid] ASC);
GO

-- Creating primary key on [Guid] in table 'Definitions_BbTypeAttribute'
ALTER TABLE [dbo].[Definitions_BbTypeAttribute]
ADD CONSTRAINT [PK_Definitions_BbTypeAttribute]
    PRIMARY KEY CLUSTERED ([Guid] ASC);
GO

-- Creating primary key on [Guid] in table 'Definitions_MvdDefinition'
ALTER TABLE [dbo].[Definitions_MvdDefinition]
ADD CONSTRAINT [PK_Definitions_MvdDefinition]
    PRIMARY KEY CLUSTERED ([Guid] ASC);
GO

-- Creating primary key on [SEntities_Guid], [BbDefinitions_Guid] in table 'SEntityBbDefinition'
ALTER TABLE [dbo].[SEntityBbDefinition]
ADD CONSTRAINT [PK_SEntityBbDefinition]
    PRIMARY KEY CLUSTERED ([SEntities_Guid], [BbDefinitions_Guid] ASC);
GO

-- Creating primary key on [BbDefinitions_Guid], [NameSpaces_Guid] in table 'BbDefinitionNameSpace'
ALTER TABLE [dbo].[BbDefinitionNameSpace]
ADD CONSTRAINT [PK_BbDefinitionNameSpace]
    PRIMARY KEY CLUSTERED ([BbDefinitions_Guid], [NameSpaces_Guid] ASC);
GO

-- Creating primary key on [RootBbs_Guid], [RootBbsInNS_Guid] in table 'BbDefinitionNameSpace1'
ALTER TABLE [dbo].[BbDefinitionNameSpace1]
ADD CONSTRAINT [PK_BbDefinitionNameSpace1]
    PRIMARY KEY CLUSTERED ([RootBbs_Guid], [RootBbsInNS_Guid] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [FkSuperTypeGuid] in table 'Definitions_BbDefinition'
ALTER TABLE [dbo].[Definitions_BbDefinition]
ADD CONSTRAINT [FK_BbHierarchy]
    FOREIGN KEY ([FkSuperTypeGuid])
    REFERENCES [dbo].[Definitions_BbDefinition]
        ([Guid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BbHierarchy'
CREATE INDEX [IX_FK_BbHierarchy]
ON [dbo].[Definitions_BbDefinition]
    ([FkSuperTypeGuid]);
GO

-- Creating foreign key on [SEntities_Guid] in table 'SEntityBbDefinition'
ALTER TABLE [dbo].[SEntityBbDefinition]
ADD CONSTRAINT [FK_SEntityBbDefinition_SEntity]
    FOREIGN KEY ([SEntities_Guid])
    REFERENCES [dbo].[Definitions_SEntity]
        ([Guid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [BbDefinitions_Guid] in table 'SEntityBbDefinition'
ALTER TABLE [dbo].[SEntityBbDefinition]
ADD CONSTRAINT [FK_SEntityBbDefinition_BbDefinition]
    FOREIGN KEY ([BbDefinitions_Guid])
    REFERENCES [dbo].[Definitions_BbDefinition]
        ([Guid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SEntityBbDefinition_BbDefinition'
CREATE INDEX [IX_FK_SEntityBbDefinition_BbDefinition]
ON [dbo].[SEntityBbDefinition]
    ([BbDefinitions_Guid]);
GO

-- Creating foreign key on [FkBbDefinitionGuid] in table 'Definitions_EntityAttribute'
ALTER TABLE [dbo].[Definitions_EntityAttribute]
ADD CONSTRAINT [FK_EntityAttributeBbDefinition]
    FOREIGN KEY ([FkBbDefinitionGuid])
    REFERENCES [dbo].[Definitions_BbDefinition]
        ([Guid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EntityAttributeBbDefinition'
CREATE INDEX [IX_FK_EntityAttributeBbDefinition]
ON [dbo].[Definitions_EntityAttribute]
    ([FkBbDefinitionGuid]);
GO

-- Creating foreign key on [FkSEntityGuid] in table 'Definitions_EntityAttribute'
ALTER TABLE [dbo].[Definitions_EntityAttribute]
ADD CONSTRAINT [FK_EntityAttributeSEntity]
    FOREIGN KEY ([FkSEntityGuid])
    REFERENCES [dbo].[Definitions_SEntity]
        ([Guid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EntityAttributeSEntity'
CREATE INDEX [IX_FK_EntityAttributeSEntity]
ON [dbo].[Definitions_EntityAttribute]
    ([FkSEntityGuid]);
GO

-- Creating foreign key on [FkBbGuidInAttributes] in table 'Definitions_BbTypeAttribute'
ALTER TABLE [dbo].[Definitions_BbTypeAttribute]
ADD CONSTRAINT [FK_BbTypeAttributeBbDefinition]
    FOREIGN KEY ([FkBbGuidInAttributes])
    REFERENCES [dbo].[Definitions_BbDefinition]
        ([Guid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BbTypeAttributeBbDefinition'
CREATE INDEX [IX_FK_BbTypeAttributeBbDefinition]
ON [dbo].[Definitions_BbTypeAttribute]
    ([FkBbGuidInAttributes]);
GO

-- Creating foreign key on [FkBbDefinitionGuid] in table 'Definitions_BbTypeAttribute'
ALTER TABLE [dbo].[Definitions_BbTypeAttribute]
ADD CONSTRAINT [FK_BbTypeForAttribute]
    FOREIGN KEY ([FkBbDefinitionGuid])
    REFERENCES [dbo].[Definitions_BbDefinition]
        ([Guid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BbTypeForAttribute'
CREATE INDEX [IX_FK_BbTypeForAttribute]
ON [dbo].[Definitions_BbTypeAttribute]
    ([FkBbDefinitionGuid]);
GO

-- Creating foreign key on [NameSpaceGuid] in table 'MvdExchanges'
ALTER TABLE [dbo].[MvdExchanges]
ADD CONSTRAINT [FK_NameSpaceAciExchange]
    FOREIGN KEY ([NameSpaceGuid])
    REFERENCES [dbo].[NameSpaces]
        ([Guid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_NameSpaceAciExchange'
CREATE INDEX [IX_FK_NameSpaceAciExchange]
ON [dbo].[MvdExchanges]
    ([NameSpaceGuid]);
GO

-- Creating foreign key on [MvdExchangeGuid] in table 'Definitions_MvdDefinition'
ALTER TABLE [dbo].[Definitions_MvdDefinition]
ADD CONSTRAINT [FK_AciExchangeMvdDefinition]
    FOREIGN KEY ([MvdExchangeGuid])
    REFERENCES [dbo].[MvdExchanges]
        ([Guid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AciExchangeMvdDefinition'
CREATE INDEX [IX_FK_AciExchangeMvdDefinition]
ON [dbo].[Definitions_MvdDefinition]
    ([MvdExchangeGuid]);
GO

-- Creating foreign key on [BbDefinitions_Guid] in table 'BbDefinitionNameSpace'
ALTER TABLE [dbo].[BbDefinitionNameSpace]
ADD CONSTRAINT [FK_BbDefinitionNameSpace_BbDefinition]
    FOREIGN KEY ([BbDefinitions_Guid])
    REFERENCES [dbo].[Definitions_BbDefinition]
        ([Guid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [NameSpaces_Guid] in table 'BbDefinitionNameSpace'
ALTER TABLE [dbo].[BbDefinitionNameSpace]
ADD CONSTRAINT [FK_BbDefinitionNameSpace_NameSpace]
    FOREIGN KEY ([NameSpaces_Guid])
    REFERENCES [dbo].[NameSpaces]
        ([Guid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BbDefinitionNameSpace_NameSpace'
CREATE INDEX [IX_FK_BbDefinitionNameSpace_NameSpace]
ON [dbo].[BbDefinitionNameSpace]
    ([NameSpaces_Guid]);
GO

-- Creating foreign key on [RootBbs_Guid] in table 'BbDefinitionNameSpace1'
ALTER TABLE [dbo].[BbDefinitionNameSpace1]
ADD CONSTRAINT [FK_BbDefinitionNameSpace1_BbDefinition]
    FOREIGN KEY ([RootBbs_Guid])
    REFERENCES [dbo].[Definitions_BbDefinition]
        ([Guid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [RootBbsInNS_Guid] in table 'BbDefinitionNameSpace1'
ALTER TABLE [dbo].[BbDefinitionNameSpace1]
ADD CONSTRAINT [FK_BbDefinitionNameSpace1_NameSpace]
    FOREIGN KEY ([RootBbsInNS_Guid])
    REFERENCES [dbo].[NameSpaces]
        ([Guid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BbDefinitionNameSpace1_NameSpace'
CREATE INDEX [IX_FK_BbDefinitionNameSpace1_NameSpace]
ON [dbo].[BbDefinitionNameSpace1]
    ([RootBbsInNS_Guid]);
GO

-- Creating foreign key on [FkCompositionGuid] in table 'Definitions_BbDefinition'
ALTER TABLE [dbo].[Definitions_BbDefinition]
ADD CONSTRAINT [FK_BbDefinitionBbDefinition]
    FOREIGN KEY ([FkCompositionGuid])
    REFERENCES [dbo].[Definitions_BbDefinition]
        ([Guid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BbDefinitionBbDefinition'
CREATE INDEX [IX_FK_BbDefinitionBbDefinition]
ON [dbo].[Definitions_BbDefinition]
    ([FkCompositionGuid]);
GO

-- Creating foreign key on [Guid] in table 'Definitions_BbDefinition'
ALTER TABLE [dbo].[Definitions_BbDefinition]
ADD CONSTRAINT [FK_BbDefinition_inherits_Definition]
    FOREIGN KEY ([Guid])
    REFERENCES [dbo].[Definitions]
        ([Guid])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Guid] in table 'Definitions_SEntity'
ALTER TABLE [dbo].[Definitions_SEntity]
ADD CONSTRAINT [FK_SEntity_inherits_Definition]
    FOREIGN KEY ([Guid])
    REFERENCES [dbo].[Definitions]
        ([Guid])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Guid] in table 'Definitions_AttributeDefinition'
ALTER TABLE [dbo].[Definitions_AttributeDefinition]
ADD CONSTRAINT [FK_AttributeDefinition_inherits_Definition]
    FOREIGN KEY ([Guid])
    REFERENCES [dbo].[Definitions]
        ([Guid])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Guid] in table 'Definitions_EntityAttribute'
ALTER TABLE [dbo].[Definitions_EntityAttribute]
ADD CONSTRAINT [FK_EntityAttribute_inherits_AttributeDefinition]
    FOREIGN KEY ([Guid])
    REFERENCES [dbo].[Definitions_AttributeDefinition]
        ([Guid])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Guid] in table 'Definitions_BbTypeAttribute'
ALTER TABLE [dbo].[Definitions_BbTypeAttribute]
ADD CONSTRAINT [FK_BbTypeAttribute_inherits_AttributeDefinition]
    FOREIGN KEY ([Guid])
    REFERENCES [dbo].[Definitions_AttributeDefinition]
        ([Guid])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Guid] in table 'Definitions_MvdDefinition'
ALTER TABLE [dbo].[Definitions_MvdDefinition]
ADD CONSTRAINT [FK_MvdDefinition_inherits_Definition]
    FOREIGN KEY ([Guid])
    REFERENCES [dbo].[Definitions]
        ([Guid])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------