/*
SQLyog Enterprise - MySQL GUI v7.12 
MySQL - 5.5.5-10.1.34-MariaDB : Database - altahqeeq
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

CREATE DATABASE /*!32312 IF NOT EXISTS*/`altahqeeq` /*!40100 DEFAULT CHARACTER SET utf32 */;

USE `altahqeeq`;

/*Table structure for table `mas_alah` */

DROP TABLE IF EXISTS `mas_alah`;

CREATE TABLE `mas_alah` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `masla_no` varchar(30) DEFAULT NULL COMMENT 'masla # of specific topic i.e., Mas''alah 001 , Mas''alah 006-B etc.',
  `file_path` varchar(250) DEFAULT NULL COMMENT 'file, that contains cshtml code of specific Mas''alah.',
  `english_name` varchar(200) DEFAULT NULL COMMENT 'Text to Show in Roman English.',
  `urdu_name` varchar(200) CHARACTER SET utf8 DEFAULT NULL COMMENT 'Text to Show in Urdu.',
  `thumbnail_path` varchar(250) DEFAULT NULL COMMENT 'thumbnail path of specific Mas''alah.',
  PRIMARY KEY (`id`),
  KEY `masla_no` (`masla_no`,`english_name`,`urdu_name`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

/*Data for the table `mas_alah` */

insert  into `mas_alah`(`id`,`masla_no`,`file_path`,`english_name`,`urdu_name`,`thumbnail_path`) values (1,'001','~/Masla/001_Mas_alah_IMAM_ul_Ambia_S_A_W_ki_Dawat_e_Quran','001-Mas\'alah Imam ul Ambia (S.A.W) ki Dawat-e-Quran','مسئلہ امامُ الانبیاء ﷺ کی دعوتِ قُرآن','/images/Thumbnails/001_imam_ul_ambia_s_a_w_ki_dawat_e_quran_icon.jpg'),(2,'005','~/Masla/005_Mas_alah_HAYAAT_un_NABI_S_A_W_say_Motalliq_Firqawaraana_Nazriyaat_ka_Tahqeeqi_jaizah','005-Mas\'alah HAYAAT-un-NABI (S.A.W) say Motalliq Firqawaraana NAZRIYAAT ka TAHQEEQI jaizah','مسئلہ حیاتُ النبی ﷺ سے متعلق فِرقہ وارانہ نظریات کا تَحقیقی جائزہ ','/images/Thumbnails/005_Mas_alah_HAYAAT_un_NABI_S_A_W_say_Motalliq_Firqawaraana_NAZRIYAAT_ka_TAHQEEQI_jaizah_icon.jpg'),(3,'006-A','~/Masla/006_A_Mas_alah_ILM_ul_Ghaib_sy_Mutalliq_Firqawaraana_Nazriyaat_ka_Tahqeeqi_Jaizah','006-A: Mas\'alah ILM-ul-Ghaib sy Mutalliq Firqawaraana Nazriyaat ka Tahqeeqi Jaizah','مسئلہ عِلمُ الغَیب سے متعلق فِرقہ وارانہ نظریات کا تَحقیقی جائزہ','/images/Thumbnails/006_A_Mas_alah_ILM_ul_Ghaib_sy_Mutalliq_Firqawaraana_Nazriyaat_ka_Tahqeeqi_Jaizah_icon.jpg'),(4,'007','~/Masla/007_Mas_alah_HAZIR_O_NAZIR_say_Motalliq_Firqawaraana_Nazriyaat_ka_Tahqeeqi_Jaizah_3_ILMI_Points','007-Mas\'alah HAZIR-O-NAZIR say Motalliq Firqawaraana NAZRIYAAT ka TAHQEEQI jaizah (3 - ILMI Points)','مسئلہ حاضِر و ناظر سے متعلق فِرقہ وارانہ نظریات کا تَحقیقی جائزہ','/images/Thumbnails/007_Mas_alah_HAZIR_O_NAZIR_say_Motalliq_Firqawaraana_Nazriyaat_ka_Tahqeeqi_Jaizah_3_ILMI_Points_icon.jpg'),(5,'008','~/Masla/008_Mas_alah_Kia_Ummat_e_Muhammadi_S_A_W_Ka_Musalman_Shirk_ker_Sakta_Hay','008-Mas\'alah Kia Ummat e Muhammadi (S.A.W) Ka Musalman Shirk ker Sakta Hay???','مسئلہ کیا امتِ مُحمّدی ﷺ کا مسُلمان شِرک کر سکتا ہے؟؟؟','/images/Thumbnails/008_Mas_alah_Kia_Ummat_e_Muhammadi_S_A_W_Ka_Musalman_Shirk_ker_Sakta_Hay_icon.jpg'),(6,'015','~/Masla/015_Mas_alah_Teen_Talaaq_Halaala_aur_Haraama_say_Motalliq_Firqawaraana_Nazriyaat_ka_Tahqeeqi_jaizah','015-Mas\'alah Teen Talaaq, Halaala aur Haraama say Motalliq Firqawaraana NAZRIYAAT ka TAHQEEQI jaizah','مسئلہ تین طلاق ، حلالہ اور حرامہ سے متعلق فِرقہ وارانہ نظریات کا تَحقیقی جائزہ','/images/Thumbnails/015_Mas_alah_Teen_Talaaq_Halaala_aur_Haraama_say_Motalliq_Firqawaraana_Nazriyaat_ka_Tahqeeqi_jaizah_icon.jpg'),(7,'021','~/Masla/021_Mas_alah_Bevion_kay_Islami_Haqooq_ka_Bayan','021-Mas\'alah Bevion kay Islami Haqooq ka Bayan','مسئلہ بیویوں کے اِسلامی حُقوق کا بیان','/images/Thumbnails/021_Mas_alah_Bevion_kay_Islami_Haqooq_ka_Bayan_icon.jpg'),(8,'070-B','~/Masla/070_B_Mas_alah_RAFA_ul_Yadain_sy_Mutalliq_Firqawaraana_Nazriyaat_ka_Tahqeeqi_Jaizah','070-B: Mas\'alah RAFA-ul-Yadain sy Mutalliq Firqawaraana Nazriyaat ka Tahqeeqi Jaizah','مسئلہ رَفعُ الیَدین سے متعلق فِرقہ وارانہ نظریات کا تَحقیقی جائزہ','/images/Thumbnails/070_B_Mas_alah_RAFA_ul_Yadain_sy_Mutalliq_Firqawaraana_Nazriyaat_ka_Tahqeeqi_Jaizah_icon.jpg'),(9,'084-New','~/Masla/084_New_Mas_alah_Fatiha_Khalf_ul_Imam_sy_Mutalliq_Firqawaraana_Nazriyaat_ka_Tahqeeqi_Jaizah','084-New Mas\'alah Fatiha Khalf-ul-Imam sy Mutalliq Firqawaraana Nazriyaat ka Tahqeeqi Jaizah','مسئلہ فاتحہ خلفُ الامام سے متعلق فِرقہ وارانہ نظریات کا تَحقیقی جائزہ','/images/Thumbnails/084_New_Mas_alah_Fatiha_Khalf_ul_Imam_sy_Mutalliq_Firqawaraana_Nazriyaat_ka_Tahqeeqi_Jaizah_icon.jpg'),(10,'148','~/Masla/148_Mas_alah_Brailvi_Deobandi_Ahl_e_Hadith_Ahl_e_Tashayyo_Sabhi_MUSLIM_hein_KAFIR_Nahin_hain','148-Mas\'alah Brailvi, Deobandi, Ahl-e-Hadith, Ahl-e-Tashayyo Sabhi MUSLIM hein KAFIR Nahin hain','مسئلہ بریلوی، دیو بندی، اہلِ حدیث، اہلِ تشیّع سبھی مسُلم ہیں! کافر نہیں ہیں !۔','/images/Thumbnails/148_Mas_alah_Brailvi_Deobandi_Ahl_e_Hadith_Ahl_e_Tashayyo_Sabhi_MUSLIM_hein_KAFIR_Nahin_hain_icon.jpg');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
