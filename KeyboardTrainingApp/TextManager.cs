using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardTrainingApp
{

   public class TextManager
    {
        private Dictionary<string, List<string>> LearningTexts;
        private Dictionary<string, List<string>> TrainingTexts;
        public TextManager()
        {
            LearningTexts = new Dictionary<string, List<string>>();
            LearningTexts["Russian"] = new List<string>()
        {
            "каждый из нас понимает очевидную вещь: выбранный нами инновационный путь влечет за собой процесс внедрения и модернизации как самодостаточных, " +
            "так и внешне зависимых концептуальных решений. С другой стороны, курс на социально-ориентированный национальный проект прекрасно подходит для " +
            "реализации укрепления моральных ценностей. банальные, но неопровержимые выводы, а также ключевые особенности структуры проекта в равной степени " +
            "предоставлены сами себе.",

            "в своём стремлении улучшить пользовательский опыт мы упускаем, что элементы политического процесса, превозмогая сложившуюся непростую " +
            "экономическую ситуацию, рассмотрены исключительно в разрезе маркетинговых и финансовых предпосылок. значимость этих проблем настолько очевидна," +
            " что реализация намеченных плановых заданий выявляет срочную потребность приоретизации разума над эмоциями.",

            "тело человека на две трети состоит из воды. Особенно богаты водой ткани молодого организма. с возрастом ее количество постепенно уменьшается: " +
            "так, например, в теле трехмесячного плода — 95 процентов воды, пятимесячного — 85, новорожденного ребенка — 70 и взрослого человека — около 65 процентов. " +
            "в связи с этим, одной из причин старения организма ученые считают понижение способности коллоидных веществ тела, особенно белков, связывать большие количества воды.",

            "в москве, в большом строченовском переулке, стиснутый современными зданиями, притаился двухэтажный деревянный дом, " +
            "в котором в 1912 году поселился Сергей Есенин. Отсюда началось «освоение» им Москвы. вскоре он сможет назвать себя московским озорным гулякой " +
            "и признаться: я люблю этот город вязевый. к сожалению, вязов на московских бульварах с тех дней значительно поубавилось. теперь все больше клены, тополя да березы.",

            "Первая жена поэта, Анна Изряднова, вспоминала о жизни Сергея в тот период: Настроение было у него упадочное — он поэт, никто не хочет этого понять, " +
            "редакции не принимают в печать, отец журит, что занимается не делом, надо работать. Слыл за передового, посещал собрания, " +
            "распространял нелегальную литературу. На книги набрасывался, все свободное время читал, все свое жалованье тратил на книги, журналы, нисколько не думал, как жить.",

            "Объединяя общины, племена, а затем и народы, мужчины создавали огромные империи и государства. Научные открытия, совершенные сильной половиной " +
            "человечества, до неузнаваемости преобразили современную жизнь. Отправляясь в путешествия и покоряя все новые и новые земли, " +
            "мужчины сумели расширить представления о мире до границ целой планеты.",

            "Рыба фугу — легенда японской кухни. Это очень знаменитое, дорогое и опасное блюдо. Некоторые части этой рыбы содержат яд. В одной рыбке яда хватит на то, чтобы убить 30-40 человек. " +
            "Её готовят преимущественно в Японии. Повар подаёт фугу сам, начиная с менее ядовитых частей. Он должен внимательно следить за состоянием клиентов, " +
            "чтобы не дать смертельную дозу. При употреблении фугу человек перестаёт чувствовать сначала ноги и руки, затем голову.",

            "Времена меняются, приходят новые поколения, у которых, казалось бы, всё не такое, как у прежних: вкусы, интересы, жизненные цели. " +
            "Но трудноразрешимые личные вопросы между тем почему-то остаются неизменными. Нынешних подростков, как и их родителей в своё время, " +
            "волнует всё то же: как обратить на себя внимание того, кто тебе нравится? Как отличить увлечение от настоящей любви?",

            "Место матери в нашей жизни особое, исключительное. Мы всегда несем ей свою радость и боль и находим понимание. " +
            "Материнская любовь окрыляет, придает силы, вдохновляет на подвиг. В сложных жизненных обстоятельствах мы всегда вспоминаем маму.",

            "Этот выбор мы делаем уже в детстве, когда выбираем друзей, учимся строить отношения с ровесниками, играть. " +
            "Но большинство важнейших решений, определяющих жизненный путь, мы всё-таки принимаем в юности. Как считают учёные, " +
            "вторая половина второго десятилетия жизни – самый ответственный период. Именно в это время человек, как правило, " +
            "выбирает самое главное и на всю жизнь: ближайшего друга, круг основных интересов, профессию."
        };

            LearningTexts["English"] = new List<string>()
        {
            "The red glint of paint sparkled under the sun. He had dreamed of owning this car since he was ten, " +
            "and that dream had become a reality less than a year ago. It was his baby and he spent hours caring for it, " +
            "pampering it, and fondling over it. She knew this all too well, and that's exactly why she had taken a sludge hammer to it.",

            "It was always the Monday mornings. It never seemed to happen on Tuesday morning, Wednesday morning, " +
            "or any other morning during the week. But it happened every Monday morning like clockwork. " +
            "He mentally prepared himself to once again deal with what was about to happen, " +
            "but this time he also placed a knife in his pocket just in case.",

            "Betty decided to write a short story and she was sure it was going to be amazing. " +
            "She had already written it in her head and each time she thought about it she grinned from ear to ear knowing how wonderful it would be. " +
            "She could imagine the accolades coming in and the praise she would receive for creating such a wonderful piece.",

            "It probably seemed trivial to most people, but it mattered to Tracey. " +
            "She wasn't sure why it mattered so much to her, but she understood deep within her being that it mattered to her. " +
            "So for the 365th day in a row, Tracey sat down to eat pancakes for breakfast.",

            "Bryan had made peace with himself and felt comfortable with the choices he made. " +
            "This had made all the difference in the world. Being alone no longer bothered him and this was " +
            "essential since there was a good chance he might spend the rest of his life alone in a cell.",

            "The time to take action was now. All three men knew in their hearts this was the case, " +
            "yet none of them moved a muscle to try. They were all watching and waiting for one of the others to make the " +
            "first move so they could follow a step or two behind and help. The situation demanded a leader and all three men were followers.",

            "The chair sat in the corner where it had been for over 25 years. The only difference was there was someone actually sitting in it. " +
            "How long had it been since someone had done that? Ten years or more he imagined. Yet there was no denying the presence in the chair now.",

            "I haven't bailed on writing. Look, I'm generating a random paragraph at this very moment in " +
            "an attempt to get my writing back on track. I am making an effort. I will start writing consistently again!",

            "The alarm went off and Jake rose awake. Rising early had become a daily ritual, one that he could not fully explain. " +
            "From the outside, it was a wonder that he was able to get up so early each morning for someone who " +
            "had absolutely no plans to be productive during the entire day.",

            "Her breath exited her mouth in big puffs as if she were smoking a cigarette. " +
            "The morning dew had made her clothes damp and she shivered from the chill in the air. " +
            "There was only one thing that could get her up and out this early in the morning."
        };
            TrainingTexts = new Dictionary<string, List<string>>();
            TrainingTexts["Russian"] = new List<string>()
            {
                "Все что ни делается - к лучшему, но худшим из способов.",
                "В любом из нас спит гений, и с каждым днем все крепче.",
                "Все чаще вокруг слышится некультурный мат, и все реже - культурный.",
                "Всем знакам внимания предпочитала денежные.",
                "Больной нуждается в уходе врача, и, чем дальше уйдет врач, тем лучше.",
                "Гнетущую тишину нарушало только всеобщее молчание.",
                "Внедрить - внедрили, а вывнедрить - забыли.",
                "В детстве каждый новый день - находка, в старости - подарок.",
                "Бойцу невидимого фронта - невидимую геройскую звезду!",
                "В жизни все бывает, но не всем достается.",
                "Время выхода из лабиринта зависит от количества извилин.",
                "В жизни всякое бывает, но с годами все реже.",
                "Будь великодушен - прости подчиненным свои ошибки.",
                "В приметы не верю, но совпадения уже надоели!",
                "Берегите каждую потерянную минуту.",
                "Будь как дома, но в холодильник не лазь!",
                "Внедрить - внедрили, а вывнедрить - забыли.",
                "Выпили меньше, чем больше половины.",
                "Выход из безвыходного положения там же, где и вход в него.",
                "В гостях хорошо, а в лифте неудобно.",
                "Всегда прощайте своих врагов: ничто не раздражает их так сильно.",
                "Все хотят хорошо провести время, но его не проведешь.",
                "Грех впадать в уныние, когда есть другие грехи.",
                "В борьбе со здравым смыслом победа будет за нами!"
            };
            TrainingTexts["English"] = new List<string>()
            {
                "I call architecture frozen music.",
                "It is not good to listen to flattery.",
                "Having nothing, nothing can he lose.",
                "The undiscovered country from whose bourn no traveler returns.",
                "Don't put all your eggs in one basket.",
                "Buy land, they're not making it anymore.",
                "It is a good thing for an uneducated man to read books of quotations.",
                "The hardest thing to understand in the world is the income tax.",
                "It is not good to listen to flattery.",
                "For I can raise no money by vile means.",
                "What is great in man is that he is a bridge and not a goal.",
                "It is strange to be known so universally and yet to be so lonely.",
                "A bird in the hand is worth two in the bush.",
                "One touch of nature makes the whole world kin.",
                "Solitary trees, if they grow at all, grow strong.",
                "He is now rising from affluence to poverty.",
                "Life is either a great adventure or nothing.",
                "I was adored once too.",
                "Love is a smoke made with the fume of sighs.",
                "To improve is to change - to be perfect is to change often.",
                "Character is formed in the stormy billows of the world.",
                "Children have the qualities of the parents.",
                "Nothing is more fearful than imagination without taste.",
                "Some are made modest by great praise, others insolent.",
                "The soul that sees beauty may sometimes walk alone."
            };
            TrainingTexts["Sharp"] = new List<string>()
            {
                "Dictionary<string, string> dict1 = new Dictionary<string, string> ",
                "var sortedList = myList.OrderBy(x => x).ToList();",
                "var merged = dict1.Concat(dict2).ToDictionary(x => x.Key, x => x.Value);",
                "foreach (var item in dict2)",
                "dict1[item.Key] = item.Value;",
                "var merged2 = dict1.Union(dict2).ToDictionary(x => x.Key, x => x.Value);",
                "string[] lines = File.ReadAllLines('/path/to/data.csv');",
                "string[] fields = line.Split(',');",
                "Console.WriteLine($'{fields[0]} - {fields[1]} - {fields[2]}');",
                "List<int> myList = new List<int> {2, 5, 6};",
                "var scaledList = myList.Select(item => 2 * item).ToList();",
                "Stopwatch stopwatch = new Stopwatch();",
                "public static void Main(string[] args)",
                "bool isSamePlayer = player1.Length == player3.Length;",
                "string filePath = 'log.txt';",
                "File.Copy(sourceFile, destinationFile);",
                "Console.WriteLine($'File not found: { ex.FileName}');",
                "ThreadPool.QueueUserWorkItem(PrintNumbers);",
                "CancellationTokenSource cts = new CancellationTokenSource();",
                "Task.Run(() => PrintNumbers(cts.Token), cts.Token);"
            };
            TrainingTexts["CPlusPlus"] = new List<string>()
            {
                "shuffle(arr.begin(), arr.end(), default_random_engine(seed));",
                "cout << 'Shuffled array:';",
                "for (int ele: arr)",
                "#include <bits/stdc++.h>",
                "vector <int> vec = {1, 2, 3, 4, 5};",
                "int size = sizeof(arr)/sizeof(arr[0]);",
                "int deleteElementy(int arr[], int size, int element)",
                "for (auto it = begin(vec); it != end(vec); it++)",
                "printf('%d:%0d:%d',tmp->hour,tmp->min,tmp->sec);",
                "#include<stdio.h>",
                "return ((year%4==0) && (year%100 !=0))||(year%400==0);",
                "TreeNode *pn = (TreeNode *) malloc(sizeof(TreeNode));",
                "pn->left = insertTree(pn->left, data);",
                "char* str_append(char* string, char* append)",
                "std::cin.getline(userString, 300);",
                "array1[count1] = 0;",
                "grid[x][y][0] = ' ';",
                "printf(' .0.1.2.Y');",
                "if(grid[x][y][0] == ch)",
                "if(i >= 3 && i <= 5)"
            };
            TrainingTexts["Python"] = new List<string>()
            {
                "dict_method_1 = dict(zip(keys_list, values_list))",
                "for key, value in items_tuples:",
                "def merge(*args, missing_val = None):",
                "max_length = max([len(lst) for lst in args])",
                "result.append([args[k][i] if i < len(args[k]) else missing",
                "from operator import itemgetter",
                "my_list = sorted(my_list, key=len)",
                "mapped_dict = dict(zip(itr, map(fn, itr)))",
                "print(f'{price_val:.2f}')",
                "date_val = datetime.utcnow()",
                "return len(s.encode('utf-8'))",
                "exists = os.path.isfile('/path/to/file')",
                "csv_reader = csv.reader(my_data, delimiter=",")",
                "all_devices = np.add(ethernet_devices, usb_devices)",
                "column_names = ['id', 'color', 'style']",
                "for i in range(size):",
                "for a, b in zip(penguins_87, penguins_59):",
                "print('My name is ', end='')",
                "while i < len(my_string):",
                "split_string(my_string)"
            };
            TrainingTexts["Pascal"] = new List<string>()
            {
                "writeln('Hello, World!');",
                "area := sqrt(s * (s - a)*(s-b)*(s-c));",
                "if (no > 0) then",
                "var a,b,c,e,f,right: integer; d:real;",
                "c:=random(200)+1;",
                "type aaa=array[1..40,1..12] of char;",
                "if ReturnCode <> OK then begin",
                "Restore('TcpFSend: ',Note.SendTurnCode);",
                "DoubleSubtract (ClockTime, StartingTime, Difference);",
                "function max(num1, num2: integer): integer;",
                "writeln( 'Max value is : ', ret );",
                "constructor Rectangle.create(l, w: integer);",
                "r1:= Rectangle.create(3, 7);",
                "writeln('appendstr( str3, str1) :  ', str3 );",
                "function RectangleArea( length, width: real): real;",
                "description: ^string;",
                "Student.s_addr := 'United States of America';",
                "Write(f,Student);",
                "while not eof(f) do",
                "assign(f, 'students.dat');"
            };
        }

        public string GetRandomTraining(string language)
        {
            List<string> selectedTexts = TrainingTexts[language];
            return selectedTexts[new Random().Next(0, selectedTexts.Count)];
        }
        public string GetRandomText(string language)
        {
            List<string> selectedTexts = LearningTexts[language];
            return selectedTexts[new Random().Next(0, selectedTexts.Count)];
        }
    }

}
