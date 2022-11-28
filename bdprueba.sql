CREATE DATABASE prueba;
USE prueba;
GO
CREATE TABLE Alumnos (
Id INT PRIMARY KEY NOT NULL,
Nombre VARCHAR(40) NOT NULL,
Apellido VARCHAR(40) NOT NULL,
Direccion VARCHAR(40),
Fecha_Nacimiento DATETIME
);
GO
INSERT INTO Alumnos(Id,Nombre,Apellido,Direccion,Fecha_Nacimiento)
VALUES(1,'María','López','Lot. Santa Ana','2000-01-01');


--UPDATE Alumnos SET Fecha_Nacimiento='2000-01-01' WHERE Id=1;

--DELETE FROM Alumnos WHERE Id=1;

--SELECT * FROM Alumnos;