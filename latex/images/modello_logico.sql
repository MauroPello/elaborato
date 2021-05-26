CREATE TABLE `Users`(
    `UserID` INT NOT NULL,
    `Name` TEXT NOT NULL,
    `Password` TEXT NOT NULL,
    `Email` TEXT NOT NULL,
    `City` TEXT NOT NULL,
    `Image` TEXT NOT NULL,
    `Salt` TEXT NOT NULL,
    `ApiKey` TEXT NOT NULL,
    `Balance` INT NOT NULL
);
ALTER TABLE
    `Users` ADD PRIMARY KEY `users_userid_primary`(`UserID`);
CREATE TABLE `Transactions`(
    `TransactionID` INT NOT NULL,
    `ProductID` INT NOT NULL,
    `OwnerID` INT NOT NULL,
    `BuyerID` INT NOT NULL,
    `State` TEXT NOT NULL,
    `LastUpdate` TEXT NOT NULL
);
ALTER TABLE
    `Transactions` ADD PRIMARY KEY `transactions_transactionid_primary`(`TransactionID`);
CREATE TABLE `Products`(
    `ProductID` INT NOT NULL,
    `Name` TEXT NOT NULL,
    `Description` TEXT NOT NULL,
    `Image` TEXT NOT NULL,
    `IsAvailable` INT NOT NULL,
    `LastUpdate` TEXT NOT NULL,
    `OwnerID` INT NOT NULL
);
ALTER TABLE
    `Products` ADD PRIMARY KEY `products_productid_primary`(`ProductID`);
ALTER TABLE
    `Products` ADD CONSTRAINT `products_ownerid_foreign` FOREIGN KEY(`OwnerID`) REFERENCES `Users`(`UserID`);
ALTER TABLE
    `Transactions` ADD CONSTRAINT `transactions_ownerid_foreign` FOREIGN KEY(`OwnerID`) REFERENCES `Users`(`UserID`);
ALTER TABLE
    `Transactions` ADD CONSTRAINT `transactions_buyerid_foreign` FOREIGN KEY(`BuyerID`) REFERENCES `Users`(`UserID`);
ALTER TABLE
    `Transactions` ADD CONSTRAINT `transactions_productid_foreign` FOREIGN KEY(`ProductID`) REFERENCES `Products`(`ProductID`);