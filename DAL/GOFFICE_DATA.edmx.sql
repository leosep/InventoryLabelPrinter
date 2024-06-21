
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/21/2024 15:07:59
-- Generated from EDMX file: C:\Develop\ActivosFijos\inventarioprintlabel\DAL\GOFFICE_DATA.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Gazella];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_afactcomp_afactivos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[afactcomps] DROP CONSTRAINT [FK_afactcomp_afactivos];
GO
IF OBJECT_ID(N'[dbo].[FK_afactivos_afgrupos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[afactivos] DROP CONSTRAINT [FK_afactivos_afgrupos];
GO
IF OBJECT_ID(N'[dbo].[FK_afactivos_aftipoact]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[afactivos] DROP CONSTRAINT [FK_afactivos_aftipoact];
GO
IF OBJECT_ID(N'[dbo].[FK_afactivos_afubic]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[afactivos] DROP CONSTRAINT [FK_afactivos_afubic];
GO
IF OBJECT_ID(N'[dbo].[FK_afbceact_afactivos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[afbceacts] DROP CONSTRAINT [FK_afbceact_afactivos];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[afactcomps]', 'U') IS NOT NULL
    DROP TABLE [dbo].[afactcomps];
GO
IF OBJECT_ID(N'[dbo].[afactivos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[afactivos];
GO
IF OBJECT_ID(N'[dbo].[afbceacts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[afbceacts];
GO
IF OBJECT_ID(N'[dbo].[afgrupos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[afgrupos];
GO
IF OBJECT_ID(N'[dbo].[aftipoacts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[aftipoacts];
GO
IF OBJECT_ID(N'[dbo].[afubics]', 'U') IS NOT NULL
    DROP TABLE [dbo].[afubics];
GO
IF OBJECT_ID(N'[dbo].[cousuarios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[cousuarios];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'afactcomps'
CREATE TABLE [dbo].[afactcomps] (
    [cia] int  NOT NULL,
    [activo] int  NOT NULL,
    [secuencia] int  NOT NULL,
    [descrip] varchar(60)  NOT NULL,
    [serie] varchar(30)  NOT NULL,
    [usuario] varchar(15)  NOT NULL,
    [fecha_creacion] datetime  NOT NULL,
    [hora_creacion] datetime  NOT NULL,
    [fecha_modificacion] datetime  NULL
);
GO

-- Creating table 'afactivos'
CREATE TABLE [dbo].[afactivos] (
    [cia] int  NOT NULL,
    [activo] int  NOT NULL,
    [cod_alterno] varchar(20)  NOT NULL,
    [descrip] varchar(60)  NOT NULL,
    [tipo_activo] int  NOT NULL,
    [tipo_activo2] varchar(1)  NOT NULL,
    [grupo_activo] int  NOT NULL,
    [ubic_activo] int  NOT NULL,
    [marca] varchar(20)  NOT NULL,
    [modelo] varchar(20)  NOT NULL,
    [serie] varchar(20)  NOT NULL,
    [cantidad] int  NOT NULL,
    [proveedor] int  NOT NULL,
    [doc_pago] varchar(20)  NOT NULL,
    [fecha_adq] datetime  NOT NULL,
    [valor_adq] decimal(15,2)  NOT NULL,
    [adicion_rebaja] decimal(15,2)  NOT NULL,
    [observaciones] varchar(255)  NOT NULL,
    [texto1] varchar(50)  NULL,
    [texto2] varchar(50)  NULL,
    [texto3] varchar(50)  NULL,
    [texto4] varchar(50)  NULL,
    [texto5] varchar(50)  NULL,
    [cantidad1] int  NULL,
    [cantidad2] int  NULL,
    [cantidad3] int  NULL,
    [cantidad4] int  NULL,
    [cantidad5] int  NULL,
    [valor1] decimal(15,2)  NULL,
    [valor2] decimal(15,2)  NULL,
    [valor3] decimal(15,2)  NULL,
    [valor4] decimal(15,2)  NULL,
    [valor5] decimal(15,2)  NULL,
    [fecha1] datetime  NULL,
    [fecha2] datetime  NULL,
    [fecha3] datetime  NULL,
    [fecha4] datetime  NULL,
    [fecha5] datetime  NULL,
    [reg_activo] varchar(1)  NOT NULL,
    [usuario] varchar(15)  NOT NULL,
    [fecha_creacion] datetime  NOT NULL,
    [hora_creacion] datetime  NOT NULL,
    [fecha_modificacion] datetime  NULL
);
GO

-- Creating table 'afbceacts'
CREATE TABLE [dbo].[afbceacts] (
    [cia] int  NOT NULL,
    [activo] int  NOT NULL,
    [ano] int  NOT NULL,
    [periodo] int  NOT NULL,
    [valor_inicial] decimal(15,2)  NOT NULL,
    [adicion_rebaja] decimal(15,2)  NULL,
    [deprec_mes] decimal(15,2)  NOT NULL,
    [deprec_acum] decimal(15,2)  NOT NULL,
    [valor_libros] decimal(15,2)  NOT NULL,
    [usuario] varchar(15)  NOT NULL,
    [fecha_creacion] datetime  NOT NULL,
    [hora_creacion] datetime  NOT NULL,
    [fecha_modificacion] datetime  NULL
);
GO

-- Creating table 'afgrupos'
CREATE TABLE [dbo].[afgrupos] (
    [cia] int  NOT NULL,
    [grupo_activo] int  NOT NULL,
    [descrip] varchar(60)  NOT NULL,
    [cuenta] varchar(15)  NOT NULL,
    [usuario] varchar(15)  NOT NULL,
    [fecha_creacion] datetime  NOT NULL,
    [hora_creacion] datetime  NOT NULL,
    [fecha_modificacion] datetime  NULL
);
GO

-- Creating table 'aftipoacts'
CREATE TABLE [dbo].[aftipoacts] (
    [cia] int  NOT NULL,
    [tipo_activo] int  NOT NULL,
    [descrip] varchar(60)  NOT NULL,
    [porct_deprec] decimal(5,2)  NOT NULL,
    [anos_vida_util] int  NOT NULL,
    [cta_activo] varchar(15)  NOT NULL,
    [cta_deprec_acum] varchar(15)  NOT NULL,
    [cta_gasto] varchar(15)  NOT NULL,
    [usuario] varchar(15)  NOT NULL,
    [fecha_creacion] datetime  NOT NULL,
    [hora_creacion] datetime  NOT NULL,
    [fecha_modificacion] datetime  NULL
);
GO

-- Creating table 'afubics'
CREATE TABLE [dbo].[afubics] (
    [cia] int  NOT NULL,
    [ubic_activo] int  NOT NULL,
    [descrip] varchar(60)  NOT NULL,
    [usuario] varchar(15)  NOT NULL,
    [fecha_creacion] datetime  NOT NULL,
    [hora_creacion] datetime  NOT NULL,
    [fecha_modificacion] datetime  NULL
);
GO

-- Creating table 'cousuarios'
CREATE TABLE [dbo].[cousuarios] (
    [usuarioid] varchar(15)  NOT NULL,
    [nombre] varchar(60)  NOT NULL,
    [email] varchar(30)  NOT NULL,
    [password] varchar(50)  NOT NULL,
    [idioma] int  NOT NULL,
    [ultima_cia] int  NULL,
    [status] varchar(3)  NOT NULL,
    [usuario] varchar(15)  NOT NULL,
    [fecha_creacion] datetime  NOT NULL,
    [hora_creacion] datetime  NOT NULL,
    [fecha_modificacion] datetime  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [cia], [activo], [secuencia] in table 'afactcomps'
ALTER TABLE [dbo].[afactcomps]
ADD CONSTRAINT [PK_afactcomps]
    PRIMARY KEY CLUSTERED ([cia], [activo], [secuencia] ASC);
GO

-- Creating primary key on [cia], [activo] in table 'afactivos'
ALTER TABLE [dbo].[afactivos]
ADD CONSTRAINT [PK_afactivos]
    PRIMARY KEY CLUSTERED ([cia], [activo] ASC);
GO

-- Creating primary key on [cia], [activo], [ano], [periodo] in table 'afbceacts'
ALTER TABLE [dbo].[afbceacts]
ADD CONSTRAINT [PK_afbceacts]
    PRIMARY KEY CLUSTERED ([cia], [activo], [ano], [periodo] ASC);
GO

-- Creating primary key on [cia], [grupo_activo] in table 'afgrupos'
ALTER TABLE [dbo].[afgrupos]
ADD CONSTRAINT [PK_afgrupos]
    PRIMARY KEY CLUSTERED ([cia], [grupo_activo] ASC);
GO

-- Creating primary key on [cia], [tipo_activo] in table 'aftipoacts'
ALTER TABLE [dbo].[aftipoacts]
ADD CONSTRAINT [PK_aftipoacts]
    PRIMARY KEY CLUSTERED ([cia], [tipo_activo] ASC);
GO

-- Creating primary key on [cia], [ubic_activo] in table 'afubics'
ALTER TABLE [dbo].[afubics]
ADD CONSTRAINT [PK_afubics]
    PRIMARY KEY CLUSTERED ([cia], [ubic_activo] ASC);
GO

-- Creating primary key on [usuarioid] in table 'cousuarios'
ALTER TABLE [dbo].[cousuarios]
ADD CONSTRAINT [PK_cousuarios]
    PRIMARY KEY CLUSTERED ([usuarioid] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [cia], [activo] in table 'afactcomps'
ALTER TABLE [dbo].[afactcomps]
ADD CONSTRAINT [FK_afactcomp_afactivos]
    FOREIGN KEY ([cia], [activo])
    REFERENCES [dbo].[afactivos]
        ([cia], [activo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [cia], [grupo_activo] in table 'afactivos'
ALTER TABLE [dbo].[afactivos]
ADD CONSTRAINT [FK_afactivos_afgrupos]
    FOREIGN KEY ([cia], [grupo_activo])
    REFERENCES [dbo].[afgrupos]
        ([cia], [grupo_activo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_afactivos_afgrupos'
CREATE INDEX [IX_FK_afactivos_afgrupos]
ON [dbo].[afactivos]
    ([cia], [grupo_activo]);
GO

-- Creating foreign key on [cia], [tipo_activo] in table 'afactivos'
ALTER TABLE [dbo].[afactivos]
ADD CONSTRAINT [FK_afactivos_aftipoact]
    FOREIGN KEY ([cia], [tipo_activo])
    REFERENCES [dbo].[aftipoacts]
        ([cia], [tipo_activo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_afactivos_aftipoact'
CREATE INDEX [IX_FK_afactivos_aftipoact]
ON [dbo].[afactivos]
    ([cia], [tipo_activo]);
GO

-- Creating foreign key on [cia], [ubic_activo] in table 'afactivos'
ALTER TABLE [dbo].[afactivos]
ADD CONSTRAINT [FK_afactivos_afubic]
    FOREIGN KEY ([cia], [ubic_activo])
    REFERENCES [dbo].[afubics]
        ([cia], [ubic_activo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_afactivos_afubic'
CREATE INDEX [IX_FK_afactivos_afubic]
ON [dbo].[afactivos]
    ([cia], [ubic_activo]);
GO

-- Creating foreign key on [cia], [activo] in table 'afbceacts'
ALTER TABLE [dbo].[afbceacts]
ADD CONSTRAINT [FK_afbceact_afactivos]
    FOREIGN KEY ([cia], [activo])
    REFERENCES [dbo].[afactivos]
        ([cia], [activo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------