using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace KinectSpecialties
{
    public partial class MainForm : Form
    {
        private string nowSelected = "Nothing";
        private string lSelectedText = "None";
        private Dictionary<string, string> criteriaList = new Dictionary<string, string>
        {
            // === ІНФОРМАЦІЙНІ ТЕХНОЛОГІЇ ТА БЕЗПЕКА ===
            ["121"] = "Інженерія програмного забезпечення - Програмування, розробка та тестування софту (Software)",
            ["122"] = "Комп'ютерні науки - Алгоритми, штучний інтелект, бази даних та аналітика",
            ["123"] = "Комп'ютерна інженерія - Проєктування комп'ютерних систем, архітектури та мереж (Hardware)",
            ["125"] = "Кібербезпека - Захист інформації від хакерів, криптографія та мережева безпека",

            // === АВІАЦІЯ ТА ТРАНСПОРТ ===
            ["272"] = "Авіаційний транспорт - Пілотування, управління повітряним рухом та обслуговування літаків",
            ["134"] = "Авіаційна та ракетно-космічна техніка - Конструювання та створення літаків, ракет і дронів",
            ["173"] = "Авіоніка - Електронні системи, навігація та прилади на борту літальних апаратів",
            ["275"] = "Транспортні технології - Логістика, організація перевезень та управління на транспорті",
            ["274"] = "Автомобільний транспорт - Технічне обслуговування, ремонт та експлуатація автомобілів",

            // === ІНЖЕНЕРІЯ ТА ТЕХНОЛОГІЇ ===
            ["151"] = "Автоматизація та комп'ютерно-інтегровані технології - Робототехніка, програмування мікроконтролерів",
            ["172"] = "Електронні комунікації та радіотехніка - Телекомунікації, мобільний зв'язок та радіоелектроніка",
            ["141"] = "Електроенергетика та електромеханіка - Виробництво, розподіл та управління електроенергією",
            ["161"] = "Хімічні технології та інженерія - Створення нових матеріалів, переробка палива та хімічний аналіз",
            ["191"] = "Архітектура та містобудування - Проєктування будівель, споруд та дизайну міського середовища",
            ["193"] = "Геодезія та землеустрій - Картографія, кадастр, 3D-моделювання та вимірювання землі",

            // === ЕКОНОМІКА, БІЗНЕС ТА УПРАВЛІННЯ ===
            ["051"] = "Економіка - Аналіз макро- та мікроекономічних процесів, бізнес-планування",
            ["073"] = "Менеджмент - Управління підприємствами, командами, проєктами та бізнес-процесами",
            ["075"] = "Маркетинг - Дослідження ринку, реклама, PR, SMM та просування брендів",
            ["072"] = "Фінанси, банківська справа та страхування - Управління грошовими потоками, інвестиції, банки",
            ["071"] = "Облік і оподаткування - Бухгалтерський облік, аудит та податкова звітність",

            // === ГУМАНІТАРНІ ТА СУСПІЛЬНІ НАУКИ ===
            ["081"] = "Право - Юриспруденція, законодавство, адвокатура та правовий захист",
            ["262"] = "Правоохоронна діяльність - Забезпечення громадської безпеки та правопорядку",
            ["291"] = "Міжнародні відносини - Дипломатія, міжнародна політика та суспільні комунікації",
            ["061"] = "Журналістика - Створення медіаконтенту, робота з інформацією, телебаченням та ЗМІ",
            ["242"] = "Туризм і рекреація - Організація подорожей, готельний та туристичний бізнес"
        };
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lSelectedText = lSelected.Text;

            var sp1 = new Button();
            var sp2 = new Button();
            var sp3 = new Button();

            sp1.BackColor = Color.LightCyan;
            sp1.Size = new Size(161, 42);
            sp1.Text = "Хочу працювати з автомобілями";
            sp1.UseVisualStyleBackColor = false;

            sp2.BackColor = Color.LightCyan;
            sp2.Size = new Size(161, 42);
            sp2.Text = "Я хочу працювати з дому та багато заробляти";
            sp2.UseVisualStyleBackColor = false;

            sp3.BackColor = Color.LightCyan;
            sp3.Size = new Size(161, 42);
            sp3.Text = "Я люблю робити щось своїми руками";
            sp3.UseVisualStyleBackColor = false;


            sp1.Click += allBtn_Click;
            sp2.Click += allBtn_Click;
            sp3.Click += allBtn_Click;


            flowLayoutPanel1.Controls.Add(sp1);
            flowLayoutPanel1.Controls.Add(sp2);
            flowLayoutPanel1.Controls.Add(sp3);
            nowSelected = flowLayoutPanel1.Controls[0].Text;
            lSelected.Text = lSelectedText + nowSelected;
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            var b = new Button();
            b.BackColor = Color.LightCyan;
            b.Size = new Size(161, 42);
            b.Text = tbDes.Text;
            b.UseVisualStyleBackColor = false;
            b.Click += allBtn_Click;
            flowLayoutPanel1.Controls.Add(b);
            nowSelected = tbDes.Text;
            lSelected.Text = $"{lSelectedText} {nowSelected}";
            tbDes.Text = "";
        }

        private async void allBtn_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                nowSelected = clickedButton.Text;
                lSelected.Text = $"{lSelectedText} {nowSelected}";
            }
        }

        private async void btnSendRequest_Click(object sender, EventArgs e)
        {
            await SendRequestAsync();
        }

        private async Task SendRequestAsync()
        {
            var apiKey = "-";

            using var client = new HttpClient();
            if (!string.IsNullOrEmpty(apiKey))
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
            }


            var requestBody = new
            {
                model = "typesafe/jev-1.13",
                state = "Incoming text from user about specialites: " + nowSelected,
                questions = new
                {
                    q = new
                    {
                        type = "choice",
                        instructions = "Which specialty is most suitable for the user?",
                        criteria = criteriaList
                    }
                }
            };

            var content = new StringContent(
                JsonSerializer.Serialize(requestBody),
                Encoding.UTF8,
                "application/json"
            );

            var response = await client.PostAsync("https://openrouter.ai/api/v1/systemone", content);
            var responseJson = await response.Content.ReadAsStringAsync();

            var j = JsonNode.Parse(responseJson);
            var choice = j?["answers"]?["q"]?["choice"]?.ToString();
            var prob = j?["answers"]?["q"]?["probabilities"]?.AsObject();
            if (prob != null)
            {
                var sortedProbabilities = prob.Select(p => new { Code = p.Key, Probability = (double)p.Value }).OrderByDescending(p => p.Probability).ToList();
                int count = 0;
                Dictionary<int, Label> n = new Dictionary<int, Label>
                {
                    [1] = l1Best,
                    [2] = l2Best,
                    [3] = l3Best,
                    [4] = l4Best,
                    [5] = l5Best,
                    [6] = l6Best,
                    [7] = l7Best,
                    [8] = l8Best,
                    [9] = l9Best
                };
                foreach (var item in sortedProbabilities.Take(10))
                {
                    count++;
                    string name = criteriaList.ContainsKey(item.Code) ? criteriaList[item.Code] : "Not found";
                    if (item.Probability == 0 || count == 10)
                        break;

                    n[count].Text = $"{item.Code} {name}: {item.Probability * 100:F0}%";
                    n[count].Visible = true;
                }
            }
        }
    }
}
