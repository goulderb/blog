CREATE TABLE
    Grocery.ListItem (
        ListItemID UNIQUEIDENTIFIER NOT NULL CONSTRAINT DFListItemPK DEFAULT NEWSEQUENTIALID (),
        ListID UNIQUEIDENTIFIER NOT NULL,
        StoreItemID UNIQUEIDENTIFIER NOT NULL,
        CONSTRAINT FKListItemList FOREIGN KEY (ListID) REFERENCES Grocery.List (ListID),
        CONSTRAINT FKListItemStoreItem FOREIGN KEY (StoreItemID) REFERENCES Grocery.StoreItem (StoreItemID)
    );

CREATE INDEX IXListItemList ON Grocery.ListItem (ListID);

CREATE INDEX IXListItemStoreItemID ON Grocery.ListItem (StoreItemID);