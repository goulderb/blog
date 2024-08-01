CREATE TABLE
    Grocery.Item (
        ItemID UNIQUEIDENTIFIER NOT NULL CONSTRAINT DFItemPK DEFAULT NEWSEQUENTIALID (),
        Item NVARCHAR (100) NOT NULL CONSTRAINT DFItemItem DEFAULT '',
        ItemCategoryID UNIQUEIDENTIFIER NOT NULL,
        Quantity DECIMAL(18, 4) NOT NULL CONSTRAINT DFItemQuantity DEFAULT 0,
        QauntityUnitID UNIQUEIDENTIFIER NOT NULL,
        CONSTRAINT FKItemItemCategory FOREIGN KEY (ItemCategoryID) REFERENCES Grocery.ItemCategory (ItemCategoryID),
        CONSTRAINT FKItemQuantityUnit FOREIGN KEY (QauntityUnitID) REFERENCES Grocery.Unit (UnitID)
    );

CREATE INDEX IXItemItemCategoryID ON Grocery.Item (ItemCategoryID);