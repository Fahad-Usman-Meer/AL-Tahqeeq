using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AL_Tahqeeq
{
    public static class CommonLinks
    {
        private static string ControllerName = "Masla";
        public static string QuestionMarks = "?_?_?_";

        private static string DawatEQuran = enmMaslaKeys.M_001_imam_ul_ambia.ToString();
        private static string HayatUnNabi = enmMaslaKeys.M_005_hayat_un_nabi.ToString();
        private static string IlmUlGhaib = enmMaslaKeys.M_006_A_ilm_ul_ghaib.ToString();
        private static string HazirONazir = enmMaslaKeys.M_007_hazir_o_nazir.ToString();
        private static string KalmaGoMushrik = enmMaslaKeys.M_008_kalma_go_mushrik.ToString();
        private static string TeenTalaaq = enmMaslaKeys.M_015_teen_talaaq.ToString();
        private static string BevionKayHaqooq = enmMaslaKeys.M_021_bivion_k_haqooq.ToString();
        private static string FatihaKhalfUlImam = enmMaslaKeys.M_084_fatiha_khalf_ul_imam.ToString();
        private static string SabhiMuslim = enmMaslaKeys.M_148_sabhi_muslim.ToString();


        // ****************************************************************
        // *** To See Original Content, Follow the Partials Accordingly   *
        // ***                                                            *
        // ***  ~/Views/Shared/ShortClips                                 *
        // ****************************************************************

        #region 001 Dawat e Quran - Subjects IDs & Links

        public static readonly string QuranPaakKiAhmiatAathAhaadeesSy_Id = "quran-paak-ki-ahmiat-aath-ahaadees-sy?_?_?_";
        public static readonly string QuranPaakKiAhmiatAathAhaadeesSy_Link = string.Format("{0}#{1}", DawatEQuran, QuranPaakKiAhmiatAathAhaadeesSy_Id);

        public static readonly string toraat_or_injeel_ki_hifaazat_kion_nahi_hui_Id = "toraat-or-injeel-ki-hifaazat-kion-nahi-hui?_?_?_";
        public static readonly string toraat_or_injeel_ki_hifaazat_kion_nahi_hui_Link = string.Format("{0}#{1}", DawatEQuran, toraat_or_injeel_ki_hifaazat_kion_nahi_hui_Id);

        public static readonly string quran_paak_duniya_ki_asaan_tareen_kitaab_Id = "quran-paak-duniya-ki-asaan-tareen-kitaab?_?_?_";
        public static readonly string quran_paak_duniya_ki_asaan_tareen_kitaab_Link = string.Format("{0}#{1}", DawatEQuran, quran_paak_duniya_ki_asaan_tareen_kitaab_Id);

        public static readonly string quran_paak_or_hadees_mehfuuz_sahih_or_asaan_hein_Id = "quran-paak-or-hadees-mehfuuz-sahih-or-asaan-hein?_?_?_";
        public static readonly string quran_paak_or_hadees_mehfuuz_sahih_or_asaan_hein_Link = string.Format("{0}#{1}", DawatEQuran, quran_paak_or_hadees_mehfuuz_sahih_or_asaan_hein_Id);

        public static readonly string deen_islam_qubuul_karny_k_ilawa_nijaat_or_kaamyabi_nahi_ho_skati_Id = "deen-islam-qubuul-karny-k-ilawa-nijaat-or-kaamyabi-nahi-ho-skati?_?_?_";
        public static readonly string deen_islam_qubuul_karny_k_ilawa_nijaat_or_kaamyabi_nahi_ho_skati_Link = string.Format("{0}#{1}", DawatEQuran, deen_islam_qubuul_karny_k_ilawa_nijaat_or_kaamyabi_nahi_ho_skati_Id);


        public static readonly string allah_or_rasuul_k_ilawa_koi_aur_hujjat_or_daleel_nahi_Id = "allah-or-rasuul-k-ilawa-koi-aur-hujjat-or-daleel-nahi?_?_?_";
        public static readonly string allah_or_rasuul_k_ilawa_koi_aur_hujjat_or_daleel_nahi_Link = string.Format("{0}#{1}", DawatEQuran, allah_or_rasuul_k_ilawa_koi_aur_hujjat_or_daleel_nahi_Id);

        public static readonly string islam_ki_sachi_taleemaat_bamuqaabla_zaati_gumaan_Id = "islam-ki-sachi-taleemaat-bamuqaabla-zaati-gumaan?_?_?_";
        public static readonly string islam_ki_sachi_taleemaat_bamuqaabla_zaati_gumaan_Link = string.Format("{0}#{1}", DawatEQuran, islam_ki_sachi_taleemaat_bamuqaabla_zaati_gumaan_Id);

        public static readonly string ilm_e_wahi_or_ilm_e_science_Id = "ilm-e-wahi-or-ilm-e-science?_?_?_";
        public static readonly string ilm_e_wahi_or_ilm_e_science_Link = string.Format("{0}#{1}", DawatEQuran, ilm_e_wahi_or_ilm_e_science_Id);

        public static readonly string quran_hadees_direct_naa_parho_warna_gumraah_ho_jao_gy_ki_daleel_Id = "quran-hadees-direct-naa-parho-warna-gumraah-ho-jao-gy-ki-daleel?_?_?_";
        public static readonly string quran_hadees_direct_naa_parho_warna_gumraah_ho_jao_gy_ki_daleel_Link = string.Format("{0}#{1}", DawatEQuran, quran_hadees_direct_naa_parho_warna_gumraah_ho_jao_gy_ki_daleel_Id);


        public static readonly string munkreen_e_hadees_ko_ilmi_jawaab_Id = "munkreen-e-hadees-ko-ilmi-jawaab?_?_?_";
        public static readonly string munkreen_e_hadees_ko_ilmi_jawaab_Link = string.Format("{0}#{1}", DawatEQuran, munkreen_e_hadees_ko_ilmi_jawaab_Id);


        public static readonly string ijma_e_ummat_or_ijtihaad_ki_ahmiat_Id = "ijma-e-ummat-or-ijtihaad-ki-ahmiat?_?_?_";
        public static readonly string ijma_e_ummat_or_ijtihaad_ki_ahmiat_Link = string.Format("{0}#{1}", DawatEQuran, ijma_e_ummat_or_ijtihaad_ki_ahmiat_Id);


        public static readonly string islam_mein_ilm_ki_bunyaad_or_hujjat_quran_or_hadees_hein_Id = "islam-mein-ilm-ki-bunyaad-or-hujjat-quran-or-hadees-hein?_?_?_";
        public static readonly string islam_mein_ilm_ki_bunyaad_or_hujjat_quran_or_hadees_hein_Link = string.Format("{0}#{1}", DawatEQuran, islam_mein_ilm_ki_bunyaad_or_hujjat_quran_or_hadees_hein_Id);


        public static readonly string hidayat_hasil_karny_k_liye_teen_shraait_koshish_kro_baat_ghor_sy_suno_or_aqal_istamal_kro_Id = "hidayat-hasil-karny-k-liye-teen-shraait-koshish-kro-baat-ghor-sy-suno-or-aqal-istamal-kro?_?_?_";
        public static readonly string hidayat_hasil_karny_k_liye_teen_shraait_koshish_kro_baat_ghor_sy_suno_or_aqal_istamal_kro_Link = string.Format("{0}#{1}", DawatEQuran, hidayat_hasil_karny_k_liye_teen_shraait_koshish_kro_baat_ghor_sy_suno_or_aqal_istamal_kro_Id);


        public static readonly string quran_ko_chhorr_kar_kisi_bhi_kitaab_sy_islam_ki_dawt_o_tableegh_or_jihaad_e_akbar_mumkin_nahi_hy_Id = "quran-ko-chhorr-kar-kisi-bhi-kitaab-sy-islam-ki-dawt-o-tableegh-or-jihaad-e-akbar-mumkin-nahi-hy?_?_?_";
        public static readonly string quran_ko_chhorr_kar_kisi_bhi_kitaab_sy_islam_ki_dawt_o_tableegh_or_jihaad_e_akbar_mumkin_nahi_hy_Link = string.Format("{0}#{1}", DawatEQuran, quran_ko_chhorr_kar_kisi_bhi_kitaab_sy_islam_ki_dawt_o_tableegh_or_jihaad_e_akbar_mumkin_nahi_hy_Id);


        public static readonly string aakhirat_ki_nakaami_ki_asal_waja_buzurg_Id = "aakhirat-ki-nakaami-ki-asal-waja-buzurg?_?_?_";
        public static readonly string aakhirat_ki_nakaami_ki_asal_waja_buzurg_Link = string.Format("{0}#{1}", DawatEQuran, aakhirat_ki_nakaami_ki_asal_waja_buzurg_Id);



        public static readonly string nabi_kareem_s_a_w_ki_shifaat_ya_shikayat_Id = "nabi-kareem-s-a-w-ki-shifaat-ya-shikayat?_?_?_";
        public static readonly string nabi_kareem_s_a_w_ki_shifaat_ya_shikayat_Link = string.Format("{0}#{1}", DawatEQuran, nabi_kareem_s_a_w_ki_shifaat_ya_shikayat_Id);


        public static readonly string hmary_barron_par_dugna_azaab_or_laanat_ho_Id = "hmary-barron-par-dugna-azaab-or-laanat-ho?_?_?_";
        public static readonly string hmary_barron_par_dugna_azaab_or_laanat_ho_Link = string.Format("{0}#{1}", DawatEQuran, hmary_barron_par_dugna_azaab_or_laanat_ho_Id);

        public static readonly string hmari_baat_ko_diwaar_par_maar_do_Id = "hmari-baat-ko-diwaar-par-maar-do?_?_?_";
        public static readonly string hmari_baat_ko_diwaar_par_maar_do_Link = string.Format("{0}#{1}", DawatEQuran, hmari_baat_ko_diwaar_par_maar_do_Id);

        public static readonly string quran_hakeem_ki_roshni_mein_firqa_waariat_ki_muzammat_Id = "quran-hakeem-ki-roshni-mein-firqa-waariat-ki-muzammat?_?_?_";
        public static readonly string quran_hakeem_ki_roshni_mein_firqa_waariat_ki_muzammat_Link = string.Format("{0}#{1}", DawatEQuran, quran_hakeem_ki_roshni_mein_firqa_waariat_ki_muzammat_Id);


        public static readonly string allah_ki_rassi_kia_hy_Id = "allah-ki-rassi-kia-hy?_?_?_";
        public static readonly string allah_ki_rassi_kia_hy_Link = string.Format("{0}#{1}", DawatEQuran, allah_ki_rassi_kia_hy_Id);


        public static readonly string hmara_naam_musalman_kis_ny_rakha_Id = "hmara-naam-musalman-kis-ny-rakha?_?_?_";
        public static readonly string hmara_naam_musalman_kis_ny_rakha_Link = string.Format("{0}#{1}", DawatEQuran, hmara_naam_musalman_kis_ny_rakha_Id);

        public static readonly string firqy_bnany_walon_ki_saza_Id = "firqy-bnany-walon-ki-saza?_?_?_";
        public static readonly string firqy_bnany_walon_ki_saza_Link = string.Format("{0}#{1}", DawatEQuran, firqy_bnany_walon_ki_saza_Id);

        public static readonly string siraat_e_mustakeem_sirf_aik_hi_rasta_hy_Id = "siraat-e-mustakeem-sirf-aik-hi-rasta-hy?_?_?_";
        public static readonly string siraat_e_mustakeem_sirf_aik_hi_rasta_hy_Link = string.Format("{0}#{1}", DawatEQuran, siraat_e_mustakeem_sirf_aik_hi_rasta_hy_Id);

        public static readonly string naa_qaabil_e_muaafi_jurm_kon_sa_hy_Id = "naa-qaabil-e-muaafi-jurm-kon-sa-hy?_?_?_";
        public static readonly string naa_qaabil_e_muaafi_jurm_kon_sa_hy_Link = string.Format("{0}#{1}", DawatEQuran, naa_qaabil_e_muaafi_jurm_kon_sa_hy_Id);

        public static readonly string huzur_ki_shifaat_sy_mehruum_shakhs_Id = "huzur-ki-shifaat-sy-mehruum-shakhs?_?_?_";
        public static readonly string huzur_ki_shifaat_sy_mehruum_shakhs_Link = string.Format("{0}#{1}", DawatEQuran, huzur_ki_shifaat_sy_mehruum_shakhs_Id);

        public static readonly string shirk_karny_wala_jannat_sy_mehruum_Id = "shirk-karny-wala-jannat-sy-mehruum?_?_?_";
        public static readonly string shirk_karny_wala_jannat_sy_mehruum_Link = string.Format("{0}#{1}", DawatEQuran, shirk_karny_wala_jannat_sy_mehruum_Id);

        public static readonly string quran_ki_bunyadi_dawat_ghalba_toheed_Id = "quran-ki-bunyadi-dawat-ghalba-toheed?_?_?_";
        public static readonly string quran_ki_bunyadi_dawat_ghalba_toheed_Link = string.Format("{0}#{1}", DawatEQuran, quran_ki_bunyadi_dawat_ghalba_toheed_Id);

        public static readonly string ghaib_mein_madad_k_liye_pukaarna_Id = "ghaib-mein-madad-k-liye-pukaarna?_?_?_";
        public static readonly string ghaib_mein_madad_k_liye_pukaarna_Link = string.Format("{0}#{1}", DawatEQuran, ghaib_mein_madad_k_liye_pukaarna_Id);

        public static readonly string zahri_asbaab_mein_madad_k_liye_pukaarna_Id = "zahri-asbaab-mein-madad-k-liye-pukaarna?_?_?_";
        public static readonly string zahri_asbaab_mein_madad_k_liye_pukaarna_Link = string.Format("{0}#{1}", DawatEQuran, zahri_asbaab_mein_madad_k_liye_pukaarna_Id);

        public static readonly string ishq_k_jhally_number_ly_gaye_Id = "ishq-k-jhally-number-ly-gaye?_?_?_";
        public static readonly string ishq_k_jhally_number_ly_gaye_Link = string.Format("{0}#{1}", DawatEQuran, ishq_k_jhally_number_ly_gaye_Id);

        public static readonly string assalam_u_alaika_yaa_rasuul_allah_Id = "assalam-u-alaika-yaa-rasuul-allah?_?_?_";
        public static readonly string assalam_u_alaika_yaa_rasuul_allah_Link = string.Format("{0}#{1}", DawatEQuran, assalam_u_alaika_yaa_rasuul_allah_Id);

        public static readonly string dua_hi_ibadat_hy_Id = "dua-hi-ibadat-hy?_?_?_";
        public static readonly string dua_hi_ibadat_hy_Link = string.Format("{0}#{1}", DawatEQuran, dua_hi_ibadat_hy_Id);

        public static readonly string minn_duunillah_mein_nabi_shamil_hein_Id = "minn-duunillah-mein-nabi-shamil-hein?_?_?_";
        public static readonly string minn_duunillah_mein_nabi_shamil_hein_Link = string.Format("{0}#{1}", DawatEQuran, minn_duunillah_mein_nabi_shamil_hein_Id);

        public static readonly string ghair_ullah_ko_madad_k_liye_pukaarna_Id = "ghair-ullah-ko-madad-k-liye-pukaarna?_?_?_";
        public static readonly string ghair_ullah_ko_madad_k_liye_pukaarna_Link = string.Format("{0}#{1}", DawatEQuran, ghair_ullah_ko_madad_k_liye_pukaarna_Id);



        #endregion // 001 Dawat e Quran - Subjects IDs & Links

        #region 005 Hayat un Nabi S.A.W - SUbjects IDs & Links

        public static readonly string aik_hadees_sy_paanch_maslon_ka_hall_HazirNazir_ilmUlGhaib_hayaatUnNabi_istaanat_WaseelaOrTawassul_Id = "aik-hadees-sy-paanch-maslon-ka-hall-HazirNazir-ilmUlGhaib-hayaatUnNabi-istaanat-WaseelaOrTawassul?_?_?_";
        public static readonly string aik_hadees_sy_paanch_maslon_ka_hall_hayaatUnNabi_HazirNazir_ilmUlGhaib_istaanat_WaseelaOrTawassul_Link = string.Format("{0}#{1}", HayatUnNabi, aik_hadees_sy_paanch_maslon_ka_hall_HazirNazir_ilmUlGhaib_hayaatUnNabi_istaanat_WaseelaOrTawassul_Id);

        #endregion

        #region 006 Ilm ul Ghaib - Subjects IDs & Links

        public static readonly string ilm_ul_ghaib_ki_tareef_kia_hy_Id = "ilm-ul-ghaib-ki-tareef-kia-hy?_?_?_";
        public static readonly string ilm_ul_ghaib_ki_tareef_kia_hy_Link = string.Format("{0}#{1}", IlmUlGhaib, ilm_ul_ghaib_ki_tareef_kia_hy_Id);

        public static readonly string wo_cheezein_jo_ilm_ul_ghaib_mein_daakhil_nahi_Id = "wo-cheezein-jo-ilm-ul-ghaib-mein-daakhil-nahi?_?_?_";
        public static readonly string wo_cheezein_jo_ilm_ul_ghaib_mein_daakhil_nahi_Link = string.Format("{0}#{1}", IlmUlGhaib, wo_cheezein_jo_ilm_ul_ghaib_mein_daakhil_nahi_Id);

        public static readonly string ilm_ul_ghaib_naa_hony_ki_behtreen_misaal_Id = "ilm-ul-ghaib-naa-hony-ki-behtreen-misaal?_?_?_";
        public static readonly string ilm_ul_ghaib_naa_hony_ki_behtreen_misaal_Link = string.Format("{0}#{1}", IlmUlGhaib, ilm_ul_ghaib_naa_hony_ki_behtreen_misaal_Id);

        public static readonly string wo_cheezein_jo_ilm_ul_ghaib_mein_daakhil_hein_Id = "wo-cheezein-jo-ilm-ul-ghaib-mein-daakhil-hein?_?_?_";
        public static readonly string wo_cheezein_jo_ilm_ul_ghaib_mein_daakhil_hein_Link = string.Format("{0}#{1}", IlmUlGhaib, wo_cheezein_jo_ilm_ul_ghaib_mein_daakhil_hein_Id);

        public static readonly string ilm_ul_ghaib_ki_do_iqsaam_Id = "ilm-ul-ghaib-ki-do-iqsaam?_?_?_";
        public static readonly string ilm_ul_ghaib_ki_do_iqsaam_Link = string.Format("{0}#{1}", IlmUlGhaib, ilm_ul_ghaib_ki_do_iqsaam_Id);

        public static readonly string nabi_s_a_w_ki_btai_hui_ghaib_ki_khabrein_bamuqaabla_buzurgon_k_mann_gharrat_daawy_Id = "nabi-s_a_w-ki-btai-hui-ghaib-ki-khabrein-bamuqaabla-buzurgon-k-mann-gharrat-daawy?_?_?_";
        public static readonly string nabi_s_a_w_ki_btai_hui_ghaib_ki_khabrein_bamuqaabla_buzurgon_k_mann_gharrat_daawy_Link = string.Format("{0}#{1}", IlmUlGhaib, nabi_s_a_w_ki_btai_hui_ghaib_ki_khabrein_bamuqaabla_buzurgon_k_mann_gharrat_daawy_Id);

        public static readonly string aik_ghalat_fehmi_or_us_ka_jawaab_Id = "aik-ghalat-fehmi-or-us-ka-jawaab?_?_?_";
        public static readonly string aik_ghalat_fehmi_or_us_ka_jawaab_Link = string.Format("{0}#{1}", IlmUlGhaib, aik_ghalat_fehmi_or_us_ka_jawaab_Id);

        public static readonly string ilm_ul_ghaib_or_shifaat_ka_masla_braabar_hein_Id = "ilm-ul-ghaib-or-shifaat-ka-masla-braabar-hein?_?_?_";
        public static readonly string ilm_ul_ghaib_or_shifaat_ka_masla_braabar_hein_Link = string.Format("{0}#{1}", IlmUlGhaib, ilm_ul_ghaib_or_shifaat_ka_masla_braabar_hein_Id);

        public static readonly string kia_ilm_ul_ghaib_aik_hunar_hy_Id = "kia-ilm-ul-ghaib-aik-hunar-hy?_?_?_";
        public static readonly string kia_ilm_ul_ghaib_aik_hunar_hy_Link = string.Format("{0}#{1}", IlmUlGhaib, kia_ilm_ul_ghaib_aik_hunar_hy_Id);

        public static readonly string nabi_s_a_w_farishta_thy_Id = "nabi-s-a-w-farishta-thy?_?_?_";
        public static readonly string nabi_s_a_w_farishta_thy_Link = string.Format("{0}#{1}", IlmUlGhaib, nabi_s_a_w_farishta_thy_Id);

        public static readonly string yahuudi_orat_ny_nabi_s_a_w_ko_zehar_khila_diya_Id = "yahuudi-orat-ny-nabi-s-a-w-ko-zehar-khila-diya?_?_?_";
        public static readonly string yahuudi_orat_ny_nabi_s_a_w_ko_zehar_khila_diya_Link = string.Format("{0}#{1}", IlmUlGhaib, yahuudi_orat_ny_nabi_s_a_w_ko_zehar_khila_diya_Id);

        public static readonly string ilm_ul_ghaib_k_aqeedy_ko_wazia_karny_wali_ayat_Id = "ilm-ul-ghaib-k-aqeedy-ko-wazia-karny-wali-ayat?_?_?_";
        public static readonly string ilm_ul_ghaib_k_aqeedy_ko_wazia_karny_wali_ayat_Link = string.Format("{0}#{1}", IlmUlGhaib, ilm_ul_ghaib_k_aqeedy_ko_wazia_karny_wali_ayat_Id);

        public static readonly string zaati_ilm_ul_ghaib_Id = "zaati-ilm-ul-ghaib?_?_?_";
        public static readonly string zaati_ilm_ul_ghaib_Link = string.Format("{0}#{1}", IlmUlGhaib, zaati_ilm_ul_ghaib_Id);

        public static readonly string ghaib_ki_paanch_chaabian_kunjiaan_Id = "ghaib-ki-paanch-chaabian-kunjiaan?_?_?_";
        public static readonly string ghaib_ki_paanch_chaabian_kunjiaan_Link = string.Format("{0}#{1}", IlmUlGhaib, ghaib_ki_paanch_chaabian_kunjiaan_Id);

        public static readonly string kia_nabi_s_a_w_ny_Allah_ko_dykha_hy_Id = "kia-nabi-s-a-w-ny-Allah-ko-dykha-hy?_?_?_";
        public static readonly string kia_nabi_s_a_w_ny_Allah_ko_dykha_hy_Link = string.Format("{0}#{1}", IlmUlGhaib, kia_nabi_s_a_w_ny_Allah_ko_dykha_hy_Id);

        public static readonly string kia_Allah_ilm_ul_ghaib_sirf_apny_ambia_ko_dyta_hy_Id = "kia-Allah-ilm-ul-ghaib-sirf-apny-ambia-ko-dyta-hy?_?_?_";
        public static readonly string kia_Allah_ilm_ul_ghaib_sirf_apny_ambia_ko_dyta_hy_Link = string.Format("{0}#{1}", IlmUlGhaib, kia_Allah_ilm_ul_ghaib_sirf_apny_ambia_ko_dyta_hy_Id);

        public static readonly string azwaaj_e_mutahraat_ka_ilm_ul_ghaib_k_mutalliq_aqeeda_Id = "azwaaj-e-mutahraat-ka-ilm-ul-ghaib-k-mutalliq-aqeeda?_?_?_";
        public static readonly string azwaaj_e_mutahraat_ka_ilm_ul_ghaib_k_mutalliq_aqeeda_Link = string.Format("{0}#{1}", IlmUlGhaib, azwaaj_e_mutahraat_ka_ilm_ul_ghaib_k_mutalliq_aqeeda_Id);

        public static readonly string sihaba_ikraam_ka_ilm_ul_ghaib_k_mutalliq_aqeeda_Id = "sihaba-ikraam-ka-ilm-ul-ghaib-k-mutalliq-aqeeda?_?_?_";
        public static readonly string sihaba_ikraam_ka_ilm_ul_ghaib_k_mutalliq_aqeeda_Link = string.Format("{0}#{1}", IlmUlGhaib, sihaba_ikraam_ka_ilm_ul_ghaib_k_mutalliq_aqeeda_Id);

        public static readonly string nabi_s_a_w_ko_andar_sy_sab_kuch_pta_tha_Id = "nabi-s-a-w-ko-andar-sy-sab-kuch-pta-tha?_?_?_";
        public static readonly string nabi_s_a_w_ko_andar_sy_sab_kuch_pta_tha_IlmUlGhaib_Link = string.Format("{0}#{1}", IlmUlGhaib, nabi_s_a_w_ko_andar_sy_sab_kuch_pta_tha_Id);

        public static readonly string nabi_intahai_paryshaan_kion_huwe_Id = "nabi-intahai-paryshaan-kion-huwe?_?_?_";
        public static readonly string nabi_intahai_paryshaan_kion_huwe_IlmUlGhaib_Link = string.Format("{0}#{1}", IlmUlGhaib, nabi_intahai_paryshaan_kion_huwe_Id);

        public static readonly string nabi_s_a_w_ny_mashaariq_or_maghaarib_ko_dyykh_liya_Id = "nabi-s-a-w-ny-mashaariq-or-maghaarib-ko-dyykh-liya?_?_?_";
        public static readonly string nabi_s_a_w_ny_mashaariq_or_maghaarib_ko_dyykh_liya_Link = string.Format("{0}#{1}", IlmUlGhaib, nabi_s_a_w_ny_mashaariq_or_maghaarib_ko_dyykh_liya_Id);

        public static readonly string brailvion_ka_dhoka_Id = "brailvion-ka-dhoka?_?_?_";
        public static readonly string brailvion_ka_dhoka_Link = string.Format("{0}#{1}", IlmUlGhaib, brailvion_ka_dhoka_Id);

        public static readonly string nabi_s_a_w_ny_26_30_or_50_saal_baad_ki_ghaibi_khabrein_bhi_ummat_ko_btain_Id = "nabi-s-a-w-ny-26-30-or-50-saal-baad-ki-ghaibi-khabrein-bhi-ummat-ko-btain?_?_?_";
        public static readonly string nabi_s_a_w_ny_26_30_or_50_saal_baad_ki_ghaibi_khabrein_bhi_ummat_ko_btain_Link = string.Format("{0}#{1}", IlmUlGhaib, nabi_s_a_w_ny_26_30_or_50_saal_baad_ki_ghaibi_khabrein_bhi_ummat_ko_btain_Id);

        public static readonly string zaati_or_atai_ilm_qadeem_or_haadis_ilm_mehduud_or_laaMehduud_ilm_Id = "zaati-or-atai-ilm-qadeem-or-haadis-ilm-mehduud-or-laaMehduud-ilm?_?_?_";
        public static readonly string zaati_or_atai_ilm_qadeem_or_haadis_ilm_mehduud_or_laaMehduud_ilm_Link = string.Format("{0}#{1}", IlmUlGhaib, zaati_or_atai_ilm_qadeem_or_haadis_ilm_mehduud_or_laaMehduud_ilm_Id);

        public static readonly string kitaabon_ka_khuda_koi_aur_hy_or_babbon_ka_khuda_koi_aur_hy_Id = "kitaabon-ka-khuda-koi-aur-hy-or-babbon-ka-khuda-koi-aur-hy?_?_?_";
        public static readonly string kitaabon_ka_khuda_koi_aur_hy_or_babbon_ka_khuda_koi_aur_hy_Link = string.Format("{0}#{1}", IlmUlGhaib, kitaabon_ka_khuda_koi_aur_hy_or_babbon_ka_khuda_koi_aur_hy_Id);

        #endregion // 006 Ilm ul Ghaib - Subjects IDs & Links

        #region 007 Hazir O Nazir - Subjects IDs & Links

        public static readonly string aqeeda_hazir_o_nazir_ki_tareef_Id = "aqeeda-hazir-o-nazir-ki-tareef?_?_?_";
        public static readonly string aqeeda_hazir_o_nazir_ki_tareef_Link = string.Format("{0}#{1}", HazirONazir, aqeeda_hazir_o_nazir_ki_tareef_Id);

        public static readonly string aqeeda_hazir_o_nazir_k_baani_Id = "aqeeda-hazir-o-nazir-k-baani?_?_?_";
        public static readonly string aqeeda_hazir_o_nazir_k_baani_Link = string.Format("{0}#{1}", HazirONazir, aqeeda_hazir_o_nazir_k_baani_Id);

        public static readonly string deo_bandion_ka_aqeeda_hazir_o_nazir_Id = "deo-bandion-ka-aqeeda-hazir-o-nazir?_?_?_";
        public static readonly string deo_bandion_ka_aqeeda_hazir_o_nazir_Link = string.Format("{0}#{1}", HazirONazir, deo_bandion_ka_aqeeda_hazir_o_nazir_Id);

        public static readonly string brailvion_ka_aqeeda_hazir_o_nazir_or_sharamnaak_waqia_Id = "brailvion-ka-aqeeda-hazir-o-nazir-or-sharamnaak-waqia?_?_?_";
        public static readonly string brailvion_ka_aqeeda_hazir_o_nazir_or_sharamnaak_waqia_Link = string.Format("{0}#{1}", HazirONazir, brailvion_ka_aqeeda_hazir_o_nazir_or_sharamnaak_waqia_Id);

        public static readonly string kia_allah_k_liye_haazir_ka_lafz_istmal_kar_sakty_hein_Id = "kia-allah-k-liye-haazir-ka-lafz-istmal-kar-sakty-hein?_?_?_";
        public static readonly string kia_allah_k_liye_haazir_ka_lafz_istmal_kar_sakty_hein_Link = string.Format("{0}#{1}", HazirONazir, kia_allah_k_liye_haazir_ka_lafz_istmal_kar_sakty_hein_Id);

        public static readonly string gawahi_dyny_wala_hazir_o_nazir_hota_hy_Id = "gawahi-dyny-wala-hazir-o-nazir-hota-hy?_?_?_";
        public static readonly string gawahi_dyny_wala_hazir_o_nazir_hota_hy_Link = string.Format("{0}#{1}", HazirONazir, gawahi_dyny_wala_hazir_o_nazir_hota_hy_Id);


        public static readonly string qyamat_waly_din_nabi_s_a_w_ki_shikayat_Id = "qyamat-waly-din-nabi-s-a-w-ki-shikayat?_?_?_";
        public static readonly string qyamat_waly_din_nabi_s_a_w_ki_shikayat_Link = string.Format("{0}#{1}", HazirONazir, qyamat_waly_din_nabi_s_a_w_ki_shikayat_Id);

        public static readonly string alahazrat_ka_dhoka_Id = "alahazrat-ka-dhoka?_?_?_";
        public static readonly string alahazrat_ka_dhoka_Link = string.Format("{0}#{1}", HazirONazir, alahazrat_ka_dhoka_Id);

        public static readonly string puuri_ki_puuri_ummat_bhi_hazir_o_nazir_hy_Id = "puuri-ki-puuri-ummat-bhi-hazir-o-nazir-hy?_?_?_";
        public static readonly string puuri_ki_puuri_ummat_bhi_hazir_o_nazir_hy_Link = string.Format("{0}#{1}", HazirONazir, puuri_ki_puuri_ummat_bhi_hazir_o_nazir_hy_Id);

        public static readonly string sihaba_ikram_bhi_hazir_o_nazir_hein_Id = "sihaba-ikram-bhi-hazir-o-nazir-hein?_?_?_";
        public static readonly string sihaba_ikram_bhi_hazir_o_nazir_hein_Link = string.Format("{0}#{1}", HazirONazir, sihaba_ikram_bhi_hazir_o_nazir_hein_Id);

        public static readonly string shuhada_al_annaas_ka_aqeeda_Id = "shuhada-al-annaas-ka-aqeeda?_?_?_";
        public static readonly string shuhada_al_annaas_ka_aqeeda_Link = string.Format("{0}#{1}", HazirONazir, shuhada_al_annaas_ka_aqeeda_Id);

        public static readonly string zameen_o_asman_k_tmam_naik_bandon_par_salam_pohanchany_ka_nuskha_Id = "zameen-o-asman-k-tmam-naik-bandon-par-salam-pohanchany-ka-nuskha?_?_?_";
        public static readonly string zameen_o_asman_k_tmam_naik_bandon_par_salam_pohanchany_ka_nuskha_Link = string.Format("{0}#{1}", HazirONazir, zameen_o_asman_k_tmam_naik_bandon_par_salam_pohanchany_ka_nuskha_Id);

        public static readonly string ummation_ka_salaam_nabi_s_a_w_tak_pohanchta_hy_Id = "ummation-ka-salaam-nabi-s-a-w-tak-pohanchta-hy?_?_?_";
        public static readonly string ummation_ka_salaam_nabi_s_a_w_tak_pohanchta_hy_Link = string.Format("{0}#{1}", HazirONazir, ummation_ka_salaam_nabi_s_a_w_tak_pohanchta_hy_Id);

        public static readonly string ummat_k_nama_e_amaal_aap_s_a_w_ki_qabar_mein_paish_hoty_hein_Id = "ummat-k-nama-e-amaal-aap-s-a-w-ki-qabar-mein-paish-hoty-hein?_?_?_";
        public static readonly string ummat_k_nama_e_amaal_aap_s_a_w_ki_qabar_mein_paish_hoty_hein_Link = string.Format("{0}#{1}", HazirONazir, ummat_k_nama_e_amaal_aap_s_a_w_ki_qabar_mein_paish_hoty_hein_Id);

        public static readonly string huzuur_s_a_w_hmari_jan_sy_ziada_qareeb_hein_isi_liye_hazir_o_nazir_hein_Id = "huzuur-s-a-w-hmari-jan-sy-ziada-qareeb-hein-isi-liye-hazir-o-nazir-hein?_?_?_";
        public static readonly string huzuur_s_a_w_hmari_jan_sy_ziada_qareeb_hein_isi_liye_hazir_o_nazir_hein_Link = string.Format("{0}#{1}", HazirONazir, huzuur_s_a_w_hmari_jan_sy_ziada_qareeb_hein_isi_liye_hazir_o_nazir_hein_Id);

        public static readonly string huzuur_s_a_w_hum_mein_mojuud_hein_isi_liye_hum_par_azaab_nahi_ata_Id = "huzuur-s-a-w-hum-mein-mojuud-hein-isi-liye-hum-par-azaab-nahi-ata?_?_?_";
        public static readonly string huzuur_s_a_w_hum_mein_mojuud_hein_isi_liye_hum_par_azaab_nahi_ata_Link = string.Format("{0}#{1}", HazirONazir, huzuur_s_a_w_hum_mein_mojuud_hein_isi_liye_hum_par_azaab_nahi_ata_Id);

        public static readonly string kia_tum_ny_dykha_nahi_sy_hazir_o_nazir_ka_aqeeda_Id = "kia-tum-ny-dykha-nahi-sy-hazir-o-nazir-ka-aqeeda?_?_?_";
        public static readonly string kia_tum_ny_dykha_nahi_sy_hazir_o_nazir_ka_aqeeda_Link = string.Format("{0}#{1}", HazirONazir, kia_tum_ny_dykha_nahi_sy_hazir_o_nazir_ka_aqeeda_Id);

        public static readonly string yaad_karo_sy_hazir_o_nazir_ka_aqeeda_Id = "yaad-karo-sy-hazir-o-nazir-ka-aqeeda?_?_?_";
        public static readonly string yaad_karo_sy_hazir_o_nazir_ka_aqeeda_Link = string.Format("{0}#{1}", HazirONazir, yaad_karo_sy_hazir_o_nazir_ka_aqeeda_Id);

        public static readonly string alahazrat_ka_aik_aur_dhoka_Id = "alahazrat-ka-aik-aur-dhoka?_?_?_";
        public static readonly string alahazrat_ka_aik_aur_dhoka_Link = string.Format("{0}#{1}", HazirONazir, alahazrat_ka_aik_aur_dhoka_Id);

        public static readonly string nabi_intahai_paryshaan_kion_huwe_HazirNazir_Link = string.Format("{0}#{1}", HazirONazir, nabi_intahai_paryshaan_kion_huwe_Id);

        public static readonly string aik_hadees_sy_paanch_maslon_ka_hall_HazirNazir_ilmUlGhaib_hayaatUnNabi_istaanat_WaseelaOrTawassul_Link = string.Format("{0}#{1}", HazirONazir, aik_hadees_sy_paanch_maslon_ka_hall_HazirNazir_ilmUlGhaib_hayaatUnNabi_istaanat_WaseelaOrTawassul_Id);

        public static readonly string sahaba_ka_aqeeda_hazir_o_nazir_bamukabla_gustakhana_waqia_Id = "sahaba-ka-aqeeda-hazir-o-nazir-bamukabla-gustakhana-waqia?_?_?_";
        public static readonly string sahaba_ka_aqeeda_hazir_o_nazir_bamukabla_gustakhana_waqia_Link = string.Format("{0}#{1}", HazirONazir, sahaba_ka_aqeeda_hazir_o_nazir_bamukabla_gustakhana_waqia_Id);

        public static readonly string qabar_mein_didaar_e_mustafa_s_a_w_sy_hazir_o_nazir_ka_aqeeda_Id = "qabar-mein-didaar-e-mustafa-s-a-w-sy-hazir-o-nazir-ka-aqeeda?_?_?_";
        public static readonly string qabar_mein_didaar_e_mustafa_s_a_w_sy_hazir_o_nazir_ka_aqeeda_Link = string.Format("{0}#{1}", HazirONazir, qabar_mein_didaar_e_mustafa_s_a_w_sy_hazir_o_nazir_ka_aqeeda_Id);

        public static readonly string nabi_s_a_w_ko_andar_sy_sab_kuch_pta_tha_hazirNazir_Link = string.Format("{0}#{1}", HazirONazir, nabi_s_a_w_ko_andar_sy_sab_kuch_pta_tha_Id);

        public static readonly string nabi_s_a_w_ny_khud_farma_diya_k_main_hazir_o_nazir_nahi_hun_Id = "nabi-s-a-w-ny-khud-farma-diya-k-main-hazir-o-nazir-nahi-hun?_?_?_";
        public static readonly string nabi_s_a_w_ny_khud_farma_diya_k_main_hazir_o_nazir_nahi_hun_Link = string.Format("{0}#{1}", HazirONazir, nabi_s_a_w_ny_khud_farma_diya_k_main_hazir_o_nazir_nahi_hun_Id);


        #endregion

        #region 008 kalma Go Mushrik - Subjects IDs & Links


        public static readonly string kia_kalma_go_musalman_shirk_kr_sakta_hy_Id = "kia-kalma-go-musalman-shirk-kr-sakta-hy?_?_?_";
        public static readonly string kia_kalma_go_musalman_shirk_kr_sakta_hy_Link = string.Format("{0}#{1}", KalmaGoMushrik, kia_kalma_go_musalman_shirk_kr_sakta_hy_Id);


        public static readonly string kia_ummat_kabhi_bhi_shirk_nahi_kary_gi_Id = "kia-ummat-kabhi-bhi-shirk-nahi-kary-gi?_?_?_";
        public static readonly string kia_ummat_kabhi_bhi_shirk_nahi_kary_gi_Link = string.Format("{0}#{1}", KalmaGoMushrik, kia_ummat_kabhi_bhi_shirk_nahi_kary_gi_Id);
        #endregion // 008 kalma Go Mushrik - Subjects IDs & Links

        #region 015 Teen Talaaq - Subjects IDs & Links

        public static readonly string ikathi_teen_talaaqein_dyna_haraam_hy_Id = "ikathi-teen-talaaqein-dyna-haraam-hy?_?_?_";
        public static readonly string ikathi_teen_talaaqein_dyna_haraam_hy_Link = string.Format("{0}#{1}", TeenTalaaq, ikathi_teen_talaaqein_dyna_haraam_hy_Id);

        public static readonly string ikathi_teen_talaaqon_sy_aik_hi_talaaq_waqia_hoti_hy_ki_daleel_Id = "ikathi-teen-talaaqon-sy-aik-hi-talaaq-waqia-hoti-hy-ki-daleel?_?_?_";
        public static readonly string ikathi_teen_talaaqon_sy_aik_hi_talaaq_waqia_hoti_hy_ki_daleel_Link = string.Format("{0}#{1}", TeenTalaaq, ikathi_teen_talaaqon_sy_aik_hi_talaaq_waqia_hoti_hy_ki_daleel_Id);

        public static readonly string us_hadees_ka_syaaq_o_sbaaq_Id = "us-hadees-ka-syaaq-o-sbaaq?_?_?_";
        public static readonly string us_hadees_ka_syaaq_o_sbaaq_Link = string.Format("{0}#{1}", TeenTalaaq, us_hadees_ka_syaaq_o_sbaaq_Id);

        public static readonly string teen_talaaq_or_abdullah_bin_abbas_r_a_Id = "teen-talaaq-or-abdullah-bin-abbas-r-a?_?_?_";
        public static readonly string teen_talaaq_or_abdullah_bin_abbas_r_a_Link = string.Format("{0}#{1}", TeenTalaaq, teen_talaaq_or_abdullah_bin_abbas_r_a_Id);

        public static readonly string nabi_s_a_w_k_zamaany_mein_ikathi_teen_talaaqein_Id = "nabi-s-a-w-k-zamaany-mein-ikathi-teen-talaaqein?_?_?_";
        public static readonly string nabi_s_a_w_k_zamaany_mein_ikathi_teen_talaaqein_Link = string.Format("{0}#{1}", TeenTalaaq, nabi_s_a_w_k_zamaany_mein_ikathi_teen_talaaqein_Id);

        public static readonly string halaala_haraama_or_nikah_e_muta_Id = "halaala-haraama-or-nikah-e-muta?_?_?_";
        public static readonly string halaala_haraama_or_nikah_e_muta_Link = string.Format("{0}#{1}", TeenTalaaq, halaala_haraama_or_nikah_e_muta_Id);

        public static readonly string hansi_mazaak_mein_nikaah_yaa_talaaq_Id = "hansi-mazaak-mein-nikaah-yaa-talaaq?_?_?_";
        public static readonly string hansi_mazaak_mein_nikaah_yaa_talaaq_Link = string.Format("{0}#{1}", TeenTalaaq, hansi_mazaak_mein_nikaah_yaa_talaaq_Id);


        #endregion // 015 Teen Talaaq - Subjects IDs & Links

        #region 021 Bivion K islami Haqooq - Subjects IDs & Links

        public static readonly string biwi_ko_khhulaa_par_majbuur_karna_Id = "biwi-ko-khhulaa-par-majbuur-karna?_?_?_";
        public static readonly string biwi_ko_khhulaa_par_majbuur_karna_Link = string.Format("{0}#{1}", BevionKayHaqooq, biwi_ko_khhulaa_par_majbuur_karna_Id);

        public static readonly string biwi_ko_kab_chhorrna_ya_talaaq_dyna_jaiz_hy_Id = "biwi-ko-kab-chhorrna-ya-talaaq-dyna-jaiz-hy?_?_?_";
        public static readonly string biwi_ko_kab_chhorrna_ya_talaaq_dyna_jaiz_hy_Link = string.Format("{0}#{1}", BevionKayHaqooq, biwi_ko_kab_chhorrna_ya_talaaq_dyna_jaiz_hy_Id);

        public static readonly string mukammal_perfect_mard_o_orat_ki_talaash_Id = "mukammal-perfect-mard-o-orat-ki-talaash?_?_?_";
        public static readonly string mukammal_perfect_mard_o_orat_ki_talaash_Link = string.Format("{0}#{1}", BevionKayHaqooq, mukammal_perfect_mard_o_orat_ki_talaash_Id);

        public static readonly string biwi_k_saath_husn_e_suluuk_quran_ki_roshni_mein_Id = "biwi-k-saath-husn-e-suluuk-quran-ki-roshni-mein?_?_?_";
        public static readonly string biwi_k_saath_husn_e_suluuk_quran_ki_roshni_mein_Link = string.Format("{0}#{1}", BevionKayHaqooq, biwi_k_saath_husn_e_suluuk_quran_ki_roshni_mein_Id);

        public static readonly string biwi_k_saath_husn_e_suluuk_ahadees_ki_roshni_mein_Id = "biwi-k-saath-husn-e-suluuk-ahadees-ki-roshni-mein?_?_?_";
        public static readonly string biwi_k_saath_husn_e_suluuk_ahadees_ki_roshni_mein_Link = string.Format("{0}#{1}", BevionKayHaqooq, biwi_k_saath_husn_e_suluuk_ahadees_ki_roshni_mein_Id);

        public static readonly string kia_talaaq_halaal_or_jaiz_hy_Id = "kia-talaaq-halaal-or-jaiz-hy?_?_?_";
        public static readonly string kia_talaaq_halaal_or_jaiz_hy_Link = string.Format("{0}#{1}", BevionKayHaqooq, kia_talaaq_halaal_or_jaiz_hy_Id);

        public static readonly string talaaq_or_shaitaan_ki_khushi_Id = "talaaq-or-shaitaan-ki-khushi?_?_?_";
        public static readonly string talaaq_or_shaitaan_ki_khushi_Link = string.Format("{0}#{1}", BevionKayHaqooq, talaaq_or_shaitaan_ki_khushi_Id);



        #endregion // 015 Teen Talaaq - Subjects IDs & Links

        #region 084 - New Fatiha Khalf ul Imam - Subjects IDs & links

        public static readonly string hanfion_ka_fatiha_sy_mutalliq_extreme_rawaiyya_Id = "hanfion-ka-fatiha-sy-mutalliq-extreme-rawaiyya?_?_?_";
        public static readonly string hanfion_ka_fatiha_sy_mutalliq_extreme_rawaiyya_Link = string.Format("{0}#{1}", FatihaKhalfUlImam, hanfion_ka_fatiha_sy_mutalliq_extreme_rawaiyya_Id);

        public static readonly string ahl_e_haddeson_ka_fatiha_sy_mutalliq_extreme_rawaiyya_Id = "ahl-e-haddeson-ka-fatiha-sy-mutalliq-extreme-rawaiyya?_?_?_";
        public static readonly string ahl_e_haddeson_ka_fatiha_sy_mutalliq_extreme_rawaiyya_Link = string.Format("{0}#{1}", FatihaKhalfUlImam, ahl_e_haddeson_ka_fatiha_sy_mutalliq_extreme_rawaiyya_Id);

        public static readonly string hanfion_ka_fatiha_sy_mutalliq_daleel_ka_mazbuut_hona_Id = "hanfion-ka-fatiha-sy-mutalliq-daleel-ka-mazbuut-hona?_?_?_";
        public static readonly string hanfion_ka_fatiha_sy_mutalliq_daleel_ka_mazbuut_hona_Link = string.Format("{0}#{1}", FatihaKhalfUlImam, hanfion_ka_fatiha_sy_mutalliq_daleel_ka_mazbuut_hona_Id);

        public static readonly string fatiha_khalf_ul_imam_sy_mutalliq_sab_sy_sakht_muakkaf_imam_bukhari_ka_Id = "fatiha-khalf-ul-imam-sy-mutalliq-sab-sy-sakht-muakkaf-imam-bukhari-ka?_?_?_";
        public static readonly string fatiha_khalf_ul_imam_sy_mutalliq_sab_sy_sakht_muakkaf_imam_bukhari_ka_Link = string.Format("{0}#{1}", FatihaKhalfUlImam, fatiha_khalf_ul_imam_sy_mutalliq_sab_sy_sakht_muakkaf_imam_bukhari_ka_Id);

        public static readonly string imam_k_sakton_mein_fatiha_parhna_Id = "imam-k-sakton-mein-fatiha-parhna?_?_?_";
        public static readonly string imam_k_sakton_mein_fatiha_parhna_Link = string.Format("{0}#{1}", FatihaKhalfUlImam, imam_k_sakton_mein_fatiha_parhna_Id);

        public static readonly string fatiha_khalf_ul_imam_sy_mutalliq_imam_nasai_ka_muakkaf_Id = "fatiha-khalf-ul-imam-sy-mutalliq-imam-nasai-ka-muakkaf?_?_?_";
        public static readonly string fatiha_khalf_ul_imam_sy_mutalliq_imam_nasai_ka_muakkaf_Link = string.Format("{0}#{1}", FatihaKhalfUlImam, fatiha_khalf_ul_imam_sy_mutalliq_imam_nasai_ka_muakkaf_Id);

        public static readonly string hanfion_k_zulm_ki_intihaa_or_fatiha_khalf_ul_imam_Id = "hanfion-k-zulm-ki-intihaa-or-fatiha-khalf-ul-imam?_?_?_";
        public static readonly string hanfion_k_zulm_ki_intihaa_or_fatiha_khalf_ul_imam_Link = string.Format("{0}#{1}", FatihaKhalfUlImam, hanfion_k_zulm_ki_intihaa_or_fatiha_khalf_ul_imam_Id);

        public static readonly string hanfion_ka_dhoka_or_fatiha_khalf_ul_imam_Id = "hanfion-ka-dhoka-or-fatiha-khalf-ul-imam?_?_?_";
        public static readonly string hanfion_ka_dhoka_or_fatiha_khalf_ul_imam_Link = string.Format("{0}#{1}", FatihaKhalfUlImam, hanfion_ka_dhoka_or_fatiha_khalf_ul_imam_Id);

        public static readonly string fatiha_ko_dil_mein_kysy_parha_jaye_Id = "fatiha-ko-dil-mein-kysy-parha-jaye?_?_?_";
        public static readonly string fatiha_ko_dil_mein_kysy_parha_jaye_Link = string.Format("{0}#{1}", FatihaKhalfUlImam, fatiha_ko_dil_mein_kysy_parha_jaye_Id);

        public static readonly string fatiha_k_ilawa_kuch_naa_parho_sy_daleel_lyna_Id = "fatiha-k-ilawa-kuch-naa-parho-sy-daleel-lyna?_?_?_";
        public static readonly string fatiha_k_ilawa_kuch_naa_parho_sy_daleel_lyna_Link = string.Format("{0}#{1}", FatihaKhalfUlImam, fatiha_k_ilawa_kuch_naa_parho_sy_daleel_lyna_Id);

        public static readonly string qirat_karny_waly_k_muu_mein_angaara_Id = "qirat-karny-waly-k-muu-mein-angaara?_?_?_";
        public static readonly string qirat_karny_waly_k_muu_mein_angaara_Link = string.Format("{0}#{1}", FatihaKhalfUlImam, qirat_karny_waly_k_muu_mein_angaara_Id);

        public static readonly string nabi_s_a_w_ki_qiraat_ka_andaaz_Id = "nabi-s-a-w-ki-qiraat-ka-andaaz?_?_?_";
        public static readonly string nabi_s_a_w_ki_qiraat_ka_andaaz_Link = string.Format("{0}#{1}", FatihaKhalfUlImam, nabi_s_a_w_ki_qiraat_ka_andaaz_Id);

        public static readonly string kia_fatiha_k_baghair_rakat_shumaar_hoti_hy_Id = "kia-fatiha-k-baghair-rakat-shumaar-hoti-hy?_?_?_";
        public static readonly string kia_fatiha_k_baghair_rakat_shumaar_hoti_hy_Link = string.Format("{0}#{1}", FatihaKhalfUlImam, kia_fatiha_k_baghair_rakat_shumaar_hoti_hy_Id);

        public static readonly string dr_israr_sahab_ka_muaqqaf_or_fatiha_khalf_ul_imam_Id = "dr-israr-sahab-ka-muaqqaf-or-fatiha-khalf-ul-imam?_?_?_";
        public static readonly string dr_israr_sahab_ka_muaqqaf_or_fatiha_khalf_ul_imam_Link = string.Format("{0}#{1}", FatihaKhalfUlImam, dr_israr_sahab_ka_muaqqaf_or_fatiha_khalf_ul_imam_Id);

        public static readonly string molana_ishaq_sahab_ka_muaqqaf_or_fatiha_khalf_ul_imam_Id = "molana-ishaq-sahab-ka-muaqqaf-or-fatiha-khalf-ul-imam?_?_?_";
        public static readonly string molana_ishaq_sahab_ka_muaqqaf_or_fatiha_khalf_ul_imam_Link = string.Format("{0}#{1}", FatihaKhalfUlImam, molana_ishaq_sahab_ka_muaqqaf_or_fatiha_khalf_ul_imam_Id);

        public static readonly string molana_modudi_sahab_ka_muaqqaf_or_fatiha_khalf_ul_imam_Id = "molana-modudi-sahab-ka-muaqqaf-or-fatiha-khalf-ul-imam?_?_?_";
        public static readonly string molana_modudi_sahab_ka_muaqqaf_or_fatiha_khalf_ul_imam_Link = string.Format("{0}#{1}", FatihaKhalfUlImam, molana_modudi_sahab_ka_muaqqaf_or_fatiha_khalf_ul_imam_Id);

        public static readonly string shah_wali_ullah_dehalwi_sahab_ka_muaqqaf_or_fatiha_khalf_ul_imam_Id = "shah-wali-ullah-dehalwi-sahab-ka-muaqqaf-or-fatiha-khalf-ul-imam?_?_?_";
        public static readonly string shah_wali_ullah_dehalwi_sahab_ka_muaqqaf_or_fatiha_khalf_ul_imam_Link = string.Format("{0}#{1}", FatihaKhalfUlImam, shah_wali_ullah_dehalwi_sahab_ka_muaqqaf_or_fatiha_khalf_ul_imam_Id);

        public static readonly string ahsan_ul_bayan_mein_muaqqaf_or_fatiha_khalf_ul_imam_Id = "ahsan-ul-bayan-mein-muaqqaf-or-fatiha-khalf-ul-imam?_?_?_";
        public static readonly string ahsan_ul_bayan_mein_muaqqaf_or_fatiha_khalf_ul_imam_Link = string.Format("{0}#{1}", FatihaKhalfUlImam, ahsan_ul_bayan_mein_muaqqaf_or_fatiha_khalf_ul_imam_Id);

        public static readonly string kia_surat_fatiha_ko_imam_sy_pehly_parh_sakty_hein_Id = "kia-surat-fatiha-ko-imam-sy-pehly-parh-sakty-hein?_?_?_";
        public static readonly string kia_surat_fatiha_ko_imam_sy_pehly_parh_sakty_hein_Link = string.Format("{0}#{1}", FatihaKhalfUlImam, kia_surat_fatiha_ko_imam_sy_pehly_parh_sakty_hein_Id);

        public static readonly string ruku_mein_milny_sy_rakat_ka_shumaar_hona_Id = "ruku-mein-milny-sy-rakat-ka-shumaar-hona?_?_?_";
        public static readonly string ruku_mein_milny_sy_rakat_ka_shumaar_hona_Link = string.Format("{0}#{1}", FatihaKhalfUlImam, ruku_mein_milny_sy_rakat_ka_shumaar_hona_Id);

        public static readonly string shion_ka_muaqqaf_or_fatiha_khalf_ul_imam_Id = "shion-ka-muaqqaf-or-fatiha-khalf-ul-imam?_?_?_";
        public static readonly string shion_ka_muaqqaf_or_fatiha_khalf_ul_imam_Link = string.Format("{0}#{1}", FatihaKhalfUlImam, shion_ka_muaqqaf_or_fatiha_khalf_ul_imam_Id);




        #endregion

        #region 148 Sabhi Muslims - Subjects IDs & Links

        public static readonly string UlmaIslamKDushman_Id = "ulma-islam-k-dushman?_?_?_";
        public static readonly string UlmaIslamKDushman_Link = string.Format("{0}#{1}", SabhiMuslim, UlmaIslamKDushman_Id);

        public static readonly string firqa_waariat_kysy_khatam_ki_jaye_Id = "firqa-waariat-kysy-khatam-ki-jaye?_?_?_";
        public static readonly string firqa_waariat_kysy_khatam_ki_jaye_Link = string.Format("{0}#{1}", SabhiMuslim, firqa_waariat_kysy_khatam_ki_jaye_Id);

        #endregion  // 148 Sabhi Muslims - Subjects IDs & Links


    }

}