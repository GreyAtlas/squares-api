CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    `MigrationId` varchar(150) NOT NULL,
    `ProductVersion` varchar(32) NOT NULL,
    PRIMARY KEY (`MigrationId`)
);

START TRANSACTION;

CREATE TABLE `PointLists` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `CreatedAt` datetime(6) NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `Points` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `CreatedAt` datetime(6) NOT NULL,
    `X` int NOT NULL,
    `Y` int NOT NULL,
    `PointListId` int NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Points_PointLists_PointListId` FOREIGN KEY (`PointListId`) REFERENCES `PointLists` (`Id`) ON DELETE CASCADE
);

CREATE INDEX `IX_Points_PointListId` ON `Points` (`PointListId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20251104175012_init', '8.0.20');

COMMIT;