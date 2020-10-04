-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 04, 2020 at 03:32 PM
-- Server version: 10.1.25-MariaDB
-- PHP Version: 7.1.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pemudik`
--

-- --------------------------------------------------------

--
-- Table structure for table `warga`
--

CREATE TABLE `warga` (
  `nik` varchar(16) NOT NULL,
  `nama` varchar(64) NOT NULL,
  `jenis_kelamin` char(9) NOT NULL,
  `pekerjaan` varchar(24) NOT NULL,
  `kota_rantauan` varchar(16) NOT NULL,
  `tanggal_kedatangan` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `warga`
--

INSERT INTO `warga` (`nik`, `nama`, `jenis_kelamin`, `pekerjaan`, `kota_rantauan`, `tanggal_kedatangan`) VALUES
('3307022809980004', 'Rizka Meilani', 'Perempuan', 'Model', 'Solo', '2020-04-25'),
('3307090100010002', 'Firman Adi', 'Laki-Laki', 'Mahasantuy', 'Kudus', '2020-04-09'),
('3307090100010003', 'Fajar Haryanto', 'Laki-Laki', 'Santri', 'Semarang', '2020-04-06'),
('3307090100010004', 'Faiz Rizal', 'Laki-Laki', 'PNS', 'Jakarta Utara', '2020-04-10'),
('3307091406990002', 'Annisa Maharani', 'Perempuan', 'Mahasiswa', 'Magelang', '2020-04-27'),
('3307092105010002', 'Siti Jumitri', 'Perempuan', 'Pegawai Swasta', 'Bandung', '2020-04-29'),
('3307111504000004', 'Ahmad Santoso', 'Laki-Laki', 'Taruna', 'Bantul', '2020-05-06');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `warga`
--
ALTER TABLE `warga`
  ADD PRIMARY KEY (`nik`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
