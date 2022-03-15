using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            timer1.Interval = 500; // 500 миллисекунд
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
        }
        void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Свойства и методы элемента управления Button:\n" +
                "1. Name-имя элемента по которому можно обращаться в коде\n" +
                "2. FlatStyle-определяет внешний вид элемента при наведении мыши и щелчке\n" +
                "3. Text-текст на элементе\n" +
                "4. Font-шрифт текста\n" +
                "5. Cursor-отображаемый курсор при его наведении на элемент\n" +
                "События элемента управления Button:\n" +
                "1. Click-происходит при щелчке элемента управления\n" +
                "2. MouseClick-возникает при щелчке мышью элемента\n" +
                "3. KeyDown-происходит в момент первого нажатия клавиши\n" +
                "4. Validating-возникает при проверке действительности элемента\n" +
                "5. Move-проиходит при перемещении элемента управления\n";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            label2.Text = "Свойства и методы элемента управления TabControl:\n" +
                "1. Name-имя элемента по которому можно обращаться в коде\n" +
                "2. Anchor-определяет грани контейнера, к которому привязан определённый элемент управления\n" +
                "3. Margin-определяет отступы между полями элементов\n" +
                "4. HotTrack-указывает, изменяется ли вид вкладок при наведении на них\n" +
                "5. TabPages-число страниц в TabControl\n" +
                "События элемента управления TabControl:\n" +
                "1. Click-происходит при щелчке элемента управления\n" +
                "2. Selected-происходит после выбора вкладки\n" +
                "3. DrowItem-происходит при необходимости прорисовать элемент/область\n" +
                "4. StyleChanged-событие возникает когда в Control изменяют стиль окна\n" +
                "5. Deselceted-просиходит при отмене выбора вкладки в качестве главной\n";
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            label2.Text = "Свойства и методы элемента управления TabControl:\n" +
                 "1. Name-имя элемента по которому можно обращаться в коде\n" +
                 "2. Anchor-определяет грани контейнера, к которому привязан определённый элемент управления\n" +
                 "3. Margin-определяет отступы между полями элементов\n" +
                 "4. HotTrack-указывает, изменяется ли вид вкладок при наведении на них\n" +
                 "5. TabPages-число страниц в TabControl\n" +
                 "События элемента управления TabControl:\n" +
                 "1. Click-происходит при щелчке элемента управления\n" +
                 "2. Selected-происходит после выбора вкладки\n" +
                 "3. DrowItem-происходит при необходимости прорисовать элемент/область\n" +
                 "4. StyleChanged-событие возникает когда в Control изменяют стиль окна\n" +
                 "5. Deselceted-просиходит при отмене выбора вкладки в качестве главной\n";
        }

        private void menuStripToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Text = "Свойства и методы элемента управления MenuStrip:\n" +
                "1. Name-имя элемента по которому можно обращаться в коде\n" +
                "2. BackColor-цвет фона элемента\n" +
                "3. Font-выбор шрифта\n"+
                "4. ForeColor-цвет для текста\n"+
                "5. Text-текст на элементе\n"+
                "События элемента управления MenuStrip:\n"+
                "1. Click-происходит при щелчке элемента управления\n" +
                "2. DragDrop-вызывается при завершении операции перетаскивания\n" +
                "3. Enter-происходит при входе в элемент управления\n" +
                "4. FontChanged-происходит при изменении значения свойства Font\n" +
                "5. GiveFeedback-вызывается при выполнении операции перетаскивания\n";
        }

        private void folderBrowserDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Text = "Свойства и методы элемента управления FolderBrowserDialog:\n"+
                "1. Name-имя элемента по которому можно обращаться в коде\n" +
                "2. BackgroundImage-картинка как фон\n" +
                "3. Checked-делает элемент отмеченным\n" +
                "4. RightToLeft-текст пишется справа налево\n" +
                "5. DropDownItems-элементы хранящиеся в выпадающем списке\n"+
                "События элемента управления FolderBrowserDialog:\n" +
                "1. Click-происходит при щелчке элемента управления\n" +
                "2. LocationChanged-происходит, если значение свойства Location было изменено\n" +
                "3. Disposed-возникает при удалении компонента путем вызова метода Dispose()" +
                "4. MouseClick-вызывается при щелчке мышью элемента управления\n" +
                "5. HelpRequest-происходит при нажатии пользователем кнопки Help в диалоговом окне.";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
                return;
        }

        private void saveFileDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Text = "Свойства и методы элемента управления SaveFileDialog:\n" +
                "1. Name-имя элемента по которому можно обращаться в коде\n" +
                "2. Options-получает значения для инициализации класса FileDialog\n" +
                "3. Tag-получает или задает объект, содержащий данные элемента управления\n" +
                "4. Title-возвращает или задает заголовок диалогового окна файла\n" +
                "5. Size-размер элемента:\n" +
                "События элемента управления SaveFileDialog:\n" +
                "1. Click-происходит при щелчке элемента управления\n" +
                "2. TextChanged-происходит при изменении слова текст\n" +
                "3. MouseEnter-возникает, когда курсор наводится над видимой частью элемента\n"+
                "4. DoubleClick-возникает при двойном щелчке данного элемента управления\n"+
                "5. MouseUp-возникает в момент отпускания кнопки мыши";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, textBox1.Text);
            MessageBox.Show("Файл сохранен");
        }

        private void openFileDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Text = "Свойства и методы элемента управления OpenFileDialog:\n" +
                "1. Name-имя элемента по которому можно обращаться в коде\n" +
                "2. Padding-внутренние отступы элемента\n" +
                "3. Visible-определяет будет ли элемент\n" +
                "4. Enabled-указывает, включен ли элемент управления\n" +
                "5. DisplayStyle-определяет, будет ли отрисовываться изображение и текст\n" +
                "События элемента управления OpenFileDialog:\n" +
                "1. Click-происходит при щелчке элемента управления\n" +
                "2. EnabledChanged-происходит при изменении допустимого размера элемента\n"+
                "3. Paint-происходит, когда для элмента требуется перерисовка\n" +
                "4. MouseDown-возникает в момент нажатия кнопки мыши\n" +
                "5. MouseHower-возникает, когда мышь остаётся неподвижной внутри элемента некоторое время";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);
            label2.Text = fileText;
            MessageBox.Show("Файл открыт");
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            label2.Text = "Свойства и методы элемента управления TextBox:\n" +
                "1. Name-имя элемента по которому можно обращаться в коде\n" +
                "2. Text-текст на элементе\n" +
                "3. AutoCompleteMode-задаёт поведение при заполнении текстом\n" +
                "4. Lines-строки текста\n" +
                "5. BorderStyle-указывает должны ли у поля быть границы\n" +
                "События элемента управления TextBox:\n" +
                "1. Click-происходит при щелчке элемента управления\n" +
                "2. TextChanged-возникает при изменении текста\n" +
                "3. SizeChanged-возникает при изменении размера элемента\n" +
                "4. DragOver-возникает, когда объект перетаскивается на элемент\n" +
                "5. KeyDown-происходит в момент первого нажатия клавиши";
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = "Свойства и методы элемента управления ComboBox:\n" +
                "1. Name-имя элемента по которому можно обращаться в коде\n" +
                "2. Text-текст на элементе\n" +
                "3. AutoCompleteMode-определяет как просиходит заполнение текста\n" +
                "4. DropDownStyle-управляет внешним видом и функционированием окна\n" +
                "5. Items-элементы в данном комбинированном окне\n" +
                "События элемента управления ComboBox:\n" +
                "1. Click-происходит при щелчке элемента управления\n" +
                "2. DropItem-просиходит при перерисовывании элемента или области\n" +
                "3. MouseDoubleClick-происходит при двойном щелчке мышью элемента\n" +
                "4. MarginChanged-возникает при изменении свойств Margin\n" +
                "5. MouseMove-возникает при наведении указателя мыши на компонент";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label2.Text = "Свойства и методы элемента управления Label:\n" +
                "1. Name-имя элемента по которому можно обращаться в коде\n" +
                "2. Text-текст на элементе\n" +
                "3. Location-координаты левого верхнего кгла элемента относительно его контейнера\n" +
                "4. Visible-определяет отображается или скрыт элемент\n" +
                "5. Size-размер элемента управления в px\n" +
                "События элемента управления Label:\n" +
                "1. Click-происходит при щелчке элемента управления\n" +
                "2. MouseDoubleClick-возникает при двойном щелчке мышью элемента\n" +
                "3. DragOver-возникает когда объект перетаскивается на элемент\n" +
                "4. Leave-возникает, когда элемент перестёт быть активным на форме\n" +
                "5. TextAlignChanged-возникает, когда изменяется значение свойства TextAlign";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Свойства и методы элемента управления CheckBox:\n" +
                "1. Name-имя элемента по которому можно обращаться в коде\n" +
                "2. Text-текст на элементе\n" +
                "3. CheckState-определяет состояние компонента\n" +
                "4. ThreeState-определяет возможность CheckBox использовать 3 состояния вместо 2ух\n" +
                "5. AutoChack-вызывает автоматическое изменение состояния флажка при его выборе\n" +
                "События элемента управления CheckBox:\n" +
                "1. Click-происходит при щелчке элемента управления\n" +
                "2. CheckedChanged-воникает при изменении свойств Check\n" +
                "3. Paint-происходит при перерисовки элемента\n" +
                "4. KeyPress-возникает, когда элемент находится в фокусе и пользоваетль нажимает и отпускает клавишу\n" +
                "5.CheckStateChanged-возникает при изменении свойства CheckState";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = "Свойства и методы элемента управления ListBox:\n" +
                "1. Name-имя элемента по которому можно обращаться в коде\n" +
                "2. Text-текст на элементе\n" +
                "3. BorderStyle-задаёт тип границы ListBox\n" +
                "4. Items-элементы списка\n" +
                "5. DataSource-указывает список, из которого элемент управления будет считывать элементы\n" +
                "События элемента управления ListBox:\n" +
                "1. Click-происходит при щелчке элемента управления\n" +
                "2. StyleChanged-возникает при изменении стиля окна\n" +
                "3. MeasureItem-происходит при необходимости расчёта высоты определённого элемента\n" +
                "4. ControlRemoved-происходит, когда из этого элемента удаляется другой\n" +
                "5. BackColorChanged-возникает при изменении значения свойства BackColor";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = "Свойства и методы элемента управления NumericUpDown:\n" +
                "1. Name-имя элемента по которому можно обращаться в коде\n" +
                "2. Hexadecimal-указывает должно ли значение числового поля быть в шестнадцатиричном формате\n" +
                "3. UpDownAlign-прижатие поля со стрелками по X\n" +
                "4. Maximum-максимальное число\n" +
                "5. Minimum-минимальное число\n" +
                "События элемента управления  NumericUpDown:\n" +
                "1. Click-происходит при щелчке элемента управления\n" +
                "2. Scroll-возникает при перемещении ползунка полосы\n" +
                "3. ValueChanged-происходит при изменении значения данного элемента\n" +
                "4. KeyUp-возникает в момент отпускания клавиши\n" +
                "5. Enter-происходит, когда элемент управления становится активным";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = "Свойства и методы элемента управления DateTimePicker:\n" +
                "1. Name-имя элемента по которому можно обращаться в коде\n" +
                "2. CalendarTitleBackColor-фоновый цвет заглавия календаря\n" +
                "3. ShowCheckBox- определяет отображается ли флажок\n" +
                "4. MaxDate-максимальная доступная для выбора дата\n" +
                "5. MinDate-минимальная доступная для выбора дата\n" +
                "События элемента управления  DateTimePicker:\n" +
                "1. Click-происходит при щелчке элемента управления\n" +
                "2. CloseUp-происходит при завершении выбора даты\n" +
                "3. ValueChanged-происходит при изменении значения данного элемента\n" +
                "4. DropDown-происходит перед развёртыванием раскрывающегося календаря\n" +
                "5. KeyDown-происходит при первом нажатии клавиши";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Свойства и методы элемента управления RadioButton:\n" +
                "1. Name-имя элемента по которому можно обращаться в коде\n" +
                "2. Text-текст на элементе\n" +
                "3. Appearance-элемент отображается стандартно или как объект Windows PuchButton\n" +
                "4. CheckAlign-определяет местоположение флажка элемента\n" +
                "5. Checked-указыает состояние переключателя\n" +
                "События элемента управления RadioButton:\n" +
                "1. Click-происходит при щелчке элемента управления\n" +
                "2. CheckedChnaged-происходит при изменении свойства checked\n" +
                "3. KeyUp-происходит в момент отпускания клавиши\n" +
                "4. TextChanged-возникает при изменении свойства Text\n" +
                "5. Move-происходит при перемещении элемента";
        }

        private void groupBox1_Click(object sender, EventArgs e)
        {
            label2.Text = "Свойства и методы элемента управления GroupBox:\n" +
                "1. Name-имя элемента по которому можно обращаться в коде\n" +
                "2. Text-текст на элементе\n" +
                "3. ForeColor-цвет текста\n" +
                "4. BackColor-фоновый цвет\n" +
                "5. Size-размер элемента\n" +
                "События элемента управления GroupBox:\n" +
                "1. Click-происходит при щелчке элемента управления\n" +
                "2. Paint-происходит при перерисовке элемента\n" +
                "3. MouseCaptureChanged-возникает при изменении перехвата сообщений от мыши\n" +
                "4. Layout-происходит, когда элемент готов показать содержимое\n" +
                "5. Resize-происиходит при изменении размера элемента";
        }
        private void panel1_Click(object sender, EventArgs e)
        {
            label2.Text = "Свойства и методы элемента управления Panel:\n" +
               "1. Name-имя элемента по которому можно обращаться в коде\n" +
               "2. Locked-определяет, можно ли двигать и изменять элемент\n" +
               "3. Dock-указывает, какие границы элмента управления привязаны к контейнеру\n" +
               "4. AllowDrop-определяет, можно ли перетащить даннные в элемент\n" +
               "5. TabStop-указывает, можно ли с помощью Tab переключить фокус на этот элемент управления\n" +
               "События элемента управления Panel:\n" +
               "1. Click-происходит при щелчке элемента управления\n" +
               "2. MouseCaptureChanged-возникает после изменения перехвата сообщений от мыши\n" +
               "3. HelpRequested-возникает, когда пользователь вызывает справку об элементе\n" +
               "4. SystemColorsChanged-возникает при изменении системной палитры\n" +
               "5. Validated-происходит после успешной проверки корректности элмента управления";
        }
        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            label2.Text = "Свойства и методы элемента управления MaskedTextBox:\n" +
                "1. Name-имя элемента по которому можно обращаться в коде\n" +
                "2. Text-текст на элементе\n" +
                "3. PromptChar-указывает символ, использующийся как местозаполнитель\n" +
                "4. BackColor-фоновый цвет\n" +
                "5. TextAlign-задаёт выравнивание текста в элементе\n" +
                "События элемента управления MaskedTextBox:\n" +
                "1. Click-происходит при щелчке элемента управления\n" +
                "2. MaskInputRejected-происходит, если символ не удовлетворяет условиям маски\n" +
                "3. TypeValidationComplete- происходит когда ValidatingType завершил разбор текста\n" +
                "4. CollectionChanged-происходит при изменении принадлежности коллекции\n" +
                "5. Resize-происиходит при изменении размера элемента";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label2.Text = "Свойства и методы элемента управления PictureBox:\n" +
               "1. Name-имя элемента по которому можно обращаться в коде\n" +
               "2. ErrorImage-изображение отображаемое при невозможности загрузки другого\n" +
               "3. InitialImage-изображение отображаемое при загрузке другого\n" +
               "4. Image-изображение в PictureBox\n" +
               "5. Visible-определяет отображается или скрыт элемент\n" +
               "События элемента управления PictureBox:\n" +
               "1. Click-происходит при щелчке элемента управления\n" +
               "2. LoadCompleted-возникает при окончании загрузки в PictureBox\n" +
               "3. LoadProgressChanged-возникает при изменении хода процесса загрузки в PictureBox\n" +
               "4. Move-происходит при перемещении элмента\n" +
               "5. Resize-просиходит при изменении размера элемента";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label2.Text = "Свойства и методы элемента управления DataGridView:\n" +
               "1. Name-имя элемента по которому можно обращаться в коде\n" +
               "2. Columns-число колонн\n" +
               "3. AlternatingRowsDefaultCellStyle-стиль ячеек, применяемый к нечётным строкам\n" +
               "4. CellBorderStyle-стиль границ ячейки\n" +
               "5. ColumnHeadersHigh-высота строки заголовка столбца\n" +
               "События элемента управления DataGridView:\n" +
               "1. CellClick-происходит при щелчке ячейки\n" +
               "2. CellBeginEdit-возникает при правке ячейки\n" +
               "3. Sorted-возникает при выполнении сортировки\n" +
               "4. Scroll-вызывается при горизонтальной или вертикальной прокрутке сетки\n" +
               "5. CellEnter-возникает при получении фокуса данной ячейкой";
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            label2.Text = "Свойства и методы элемента управления ProgressBar:\n" +
               "1. Name-имя элемента по которому можно обращаться в коде\n" +
               "2. Maximum-верхняя граница диапозона, в котором действует ProgressBar\n" +
               "3. Minimum-нижняя граница диапозона, в котором действует ProgressBar\n" +
               "4. BackColor-фоновый цвет компонента\n" +
               "5. Step-велечина приращения текущего значения элемента\n" +
               "События элемента управления ProgressBar:\n" +
               "1. Click-происходит при щелчке элемента управления\n" +
               "2. MouseClick-возникает при щелчке мышью элмента\n" +
               "3. GiveFeedBack-происходит, когда элемент перетаскивается с помощью мыши\n" +
               "4. Move-просиходит при перемещении элемента\n" +
               "5. Validated-происходит после успешной првоверки корректности в элемента";
        }
    }
}
