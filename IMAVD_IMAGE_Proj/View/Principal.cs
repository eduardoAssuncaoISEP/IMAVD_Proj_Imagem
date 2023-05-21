using System.Security.Cryptography.X509Certificates;
using System.Drawing.Imaging;
using System.Text;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Numerics;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IMAVD_IMAGE_Proj
{
    public partial class Principal : Form
    {
        /// <summary>
        /// Vari�veis para armazenamento de informa��es padr�es da imagem
        /// </summary>
        private Image Img;
        private Size OriginalImageSize;
        private Size ModifiedImageSize;
        PictureBox org;

        /// <summary>
        /// Vari�veis globais para armazenamento das propriedades da imagem
        /// </summary>
        public static string imageName = "";
        public static string imageExtension = "";
        public static string imageDimension = "";
        public static string imageLocation = "";
        public static string imageSize = "";
        public static string imageCreatedOn = "";
        public static Image imagePath = null;

        /// <summary>
        /// Vari�veis para armazenamento de informa��es referentes ao corte (crop) da imagem
        /// </summary>
        private int cropX, cropY, cropWidth, cropHeight, oCropX, oCropY;
        public Pen cropPen;
        public DashStyle cropDashStyle = DashStyle.DashDot;

        public Principal()
        {
            InitializeComponent();
            picImagem = new PictureBox();

        }

        /// <summary>
        /// Defini��o dos valores do trackBar ao inicializar o formul�rio
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {

            trackBar1.Minimum = 1;
            trackBar1.Maximum = 6;
            trackBar1.SmallChange = 1;
            trackBar1.LargeChange = 1;
            trackBar1.UseWaitCursor = false;

            //minimizar o efeito de stutter
            this.DoubleBuffered = true;

        }

        /// <summary>
        /// A��o de abertura de image, obten��o e atribui��o de propriedades da mesma �s vari�veis globais
        /// </summary>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dlg = new OpenFileDialog();
            Dlg.Filter = "";
            Dlg.Title = "Select image";
            if (Dlg.ShowDialog() == DialogResult.OK)
            {
                makeSelectionButton.Enabled = true;
                Img = Image.FromFile(Dlg.FileName);
                LoadImage();

                FileInfo fileInfo = new FileInfo(Dlg.FileName);
                org = new PictureBox();
                org.Image = pictureBox1.Image;

                // set image information for global variable
                imagePath = pictureBox1.Image;
                imageName = Path.GetFileName(Dlg.FileName);
                imageExtension = Path.GetExtension(Dlg.FileName);

                string width = pictureBox1.Image.Width.ToString();
                string height = pictureBox1.Image.Height.ToString();
                imageDimension = width + " x " + height;

                long tamanhoEmBytes = fileInfo.Length;
                int tamanhoEmKilobytes = (int)tamanhoEmBytes / 1024;
                imageSize = tamanhoEmKilobytes.ToString() + " KB";
                imageLocation = Path.GetFullPath(Dlg.FileName);
                imageCreatedOn = fileInfo.CreationTime.ToString();
            }
        }

        /// <summary>
        /// Fun��o para carregamento de informa��es da imagem a serem utilizados em outras fun��es
        /// </summary>
        private void LoadImage()
        {
            int imgWidth = Img.Width;
            int imgHeight = Img.Height;
            pictureBox1.Width = imgWidth;
            pictureBox1.Height = imgHeight;
            pictureBox1.Image = Img;
            PictureBoxLocation();
            OriginalImageSize = new Size(imgWidth, imgHeight);
            //SetResizeInfo();
        }

        /// <summary>
        /// Fun��o para determinar a posi��o, no painel, da imagem carregada
        /// </summary>
        private void PictureBoxLocation()
        {
            int _x = 0;
            int _y = 0;
            if (panelPictureBox1.Width > pictureBox1.Width)
            {
                _x = (panelPictureBox1.Width - pictureBox1.Width) / 2;
            }
            if (panelPictureBox1.Height > pictureBox1.Height)
            {
                _y = (panelPictureBox1.Height - pictureBox1.Height) / 2;
            }
            pictureBox1.Location = new Point(_x, _y);
        }

        /// <summary>
        /// A��o para converter a cor da imagem para vermelho
        /// </summary>
        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //verificando se a imagem foi aberta
            if (pictureBox1.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox1.Image);
                int width = pictureBox1.Image.Width;
                int height = pictureBox1.Image.Height;

                //Bitmap red = new Bitmap(img);

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Color p = img.GetPixel(x, y);

                        int a = p.A;
                        int r = p.R;
                        int g = p.G;
                        int b = p.B;

                        img.SetPixel(x, y, Color.FromArgb(a, r, 0, 0));
                    }
                }

                pictureBox2.Image = img;
            }
        }

        /// <summary>
        /// A��o para converter a cor da imagem para verde
        /// </summary>
        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //verificando se a imagem foi aberta
            if (pictureBox1.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox1.Image);
                int width = pictureBox1.Image.Width;
                int height = pictureBox1.Image.Height;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Color p = img.GetPixel(x, y);

                        int a = p.A;
                        int r = p.R;
                        int g = p.G;
                        int b = p.B;

                        img.SetPixel(x, y, Color.FromArgb(a, 0, g, 0));
                    }
                }

                pictureBox2.Image = img;
            }
        }

        /// <summary>
        /// A��o para converter a cor da imagem para azul
        /// </summary>
        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //verificando se a imagem foi aberta
            if (pictureBox1.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox1.Image);
                int width = pictureBox1.Image.Width;
                int height = pictureBox1.Image.Height;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Color p = img.GetPixel(x, y);

                        int a = p.A;
                        int r = p.R;
                        int g = p.G;
                        int b = p.B;

                        img.SetPixel(x, y, Color.FromArgb(a, 0, 0, b));
                    }
                }

                pictureBox2.Image = img;
            }
        }

        /// <summary>
        /// A��o para inverter a cor da imagem
        /// </summary> 
        private void invertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //verificando se a imagem foi aberta
            if (pictureBox1.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox1.Image);
                int width = pictureBox1.Image.Width;
                int height = pictureBox1.Image.Height;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Color p = img.GetPixel(x, y);

                        int a = p.A;
                        int r = p.R;
                        int g = p.G;
                        int b = p.B;

                        r = 255 - r;
                        g = 255 - g;
                        b = 255 - b;

                        img.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                    }
                }

                pictureBox2.Image = img;
            }
        }

        /// <summary>
        /// Fun��o para redimencionar a imagem
        /// </summary>
        Image ZoomPicture(Image img, Size size)
        {
            Bitmap bmp = new Bitmap(img, Convert.ToInt32(img.Width * size.Width),
                Convert.ToInt32(img.Height * size.Height));
            Graphics g = Graphics.FromImage(bmp);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            return bmp;
        }

        /// <summary>
        /// A��o para realizar o zoom � imagem com o trackBar
        /// Necess�rio corrigir reset da imagem quando zoom � realizado
        /// </summary>
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value != 0 && pictureBox1.Image != null)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = ZoomPicture(Img, new Size(trackBar1.Value, trackBar1.Value));
            }
        }

        /// <summary>
        /// A��o para permiter a sele��o da �rea � ser realizado o corte (crop)
        /// </summary>
        private void makeSelectionButton_Click(object sender, EventArgs e)
        {
            makeSelectionButton.Enabled = false;
        }

        //// <summary>
        /// A��o para desenho da �rea para corte - Click (posi��o inicial)
        /// </summary>
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && makeSelectionButton.Enabled == false)
            {
                Cursor = Cursors.Cross;
                cropX = e.X;
                cropY = e.Y;
                cropPen = new Pen(Color.Black, 1);
                cropPen.DashStyle = DashStyle.DashDotDot;
            }
            pictureBox1.Refresh();
        }

        //// <summary>
        /// A��o para desenho da �rea para corte - Move (sele��o da �rea)
        /// </summary>
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image == null)
                return;
            if (e.Button == MouseButtons.Left && makeSelectionButton.Enabled == false)
            {
                pictureBox1.Refresh();
                cropWidth = e.X - cropX;
                cropHeight = e.Y - cropY;
                pictureBox1.CreateGraphics().DrawRectangle(cropPen, cropX, cropY, cropWidth, cropHeight);
            }
        }

        /// <summary>
        /// A��o para realizar o corte � imagem com base na sele��o da �rea
        /// </summary>
        private void makeCropButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            if (cropWidth < 1)
            {
                return;
            }
            Rectangle rect = new Rectangle(cropX, cropY, cropWidth, cropHeight);
            //First we define a rectangle with the help of already calculated points  
            Bitmap OriginalImage = new Bitmap(pictureBox1.Image, pictureBox1.Width, pictureBox1.Height);
            //Original image  
            Bitmap _img = new Bitmap(cropWidth, cropHeight);
            // for cropinf image  
            Graphics g = Graphics.FromImage(_img);
            // create graphics  
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.CompositingQuality = CompositingQuality.HighQuality;
            //set image attributes  
            g.DrawImage(OriginalImage, 0, 0, rect, GraphicsUnit.Pixel);
            pictureBox1.Image = _img;
            pictureBox1.Width = _img.Width;
            pictureBox1.Height = _img.Height;
            PictureBoxLocation();
            saveCropButton.Enabled = true;
            //makeCropButton.Enabled = false;
        }

        /// <summary>
        /// A��o para salvar a imagem cortada
        /// </summary>
        private void saveCropButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
                saveCropButton.Enabled = false;

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Arquivos PNG (*.png)|*.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(dialog.FileName, ImageFormat.Png);
            }
        }

        /// <summary>
        /// Fun��o para mudar o incremento do domainUpDown, mas n�o est� funcionando
        /// </summary>
        private void BindDomainIUpDown()
        {
            for (int i = 1; i <= 999; i++)
            {
                resizeDomainUpDown.Items.Add(i);
            }
            resizeDomainUpDown.Text = "100";
        }

        /// <summary>
        /// A��o para realizar o redimensionamento da imagem
        /// </summary>
        private void resizeDomainUpDown_SelectedItemChanged(object sender, EventArgs e)
        {
            int percentage = 0;
            try
            {
                percentage = Convert.ToInt32(resizeDomainUpDown.Text);
                ModifiedImageSize = new Size((OriginalImageSize.Width * percentage) / 100, (OriginalImageSize.Height * percentage) / 100);
                //SetResizeInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Percentage");
                return;
            }
        }

        /// <summary>
        /// A��o para aplicar o redimensionamento
        /// </summary>
        private void okResizeButton_Click(object sender, EventArgs e)
        {
            Bitmap bm_source = new Bitmap(pictureBox1.Image);
            // Make a bitmap for the result.  
            Bitmap bm_dest = new Bitmap(Convert.ToInt32(ModifiedImageSize.Width), Convert.ToInt32(ModifiedImageSize.Height));
            // Make a Graphics object for the result Bitmap.  
            Graphics gr_dest = Graphics.FromImage(bm_dest);
            // Copy the source image into the destination bitmap.  
            gr_dest.DrawImage(bm_source, 0, 0, bm_dest.Width + 1, bm_dest.Height + 1);
            // Display the result.  
            pictureBox1.Image = bm_dest;
            pictureBox1.Width = bm_dest.Width;
            pictureBox1.Height = bm_dest.Height;
            PictureBoxLocation();
        }

        /// <summary>
        /// A��o para modificar o brilho da imagem
        /// </summary>
        private void brightnessTrackBar_Scroll(object sender, EventArgs e)
        {
            brightnessDomainUpDown.Text = brightnessTrackBar.Value.ToString();
            float value = brightnessTrackBar.Value * 0.01f;

            float[][] colorMatrixElements = {
                  new float[] {
                        1, 0, 0, 0, 0
                  },
                  new float[] {
                        0, 1, 0, 0, 0
                  },
                  new float[] {
                        0, 0, 1, 0, 0
                  },
                  new float[] {
                        0, 0, 0, 1, 0
                  },
                  new float[] {
                        value, value, value, 0, 1
                  }
            };

            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            Image _img = Img;
            Graphics _g = default(Graphics);
            Bitmap bm_dest = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
            _g = Graphics.FromImage(bm_dest);
            _g.DrawImage(_img, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
            pictureBox1.Image = bm_dest;

            if (applyBrightnessButton.Enabled == false)
            {
                //Img = bm_dest; Tentativa de adi��o de sobreposi��o do brilho ao contraste
            }

            applyBrightnessButton.Enabled = true;
        }

        /// <summary>
        /// A��o para aplica��o a modifica��o do brilho, mas ainda n�o est� funcionando
        /// </summary>
        private void applyBrightnessButton_Click(object sender, EventArgs e)
        {
            applyBrightnessButton.Enabled = false;
        }
        //Comentários
        /// <summary>
        /// A��o para modificar o contraste da imagem
        /// </summary>
        private void contrastTrackBar_Scroll(object sender, EventArgs e)
        {
            contrastDomainUpDown.Text = contrastTrackBar.Value.ToString();
            float value = contrastTrackBar.Value * 0.01f + 1; // Normalizar o valor entre 0 e 2
            float offset = -0.5f * (value - 1);

            float[][] colorMatrixElements = {
                new float[] { value, 0, 0, 0, 0 },
                new float[] { 0, value, 0, 0, 0 },
                new float[] { 0, 0, value, 0, 0 },
                new float[] { 0, 0, 0, 1, 0 },
                new float[] { offset, offset, offset, 0, 1 }
            };

            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            Image _img = Img;
            Graphics _g = default(Graphics);
            Bitmap bm_dest = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
            _g = Graphics.FromImage(bm_dest);
            _g.DrawImage(_img, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
            pictureBox1.Image = bm_dest;

            if (applyContrastButton.Enabled == false)
            {
                //Img = bm_dest; Tentativa de adi��o de sobreposi��o do contrate ao brilho
            }

            applyContrastButton.Enabled = true;
        }

        /// <summary>
        /// A��o para aplica��o a modifica��o do contraste, mas ainda n�o est� funcionando
        /// </summary>
        private void applyContrastButton_Click(object sender, EventArgs e)
        {
            applyContrastButton.Enabled = false;
        }

        /// <summary>
        /// A��o para rotacionar a imagem para a esquerda
        /// </summary>
        private void rotateLeftButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Refresh();
            imgStack.Push(pictureBox1.Image);
        }

        /// <summary>
        /// A��o para rotacionar a imagem para a direita
        /// </summary>
        private void rotateRightButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox1.Refresh();
        }

        /// <summary>
        /// A��o para rotacionar a imagem na horizonta
        /// </summary>
        private void rotateHorizontalButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureBox1.Refresh();
        }

        /// <summary>
        /// A��o para rotacionar a imagem na vertical
        /// </summary>
        private void rotateVerticalButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBox1.Refresh();
        }

        /// <summary>
        /// A��o para abrir o form respons�vel por buscar uma cor na imagem
        /// </summary>
        private void findColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorSearch colorSearch = new ColorSearch();
            colorSearch.Show();
        }

        /// <summary>
        /// A��o para abrir o form respons�vel por pegar a cor da imagem
        /// </summary>
        private void getColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetColor getColor = new GetColor();
            getColor.Show();
        }

        /// <summary>
        /// A��o para abrir o form respons�vel por exibir as propriedades da imagem
        /// </summary>
        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties properties = new Properties();
            properties.Show();
        }

        private PictureBox picImagem;
        private Bitmap imagemCarregada;
        private Stack<Image> imgStack = new Stack<Image>();

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Configura��es do OpenFileDialog
            openFileDialog1.Filter = "Arquivos de Imagem (*.png;*.jpg;*.jpeg;*.bmp)|*.png;*.jpg;*.jpeg;*.bmp";
            openFileDialog1.Title = "Selecionar Imagem";
            openFileDialog1.Multiselect = false;

            // Exibe o OpenFileDialog e verifica se o usu�rio selecionou um arquivo
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Obt�m o caminho completo do arquivo selecionado
                string caminhoDaImagem = openFileDialog1.FileName;

                // Carrega a imagem no controle PictureBox
                pictureBox1.Image = Image.FromFile(caminhoDaImagem);

                imgStack.Push(pictureBox1.Image);

                // Atualiza a vari�vel imagemCarregada com a imagem selecionada
                imagemCarregada = new Bitmap(caminhoDaImagem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private Bitmap RemoverChromaKey(Bitmap imagem)
        {
            if (imagem == null)
            {
                throw new ArgumentNullException(nameof(imagem), "A imagem n�o pode ser nula.");
            }

            Bitmap novaImagem = new Bitmap(imagem.Width, imagem.Height);

            Color chromaKey = Color.FromArgb(0, 255, 0); // Verde

            for (int y = 0; y < novaImagem.Height; y++)
            {
                for (int x = 0; x < novaImagem.Width; x++)
                {
                    Color pixelColor = imagem.GetPixel(x, y);

                    // Verifica a dist�ncia Euclidiana entre as cores
                    double distance = Math.Sqrt(Math.Pow(pixelColor.R - chromaKey.R, 2) +
                                                Math.Pow(pixelColor.G - chromaKey.G, 2) +
                                                Math.Pow(pixelColor.B - chromaKey.B, 2));

                    // Se a dist�ncia for maior que 100, copia a cor do pixel para a nova imagem
                    if (distance > 100)
                    {
                        novaImagem.SetPixel(x, y, pixelColor);
                    }
                }
            }

            return novaImagem;
        }


        private void CarregarImagem(Image imagem)
        {
            try
            {
                // armazena a imagem atual da PictureBox1 na pilha de imagens
                imgStack.Push(pictureBox1.Image);

                // exibe a nova imagem na PictureBox1
                pictureBox1.Image = imagem;

                // atualiza a vari�vel imagemAtual com a imagem carregada
                imagemAtual = imagem;
            }
            catch (Exception ex)
            {
                // exibe mensagem de erro em caso de falha ao carregar a imagem
                MessageBox.Show("Erro ao carregar a imagem: " + ex.Message);
            }
        }



















        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        Bitmap imagemOriginal;

        private Image imagemAtual;

        private void AdicionarTexto(string texto)
        {
            // verifica se h� uma imagem carregada
            if (pictureBox1.Image != null)
            {
                // cria um objeto Graphics a partir da imagem atual da PictureBox1
                Graphics g = Graphics.FromImage(pictureBox1.Image);

                // define uma fonte e um Brush para o texto a ser desenhado
                Font fonte = new Font("Arial", 24);
                Brush brush = new SolidBrush(Color.Black);

                // define a posi��o onde o texto ser� desenhado
                Point posicao = new Point(50, 50);

                // desenha o texto na imagem
                g.DrawString(texto, fonte, brush, posicao);

                // atualiza a PictureBox1 com a imagem modificada
                pictureBox1.Refresh();
            }
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                // Obt�m a imagem carregada no PictureBox
                Bitmap imagemCarregada = new Bitmap(pictureBox1.Image);

                // Aplica a remo��o do Chroma Key na imagem carregada
                Bitmap imagemSemChromaKey = RemoverChromaKey(imagemCarregada);

                // Exibe a imagem resultante na tela
                pictureBox1.Image = imagemSemChromaKey;
            }
            else
            {
                MessageBox.Show("Carregue uma imagem antes de remover o Chroma Key.");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // verifica se h� pelo menos duas imagens na pilha
            if (imgStack.Count >= 1)
            {
                // remove a imagem atual da PictureBox1
                pictureBox1.Image = null;

                // exibe a �ltima imagem carregada na PictureBox1
                Image ultimaImagem = imgStack.Peek();
                pictureBox1.Image = ultimaImagem;

                // armazena a imagem que acabou de ser exibida em uma nova vari�vel Image
                Image imagemPenultima = pictureBox1.Image;

                // remove a imagem que acabou de ser exibida da pilha
                //imgStack.Pop();

                // exibe a pen�ltima imagem carregada na PictureBox1
                pictureBox1.Image = imgStack.Peek();

                // armazena a imagem pen�ltima como a imagem atual da PictureBox1
                imagemAtual = pictureBox1.Image;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            AdicionarTexto(texto);
            imgStack.Push(pictureBox1.Image);
        }

        private void AdicionarImagem(Image imagem, float escala)
        {
            // verifica se há uma imagem carregada
            if (pictureBox1.Image != null)
            {
                // cria um objeto Graphics a partir da imagem atual da PictureBox1
                Graphics g = Graphics.FromImage(pictureBox1.Image);

                // define a posição e a escala da imagem a ser adicionada
                int posX = 50;
                int posY = 50;
                int largura = (int)(imagem.Width * escala);
                int altura = (int)(imagem.Height * escala);

                // desenha a imagem na posição e escala desejadas
                g.DrawImage(imagem, posX, posY, largura, altura);

                // atualiza a PictureBox1 com a imagem modificada
                pictureBox1.Refresh();
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            // carrega a imagem a ser adicionada
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de imagem|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image imagem = Image.FromFile(openFileDialog.FileName);

                // adiciona a imagem na PictureBox1 com escala de 0.2 (20%)
                AdicionarImagem(imagem, 0.2f);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // verifica se há uma imagem carregada
            if (pictureBox1.Image != null)
            {
                // cria um objeto SaveFileDialog para selecionar o local onde a imagem será salva
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Arquivo JPEG (*.jpg)|*.jpg|Arquivo PNG (*.png)|*.png|Arquivo BMP (*.bmp)|*.bmp";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // salva a imagem no formato selecionado
                    switch (saveFileDialog.FilterIndex)
                    {
                        case 1:
                            pictureBox1.Image.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                            break;
                        case 2:
                            pictureBox1.Image.Save(saveFileDialog.FileName, ImageFormat.Png);
                            break;
                        case 3:
                            pictureBox1.Image.Save(saveFileDialog.FileName, ImageFormat.Bmp);
                            break;
                    }
                }
            }
        }




        /* private void AlterarGamma(float gamma)
         {
             if (pictureBox1.Image != null)
             {
                 Image imagem = pictureBox1.Image;

                 // Define os valores da matriz de cores para alterar o Gamma
                 float[][] cores = {
             new float[] {gamma, 0, 0, 0, 0},
             new float[] {0, gamma, 0, 0, 0},
             new float[] {0, 0, gamma, 0, 0},
             new float[] {0, 0, 0, 1, 0},
             new float[] {0, 0, 0, 0, 1}
         };

                 // Cria um objeto ImageAttributes e define a matriz de cores
                 ImageAttributes atributos = new ImageAttributes();
                 atributos.SetColorMatrix(new ColorMatrix(cores), ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                 // Cria um objeto Graphics a partir da imagem atual da PictureBox1
                 Graphics g = Graphics.FromImage(imagem);

                 // Desenha a imagem com as alterações de Gamma
                 g.DrawImage(imagem, new Rectangle(0, 0, imagem.Width, imagem.Height), 0, 0, imagem.Width, imagem.Height, GraphicsUnit.Pixel, atributos);

                 // Atualiza a PictureBox1 com a imagem modificada
                 pictureBox1.Image = imagem;
             }
         }



         private void trackBar2_Scroll(object sender, EventArgs e)
         {
             float gamma = trackBar2.Value / 10f;
             AlterarGamma(gamma);
         }
        */









        //======================================FUN��ES MODIFICADAS======================================================//




        //A��o pode ser removida
        /*private void cropToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (xPositionCrop.Text.Length > 0 && yPositionCrop.Text.Length > 0 && widthCrop.Text.Length > 0 && heightCrop.Text.Length > 0)
                {
                    int xCrop = Convert.ToInt32(xPositionCrop.Text);
                    int yCrop = Convert.ToInt32(yPositionCrop.Text);
                    int wCrop = Convert.ToInt32(widthCrop.Text);
                    int hCrop = Convert.ToInt32(heightCrop.Text);

                    if (pictureBox1.Image.Width > xCrop && pictureBox1.Image.Height > yCrop && pictureBox1.Image.Width > wCrop && pictureBox1.Image.Height > hCrop)
                    {
                        //setar essas informa��es pelo form (pos em X da imagem, pos Y da imagem,tamanho do crop altura, tamanho do crop largura)
                        Rectangle rect = new Rectangle(xCrop, yCrop, wCrop, hCrop);
                        pictureBox1.Image = CropImage(pictureBox1.Image, rect);
                        saveCropButton.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Valores informados n�o s�o acess�veis a imagem usada. Verifique se a pasi��o de corte e o tamanho n�o ultrapassam o tamanho da imagem");
                    }
                }
                else
                {
                    MessageBox.Show("Valores para corte n�o informados");
                }
            }
            else
            {
                MessageBox.Show("Imagem n�o foi aberta");
            }
        }
        //Op��o alternativa. Pode ser removido
        private static Image CropImage(Image img, Rectangle cropArea)
        {
            Bitmap bmpImage = new Bitmap(img);
            return bmpImage.Clone(cropArea, bmpImage.PixelFormat);
        }*/

        //Necess�rio corrigir soma de brilho. 
        /*public static Bitmap AdjustBrightness(Bitmap image, float brightnessAdjustment)
        {
            Bitmap adjustedImage = new Bitmap(image.Width, image.Height);

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    int r = Clamp((int)(pixelColor.R + brightnessAdjustment), 0, 255);
                    int g = Clamp((int)(pixelColor.G + brightnessAdjustment), 0, 255);
                    int b = Clamp((int)(pixelColor.B + brightnessAdjustment), 0, 255);

                    adjustedImage.SetPixel(x, y, Color.FromArgb(pixelColor.A, r, g, b));
                }
            }

            return adjustedImage;
        }

        //Necess�rio corrigir soma de contraste.
        public static Bitmap AdjustContrast(Bitmap image, float contrastLevel)
        {
            Bitmap adjustedImage = new Bitmap(image.Width, image.Height);
            contrastLevel = (100.0f + contrastLevel) / 100.0f;
            contrastLevel *= contrastLevel;

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    float r = pixelColor.R / 255.0f;
                    float g = pixelColor.G / 255.0f;
                    float b = pixelColor.B / 255.0f;
                    r = (((r - 0.5f) * contrastLevel) + 0.5f) * 255.0f;
                    g = (((g - 0.5f) * contrastLevel) + 0.5f) * 255.0f;
                    b = (((b - 0.5f) * contrastLevel) + 0.5f) * 255.0f;

                    adjustedImage.SetPixel(x, y, Color.FromArgb(pixelColor.A, Clamp((int)r, 0, 255), Clamp((int)g, 0, 255), Clamp((int)b, 0, 255)));
                }
            }

            return adjustedImage;
        }

        private static int Clamp(int value, int min, int max)
        {
            return (value < min) ? min : (value > max) ? max : value;
        }

        private void changeGlowButton_Click(object sender, EventArgs e)
        {
            int brightnessAdjustment = Convert.ToInt32(changeGlowTextBox.Text);

            Bitmap originalImage = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = AdjustBrightness(originalImage, brightnessAdjustment);

        }

        private void changeContrastButton_Click(object sender, EventArgs e)
        {
            int contrastAdjustment = Convert.ToInt32(changeContrastTextBox.Text);

            Bitmap originalImage = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = AdjustContrast(originalImage, contrastAdjustment);
        }*/
    }
}