using System.Security.Cryptography.X509Certificates;
using System.Drawing.Imaging;
using System.Text;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Numerics;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using IMAVD_IMAGE_Proj.Controller;

namespace IMAVD_IMAGE_Proj
{
    public partial class Principal : Form
    {
        /// <summary>
        /// Vari�veis para armazenamento de informa��es padr�es da imagem
        /// </summary>
        private Image Img;
        private Image ModifiedImg;
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

        //Variável para armazenamento de pilha de alterações
        private LinkedList<Image> imgStack;
        private LinkedList<Image> redoImgStack;

        public Principal()
        {
            InitializeComponent();
            imgStack = new LinkedList<Image>();
            redoImgStack = new LinkedList<Image>();
            picImagem = new PictureBox();
            ControlPanel1.Enabled = false;
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
        /// Ação de abertura de image, obtendo e atribuindo de propriedades da mesma �s vari�veis globais
        /// </summary>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dlg = new OpenFileDialog();
            Dlg.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif)|*.jpg;*.jpeg;*.png;*.gif";
            Dlg.Title = "Select image";
            if (Dlg.ShowDialog() == DialogResult.OK)
            {
                makeSelectionButton.Enabled = true;
                Img = Image.FromFile(Dlg.FileName);
                ModifiedImg = Img;
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

                ControlPanel1.Enabled = true;
                setDimensionsResize(pictureBox2.Image);

                returnButton.Enabled = true;
                saveImageButton.Enabled = true;
                insertImageStack(Img);
            }
        }

        /// <summary>
        /// Fun��o para carregamento de informa��es da imagem a serem utilizados em outras fun��es
        /// </summary>
        private void LoadImage()
        {
            int imgWidth = Img.Width;
            int imgHeight = Img.Height;
            //Picture Box 1
            pictureBox1.Width = imgWidth;
            pictureBox1.Height = imgHeight;
            pictureBox1.Image = Img;

            //Picture Box 2
            pictureBox2.Width = imgWidth;
            pictureBox2.Height = imgHeight;
            pictureBox2.Image = Img;
            PictureBoxLocation1();
            PictureBoxLocation2();
            OriginalImageSize = new Size(imgWidth, imgHeight);
            //SetResizeInfo();
        }

        /// <summary>
        /// Fun��o para determinar a posi��o, no painel, da imagem carregada
        /// </summary>
        private void PictureBoxLocation1()
        {
            int _x = (panelPictureBox1.Width > pictureBox1.Width) ?
                (panelPictureBox1.Width - pictureBox1.Width) / 2 :
                (pictureBox1.Width - panelPictureBox1.Width) / 2;

            int _y = (panelPictureBox1.Height > pictureBox1.Height) ?
                (panelPictureBox1.Height - pictureBox1.Height) / 2 :
                (pictureBox1.Height - panelPictureBox1.Height) / 2;

            pictureBox1.Location = new Point(_x, _y);
        }

        private void PictureBoxLocation2()
        {
            int _x = (panelPictureBox2.Width > pictureBox2.Width) ?
                (panelPictureBox2.Width - pictureBox2.Width) / 2 :
                 (pictureBox2.Width - panelPictureBox2.Width) / 2;

            int _y = (panelPictureBox2.Height > pictureBox2.Height) ?
                (panelPictureBox2.Height - pictureBox2.Height) / 2 :
                (pictureBox2.Height - panelPictureBox2.Height) / 2;

            pictureBox2.Location = new Point(_x, _y);
        }

        /// <summary>
        /// A��o para converter a cor da imagem para vermelho
        /// </summary>
        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //verificando se a imagem foi aberta
            if (pictureBox2.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox2.Image);
                int width = pictureBox2.Image.Width;
                int height = pictureBox2.Image.Height;

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
                insertImageStack(pictureBox2.Image);
                ModifiedImg = img;
            }
        }

        /// <summary>
        /// A��o para converter a cor da imagem para verde
        /// </summary>
        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //verificando se a imagem foi aberta
            if (pictureBox2.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox2.Image);
                int width = pictureBox2.Image.Width;
                int height = pictureBox2.Image.Height;

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
                insertImageStack(pictureBox2.Image);
                ModifiedImg = img;
            }
        }

        /// <summary>
        /// A��o para converter a cor da imagem para azul
        /// </summary>
        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //verificando se a imagem foi aberta
            if (pictureBox2.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox2.Image);
                int width = pictureBox2.Image.Width;
                int height = pictureBox2.Image.Height;

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
                insertImageStack(pictureBox2.Image);
                ModifiedImg = img;
            }
        }

        /// <summary>
        /// A��o para inverter a cor da imagem
        /// </summary> 
        private void invertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //verificando se a imagem foi aberta
            if (pictureBox2.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox2.Image);
                int width = pictureBox2.Image.Width;
                int height = pictureBox2.Image.Height;

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
                insertImageStack(pictureBox2.Image);
                ModifiedImg = img;
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
            Bitmap OriginalImage = new Bitmap(pictureBox2.Image, pictureBox2.Width, pictureBox2.Height);
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
            pictureBox2.Image = _img;
            pictureBox2.Width = _img.Width;
            pictureBox2.Height = _img.Height;
            PictureBoxLocation2();
            insertImageStack(pictureBox2.Image);
            setDimensionsResize(pictureBox2.Image);
            ModifiedImg = pictureBox2.Image;

            saveCropButton.Enabled = true;
            makeSelectionButton.Enabled = true;
            makeCropButton.Enabled = false;
        }

        /// <summary>
        /// A��o para salvar a imagem cortada
        /// </summary>
        private void saveCropButton_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image == null)
                saveCropButton.Enabled = false;

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Arquivos PNG (*.png)|*.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image.Save(dialog.FileName, ImageFormat.Png);
            }
        }


        /// <summary>
        /// A��o para aplicar o redimensionamento
        /// </summary>
        private void okResizeButton_Click(object sender, EventArgs e)
        {
            int percentage = 0;
            try
            {
                percentage = Convert.ToInt32(resizeDomainUpDown.Text);
                percentage = (percentage < 1) ? 1 : percentage;
                if (percentage == 100) return;
                ModifiedImageSize = new Size((OriginalImageSize.Width * percentage) / 100, (OriginalImageSize.Height * percentage) / 100);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Percentage");
                return;
            }

            if (percentageResize.Checked)
            {
                Bitmap bm_source = new Bitmap(pictureBox2.Image);
                // Make a bitmap for the result.  
                Bitmap bm_dest = new Bitmap(Convert.ToInt32(ModifiedImageSize.Width), Convert.ToInt32(ModifiedImageSize.Height));
                // Make a Graphics object for the result Bitmap.  
                Graphics gr_dest = Graphics.FromImage(bm_dest);
                // Copy the source image into the destination bitmap.  
                gr_dest.DrawImage(bm_source, 0, 0, bm_dest.Width + 1, bm_dest.Height + 1);
                // Display the result.  
                pictureBox2.Image = bm_dest;
                pictureBox2.Width = bm_dest.Width;
                pictureBox2.Height = bm_dest.Height;
                PictureBoxLocation2();
                insertImageStack(pictureBox2.Image);
                setDimensionsResize(pictureBox2.Image);
                ModifiedImg = pictureBox2.Image;
            }
        }

        /// <summary>
        /// A��o para modificar o brilho da imagem
        /// </summary>
        private void brightnessTrackBar_Scroll(object sender, EventArgs e)
        {
            brightnessBox.Text = brightnessTrackBar.Value.ToString();
            setBrightness();
        }

        /// <summary>
        /// A��o para aplica��o a modifica��o do brilho, mas ainda n�o est� funcionando
        /// </summary>
        private void applyBrightnessButton_Click(object sender, EventArgs e)
        {
            applyBrightnessButton.Enabled = false;
            ModifiedImg = pictureBox2.Image;
            insertImageStack(pictureBox2.Image);
        }

        private void setBrightness()
        {
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

            Image _img = ModifiedImg;
            Graphics _g = default(Graphics);
            Bitmap bm_dest = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
            _g = Graphics.FromImage(bm_dest);
            _g.DrawImage(_img, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
            pictureBox2.Image = bm_dest;

            applyBrightnessButton.Enabled = true;
        }

        //Comentários
        /// <summary>
        /// A��o para modificar o contraste da imagem
        /// </summary>
        private void contrastTrackBar_Scroll(object sender, EventArgs e)
        {
            contrastBox.Text = contrastTrackBar.Value.ToString();
            setContrast();
        }

        /// <summary>
        /// A��o para aplica��o a modifica��o do contraste, mas ainda n�o est� funcionando
        /// </summary>
        private void applyContrastButton_Click(object sender, EventArgs e)
        {
            applyContrastButton.Enabled = false;
            ModifiedImg = pictureBox2.Image;
            insertImageStack(pictureBox2.Image);
        }

        private void setContrast()
        {
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

            Image _img = ModifiedImg;
            Graphics _g = default(Graphics);
            Bitmap bm_dest = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
            _g = Graphics.FromImage(bm_dest);
            _g.DrawImage(_img, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
            pictureBox2.Image = bm_dest;

            applyContrastButton.Enabled = true;
        }

        /// <summary>
        /// A��o para rotacionar a imagem para a esquerda
        /// </summary>
        private void rotateLeftButton_Click(object sender, EventArgs e)
        {
            Image image = pictureBox2.Image;
            image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox2.Image = image;
            PictureBoxLocation2();
            insertImageStack(pictureBox2.Image);
            ModifiedImg = pictureBox2.Image;
        }

        /// <summary>
        /// A��o para rotacionar a imagem para a direita
        /// </summary>
        private void rotateRightButton_Click(object sender, EventArgs e)
        {
            Image image = pictureBox2.Image;
            image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox2.Image = image;
            PictureBoxLocation2();
            insertImageStack(pictureBox2.Image);
            ModifiedImg = pictureBox2.Image;
        }

        /// <summary>
        /// A��o para rotacionar a imagem na horizonta
        /// </summary>
        private void rotateHorizontalButton_Click(object sender, EventArgs e)
        {
            Image image = pictureBox2.Image;
            image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureBox2.Image = image;
            PictureBoxLocation2();
            insertImageStack(pictureBox2.Image);
            ModifiedImg = pictureBox2.Image;
        }

        /// <summary>
        /// A��o para rotacionar a imagem na vertical
        /// </summary>
        private void rotateVerticalButton_Click(object sender, EventArgs e)
        {
            Image image = pictureBox2.Image;
            image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBox2.Image = image;
            PictureBoxLocation2();
            insertImageStack(pictureBox2.Image);
            ModifiedImg = pictureBox2.Image;
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
            Information properties = new Information();
            properties.Show();
        }

        private PictureBox picImagem;
        private Bitmap imagemCarregada;


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
                //insertImageStack(pictureBox1.Image);

                // Atualiza a vari�vel imagemCarregada com a imagem selecionada
                imagemCarregada = new Bitmap(caminhoDaImagem);
            }
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
                //imgStack.Push(pictureBox1.Image);

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



        private void button4_Click_1(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            AdicionarTexto(texto);
            //imgStack.Push(pictureBox1.Image);
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


        private void insertImageStack(Image image)
        {
            if (imgStack.Count < 10)
            {
                imgStack.AddLast(image);
            }
            else
            {
                imgStack.RemoveFirst();
                imgStack.AddLast(image);
            }
            clearRedo();
            if (!undoButton.Enabled)
                undoButton.Enabled = true;
        }

        private void percentageResize_CheckedChanged(object sender, EventArgs e)
        {
            manualResize.Checked = false;
        }

        private void manualResize_CheckedChanged(object sender, EventArgs e)
        {
            percentageResize.Checked = false;
        }

        private void manualResizeApply_Click(object sender, EventArgs e)
        {
            if (manualResize.Checked)
            {
                int width = int.Parse(widthResize.Text);
                width = (width == 0) ? ModifiedImg.Width : width;
                int height = int.Parse(heightResize.Text);
                height = (height == 0) ? ModifiedImg.Height : height;

                if ((width == ModifiedImg.Width) && (height == ModifiedImg.Height)) return;

                Bitmap bm_source = new Bitmap(pictureBox2.Image);
                // Make a bitmap for the result.  
                Bitmap bm_dest = new Bitmap(Convert.ToInt32(width), Convert.ToInt32(height));
                // Make a Graphics object for the result Bitmap.  
                Graphics gr_dest = Graphics.FromImage(bm_dest);
                // Copy the source image into the destination bitmap.  
                gr_dest.DrawImage(bm_source, 0, 0, bm_dest.Width + 1, bm_dest.Height + 1);
                // Display the result.  
                pictureBox2.Image = bm_dest;
                pictureBox2.Width = bm_dest.Width;
                pictureBox2.Height = bm_dest.Height;
                PictureBoxLocation2();
                insertImageStack(pictureBox2.Image);
                setDimensionsResize(pictureBox2.Image);
                widthResize.Text = width.ToString();
                heightResize.Text = height.ToString();
                ModifiedImg = pictureBox2.Image;
            }
        }

        private void setDimensionsResize(Image image)
        {
            widthResize.Text = image.Width.ToString();
            heightResize.Text = image.Height.ToString();
        }

        private void widthResize_TextChanged(object sender, EventArgs e)
        {
            int width = (widthResize.Text.Equals("")) ? ModifiedImg.Width :
                    int.Parse(widthResize.Text);
            if (proportionalResize.Checked && widthResize.Focused)
            {
                int height = (width * ModifiedImg.Height) / ModifiedImg.Width;
                heightResize.Text = height.ToString();
            }
            widthResize.Text = width.ToString();
        }

        private void widthResize_KeyPress(object sender, KeyPressEventArgs e)
        {
            restrictedNumbers(sender, e);
        }

        private void restrictedNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void heightResize_TextChanged(object sender, EventArgs e)
        {
            int height = (heightResize.Text.Equals("")) ? ModifiedImg.Height :
                   int.Parse(heightResize.Text);
            if (proportionalResize.Checked && heightResize.Focused)
            {
                int width = (height * ModifiedImg.Width) / ModifiedImg.Height;
                widthResize.Text = width.ToString();
            }
            heightResize.Text = height.ToString();
        }

        private void heightResize_KeyPress(object sender, KeyPressEventArgs e)
        {
            restrictedNumbers(sender, e);
        }

        private void redGammaBar_Scroll(object sender, EventArgs e)
        {
            float redValue = redGammaBar.Value / 10.0f;
            redGammaBox.Text = redValue.ToString();
            setGamma();
        }

        private void greenGammaBar_Scroll(object sender, EventArgs e)
        {
            float greenValue = greenGammaBar.Value / 10.0f;
            greenGammaBox.Text = greenValue.ToString();
            setGamma();
        }

        private void blueGammaBar_Scroll(object sender, EventArgs e)
        {
            float blueValue = blueGammaBar.Value / 10.0f;
            blueGammaBox.Text = blueValue.ToString();
            setGamma();
        }

        private void setGamma()
        {
            //Dados da Imagem
            int width = ModifiedImg.Width;
            int height = ModifiedImg.Height;
            Bitmap image = new Bitmap(ModifiedImg);

            //Dados de Alteração Gama
            float redGamma = redGammaBar.Value / 10.0f;
            float greenGamma = greenGammaBar.Value / 10.0f;
            float blueGamma = blueGammaBar.Value / 10.0f;

            //Fórmula de alteração
            BitmapData srcData = image.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb
                );
            int bytes = srcData.Stride * srcData.Height;
            byte[] buffer = new byte[bytes];
            byte[] result = new byte[bytes];
            Marshal.Copy(srcData.Scan0, buffer, 0, bytes);
            image.UnlockBits(srcData);
            int current = 0;
            double c = 1d;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    current = y * srcData.Stride + x * 4;

                    //Aplicação ao Red
                    double rangeRed = (double)buffer[current] / 255;
                    double correctionRed = c * Math.Pow(rangeRed, redGamma);
                    result[current] = (byte)(correctionRed * 255);

                    //Aplicação ao Green
                    double rangeGreen = (double)buffer[current + 1] / 255;
                    double correctionGreen = c * Math.Pow(rangeGreen, greenGamma);
                    result[current + 1] = (byte)(correctionGreen * 255);

                    //Aplicação ao Blue
                    double rangeBlue = (double)buffer[current + 2] / 255;
                    double correctionBlue = c * Math.Pow(rangeBlue, blueGamma);
                    result[current + 2] = (byte)(correctionBlue * 255);

                    //Aplicação ao Alfa
                    result[current + 3] = 255;


                }
            }
            Bitmap resImg = new Bitmap(width, height);
            BitmapData resData = resImg.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb
                );
            Marshal.Copy(result, 0, resData.Scan0, bytes);
            resImg.UnlockBits(resData);
            pictureBox2.Image = (Image)resImg;

        }

        private void applyGamma_Click(object sender, EventArgs e)
        {
            ModifiedImg = pictureBox2.Image;
            insertImageStack(pictureBox2.Image);
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && makeSelectionButton.Enabled == false)
            {
                Cursor = Cursors.Cross;
                cropX = e.X;
                cropY = e.Y;
                cropPen = new Pen(Color.Black, 1);
                cropPen.DashStyle = DashStyle.DashDotDot;
            }
            pictureBox2.Refresh();
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox2.Image == null)
                return;
            if (e.Button == MouseButtons.Left && makeSelectionButton.Enabled == false)
            {
                pictureBox2.Refresh();
                cropWidth = e.X - cropX;
                cropHeight = e.Y - cropY;
                pictureBox2.CreateGraphics().DrawRectangle(cropPen, cropX, cropY, cropWidth, cropHeight);
                makeCropButton.Enabled = true;
            }
        }


        private void returnButton_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null)
            {
                pictureBox2.Image = pictureBox1.Image;
                PictureBoxLocation2();
                ModifiedImg = pictureBox2.Image;
                clearRedo();
                imgStack.Clear();
                imgStack.AddLast(ModifiedImg);
                undoButton.Enabled = false;
            }
        }

        private void saveImageButton_Click(object sender, EventArgs e)
        {
            // verifica se há uma imagem carregada
            if (pictureBox2.Image != null)
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
                            pictureBox2.Image.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                            break;
                        case 2:
                            pictureBox2.Image.Save(saveFileDialog.FileName, ImageFormat.Png);
                            break;
                        case 3:
                            pictureBox2.Image.Save(saveFileDialog.FileName, ImageFormat.Bmp);
                            break;
                    }
                }
            }
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            // verifica se h� pelo menos duas imagens na pilha
            if (imgStack.Count >= 2)
            {
                //Pega a última image e depois a remove
                Image imageLast = imgStack.Last();
                imgStack.RemoveLast();

                //adiciona a última imagem ao Redo e utiliza a nova última imagem
                redoImgStack.AddLast(imageLast);
                Image newLastImage = imgStack.Last();
                pictureBox2.Image = newLastImage;
                PictureBoxLocation2();
                ModifiedImg = pictureBox2.Image;


                if (imgStack.Count == 1)
                {
                    undoButton.Enabled = false;
                }
                redoButton.Enabled = true;
            }

        }

        private void redoButton_Click(object sender, EventArgs e)
        {
            if (redoImgStack.Count >= 1)
            {
                //Pega a última image e depois a remove
                Image imageLast = redoImgStack.Last();
                redoImgStack.RemoveLast();

                //adiciona a última imagem ao Undo e utiliza a nova última imagem
                imgStack.AddLast(imageLast);
                pictureBox2.Image = imageLast;
                PictureBoxLocation2();
                ModifiedImg = pictureBox2.Image;


                if (redoImgStack.Count == 0)
                {
                    redoButton.Enabled = false;
                }
                undoButton.Enabled = true;
            }
        }

        private void clearRedo()
        {
            if (redoImgStack.Count >= 1)
            {
                redoImgStack.Clear();

                redoButton.Enabled = false;
            }
        }

        private void fourBoxShape_Click(object sender, EventArgs e)
        {
            int margin = 15;

            // Calcula a largura e altura de cada área
            Image image = pictureBox2.Image;
            int width = image.Width / 2;
            int height = image.Height / 2;

            Image[] dividedImages = new Image[4];

            for (int i = 0; i < 4; i++)
            {
                // Cria uma nova área de imagem com a largura e altura calculadas
                Bitmap dividedBitmap = new Bitmap(width, height);
                dividedBitmap.SetResolution(image.HorizontalResolution, image.VerticalResolution);

                // Cria um objeto Graphics a partir da nova área de imagem
                using (Graphics graphics = Graphics.FromImage(dividedBitmap))
                {
                    // Define a área de destino para a cópia da porção da imagem original
                    int x = (i % 2) * (width);
                    int y = (i / 2) * (height);
                    Rectangle destinationRect = new Rectangle(0, 0, width, height);

                    // Define a área de origem para a cópia da porção da imagem original
                    Rectangle sourceRect = new Rectangle(x, y, width, height);

                    // Copia a porção da imagem original para a nova área de imagem
                    graphics.DrawImage(image, destinationRect, sourceRect, GraphicsUnit.Pixel);
                }

                dividedImages[i] = dividedBitmap;
            }

            // Cria uma nova imagem composta com a largura e altura calculadas
            int compositeWidth = (width + margin) * 2 - margin;
            int compositeHeight = (height + margin) * 2 - margin;
            Bitmap compositeImage = new Bitmap(compositeWidth, compositeHeight);
            compositeImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            // Cria um objeto Graphics a partir da imagem composta
            using (Graphics graphics = Graphics.FromImage(compositeImage))
            {
                // Define o fundo do Graphics com uma cor de fundo, se necessário
                graphics.Clear(Color.White);

                // Desenha as quatro imagens divididas na imagem composta, com a margem
                for (int i = 0; i < 4; i++)
                {
                    int x = (i % 2) * (width + margin);
                    int y = (i / 2) * (height + margin);

                    graphics.DrawImage(dividedImages[i], x, y);
                }
            }
            // Define a imagem composta como a imagem exibida no PictureBox
            pictureBox2.Image = compositeImage;
            PictureBoxLocation2();
            insertImageStack(pictureBox2.Image);
            ModifiedImg = pictureBox2.Image;
        }

        private void twoRectangleShape_Click(object sender, EventArgs e)
        {
            int margin = 15;

            // Calcula a largura e altura de cada área
            Image image = pictureBox2.Image;
            int width = image.Width;
            int height = image.Height / 2;

            Image[] dividedImages = new Image[2];

            for (int i = 0; i < 2; i++)
            {
                // Cria uma nova área de imagem com a largura e altura calculadas
                Bitmap dividedBitmap = new Bitmap(width, height);
                dividedBitmap.SetResolution(image.HorizontalResolution, image.VerticalResolution);

                // Cria um objeto Graphics a partir da nova área de imagem
                using (Graphics graphics = Graphics.FromImage(dividedBitmap))
                {
                    // Define a área de destino para a cópia da porção da imagem original
                    int x = 0;
                    int y = i * height;
                    Rectangle destinationRect = new Rectangle(0, 0, width, height);

                    // Define a área de origem para a cópia da porção da imagem original
                    Rectangle sourceRect = new Rectangle(x, y, width, height);

                    // Copia a porção da imagem original para a nova área de imagem
                    graphics.DrawImage(image, destinationRect, sourceRect, GraphicsUnit.Pixel);
                }

                dividedImages[i] = dividedBitmap;
            }

            // Cria uma nova imagem composta com a largura e altura calculadas
            int compositeWidth = width;
            int compositeHeight = (height + margin) * 2 - margin;
            Bitmap compositeImage = new Bitmap(compositeWidth, compositeHeight);
            compositeImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            // Cria um objeto Graphics a partir da imagem composta
            using (Graphics graphics = Graphics.FromImage(compositeImage))
            {
                // Define o fundo do Graphics com uma cor de fundo, se necessário
                graphics.Clear(Color.White);

                // Desenha as quatro imagens divididas na imagem composta, com a margem
                for (int i = 0; i < 2; i++)
                {
                    int x = 0;
                    int y = i * (height + margin);

                    graphics.DrawImage(dividedImages[i], x, y);
                }
            }
            // Define a imagem composta como a imagem exibida no PictureBox
            pictureBox2.Image = compositeImage;
            PictureBoxLocation2();
            insertImageStack(pictureBox2.Image);
            ModifiedImg = pictureBox2.Image;
        }

        private void triangleTopShape_Click(object sender, EventArgs e)
        {
            //Triângulo canto superior esquerdo
            Image image = pictureBox2.Image;
            int width = image.Width;
            int height = image.Height;

            // Define as coordenadas dos vértices dos triângulos
            Point[] trianglePoints = new Point[]
            {
            new Point(width, height),
            new Point(0, height),
            new Point(width, 0)
            };

            drawTriangles(image, trianglePoints);

        }

        private void drawTriangles(Image image, Point[] trianglePoints)
        {
            // Criação do bitmap para exibir a imagem recortada
            Bitmap mergedImage = new Bitmap(image.Width, image.Height);
            mergedImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);


            //Criação dos Graphics para desenhar no Bitmap
            using (Graphics graphics = Graphics.FromImage(mergedImage))
            {
                // Desenho da imagem original no bitmap
                graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height));
                // Desenho dos triângulos no bitmap
                graphics.FillPolygon(Brushes.White, trianglePoints);

            }

            pictureBox2.Image = mergedImage;
            PictureBoxLocation2();
            insertImageStack(pictureBox2.Image);
            ModifiedImg = pictureBox2.Image;
        }

        private void triangleBottomShape_Click(object sender, EventArgs e)
        {
            //Triângulo canto superior esquerdo
            Image image = pictureBox2.Image;
            int width = image.Width;
            int height = image.Height;

            // Define as coordenadas dos vértices dos triângulos
            Point[] trianglePoints = new Point[]
            {
            new Point(0,0),
            new Point(width,0),
            new Point(0, height)
            };

            drawTriangles(image, trianglePoints);
        }

        private void verticalMultiply_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void horizontalMultiply_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void verticalMultiply_Leave(object sender, EventArgs e)
        {
            if (verticalMultiply.Text.Equals(""))
                verticalMultiply.Text = "1";
        }

        private void horizontalMultiply_Leave(object sender, EventArgs e)
        {
            if (horizontalMultiply.Text.Equals(""))
                horizontalMultiply.Text = "1";
        }

        private void applyMultiply_Click(object sender, EventArgs e)
        {
            int N = int.Parse(verticalMultiply.Text);
            N = (N == 0) ? 1 : N;
            int K = int.Parse(horizontalMultiply.Text);
            K = (K == 0) ? 1 : K;

            if ((N == 1) && (K == 1)) return;

            Image image = pictureBox2.Image;
            int width = image.Width / K;
            width = (width < 2) ? 2 : width;

            int height = image.Height / N;
            height = (height<2) ? 2 : height;


            Bitmap frameImage = new Bitmap(image.Width, image.Height);
            frameImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using(Graphics graphics = Graphics.FromImage(frameImage))
            {
                for(int i=0; i<N; i++)
                {
                    for(int j=0; j<K; j++)
                    {
                        graphics.DrawImage(image, j * width, i * height, width, height);
                    }
                }
            }

            pictureBox2.Image = frameImage;
            PictureBoxLocation2();
            insertImageStack(pictureBox2.Image);
            ModifiedImg = pictureBox2.Image;
        }
    }
}