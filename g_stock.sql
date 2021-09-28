-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 30-10-2020 a las 04:29:52
-- Versión del servidor: 5.7.14
-- Versión de PHP: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `g_stock`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cierra`
--

CREATE TABLE `cierra` (
  `ci_usuario` int(8) DEFAULT NULL,
  `codigo_ticket` int(5) NOT NULL,
  `fecha_y_hora` datetime DEFAULT NULL,
  `solucion` varchar(300) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `cierra`
--

INSERT INTO `cierra` (`ci_usuario`, `codigo_ticket`, `fecha_y_hora`, `solucion`) VALUES
(52938368, 2, '2018-08-15 11:30:00', 'Se le cambio el procesador'),
(53054753, 3, '2016-07-16 12:30:00', 'Se compraron cargadores de ASUS'),
(54695641, 4, '2018-12-16 15:30:00', 'Se le cambio la plaqueta'),
(53054753, 5, '2018-11-16 16:30:00', 'Se cambio el sistema operativo'),
(54695641, 6, '2018-03-16 14:30:00', 'Se compro un nuevo router y se instalaron nuevos lan'),
(54695641, 7, '2019-07-16 12:35:00', 'Se compro el adaptador del cargador'),
(56831419, 8, '2020-07-13 13:30:00', 'Se amplio la instalacion wifi'),
(52902014, 9, '2019-07-25 18:30:00', 'Se corrijieron los estropisios del servidor'),
(52902014, 10, '2016-04-11 21:30:00', 'Se formateo el equipo HP y se instalo un sistema operativo nuevo.'),
(52509155, 12, '2020-10-20 16:52:13', 'Se cambio compro otro cable'),
(52509155, 1, '2020-10-20 17:41:29', 'Se cambio compro otro cable.'),
(52509155, 11, '2020-10-20 17:52:48', 'Se cambio compro otro cable'),
(52509155, 13, '2020-10-20 18:22:37', 'Se cambio compro otro cable'),
(52509155, 14, '2020-10-20 18:23:14', 'Se cambio compro otro cable'),
(52509155, 17, '2020-10-20 18:43:56', 'Se cambio compro otro cable'),
(52509155, 20, '2020-10-28 09:24:36', 'Se cambio la computadora y se pudieron dejar el almacenamiento y datos de esta misma'),
(52509155, 21, '2020-10-30 01:11:29', 'Se compro otro hdmi y se coloco en la television.');

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `consult1`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `consult1` (
`codigo` int(5)
,`nombre_invitado` varchar(15)
,`apellido_invitado` varchar(15)
,`mensaje` varchar(120)
,`sector` varchar(20)
,`prioridad` varchar(10)
,`email` varchar(30)
,`fecha_t` date
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `consult2`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `consult2` (
`Ticket` bigint(21)
,`sector` varchar(20)
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `consult3`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `consult3` (
`Nombre` varchar(15)
,`Apellido` varchar(15)
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `consult4`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `consult4` (
`Diferencia de dias` bigint(21)
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `consult5`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `consult5` (
`Insumos` varchar(25)
,`Stock` bigint(21)
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `consult6`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `consult6` (
`Insumos` varchar(25)
,`Sector` varchar(15)
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `consult7`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `consult7` (
`cod_i` int(5)
,`nombre_p` varchar(25)
,`fecha_mov` date
,`estado` varchar(15)
,`sector` varchar(15)
,`donador` varchar(15)
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `consult8`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `consult8` (
`Codigo` int(5)
,`Insumo` varchar(25)
,`Fecha en la que ingreso` date
,`Donador` varchar(15)
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `consult9`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `consult9` (
`Nombre del tecnico` varchar(15)
,`Apellido del tecnico` varchar(15)
,`Fecha de ingreso` date
,`Fecha de cierre` datetime
,`Sector asignado` varchar(20)
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `consult10`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `consult10` (
`Nombre` varchar(20)
,`Inicio de sesion` datetime
,`Cierre de sesion` datetime
);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `gestiona`
--

CREATE TABLE `gestiona` (
  `ci_u` int(8) NOT NULL,
  `codigo_p` int(5) NOT NULL,
  `fecha_g` date DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `gestiona`
--

INSERT INTO `gestiona` (`ci_u`, `codigo_p`, `fecha_g`) VALUES
(52996415, 12345, '2018-05-16'),
(52509155, 11111, '2013-07-17'),
(53054753, 22222, '2017-08-31'),
(52938368, 33333, '2018-05-21'),
(52619166, 44444, '2017-04-23'),
(52902014, 55555, '2018-03-19'),
(54695641, 66666, '2019-02-26'),
(56831419, 77777, '2020-07-29'),
(52866765, 88888, '2020-01-04'),
(52285373, 99999, '2015-09-07');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `historico`
--

CREATE TABLE `historico` (
  `cod_i` int(5) NOT NULL,
  `nombre_p` varchar(25) NOT NULL,
  `fecha_mov` date NOT NULL,
  `estado` varchar(15) NOT NULL,
  `sector` varchar(15) NOT NULL,
  `donador` varchar(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `historico`
--

INSERT INTO `historico` (`cod_i`, `nombre_p`, `fecha_mov`, `estado`, `sector`, `donador`) VALUES
(12345, 'LAPTOP', '2018-05-16', 'Funcionando', 'Salones', NULL),
(11111, 'LAPTOP', '2018-06-23', 'Funcionando', '6to', NULL),
(22222, 'SWITCH', '2018-05-24', 'Dañado', '6to', 'Jayce Jaminton'),
(33333, 'CARGADOR', '2019-05-16', 'Funcionando', 'Oficinas', 'Ruperto Lavalle'),
(44444, 'CARGADOR', '2019-05-21', 'Funcionando', 'Taller', NULL),
(12345, 'LAPTOP', '2018-11-23', 'Ausente', 'Salones', NULL),
(66666, 'SERVER', '2017-05-16', 'Funcionando', 'Taller', NULL),
(77777, 'SERVER', '2020-05-16', 'Reparando', 'Oficinas', 'Ruben Rada'),
(88888, 'CPU', '2018-09-16', 'Funcionando', 'Tecnológico', NULL),
(11111, 'LAPTOP', '2019-05-16', 'Ausente', '6to', NULL),
(11111, 'Laptop', '2020-10-27', 'Reparando', 'Taller', NULL),
(76543, 'Router', '2020-10-17', 'Ausente', 'Profesores', 'TP Link'),
(123321, 'Cargadores', '2020-10-17', 'Funcionando', 'Salones', 'HP'),
(94503409, 'Laptop', '2020-10-25', 'Reparando', 'Taller', ''),
(12345, 'Laptop', '2020-10-28', 'Funcionando', 'Tutoria', NULL),
(6789, 'Monitores', '2020-10-28', 'Ausente', 'Biblioteca', ''),
(12345, 'Impresoras', '2020-10-29', 'Reparando', 'Taller', ''),
(11111, 'Laptop', '2020-10-30', 'Funcionando', 'Taller', NULL),
(9, 'Router', '2020-10-30', 'Reparando', 'Biblioteca', '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `insumos`
--

CREATE TABLE `insumos` (
  `codigo_i` int(5) NOT NULL,
  `nombre_stock` varchar(25) NOT NULL,
  `estado_stock` varchar(15) NOT NULL,
  `sector_stock` varchar(15) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `insumos`
--

INSERT INTO `insumos` (`codigo_i`, `nombre_stock`, `estado_stock`, `sector_stock`) VALUES
(12345, 'Laptop', 'Funcionando', 'Tutoria'),
(11111, 'Laptop', 'Funcionando', 'Taller'),
(22222, 'SWITCH', 'Dañado', '6to'),
(33333, 'CARGADOR', 'Funcionando', 'Oficinas'),
(44444, 'CARGADOR', 'Funcionando', 'Taller'),
(66666, 'SERVER', 'Funcionando', 'Taller'),
(77777, 'SERVER', 'Reparando', 'Oficinas'),
(88888, 'CPU', 'Funcionando', '6to'),
(100002, 'Router', 'Funcionando', 'Profesores'),
(94503409, 'Laptop', 'Funcionando', 'Taller'),
(6789, 'Monitores', 'Ausente', 'Biblioteca'),
(9, 'Router', 'Reparando', 'Biblioteca');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sesion`
--

CREATE TABLE `sesion` (
  `ci_sesion` int(8) NOT NULL,
  `nombre` varchar(20) DEFAULT NULL,
  `fh_inicia` datetime NOT NULL,
  `fh_cierra` datetime DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `sesion`
--

INSERT INTO `sesion` (`ci_sesion`, `nombre`, `fh_inicia`, `fh_cierra`) VALUES
(52996415, 'Axel', '2020-10-30 01:25:48', '2020-10-30 01:26:43'),
(52996415, 'Axel', '2020-10-30 01:07:58', '2020-10-30 01:11:35'),
(52996415, 'Axel', '2020-10-29 22:48:47', '2020-10-29 22:48:51'),
(52509155, 'Ignacio', '2020-10-29 18:37:29', '2020-10-29 18:37:30'),
(52996415, 'Axel', '2020-10-29 18:28:44', '2020-10-29 18:28:45'),
(52509155, 'Ignacio', '2020-10-29 18:27:23', '2020-10-29 18:27:25'),
(52996415, 'Axel', '2020-10-28 16:03:37', '2020-10-28 16:03:48'),
(53054753, 'Fernando', '2020-10-29 10:26:26', '2020-10-29 10:29:50'),
(52509155, 'Ignacio', '2020-10-29 11:40:12', '2020-10-29 11:40:19');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ticket`
--

CREATE TABLE `ticket` (
  `codigo` int(5) NOT NULL,
  `nombre_invitado` varchar(15) NOT NULL,
  `apellido_invitado` varchar(15) NOT NULL,
  `mensaje` varchar(120) NOT NULL,
  `sector` varchar(20) DEFAULT NULL,
  `prioridad` varchar(10) DEFAULT NULL,
  `email` varchar(30) NOT NULL,
  `fecha_t` date DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `ticket`
--

INSERT INTO `ticket` (`codigo`, `nombre_invitado`, `apellido_invitado`, `mensaje`, `sector`, `prioridad`, `email`, `fecha_t`) VALUES
(1, 'Francisco', 'Salvatore', 'Equipo HP no funciona correctamente', '6T', 'Baja', 'axelrodri64@gmail.com', '2018-05-16'),
(2, 'Antoño', 'Ribeiro', 'Equipo ASUS no funciona correctamente', '6T', 'Baja', 'anotoñitoribeiro@gmail.com', '2018-08-10'),
(3, 'Manuel', 'Gilbert', 'No hay cargador de ASUS', 'Sala', 'Baja', 'manuelgilbert@gmail.com', '2015-07-16'),
(4, 'Camila', 'Lockwood', 'El monitor da pantallasos negros', 'Taller', 'Alta', 'cam14@gmail.com', '2018-10-13'),
(5, 'Biatriz', 'Clavijo', 'El equipo da pantalla azul', 'Sala', 'Media', 'triz134@gmail.com', '2017-11-01'),
(6, 'Veronica', 'Bentancur', 'No funciona el router', 'Taller', 'Alta', 'verobenta@gmail.com', '2018-03-11'),
(7, 'Angel', 'Masner', 'Se perdio el adaptador de cargador', 'Taller', 'Baja', 'angelitoyasabes@gmail.com', '2019-05-14'),
(8, 'Leticia', 'Martinez', 'No hay buena recepcion wifi', 'Oficinas', 'Alta', 'lecasabe@gmail.com', '2020-07-12'),
(9, 'Fiorella', 'Mendez', 'Se estropeo el servidor', 'Salones', 'Media', 'fiomartinez@gmail.com', '2019-07-20'),
(10, 'Juan', 'Nantes', 'Equipo HP no corre ningun programa', 'Salones', 'Media', 'juancho12@gmail.com', '2016-04-09'),
(11, 'Damian', 'Suarez', 'Se rompio la PC del profesor.', 'Biblioteca', 'Alta', 'DSuarez@Gmail.com', '2020-10-16'),
(12, 'Bruno ', 'Clavijo', 'Se quemo la pc numero 4', '6T', 'Alta', 'BClavijo@gmail.com', '2020-10-16'),
(13, 'Antonio', 'Morales', 'Se rompio un cargador de una laptop', 'Tutoria', 'Baja', 'AMorales@gmail.com', '2020-10-16'),
(14, 'Juan', 'Nantes', 'Se rompio los cables conectados al router', 'Salones', 'Alta', 'JNantes@gmail.com', '2020-10-16'),
(15, 'Leo', 'Gomez', 'Se rompio el enchufe de la television', 'Biblioteca', 'Alta', 'AGomez@gmail.com', '2020-10-17'),
(16, 'Leticia', 'De los Santos', 'Se rompieron los cables lan', 'Salas', 'Alta', 'LDLS@gmail.com', '2020-10-19'),
(17, 'Damian', 'Suarez', 'ssssssssssssssss11111111111111----------------------rrrrrrrrrrrrrrRRRRRRRRRr', 'Profesores', 'dsadsa', '....@gmail.com', '2020-10-20'),
(18, 'Alvaro', 'Melendrez', 'Se desintalo el genexus en la maquina 16.', '6T', 'Media', 'AMelendrez@gmail.com', '2020-10-20'),
(19, 'Ignacio', 'Hernandez', 'Se rompio el control del proyecto.', 'Taller', 'Alta', 'IHernandez@gmail.com', '2020-10-23'),
(20, 'Tania', 'Denucci', 'Se rompio la computadora del profesor.', '6T', 'Alta', 'TDenucci@liceoimpulso.edu.uy', '2020-10-24'),
(21, 'Ezequiel', 'Diaz', 'El hdmi dejo de funcionar', '6T', 'Baja', 'EDiaz@liceoimpulso.edu.uy', '2020-10-28');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE `usuario` (
  `ci` int(8) NOT NULL,
  `cargo` varchar(15) NOT NULL,
  `contraseña` varchar(15) NOT NULL,
  `pnombre` varchar(15) NOT NULL,
  `snombre` varchar(15) DEFAULT NULL,
  `papellido` varchar(15) NOT NULL,
  `sapellido` varchar(15) DEFAULT NULL,
  `area` varchar(20) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`ci`, `cargo`, `contraseña`, `pnombre`, `snombre`, `papellido`, `sapellido`, `area`) VALUES
(52996415, 'Administrador', 'Impulso2020', 'Axel', 'Emiliano', 'Rodriguez', 'Paz', ''),
(52509155, 'Reporte', 'Impulso2021', 'Ignacio', '', 'Umpierrez', '', ''),
(53054753, 'Tecnico', 'Impulso2022', 'Fernando', '', 'Rivera', 'Casavieja', 'Sala'),
(52938368, 'Tecnico', 'Impulso2023', 'Richard', '', 'Fernandez', 'Casanueva', '6T'),
(52619166, 'Reporte', 'Impulso2024', 'Sergio', '', 'Viera', '', ''),
(52902014, 'Tecnico', 'Impulso2025', 'Rodrigo', '', 'Maidana', '', 'Salones'),
(54695641, 'Tecnico', 'Impulso2026', 'Javier', 'Facundo', 'Gimenez', '', 'Taller'),
(56831419, 'Tecnico', 'Impulso2027', 'Enrique', 'Eloi', 'Suarez', '', 'Oficinas'),
(52866765, 'Reporte', 'Impulso2028', 'Damian', 'Joaquin', 'Perez', '', ''),
(46658819, 'Tecnico', 'Impulso3030', 'Fabian', '', 'Carballo', '', 'Taller'),
(25815492, 'Tecnico', 'Impulso2035', 'Alejandro', 'Ignacio', 'Vascolet', '', 'Taller'),
(28221735, 'Tecnico', 'Impulso2034', 'Alvaro', '', 'Hernandez', '', '6T');

-- --------------------------------------------------------

--
-- Estructura para la vista `consult1`
--
DROP TABLE IF EXISTS `consult1`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `consult1`  AS  select `ticket`.`codigo` AS `codigo`,`ticket`.`nombre_invitado` AS `nombre_invitado`,`ticket`.`apellido_invitado` AS `apellido_invitado`,`ticket`.`mensaje` AS `mensaje`,`ticket`.`sector` AS `sector`,`ticket`.`prioridad` AS `prioridad`,`ticket`.`email` AS `email`,`ticket`.`fecha_t` AS `fecha_t` from `ticket` where (not(`ticket`.`codigo` in (select `cierra`.`codigo_ticket` from `cierra`))) ;

-- --------------------------------------------------------

--
-- Estructura para la vista `consult2`
--
DROP TABLE IF EXISTS `consult2`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `consult2`  AS  select count(`ticket`.`codigo`) AS `Ticket`,`ticket`.`sector` AS `sector` from `ticket` group by `ticket`.`sector` ;

-- --------------------------------------------------------

--
-- Estructura para la vista `consult3`
--
DROP TABLE IF EXISTS `consult3`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `consult3`  AS  select `usuario`.`pnombre` AS `Nombre`,`usuario`.`papellido` AS `Apellido` from (`usuario` join `ticket` on(((`ticket`.`sector` = (select `a`.`sector` from (select count(0) AS `Cantidad`,`ticket`.`sector` AS `sector` from `ticket` group by `ticket`.`sector` order by `Cantidad` desc limit 1) `a`)) and (`ticket`.`sector` = `usuario`.`area`)))) limit 1 ;

-- --------------------------------------------------------

--
-- Estructura para la vista `consult4`
--
DROP TABLE IF EXISTS `consult4`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `consult4`  AS  select timestampdiff(DAY,`ticket`.`fecha_t`,`cierra`.`fecha_y_hora`) AS `Diferencia de dias` from (`ticket` join `cierra` on((`ticket`.`codigo` = `cierra`.`codigo_ticket`))) ;

-- --------------------------------------------------------

--
-- Estructura para la vista `consult5`
--
DROP TABLE IF EXISTS `consult5`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `consult5`  AS  select `insumos`.`nombre_stock` AS `Insumos`,count(`insumos`.`nombre_stock`) AS `Stock` from `insumos` where (`insumos`.`estado_stock` <> 'Ausente') group by `insumos`.`nombre_stock` ;

-- --------------------------------------------------------

--
-- Estructura para la vista `consult6`
--
DROP TABLE IF EXISTS `consult6`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `consult6`  AS  select `insumos`.`nombre_stock` AS `Insumos`,`insumos`.`sector_stock` AS `Sector` from `insumos` where (`insumos`.`estado_stock` <> 'Ausente') ;

-- --------------------------------------------------------

--
-- Estructura para la vista `consult7`
--
DROP TABLE IF EXISTS `consult7`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `consult7`  AS  select `historico`.`cod_i` AS `cod_i`,`historico`.`nombre_p` AS `nombre_p`,`historico`.`fecha_mov` AS `fecha_mov`,`historico`.`estado` AS `estado`,`historico`.`sector` AS `sector`,`historico`.`donador` AS `donador` from `historico` ;

-- --------------------------------------------------------

--
-- Estructura para la vista `consult8`
--
DROP TABLE IF EXISTS `consult8`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `consult8`  AS  select `historico`.`cod_i` AS `Codigo`,`historico`.`nombre_p` AS `Insumo`,`historico`.`fecha_mov` AS `Fecha en la que ingreso`,`historico`.`donador` AS `Donador` from `historico` where (`historico`.`donador` <> 'NULL') ;

-- --------------------------------------------------------

--
-- Estructura para la vista `consult9`
--
DROP TABLE IF EXISTS `consult9`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `consult9`  AS  select `usuario`.`pnombre` AS `Nombre del tecnico`,`usuario`.`papellido` AS `Apellido del tecnico`,`ticket`.`fecha_t` AS `Fecha de ingreso`,`cierra`.`fecha_y_hora` AS `Fecha de cierre`,`ticket`.`sector` AS `Sector asignado` from (`ticket` left join (`usuario` join `cierra` on((`usuario`.`ci` = `cierra`.`ci_usuario`))) on((`ticket`.`codigo` = `cierra`.`codigo_ticket`))) ;

-- --------------------------------------------------------

--
-- Estructura para la vista `consult10`
--
DROP TABLE IF EXISTS `consult10`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `consult10`  AS  select `sesion`.`nombre` AS `Nombre`,`sesion`.`fh_inicia` AS `Inicio de sesion`,`sesion`.`fh_cierra` AS `Cierre de sesion` from `sesion` ;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `cierra`
--
ALTER TABLE `cierra`
  ADD PRIMARY KEY (`codigo_ticket`),
  ADD KEY `ci_usuario` (`ci_usuario`);

--
-- Indices de la tabla `gestiona`
--
ALTER TABLE `gestiona`
  ADD PRIMARY KEY (`ci_u`,`codigo_p`),
  ADD KEY `codigo_p` (`codigo_p`);

--
-- Indices de la tabla `historico`
--
ALTER TABLE `historico`
  ADD PRIMARY KEY (`cod_i`,`fecha_mov`);

--
-- Indices de la tabla `insumos`
--
ALTER TABLE `insumos`
  ADD PRIMARY KEY (`codigo_i`);

--
-- Indices de la tabla `sesion`
--
ALTER TABLE `sesion`
  ADD PRIMARY KEY (`fh_inicia`);

--
-- Indices de la tabla `ticket`
--
ALTER TABLE `ticket`
  ADD PRIMARY KEY (`codigo`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`ci`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `ticket`
--
ALTER TABLE `ticket`
  MODIFY `codigo` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
