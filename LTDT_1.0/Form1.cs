using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;

namespace LTDT_1._0
{

    public partial class PrimAndDijsktra : Form
    {
        public PrimAndDijsktra()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        const int MAX = 100;
		const int Vc = -1;

		public class GRAPH
		{
			public int sodinh;
			public int[,] a;
			public int[] visited;  //danh dau dinh i da xet hay chua, 0 la chua 

			public int SoDinh
			{
				get { return sodinh; }
				set { SoDinh = value; }
			}
			public int this[int i, int j]
			{
				get { return a[i, j]; }
				set { a[i, j] = value; }
			}
			public int this[int i]
			{
				get { return visited[i]; }
				set { visited[i] = value; }
			}
		}

		public static GRAPH readGRAPH(int[,] matrix, int n)
		{
			GRAPH g = new GRAPH();
			g.a = new int[MAX, MAX];
			g.visited = new int[MAX];
			g.sodinh = n;

			//Console.Write("So dinh cua do thi: ");
			//g.sodinh = int.Parse(Console.ReadLine());
			for (int i = 0; i < g.sodinh; i++)
			{
				for (int j = 0; j < g.sodinh; j++)
				{
					//Console.Write("[" + i + "," + j + "]: ");
					g.a[i, j] = matrix[i, j];
				}
			}
			return g;
		}

		public static void printGRAPH(GRAPH g)
		{
			Console.WriteLine("So dinh cua do thi: " + g.sodinh);
			for (int i = 0; i < g.sodinh; i++)
			{
				for (int j = 0; j < g.sodinh; j++)
					Console.Write("  " + g.a[i, j]);
				Console.WriteLine();
			}
			Console.WriteLine();
		}

		public class CANH
		{
			public int u;//Dinh thu nhat
			public int v;//Dinh thu hai
			public int trongso;
		}

        int[,] Matrix = new int[100, 100];  // Lưu ma trận khi tạo các đỉnh và đường đi
        Label[] Dinh = new Label[100];      // Lưu lại các đỉnh dưới dạng label để dễ dàng thay đổi
        CANH[] T = new CANH[MAX];  // Prim
        int nT = 0;                // Prim
        int[] Road = new int[MAX]; // Dijkstra
        int roadid = 0;            // Dijkstra
        int roadi;                 // Dijkstra
        int SoDinh = 1;            // Dùng để đếm số lượng của label
        bool TaoDinh = false;      // btn Tạo đỉnh
        bool line = false;         // btn tạo đường đi
        List<int> DanhSachDi;    
        List<int> DanhSachDen;

        private void ThemVong()
            {
                int X = Cursor.Position.X;
                int Y = Cursor.Position.Y;
                int tmpX = (int)this.PointToClient(Cursor.Position).X;  // tạo hình tròn xung quanh đỉnh
                int tmpY = (int)this.PointToClient(Cursor.Position).Y;
                Pen pen = new Pen(Color.Black, 2);
                Graphics g = this.CreateGraphics();
                if (SoDinh < 10) g.DrawEllipse(pen, tmpX - 9, tmpY - 9, 33, 33);  // canh chỉnh để vòng tròn nhìn đẹp
                if (SoDinh >= 10) g.DrawEllipse(pen, tmpX - 6, tmpY - 8, 33, 34);
            }

        private Label ThemDinh(Label tmp, string text)
        { 
            int X = Cursor.Position.X;
            int Y = Cursor.Position.Y;
            tmp.Location = this.PointToClient(new Point(X, Y)); // tạo vị trí dựa vào con trỏ chuột
            tmp.Text = text;                          // thứ tự các đỉnh
            tmp.Parent = this;
            tmp.BackColor = Color.Transparent;
            if (SoDinh < 10) tmp.Size = new Size(20, 20);          // tuỳ theo số để tuỳ chỉnh size phù hợp cho thẩm mỹ
            if (SoDinh >= 10) tmp.Size = new Size(22, 22);
            tmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));         
            return tmp;
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (DuongDi.Visible == true)
            {
                DuongDi.Visible = false;
            }
            if (TaoDinh == false)
            {
                //MessageBox.Show("Cre Graph");
                TaoDinh = true;
            }
            else if (TaoDinh == true)
            {
                //MessageBox.Show("Tat");
                TaoDinh = false;
            }
        }

        private void PrimAndDijsktra_MouseClick(object sender, MouseEventArgs e)
        {
            if (TaoDinh == true)
            {
                Label tmp = new Label();
                ThemDinh(tmp, SoDinh.ToString()); // tạo dỉnh tại vị trí đã chọn
                ThemVong();                       // thêm vòng ngay tại vị trí đã chọn luôn
                this.Controls.Add(tmp);           // thêm vào controls để đưa label vào hệ thống                
                Dinh[SoDinh] = tmp;               // gán label vào đỉnh để sau này để chỉnh sửa
                SoDinh++;                         // tăng số lượng label
            }
            if (line == true)
            {
                Label tmp = new Label();
                ThemDinh(tmp, GiaTri.Text);         // thêm trọng số kế bên đường đi
                tmp.Size = new Size(30, 22);        // cài đặt size to để có thể chứa nhiều số hơn và không bị mất số
                tmp.Parent = this;
                tmp.BackColor = Color.Transparent;
                this.Controls.Add(tmp);             // thêm vào controls để đưa vào hệ thống
                GiaTri.Text = "";                   // reset lại biến giá trị để người dùng có thể tiếp tục nhập
                line = false;                       // tắt để người dùng không thể đặt ra thêm label
            }
        }

        private void CreLine_Click(object sender, EventArgs e)
        {
            if (TaoDinh == true)
            {
                TaoDinh = false;        // nếu chưa tắt tạo đỉnh sẽ tự động tắt
            }

            //MessageBox.Show("Cre Line");
            DuongDi.Visible = true;             // hiện panel để tạo đường đi
            DanhSachDi = new List<int>();       // tạo list mới để combobox không bị lặp lại
            DanhSachDen = new List<int>();
            for (int i = 1; i < SoDinh; i++)
            {
                DanhSachDi.Add(i);
                DanhSachDen.Add(i);
            }            
            Start.DataSource = DanhSachDi;      // thêm list vào combobox
            End.DataSource = DanhSachDen;       // thêm list vào combobox
        }

        private void GO_Click(object sender, EventArgs e)
        {
            if (GiaTri.Text == "")
            {
                MessageBox.Show("NHAP SAI");        // nếu người dùng quên nhập giá trị sẽ bắt người dùng nhập lại
            }
            else
            {
                MessageBox.Show("Chon vi tri");      // rất khó để canh vị trí để đặt trọng số kế bên đường đi nên cho người dùng tự chọn vị trí
                line = true;                         // set line = true để có thể chọn vị trí
                Pen pen = new Pen(Color.Black, 2);      // tạo cây bút để vẻ
                Graphics g = this.CreateGraphics();     
                int from = int.Parse(Start.SelectedItem.ToString());    // chuyển giá trị đã chọn ở 2 combobox thành int để tạo đường đi form to 
                int to = int.Parse(End.SelectedItem.ToString());
                Point arrfrom = new Point(Dinh[from].Location.X, Dinh[from].Location.Y);    // đi từ
                Point arrto = new Point(Dinh[to].Location.X, Dinh[to].Location.Y);          // đi đến

                if (primrbt.Checked == true)
                {
                    Matrix[from - 1, to - 1] = int.Parse(GiaTri.Text);      // nếu là vô hướng giá trị sẽ đối xứng
                    Matrix[to - 1, from - 1] = int.Parse(GiaTri.Text);
                    g.DrawLine(pen, arrfrom, arrto);                    // vẽ đường thẳng bình thường
                }
                else if (dijsktrarbt.Checked == true)
                {
                    AdjustableArrowCap bigArrow = new AdjustableArrowCap(6, 6);     // chỉnh bút vẽ lại thành dấu mủi tên
                    pen.CustomEndCap = bigArrow;
                    g.DrawLine(pen, arrfrom, arrto);
                    Matrix[from - 1, to - 1] = int.Parse(GiaTri.Text);          // có hướng giá trị không đối xứng
                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DuongDi.Visible = false;  // bấm huỷ panel sẽ ẩn đi
            GiaTri.Text = "";         // reset lại giá trị
        }

        private void PrintMatrix_Click(object sender, EventArgs e)
        {
            string xuat;
            if (DuongDi.Visible == true)
            {
                DuongDi.Visible = false;    // nếu chưa tắt panel chọn đường đi sẽ tự tắt
            }
            if (TaoDinh == true)
            {
                TaoDinh = false;    // nếu chưa tắt tạo đỉnh sẽ tự tắt
            }
            else
            {
                xuat = "Ma trận hiện tại:\r\n";             // gôm các số lại xuất dưới dạng chuỗi và hiện vào messagebox
                for (int i = 0; i < SoDinh - 1; i++)
                {
                    for (int j = 0; j < SoDinh - 1; j++)
                    {
                        xuat += Matrix[i, j].ToString() + "  ";
                    }
                    xuat += "\r\n";
                }
                MessageBox.Show(xuat, "Ma trận của đồ thị: ");
            }
        }
                
		private void PrimMin(GRAPH g)
		{
			for (int i = 0; i < g.sodinh; i++)
				g.visited[i] = 0;

			g.visited[0] = 1;

			while (nT < g.sodinh - 1)
			{
				CANH canhnhonhat = new CANH();
				int min = -1;
				for (int i = 0; i < g.sodinh; i++)
					if (g.visited[i] == 0)
					{
						for (int j = 0; j < g.sodinh; j++)
							if (g.visited[j] == 1 && (g.a[i, j] != 0))
							{
								if (min == -1 || g.a[i, j] < min)
								{
									min = g.a[i, j];
									canhnhonhat.u = i;
									canhnhonhat.v = j;
									canhnhonhat.trongso = g.a[i, j];
								}
							}
					}
				T[nT] = canhnhonhat;
                nT++;
				g.visited[canhnhonhat.u] = 1;
			}
		}

        void XuatPrim()
        {
            // tạo 1 hàm xuất prim để dùng thread chạy 1 luồng riêng và có thể thấy được từng bước
            int sum = 0;
            //Console.WriteLine("Cay khung nho nhat cua do thi la: ");
            for (int i = 0; i < nT; i++)
            {
                //Console.Write("(" + T[i].v + "," + T[i].u + ")");
                sum += T[i].trongso;
                Dinh[T[i].v + 1].BackColor = Color.Green;
                Dinh[T[i].u + 1].BackColor = Color.Green;
                // vẻ lại đường đi thành màu xanh
                Thread.Sleep(3000);
            }
            //Console.WriteLine();
            //Console.WriteLine("Tong gia tri cua cay la: " + sum);
        }

		private void DijsktraFind(GRAPH g, int x, int y)
		{
			bool[] ThuocT = new bool[MAX];
			int[] Length = new int[MAX];
			int[] LastV = new int[MAX];

			/*x, y;

			Console.Write("Tim duong di min tu: ");
			x = int.Parse(Console.ReadLine());
			Console.Write("Den: ");
			y = int.Parse(Console.ReadLine());
			*/

			for (roadi = 0; roadi < g.sodinh; roadi++)
			{
				ThuocT[roadi] = true;
				Length[roadi] = Vc;
				LastV[roadi] = -1;
			}

			Length[x] = 0;
			ThuocT[x] = false;
			LastV[x] = x;
			int v = x;
			int t = x;

			while (ThuocT[y])
			{
				for (int k = 0; k < g.sodinh; k++)
				{
					if (g.a[v, k] != 0 && ThuocT[k] == true && (Length[k] == Vc || Length[k] > Length[v] + g.a[v, k]))
					{
						Length[k] = Length[v] + g.a[v, k];
						LastV[k] = v;
					}
				}

				v = -1;
				for (roadi = 0; roadi < g.sodinh; roadi++)
				{
					if (ThuocT[roadi] == true && Length[roadi] != Vc)
						if (v == -1 || Length[v] > Length[roadi])
							v = roadi;
				}
				ThuocT[v] = false;
			}

			v = y;
			//Tìm đường đi: truy xuất từ LastV
			while (v != x)
			{
				Road[roadid] = v;
				v = LastV[v];
				roadid++;
			}
			Road[roadid] = x;
		}

        void XuatDij()
        {
            // cũng tương tự như prim tạo 1 luồng thread mới để chạy từng bước
            //Xuất ngược để tìm đường đi dinhDau -> dinhCuoi
            for (roadi = roadid; roadi > 0; roadi--)
            {
                Dinh[Road[roadi] + 1].BackColor = Color.Green;
                Thread.Sleep(3000);
                //Console.Write(Road[roadi] + " --> ");
                //Console.WriteLine(Road[roadi]);
            }
        }

		private void Run_Click(object sender, EventArgs e)
        {
            GRAPH tmp;
            tmp = readGRAPH(Matrix, SoDinh - 1);
            if (dijsktrarbt.Checked == true)    // nếu là thuật toán dijkstra
            {
                dijGoto.Visible = true;         // hiện bảng chọn thuật toán chạy từ đỉnh nào đến đỉnh nào
                DanhSachDi = new List<int>();   // tạo list mới để các item không bị trùng lặp
                DanhSachDen = new List<int>();
                for (int i = 1; i < SoDinh; i++)
                {
                    DanhSachDi.Add(i);
                    DanhSachDen.Add(i);
                }
                dijfrom.DataSource = DanhSachDi;
                dijto.DataSource = DanhSachDen;
            }
            if (primrbt.Checked == true)
            {
                PrimMin(tmp);
                ThreadStart ts = new ThreadStart(XuatPrim); // tạo thread mới để có thể thấy được quá trình chạy prim
                Thread thrd = new Thread(ts);
                thrd.IsBackground = true;                   // tạo luồng thread mới để có thể coi quá trình chạy
                thrd.Start();
            }
            //printGRAPH(tmp);
        }

        private void rundijbt_Click(object sender, EventArgs e)
        {
            // Bảng chọn đường đi từ đỉnh nào tới đỉnh nào
            GRAPH tmp;
            tmp = readGRAPH(Matrix, SoDinh - 1);
            int from = int.Parse(dijfrom.SelectedItem.ToString());  // chuyển giá trị đã chọn của combobox sang int để chạy thuật toán
            int to = int.Parse(dijto.SelectedItem.ToString());
            DijsktraFind(tmp, from - 1, to - 1);                    // giảm đi 1 vì thuật toán và giá trị chênh lệnh 1 giá trị
            ThreadStart ts = new ThreadStart(XuatDij);              // tạo luồng thread mới để có thể coi quá trình chạy
            Thread thrd = new Thread(ts);
            thrd.IsBackground = true;                               // cho phép người dùng thoát ngay cả khi còn đang chạy
            thrd.Start();
        }

        private void exitdij_Click(object sender, EventArgs e)
        {
            dijGoto.Visible = false;         // ẩn đi bảng chọn thuật toán chạy từ đỉnh nào đến đỉnh nào
        }
    }
}