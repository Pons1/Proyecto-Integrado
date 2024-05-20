CREATE DATABASE centralis;
USE centralis;

CREATE TABLE modulos (
    CodigoModulo ENUM('A','B') PRIMARY KEY
);

CREATE TABLE zonas (
    Zona ENUM('COMEDOR','BAÑO','PATIO','LIBRERIA','CONTROL','ENFERMERIA') PRIMARY KEY
);

CREATE TABLE crimenes (
    IdCrimen INT auto_increment,
    Descripcion VARCHAR(50),
    Condena INT,
    PRIMARY KEY (IdCrimen)
);

CREATE TABLE celdas (
    CodigoCelda INT auto_increment,
    Modulo ENUM('A','B'),
    Abierta TINYINT,
    PRIMARY KEY (CodigoCelda),
    FOREIGN KEY (Modulo) REFERENCES modulos(CodigoModulo) ON DELETE CASCADE
);

CREATE TABLE turnos (
    Turno ENUM('MAÑANA','TARDE','NOCHE') PRIMARY KEY,
    HoraEntrada TIME NOT NULL,
    HoraSalida TIME NOT NULL
);

CREATE TABLE presos (
    NIF CHAR(9) NOT NULL,
    Nombre CHAR(20) NOT NULL,
    Apellidos CHAR(20),
    Crimen INT,
    Sexo CHAR(1),
    Direccion CHAR(50),
    CodigoPostal CHAR(5),
    Correo VARCHAR(50),
    Celda INT,
    Telefono VARCHAR(15),
    Foto BLOB,
    PRIMARY KEY (NIF),
    FOREIGN KEY (Celda) REFERENCES celdas(CodigoCelda) ON DELETE SET NULL,
    FOREIGN KEY (Crimen) REFERENCES crimenes(IdCrimen) ON DELETE SET NULL
);

CREATE TABLE empleados (
    NIF CHAR(9) NOT NULL,
    Nombre CHAR(20) NOT NULL,
    Apellidos CHAR(20),
    Puesto ENUM('VIGILANCIA','LIMPIEZA','COCINA','ENFERMERIA','ADMINISTRACION'),
    Contraseña VARCHAR(30),
    Sexo CHAR(1),
    Turno ENUM('MAÑANA','TARDE','NOCHE'),
    Direccion CHAR(50),
    CodigoPostal CHAR(5),
    Correo VARCHAR(50),
    Celda INT,
    Telefono VARCHAR(15),
    Foto BLOB,
    PRIMARY KEY (NIF),
    FOREIGN KEY (Celda) REFERENCES celdas(CodigoCelda) ON DELETE SET NULL,
    FOREIGN KEY (Turno) REFERENCES turnos(Turno) ON DELETE SET NULL
);

CREATE TABLE puertas (
    CodigoPuerta INT auto_increment,
    Zona ENUM('COMEDOR','BAÑO','PATIO','LIBRERIA','CONTROL','ENFERMERIA'),
    Modulo ENUM('A','B'),  
    PRIMARY KEY (CodigoPuerta),
    FOREIGN KEY (Zona) REFERENCES zonas(Zona) ON DELETE CASCADE,
    FOREIGN KEY (Modulo) REFERENCES modulos(Modulo) ON DELETE CASCADE
);

CREATE TABLE registros (
    CodigoRegistro INT auto_increment,
    Tipo ENUM('ENTRADA','SALIDA'),
    Preso CHAR(9),
    Motivo CHAR(30),
    Fecha DATETIME,
    PRIMARY KEY (CodigoRegistro),
    FOREIGN KEY (Preso) REFERENCES presos(NIF) ON DELETE SET NULL
);