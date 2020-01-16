-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 16-09-2017 a las 04:51:05
-- Versión del servidor: 5.7.18-log
-- Versión de PHP: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `libreria_parra`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `bodega`
--

CREATE TABLE `bodega` (
  `id_registro` int(11) NOT NULL,
  `producto` varchar(30) NOT NULL,
  `cantidad` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `bodega`
--

INSERT INTO `bodega` (`id_registro`, `producto`, `cantidad`) VALUES
(1, '025215961731', 5),
(2, '025215495090', 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `caja`
--

CREATE TABLE `caja` (
  `id` int(11) NOT NULL,
  `gastos` float NOT NULL,
  `ventas` float NOT NULL,
  `pagos` float NOT NULL,
  `total` float NOT NULL,
  `fecha` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `categoria`
--

CREATE TABLE `categoria` (
  `codigo` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `categoria`
--

INSERT INTO `categoria` (`codigo`, `nombre`) VALUES
(1, 'TECNOLOGIA'),
(2, 'ESCOLARES'),
(3, 'OFICINA'),
(4, 'MANUALIDADES'),
(5, 'SERVICIOS');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

CREATE TABLE `cliente` (
  `ruc` varchar(30) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `direccion` varchar(100) NOT NULL,
  `telefono` varchar(9) NOT NULL,
  `email` varchar(25) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `cliente`
--

INSERT INTO `cliente` (`ruc`, `nombre`, `direccion`, `telefono`, `email`) VALUES
('1234', 'CONTADO', 'LEON', '58244180', 'yesser.miranda@gmail.com'),
('17101997', 'ALMACENES JERUSALEM', 'CENTRO COMERCIAL PASEO REAL', '58244180', 'alm.jerusalem@gmail.com');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `credito`
--

CREATE TABLE `credito` (
  `codigo` int(11) NOT NULL,
  `fecha_final` date NOT NULL,
  `empresa` int(11) NOT NULL,
  `total` float NOT NULL,
  `estado` enum('PENDIENTE','PAGADO') DEFAULT NULL,
  `proveedor` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `credito`
--

INSERT INTO `credito` (`codigo`, `fecha_final`, `empresa`, `total`, `estado`, `proveedor`) VALUES
(1, '2017-09-03', 1, 12000, 'PAGADO', '101092'),
(3, '2017-11-02', 1, 10000, 'PAGADO', '17101997'),
(4, '2017-12-01', 1, 5000, 'PAGADO', '8081991'),
(5, '2017-12-02', 1, 2000, 'PAGADO', '101092'),
(6, '2017-12-03', 1, 3000, 'PAGADO', '101092'),
(7, '2017-10-21', 1, 20000, 'PENDIENTE', '101092'),
(8, '2017-10-21', 1, 20000, 'PENDIENTE', '101092'),
(9, '2017-10-22', 1, 22000, 'PAGADO', '17101997'),
(10, '2017-10-22', 1, 22000, 'PENDIENTE', '8081991'),
(11, '2017-10-12', 1, 20000, 'PENDIENTE', '8081991');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_factura`
--

CREATE TABLE `detalle_factura` (
  `codigo` int(11) NOT NULL,
  `codigo_factura` int(11) NOT NULL,
  `producto` varchar(30) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `descuento` int(11) DEFAULT NULL,
  `total` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `detalle_factura`
--

INSERT INTO `detalle_factura` (`codigo`, `codigo_factura`, `producto`, `cantidad`, `descuento`, `total`) VALUES
(3, 42, '025215490217', 1, 510, 0),
(4, 43, '025215197125', 1, 135, 0),
(5, 44, '025215491207', 1, 110, 0),
(6, 45, '025215721113', 1, 100, 0),
(7, 46, '025215490217', 1, 510, 0),
(8, 49, '025215492891', 1, 65, 65),
(9, 51, '025215489617', 1, 235, 235),
(10, 51, '025215736483', 1, 20, 20);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_pedido`
--

CREATE TABLE `detalle_pedido` (
  `codigo` int(11) NOT NULL,
  `codigo_factura` int(11) NOT NULL,
  `producto` varchar(30) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `descuento` int(11) DEFAULT NULL,
  `total` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `detalle_pedido`
--

INSERT INTO `detalle_pedido` (`codigo`, `codigo_factura`, `producto`, `cantidad`, `descuento`, `total`) VALUES
(13, 51, '025215723025', 1, 95, 95);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_producto`
--

CREATE TABLE `detalle_producto` (
  `ns` varchar(30) NOT NULL,
  `estado_producto` enum('DISPONIBLE','VENDIDO','DEVUELTO','PENDIENTE','ENTREGADO') NOT NULL,
  `codigo_barras` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `detalle_producto`
--

INSERT INTO `detalle_producto` (`ns`, `estado_producto`, `codigo_barras`) VALUES
('V98Y044431', 'DISPONIBLE', '010343920620'),
('VGNK289629', 'DISPONIBLE', '010343918252'),
('VGNK289633', 'DISPONIBLE', '010343918252'),
('VGNK289746', 'DISPONIBLE', '010343918252'),
('VH3K086213', 'DISPONIBLE', '010343918283');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `devolucion`
--

CREATE TABLE `devolucion` (
  `idDevolucion` int(11) NOT NULL,
  `Detalle_devolucion` varchar(150) NOT NULL,
  `Identificacion_producto` varchar(30) NOT NULL,
  `id_factura` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `devolucion`
--

INSERT INTO `devolucion` (`idDevolucion`, `Detalle_devolucion`, `Identificacion_producto`, `id_factura`) VALUES
(1, 'ESTE PRODUCTO NO FUNCIONA EL BT', '025215192968', 35),
(2, 'NO FUNCIONA EL BT', '025215494123', 35),
(3, 'NO FUNCIONA EL CABLE', '025215494123', 35),
(4, 'NO FUNCIONA EL PINCHE PRODUCTO', '025215494147', 36),
(5, 'NO SIRVE', '025215192968', 35),
(6, 'NO FUNCIONA EL PINCHE', '025215494147', 36),
(7, 'no sirve', '025215961724', 37),
(8, 'no sirve 2', '025215494147', 36),
(9, 'HI', '025215192968', 35);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `devolucion_clientes`
--

CREATE TABLE `devolucion_clientes` (
  `idDevolucionClientes` int(11) NOT NULL,
  `id_cliente` varchar(30) NOT NULL,
  `id_devolucion` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='	';

--
-- Volcado de datos para la tabla `devolucion_clientes`
--

INSERT INTO `devolucion_clientes` (`idDevolucionClientes`, `id_cliente`, `id_devolucion`) VALUES
(1, '1234', 1),
(2, '1234', 3),
(3, '1234', 7),
(4, '1234', 8),
(5, '1234', 9);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `devolucion_proveedores`
--

CREATE TABLE `devolucion_proveedores` (
  `idDevolucionProveedores` int(11) NOT NULL,
  `id_proveedor` varchar(30) NOT NULL,
  `id_devolucion` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `devolucion_proveedores`
--

INSERT INTO `devolucion_proveedores` (`idDevolucionProveedores`, `id_proveedor`, `id_devolucion`) VALUES
(1, '17101997', 6);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empresa`
--

CREATE TABLE `empresa` (
  `codigo` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `empresa`
--

INSERT INTO `empresa` (`codigo`, `nombre`) VALUES
(1, 'LIBRERIA PARRA JUNIOR');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `factura`
--

CREATE TABLE `factura` (
  `codigo` int(11) NOT NULL,
  `fecha_hora` datetime NOT NULL,
  `empresa` int(11) NOT NULL,
  `cliente` varchar(30) NOT NULL,
  `total` float NOT NULL,
  `tipo_pago` enum('CONTADO','TARJETA','PAY PHONE','CHEQUE','CREDITO') NOT NULL,
  `descripcion_pago` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `factura`
--

INSERT INTO `factura` (`codigo`, `fecha_hora`, `empresa`, `cliente`, `total`, `tipo_pago`, `descripcion_pago`) VALUES
(35, '2017-08-14 09:51:44', 1, '1234', 135, 'CONTADO', 'CONTADO'),
(36, '2017-08-05 18:31:13', 1, '1234', 270, 'CONTADO', 'CONTADO'),
(37, '2017-08-13 15:05:00', 1, '1234', 100, 'CONTADO', 'CONTADO'),
(38, '2017-08-14 12:19:07', 1, '1234', 135, 'CONTADO', 'CONTADO'),
(39, '2017-08-14 12:42:39', 1, '1234', 135, 'CONTADO', 'CONTADO'),
(40, '2017-08-14 16:52:13', 1, '1234', 135, 'CONTADO', 'CONTADO'),
(41, '2017-08-14 16:53:52', 1, '1234', 100, 'CONTADO', 'CONTADO'),
(42, '2017-08-15 15:43:35', 1, '1234', 510, 'CONTADO', 'CONTADO'),
(43, '2017-08-24 19:55:13', 1, '1234', 135, 'CONTADO', 'CONTADO'),
(44, '2017-08-24 20:15:12', 1, '1234', 110, 'CONTADO', 'CONTADO'),
(45, '2017-08-24 20:24:51', 1, '1234', 100, 'CONTADO', 'CONTADO'),
(46, '2017-09-01 08:36:03', 1, '1234', 510, 'CONTADO', 'CONTADO'),
(47, '2017-09-14 11:14:34', 1, '1234', 235, 'CONTADO', 'CONTADO'),
(48, '2017-09-14 11:19:24', 1, '1234', 235, 'CONTADO', 'CONTADO'),
(49, '2017-09-14 11:22:05', 1, '1234', 65, 'CONTADO', 'CONTADO'),
(50, '2017-09-14 13:06:54', 1, '1234', 365, 'CONTADO', 'CONTADO'),
(51, '2017-09-14 13:13:03', 1, '1234', 350, 'CONTADO', 'CONTADO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `gastos`
--

CREATE TABLE `gastos` (
  `id` int(11) NOT NULL,
  `cantidad` float NOT NULL,
  `descripción` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `fecha` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `gastos`
--

INSERT INTO `gastos` (`id`, `cantidad`, `descripción`, `fecha`) VALUES
(1, 20, 's', '2017-08-13'),
(2, 1000, 'd', '2017-08-08'),
(3, 100, 'YESSER PUTITO', '2017-08-14'),
(4, 200, 'CAFE', '2017-08-14');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `marca`
--

CREATE TABLE `marca` (
  `codigo` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `marca`
--

INSERT INTO `marca` (`codigo`, `nombre`) VALUES
(1, 'MAXELL'),
(2, 'SAMSUNG'),
(3, 'EPSON'),
(4, 'KLIP EXTREME'),
(5, 'NEXXT'),
(6, 'MAPED'),
(7, 'BARRILITO'),
(8, 'POINTER'),
(9, 'TUCAN'),
(10, 'CASIO'),
(11, 'KORES'),
(12, 'PAPERMATE'),
(13, 'FABER CASTEL'),
(14, 'VINCI'),
(15, 'UNIVERSAL'),
(16, 'MAE');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pagos`
--

CREATE TABLE `pagos` (
  `codigo` int(11) NOT NULL,
  `fecha` date NOT NULL,
  `hora` time NOT NULL,
  `monto` float NOT NULL,
  `codigo_credito` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `pagos`
--

INSERT INTO `pagos` (`codigo`, `fecha`, `hora`, `monto`, `codigo_credito`) VALUES
(1, '2017-01-02', '17:00:00', 5000, 1),
(3, '2017-09-11', '16:24:00', 7000, 1),
(5, '2017-01-02', '00:00:00', 12000, 3),
(6, '2017-09-21', '16:40:00', 6000, 4),
(7, '2017-09-28', '17:30:00', 2000, 5),
(8, '2017-09-15', '11:32:00', 2000, 6),
(9, '2017-09-29', '12:40:00', 1000, 6),
(10, '2017-08-23', '17:40:00', 10000, 8),
(11, '2017-09-08', '13:16:00', 10000, 9),
(12, '2017-01-02', '00:00:00', 3000, 9),
(13, '2017-01-02', '00:00:00', 9000, 9);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pagos_trabajadores`
--

CREATE TABLE `pagos_trabajadores` (
  `id` int(11) NOT NULL,
  `cantidad` float NOT NULL,
  `cedula` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `fecha` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `pagos_trabajadores`
--

INSERT INTO `pagos_trabajadores` (`id`, `cantidad`, `cedula`, `fecha`) VALUES
(1, 100, '281-060196-0012X', '2017-08-14'),
(5, 1000, '281-060196-0012X', '0000-00-00'),
(6, 1000, '281-060196-0012X', '0000-00-00'),
(7, 2000, '281-060196-0012X', '2017-08-14'),
(8, 45443, '615-171097-0001W', '2017-08-18');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

CREATE TABLE `productos` (
  `codigo` varchar(30) NOT NULL,
  `ubicacion` varchar(10) DEFAULT NULL,
  `nombre` varchar(60) NOT NULL,
  `caracteristica` varchar(100) DEFAULT NULL,
  `precio` float NOT NULL,
  `stock` int(11) DEFAULT NULL,
  `marca` int(11) NOT NULL,
  `presentacion` enum('UNIDAD','DOCENA','RESMA','CAJA','PAQUETE','OTROS') NOT NULL,
  `proveedor` varchar(30) NOT NULL,
  `categoria` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`codigo`, `ubicacion`, `nombre`, `caracteristica`, `precio`, `stock`, `marca`, `presentacion`, `proveedor`, `categoria`) VALUES
('010343918252', 'EST_MAXELL', 'IMPRESORA L220', 'IMPRIME, COPIA, ESCANEA', 7500, 3, 3, 'UNIDAD', '17101997', 1),
('010343918283', 'EST_MAXELL', 'IMPRESORA L365', 'INALAMBRICA, IMPRIME, COPIA, ESCANEA', 8500, 2, 3, 'UNIDAD', '17101997', 1),
('010343920620', 'EST_MAXELL', 'IMPRESORA L575', 'INALAMBRICA,  IMPRIME, COPIA, ESCANEA, FAX, ETHERNET', 12000, 4, 3, 'UNIDAD', '17101997', 1),
('025215192968', 'EST_MAXELL', 'AUDIFONOS JUICY TUNES JT-P', 'CABLE DE 1.2  CON SENSIBILIDAD DE 100 DB', 135, 8, 1, 'UNIDAD', '17101997', 1),
('025215193606', 'EST_MAXELL', 'AUDIFONOS JELLEEZ EB-WT', 'FONES DE OUVIDIO', 125, 2, 1, 'UNIDAD', '17101997', 1),
('025215197125', 'EST_MAXELL', 'AUDIFONOS JINX JEB-WH', 'SENSIBILIDAD 100DB', 135, 3, 1, 'UNIDAD', '17101997', 1),
('025215489617', 'EST_MAXELL', 'AUDIFONOS PLEGABLES H-MIC', 'MICROFONO DESMONTABLE CONTROL DE PLAYBACK', 235, 9, 1, 'UNIDAD', '17101997', 1),
('025215490217', 'EST_MAXELL', 'MOUSE MOWL-200', 'INALAMBRICO PARA VIAJES Y RECEPTOR MICROUSB', 510, 1, 1, 'UNIDAD', '17101997', 1),
('025215491207', 'EST_MAXELL', 'AUDIFONOS PLUGS IN-225', 'CON BOTON Y SENSIBILIDAD DE 94 DB', 110, 5, 1, 'UNIDAD', '17101997', 1),
('025215492891', 'EST_MAXELL', 'AURICULAR ESTEREO EB-95', 'SONIDO ESTEREO DE BOTON CON SENSIBILIDAD DE 95 DB', 65, 5, 1, 'UNIDAD', '17101997', 1),
('025215493416', 'EST_MAXELL', 'MOUSE MOWR-101', 'OPTICO CON USB 1000 DPI ERGONOMICO', 195, 5, 1, 'UNIDAD', '17101997', 1),
('025215494123', 'EST_MAXELL', 'AURICULAR ESTEREO EB-MIC', 'SONIDO ESTEREO DE BOTON CON MICROFONO', 95, 14, 1, 'UNIDAD', '17101997', 1),
('025215494147', 'EST_MAXELL', 'AURICULARES PLUGS MIC IN-MIC', 'DE BOTONO CON MICROFONO SENSIBILIDAD DE 40DB', 135, 12, 1, 'UNIDAD', '17101997', 1),
('02521549451', 'EST_MAXELL', 'CABLE MICROUSB MUSB-600-6FT-CABLEORG', 'CON ADAPTADOR DE PARED', 350, 1, 1, 'UNIDAD', '17101997', 1),
('025215494888', 'EST_MAXELL', 'AUDIFONOS PURE FITNESS EB-ESB', 'MICROFONO CON CONTROL DE VOLUMEN', 395, 1, 1, 'UNIDAD', '17101997', 1),
('025215495090', 'EST_MAXELL', 'MICRO AUDIFONOS INNE-300', 'CON MICROFONO INCLUIDO', 290, 12, 1, 'UNIDAD', '17101997', 1),
('025215496332', 'EST_MAXELL', 'AURICULARES WIRED RETRO EARPHONES WIR-90', 'DE OIDO INTERNO CONTROL DE VOLUMEN Y MICROFONO', 380, 2, 1, 'UNIDAD', '17101997', 1),
('025215496424', 'EST_MAXELL', 'CARGADOR PORTATIL MUSB-KC', 'USB A MICROUSB CHARGE & SYNC FLEXIBLE', 190, 3, 1, 'UNIDAD', '17101997', 1),
('025215496523', 'EST_MAXELL', 'AUDIFONOS DUAL COLOR', 'CONECTOR PARA COMPARTIR - EARBUDS COMBO', 300, 10, 1, 'UNIDAD', '17101997', 1),
('025215497032', 'EST_MAXELL', 'CONEXION METALICA MUSB-LTR', 'MICROUSB A USB 15 CM', 235, 3, 1, 'UNIDAD', '17101997', 1),
('025215497209', 'EST_MAXELL', 'AUDIFONOS DJ-21', 'PLEGABLES CON MICROFONO BAJOS PROFUNDOS', 460, 2, 1, 'UNIDAD', '17101997', 1),
('025215497292', 'EST_MAXELL', 'AUDIFONOS REFLEKT REFL LIME ', 'CONTROL MULTIMEDIA MICROFONO BAJOS PROFUNDOS', 340, 1, 1, 'UNIDAD', '17101997', 1),
('025215498152', 'EST_MAXELL', 'AURICULARES GRIP HEADPHONES K-100', 'MICROFONO CON CONTROL DE VOLUMEN CON ALMOHADILLAS', 460, 1, 1, 'UNIDAD', '17101997', 1),
('025215498268', 'EST_MAXELL', 'AUDIFONOS SOLID EB-BT100', 'INALAMBRICO BLUETOOTH CON CONTROL DE MULTIMEDIA', 650, 3, 1, 'UNIDAD', '17101997', 1),
('025215721113', 'EST_MAXELL', 'PILAS ALCALINAS 6LF22-1BP', '9 VOLTIOS', 100, 8, 1, 'UNIDAD', '17101997', 1),
('025215723025', 'EST_MAXELL', 'PILAS ALCALINAS D LR20-2BP', '1.5 VOLTIOS', 95, 2, 1, 'UNIDAD', '17101997', 1),
('025215736483', 'EST_MAXELL', 'PILAS MICRO-LITHIUM CELL CR2032', '3 VOLTIOS', 20, 0, 1, 'UNIDAD', '17101997', 1),
('02521579306', 'EST_MAXELL', 'PILAS RECARGABLES AA MH6-2BP', '1.2 VOLTIOS', 185, 2, 1, 'UNIDAD', '17101997', 1),
('025215961724', 'EST_MAXELL', 'PILAS ALCALINAS AAA LR03-2BP', '1.5 VOLTIOS', 25, 4, 1, 'UNIDAD', '17101997', 1),
('025215961731', 'EST_MAXELL', 'PILAS ALCALINAS AA LR6-2BP', '1.5 VOLTIOS ', 25, 6, 1, 'UNIDAD', '17101997', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedor`
--

CREATE TABLE `proveedor` (
  `ruc` varchar(30) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `direccion` varchar(100) NOT NULL,
  `telefono` varchar(9) NOT NULL,
  `email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `proveedor`
--

INSERT INTO `proveedor` (`ruc`, `nombre`, `direccion`, `telefono`, `email`) VALUES
('101092', 'LIBRERIA UNIVERSAL', 'MANAGUA', '2311-6753', 'LIBRERIA.UNIVERSAL@GMAIL.COM'),
('17101997', 'COMERCIAL ALTASA', 'MANAGUA', '87972337', 'marlon.altamirano97@gmail'),
('2811709810001W', 'TAIZ', 'MNAGUA', '2311-3453', 'TAIZ@GMAIL.COM'),
('8081991', 'LIBRERIA JARDIN', 'MANAGUA', '2311-4567', 'LIBRERIA.JARDIN@GMAIL.COM');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trabajadores`
--

CREATE TABLE `trabajadores` (
  `cedula` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `nombre` varchar(30) COLLATE utf8_unicode_ci NOT NULL,
  `apellido` varchar(30) COLLATE utf8_unicode_ci NOT NULL,
  `telefono` varchar(9) COLLATE utf8_unicode_ci NOT NULL,
  `salario` float NOT NULL,
  `fecha_entrada` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `trabajadores`
--

INSERT INTO `trabajadores` (`cedula`, `nombre`, `apellido`, `telefono`, `salario`, `fecha_entrada`) VALUES
('281-060196-0012X', 'HENRY JAVIER', 'CANALES MOLINA', '8699-3487', 1000, '2017-08-14'),
('615-171097-0001W', 'YESSER JOEL', 'GUARDADO DELGADO', '8888-8888', 50000, '2017-08-14');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `id` int(11) NOT NULL,
  `usuario` varchar(50) NOT NULL,
  `pass` varchar(100) NOT NULL,
  `tipo_usuario` enum('CAJERO','ADMIN') DEFAULT 'CAJERO'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`id`, `usuario`, `pass`, `tipo_usuario`) VALUES
(1, 'Yesser', 'Ingeniero.1', 'CAJERO'),
(3, 'Henry', '123', ''),
(4, 'Sayda', '123', 'CAJERO');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `bodega`
--
ALTER TABLE `bodega`
  ADD PRIMARY KEY (`id_registro`),
  ADD KEY `bodega_prod_fk_idx` (`producto`);

--
-- Indices de la tabla `caja`
--
ALTER TABLE `caja`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `categoria`
--
ALTER TABLE `categoria`
  ADD PRIMARY KEY (`codigo`);

--
-- Indices de la tabla `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`ruc`);

--
-- Indices de la tabla `credito`
--
ALTER TABLE `credito`
  ADD PRIMARY KEY (`codigo`),
  ADD KEY `empresafk1` (`empresa`),
  ADD KEY `proveedor_cred_fk_idx` (`proveedor`);

--
-- Indices de la tabla `detalle_factura`
--
ALTER TABLE `detalle_factura`
  ADD PRIMARY KEY (`codigo`),
  ADD KEY `facturafk` (`codigo_factura`),
  ADD KEY `productofk` (`producto`);

--
-- Indices de la tabla `detalle_pedido`
--
ALTER TABLE `detalle_pedido`
  ADD PRIMARY KEY (`codigo`),
  ADD KEY `facturafk` (`codigo_factura`),
  ADD KEY `productofk` (`producto`);

--
-- Indices de la tabla `detalle_producto`
--
ALTER TABLE `detalle_producto`
  ADD PRIMARY KEY (`ns`),
  ADD KEY `fk_p_dp` (`codigo_barras`);

--
-- Indices de la tabla `devolucion`
--
ALTER TABLE `devolucion`
  ADD PRIMARY KEY (`idDevolucion`),
  ADD KEY `facturafk_idx` (`id_factura`),
  ADD KEY `factura_dev_fk_idx` (`id_factura`),
  ADD KEY `producto_dev_fk_idx` (`Identificacion_producto`);

--
-- Indices de la tabla `devolucion_clientes`
--
ALTER TABLE `devolucion_clientes`
  ADD PRIMARY KEY (`idDevolucionClientes`),
  ADD KEY `id_devolucion` (`id_devolucion`),
  ADD KEY `id_cliente` (`id_cliente`);

--
-- Indices de la tabla `devolucion_proveedores`
--
ALTER TABLE `devolucion_proveedores`
  ADD PRIMARY KEY (`idDevolucionProveedores`),
  ADD KEY `id_devolucion` (`id_devolucion`),
  ADD KEY `id_proveedor` (`id_proveedor`);

--
-- Indices de la tabla `empresa`
--
ALTER TABLE `empresa`
  ADD PRIMARY KEY (`codigo`);

--
-- Indices de la tabla `factura`
--
ALTER TABLE `factura`
  ADD PRIMARY KEY (`codigo`),
  ADD KEY `empresafk` (`empresa`),
  ADD KEY `clientefk` (`cliente`);

--
-- Indices de la tabla `gastos`
--
ALTER TABLE `gastos`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `marca`
--
ALTER TABLE `marca`
  ADD PRIMARY KEY (`codigo`);

--
-- Indices de la tabla `pagos`
--
ALTER TABLE `pagos`
  ADD PRIMARY KEY (`codigo`),
  ADD KEY `creditofk` (`codigo_credito`);

--
-- Indices de la tabla `pagos_trabajadores`
--
ALTER TABLE `pagos_trabajadores`
  ADD PRIMARY KEY (`id`),
  ADD KEY `cedula` (`cedula`);

--
-- Indices de la tabla `productos`
--
ALTER TABLE `productos`
  ADD PRIMARY KEY (`codigo`),
  ADD KEY `proveedorfk` (`proveedor`),
  ADD KEY `marcafk` (`marca`),
  ADD KEY `fk_pc` (`categoria`);

--
-- Indices de la tabla `proveedor`
--
ALTER TABLE `proveedor`
  ADD PRIMARY KEY (`ruc`);

--
-- Indices de la tabla `trabajadores`
--
ALTER TABLE `trabajadores`
  ADD PRIMARY KEY (`cedula`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `bodega`
--
ALTER TABLE `bodega`
  MODIFY `id_registro` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `caja`
--
ALTER TABLE `caja`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `categoria`
--
ALTER TABLE `categoria`
  MODIFY `codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT de la tabla `credito`
--
ALTER TABLE `credito`
  MODIFY `codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
--
-- AUTO_INCREMENT de la tabla `detalle_factura`
--
ALTER TABLE `detalle_factura`
  MODIFY `codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT de la tabla `detalle_pedido`
--
ALTER TABLE `detalle_pedido`
  MODIFY `codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
--
-- AUTO_INCREMENT de la tabla `devolucion`
--
ALTER TABLE `devolucion`
  MODIFY `idDevolucion` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
--
-- AUTO_INCREMENT de la tabla `devolucion_clientes`
--
ALTER TABLE `devolucion_clientes`
  MODIFY `idDevolucionClientes` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT de la tabla `devolucion_proveedores`
--
ALTER TABLE `devolucion_proveedores`
  MODIFY `idDevolucionProveedores` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `factura`
--
ALTER TABLE `factura`
  MODIFY `codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=52;
--
-- AUTO_INCREMENT de la tabla `gastos`
--
ALTER TABLE `gastos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT de la tabla `marca`
--
ALTER TABLE `marca`
  MODIFY `codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;
--
-- AUTO_INCREMENT de la tabla `pagos`
--
ALTER TABLE `pagos`
  MODIFY `codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
--
-- AUTO_INCREMENT de la tabla `pagos_trabajadores`
--
ALTER TABLE `pagos_trabajadores`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `bodega`
--
ALTER TABLE `bodega`
  ADD CONSTRAINT `bodega_prod_fk` FOREIGN KEY (`producto`) REFERENCES `productos` (`codigo`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `credito`
--
ALTER TABLE `credito`
  ADD CONSTRAINT `empresafk1` FOREIGN KEY (`empresa`) REFERENCES `empresa` (`codigo`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `proveedor_cred_fk` FOREIGN KEY (`proveedor`) REFERENCES `proveedor` (`ruc`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `detalle_factura`
--
ALTER TABLE `detalle_factura`
  ADD CONSTRAINT `facturafk` FOREIGN KEY (`codigo_factura`) REFERENCES `factura` (`codigo`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `productofk` FOREIGN KEY (`producto`) REFERENCES `productos` (`codigo`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `detalle_pedido`
--
ALTER TABLE `detalle_pedido`
  ADD CONSTRAINT `factura1fk` FOREIGN KEY (`codigo_factura`) REFERENCES `factura` (`codigo`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `producto1fk` FOREIGN KEY (`producto`) REFERENCES `productos` (`codigo`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `detalle_producto`
--
ALTER TABLE `detalle_producto`
  ADD CONSTRAINT `fk_p_dp` FOREIGN KEY (`codigo_barras`) REFERENCES `productos` (`codigo`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `devolucion`
--
ALTER TABLE `devolucion`
  ADD CONSTRAINT `factura_dev_fk` FOREIGN KEY (`id_factura`) REFERENCES `factura` (`codigo`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `producto_dev_fk` FOREIGN KEY (`Identificacion_producto`) REFERENCES `productos` (`codigo`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `devolucion_clientes`
--
ALTER TABLE `devolucion_clientes`
  ADD CONSTRAINT `devolucion_clientes_ibfk_1` FOREIGN KEY (`id_devolucion`) REFERENCES `devolucion` (`idDevolucion`),
  ADD CONSTRAINT `devolucion_clientes_ibfk_2` FOREIGN KEY (`id_cliente`) REFERENCES `cliente` (`ruc`);

--
-- Filtros para la tabla `devolucion_proveedores`
--
ALTER TABLE `devolucion_proveedores`
  ADD CONSTRAINT `devolucion_proveedores_ibfk_1` FOREIGN KEY (`id_devolucion`) REFERENCES `devolucion` (`idDevolucion`),
  ADD CONSTRAINT `devolucion_proveedores_ibfk_2` FOREIGN KEY (`id_proveedor`) REFERENCES `proveedor` (`ruc`);

--
-- Filtros para la tabla `factura`
--
ALTER TABLE `factura`
  ADD CONSTRAINT `clientefk` FOREIGN KEY (`cliente`) REFERENCES `cliente` (`ruc`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `empresafk` FOREIGN KEY (`empresa`) REFERENCES `empresa` (`codigo`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `pagos`
--
ALTER TABLE `pagos`
  ADD CONSTRAINT `creditofk` FOREIGN KEY (`codigo_credito`) REFERENCES `credito` (`codigo`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `pagos_trabajadores`
--
ALTER TABLE `pagos_trabajadores`
  ADD CONSTRAINT `pagos_trabajadores_ibfk_1` FOREIGN KEY (`cedula`) REFERENCES `trabajadores` (`cedula`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `productos`
--
ALTER TABLE `productos`
  ADD CONSTRAINT `fk_pc` FOREIGN KEY (`categoria`) REFERENCES `categoria` (`codigo`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `marcafk` FOREIGN KEY (`marca`) REFERENCES `marca` (`codigo`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `proveedorfk` FOREIGN KEY (`proveedor`) REFERENCES `proveedor` (`ruc`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
