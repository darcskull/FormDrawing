using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace курсов_проект
{
    public partial class FormScene : Form
    {
        private Scene scene = new Scene();
        private List<Shape> saveshape = new List<Shape>();
        private List<Shape> fileshape = new List<Shape>();
        public FormScene()
        {
            InitializeComponent();
        }

        private void FormScene_Load(object sender, EventArgs e)
        {
            if (!File.Exists("shapes"))
                return;

            var binformatter = new BinaryFormatter();
            using (var filestream = new FileStream("shapes", FileMode.Open, FileAccess.Read))
                scene = (Scene)binformatter.Deserialize(filestream);
            scene.FillShape(fileshape);
            scene.ListRes();
        }
        private void FormScene_FormClosing(object sender, FormClosingEventArgs e)
        {
            var binformatter = new BinaryFormatter();
            using (var filestream = new FileStream("shapes", FileMode.Create, FileAccess.Write))
                binformatter.Serialize(filestream, scene);
        }

        private void FormScene_MouseDown(object sender, MouseEventArgs e)
        {
            Color col = new Color();
            int coll = 0;
            if (String.IsNullOrEmpty(textBoxColor.Text) || !int.TryParse(textBoxColor.Text, out coll) || coll > 10 || coll <= 0)
                col = Color.Gray;
            if (coll == 1)
                col = Color.Yellow;
            if (coll == 2)
                col = Color.Red;
            if (coll == 3)
                col = Color.Blue;
            if (coll == 4)
                col = Color.Green;
            if (coll == 5)
                col = Color.Orange;
            if (coll == 6)
                col = Color.Pink;
            if (coll == 7)
                col = Color.Brown;
            if (coll == 8)
                col = Color.Black;
            if (coll == 9)
                col = Color.OrangeRed;
            if (coll == 10)
                col = Color.Purple;

            if (e.Button == MouseButtons.Right)
            {

                int ssize = 0;
                if (!String.IsNullOrEmpty(textBoxSize.Text) && int.TryParse(textBoxSize.Text, out ssize) && ssize >= 10 && ssize <= 100)
                {
                    if (this.radioButtonCircle.Checked)
                    {
                        Shape s = new Circle();
                        s.Color = col;
                        s.Draw(e.X, e.Y, ssize);
                        scene.AddShape(s);

                        textBoxSurface.Text = s.CalculateSurface().ToString();
                        textBoxPerimeter.Text = s.CalculatePerimeter().ToString();
                        toolStripStatusLabelSurface.Text = "Shapes Surface : " + scene.CalculateSurface();
                        toolStripStatusLabelPerimeter.Text = "Shapes Perimeter : " + scene.CalculatePerimeter();
                    }
                    else if (this.radioButtonTriangle.Checked)
                    {
                        Shape s = new Triangle();
                        s.Color = col;
                        s.Draw(e.X, e.Y, ssize);
                        scene.AddShape(s);

                        textBoxSurface.Text = s.CalculateSurface().ToString();
                        textBoxPerimeter.Text = s.CalculatePerimeter().ToString();
                        toolStripStatusLabelSurface.Text = "Shapes Surface : " + scene.CalculateSurface();
                        toolStripStatusLabelPerimeter.Text = "Shapes Perimeter : " + scene.CalculatePerimeter();
                    }
                    else if (this.radioButtonSquare.Checked)
                    {
                        Shape s = new Square();
                        s.Color = col;
                        s.Draw(e.X, e.Y, ssize);
                        scene.AddShape(s);
 
                        textBoxSurface.Text = s.CalculateSurface().ToString();
                        textBoxPerimeter.Text = s.CalculatePerimeter().ToString();
                        toolStripStatusLabelSurface.Text = "Shapes Surface : " + scene.CalculateSurface();
                        toolStripStatusLabelPerimeter.Text = "Shapes Perimeter : " + scene.CalculatePerimeter();
                    }
                    else
                    {
                        MessageBox.Show("Моля изберете фигура, която искате да начертаете!");
                    }
                }
                else
                {
                    MessageBox.Show("Моля въведете валидна стойност между 10 и 100!");
                }
            }
            else if (e.Button == MouseButtons.Left)
            {
                scene.selectedShape = scene.SelectShape(e.X, e.Y);

                if (scene.selectedShape == null)
                {
                    MessageBox.Show("Моля натиснете върху фигура, която да преместите!");
                    textBoxSurface.Text = "";
                    textBoxPerimeter.Text = "";
                }
                else
                {
                    textBoxSurface.Text = scene.selectedShape.CalculateSurface().ToString();
                    textBoxPerimeter.Text = scene.selectedShape.CalculatePerimeter().ToString();
                }
            }
        }

        string help = "Помощ за работа с приложението \n" +
           "\n" +
           "1. Въведете размер и изберете каква фигура искате да начертаете (фигурите се чертаят с натискането на десен бутон на мишката) \n" +
           "2. В менютата -Shape Surface- и -Shape Perimeter- се изписват съответно лицето и периметърът на последната начертана фигура или фигурата, която се премества\n" +
           "3. Бутонът -Clear- почиства всички фигури от сцената \n" +
           "4. Бутонът -Redraw- въстановява всички фигури, които са били нарисувани на сцената \n" +
           "5. В менютата  -Shapes Surface- и -Shapes Perimeter- се изписват съответно лицето и периметърът на всички начертани фигури \n" +
           "6. Преместване - с ляв бутон на мишката се натиска върху избраната фигура и се задържа, след което мишката се премества до новата позиция на фигурата, след което се отпуска мишката и фигурата се премества \n" +
           "7. Избор на цвят- при натискане на бутона -Colors Codes- ще видите кодовете на поддържаните от приложението цветове, в менюто -Add Color's Code- въведете кодът на цвета, в който искате да бъдат оцветени вашите фигури, ако въведете невалиден код програмата ще използва сив цвят \n" +
           "8. Запазване във файл - след като решите да затворите програмата всички начертани до момента фигури ще бъдат запазени във файл, ако решите, че не искате да запазите своите фигури натиснете бутона -Clear- \n" +
           "9. Рисуване от файл- ако искате да нарисувате фигурите от предишното отваряне на праграмата(ако те са запазени) натиснете бутона -Draw from file-";
            
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(help);
        }
        String cols = "Кодове за цветовете \n" +
           "\n" +
           "1 - Жълт \n" +
           "2 - Червен \n" +
           "3 - Син \n" +
           "4 - Зелен \n" +
           "5 - Оранжев \n" +
           "6 - Розов \n" +
           "7 - Кафяв \n" +
           "8 - Черен \n" +
           "9 - Оранжево-червен \n" +
           "10 - Лилав \n" +
           "Ако въведете невалиден код, програмата ще използва сив цвят!!!";

        private void buttonColor_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cols);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Invalidate();
            scene.selectedShape = null;
            scene.FillShape(saveshape);
            scene.ListRes();
            toolStripStatusLabelSurface.Text = "Shapes Surface : ";
            toolStripStatusLabelPerimeter.Text = "Shapes Perimeter : ";
            textBoxSurface.Text = "";
            textBoxPerimeter.Text = "";
        }

        private void buttonRedraw_Click(object sender, EventArgs e)
        {
            if (saveshape.Count <= 0)
                MessageBox.Show("Няма изтрити фигури, които да бъдат възстановени!");


            scene.ReAdd(saveshape);

            scene.DrawAll();
            toolStripStatusLabelSurface.Text = "Shapes Surface : " + scene.CalculateSurface();
            toolStripStatusLabelPerimeter.Text = "Shapes Perimeter : " + scene.CalculatePerimeter();
        }

        private void FormScene_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                scene.selectedShape.x = e.X;
                scene.selectedShape.y = e.Y;
                this.Refresh();

                scene.DrawAll();

            }
            scene.selectedShape = null;
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            if (fileshape.Count<=0)
                MessageBox.Show("Няма запазени фигури!");

            scene.ReAdd(fileshape);

            scene.DrawAll();
            toolStripStatusLabelSurface.Text = "Shapes Surface : " + scene.CalculateSurface();
            toolStripStatusLabelPerimeter.Text = "Shapes Perimeter : " + scene.CalculatePerimeter();
        }
    }
}
