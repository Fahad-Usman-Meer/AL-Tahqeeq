using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AL_Tahqeeq
{
    public enum enmLanguage
    {
        URDU = 0,
        ROMAN_URDU = 1

    };

    

    /// <summary>
    /// each item is actually file name of specific masla.
    /// </summary>
    public enum enmMaslaKeys
    {
        M_001_imam_ul_ambia = 1,
        M_005_hayat_un_nabi = 5,
        M_006_A_ilm_ul_ghaib = 6,
        M_007_hazir_o_nazir = 7,
        M_008_kalma_go_mushrik = 8,
        M_015_teen_talaaq = 15,
        M_021_bivion_k_haqooq = 21,
        M_070_B_rafa_ul_yadain = 70,
        M_084_fatiha_khalf_ul_imam = 84,
        M_148_sabhi_muslim = 148,
    }

    public static class Common
    {
        public static readonly string SITE_NAME = "AL-TAHQEEQ";
        public static readonly string Bismillah_Kalmaat =

     "۔ بِسمِ اللہِ الرّحمٰنِ الرّحیم ، و الصّلوة والسّلام علیٰ رسولِ اللہ و علیٰ ازوَجہِ و الہِ و اصحابہِ اجمعین ، الیٰ یومِ الدّین۔";


        /// <summary>
        /// Key will be the name of "File" and Value will be "Text to Show"
        /// </summary>
        public static readonly Dictionary<string, string> List_of_English_Maslas = new Dictionary<string, string>()
        {
            {enmMaslaKeys.M_001_imam_ul_ambia.ToString(), "001-Imam ul Ambia (S.A.W) ki Dawat-e-Quran"},

            {enmMaslaKeys.M_005_hayat_un_nabi.ToString(), "005-Mas'alah HAYAAT-un-NABI (S.A.W) say Motalliq Firqawaraana NAZRIYAAT ka TAHQEEQI jaizah"},
            
            {enmMaslaKeys.M_006_A_ilm_ul_ghaib.ToString(), "006-A: Mas'alah ILM-ul-Ghaib sy Mutalliq Firqawaraana Nazriyaat ka Tahqeeqi Jaizah"},

            {enmMaslaKeys.M_007_hazir_o_nazir.ToString(), "007-Mas'alah HAZIR-O-NAZIR say Motalliq Firqawaraana NAZRIYAAT ka TAHQEEQI jaizah (3 - ILMI Points)"},

            {enmMaslaKeys.M_008_kalma_go_mushrik.ToString(), "008-Mas'alah Kia Ummat e Muhammadi (S.A.W) Ka Musalman Shirk ker Sakta Hay???"},

            {enmMaslaKeys.M_015_teen_talaaq.ToString(), "015-Mas'alah Teen Talaaq, Halaala aur Haraama say Motalliq Firqawaraana NAZRIYAAT ka TAHQEEQI jaizah"},

            {enmMaslaKeys.M_021_bivion_k_haqooq.ToString(), "021-Mas'alah Bevion kay Islami Haqooq ka Bayan"},

            {enmMaslaKeys.M_070_B_rafa_ul_yadain.ToString(), "070-B: Mas'alah RAFA-ul-Yadain sy Mutalliq Firqawaraana Nazriyaat ka Tahqeeqi Jaizah"},

            {enmMaslaKeys.M_084_fatiha_khalf_ul_imam.ToString(), "084-New Mas'alah Fatiha Khalf-ul-Imam sy Mutalliq Firqawaraana Nazriyaat ka Tahqeeqi Jaizah"},

            {enmMaslaKeys.M_148_sabhi_muslim.ToString(), "148-Mas'alah Brailvi, Deobandi, Ahl-e-Hadith, Ahl-e-Tashayyo Sabhi MUSLIM hein KAFIR Nahin hain"}
 
        };

        /// <summary>
        /// Key will be the name of "File" and Value will be "Text to Show"
        /// </summary>
        public static readonly Dictionary<string, string> List_of_Urdu_Maslas = new Dictionary<string, string>()
        {
            {enmMaslaKeys.M_001_imam_ul_ambia.ToString()," مسئلہ امامُ الانبیاء ﷺ کی دعوتِ قُرآن"},

            {enmMaslaKeys.M_005_hayat_un_nabi.ToString()," مسئلہ حیاتُ النبی ﷺ سے متعلق فِرقہ وارانہ نظریات کا تَحقیقی جائزہ "},

            {enmMaslaKeys.M_006_A_ilm_ul_ghaib.ToString(), "مسئلہ عِلمُ الغَیب سے متعلق فِرقہ وارانہ نظریات کا تَحقیقی جائزہ"},

            {enmMaslaKeys.M_007_hazir_o_nazir.ToString(), "مسئلہ حاضِر و ناظر سے متعلق فِرقہ وارانہ نظریات کا تَحقیقی جائزہ"},

            {enmMaslaKeys.M_008_kalma_go_mushrik.ToString(), "مسئلہ کیا امتِ مُحمّدی ﷺ کا مسُلمان شِرک کر سکتا ہے؟؟؟"},

            {enmMaslaKeys.M_015_teen_talaaq.ToString(), "مسئلہ تین طلاق ، حلالہ اور حرامہ سے متعلق فِرقہ وارانہ نظریات کا تَحقیقی جائزہ"},

            {enmMaslaKeys.M_021_bivion_k_haqooq.ToString(), "مسئلہ بیویوں کے اِسلامی حُقوق کا بیان"},

            {enmMaslaKeys.M_070_B_rafa_ul_yadain.ToString(), "مسئلہ رَفعُ الیَدین سے متعلق فِرقہ وارانہ نظریات کا تَحقیقی جائزہ"},

            {enmMaslaKeys.M_084_fatiha_khalf_ul_imam.ToString(), "مسئلہ فاتحہ خلفُ الامام سے متعلق فِرقہ وارانہ نظریات کا تَحقیقی جائزہ"},

            {enmMaslaKeys.M_148_sabhi_muslim.ToString(), " مسئلہ بریلوی، دیو بندی، اہلِ حدیث، اہلِ تشیّع سبھی مسُلم ہیں! کافر نہیں ہیں !۔ "}

        };


        /// <summary>
        /// Key will be the name of "File" and Value will be "Title Icons Path"
        /// </summary>
        public static readonly Dictionary<string, string> List_of_Thumbnails_Path = new Dictionary<string, string>()
        {
            {enmMaslaKeys.M_001_imam_ul_ambia.ToString(), "/images/Thumbnails/M_001_imam_ul_ambia_icon.jpg"},

            {enmMaslaKeys.M_005_hayat_un_nabi.ToString(), "/images/Thumbnails/M_005_hayat_un_nabi_icon.jpg"},
            
            {enmMaslaKeys.M_006_A_ilm_ul_ghaib.ToString(), "/images/Thumbnails/M_006_A_ilm_ul_ghaib_icon.jpg"},

            {enmMaslaKeys.M_007_hazir_o_nazir.ToString(), "/images/Thumbnails/M_007_hazir_o_nazir_icon.jpg"},

            {enmMaslaKeys.M_008_kalma_go_mushrik.ToString(), "/images/Thumbnails/M_008_kalma_go_mushrik_icon.jpg" },

            {enmMaslaKeys.M_015_teen_talaaq.ToString(), "/images/Thumbnails/M_015_teen_talaaq_icon.jpg"},

            {enmMaslaKeys.M_021_bivion_k_haqooq.ToString(), "/images/Thumbnails/M_021_bivion_k_haqooq_icon.jpg"},

            {enmMaslaKeys.M_070_B_rafa_ul_yadain.ToString(), "/images/Thumbnails/M_070_B_rafa_ul_yadain_icon.jpg"},

            {enmMaslaKeys.M_084_fatiha_khalf_ul_imam.ToString(), "/images/Thumbnails/M_084_fatiha_khalf_ul_imam_icon.jpg"},

            {enmMaslaKeys.M_148_sabhi_muslim.ToString(), "/images/Thumbnails/M_148_sabhi_muslim_icon.jpg"},
            
            {"error", "/images/Thumbnails/Error_icon.png"}

        };
    }

    public static class CommonSentences
    {
        private static string SentencesFolderPath = "Sentences/";


        #region Common Sentences

        public static readonly string naa_main_wahabi_naa_mein_baabbi = string.Format("{0}naa_main_wahabi_naa_mein_baabbi", SentencesFolderPath);

        public static readonly string inna_lillahi_wa_inna_ilaihi_raajeuun = string.Format("{0}inna_lillahi_wa_inna_ilaihi_raajeuun", SentencesFolderPath);

        #endregion
    }

    public static class CommonStrings
    {

         //    صحیح بُخاری    
               
         //       صحیح مسُلم
              
         //       جامع تِرمذی
               
         //       سُنن ابو داؤد
             
         //       سُنن نَسائی
              
         //       سُنن ابنِ ماجہ
               
         //       سِلسِلہ الصحیحہ
                
         //       مُسند أحمد

        //       مِشکوٰۃ المصابیح
                

    }

}