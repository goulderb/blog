CREATE TABLE
    Grocery.ItemCategory (
        ItemCategoryID UNIQUEIDENTIFIER NOT NULL CONSTRAINT DFItemCategoryPK DEFAULT NEWSEQUENTIALID (),
        ItemCategory NVARCHAR (50) NOT NULL CONSTRAINT DFItemCategoryItemCategory DEFAULT ''
    );