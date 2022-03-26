insert into Furnitures (Id, Price, SquareMeters, DateOfCreate, Type)
values (NEWID(), 50, 2, GETDATE(), 'Armchair'),
	   (NEWID(), 100, 3, GETDATE(), 'Sofa'),
       (NEWID(), 70, 5, GETDATE(), 'Table'),
	   (NEWID(), 77, 2, GETDATE(), 'Sofa'),
       (NEWID(), 70, 5, GETDATE(), 'Armchair'),
	   (NEWID(), 11, 2, GETDATE(), 'Armchair'),
       (NEWID(), 89, 6, GETDATE(), 'Table'),
	   (NEWID(), 23, 1, GETDATE(), 'Sofa'),
       (NEWID(), 64, 2, GETDATE(), 'Sofa');

insert into Devices (Id, Author, DateOfCreate, EnergyPerHour, Price, SquareMeters, Type)
values (NEWID(), 'Sony', GETDATE(), 10, 1000, 5, 'Computer'),
	   (NEWID(), 'Phanasonic', GETDATE(), 7, 1000, 5, 'TV'),
	   (NEWID(), 'Samsung', GETDATE(), 11, 1000, 5, 'Fridge'),
	   (NEWID(), 'Samsung', GETDATE(), 12, 1000, 5, 'Fridge'),
	   (NEWID(), 'Apple', GETDATE(), 15, 1000, 5, 'Fridge'),
	   (NEWID(), 'Phanasonic', GETDATE(), 8, 1000, 5, 'TV'),
	   (NEWID(), 'Sony', GETDATE(), 9, 1000, 5, 'Computer'),
	   (NEWID(), 'Samsung', GETDATE(), 11, 1000, 5, 'Computer'),
	   (NEWID(), 'Apple', GETDATE(), 11, 1000, 5, 'TV'),
	   (NEWID(), 'Apple', GETDATE(), 12, 1000, 5, 'Fridge');

insert into ShelvingStorage (Id, DateOfCreate, Length, Price, SquareMeters, Type)
values (NEWID(), GETDATE(), 100, 150, 6, 'Bookcase'),
	   (NEWID(), GETDATE(), 150, 123, 7, 'Cupboard'),
       (NEWID(), GETDATE(), 99, 543, 8, 'Cupboard'),
       (NEWID(), GETDATE(), 25, 435, 9, 'Wardrobe'),
       (NEWID(), GETDATE(), 43, 433, 9, 'Bookcase'),
       (NEWID(), GETDATE(), 65, 712, 2, 'Wardrobe'),
       (NEWID(), GETDATE(), 34, 143, 5, 'Bookcase'),
       (NEWID(), GETDATE(), 21, 251, 3, 'Cupboard'),
       (NEWID(), GETDATE(), 54, 215, 6, 'Bookcase'),
       (NEWID(), GETDATE(), 66, 125, 7, 'Wardrobe');