﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class ConvertToAlpha
    {
        public static String Convert(int i)
        {

            Dictionary<int, String> dictionary = new Dictionary<int, string>() {
             { 1,"un" },

             { 2,"deux"},

             { 3," trois"},

             { 4, "quatre" },

             { 5," cinq"},

             { 6," six" },

             { 7," sept" },

             { 8," huit"},

             { 9,"neuf" },

             { 10,"dix" },

             { 11,"onze" },

             { 12,"douze" },

             { 13,"treize"},

             { 14, "quatorze" },

             { 15,"quinze" },

             { 16,"seize" },

             { 17,"dix-sept" },

             { 18,"dix-huit" },

             { 19,"dix-neuf" },

             { 20,"vingt" },

             { 21,"vingt et un" },

             { 22,"vingt-deux" },

             { 23,"vingt-trois" },

             { 24,"vingt-quatre" },

             { 25,"vingt-cinq" },

             { 26,"vingt-six" },

             { 27,"vingt-sept" },

             { 28,"vingt-huit" },

             { 29,"vingt-neuf" },

             { 30,"trente" },

             { 31,"trente et un" },

             { 32,"trente-deux" },

             { 33,"trente-trois" },

             { 34,"trente-quatre" },

             { 35,"trente-cinq" },

             { 36,"trente-six" },

             { 37,"trente-sept" },

             { 38,"trente-huit" },

             { 39,"trente-neuf" },

             { 40,"quarante" },

             { 41,"quarante et un" },

             { 42,"quarante-deux" },

            { 43,"quarante-trois" },

             { 44,"quarante-quatre" },

             { 45,"quarante-cinq" },

             { 46," quarante-six"},

             { 47,"quarante-sept"},

             { 48, "quarante-huit" },

             { 49,"quarante-neuf" },

             { 50,"cinquante" },

             { 51,"cinquante et un" },

             { 52,"cinquante-deux" },

             { 53,"cinquante-trois"},

             { 54,"cinquante-quatre" },

             { 55,"cinquante-cinq" },

             { 56,"cinquante-six" },

             { 57,"cinquante-sept" },

             { 58,"cinquante-huit" },

             { 59,"cinquante-neuf" },

             { 60,"soixante" },

             { 61,"soixante et un" },

             { 62,"soixante-deux" },

             { 63,"soixante-trois" },

             { 64,"soixante-quatre" },

             { 65,"soixante-cinq" },

             { 66,"soixante-six" },

             { 67,"soixante-sept" },

             { 68,"soixante-huit" },

             { 69,"soixante-neuf" },

             { 70,"soixante-dix" },

             { 71,"soixante et onze" },

             { 72,"soixante-douze"},

             { 73,"soixante-treize"},

             { 74, "soixante-quatorze"},

             { 75,"soixante-quinze" },

             { 76,"soixante-seize" },

             { 77,"soixante-dix-sept" },

             { 78,"soixante-dix-huit" },

              { 79,"soixante-dix-neuf" },

                {80,"quatre-vingts" },

                {81,"quatre-vingt-un" },

                {82,"quatre-vingt-deux" },

                {83,"quatre-vingt-trois" },

                {84,"quatre-vingt-quatre" },

                {85,"quatre-vingt-cinq" },

                {86,"quatre-vingt-six" },

                {87,"quatre-vingt-sept" },

                {88,"quatre-vingt-huit" },

                {89,"quatre-vingt-neuf" },

                {90,"quatre-vingt-dix" },

                {91,"quatre-vingt-onze" },

                {92,"quatre-vingt-douze" },

                {93,"quatre-vingt-treize"},

                {94,"quatre-vingt-quatorze" },

                {95,"quatre-vingt-quinze" },

                {96,"quatre-vingt-seize" },

                {97,"quatre-vingt-dix-sept" },

                {98,"quatre-vingt-dix-huit" },

                {99,"quatre-vingt-dix-neuf" },

                {100,"cent" },

                {101,"cent un" },

                {102,"cent deux" },

                {103,"cent trois" },

                {104,"cent quatre" },

                {105,"cent cinq" },

                {106,"cent six" },

                {107,"cent sept" },

                {108,"cent huit" },

                {109,"cent neuf" },

                {110,"cent dix" },

                {111,"cent onze" },

                {112,"cent douze" },

                {113,"cent treize"},

                {114,"cent quatorze" },

                {115,"cent quinze" },

                {116,"cent seize" },

                {117,"cent dix-sept" },

                {118,"cent dix-huit" },

                {119,"cent dix-neuf" },

                {120,"cent vingt" },

                {121,"cent vingt et un" },

                {122,"cent vingt-deux" },

                {123,"cent vingt-trois" },

                {124,"cent vingt-quatre" },

                {125,"cent vingt-cinq" },

                {126,"cent vingt-six" },

                {127,"cent vingt-sept" },

                {128,"cent vingt-huit" },

                {129,"cent vingt-neuf" },

                {130,"cent trente" },

                {131,"cent trente et un" },

                {132,"cent trente-deux" },

                {133,"cent trente-trois" },

                {134,"cent trente-quatre" },

                {135,"cent trente-cinq" },

                {136,"cent trente-six" },

                {137,"cent trente-sept" },

                {138,"cent trente-huit" },

                {139,"cent trente-neuf" },

                {140,"cent quarante" },

                {141,"cent quarante et un" },

                {142,"cent quarante-deux" },

                {143,"cent quarante-trois" },

                {144,"cent quarante-quatre" },

                {145,"cent quarante-cinq" },

                {146,"cent  quarante-six"},

                {147,"cent quarante-sept"},

                {148,"cent quarante-huit" },

                {149,"cent quarante-neuf" },


                {150,"cent cinquante" },

                {151,"cent cinquante et un" },

                {152,"cent cinquante-deux" },

                {153,"cent cinquante-trois" },

                {154,"cent cinquante-quatre" },

                {155,"cent cinquante-cinq" },

                {156,"cent cinquante-six" },

                {157,"cent cinquante-sept" },

                {158,"cent cinquante-huit" },

                {159,"cent cinquante-neuf" },

                {160,"cent soixante" },

                {161,"cent soixante et un" },

                {162,"cent soixante-deux" },

                {163,"cent soixante-trois" },

                {164,"cent soixante-quatre" },

                {165,"cent soixante-cinq" },

                {166,"cent soixante-six" },

                {167,"cent soixante-sept" },

                {168,"cent soixante-huit" },

                {169,"cent soixante-neuf" },

                {170,"cent soixante-dix" },

                {171,"cent soixante et onze" },

                {172,"cent soixante-douze"},

                {173,"cent soixante-treize"},

                {174,"cent soixante-quatorze" },

                {175,"cent soixante-quinze" },

                {176,"cent soixante-seize" },

                {177,"cent soixante-dix-sept" },

                {178,"cent soixante-dix-huit" },

                {179,"cent soixante-dix-neuf" },

                {180,"cent quatre-vingts" },

                {181,"cent quatre-vingt-un" },

                {182,"cent quatre-vingt-deux" },

                {183,"cent quatre-vingt-trois" },

                {184,"cent quatre-vingt-quatre" },

                {185,"cent quatre-vingt-cinq" },

                {186,"cent quatre-vingt-six" },

                {187,"cent quatre-vingt-sept" },

                {188,"cent quatre-vingt-huit" },

                {189,"cent quatre-vingt-neuf" },

                {190,"cent quatre-vingt-dix" },

                {191,"cent quatre-vingt-onze" },

                {192,"cent quatre-vingt-douze" },

                {193,"cent quatre-vingt-treize"},

                {194,"cent quatre-vingt-quatorze" },

                {195,"cent quatre-vingt-quinze" },

                {196,"cent quatre-vingt-seize" },

                {197,"cent quatre-vingt-dix-sept" },

                {198,"cent quatre-vingt-dix-huit" },

                {199,"cent quatre-vingt-dix-neuf" },

                {200,"deux cents" },

                {201,"deux cent un" },

                {202,"deux cent deux" },

                {203,"deux cent trois" },

                {204,"deux cent quatre" },

                {205,"deux cent cinq" },

                {206,"deux cent six" },

                {207,"deux cent sept" },

                {208,"deux cent huit" },

                {209,"deux cent neuf" },

                {210,"deux cent dix" },

                {211,"deux cent onze" },

                {212,"deux cent douze" },

                {213,"deux cent treize"},

                {214,"deux cent quatorze" },

                {215,"deux cent quinze" },

                {216,"deux cent seize" },

                {217,"deux cent dix-sept" },

                {218,"deux cent dix-huit" },

                {219,"deux cent dix-neuf" },

                {220,"deux cent vingt" },

                {221,"deux cent vingt et un" },

                {222,"deux cent vingt-deux" },

                {223,"deux cent vingt-trois" },

                {224,"deux cent vingt-quatre" },

                {225,"deux cent vingt-cinq" },

                {226,"deux cent vingt-six" },

                {227,"deux cent vingt-sept" },

                {228,"deux cent vingt-huit" },

                {229,"deux cent vingt-neuf" },

                {230,"deux cent trente" },

                {231,"deux cent trente et un" },

                {232,"deux cent trente-deux" },

                {233,"deux cent trente-trois" },

                {234,"deux cent trente-quatre" },

                {235,"deux cent trente-cinq" },

                {236,"deux cent trente-six" },

                {237,"deux cent trente-sept" },

                {238,"deux cent trente-huit" },

                {239,"deux cent trente-neuf" },

                {240,"deux cent quarante" },

                {241,"deux cent quarante et un" },

                {242,"deux cent quarante-deux" },

                {243,"deux cent quarante-trois" },

                {244,"deux cent quarante-quatre" },

                {245,"deux cent quarante-cinq" },

                {246,"deux cent  quarante-six"},

                {247,"deux cent quarante-sept"},

                {248,"deux cent quarante-huit" },

                {249,"deux cent quarante-neuf" },

                {250,"deux cent cinquante" },

                {251,"deux cent cinquante et un" },

                {252,"deux cent cinquante-deux" },

                {253,"deux cent cinquante-trois" },

                {254,"deux cent cinquante-quatre" },

                {255,"deux cent cinquante-cinq" },

                {256,"deux cent cinquante-six" },

                {257,"deux cent cinquante-sept" },

                {258,"deux cent cinquante-huit" },

                {259,"deux cent cinquante-neuf" },

                {260,"deux cent soixante" },

                {261,"deux cent soixante et un" },

                {262,"deux cent soixante-deux" },

                {263,"deux cent soixante-trois" },

                {264,"deux cent soixante-quatre" },

                {265,"deux cent soixante-cinq" },

                {266,"deux cent soixante-six" },

                {267,"deux cent soixante-sept" },

                {268,"deux cent soixante-huit" },

                {269,"deux cent soixante-neuf" },

                {270,"deux cent soixante-dix" },

                {271,"deux cent soixante et onze" },

                {272,"deux cent soixante-douze"},

                {273,"deux cent soixante-treize"},

                {274,"deux cent soixante-quatorze"},

                { 275,"deux cent soixante-quinze"},

                { 276,"deux cent soixante-seize"},

                { 277,"deux cent soixante-dix-sept"},

                { 278,"deux cent soixante-dix-huit"},

                { 279,"deux cent soixante-dix-neuf"},

                { 280,"deux cent quatre-vingts"},

                { 281,"deux cent quatre-vingt-un"},

                { 282,"deux cent quatre-vingt-deux"},

                { 283,"deux cent quatre-vingt-trois"},

                { 284,"deux cent quatre-vingt-quatre"},

                { 285,"deux cent quatre-vingt-cinq"},

                { 286,"deux cent quatre-vingt-six"},

                { 287,"deux cent quatre-vingt-sept"},

                { 288,"deux cent quatre-vingt-huit"},

                { 289,"deux cent quatre-vingt-neuf"},

                { 290,"deux cent quatre-vingt-dix"},

                { 291,"deux cent quatre-vingt-onze"},

                { 292,"deux cent quatre-vingt-douze"},

                { 293,"deux cent quatre-vingt-treize"},

                { 294,"deux cent quatre-vingt-quatorze"},

                { 295,"deux cent quatre-vingt-quinze"},

                {296,"deux cent quatre-vingt-seize"},

                {297,"deux cent quatre-vingt-dix-sept"},

                {298,"deux cent quatre-vingt-dix-huit"},

                {299,"deux cent quatre-vingt-dix-neuf"},

                {300," trois cents"},

                { 301,"trois cent un"},
                { 302,"trois cent deux"},
                { 303,"trois cent trois"},
                { 304,"trois cent quatre"},
                { 305,"trois cent cinq"},
                { 306,"trois cent six"},
                { 307,"trois cent sept"},
                { 308,"trois cent huit"},
{309,"trois cent neuf"},
{310,"trois cent dix"},
{311,"trois cent onze"},
{312,"trois cent douze"},
{313,"trois cent treize"},
{314,"trois cent quatorze"},
{315,"trois cent quinze"},
{316,"trois cent seize"},
{317,"trois cent dix-sept"},
{318,"trois cent dix-huit"},
{319,"trois cent dix-neuf"},
{320,"trois cent vingt"},
{321,"trois cent vingt et un"},
{322,"trois cent vingt-deux"},
{323,"trois cent vingt-trois"},
{324,"trois cent vingt-quatre"},
{325,"trois cent vingt-cinq"},
{326,"trois cent vingt-six"},
{327,"trois cent vingt-sept"},
{328,"trois cent vingt-huit"},
{329,"trois cent vingt-neuf"},
{330,"trois cent trente"},
{331,"trois cent trente et un"},
{332,"trois cent trente-deux"},
{333,"trois cent trente-trois"},
{334,"trois cent trente-quatre"},
{335,"trois cent trente-cinq"},
{336,"trois cent trente-six"},
{337,"trois cent trente-sept"},
{338,"trois cent trente-huit"},
{339,"trois cent trente-neuf"},
{340,"trois cent quarante"},
{341,"trois cent quarante et un"},
{342,"trois cent quarante-deux"},
{343,"trois cent quarante-trois"},
{344,"trois cent quarante-quatre"},
{345,"trois cent quarante-cinq"},
{346,"trois cent quarante-six"},
{347,"trois cent quarante-sept"},
{348,"trois cent quarante-huit"},
{349,"trois cent quarante-neuf"},
{350,"trois cent cinquante"},
{351,"trois cent cinquante et un"},
{352,"trois cent cinquante-deux"},
{353,"trois cent cinquante-trois"},
{354,"trois cent cinquante-quatre"},
{355,"trois cent cinquante-cinq"},
{356,"trois cent cinquante-six"},
{357,"trois cent cinquante-sept"},
{358,"trois cent cinquante-huit"},
{359,"trois cent cinquante-neuf"},
{360,"trois cent soixante"},
{361,"trois cent soixante et un"},
{362,"trois cent soixante-deux"},
{363,"trois cent soixante-trois"},
{364,"trois cent soixante-quatre"},
{365,"trois cent soixante-cinq"},
{366,"trois cent soixante-six"},
{367,"trois cent soixante-sept"},
{368,"trois cent soixante-huit"},
{369,"trois cent soixante-neuf"},
{370,"trois cent soixante-dix"},
{371,"trois cent soixante et onze"},
{372,"trois cent soixante-douze"},
{373,"trois cent soixante-treize"},
{374,"trois cent soixante-quatorze"},
{375,"trois cent soixante-quinze"},
{376,"trois cent soixante-seize"},
{377,"trois cent soixante-dix-sept"},
{378,"trois cent soixante-dix-huit"},
{379,"trois cent soixante-dix-neuf"},
{380,"trois cent quatre-vingts"},
{381,"trois cent quatre-vingt-un"},
{382,"trois cent quatre-vingt-deux"},
{383,"trois cent quatre-vingt-trois"},
{384,"trois cent quatre-vingt-quatre"},
{385,"trois cent quatre-vingt-cinq"},
{386,"trois cent quatre-vingt-six"},
{387,"trois cent quatre-vingt-sept"},
{388,"trois cent quatre-vingt-huit"},
{389,"trois cent quatre-vingt-neuf"},
{390,"trois cent quatre-vingt-dix"},
{391,"trois cent quatre-vingt-onze"},
{392,"trois cent quatre-vingt-douze"},
{393,"trois cent quatre-vingt-treize"},
{394,"trois cent quatre-vingt-quatorze"},
{395,"trois cent quatre-vingt-quinze"},
{396,"trois cent quatre-vingt-seize"},
{397,"trois cent quatre-vingt-dix-sept"},
{398,"trois cent quatre-vingt-dix-huit"},
{399,"trois cent quatre-vingt-dix-neuf"},
                {400," quatre cents"},
                {401,"quatre cent un"},
{402,"quatre cent deux"},
{403,"quatre cent trois"},
{404,"quatre cent quatre"},
{405,"quatre cent cinq"},
{406,"quatre cent six"},
{407,"quatre cent sept"},
{408,"quatre cent huit"},
{409,"quatre cent neuf"},
{410,"quatre cent dix"},
{411,"quatre cent onze"},
{412,"quatre cent douze"},
{413,"quatre cent treize"},
{414,"quatre cent quatorze"},
{415,"quatre cent quinze"},
{416,"quatre cent seize"},
{417,"quatre cent dix-sept"},
{418,"quatre cent dix-huit"},
{419,"quatre cent dix-neuf"},
{420,"quatre cent vingt"},
{421,"quatre cent vingt et un"},
{422,"quatre cent vingt-deux"},
{423,"quatre cent vingt-trois"},
{424,"quatre cent vingt-quatre"},
{425,"quatre cent vingt-cinq"},
{426,"quatre cent vingt-six"},
{427,"quatre cent vingt-sept"},
{428,"quatre cent vingt-huit"},
{429,"quatre cent vingt-neuf"},
{430,"quatre cent trente"},
{431,"quatre cent trente et un"},
{432,"quatre cent trente-deux"},
{433,"quatre cent trente-trois"},
{434,"quatre cent trente-quatre"},
{435,"quatre cent trente-cinq"},
{436,"quatre cent trente-six"},
{437,"quatre cent trente-sept"},
{438,"quatre cent trente-huit"},
{439,"quatre cent trente-neuf"},
{440,"quatre cent quarante"},
{441,"quatre cent quarante et un"},
{442,"quatre cent quarante-deux"},
{443,"quatre cent quarante-trois"},
{444,"quatre cent quarante-quatre"},
{445,"quatre cent quarante-cinq"},
{446,"quatre cent quarante-six"},
{447,"quatre cent quarante-sept"},
{448,"quatre cent quarante-huit"},
{449,"quatre cent quarante-neuf"},
{450,"quatre cent cinquante"},
{451,"quatre cent cinquante et un"},
{452,"quatre cent cinquante-deux"},
{453,"quatre cent cinquante-trois"},
{454,"quatre cent cinquante-quatre"},
{455,"quatre cent cinquante-cinq"},
{456,"quatre cent cinquante-six"},
{457,"quatre cent cinquante-sept"},
{458,"quatre cent cinquante-huit"},
{459,"quatre cent cinquante-neuf"},
{460,"quatre cent soixante"},
{461,"quatre cent soixante et un"},
{462,"quatre cent soixante-deux"},
{463,"quatre cent soixante-trois"},
{464,"quatre cent soixante-quatre"},
{465,"quatre cent soixante-cinq"},
{466,"quatre cent soixante-six"},
{467,"quatre cent soixante-sept"},
{468,"quatre cent soixante-huit"},
{469,"quatre cent soixante-neuf"},
{470,"quatre cent soixante-dix"},
{471,"quatre cent soixante et onze"},
{472,"quatre cent soixante-douze"},
{473,"quatre cent soixante-treize"},
{474,"quatre cent soixante-quatorze"},
{475,"quatre cent soixante-quinze"},
{476,"quatre cent soixante-seize"},
{477,"quatre cent soixante-dix-sept"},
{478,"quatre cent soixante-dix-huit"},
{479,"quatre cent soixante-dix-neuf"},
{480,"quatre cent quatre-vingts"},
{481,"quatre cent quatre-vingt-un"},
{482,"quatre cent quatre-vingt-deux"},
{483,"quatre cent quatre-vingt-trois"},
{484,"quatre cent quatre-vingt-quatre"},
{485,"quatre cent quatre-vingt-cinq"},
{486,"quatre cent quatre-vingt-six"},
{487,"quatre cent quatre-vingt-sept"},
{488,"quatre cent quatre-vingt-huit"},
{489,"quatre cent quatre-vingt-neuf"},
{490,"quatre cent quatre-vingt-dix"},
{491,"quatre cent quatre-vingt-onze"},
{492,"quatre cent quatre-vingt-douze"},
{493,"quatre cent quatre-vingt-treize"},
{494,"quatre cent quatre-vingt-quatorze"},
{495,"quatre cent quatre-vingt-quinze"},
{496,"quatre cent quatre-vingt-seize"},
{497,"quatre cent quatre-vingt-dix-sept"},
{498,"quatre cent quatre-vingt-dix-huit"},
{499,"quatre cent quatre-vingt-dix-neuf"},
                {500," cinq cents"},
                {501,"cinq cent un"},
{502,"cinq cent deux"},
{503,"cinq cent trois"},
{504,"cinq cent quatre"},
{505,"cinq cent cinq"},
{506,"cinq cent six"},
{507,"cinq cent sept"},
{508,"cinq cent huit"},
{509,"cinq cent neuf"},
{510,"cinq cent dix"},
{511,"cinq cent onze"},
{512,"cinq cent douze"},
{513,"cinq cent treize"},
{514,"cinq cent quatorze"},
{515,"cinq cent quinze"},
{516,"cinq cent seize"},
{517,"cinq cent dix-sept"},
{518,"cinq cent dix-huit"},
{519,"cinq cent dix-neuf"},
{520,"cinq cent vingt"},
{521,"cinq cent vingt et un"},
{522,"cinq cent vingt-deux"},
{523,"cinq cent vingt-trois"},
{524,"cinq cent vingt-quatre"},
{525,"cinq cent vingt-cinq"},
{526,"cinq cent vingt-six"},
{527,"cinq cent vingt-sept"},
{528,"cinq cent vingt-huit"},
{529,"cinq cent vingt-neuf"},
{530,"cinq cent trente"},
{531,"cinq cent trente et un"},
{532,"cinq cent trente-deux"},
{533,"cinq cent trente-trois"},
{534,"cinq cent trente-quatre"},
{535,"cinq cent trente-cinq"},
{536,"cinq cent trente-six"},
{537,"cinq cent trente-sept"},
{538,"cinq cent trente-huit"},
{539,"cinq cent trente-neuf"},
{540,"cinq cent quarante"},
{541,"cinq cent quarante et un"},
{542,"cinq cent quarante-deux"},
{543,"cinq cent quarante-trois"},
{544,"cinq cent quarante-quatre"},
{545,"cinq cent quarante-cinq"},
{546,"cinq cent quarante-six"},
{547,"cinq cent quarante-sept"},
{548,"cinq cent quarante-huit"},
{549,"cinq cent quarante-neuf"},
{550,"cinq cent cinquante"},
{551,"cinq cent cinquante et un"},
{552,"cinq cent cinquante-deux"},
{553,"cinq cent cinquante-trois"},
{554,"cinq cent cinquante-quatre"},
{555,"cinq cent cinquante-cinq"},
{556,"cinq cent cinquante-six"},
{557,"cinq cent cinquante-sept"},
{558,"cinq cent cinquante-huit"},
{559,"cinq cent cinquante-neuf"},
{560,"cinq cent soixante"},
{561,"cinq cent soixante et un"},
{562,"cinq cent soixante-deux"},
{563,"cinq cent soixante-trois"},
{564,"cinq cent soixante-quatre"},
{565,"cinq cent soixante-cinq"},
{566,"cinq cent soixante-six"},
{567,"cinq cent soixante-sept"},
{568,"cinq cent soixante-huit"},
{569,"cinq cent soixante-neuf"},
{570,"cinq cent soixante-dix"},
{571,"cinq cent soixante et onze"},
{572,"cinq cent soixante-douze"},
{573,"cinq cent soixante-treize"},
{574,"cinq cent soixante-quatorze"},
{575,"cinq cent soixante-quinze"},
{576,"cinq cent soixante-seize"},
{577,"cinq cent soixante-dix-sept"},
{578,"cinq cent soixante-dix-huit"},
{579,"cinq cent soixante-dix-neuf"},
{580,"cinq cent quatre-vingts"},
{581,"cinq cent quatre-vingt-un"},
{582,"cinq cent quatre-vingt-deux"},
{583,"cinq cent quatre-vingt-trois"},
{584,"cinq cent quatre-vingt-quatre"},
{585,"cinq cent quatre-vingt-cinq"},
{586,"cinq cent quatre-vingt-six"},
{587,"cinq cent quatre-vingt-sept"},
{588,"cinq cent quatre-vingt-huit"},
{589,"cinq cent quatre-vingt-neuf"},
{590,"cinq cent quatre-vingt-dix"},
{591,"cinq cent quatre-vingt-onze"},
{592,"cinq cent quatre-vingt-douze"},
{593,"cinq cent quatre-vingt-treize"},
{594,"cinq cent quatre-vingt-quatorze"},
{595,"cinq cent quatre-vingt-quinze"},
{596,"cinq cent quatre-vingt-seize"},
{597,"cinq cent quatre-vingt-dix-sept"},
{598,"cinq cent quatre-vingt-dix-huit"},
{599,"cinq cent quatre-vingt-dix-neuf"},
                {600," six cents"},
                {601,"six cent un"},
{602,"six cent deux"},
{603,"six cent trois"},
{604,"six cent quatre"},
{605,"six cent cinq"},
{606,"six cent six"},
{607,"six cent sept"},
{608,"six cent huit"},
{609,"six cent neuf"},
{610,"six cent dix"},
{611,"six cent onze"},
{612,"six cent douze"},
{613,"six cent treize"},
{614,"six cent quatorze"},
{615,"six cent quinze"},
{616,"six cent seize"},
{617,"six cent dix-sept"},
{618,"six cent dix-huit"},
{619,"six cent dix-neuf"},
{620,"six cent vingt"},
{621,"six cent vingt et un"},
{622,"six cent vingt-deux"},
{623,"six cent vingt-trois"},
{624,"six cent vingt-quatre"},
{625,"six cent vingt-cinq"},
{626,"six cent vingt-six"},
{627,"six cent vingt-sept"},
{628,"six cent vingt-huit"},
{629,"six cent vingt-neuf"},
{630,"six cent trente"},
{631,"six cent trente et un"},
{632,"six cent trente-deux"},
{633,"six cent trente-trois"},
{634,"six cent trente-quatre"},
{635,"six cent trente-cinq"},
{636,"six cent trente-six"},
{637,"six cent trente-sept"},
{638,"six cent trente-huit"},
{639,"six cent trente-neuf"},
{640,"six cent quarante"},
{641,"six cent quarante et un"},
{642,"six cent quarante-deux"},
{643,"six cent quarante-trois"},
{644,"six cent quarante-quatre"},
{645,"six cent quarante-cinq"},
{646,"six cent quarante-six"},
{647,"six cent quarante-sept"},
{648,"six cent quarante-huit"},
{649,"six cent quarante-neuf"},
{650,"six cent cinquante"},
{651,"six cent cinquante et un"},
{652,"six cent cinquante-deux"},
{653,"six cent cinquante-trois"},
{654,"six cent cinquante-quatre"},
{655,"six cent cinquante-cinq"},
{656,"six cent cinquante-six"},
{657,"six cent cinquante-sept"},
{658,"six cent cinquante-huit"},
{659,"six cent cinquante-neuf"},
{660,"six cent soixante"},
{661,"six cent soixante et un"},
{662,"six cent soixante-deux"},
{663,"six cent soixante-trois"},
{664,"six cent soixante-quatre"},
{665,"six cent soixante-cinq"},
{666,"six cent soixante-six"},
{667,"six cent soixante-sept"},
{668,"six cent soixante-huit"},
{669,"six cent soixante-neuf"},
{670,"six cent soixante-dix"},
{671,"six cent soixante et onze"},
{672,"six cent soixante-douze"},
{673,"six cent soixante-treize"},
{674,"six cent soixante-quatorze"},
{675,"six cent soixante-quinze"},
{676,"six cent soixante-seize"},
{677,"six cent soixante-dix-sept"},
{678,"six cent soixante-dix-huit"},
{679,"six cent soixante-dix-neuf"},
{680,"six cent quatre-vingts"},
{681,"six cent quatre-vingt-un"},
{682,"six cent quatre-vingt-deux"},
{683,"six cent quatre-vingt-trois"},
{684,"six cent quatre-vingt-quatre"},
{685,"six cent quatre-vingt-cinq"},
{686,"six cent quatre-vingt-six"},
{687,"six cent quatre-vingt-sept"},
{688,"six cent quatre-vingt-huit"},
{689,"six cent quatre-vingt-neuf"},
{690,"six cent quatre-vingt-dix"},
{691,"six cent quatre-vingt-onze"},
{692,"six cent quatre-vingt-douze"},
{693,"six cent quatre-vingt-treize"},
{694,"six cent quatre-vingt-quatorze"},
{695,"six cent quatre-vingt-quinze"},
{696,"six cent quatre-vingt-seize"},
{697,"six cent quatre-vingt-dix-sept"},
{698,"six cent quatre-vingt-dix-huit"},
{699,"six cent quatre-vingt-dix-neuf"},

                {700," sept cents" },
                {701,"sept cent un"},
{702,"sept cent deux"},
{703,"sept cent trois"},
{704,"sept cent quatre"},
{705,"sept cent cinq"},
{706,"sept cent six"},
{707,"sept cent sept"},
{708,"sept cent huit"},
{709,"sept cent neuf"},
{710,"sept cent dix"},
{711,"sept cent onze"},
{712,"sept cent douze"},
{713,"sept cent treize"},
{714,"sept cent quatorze"},
{715,"sept cent quinze"},
{716,"sept cent seize"},
{717,"sept cent dix-sept"},
{718,"sept cent dix-huit"},
{719,"sept cent dix-neuf"},
{720,"sept cent vingt"},
{721,"sept cent vingt et un"},
{722,"sept cent vingt-deux"},
{723,"sept cent vingt-trois"},
{724,"sept cent vingt-quatre"},
{725,"sept cent vingt-cinq"},
{726,"sept cent vingt-six"},
{727,"sept cent vingt-sept"},
{728,"sept cent vingt-huit"},
{729,"sept cent vingt-neuf"},
{730,"sept cent trente"},
{731,"sept cent trente et un"},
{732,"sept cent trente-deux"},
{733,"sept cent trente-trois"},
{734,"sept cent trente-quatre"},
{735,"sept cent trente-cinq"},
{736,"sept cent trente-six"},
{737,"sept cent trente-sept"},
{738,"sept cent trente-huit"},
{739,"sept cent trente-neuf"},
{740,"sept cent quarante"},
{741,"sept cent quarante et un"},
{742,"sept cent quarante-deux"},
{743,"sept cent quarante-trois"},
{744,"sept cent quarante-quatre"},
{745,"sept cent quarante-cinq"},
{746,"sept cent quarante-six"},
{747,"sept cent quarante-sept"},
{748,"sept cent quarante-huit"},
{749,"sept cent quarante-neuf"},
{750,"sept cent cinquante"},
{751,"sept cent cinquante et un"},
{752,"sept cent cinquante-deux"},
{753,"sept cent cinquante-trois"},
{754,"sept cent cinquante-quatre"},
{755,"sept cent cinquante-cinq"},
{756,"sept cent cinquante-six"},
{757,"sept cent cinquante-sept"},
{758,"sept cent cinquante-huit"},
{759,"sept cent cinquante-neuf"},
{760,"sept cent soixante"},
{761,"sept cent soixante et un"},
{762,"sept cent soixante-deux"},
{763,"sept cent soixante-trois"},
{764,"sept cent soixante-quatre"},
{765,"sept cent soixante-cinq"},
{766,"sept cent soixante-six"},
{767,"sept cent soixante-sept"},
{768,"sept cent soixante-huit"},
{769,"sept cent soixante-neuf"},
{770,"sept cent soixante-dix"},
{771,"sept cent soixante et onze"},
{772,"sept cent soixante-douze"},
{773,"sept cent soixante-treize"},
{774,"sept cent soixante-quatorze"},
{775,"sept cent soixante-quinze"},
{776,"sept cent soixante-seize"},
{777,"sept cent soixante-dix-sept"},
{778,"sept cent soixante-dix-huit"},
{779,"sept cent soixante-dix-neuf"},
{780,"sept cent quatre-vingts"},
{781,"sept cent quatre-vingt-un"},
{782,"sept cent quatre-vingt-deux"},
{783,"sept cent quatre-vingt-trois"},
{784,"sept cent quatre-vingt-quatre"},
{785,"sept cent quatre-vingt-cinq"},
{786,"sept cent quatre-vingt-six"},
{787,"sept cent quatre-vingt-sept"},
{788,"sept cent quatre-vingt-huit"},
{789,"sept cent quatre-vingt-neuf"},
{790,"sept cent quatre-vingt-dix"},
{791,"sept cent quatre-vingt-onze"},
{792,"sept cent quatre-vingt-douze"},
{793,"sept cent quatre-vingt-treize"},
{794,"sept cent quatre-vingt-quatorze"},
{795,"sept cent quatre-vingt-quinze"},
{796,"sept cent quatre-vingt-seize"},
{797,"sept cent quatre-vingt-dix-sept"},
{798,"sept cent quatre-vingt-dix-huit"},
{799,"sept cent quatre-vingt-dix-neuf"},
                {800," huit cents" },
                {801,"huit cent un"},
{802,"huit cent deux"},
{803,"huit cent trois"},
{804,"huit cent quatre"},
{805,"huit cent cinq"},
{806,"huit cent six"},
{807,"huit cent sept"},
{808,"huit cent huit"},
{809,"huit cent neuf"},
{810,"huit cent dix"},
{811,"huit cent onze"},
{812,"huit cent douze"},
{813,"huit cent treize"},
{814,"huit cent quatorze"},
{815,"huit cent quinze"},
{816,"huit cent seize"},
{817,"huit cent dix-sept"},
{818,"huit cent dix-huit"},
{819,"huit cent dix-neuf"},
{820,"huit cent vingt"},
{821,"huit cent vingt et un"},
{822,"huit cent vingt-deux"},
{823,"huit cent vingt-trois"},
{824,"huit cent vingt-quatre"},
{825,"huit cent vingt-cinq"},
{826,"huit cent vingt-six"},
{827,"huit cent vingt-sept"},
{828,"huit cent vingt-huit"},
{829,"huit cent vingt-neuf"},
{830,"huit cent trente"},
{831,"huit cent trente et un"},
{832,"huit cent trente-deux"},
{833,"huit cent trente-trois"},
{834,"huit cent trente-quatre"},
{835,"huit cent trente-cinq"},
{836,"huit cent trente-six"},
{837,"huit cent trente-sept"},
{838,"huit cent trente-huit"},
{839,"huit cent trente-neuf"},
{840,"huit cent quarante"},
{841,"huit cent quarante et un"},
{842,"huit cent quarante-deux"},
{843,"huit cent quarante-trois"},
{844,"huit cent quarante-quatre"},
{845,"huit cent quarante-cinq"},
{846,"huit cent quarante-six"},
{847,"huit cent quarante-sept"},
{848,"huit cent quarante-huit"},
{849,"huit cent quarante-neuf"},
{850,"huit cent cinquante"},
{851,"huit cent cinquante et un"},
{852,"huit cent cinquante-deux"},
{853,"huit cent cinquante-trois"},
{854,"huit cent cinquante-quatre"},
{855,"huit cent cinquante-cinq"},
{856,"huit cent cinquante-six"},
{857,"huit cent cinquante-sept"},
{ 858,"huit cent cinquante-huit"},
{859,"huit cent cinquante-neuf"},
{860,"huit cent soixante"},
{861,"huit cent soixante et un"},
{862,"huit cent soixante-deux"},
{863,"huit cent soixante-trois"},
{864,"huit cent soixante-quatre"},
{865,"huit cent soixante-cinq"},
{866,"huit cent soixante-six"},
{867,"huit cent soixante-sept"},
{868,"huit cent soixante-huit"},
{869,"huit cent soixante-neuf"},
{870,"huit cent soixante-dix"},
{871,"huit cent soixante et onze"},
{872,"huit cent soixante-douze"},
{873,"huit cent soixante-treize"},
{874,"huit cent soixante-quatorze"},
{875,"huit cent soixante-quinze"},
{876,"huit cent soixante-seize"},
{877,"huit cent soixante-dix-sept"},
{878,"huit cent soixante-dix-huit"},
{879,"huit cent soixante-dix-neuf"},
{880,"huit cent quatre-vingts"},
{881,"huit cent quatre-vingt-un"},
{882,"huit cent quatre-vingt-deux"},
{883,"huit cent quatre-vingt-trois"},
{884,"huit cent quatre-vingt-quatre"},
{885,"huit cent quatre-vingt-cinq"},
{886,"huit cent quatre-vingt-six"},
{887,"huit cent quatre-vingt-sept"},
{888,"huit cent quatre-vingt-huit"},
{889,"huit cent quatre-vingt-neuf"},
{890,"huit cent quatre-vingt-dix"},
{891,"huit cent quatre-vingt-onze"},
{892,"huit cent quatre-vingt-douze"},
{893,"huit cent quatre-vingt-treize"},
{894,"huit cent quatre-vingt-quatorze"},
{895,"huit cent quatre-vingt-quinze"},
{896,"huit cent quatre-vingt-seize"},
{897,"huit cent quatre-vingt-dix-sept"},
{898,"huit cent quatre-vingt-dix-huit"},
{899,"huit cent quatre-vingt-dix-neuf"},

                {900," neuf cents"},
                {901,"neuf cent un"},
{902,"neuf cent deux"},
{903,"neuf cent trois"},
{904,"neuf cent quatre"},
{905,"neuf cent cinq"},
{906,"neuf cent six"},
{907,"neuf cent sept"},
{908,"neuf cent huit"},
{909,"neuf cent neuf"},
{910,"neuf cent dix"},
{911,"neuf cent onze"},
{912,"neuf cent douze"},
{913,"neuf cent treize"},
{914,"neuf cent quatorze"},
{915,"neuf cent quinze"},
{916,"neuf cent seize"},
{917,"neuf cent dix-sept"},
{918,"neuf cent dix-huit"},
{919,"neuf cent dix-neuf"},
{920,"neuf cent vingt"},
{921,"neuf cent vingt et un"},
{922,"neuf cent vingt-deux"},
{923,"neuf cent vingt-trois"},
{924,"neuf cent vingt-quatre"},
{925,"neuf cent vingt-cinq"},
{926,"neuf cent vingt-six"},
{927,"neuf cent vingt-sept"},
{928,"neuf cent vingt-huit"},
{929,"neuf cent vingt-neuf"},
{930,"neuf cent trente"},
{931,"neuf cent trente et un"},
{932,"neuf cent trente-deux"},
{933,"neuf cent trente-trois"},
{934,"neuf cent trente-quatre"},
{935,"neuf cent trente-cinq"},
{936,"neuf cent trente-six"},
{937,"neuf cent trente-sept"},
{938,"neuf cent trente-huit"},
{939,"neuf cent trente-neuf"},
{940,"neuf cent quarante"},
{941,"neuf cent quarante et un"},
{942,"neuf cent quarante-deux"},
{943,"neuf cent quarante-trois"},
{944,"neuf cent quarante-quatre"},
{945,"neuf cent quarante-cinq"},
{946,"neuf cent quarante-six"},
{947,"neuf cent quarante-sept"},
{948,"neuf cent quarante-huit"},
{949,"neuf cent quarante-neuf"},
{950,"neuf cent cinquante"},
{951,"neuf cent cinquante et un"},
{952,"neuf cent cinquante-deux"},
{953,"neuf cent cinquante-trois"},
{954,"neuf cent cinquante-quatre"},
{955,"neuf cent cinquante-cinq"},
{956,"neuf cent cinquante-six"},
{957,"neuf cent cinquante-sept"},
{958,"neuf cent cinquante-huit"},
{959,"neuf cent cinquante-neuf"},
{960,"neuf cent soixante"},
{961,"neuf cent soixante et un"},
{962,"neuf cent soixante-deux"},
{963,"neuf cent soixante-trois"},
{964,"neuf cent soixante-quatre"},
{965,"neuf cent soixante-cinq"},
{966,"neuf cent soixante-six"},
{967,"neuf cent soixante-sept"},
{968,"neuf cent soixante-huit"},
{969,"neuf cent soixante-neuf"},
{970,"neuf cent soixante-dix"},
{971,"neuf cent soixante et onze"},
{972,"neuf cent soixante-douze"},
{973,"neuf cent soixante-treize"},
{974,"neuf cent soixante-quatorze"},
{975,"neuf cent soixante-quinze"},
{976,"neuf cent soixante-seize"},
{977,"neuf cent soixante-dix-sept"},
{978,"neuf cent soixante-dix-huit"},
{979,"neuf cent soixante-dix-neuf"},
{980,"neuf cent quatre-vingts"},
{981,"neuf cent quatre-vingt-un"},
{982,"neuf cent quatre-vingt-deux"},
{983,"neuf cent quatre-vingt-trois"},
{984,"neuf cent quatre-vingt-quatre"},
{985,"neuf cent quatre-vingt-cinq"},
{986,"neuf cent quatre-vingt-six"},
{987,"neuf cent quatre-vingt-sept"},
{988,"neuf cent quatre-vingt-huit"},
{989,"neuf cent quatre-vingt-neuf"},
                {990," neuf cent quatre-vingt-dix"},

                {991," neuf cent quatre-vingt-onze"},

                {992," neuf cent quatre-vingt-douze"},

                {993," neuf cent quatre-vingt-treize"},

                {994," neuf cent quatre-vingt-quatorze"},

                {995," neuf cent quatre-vingt-quinze"},

                {996," neuf cent quatre-vingt-seize"},

                {997, "neuf cent quatre-vingt-dix-sept"},

                {998," neuf cent quatre-vingt-dix-huit"},

                {999,"neuf cent quatre-vingt-dix-neuf" } };
            if (i.ToString().Length <= 3) return dictionary[i];
            else{
                int w = int.Parse(i.ToString().Substring(0, i.ToString().Length - 3));
                int r = int.Parse(i.ToString().Substring(i.ToString().Length - 3, 3));
                return ((w!=1) ? dictionary[w].Trim() : "") + " mille " + dictionary[r].Trim();
            }
        } 
    }
}
