CREATE DATABASE centralis;
USE centralis;

CREATE TABLE modulos (
    CodigoModulo VARCHAR(10),
    PRIMARY KEY (CodigoModulo)
);
CREATE TABLE crimenes (
    IdCrimen INT auto_increment,
    Descripcion VARCHAR(50),
    Condena INT,
    PRIMARY KEY (IdCrimen)
);

CREATE TABLE celdas (
    CodigoCelda INT auto_increment,
    Modulo VARCHAR(10),
    PRIMARY KEY (CodigoCelda),
    FOREIGN KEY (Modulo) REFERENCES modulos(CodigoModulo) ON DELETE SET NULL
);

CREATE TABLE turnos (
    CodigoTurno INT,
    HoraEntrada TIME,
    HoraSalida TIME,
    PRIMARY KEY (CodigoTurno)
);

CREATE TABLE presos (
    NIF CHAR(9) NOT NULL,
    Nombre CHAR(20) NOT NULL,
    Apellidos CHAR(20),
    Crimen INT,
    Sexo CHAR(20),
    Direccion CHAR(20),
    CodigoPostal INT,
    Correo CHAR(30),
    Celda int,
    Telefono INT,
    Foto BLOB,
    PRIMARY KEY (NIF),
    FOREIGN KEY (Celda) REFERENCES celdas(CodigoCelda) ON DELETE SET NULL,
    FOREIGN KEY (Crimen) REFERENCES Crimenes(IdCrimen) ON DELETE SET NULL
);

CREATE TABLE empleado (
    NIF CHAR(9) NOT NULL,
    Nombre CHAR(20) NOT NULL,
    Apellidos CHAR(20),
    Puesto CHAR(20),
    Contraseña VARCHAR(30),
    Sexo CHAR(20),
    Turno INT,
    Direccion CHAR(20),
    CodigoPostal INT,
    Correo CHAR(30),
    Celda int,
    Telefono INT,
     Foto BLOB,
    PRIMARY KEY (NIF),
    FOREIGN KEY (Celda) REFERENCES celdas(CodigoCelda) ON DELETE SET NULL,
    FOREIGN KEY (Turno) REFERENCES turnos(CodigoTurno) ON DELETE SET NULL
);

CREATE TABLE puertas (
    CodigoPuerta INT,
    Abierta TINYINT,
    PRIMARY KEY (CodigoPuerta)
);

CREATE TABLE registros (
    CodigoRegistro INT,
    Tipo CHAR(30),
    Preso CHAR(9),
    Motivo CHAR(30),
    Fecha DATETIME,
    PRIMARY KEY (CodigoRegistro),
    FOREIGN KEY (Preso) REFERENCES presos(NIF) ON DELETE SET NULL
);