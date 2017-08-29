-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Servidor: localhost
-- Tiempo de generación: 29-08-2017 a las 19:03:41
-- Versión del servidor: 5.6.34
-- Versión de PHP: 7.1.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `goodeating_db`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `VN_AGES`
--

CREATE TABLE `VN_AGES` (
  `id_age` int(11) NOT NULL,
  `age` varchar(20) CHARACTER SET latin1 DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `VN_AGES`
--

INSERT INTO `VN_AGES` (`id_age`, `age`) VALUES
(1, 'Between 13 and 25 ye'),
(2, 'Between 26 and 60 ye'),
(3, 'More than 60 years');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `VN_COUNTRIES`
--

CREATE TABLE `VN_COUNTRIES` (
  `id_country` int(11) NOT NULL,
  `iso` char(2) CHARACTER SET latin1 DEFAULT NULL,
  `name` varchar(80) CHARACTER SET latin1 DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `VN_COUNTRIES`
--

INSERT INTO `VN_COUNTRIES` (`id_country`, `iso`, `name`) VALUES
(1, 'AF', 'Afghanistan'),
(2, 'AX', 'Aland Islands'),
(3, 'AL', 'Albania'),
(4, 'DE', 'Germany'),
(5, 'AD', 'Andorra'),
(6, 'AO', 'Angola'),
(7, 'AI', 'Anguilla'),
(8, 'AQ', 'Antarctica'),
(9, 'AG', 'Antigua and Barbuda'),
(10, 'AN', 'Netherlands Antilles'),
(11, 'SA', 'Saudi Arabia'),
(12, 'DZ', 'Algeria'),
(13, 'AR', 'Argentina'),
(14, 'AM', 'Armenia'),
(15, 'AW', 'Aruba'),
(16, 'AU', 'Australia'),
(17, 'AT', 'Austria'),
(18, 'AZ', 'Azerbaijan'),
(19, 'BS', 'Bahamas'),
(20, 'BH', 'Bahrain'),
(21, 'BD', 'Bangladesh'),
(22, 'BB', 'Barbados'),
(23, 'BY', 'Belarus'),
(24, 'BE', 'Belgium'),
(25, 'BZ', 'Belize'),
(26, 'BJ', 'Benin'),
(27, 'BM', 'Bermuda'),
(28, 'BT', 'Bhutan'),
(29, 'BO', 'Bolivia'),
(30, 'BA', 'Bosnia and Herzegovina'),
(31, 'BW', 'Botswana'),
(32, 'BV', 'Bouvet Island'),
(33, 'BR', 'Brazil'),
(34, 'BN', 'Brunei'),
(35, 'BG', 'Bulgaria'),
(36, 'BF', 'Burkina Faso'),
(37, 'BI', 'Burundi'),
(38, 'CV', 'Cape Verde'),
(39, 'KY', 'Cayman Islands'),
(40, 'KH', 'Cambodia'),
(41, 'CM', 'Cameroon'),
(42, 'CA', 'Canada'),
(43, 'CF', 'Central African Republic'),
(44, 'TD', 'Chad'),
(45, 'CZ', 'Czech Republic'),
(46, 'CL', 'Chile'),
(47, 'CN', 'China'),
(48, 'CY', 'Cyprus'),
(49, 'CX', 'Christmas Island'),
(50, 'VA', 'Holy See'),
(51, 'CC', 'Cocos Islands'),
(52, 'CO', 'Colombia'),
(53, 'KM', 'Comoros'),
(54, 'CD', 'Democratic Republic of the Congo'),
(55, 'CG', 'Congo'),
(56, 'CK', 'Cook Islands'),
(57, 'KP', 'North Korea'),
(58, 'KR', 'South Korea'),
(59, 'CI', 'Cote d\'Ivoire'),
(60, 'CR', 'Costa Rica'),
(61, 'HR', 'Croatia'),
(62, 'CU', 'Cuba'),
(63, 'DK', 'Denmark'),
(64, 'DM', 'Dominica'),
(65, 'DO', 'Dominican Republic'),
(66, 'EC', 'Ecuador'),
(67, 'EG', 'Egypt'),
(68, 'SV', 'El Salvador'),
(69, 'AE', 'United Arab Emirates'),
(70, 'ER', 'Eritrea'),
(71, 'SK', 'Slovakia'),
(72, 'SI', 'Slovenia'),
(73, 'ES', 'Spain'),
(74, 'UM', 'United States Minor Outlying Islands'),
(75, 'US', 'United States'),
(76, 'EE', 'Estonia'),
(77, 'ET', 'Ethiopía'),
(78, 'FO', 'Faeroe Islands'),
(79, 'PH', 'Philippines'),
(80, 'FI', 'Finland'),
(81, 'FJ', 'Fiyi'),
(82, 'FR', 'France'),
(83, 'GA', 'Gabon'),
(84, 'GM', 'Gambia'),
(85, 'GE', 'Georgia'),
(86, 'GS', 'South Georgia and the South Sandwich Islands'),
(87, 'GH', 'Ghana'),
(88, 'GI', 'Gibraltar'),
(89, 'GD', 'Granada'),
(90, 'GR', 'Greece'),
(91, 'GL', 'Greenland'),
(92, 'GP', 'Guadeloupe'),
(93, 'GU', 'Guam'),
(94, 'GT', 'Guatemala'),
(95, 'GF', 'French Guyana'),
(96, 'GN', 'Guinea'),
(97, 'GQ', 'Equatorial Guinea'),
(98, 'GW', 'Guinea-Bissau'),
(99, 'GY', 'Guyana'),
(100, 'HT', 'Haiti'),
(101, 'HM', 'Heard Island and McDonald Islands'),
(102, 'HN', 'Honduras'),
(103, 'HK', 'Hong Kong'),
(104, 'HU', 'Hungary'),
(105, 'IN', 'India'),
(106, 'ID', 'Indonesia'),
(107, 'IR', 'Iran'),
(108, 'IQ', 'Iraq'),
(109, 'IE', 'Ireland'),
(110, 'IS', 'Iceland'),
(111, 'IL', 'Israel'),
(112, 'IT', 'Italy'),
(113, 'JM', 'Jamaica'),
(114, 'JP', 'Japan'),
(115, 'JO', 'Jordan'),
(116, 'KZ', 'Kazakhstan'),
(117, 'KE', 'Kenya'),
(118, 'KG', 'Kyrgyzstan'),
(119, 'KI', 'Kiribati'),
(120, 'KW', 'Kuwait'),
(121, 'LA', 'Laos'),
(122, 'LS', 'Lesotho'),
(123, 'LV', 'Latvia'),
(124, 'LB', 'Lebanon'),
(125, 'LR', 'Liberia'),
(126, 'LY', 'Libyan Arab Jamahiriya'),
(127, 'LI', 'Liechtenstein'),
(128, 'LT', 'Lithuania'),
(129, 'LU', 'Luxembourg'),
(130, 'MO', 'Macao'),
(131, 'MK', 'ARY Macedonia'),
(132, 'MG', 'Madagascar'),
(133, 'MY', 'Malaysia'),
(134, 'MW', 'Malawi'),
(135, 'MV', 'Maldives'),
(136, 'ML', 'Mali'),
(137, 'MT', 'Malta'),
(138, 'FK', 'Falkland Islands'),
(139, 'MP', 'Northern Mariana Islands'),
(140, 'MA', 'Morocco'),
(141, 'MH', 'Marshall Islands'),
(142, 'MQ', 'Martinique'),
(143, 'MU', 'Mauritius'),
(144, 'MR', 'Mauritania'),
(145, 'YT', 'Mayotte'),
(146, 'MX', 'Mexico'),
(147, 'FM', 'Micronesia'),
(148, 'MD', 'Moldova'),
(149, 'MC', 'Monaco'),
(150, 'MN', 'Mongolia'),
(151, 'MS', 'Montserrat'),
(152, 'MZ', 'Mozambique'),
(153, 'MM', 'Myanmar'),
(154, 'NA', 'Namibia'),
(155, 'NR', 'Nauru'),
(156, 'NP', 'Nepal'),
(157, 'NI', 'Nicaragua'),
(158, 'NE', 'Niger'),
(159, 'NG', 'Nigeria'),
(160, 'NU', 'Niue'),
(161, 'NF', 'Norfolk Island'),
(162, 'NO', 'Norway'),
(163, 'NC', 'New Caledonia'),
(164, 'NZ', 'New Zealand'),
(165, 'OM', 'Oman'),
(166, 'NL', 'Netherlands'),
(167, 'PK', 'Pakistan'),
(168, 'PW', 'Palau'),
(169, 'PS', 'Palestine'),
(170, 'PA', 'Panama'),
(171, 'PG', 'Papua New Guinea'),
(172, 'PY', 'Paraguay'),
(173, 'PE', 'Peru'),
(174, 'PN', 'Pitcairn Islands'),
(175, 'PF', 'French Polynesia'),
(176, 'PL', 'Poland'),
(177, 'PT', 'Portugal'),
(178, 'PR', 'Puerto Rico'),
(179, 'QA', 'Qatar'),
(180, 'GB', 'United Kingdom'),
(181, 'RE', 'Reunion'),
(182, 'RW', 'Rwanda'),
(183, 'RO', 'Romania'),
(184, 'RU', 'Russian Federation'),
(185, 'EH', 'Western Sahara'),
(186, 'SB', 'Solomon Islands'),
(187, 'WS', 'Samoa'),
(188, 'AS', 'American Samoa'),
(189, 'KN', 'Saint Kitts and Nevis'),
(190, 'SM', 'San Marino'),
(191, 'PM', 'Saint Pierre and Miquelon'),
(192, 'VC', 'Saint Vincent and the Grenadines'),
(193, 'SH', 'Saint Helena'),
(194, 'LC', 'Saint Lucia'),
(195, 'ST', 'Sao Tome and Principe'),
(196, 'SN', 'Senegal'),
(197, 'CS', 'Serbia and Montenegro'),
(198, 'SC', 'Seychelles'),
(199, 'SL', 'Sierra Leone'),
(200, 'SG', 'Singapore'),
(201, 'SY', 'Syrian Arab Republic'),
(202, 'SO', 'Somalia'),
(203, 'LK', 'Sri Lanka'),
(204, 'SZ', 'Swaziland'),
(205, 'ZA', 'South Africa'),
(206, 'SD', 'Sudan'),
(207, 'SE', 'Sweden'),
(208, 'CH', 'Switzerland'),
(209, 'SR', 'Suriname'),
(210, 'SJ', 'Svalbard and Jan Mayen'),
(211, 'TH', 'Thailand'),
(212, 'TW', 'Taiwan'),
(213, 'TZ', 'Tanzania'),
(214, 'TJ', 'Tajikistan'),
(215, 'IO', 'British Indian Ocean Territory'),
(216, 'TF', 'French Southern and Antarctic Lands'),
(217, 'TL', 'East Timor'),
(218, 'TG', 'Togo'),
(219, 'TK', 'Tokelau'),
(220, 'TO', 'Tonga'),
(221, 'TT', 'Trinidad and Tobago'),
(222, 'TN', 'Tunisia'),
(223, 'TC', 'Turks and Caicos Islands'),
(224, 'TM', 'Turkmenistan'),
(225, 'TR', 'Turkey'),
(226, 'TV', 'Tuvalu'),
(227, 'UA', 'Ukraine'),
(228, 'UG', 'Uganda'),
(229, 'UY', 'Uruguay'),
(230, 'UZ', 'Uzbekistan'),
(231, 'VU', 'Vanuatu'),
(232, 'VE', 'Venezuela'),
(233, 'VN', 'Vietnam'),
(234, 'VG', 'British Virgin Islands'),
(235, 'VI', 'United States Virgin Islands'),
(236, 'WF', 'Wallis and Futuna'),
(237, 'YE', 'Yemen'),
(238, 'DJ', 'Yibuti'),
(239, 'ZM', 'Zambia'),
(240, 'ZW', 'Zimbabwe');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `VN_DISH`
--

CREATE TABLE `VN_DISH` (
  `id_dish` int(11) NOT NULL,
  `id_menu` int(11) DEFAULT NULL,
  `id_type_dish` int(11) DEFAULT NULL,
  `name` varchar(50) CHARACTER SET latin1 DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

--
-- Volcado de datos para la tabla `VN_DISH`
--

INSERT INTO `VN_DISH` (`id_dish`, `id_menu`, `id_type_dish`, `name`) VALUES
(1, 1, 1, 'Coffee with skim milk'),
(2, 1, 5, 'Coffee with skim milk'),
(3, 1, 1, 'Bread 25 g.'),
(4, 1, 5, 'Diet cookies'),
(5, 1, 1, 'Margarine'),
(6, 1, 1, 'Fruit 150 g.'),
(7, 1, 4, 'Fruit 150 g.'),
(8, 1, 5, 'Fruit 150 g.'),
(9, 1, 8, 'Fruit 150 g.'),
(10, 1, 2, 'Lentils'),
(11, 1, 3, 'Grilled chicken'),
(12, 1, 6, 'Star soup'),
(13, 1, 7, 'Cooked eggs with pisto'),
(14, 1, 8, 'Skimmed natural yogurt'),
(15, 1, 2, 'Leek soup'),
(16, 1, 3, 'Salmon'),
(17, 1, 4, 'Flan'),
(18, 1, 6, 'Vegetable cream'),
(19, 1, 7, 'Stew chicken with mushrooms'),
(20, 1, 2, 'Legume cream'),
(21, 1, 3, 'Roasted beef with mushrooms'),
(22, 1, 6, 'Vegetable soup'),
(23, 1, 7, 'Menier fish'),
(24, 1, 2, 'Potatos in green sauce'),
(25, 1, 3, 'Meat balls'),
(26, 1, 6, 'Pea cream'),
(27, 1, 7, 'Pork in its juice'),
(28, 1, 2, 'Beans'),
(29, 1, 3, 'Chicken thigh'),
(30, 1, 6, 'Fish soup'),
(31, 1, 7, 'Cooked eggs'),
(32, 1, 2, 'Stew of vegetables'),
(33, 1, 3, 'Fish in green sauce'),
(34, 1, 6, 'Minestrone soup'),
(35, 1, 7, 'Scorpion loins'),
(36, 1, 2, 'Green beans with potatos'),
(37, 1, 3, 'Rabbit cacciatore'),
(38, 1, 6, 'Cream of zucchini'),
(39, 1, 7, 'American hake'),
(40, 2, 1, 'Coffee with skimmed milk'),
(41, 2, 5, 'Coffee with skimmed milk'),
(42, 2, 1, 'Bread 50 g.'),
(43, 2, 5, 'Diet cookies'),
(44, 2, 1, 'Margarine'),
(45, 2, 1, 'Fruit 150 g.'),
(46, 2, 4, 'Fruit 150 g.'),
(47, 2, 5, 'Fruit 150 g.'),
(48, 2, 8, 'Fruit 150 g.'),
(49, 2, 2, 'Lentils'),
(50, 2, 3, 'Grilled chicken'),
(51, 2, 6, 'Cream of carrots'),
(52, 2, 7, 'Bacalao a la vizcaína'),
(53, 2, 8, 'Skimmed natural yogurt'),
(54, 2, 2, 'Mixed salad'),
(55, 2, 3, 'Beef stew'),
(56, 2, 4, 'Flan'),
(57, 2, 6, 'Vegetable cream'),
(58, 2, 7, 'Stew chicken with mushrooms'),
(59, 2, 2, 'Legume cream'),
(60, 2, 3, 'Roasted beef with mushrooms'),
(61, 2, 6, 'Vegetable soup'),
(62, 2, 7, 'Menier fish'),
(63, 2, 2, 'Potatos in green sauce'),
(64, 2, 3, 'Meatballs'),
(65, 2, 6, 'Pea cream'),
(66, 2, 7, 'Pork in its juice'),
(67, 2, 2, 'Beans'),
(68, 2, 3, 'Chicken thigh'),
(69, 2, 6, 'Fish soup'),
(70, 2, 7, 'Cooked eggs'),
(71, 2, 2, 'Vegetable stew'),
(72, 2, 3, 'Fish in green sauce'),
(73, 2, 6, 'Minestrone soup'),
(74, 2, 7, 'Scorpion loins'),
(75, 2, 2, 'Green beans with potatos'),
(76, 2, 3, 'Rabbit cacciatore'),
(77, 2, 6, 'Cream of zucchini'),
(78, 2, 7, 'American hake'),
(79, 3, 1, 'Coffee with skimmed milk'),
(80, 3, 5, 'Coffee with skimmed milk'),
(81, 3, 1, 'Bread 50 g.'),
(82, 3, 5, 'Sandwich'),
(83, 3, 1, 'Margarine'),
(84, 3, 1, 'Fruit 150 g.'),
(85, 3, 4, 'Fruit 150 g.'),
(86, 3, 5, 'Fruit 150 g.'),
(87, 3, 8, 'Fruit 150 g.'),
(88, 3, 2, 'Lentils'),
(89, 3, 3, 'Grilled chicken'),
(90, 3, 6, 'Cream of carrots'),
(91, 3, 7, 'Bacalao a la vizcaína'),
(92, 3, 8, 'Natural yogurt'),
(93, 3, 2, 'Rice with vegetables'),
(94, 3, 3, 'Beef stew'),
(95, 3, 4, 'Flan'),
(96, 3, 6, 'Vegetable cream'),
(97, 3, 7, 'Stew chicken with mushrooms'),
(98, 3, 2, 'Legume cream'),
(99, 3, 3, 'Roasted beef with mushrooms'),
(100, 3, 6, 'Vegetable soup'),
(101, 3, 7, 'Menier fish'),
(102, 3, 2, 'Potatos with green sauce'),
(103, 3, 3, 'Meatballs'),
(104, 3, 6, 'Pea cream'),
(105, 3, 7, 'Pork in its juice'),
(106, 3, 2, 'Beans'),
(107, 3, 3, 'Chicken thistle'),
(108, 3, 6, 'Fish soup'),
(109, 3, 7, 'Cooked eggs'),
(110, 3, 2, 'Vegetable stew'),
(111, 3, 3, 'Lamb in vegetable stew'),
(112, 3, 6, 'Minestrone soup'),
(113, 3, 7, 'Scorpion loins'),
(114, 3, 2, 'Green beans with potatos'),
(115, 3, 3, 'Rabbit cacciatore'),
(116, 3, 6, 'Cream of zucchini'),
(118, 3, 7, 'American hake');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `VN_FAMILY`
--

CREATE TABLE `VN_FAMILY` (
  `id_family` int(11) NOT NULL,
  `new_family` varchar(20) CHARACTER SET latin1 DEFAULT NULL,
  `removed_family` varchar(20) CHARACTER SET latin1 DEFAULT NULL,
  `type_family` varchar(4) CHARACTER SET latin1 DEFAULT NULL,
  `name_family` varchar(100) CHARACTER SET latin1 DEFAULT NULL,
  `password_family` varchar(20) CHARACTER SET latin1 DEFAULT NULL,
  `email_family` varchar(150) CHARACTER SET latin1 DEFAULT NULL,
  `notes_family` mediumtext CHARACTER SET latin1,
  `date_removed` varchar(20) CHARACTER SET latin1 DEFAULT NULL,
  `date_family_mod` varchar(20) CHARACTER SET latin1 DEFAULT NULL,
  `id_family_mod` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `VN_INGREDIENT`
--

CREATE TABLE `VN_INGREDIENT` (
  `id_dish` int(11) NOT NULL,
  `lactose` tinyint(1) DEFAULT NULL,
  `fruit` tinyint(1) DEFAULT NULL,
  `asparagus` tinyint(1) DEFAULT NULL,
  `spinach` tinyint(1) DEFAULT NULL,
  `chard` tinyint(1) DEFAULT NULL,
  `thistle` tinyint(1) DEFAULT NULL,
  `borage` tinyint(1) DEFAULT NULL,
  `lettuce` tinyint(1) DEFAULT NULL,
  `pickle` tinyint(1) DEFAULT NULL,
  `tomato` tinyint(1) DEFAULT NULL,
  `pepper` tinyint(1) DEFAULT NULL,
  `eggplant` tinyint(1) DEFAULT NULL,
  `zucchini` tinyint(1) DEFAULT NULL,
  `artichoke` tinyint(1) DEFAULT NULL,
  `leek` tinyint(1) DEFAULT NULL,
  `garlic` tinyint(1) DEFAULT NULL,
  `onion` tinyint(1) DEFAULT NULL,
  `turnip` tinyint(1) DEFAULT NULL,
  `potato` tinyint(1) DEFAULT NULL,
  `radishes` tinyint(1) DEFAULT NULL,
  `beet` tinyint(1) DEFAULT NULL,
  `carrot` tinyint(1) DEFAULT NULL,
  `greenbeans` tinyint(1) DEFAULT NULL,
  `peas` tinyint(1) DEFAULT NULL,
  `lentils` tinyint(1) DEFAULT NULL,
  `beans` tinyint(1) DEFAULT NULL,
  `cabbage` tinyint(1) DEFAULT NULL,
  `brecol` tinyint(1) DEFAULT NULL,
  `brusselssprouts` tinyint(1) DEFAULT NULL,
  `cauliflower` tinyint(1) DEFAULT NULL,
  `buttonmushroom` tinyint(1) DEFAULT NULL,
  `mushrooms` tinyint(1) DEFAULT NULL,
  `eggs` tinyint(1) DEFAULT NULL,
  `bread` tinyint(1) DEFAULT NULL,
  `rice` tinyint(1) DEFAULT NULL,
  `pasta` tinyint(1) DEFAULT NULL,
  `fish` tinyint(1) DEFAULT NULL,
  `meat` tinyint(1) DEFAULT NULL,
  `chicken` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

--
-- Volcado de datos para la tabla `VN_INGREDIENT`
--

INSERT INTO `VN_INGREDIENT` (`id_dish`, `lactose`, `fruit`, `asparagus`, `spinach`, `chard`, `thistle`, `borage`, `lettuce`, `pickle`, `tomato`, `pepper`, `eggplant`, `zucchini`, `artichoke`, `leek`, `garlic`, `onion`, `turnip`, `potato`, `radishes`, `beet`, `carrot`, `greenbeans`, `peas`, `lentils`, `beans`, `cabbage`, `brecol`, `brusselssprouts`, `cauliflower`, `buttonmushroom`, `mushrooms`, `eggs`, `bread`, `rice`, `pasta`, `fish`, `meat`, `chicken`) VALUES
(1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(2, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0),
(4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0),
(5, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(6, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(7, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(8, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(9, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(11, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1),
(12, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0),
(13, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 1, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0),
(14, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(15, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(16, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0),
(17, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0),
(18, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 1, 1, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(19, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1),
(20, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(21, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0),
(22, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 1, 1, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(23, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0),
(24, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(25, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0),
(26, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(27, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0),
(28, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(29, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1),
(30, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0),
(31, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0),
(32, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(33, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0),
(34, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(35, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0),
(36, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(37, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0),
(38, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(39, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0),
(40, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(41, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(42, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0),
(43, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0),
(44, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(45, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(46, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(47, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(48, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(49, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(50, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1),
(51, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(52, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0),
(53, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(54, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(55, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0),
(56, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0),
(57, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 1, 1, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(58, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1),
(59, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(60, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0),
(61, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 1, 1, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(62, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0),
(63, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(64, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0),
(65, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(66, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0),
(67, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(68, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1),
(69, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0),
(70, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0),
(71, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(72, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0),
(73, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(74, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0),
(75, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(76, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0),
(77, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(78, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0),
(79, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(80, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(81, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0),
(82, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0),
(83, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(84, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(85, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(86, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(87, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(88, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(89, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1),
(90, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(91, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0),
(92, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(93, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0),
(94, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0),
(95, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0),
(96, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 1, 1, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(97, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1),
(98, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(99, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0),
(100, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 1, 1, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(101, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0),
(102, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(103, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0),
(104, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(105, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0),
(106, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1),
(108, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0),
(109, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0),
(110, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(111, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0),
(112, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(113, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0),
(114, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(115, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0),
(116, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(117, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `VN_LOG`
--

CREATE TABLE `VN_LOG` (
  `id_log` int(11) NOT NULL,
  `login` varchar(20) CHARACTER SET latin1 DEFAULT NULL,
  `op` varchar(100) CHARACTER SET latin1 DEFAULT NULL,
  `dated` varchar(40) CHARACTER SET latin1 DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `VN_MENU`
--

CREATE TABLE `VN_MENU` (
  `id_menu` int(11) NOT NULL,
  `calories` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

--
-- Volcado de datos para la tabla `VN_MENU`
--

INSERT INTO `VN_MENU` (`id_menu`, `calories`) VALUES
(1, 1800),
(2, 2200),
(3, 3000);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `VN_MODELLING`
--

CREATE TABLE `VN_MODELLING` (
  `id_modelling` int(11) NOT NULL,
  `id_user` int(11) NOT NULL,
  `sex` tinyint(1) NOT NULL,
  `id_age` int(11) DEFAULT NULL,
  `height` varchar(20) CHARACTER SET latin1 DEFAULT NULL,
  `weight` varchar(20) CHARACTER SET latin1 DEFAULT NULL,
  `num_meals` int(11) DEFAULT NULL,
  `religion` varchar(20) CHARACTER SET latin1 DEFAULT NULL,
  `id_country` int(11) DEFAULT NULL,
  `diabetes` tinyint(1) DEFAULT NULL,
  `cholesterol` tinyint(1) DEFAULT NULL,
  `hepatic` tinyint(1) DEFAULT NULL,
  `renal` tinyint(1) DEFAULT NULL,
  `pancreas` tinyint(1) DEFAULT NULL,
  `bile` tinyint(1) DEFAULT NULL,
  `ulcer` tinyint(1) DEFAULT NULL,
  `colitis` tinyint(1) DEFAULT NULL,
  `colon` tinyint(1) DEFAULT NULL,
  `intestine` tinyint(1) DEFAULT NULL,
  `num_fruit` int(11) DEFAULT NULL,
  `banana` tinyint(1) DEFAULT NULL,
  `cherry` tinyint(1) DEFAULT NULL,
  `plum` tinyint(1) DEFAULT NULL,
  `guava` tinyint(1) DEFAULT NULL,
  `soursop` tinyint(1) DEFAULT NULL,
  `fig` tinyint(1) DEFAULT NULL,
  `pear` tinyint(1) DEFAULT NULL,
  `apricot` tinyint(1) DEFAULT NULL,
  `lemon` tinyint(1) DEFAULT NULL,
  `orange` tinyint(1) DEFAULT NULL,
  `pineapple` tinyint(1) DEFAULT NULL,
  `tamarind` tinyint(1) DEFAULT NULL,
  `grapefruit` tinyint(1) DEFAULT NULL,
  `grape` tinyint(1) DEFAULT NULL,
  `apple` tinyint(1) DEFAULT NULL,
  `peach` tinyint(1) DEFAULT NULL,
  `strawberry` tinyint(1) DEFAULT NULL,
  `tangerine` tinyint(1) DEFAULT NULL,
  `lime` tinyint(1) DEFAULT NULL,
  `avocado` tinyint(1) DEFAULT NULL,
  `olive` tinyint(1) DEFAULT NULL,
  `hazelnut` tinyint(1) DEFAULT NULL,
  `coconut` tinyint(1) DEFAULT NULL,
  `nut` tinyint(1) DEFAULT NULL,
  `cocoa` tinyint(1) DEFAULT NULL,
  `smallpeach` tinyint(1) DEFAULT NULL,
  `lactose` tinyint(1) DEFAULT NULL,
  `num_lactose` int(11) DEFAULT NULL,
  `num_green` int(11) DEFAULT NULL,
  `asparagus` tinyint(1) DEFAULT NULL,
  `spinach` tinyint(1) DEFAULT NULL,
  `chard` tinyint(1) DEFAULT NULL,
  `thistle` tinyint(1) DEFAULT NULL,
  `borage` tinyint(1) DEFAULT NULL,
  `lettuce` tinyint(1) DEFAULT NULL,
  `pickle` tinyint(1) DEFAULT NULL,
  `tomato` tinyint(1) DEFAULT NULL,
  `pepper` tinyint(1) DEFAULT NULL,
  `eggplant` tinyint(1) DEFAULT NULL,
  `zucchini` tinyint(1) DEFAULT NULL,
  `artichoke` tinyint(1) DEFAULT NULL,
  `leek` tinyint(1) DEFAULT NULL,
  `garlic` tinyint(1) DEFAULT NULL,
  `onion` tinyint(1) DEFAULT NULL,
  `turnip` tinyint(1) DEFAULT NULL,
  `potato` tinyint(1) DEFAULT NULL,
  `radishes` tinyint(1) DEFAULT NULL,
  `beet` tinyint(1) DEFAULT NULL,
  `carrot` tinyint(1) DEFAULT NULL,
  `greenbeans` tinyint(1) DEFAULT NULL,
  `peas` tinyint(1) DEFAULT NULL,
  `lentils` tinyint(1) DEFAULT NULL,
  `beans` tinyint(1) DEFAULT NULL,
  `cabbage` tinyint(1) DEFAULT NULL,
  `brecol` tinyint(1) DEFAULT NULL,
  `brusselssprouts` tinyint(1) DEFAULT NULL,
  `cauliflower` tinyint(1) DEFAULT NULL,
  `buttonmushroom` tinyint(1) DEFAULT NULL,
  `mushrooms` tinyint(1) DEFAULT NULL,
  `eggs` tinyint(1) DEFAULT NULL,
  `bread` tinyint(1) DEFAULT NULL,
  `rice` tinyint(1) DEFAULT NULL,
  `pasta` tinyint(1) DEFAULT NULL,
  `type_eater` tinyint(1) DEFAULT NULL,
  `fish` tinyint(1) DEFAULT NULL,
  `meat` tinyint(1) DEFAULT NULL,
  `chicken` tinyint(1) DEFAULT NULL,
  `style` int(11) DEFAULT NULL,
  `budget` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `VN_TYPE_DISH`
--

CREATE TABLE `VN_TYPE_DISH` (
  `id_type_dish` int(11) NOT NULL,
  `name` varchar(50) CHARACTER SET latin1 DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

--
-- Volcado de datos para la tabla `VN_TYPE_DISH`
--

INSERT INTO `VN_TYPE_DISH` (`id_type_dish`, `name`) VALUES
(1, 'Breakfast'),
(2, 'Lunch (1st. dish)'),
(3, 'Lunch (2nd. dish)'),
(4, 'Lunch (dessert)'),
(5, 'Snack'),
(6, 'Dinner (1st. dish)'),
(7, 'Dinner (2nd. dish)'),
(8, 'Dinner (dessert)');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `VN_USER`
--

CREATE TABLE `VN_USER` (
  `id_user` int(11) NOT NULL,
  `new_user` varchar(20) CHARACTER SET latin1 DEFAULT NULL,
  `removed_user` varchar(20) CHARACTER SET latin1 DEFAULT NULL,
  `type_user` varchar(4) CHARACTER SET latin1 DEFAULT NULL,
  `name_user` varchar(100) CHARACTER SET latin1 DEFAULT NULL,
  `surnames_user` varchar(100) CHARACTER SET latin1 DEFAULT NULL,
  `email_user` varchar(150) CHARACTER SET latin1 DEFAULT NULL,
  `login` varchar(20) CHARACTER SET latin1 DEFAULT NULL,
  `password` varchar(20) CHARACTER SET latin1 DEFAULT NULL,
  `notes_user` mediumtext CHARACTER SET latin1,
  `date_removed` varchar(20) CHARACTER SET latin1 DEFAULT NULL,
  `date_user_mod` varchar(20) CHARACTER SET latin1 DEFAULT NULL,
  `id_user_mod` int(11) DEFAULT NULL,
  `id_family` varchar(20) CHARACTER SET latin1 DEFAULT NULL,
  `area` varchar(20) CHARACTER SET latin1 DEFAULT NULL,
  `vn_access` varchar(20) CHARACTER SET latin1 DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `VN_AGES`
--
ALTER TABLE `VN_AGES`
  ADD PRIMARY KEY (`id_age`);

--
-- Indices de la tabla `VN_COUNTRIES`
--
ALTER TABLE `VN_COUNTRIES`
  ADD PRIMARY KEY (`id_country`);

--
-- Indices de la tabla `VN_DISH`
--
ALTER TABLE `VN_DISH`
  ADD PRIMARY KEY (`id_dish`);

--
-- Indices de la tabla `VN_FAMILY`
--
ALTER TABLE `VN_FAMILY`
  ADD PRIMARY KEY (`id_family`);

--
-- Indices de la tabla `VN_INGREDIENT`
--
ALTER TABLE `VN_INGREDIENT`
  ADD PRIMARY KEY (`id_dish`);

--
-- Indices de la tabla `VN_LOG`
--
ALTER TABLE `VN_LOG`
  ADD PRIMARY KEY (`id_log`);

--
-- Indices de la tabla `VN_MENU`
--
ALTER TABLE `VN_MENU`
  ADD PRIMARY KEY (`id_menu`);

--
-- Indices de la tabla `VN_MODELLING`
--
ALTER TABLE `VN_MODELLING`
  ADD PRIMARY KEY (`id_modelling`);

--
-- Indices de la tabla `VN_TYPE_DISH`
--
ALTER TABLE `VN_TYPE_DISH`
  ADD PRIMARY KEY (`id_type_dish`);

--
-- Indices de la tabla `VN_USER`
--
ALTER TABLE `VN_USER`
  ADD PRIMARY KEY (`id_user`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `VN_AGES`
--
ALTER TABLE `VN_AGES`
  MODIFY `id_age` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `VN_COUNTRIES`
--
ALTER TABLE `VN_COUNTRIES`
  MODIFY `id_country` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=241;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
