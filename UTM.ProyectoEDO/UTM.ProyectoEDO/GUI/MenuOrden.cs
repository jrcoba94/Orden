using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTM.ProyectoEDO.DAO;

namespace UTM.ProyectoEDO.GUI
{
    public partial class MenuOrden : Form
    {
        public MenuOrden()
        {
            InitializeComponent();
        }
        Random randomN = new Random();
        int[] rand;
        int and;
        Orden mo = new Orden();

        private void MenuOrden_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnHeap_Click(object sender, EventArgs e)
        {
            int[] arregloR = mo.heapSort(randomVal());
            richTextBox2.Clear();
            richTextBox2.Text = string.Join("\n", arregloR);
        }

        private void btnQuick_Click(object sender, EventArgs e)
        {
            int[] arr = mo.quickSort(randomVal());
            richTextBox2.Clear();
            richTextBox2.Text = string.Join("\n", arr);
        }

        private void btnShaker_Click(object sender, EventArgs e)
        {
            int[] arr = mo.shakerSort(randomVal());
            richTextBox2.Clear();
            richTextBox2.Text = string.Join("\n", arr);
        }

        private void btnSelection_Click(object sender, EventArgs e)
        {
            int[] arr = mo.selectionSort(randomVal());
            richTextBox2.Clear();
            richTextBox2.Text = string.Join("\n", arr);
        }

        private void btnBubble_Click(object sender, EventArgs e)
        {
            int[] arregloR = mo.bubbleSort(randomVal());
            richTextBox2.Clear();
            richTextBox2.Text = string.Join("\n", arregloR);
        }

        private void btnDesO_Click(object sender, EventArgs e)
        {
            int[] drag = randomVal();
            for (int i = 0; i <= richTextBox1.Text.Length; i++)
            {
                richTextBox1.Text = string.Join("\n", drag);
                if (richTextBox1.Text.Length < 100)
                {
                    richTextBox1.Clear();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripButton4.Text = DateTime.Now.ToString("G");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public int[] randomVal()
        {
            rand = new int[randomN.Next(1, 100)];
            for(int i =0; i<rand.Length; i++)
            {
                rand[i] = randomN.Next(1, 100);
            }
            return rand;
        }
    }
}
