CREATE TABLE [dbo].[FuelLog] (
    [id]                 INT          IDENTITY (1, 1) NOT NULL,
    [date]               DATETIME     NULL,
    [employeeName]       VARCHAR (50) NULL,
    [vendorName]         VARCHAR (50) NULL,
    [vehicle]             VARCHAR (50) NULL,
    [assetNum]           VARCHAR (50) NULL,
    [odometer]           VARCHAR (50) NULL,
    [gallonsGasUsed]     DECIMAL (18) NULL,
    [gallonsGasAdded]    DECIMAL (18) NULL,
    [gallonsDieselUsed]  DECIMAL (18) NULL,
    [gallonsDieselAdded] DECIMAL (18) NULL,
    [startingGas]        DECIMAL (18) NULL,
    [startingDiesel]     DECIMAL (18) NULL,
    CONSTRAINT [PK_FuelLog] PRIMARY KEY CLUSTERED ([id] ASC)
);

