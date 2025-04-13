using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texst1 = "После многолетних исследований ученые обнаружили тревожную тенденцию в вырубке лесов Амазонии. Анализ данных показал, что основной участник разрушения лесного покрова – человеческая деятельность. За последние десятилетия рост объема вырубки достиг критических показателей. Главными факторами, способствующими этому, являются промышленные рубки, производство древесины, расширение сельскохозяйственных угодий и незаконная добыча древесины. Это приводит к серьезным экологическим последствиям, таким как потеря биоразнообразия, ухудшение климата и угроза вымирания многих видов животных и растений.";
            var test1 = new Blue_1(texst1);
            test1.Review();
            System.Console.WriteLine(test1.ToString());
            Console.WriteLine();

            string texst2 = "Двигатель самолета – это сложная инженерная конструкция, обеспечивающая подъем, управление и движение в воздухе. Он состоит из множества компонентов, каждый из которых играет важную роль в общей работе механизма. Внутреннее устройство двигателя включает в себя компрессор, камеру сгорания, турбину и системы управления и охлаждения. Принцип работы основан на воздушно-топливной смеси, которая подвергается сжатию, воспламенению и расширению, обеспечивая движение воздушного судна.";
            var test2 = new Blue_1(texst2);
            test2.Review();
            System.Console.WriteLine(test2.ToString());
            Console.WriteLine();

            string texst3 = "1 июля 2015 года Греция объявила о дефолте по государственному долгу, став первой развитой страной в истории, которая не смогла выплатить свои долговые обязательства в полном объеме. Сумма дефолта составила порядка 1,6 миллиарда евро. Этому предшествовали долгие переговоры с международными кредиторами, такими как Международный валютный фонд(МВФ), Европейский центральный банк(ЕЦБ) и Европейская комиссия(ЕК), о программах финансовой помощи и реструктуризации долга.Основными причинами дефолта стали недостаточная эффективность реформ, направленных на улучшение финансовой стабильности страны, а также политическая нестабильность, что вызвало потерю доверия со стороны международных инвесторов и кредиторов. Последствия дефолта оказались глубокими и долгосрочными: сокращение кредитного рейтинга страны, увеличение затрат на заемный капитал, рост стоимости заимствований и утрата доверия со стороны международных инвесторов.";
            var test3 = new Blue_1(texst3);
            test3.Review();
            System.Console.WriteLine(test3.ToString());
            Console.WriteLine();

            string tex1 = "После многолетних иследований ученые обнаружили после тревожную тенденцию в вырубке лесов Амазонии. Анализ данных показал, что основной участник разрушения лесного покрова – человеческая деятельность. За последние десятилетия рост объема вырубки достиг критических показателей. Главными факторами, способствующими этому, являются промышленные рубки, производство древесины, расширение сельскохозяйственных угодий и незаконная добыча древесины. Это приводит к серьезным экологическим последствиям после, таким как потеря биоразнообразия, ухудшение климата и угроза вымирания многих видов животных и растений после.";
            string del1 = "ос";
            var tes1 = new Blue_2(del1, tex1);
            tes1.Review();
            System.Console.WriteLine(tes1.ToString());
            Console.WriteLine();

            var tes3 = new Blue_3("William Shakespeare, widely regarded as one of the greatest writers in the English language, authored a total of 37 plays, along with numerous poems and sonnets. He was born in Stratford-upon-Avon, England, in 1564, and died in 1616. Shakespeare's most famous works, including \"Romeo and Juliet,\" \"Hamlet,\" \"Macbeth,\" and \"Othello,\" were written during the late 16th and early 17th centuries. \"Romeo and Juliet,\" a tragic tale of young love, was penned around 1595. \"Hamlet,\" one of his most celebrated tragedies, was written in the early 1600s, followed by \"Macbeth,\" a gripping drama exploring themes of ambition and power, around 1606. \"Othello,\" a tragedy revolving around jealousy and deceit, was also composed during this period, believed to be around 1603.");
            tes3.Review();
            Console.WriteLine(tes3.ToString());
            Console.WriteLine();

            var tes33 = new Blue_3("1 июля 2015 года Греция объявила о дефолте по государственному долгу, став первой развитой страной в истории, которая не смогла выплатить свои долговые обязательства в полном объеме.Сумма дефолта составила порядка 1, 6 миллиарда евро.Этому предшествовали долгие переговоры с международными кредиторами, такими как Международный валютный фонд(МВФ), Европейский центральный банк(ЕЦБ) и Европейская комиссия(ЕК), о программах финансовой помощи и реструктуризации долга.Основными причинами дефолта стали недостаточная эффективность реформ, направленных на улучшение финансовой стабильности страны, а также политическая нестабильность, что вызвало потерю доверия со стороны международных инвесторов и кредиторов.Последствия дефолта оказались глубокими и долгосрочными: сокращение кредитного рейтинга страны, увеличение затрат на заемный капитал, рост стоимости заимствований и утрата доверия со стороны международных инвесторов.");
            tes33.Review();
            Console.WriteLine(tes33.ToString());
            Console.WriteLine();

            var tes4 = new Blue_4("1 июля 2015 года Греция объявила о дефолте по государственному долгу, став первой развитой страной в истории, которая не смогла выплатить свои долговые обязательства в полном объеме.Сумма дефолта составила порядка 1, 6 миллиарда евро.Этому предшествовали долгие переговоры с международными кредиторами, такими как Международный валютный фонд(МВФ), Европейский центральный банк(ЕЦБ) и Европейская комиссия(ЕК), о программах финансовой помощи и реструктуризации долга.Основными причинами дефолта стали недостаточная эффективность реформ, направленных на улучшение финансовой стабильности страны, а также политическая нестабильность, что вызвало потерю доверия со стороны международных инвесторов и кредиторов.Последствия дефолта оказались глубокими и долгосрочными: сокращение кредитного рейтинга страны, увеличение затрат на заемный капитал, рост стоимости заимствований и утрата доверия со стороны международных инвесторов.");
            tes4.Review();
            Console.WriteLine(tes4.ToString());
            Console.WriteLine();

            var tes44 = new Blue_4("William Shakespeare, widely regarded as one of the greatest writers in the English language, authored a total of 37 plays, along with numerous poems and sonnets. He was born in Stratford-upon-Avon, England, in 1564, and died in 1616. Shakespeare's most famous works, including \"Romeo and Juliet,\" \"Hamlet,\" \"Macbeth,\" and \"Othello,\" were written during the late 16th and early 17th centuries. \"Romeo and Juliet,\" a tragic tale of young love, was penned around 1595. \"Hamlet,\" one of his most celebrated tragedies, was written in the early 1600s, followed by \"Macbeth,\" a gripping drama exploring themes of ambition and power, around 1606. \"Othello,\" a tragedy revolving around jealousy and deceit, was also composed during this period, believed to be around 1603.");
            tes44.Review();
            Console.WriteLine(tes44.ToString());
            Console.WriteLine();
        }
    }
}
