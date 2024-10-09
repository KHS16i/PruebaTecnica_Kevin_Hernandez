---------------------------------//////////CREACI�N DE BASE DE DATOS//////////---------------------------------



CREATE DATABASE PruebaTecnicaKevinH



---------------------------------//////////FIN CREACI�N DE BASE DE DATOS//////////---------------------------------





---------------------------------//////////CREACI�N DE TABLAS//////////---------------------------------



USE PruebaTecnicaKevinH


CREATE TABLE Gestores (
    IdGestor int IDENTITY(1,1) PRIMARY KEY,
    Nombre varchar(50)
);


CREATE TABLE Saldos (
    IdSaldo int IDENTITY(1,1) PRIMARY KEY,
    IdGestor int,
    Saldo int
);



---------------------------------//////////FIN CREACI�N DE TABLAS//////////---------------------------------





---------------------------------//////////INSERCI�N A TABLAS//////////---------------------------------


USE PruebaTecnicaKevinH


INSERT INTO Gestores (Nombre)
VALUES
    ('Gestor 1'),
    ('Gestor 2'),
    ('Gestor 3'),
    ('Gestor 4'),
    ('Gestor 5'),
    ('Gestor 6'),
    ('Gestor 7'),
    ('Gestor 8'),
    ('Gestor 9'),
    ('Gestor 10');			-- Se insertan los 10 Gestores para la asignaci�n de los saldos



---------------------------------//////////FIN INSERCI�N A TABLAS//////////---------------------------------





---------------------------------//////////CREACI�N DEL PROCEDIMIENTO ALMACENADO//////////---------------------------------



USE PruebaTecnicaKevinH


CREATE PROCEDURE usp_AsignaSaldos
    @saldos_desordenados varchar(1000)
AS
BEGIN
    DECLARE @gestorId int;	-- Para almacenar el ID del Gestor
    DECLARE @saldos_asignados int = 0;	-- Para controlar el n�mero de saldos asignados
    DECLARE @total_saldos int = 50;		-- Seg�n documentaci�n, son 50 saldos
    DECLARE @saldos_x_Gestor int = @total_saldos / 10;		-- Se divide el total de saldos por 10 Gestores para seguir los requerimientos, ac� se almacena el resultado
    DECLARE @saldo int;		-- Para almacenar el saldo actual

    CREATE TABLE #tmp_saldos_ordenados (		-- Se crea tabla temporal para almacenar los saldos
        saldo int
    );

    INSERT INTO #tmp_saldos_ordenados (saldo)	
    SELECT value
    FROM STRING_SPLIT(@saldos_desordenados, ',');	-- Se insertan los saldos extrayendolos del par�metro, separandolos por una coma

    DECLARE cursor_saldos CURSOR FOR	-- Se crea el cursor solicitado en los requerimientos para obtener informaci�n de los Gestores e iterar la tabla temporal
    SELECT saldo
    FROM #tmp_saldos_ordenados
    ORDER BY saldo DESC;	-- Se ordena Descendentemente la informaci�n de la tabla temporal para asignarlos a los Gestores ordenadamente

    OPEN cursor_saldos;		-- Se abre el cursor

    FETCH NEXT FROM cursor_saldos INTO @saldo;		-- Se almacena el dato saldo de la tabla temporal

    WHILE @@FETCH_STATUS = 0	-- Mientras hayan datos en la tabla temp se sigue iterando
    BEGIN

        SELECT TOP 1 @gestorId = IdGestor	-- Se obtine el ID del Gestor realizando un top 1 y se almacena en la variable "@gestorId"
        FROM Gestores 
        WHERE IdGestor NOT IN (SELECT IdGestor FROM Saldos)		-- Seg�n se vaya iterando, se verifica que no sea el mismo Id del Gestor que se ten�a en la iteraci�n pasada
		ORDER BY IdGestor;

        WHILE @saldos_asignados < @saldos_x_Gestor AND @@FETCH_STATUS = 0	-- Cuando el n�mero de saldos para asignar por Gestor no sea mayor a los saldos asignados y se tengan datos para iterar en la tabla temp
        BEGIN
            INSERT INTO Saldos (IdGestor, Saldo)
            VALUES (@gestorId, @saldo);		-- Se inserta en la tabla Saldos el saldo correspondiente a la iteraci�n con el Id del Gestor correspondiente
            SET @saldos_asignados = @saldos_asignados + 1;		-- Se incrementa en uno la variable que controla el n�mero de saldos asignados por Gestor

            FETCH NEXT FROM cursor_saldos INTO @saldo;		--Se pasa a la siguiente iteraci�n del cursor con el siguiente saldo.
        END

        SET @saldos_asignados = 0;		-- Reinicia contador de saldos asignados para el pr�ximo gestor
    END

    CLOSE cursor_saldos;	
    DEALLOCATE cursor_saldos;	-- Se cierra y destruye el cursor

	DROP TABLE #tmp_saldos_ordenados

	
	SELECT G.Nombre, S.Saldo FROM Saldos S
	INNER JOIN Gestores G ON S.IdGestor = G.IdGestor	-- Devuelve la informacion de los saldos asignados a los gestores

END;



---------------------------------//////////FIN CREACI�N DEL PROCEDIMIENTO ALMACENADO//////////---------------------------------




