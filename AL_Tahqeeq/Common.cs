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

            {enmMaslaKeys.M_007_hazir_o_nazir.ToString(), "007-Mas'alah HAZIR-o-NAZIR say Motalliq Firqawaraana NAZRIYAAT ka TAHQEEQI jaizah (3- ILMI Points)"},

            {enmMaslaKeys.M_008_kalma_go_mushrik.ToString(), "008-Mas'alah Kia Ummat e Muhammadi (S.A.W) Ka Musalman Shirk ker Sakta Hay???"},

            {enmMaslaKeys.M_015_teen_talaaq.ToString(), "015-Mas'alah Teen Talaaq, Halaala aur Haraama"},

            {enmMaslaKeys.M_021_bivion_k_haqooq.ToString(), "021-Mas'alah Bevion kay Islami Haqooq ka Bayan"},

            {enmMaslaKeys.M_148_sabhi_muslim.ToString(), "148-Mas'alah Brailvi, Deobandi, Ahl-e-Hadith, Ahl-e-Tashayyo Sabhi MUSLIM hein KAFIR Nahin hain"}
 
        };

        /// <summary>
        /// Key will be the name of "File" and Value will be "Text to Show"
        /// </summary>
        public static readonly Dictionary<string, string> List_of_Urdu_Maslas = new Dictionary<string, string>()
        {
            {enmMaslaKeys.M_001_imam_ul_ambia.ToString()," مسئلہ امامُ الانبیاء ﷺ کی دعوتِ قُرآن"},

            {enmMaslaKeys.M_005_hayat_un_nabi.ToString()," مسئلہ حیاتُ النبی ﷺ سے متعلق فِرقہ وارانہ نظریات کا تَحقیقی جائزہ "},

            {enmMaslaKeys.M_006_A_ilm_ul_ghaib.ToString(), "مسئلہ عِلُم الغَیب سے متعلق فِرقہ وارانہ نظریات کا تَحقیقی جائزہ"},

            {enmMaslaKeys.M_007_hazir_o_nazir.ToString(), "مسئلہ حاضِر و ناظر سے متعلق فِرقہ وارانہ نظریات کا تَحقیقی جائزہ"},

            {enmMaslaKeys.M_008_kalma_go_mushrik.ToString(), "مسئلہ کیا امتِ مُحمدی ﷺ کا مسُلمان شرِک کر سکتا ہے؟؟؟"},

            {enmMaslaKeys.M_015_teen_talaaq.ToString(), "مسئلہ تین طلاق ، حلالہ اور حرامہ"},

            {enmMaslaKeys.M_021_bivion_k_haqooq.ToString(), "مسئلہ بیویوں کے اِسلامی حُقوق کا بیان"},

            {enmMaslaKeys.M_148_sabhi_muslim.ToString(), " مسئلہ بریلوی، دیو بندی، اہلِ حدیث، اہلِ تشیّع سبھی مسُلم ہیں! کافر نہیں ہیں !۔ "}

        };


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