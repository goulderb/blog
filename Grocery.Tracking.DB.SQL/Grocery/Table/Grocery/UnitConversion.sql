CREATE TABLE
    Grocery.UnitConversion (
        UnitConversionID UNIQUEIDENTIFIER NOT NULL CONSTRAINT DFUnitConversionPK DEFAULT NEWSEQUENTIALID (),
        SourceUnitID UNIQUEIDENTIFIER NOT NULL,
        TargetUnitID UNIQUEIDENTIFIER NOT NULL,
        Factor DECIMAL(18, 4) NOT NULL CONSTRAINT DFUnitConversionFactor DEFAULT 0,
        CONSTRAINT FKUnitConversionUnit FOREIGN KEY (SourceUnitID) REFERENCES Grocery.Unit (UnitID),
        CONSTRAINT FKUnitConversionUnit FOREIGN KEY (TargetUnitID) REFERENCES Grocery.Unit (UnitID)
    );